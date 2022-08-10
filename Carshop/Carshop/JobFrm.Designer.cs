namespace Carshop
{
    partial class JobFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.ViewJobbtn = new System.Windows.Forms.Button();
            this.CreateJobbtn = new System.Windows.Forms.Button();
            this.DeleteJobbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(535, 62);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(314, 90);
            this.button4.TabIndex = 7;
            this.button4.Text = "Update Job";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ViewJobbtn
            // 
            this.ViewJobbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewJobbtn.Location = new System.Drawing.Point(132, 62);
            this.ViewJobbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewJobbtn.Name = "ViewJobbtn";
            this.ViewJobbtn.Size = new System.Drawing.Size(314, 90);
            this.ViewJobbtn.TabIndex = 6;
            this.ViewJobbtn.Text = "View Job";
            this.ViewJobbtn.UseVisualStyleBackColor = true;
            // 
            // CreateJobbtn
            // 
            this.CreateJobbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateJobbtn.Location = new System.Drawing.Point(132, 187);
            this.CreateJobbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CreateJobbtn.Name = "CreateJobbtn";
            this.CreateJobbtn.Size = new System.Drawing.Size(314, 90);
            this.CreateJobbtn.TabIndex = 4;
            this.CreateJobbtn.Text = "Create Job";
            this.CreateJobbtn.UseVisualStyleBackColor = true;
            // 
            // DeleteJobbtn
            // 
            this.DeleteJobbtn.AccessibleDescription = "  ";
            this.DeleteJobbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteJobbtn.Location = new System.Drawing.Point(535, 187);
            this.DeleteJobbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DeleteJobbtn.Name = "DeleteJobbtn";
            this.DeleteJobbtn.Size = new System.Drawing.Size(314, 90);
            this.DeleteJobbtn.TabIndex = 8;
            this.DeleteJobbtn.Text = "Delete Job";
            this.DeleteJobbtn.UseVisualStyleBackColor = true;
            // 
            // JobFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 340);
            this.Controls.Add(this.DeleteJobbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ViewJobbtn);
            this.Controls.Add(this.CreateJobbtn);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "JobFrm";
            this.Text = "Job Tasks Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button4;
        private Button ViewJobbtn;
        private Button CreateJobbtn;
        private Button DeleteJobbtn;
    }
}