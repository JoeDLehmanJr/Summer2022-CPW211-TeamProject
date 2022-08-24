namespace Carshop
{
    partial class Mainfrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignOutByLastNamebtn = new System.Windows.Forms.Button();
            this.StartShiftwithLastNamebtn = new System.Windows.Forms.Button();
            this.LogInbtn = new System.Windows.Forms.Button();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.TimeSheetgrp = new System.Windows.Forms.GroupBox();
            this.SignInToAJobbtn = new System.Windows.Forms.Button();
            this.StartShiftWithEmployeeNumberbtn = new System.Windows.Forms.Button();
            this.SignOutOfAJobbtn = new System.Windows.Forms.Button();
            this.EndShiftwithEmployeeNumberbtn = new System.Windows.Forms.Button();
            this.SignOngrp = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Jobgrp = new System.Windows.Forms.GroupBox();
            this.UpdateJobByLastNamebtn = new System.Windows.Forms.Button();
            this.UpdateJobByJobNumberbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CreateAJobbtn = new System.Windows.Forms.Button();
            this.ViewAllOpenJobsbtn = new System.Windows.Forms.Button();
            this.DeleteAJobbtn = new System.Windows.Forms.Button();
            this.ViewJobByLastNamebtn = new System.Windows.Forms.Button();
            this.ViewJobByJobNumberbtn = new System.Windows.Forms.Button();
            this.ViewAllJobsByPhoneNumbersbtn = new System.Windows.Forms.Button();
            this.Customergrp = new System.Windows.Forms.GroupBox();
            this.CreateCustomerbtn = new System.Windows.Forms.Button();
            this.ViewCustomerByKnownPhoneNumberbtn = new System.Windows.Forms.Button();
            this.DeleteCustomerbtn = new System.Windows.Forms.Button();
            this.ViewCustomersByJobNumberbtn = new System.Windows.Forms.Button();
            this.ViewAllCustomersbtn = new System.Windows.Forms.Button();
            this.UpdateCustomersbtn = new System.Windows.Forms.Button();
            this.TimeSheetgrp.SuspendLayout();
            this.SignOngrp.SuspendLayout();
            this.Jobgrp.SuspendLayout();
            this.Customergrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignOutByLastNamebtn
            // 
            this.SignOutByLastNamebtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignOutByLastNamebtn.Location = new System.Drawing.Point(327, 49);
            this.SignOutByLastNamebtn.Margin = new System.Windows.Forms.Padding(5);
            this.SignOutByLastNamebtn.Name = "SignOutByLastNamebtn";
            this.SignOutByLastNamebtn.Size = new System.Drawing.Size(284, 90);
            this.SignOutByLastNamebtn.TabIndex = 6;
            this.SignOutByLastNamebtn.Text = "Sign Out by Last Name";
            this.SignOutByLastNamebtn.UseVisualStyleBackColor = true;
            // 
            // StartShiftwithLastNamebtn
            // 
            this.StartShiftwithLastNamebtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartShiftwithLastNamebtn.Location = new System.Drawing.Point(20, 49);
            this.StartShiftwithLastNamebtn.Margin = new System.Windows.Forms.Padding(5);
            this.StartShiftwithLastNamebtn.Name = "StartShiftwithLastNamebtn";
            this.StartShiftwithLastNamebtn.Size = new System.Drawing.Size(284, 90);
            this.StartShiftwithLastNamebtn.TabIndex = 7;
            this.StartShiftwithLastNamebtn.Text = "Start Shift with Last Name";
            this.StartShiftwithLastNamebtn.UseVisualStyleBackColor = true;
            // 
            // LogInbtn
            // 
            this.LogInbtn.Location = new System.Drawing.Point(198, 122);
            this.LogInbtn.Name = "LogInbtn";
            this.LogInbtn.Size = new System.Drawing.Size(75, 23);
            this.LogInbtn.TabIndex = 8;
            this.LogInbtn.Text = "Log In";
            this.LogInbtn.UseVisualStyleBackColor = true;
            this.LogInbtn.Click += new System.EventHandler(this.LogInbtn_Click);
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Location = new System.Drawing.Point(1124, 971);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutbtn.TabIndex = 9;
            this.LogOutbtn.Text = "Log Out";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(1220, 971);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 10;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // TimeSheetgrp
            // 
            this.TimeSheetgrp.AutoSize = true;
            this.TimeSheetgrp.Controls.Add(this.SignInToAJobbtn);
            this.TimeSheetgrp.Controls.Add(this.StartShiftWithEmployeeNumberbtn);
            this.TimeSheetgrp.Controls.Add(this.SignOutOfAJobbtn);
            this.TimeSheetgrp.Controls.Add(this.SignOutByLastNamebtn);
            this.TimeSheetgrp.Controls.Add(this.StartShiftwithLastNamebtn);
            this.TimeSheetgrp.Controls.Add(this.EndShiftwithEmployeeNumberbtn);
            this.TimeSheetgrp.Location = new System.Drawing.Point(42, 41);
            this.TimeSheetgrp.Name = "TimeSheetgrp";
            this.TimeSheetgrp.Size = new System.Drawing.Size(828, 490);
            this.TimeSheetgrp.TabIndex = 11;
            this.TimeSheetgrp.TabStop = false;
            this.TimeSheetgrp.Text = "Time Sheet";
            this.TimeSheetgrp.Visible = false;
            // 
            // SignInToAJobbtn
            // 
            this.SignInToAJobbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignInToAJobbtn.Location = new System.Drawing.Point(20, 270);
            this.SignInToAJobbtn.Margin = new System.Windows.Forms.Padding(5);
            this.SignInToAJobbtn.Name = "SignInToAJobbtn";
            this.SignInToAJobbtn.Size = new System.Drawing.Size(284, 90);
            this.SignInToAJobbtn.TabIndex = 15;
            this.SignInToAJobbtn.Text = "Sign in to a Job";
            this.SignInToAJobbtn.UseVisualStyleBackColor = true;
            // 
            // StartShiftWithEmployeeNumberbtn
            // 
            this.StartShiftWithEmployeeNumberbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartShiftWithEmployeeNumberbtn.Location = new System.Drawing.Point(20, 159);
            this.StartShiftWithEmployeeNumberbtn.Margin = new System.Windows.Forms.Padding(5);
            this.StartShiftWithEmployeeNumberbtn.Name = "StartShiftWithEmployeeNumberbtn";
            this.StartShiftWithEmployeeNumberbtn.Size = new System.Drawing.Size(284, 90);
            this.StartShiftWithEmployeeNumberbtn.TabIndex = 13;
            this.StartShiftWithEmployeeNumberbtn.Text = "Start Shift With Employee Number";
            this.StartShiftWithEmployeeNumberbtn.UseVisualStyleBackColor = true;
            // 
            // SignOutOfAJobbtn
            // 
            this.SignOutOfAJobbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignOutOfAJobbtn.Location = new System.Drawing.Point(327, 270);
            this.SignOutOfAJobbtn.Margin = new System.Windows.Forms.Padding(5);
            this.SignOutOfAJobbtn.Name = "SignOutOfAJobbtn";
            this.SignOutOfAJobbtn.Size = new System.Drawing.Size(284, 90);
            this.SignOutOfAJobbtn.TabIndex = 14;
            this.SignOutOfAJobbtn.Text = "Sign Out of a Job";
            this.SignOutOfAJobbtn.UseVisualStyleBackColor = true;
            // 
            // EndShiftwithEmployeeNumberbtn
            // 
            this.EndShiftwithEmployeeNumberbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndShiftwithEmployeeNumberbtn.Location = new System.Drawing.Point(327, 159);
            this.EndShiftwithEmployeeNumberbtn.Margin = new System.Windows.Forms.Padding(5);
            this.EndShiftwithEmployeeNumberbtn.Name = "EndShiftwithEmployeeNumberbtn";
            this.EndShiftwithEmployeeNumberbtn.Size = new System.Drawing.Size(284, 90);
            this.EndShiftwithEmployeeNumberbtn.TabIndex = 12;
            this.EndShiftwithEmployeeNumberbtn.Text = "End Shift with Employee Number";
            this.EndShiftwithEmployeeNumberbtn.UseVisualStyleBackColor = true;
            // 
            // SignOngrp
            // 
            this.SignOngrp.Controls.Add(this.textBox2);
            this.SignOngrp.Controls.Add(this.textBox1);
            this.SignOngrp.Controls.Add(this.label2);
            this.SignOngrp.Controls.Add(this.label1);
            this.SignOngrp.Controls.Add(this.LogInbtn);
            this.SignOngrp.Location = new System.Drawing.Point(530, 840);
            this.SignOngrp.Name = "SignOngrp";
            this.SignOngrp.Size = new System.Drawing.Size(340, 180);
            this.SignOngrp.TabIndex = 14;
            this.SignOngrp.TabStop = false;
            this.SignOngrp.Text = "Sign On";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username: ";
            // 
            // Jobgrp
            // 
            this.Jobgrp.AutoSize = true;
            this.Jobgrp.Controls.Add(this.UpdateJobByLastNamebtn);
            this.Jobgrp.Controls.Add(this.UpdateJobByJobNumberbtn);
            this.Jobgrp.Controls.Add(this.button4);
            this.Jobgrp.Controls.Add(this.CreateAJobbtn);
            this.Jobgrp.Controls.Add(this.ViewAllOpenJobsbtn);
            this.Jobgrp.Controls.Add(this.DeleteAJobbtn);
            this.Jobgrp.Controls.Add(this.ViewJobByLastNamebtn);
            this.Jobgrp.Controls.Add(this.ViewJobByJobNumberbtn);
            this.Jobgrp.Controls.Add(this.ViewAllJobsByPhoneNumbersbtn);
            this.Jobgrp.Location = new System.Drawing.Point(723, 41);
            this.Jobgrp.Name = "Jobgrp";
            this.Jobgrp.Size = new System.Drawing.Size(657, 593);
            this.Jobgrp.TabIndex = 12;
            this.Jobgrp.TabStop = false;
            this.Jobgrp.Text = "Job";
            // 
            // UpdateJobByLastNamebtn
            // 
            this.UpdateJobByLastNamebtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateJobByLastNamebtn.Location = new System.Drawing.Point(340, 366);
            this.UpdateJobByLastNamebtn.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateJobByLastNamebtn.Name = "UpdateJobByLastNamebtn";
            this.UpdateJobByLastNamebtn.Size = new System.Drawing.Size(284, 90);
            this.UpdateJobByLastNamebtn.TabIndex = 16;
            this.UpdateJobByLastNamebtn.Text = "Update Job by Last Name";
            this.UpdateJobByLastNamebtn.UseVisualStyleBackColor = true;
            // 
            // UpdateJobByJobNumberbtn
            // 
            this.UpdateJobByJobNumberbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateJobByJobNumberbtn.Location = new System.Drawing.Point(33, 366);
            this.UpdateJobByJobNumberbtn.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateJobByJobNumberbtn.Name = "UpdateJobByJobNumberbtn";
            this.UpdateJobByJobNumberbtn.Size = new System.Drawing.Size(284, 90);
            this.UpdateJobByJobNumberbtn.TabIndex = 17;
            this.UpdateJobByJobNumberbtn.Text = "Update Job by Job Number";
            this.UpdateJobByJobNumberbtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(33, 476);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(284, 90);
            this.button4.TabIndex = 18;
            this.button4.Text = "Update All Jobs by Phone Numbers";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CreateAJobbtn
            // 
            this.CreateAJobbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateAJobbtn.Location = new System.Drawing.Point(33, 35);
            this.CreateAJobbtn.Margin = new System.Windows.Forms.Padding(5);
            this.CreateAJobbtn.Name = "CreateAJobbtn";
            this.CreateAJobbtn.Size = new System.Drawing.Size(284, 90);
            this.CreateAJobbtn.TabIndex = 15;
            this.CreateAJobbtn.Text = "Create a Job";
            this.CreateAJobbtn.UseVisualStyleBackColor = true;
            // 
            // ViewAllOpenJobsbtn
            // 
            this.ViewAllOpenJobsbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewAllOpenJobsbtn.Location = new System.Drawing.Point(33, 256);
            this.ViewAllOpenJobsbtn.Margin = new System.Windows.Forms.Padding(5);
            this.ViewAllOpenJobsbtn.Name = "ViewAllOpenJobsbtn";
            this.ViewAllOpenJobsbtn.Size = new System.Drawing.Size(284, 90);
            this.ViewAllOpenJobsbtn.TabIndex = 13;
            this.ViewAllOpenJobsbtn.Text = "View All Open Jobs";
            this.ViewAllOpenJobsbtn.UseVisualStyleBackColor = true;
            // 
            // DeleteAJobbtn
            // 
            this.DeleteAJobbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteAJobbtn.Location = new System.Drawing.Point(340, 35);
            this.DeleteAJobbtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteAJobbtn.Name = "DeleteAJobbtn";
            this.DeleteAJobbtn.Size = new System.Drawing.Size(284, 90);
            this.DeleteAJobbtn.TabIndex = 14;
            this.DeleteAJobbtn.Text = "Delete a Job";
            this.DeleteAJobbtn.UseVisualStyleBackColor = true;
            // 
            // ViewJobByLastNamebtn
            // 
            this.ViewJobByLastNamebtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewJobByLastNamebtn.Location = new System.Drawing.Point(340, 146);
            this.ViewJobByLastNamebtn.Margin = new System.Windows.Forms.Padding(5);
            this.ViewJobByLastNamebtn.Name = "ViewJobByLastNamebtn";
            this.ViewJobByLastNamebtn.Size = new System.Drawing.Size(284, 90);
            this.ViewJobByLastNamebtn.TabIndex = 6;
            this.ViewJobByLastNamebtn.Text = "View Job by Last Name";
            this.ViewJobByLastNamebtn.UseVisualStyleBackColor = true;
            // 
            // ViewJobByJobNumberbtn
            // 
            this.ViewJobByJobNumberbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewJobByJobNumberbtn.Location = new System.Drawing.Point(33, 146);
            this.ViewJobByJobNumberbtn.Margin = new System.Windows.Forms.Padding(5);
            this.ViewJobByJobNumberbtn.Name = "ViewJobByJobNumberbtn";
            this.ViewJobByJobNumberbtn.Size = new System.Drawing.Size(284, 90);
            this.ViewJobByJobNumberbtn.TabIndex = 7;
            this.ViewJobByJobNumberbtn.Text = "View Job by Job Number";
            this.ViewJobByJobNumberbtn.UseVisualStyleBackColor = true;
            // 
            // ViewAllJobsByPhoneNumbersbtn
            // 
            this.ViewAllJobsByPhoneNumbersbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewAllJobsByPhoneNumbersbtn.Location = new System.Drawing.Point(340, 256);
            this.ViewAllJobsByPhoneNumbersbtn.Margin = new System.Windows.Forms.Padding(5);
            this.ViewAllJobsByPhoneNumbersbtn.Name = "ViewAllJobsByPhoneNumbersbtn";
            this.ViewAllJobsByPhoneNumbersbtn.Size = new System.Drawing.Size(284, 90);
            this.ViewAllJobsByPhoneNumbersbtn.TabIndex = 12;
            this.ViewAllJobsByPhoneNumbersbtn.Text = "View All Jobs by Phone Numbers";
            this.ViewAllJobsByPhoneNumbersbtn.UseVisualStyleBackColor = true;
            // 
            // Customergrp
            // 
            this.Customergrp.Controls.Add(this.CreateCustomerbtn);
            this.Customergrp.Controls.Add(this.ViewCustomerByKnownPhoneNumberbtn);
            this.Customergrp.Controls.Add(this.DeleteCustomerbtn);
            this.Customergrp.Controls.Add(this.ViewCustomersByJobNumberbtn);
            this.Customergrp.Controls.Add(this.ViewAllCustomersbtn);
            this.Customergrp.Controls.Add(this.UpdateCustomersbtn);
            this.Customergrp.Location = new System.Drawing.Point(42, 447);
            this.Customergrp.Name = "Customergrp";
            this.Customergrp.Size = new System.Drawing.Size(657, 387);
            this.Customergrp.TabIndex = 13;
            this.Customergrp.TabStop = false;
            this.Customergrp.Text = "Customer";
            // 
            // CreateCustomerbtn
            // 
            this.CreateCustomerbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCustomerbtn.Location = new System.Drawing.Point(20, 260);
            this.CreateCustomerbtn.Margin = new System.Windows.Forms.Padding(5);
            this.CreateCustomerbtn.Name = "CreateCustomerbtn";
            this.CreateCustomerbtn.Size = new System.Drawing.Size(284, 90);
            this.CreateCustomerbtn.TabIndex = 21;
            this.CreateCustomerbtn.Text = "Create Customer";
            this.CreateCustomerbtn.UseVisualStyleBackColor = true;
            // 
            // ViewCustomerByKnownPhoneNumberbtn
            // 
            this.ViewCustomerByKnownPhoneNumberbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewCustomerByKnownPhoneNumberbtn.Location = new System.Drawing.Point(20, 149);
            this.ViewCustomerByKnownPhoneNumberbtn.Margin = new System.Windows.Forms.Padding(5);
            this.ViewCustomerByKnownPhoneNumberbtn.Name = "ViewCustomerByKnownPhoneNumberbtn";
            this.ViewCustomerByKnownPhoneNumberbtn.Size = new System.Drawing.Size(284, 90);
            this.ViewCustomerByKnownPhoneNumberbtn.TabIndex = 19;
            this.ViewCustomerByKnownPhoneNumberbtn.Text = "View Customer by Known Phone Number";
            this.ViewCustomerByKnownPhoneNumberbtn.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomerbtn
            // 
            this.DeleteCustomerbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteCustomerbtn.Location = new System.Drawing.Point(327, 260);
            this.DeleteCustomerbtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteCustomerbtn.Name = "DeleteCustomerbtn";
            this.DeleteCustomerbtn.Size = new System.Drawing.Size(284, 90);
            this.DeleteCustomerbtn.TabIndex = 20;
            this.DeleteCustomerbtn.Text = "Delete Customer";
            this.DeleteCustomerbtn.UseVisualStyleBackColor = true;
            // 
            // ViewCustomersByJobNumberbtn
            // 
            this.ViewCustomersByJobNumberbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewCustomersByJobNumberbtn.Location = new System.Drawing.Point(327, 39);
            this.ViewCustomersByJobNumberbtn.Margin = new System.Windows.Forms.Padding(5);
            this.ViewCustomersByJobNumberbtn.Name = "ViewCustomersByJobNumberbtn";
            this.ViewCustomersByJobNumberbtn.Size = new System.Drawing.Size(284, 90);
            this.ViewCustomersByJobNumberbtn.TabIndex = 16;
            this.ViewCustomersByJobNumberbtn.Text = "View Customers by Job Number";
            this.ViewCustomersByJobNumberbtn.UseVisualStyleBackColor = true;
            // 
            // ViewAllCustomersbtn
            // 
            this.ViewAllCustomersbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewAllCustomersbtn.Location = new System.Drawing.Point(20, 39);
            this.ViewAllCustomersbtn.Margin = new System.Windows.Forms.Padding(5);
            this.ViewAllCustomersbtn.Name = "ViewAllCustomersbtn";
            this.ViewAllCustomersbtn.Size = new System.Drawing.Size(284, 90);
            this.ViewAllCustomersbtn.TabIndex = 17;
            this.ViewAllCustomersbtn.Text = "View All Customers";
            this.ViewAllCustomersbtn.UseVisualStyleBackColor = true;
            // 
            // UpdateCustomersbtn
            // 
            this.UpdateCustomersbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateCustomersbtn.Location = new System.Drawing.Point(327, 149);
            this.UpdateCustomersbtn.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateCustomersbtn.Name = "UpdateCustomersbtn";
            this.UpdateCustomersbtn.Size = new System.Drawing.Size(284, 90);
            this.UpdateCustomersbtn.TabIndex = 18;
            this.UpdateCustomersbtn.Text = "Update Customers";
            this.UpdateCustomersbtn.UseVisualStyleBackColor = true;
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.SignOngrp);
            this.Controls.Add(this.Customergrp);
            this.Controls.Add(this.Jobgrp);
            this.Controls.Add(this.TimeSheetgrp);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.Exitbtn);
            this.MaximizeBox = false;
            this.Name = "Mainfrm";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TimeSheetgrp.ResumeLayout(false);
            this.SignOngrp.ResumeLayout(false);
            this.SignOngrp.PerformLayout();
            this.Jobgrp.ResumeLayout(false);
            this.Customergrp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SignOutByLastNamebtn;
        private Button StartShiftwithLastNamebtn;
        private Button LogInbtn;
        private Button LogOutbtn;
        private Button Exitbtn;
        private GroupBox TimeSheetgrp;
        private Button StartShiftWithEmployeeNumberbtn;
        private Button EndShiftwithEmployeeNumberbtn;
        private Button SignInToAJobbtn;
        private Button SignOutOfAJobbtn;
        private GroupBox Jobgrp;
        private Button ViewAllOpenJobsbtn;
        private Button ViewJobByLastNamebtn;
        private Button ViewJobByJobNumberbtn;
        private Button ViewAllJobsByPhoneNumbersbtn;
        private Button CreateAJobbtn;
        private Button DeleteAJobbtn;
        private Button UpdateJobByLastNamebtn;
        private Button UpdateJobByJobNumberbtn;
        private Button button4;
        private GroupBox Customergrp;
        private Button CreateCustomerbtn;
        private Button ViewCustomerByKnownPhoneNumberbtn;
        private Button DeleteCustomerbtn;
        private Button ViewCustomersByJobNumberbtn;
        private Button ViewAllCustomersbtn;
        private Button UpdateCustomersbtn;
        private GroupBox SignOngrp;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}