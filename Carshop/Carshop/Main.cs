
namespace Carshop
{
    public partial class Main : Form
    {
        public Boolean isLogined = false;
        public Main()
        {
            InitializeComponent();
            Jobgrp.Visible = false;
            TimeSheetgrp.Visible = false;
            Customergrp.Visible = false;
            LogOutbtn.Visible = false;
            LogInbtn.Visible = true;
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
        }
    }
}