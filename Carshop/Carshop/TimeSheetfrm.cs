using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carshop
{
    public partial class TimeSheetfrm : Form
    {
        public TimeSheetfrm(int buttonPushed)
        {
            InitializeComponent();
            InitializeTimeSheetfrm(buttonPushed);
        }
        public void InitializeTimeSheetfrm(int buttonPushed)
        {
            LastNamepnl.Visible = false;
            EmployeeNumberpnl.Visible = false;
            JobOrderNumberpnl.Visible = false;
            switch (buttonPushed)
            {
                case 1:
                    LastNamepnl.Visible = true;
                    break;
                case 2:
                    EmployeeNumberpnl.Visible = true;
                    break;
                case 3:
                    JobOrderNumberpnl.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
