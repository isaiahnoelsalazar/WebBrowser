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
            Button TabButton = new Button();
            TabButton.Size = new Size(0, 48);
            TabButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabButton.Text = "New Tab";
            TabButton.TextAlign = ContentAlignment.MiddleLeft;
            TabButton.Margin = new Padding(8, 0, 8, 0);
            TabButton.Padding = new Padding(8, 0, 8, 0);

            int FinalTabCount = TabCount;

            TabButton.Click += (s, e) =>
            {
                SelectTab(FinalTabCount);
            };

            TabList.RowStyles.Add(Row);
            TabList.Controls.Add(TabButton);
            TabButtons.Add(TabButton);
            Tabs.Add(NewTab);
            SelectTab(FinalTabCount);
            TabCount++;
        }

        void SelectTab(int Index)
        {
            if (Tabs[Index] != ActiveTab)
            {
                if (ActiveTab != null)
                {
                    ActiveTab.Hide();
                    ActiveTab.MdiParent = null;
                }
                ActiveTab = Tabs[Index];
                ActiveTabIndex = Index;
                Tabs[Index].MdiParent = this;
                Tabs[Index].Dock = DockStyle.Fill;
                Tabs[Index].Show();
            }
        }

        private void AddNewTabButton_Click(object sender, System.EventArgs e)
        {
            AddNewTab();
        }
    }
}
