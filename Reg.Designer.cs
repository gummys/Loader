﻿
namespace spacey
{
    partial class Reg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regB = new Guna.UI2.WinForms.Guna2Button();
            this.psRegTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usregTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keyregTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.erTxt = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(309, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "S P A C E Y";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(769, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // regB
            // 
            this.regB.Animated = true;
            this.regB.BackColor = System.Drawing.Color.Transparent;
            this.regB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.regB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.regB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.regB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.regB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.regB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regB.ForeColor = System.Drawing.Color.White;
            this.regB.Location = new System.Drawing.Point(184, 325);
            this.regB.Name = "regB";
            this.regB.Size = new System.Drawing.Size(433, 46);
            this.regB.TabIndex = 14;
            this.regB.Text = "Register";
            this.regB.Click += new System.EventHandler(this.regB_Click);
            // 
            // psRegTxt
            // 
            this.psRegTxt.Animated = true;
            this.psRegTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.psRegTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.psRegTxt.CustomizableEdges.BottomRight = false;
            this.psRegTxt.CustomizableEdges.TopLeft = false;
            this.psRegTxt.CustomizableEdges.TopRight = false;
            this.psRegTxt.DefaultText = "";
            this.psRegTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.psRegTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.psRegTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.psRegTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.psRegTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.psRegTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.psRegTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.psRegTxt.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.psRegTxt.Location = new System.Drawing.Point(184, 194);
            this.psRegTxt.Name = "psRegTxt";
            this.psRegTxt.PasswordChar = '●';
            this.psRegTxt.PlaceholderText = "Password";
            this.psRegTxt.SelectedText = "";
            this.psRegTxt.Size = new System.Drawing.Size(433, 44);
            this.psRegTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.psRegTxt.TabIndex = 13;
            this.psRegTxt.UseSystemPasswordChar = true;
            // 
            // usregTxt
            // 
            this.usregTxt.Animated = true;
            this.usregTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.usregTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usregTxt.CustomizableEdges.BottomRight = false;
            this.usregTxt.CustomizableEdges.TopLeft = false;
            this.usregTxt.CustomizableEdges.TopRight = false;
            this.usregTxt.DefaultText = "";
            this.usregTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usregTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usregTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usregTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usregTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.usregTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.usregTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usregTxt.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.usregTxt.Location = new System.Drawing.Point(184, 133);
            this.usregTxt.Name = "usregTxt";
            this.usregTxt.PasswordChar = '\0';
            this.usregTxt.PlaceholderText = "Username";
            this.usregTxt.SelectedText = "";
            this.usregTxt.Size = new System.Drawing.Size(433, 44);
            this.usregTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.usregTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(308, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Already have an account?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(449, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "LOG IN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // keyregTxt
            // 
            this.keyregTxt.Animated = true;
            this.keyregTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.keyregTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyregTxt.CustomizableEdges.BottomRight = false;
            this.keyregTxt.CustomizableEdges.TopLeft = false;
            this.keyregTxt.CustomizableEdges.TopRight = false;
            this.keyregTxt.DefaultText = "";
            this.keyregTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keyregTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keyregTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyregTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyregTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.keyregTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.keyregTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyregTxt.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.keyregTxt.Location = new System.Drawing.Point(184, 252);
            this.keyregTxt.Name = "keyregTxt";
            this.keyregTxt.PasswordChar = '●';
            this.keyregTxt.PlaceholderText = "Key";
            this.keyregTxt.SelectedText = "";
            this.keyregTxt.Size = new System.Drawing.Size(433, 44);
            this.keyregTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.keyregTxt.TabIndex = 19;
            this.keyregTxt.UseSystemPasswordChar = true;
            // 
            // erTxt
            // 
            this.erTxt.AutoSize = true;
            this.erTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erTxt.ForeColor = System.Drawing.Color.IndianRed;
            this.erTxt.Location = new System.Drawing.Point(200, 301);
            this.erTxt.Name = "erTxt";
            this.erTxt.Size = new System.Drawing.Size(152, 17);
            this.erTxt.TabIndex = 20;
            this.erTxt.Text = "Invalid Login Information";
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 14;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.erTxt);
            this.Controls.Add(this.keyregTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regB);
            this.Controls.Add(this.psRegTxt);
            this.Controls.Add(this.usregTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reg";
            this.Text = "Reg";
            this.Load += new System.EventHandler(this.Reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button regB;
        private Guna.UI2.WinForms.Guna2TextBox psRegTxt;
        private Guna.UI2.WinForms.Guna2TextBox usregTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox keyregTxt;
        private System.Windows.Forms.Label erTxt;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}