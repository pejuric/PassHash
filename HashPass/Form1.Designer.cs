﻿namespace HashPass
{
    partial class PassKeeper
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
            this.button2 = new System.Windows.Forms.Button();
            this.SavePassPage = new System.Windows.Forms.TabControl();
            this.CreateAccount = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SavePassPage.SuspendLayout();
            this.CreateAccount.SuspendLayout();
            this.LogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "LogIn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SavePassPage
            // 
            this.SavePassPage.Controls.Add(this.CreateAccount);
            this.SavePassPage.Controls.Add(this.LogIn);
            this.SavePassPage.Location = new System.Drawing.Point(12, 12);
            this.SavePassPage.Name = "SavePassPage";
            this.SavePassPage.SelectedIndex = 0;
            this.SavePassPage.Size = new System.Drawing.Size(271, 168);
            this.SavePassPage.TabIndex = 9;
            this.SavePassPage.Tag = "";
            // 
            // CreateAccount
            // 
            this.CreateAccount.BackColor = System.Drawing.Color.Gold;
            this.CreateAccount.Controls.Add(this.textBox2);
            this.CreateAccount.Controls.Add(this.textBox1);
            this.CreateAccount.Controls.Add(this.button1);
            this.CreateAccount.Location = new System.Drawing.Point(4, 22);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Padding = new System.Windows.Forms.Padding(3);
            this.CreateAccount.Size = new System.Drawing.Size(263, 142);
            this.CreateAccount.TabIndex = 0;
            this.CreateAccount.Text = "CreateAccount";

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.LogIn.Controls.Add(this.label2);
            this.LogIn.Controls.Add(this.label1);
            this.LogIn.Controls.Add(this.textBox4);
            this.LogIn.Controls.Add(this.textBox3);
            this.LogIn.Controls.Add(this.button2);
            this.LogIn.Location = new System.Drawing.Point(4, 22);
            this.LogIn.Name = "LogIn";
            this.LogIn.Padding = new System.Windows.Forms.Padding(3);
            this.LogIn.Size = new System.Drawing.Size(263, 142);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "LogIn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Name";

            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Pass";

            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Name";
                       // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Pass";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loged In";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account does not exist";
            this.label2.Visible = false;
            // 
            // PassKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 197);
            this.Controls.Add(this.SavePassPage);
            this.Name = "PassKeeper";
            this.Text = "PassKeeper";
            this.SavePassPage.ResumeLayout(false);
            this.CreateAccount.ResumeLayout(false);
            this.CreateAccount.PerformLayout();
            this.LogIn.ResumeLayout(false);
            this.LogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl SavePassPage;
        private System.Windows.Forms.TabPage CreateAccount;
        private System.Windows.Forms.TabPage LogIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

