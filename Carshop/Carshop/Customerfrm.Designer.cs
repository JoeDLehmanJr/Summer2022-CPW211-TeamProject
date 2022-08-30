namespace Carshop
{
    partial class Customerfrm
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
            this.CustomerPhonepnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EditCustomerbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerPhonepnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerPhonepnl
            // 
            this.CustomerPhonepnl.Controls.Add(this.EditCustomerbtn);
            this.CustomerPhonepnl.Controls.Add(this.button1);
            this.CustomerPhonepnl.Controls.Add(this.button2);
            this.CustomerPhonepnl.Controls.Add(this.comboBox1);
            this.CustomerPhonepnl.Controls.Add(this.label1);
            this.CustomerPhonepnl.Location = new System.Drawing.Point(18, 41);
            this.CustomerPhonepnl.Name = "CustomerPhonepnl";
            this.CustomerPhonepnl.Size = new System.Drawing.Size(295, 141);
            this.CustomerPhonepnl.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete Customer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Customer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer phone number";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // EditCustomerbtn
            // 
            this.EditCustomerbtn.Location = new System.Drawing.Point(81, 102);
            this.EditCustomerbtn.Name = "EditCustomerbtn";
            this.EditCustomerbtn.Size = new System.Drawing.Size(106, 23);
            this.EditCustomerbtn.TabIndex = 4;
            this.EditCustomerbtn.Text = "Edit Customer";
            this.EditCustomerbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 141);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Edit Customer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete Customer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "View Customer";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(145, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer phone number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Customerfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomerPhonepnl);
            this.Name = "Customerfrm";
            this.Text = "Customerfrm";
            this.CustomerPhonepnl.ResumeLayout(false);
            this.CustomerPhonepnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel CustomerPhonepnl;
        private Button button1;
        private Button button2;
        private Label label1;
        private ComboBox comboBox1;
        private Button EditCustomerbtn;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBox2;
        private Label label2;
        private Panel panel2;
        private Button EditCustomerPhonebtn;
        private Button DeleteCustomerPhonebtn;
        private Button ViewCustomerPhonebtn;
        private ComboBox CustomerPhonecmb;
        private Label label3;
        private Panel CustomerJobNumberpnl;
        private Button EditCustomerJobbtn;
        private Button DeleteCustomerJobbtn;
        private Button ViewCustomerJobbtn;
        private ComboBox CustomerJobcmb;
        private Label label4;
    }
}