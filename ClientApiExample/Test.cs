using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ClientApiWrapper;
using ClientApiWrapper.Models;
using IPS.ClientApi.Messages;
using Newtonsoft.Json;

namespace ClientApiExample
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            lblDocumentation.Links.Add(new LinkLabel.Link()
            {
                LinkData = "https://developers.agencyrevolution.com/api-reference/account"
            });

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test_FormClosing);
        }


        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }




        private async void btnSubmitJson_Click(object sender, EventArgs e)
        {

            lblJson.Text = "Reading XML.";
            string account = File.ReadAllText(@"..\..\example.json");

            lblJson.Text = "Deserialzing to Account object.";
            var newAccount = JsonConvert.DeserializeObject<Account>(account);

            var task =
                ClientApiWrapper.Controller.PostAccount(newAccount, Properties.Settings.Default.AccountId,
                    Properties.Settings.Default.Username, Properties.Settings.Default.Password, Controller.SubmitDataType.Json);

            lblJson.Text = "Waiting for server response.";
            var newAccountResponse = await task;

            lblJson.Text = String.Format("Server responded: {0}, view ApiResponse object for full details.", newAccountResponse.Meta.Result);

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {

            lblXml.Text = "Reading XML.";
            string account = File.ReadAllText(@"..\..\example.xml");

            lblXml.Text = "Deserialzing to Account object.";
            var newAccount = FromXmlString(account);

            var task =
                ClientApiWrapper.Controller.PostAccount(newAccount, Properties.Settings.Default.AccountId,
                    Properties.Settings.Default.Username, Properties.Settings.Default.Password, Controller.SubmitDataType.Xml);

            lblXml.Text = "Waiting for server response.";
            var newAccountResponse = await task;

            lblXml.Text = String.Format("Server responded: {0}, view ApiResponse object for full details.", newAccountResponse.Meta.Result);

        }

        public static Account FromXmlString(string xmlString)
        {
            var reader = new StringReader(xmlString);
            var serializer = new XmlSerializer(typeof(Account));
            var instance = (Account)serializer.Deserialize(reader);

            return instance;
        }

        private void lblDocumentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }


    }

}
