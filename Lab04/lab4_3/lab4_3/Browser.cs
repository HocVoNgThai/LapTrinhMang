using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Security.Policy;

namespace lab4_3
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
           // webView.NavigationStarting += EnsureHttps;
            //InitializeAsync();
        }
        /*async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
        }
        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            txtUrl.Text = uri;
            webView.CoreWebView2.PostWebMessageAsString(uri);
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }
        }*/

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            btnDownSource.Left = this.ClientSize.Width - btnDownSource.Width - 30;
            btnDownFile.Left = this.ClientSize.Width - btnDownFile.Width - 30;
            txtUrl.Width = btnDownSource.Left - txtUrl.Left - 20;
            txtPath.Width = btnDownFile.Left - txtPath.Left - 20;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
                webView.Navigate(txtUrl.Text);
        }
        private void btnDownFile_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string folderPath = txtPath.Text;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);
            string source = document.DocumentNode.OuterHtml;
            string fileName = Path.GetFileName(url);
            string filePath = Path.Combine(folderPath, fileName + ".html");
            File.WriteAllText(filePath, source);
            MessageBox.Show("Download completed!");
        }
        private void btnDownSource_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string folderPath = txtPath.Text;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);
            string source = document.DocumentNode.OuterHtml;
            string fileName = Path.GetFileName(url);
            string filePath = Path.Combine(folderPath, fileName + ".html");
            File.WriteAllText(filePath, source);
            DownloadSource(document.DocumentNode, folderPath);
            MessageBox.Show("Download completed!");
        }
        void DownloadSource(HtmlAgilityPack.HtmlNode node, string folderPath)
        {
            if (node.NodeType == HtmlAgilityPack.HtmlNodeType.Element)
            {
                if (node.Name == "img" || node.Name == "link" || node.Name == "script")
                {
                    string sourceUrl = node.GetAttributeValue("src", null) ?? node.GetAttributeValue("href", null);

                    if (!string.IsNullOrEmpty(sourceUrl))
                    {
                        string fileName = Path.GetFileName(sourceUrl);
                        string filePath = Path.Combine(folderPath, fileName);
                        using (WebClient client = new WebClient())
                        {
                            try
                            {
                                client.DownloadFile(sourceUrl, filePath);
                            }
                            catch (Exception ex) { }
                        }
                    }
                }
            }
            foreach (HtmlAgilityPack.HtmlNode childNode in node.ChildNodes)
            {
                DownloadSource(childNode, folderPath);
            }
        }
    }
}
