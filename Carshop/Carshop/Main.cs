
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
            int x = 1920 / 2 - 170;
            int y = 1080 / 2 - 90;
            SignOngrp.Location = new Point(x, y);
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            switch (isLogined)
            {
                case true:
                    Jobgrp.Visible = false;
                    TimeSheetgrp.Visible = false;
                    Customergrp.Visible = false;
                    LogInbtn.Visible = true;
                    LogOutbtn.Visible = false;
                    isLogined = true;
                    break;


                case false:
                    Jobgrp.Visible = true;
                    TimeSheetgrp.Visible = true;
                    Customergrp.Visible = true;
                    LogInbtn.Visible = false;
                    LogOutbtn.Visible = true;
                    isLogined = true;
                    break;
            }
            SignOngrp.Visible = false;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            switch (isLogined)
            {
                case true:
                    Jobgrp.Visible = false;
                    TimeSheetgrp.Visible = false;
                    Customergrp.Visible = false;
                    LogInbtn.Visible = true;
                    LogOutbtn.Visible = false;
                    isLogined = false;
                    break;

                case false:
                    Jobgrp.Visible = false;
                    TimeSheetgrp.Visible = false;
                    Customergrp.Visible = false;
                    LogInbtn.Visible = true;
                    LogOutbtn.Visible = false;
                    isLogined = false;
                    break;
            }
            SignOngrp.Visible = true;
        }
    }
}