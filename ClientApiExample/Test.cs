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

            var sw = new Stopwatch();
            sw.Start();

            lblJson.Text = "Reading XML.";
            string account = File.ReadAllText(@"..\..\example.json");

            lblJson.Text = "Deserialzing to Account object.";
            var newAccount = JsonConvert.DeserializeObject<Account>(account);

            var task =
                ClientApiWrapper.Controller.PostAccount(newAccount, Properties.Settings.Default.AccountId,
                    Properties.Settings.Default.Username, Properties.Settings.Default.Password, Controller.SubmitDataType.Json);

            lblJson.Text = "Waiting for server response.";
            var newAccountResponse = await task;

            sw.Stop();

            lblJson.Text = String.Format("Server responded: {0}, view ApiResponse object for full details. Speed {1}", newAccountResponse.Meta.Result, sw.ElapsedMilliseconds);

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {

            var sw = new Stopwatch();
            sw.Start();

            lblXml.Text = "Reading XML.";
            string account = File.ReadAllText(@"..\..\example.xml");

            lblXml.Text = "Deserialzing to Account object.";
            var newAccount = Helpers.FromXmlString<Account>(account);

            var task =
                ClientApiWrapper.Controller.PostAccount(newAccount, Properties.Settings.Default.AccountId,
                    Properties.Settings.Default.Username, Properties.Settings.Default.Password, Controller.SubmitDataType.Xml);

            lblXml.Text = "Waiting for server response.";
            var newAccountResponse = await task;

            sw.Stop();

            lblXml.Text = String.Format("Server responded: {0}, view ApiResponse object for full details. Speed: {1}", newAccountResponse.Meta.Result, sw.ElapsedMilliseconds);

        }



        private void lblDocumentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private async void btnMultipleJson_Click(object sender, EventArgs e)
        {

            var sw = new Stopwatch();
            sw.Start();

            lblJson.Text = "Reading JSON.";
            string account = File.ReadAllText(@"..\..\example.json");

            lblJson.Text = "Deserialzing to Account object.";
            var newAccount = JsonConvert.DeserializeObject<Account>(account);

            // create an array of 50 accounts to send at once. in your code you will get real data
            var accounts = new List<Account>();
            for (int i = 0; i < 50; i++)
            {
                accounts.Add(newAccount);
            }

            var tasks =
                ClientApiWrapper.Controller.PostAccounts(accounts, Properties.Settings.Default.AccountId,
                    Properties.Settings.Default.Username, Properties.Settings.Default.Password, Controller.SubmitDataType.Json);

            lblJson.Text = "Waiting for server response.";
            var newAccountResponse = await tasks;

            sw.Stop();

            lblJson.Text = String.Format("Server responses: {0}, debug to view all responses. Speed {1}", newAccountResponse.Count, sw.ElapsedMilliseconds);

        }




        private async void btnMultipleXml_Click(object sender, EventArgs e)
        {

            var sw = new Stopwatch();
            sw.Start();

            lblXml.Text = string.Format("Reading XML. {0}ms", sw.ElapsedMilliseconds);
            var accounts = XDocument.Load(@"..\..\exampleAccounts.xml");

            lblXml.Text = string.Format("Deserialzing to Account object. {0} ms", sw.ElapsedMilliseconds);
            var accountsList = accounts.Descendants("Account").Select(Helpers.FromXmlNode<Account>).ToList();

            /*
             * I would recommend doing this in segments of 100 records per request to minimize the amount of memory the 
             * application consumes. If you put the entire file in memory, it will run very slow.
             * Plus if there are any errors you want to easily be able to retry just the records needed.
             * See the Skip and Take methods on extension
            var accountsList = accounts.Descendants("Account").
                Select(FromXmlNode<Account>).
                Skip(0).
                Take(100).
                ToList();
             */


            var tasks =
                ClientApiWrapper.Controller.PostAccounts(accountsList, Properties.Settings.Default.AccountId,
                    Properties.Settings.Default.Username, Properties.Settings.Default.Password, Controller.SubmitDataType.Json);

            lblXml.Text = string.Format("Waiting for server response. {0} ms", sw.ElapsedMilliseconds);
            var newAccountResponse = await tasks;

            sw.Stop();

            lblXml.Text = String.Format("Server responses: {0}, debug to view all responses. Speed {1} ms", newAccountResponse.Count, sw.ElapsedMilliseconds);

        }


    }

}
