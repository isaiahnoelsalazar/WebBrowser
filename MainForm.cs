using System;
using System.Drawing;
using System.Windows.Forms;
using static Web_Browser.GlobalValues;

namespace Web_Browser
{
    public partial class MainForm : Form
    {
        NewTab ActiveTab = null;
        int TabCount = 0;

        public MainForm()
        {
            InitializeComponent();

            TabList.Controls.Clear();
            TabList.RowStyles.Clear();
            TabList.VerticalScroll.Visible = true;
            TabList.HorizontalScroll.Enabled = false;
            TabList.HorizontalScroll.Visible = false;
            AddNewTab();
        }

        public void AddNewTab()
        {
            RowStyle Row = new RowStyle(SizeType.Absolute, 48f);
            NewTab NewTab = new NewTab(this);
            TableLayoutPanel Panel = new TableLayoutPanel
            {
                ColumnCount = 2
            };
            Button TabButton = new Button();
            Button CloseButton = new Button();

            Panel.ColumnStyles.Clear();
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            Panel.Margin = new Padding(5, 0, 5, 0);

            TabButton.Dock = DockStyle.Fill;
            TabButton.Text = "New Tab";
            TabButton.TextAlign = ContentAlignment.MiddleLeft;

            CloseButton.Dock = DockStyle.Fill;
            CloseButton.Text = "X";
            CloseButton.TextAlign = ContentAlignment.MiddleCenter;

            int FinalTabCount = TabCount;

            TabButton.Click += (s, e) =>
            {
                SelectTab(NewTab);
            };
            CloseButton.Click += (s, e) =>
            {
                CloseTab(NewTab, Panel, TabButton);
            };

            TabList.RowStyles.Add(Row);
            Panel.Controls.Add(TabButton, 0, 0);
            Panel.Controls.Add(CloseButton, 1, 0);
            TabList.Controls.Add(Panel);
            TabButtons.Add(TabButton);
            Tabs.Add(NewTab);
            SelectTab(NewTab);
            TabCount++;
        }

        void SelectTab(NewTab NewTab)
        {
            if (NewTab != ActiveTab)
            {
                if (ActiveTab != null)
                {
                    ActiveTab.Hide();
                    ActiveTab.MdiParent = null;
                }
                ActiveTab = NewTab;
                ActiveTabIndex = Tabs.IndexOf(NewTab);
                NewTab.MdiParent = this;
                NewTab.Dock = DockStyle.Fill;
                NewTab.Show();
            }
        }

        void CloseTab(NewTab NewTab, TableLayoutPanel Container, Button TabButton)
        {
            TabList.Controls.Remove(Container);
            TabButtons.Remove(TabButton);
            NewTab.Hide();
            NewTab.MdiParent = null;
            Tabs.Remove(NewTab);
            TabCount--;

            if (NewTab == ActiveTab && Tabs.Count > 0)
            {
                SelectTab(Tabs[Tabs.Count - 1]);
            }
        }

        private void AddNewTabButton_Click(object sender, EventArgs e)
        {
            AddNewTab();
        }
    }
}
