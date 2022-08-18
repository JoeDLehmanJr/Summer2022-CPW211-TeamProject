namespace Carshop
{
    partial class Main
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
            this.JobTasksbtn = new System.Windows.Forms.Button();
            this.CustomerTasksbtn = new System.Windows.Forms.Button();
            this.LogInbtn = new System.Windows.Forms.Button();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JobTasksbtn
            // 
            this.JobTasksbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JobTasksbtn.Location = new System.Drawing.Point(931, 314);
            this.JobTasksbtn.Margin = new System.Windows.Forms.Padding(5);
            this.JobTasksbtn.Name = "JobTasksbtn";
            this.JobTasksbtn.Size = new System.Drawing.Size(284, 90);
            this.JobTasksbtn.TabIndex = 6;
            this.JobTasksbtn.Text = "Job Tasks";
            this.JobTasksbtn.UseVisualStyleBackColor = true;
            // 
            // CustomerTasksbtn
            // 
            this.CustomerTasksbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerTasksbtn.Location = new System.Drawing.Point(931, 171);
            this.CustomerTasksbtn.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerTasksbtn.Name = "CustomerTasksbtn";
            this.CustomerTasksbtn.Size = new System.Drawing.Size(284, 90);
            this.CustomerTasksbtn.TabIndex = 7;
            this.CustomerTasksbtn.Text = "Customer Tasks";
            this.CustomerTasksbtn.UseVisualStyleBackColor = true;
            // 
            // LogInbtn
            // 
            this.LogInbtn.Location = new System.Drawing.Point(1271, 933);
            this.LogInbtn.Name = "LogInbtn";
            this.LogInbtn.Size = new System.Drawing.Size(75, 23);
            this.LogInbtn.TabIndex = 8;
            this.LogInbtn.Text = "Log In";
            this.LogInbtn.UseVisualStyleBackColor = true;
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Location = new System.Drawing.Point(1166, 933);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutbtn.TabIndex = 9;
            this.LogOutbtn.Text = "Log Out";
            this.LogOutbtn.UseVisualStyleBackColor = true;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.LogInbtn);
            this.Controls.Add(this.CustomerTasksbtn);
            this.Controls.Add(this.JobTasksbtn);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button JobTasksbtn;
        private Button CustomerTasksbtn;
        private Button LogInbtn;
        private Button LogOutbtn;
        private Button Exitbtn;
    }
}