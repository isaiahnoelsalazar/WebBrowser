using System.Collections.Generic;
using System.Windows.Forms;

namespace Web_Browser
{
    public class GlobalValues
    {
        public static List<NewTab> Tabs = new List<NewTab>();
        public static List<Button> TabButtons = new List<Button>();
        public static int ActiveTabIndex = -1;
        public static MainForm GlobalMainForm;
    }
}
