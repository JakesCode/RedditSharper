using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Web;

namespace RedditSharper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.reddit.com/api/v1/authorize?client_id=wJOPK4JHjb316Q&response_type=code&state=jakeisadeveloper&redirect_uri=https://www.reddit.com/&duration=permanent&scope=identity");
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if(webBrowser1.Url.ToString().Substring(0, 25) != "https://www.reddit.com/lo")
            {
                string code = HttpUtility.ParseQueryString(webBrowser1.Url.Query).Get("code");
                if(HttpUtility.ParseQueryString(webBrowser1.Url.Query).Get("state") == "jakeisadeveloper")
                {
                    // Post Request //
                    // Guide here: https://github.com/reddit/reddit/wiki/OAuth2 //
                }
            }
        }
    }
}
