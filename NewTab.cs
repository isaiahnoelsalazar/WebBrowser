using System;
using System.Drawing;
using System.Windows.Forms;
using static Web_Browser.GlobalValues;

namespace Web_Browser
{
    public partial class NewTab : Form
    {
        bool IsAddressBarFocused = false;

        public NewTab(MainForm MainForm)
        {
            InitializeComponent();

            AddressBar.BackColor = SystemColors.Control;
            AddressBar.ForeColor = Color.FromArgb(150, 150, 150);
            AddressBar.GotFocus += (s, e) =>
            {
                AddressBar.ForeColor = Color.Black;
            };
            AddressBar.LostFocus += (s, e) =>
            {
                AddressBar.ForeColor = Color.FromArgb(150, 150, 150);
                IsAddressBarFocused = false;
            };

            WebView.Source = new Uri("https://www.google.com");
            WebView.ContentLoading += (s, e) =>
            {
                WebView.CoreWebView2.DocumentTitleChanged += (sndr, evnt) =>
                {
                    TabButtons[ActiveTabIndex].Text = WebView.CoreWebView2.DocumentTitle;
                    AddressBar.Text = WebView.Source.ToString();
                };
                WebView.CoreWebView2.NewWindowRequested += (sndr, evnt) =>
                {
                    WebView.CoreWebView2.Navigate(evnt.Uri);
                    evnt.Handled = true;
                };
            };
        }

        private void AddressBar_Click(object sender, EventArgs e)
        {
            if (!IsAddressBarFocused)
            {
                AddressBar.SelectAll();
                IsAddressBarFocused = true;
            }
        }

        private void AddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void AddressBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WebView.Source = new Uri(AddressBar.Text.StartsWith("https://") ? AddressBar.Text : "https://www.google.com/search?q=" + AddressBar.Text);
                AddressBar.Text = WebView.Source.ToString();
                WebView.Focus();
            }
        }
    }
}
