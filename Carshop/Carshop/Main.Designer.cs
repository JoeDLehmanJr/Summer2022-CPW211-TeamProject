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
            this.SuspendLayout();
            // 
            // JobTasksbtn
            // 
            this.JobTasksbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JobTasksbtn.Location = new System.Drawing.Point(252, 246);
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
            this.CustomerTasksbtn.Location = new System.Drawing.Point(252, 103);
            this.CustomerTasksbtn.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerTasksbtn.Name = "CustomerTasksbtn";
            this.CustomerTasksbtn.Size = new System.Drawing.Size(284, 90);
            this.CustomerTasksbtn.TabIndex = 7;
            this.CustomerTasksbtn.Text = "Customer Tasks";
            this.CustomerTasksbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerTasksbtn);
            this.Controls.Add(this.JobTasksbtn);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private Button JobTasksbtn;
        private Button CustomerTasksbtn;
    }
}