using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ClientApiWrapper;
using IPS.ClientApi.Messages;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace ClientApiExample
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test_FormClosing);
        }


        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }




        private async void btnSubmitJson_Click(object sender, EventArgs e)
        {

            var sw = new Stopwatch();
            sw.Start();

            lblJson.Text = "Reading XML.";
            string account = File.ReadAllText(@"..\..\example.json");

            lblJson.Text = "Deserialzing to Account object.";
            var newAccount = JsonConvert.DeserializeObject<Account>(account);

            //take care that the "key field" value exists and it is typed in camelCase if using JSON, TitleCase if using XML

            var task =
                ClientApiWrapper.Controller.PostAccount(newAccount, "Account", Properties.Settings.Default.ListId,
                    Properties.Settings.Default.AuthKey, "contactId", Controller.SubmitDataType.Json, "NASA");

            lblJson.Text = "Waiting for server response.";
            var newAccountResponse = await task;

            sw.Stop();

            lblJson.Text = String.Format("Server responded: {0}, view ApiResponse object for full details. Speed {1}", newAccountResponse, sw.ElapsedMilliseconds);

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {

            //var sw = new Stopwatch();
            //sw.Start();

            //lblXml.Text = "Reading XML.";
            //string account = File.ReadAllText(@"..\..\example.xml");

            //lblXml.Text = "Deserialzing to Account object.";
            //var newAccount = Helpers.FromXmlString<Account>(account);

            //var task =
            //    ClientApiWrapper.Controller.PostAccount(newAccount, Properties.Settings.Default.AccountId,
            //        Properties.Settings.Default.Username, Properties.Settings.Default.Password, Controller.SubmitDataType.Xml);

            //lblXml.Text = "Waiting for server response.";
            //var newAccountResponse = await task;

            //sw.Stop();

            //lblXml.Text = String.Format("Server responded: {0}, view ApiResponse object for full details. Speed: {1}", newAccountResponse.Meta.Result, sw.ElapsedMilliseconds);

        }



        private void lblDocumentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

   
        
    }

}
