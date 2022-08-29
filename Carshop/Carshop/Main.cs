
namespace Carshop
{
    public partial class Mainfrm : Form
    {
        public Boolean isLogined = false;
        public Mainfrm()
        {
            InitializeComponent();
            Jobgrp.Visible = false;
            TimeSheetgrp.Visible = false;
            Customergrp.Visible = false;
            LogOutbtn.Visible = false;
            LogInbtn.Visible = true;
            int x = this.Size.Width / 2 - 170;
            int y = this.Size.Height / 2 - 90;
            SignOngrp.Location = new Point(x, y);
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            SignOngrp.Visible = false;
            Jobgrp.Visible = true;
            TimeSheetgrp.Visible = true;
            Customergrp.Visible = true;
            LogInbtn.Visible = false;
            LogOutbtn.Visible = true;
            isLogined = true;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            SignOngrp.Visible = true;
            Jobgrp.Visible = false;
            TimeSheetgrp.Visible = false;
            Customergrp.Visible = false;
            LogInbtn.Visible = true;
            LogOutbtn.Visible = false;
            isLogined = false;
        }

        private void StartEndShiftwithLastNamebtn_Click(object sender, EventArgs e)
        {
            TimeSheetfrm TimeSheetfrm = new(1);
            TimeSheetfrm.Show();
        }

        private void StartEndShiftWithEmployeeNumberbtn_Click(object sender, EventArgs e)
        {
            TimeSheetfrm TimeSheetfrm = new(2);
            TimeSheetfrm.Show();
        }

        private void SignInToAJobbtn_Click(object sender, EventArgs e)
        {
            TimeSheetfrm TimeSheetfrm = new(3);
            TimeSheetfrm.Show();
        }
    }
}