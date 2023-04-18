
namespace spacey
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.regB = new Guna.UI2.WinForms.Guna2Button();
            this.psdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lgBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.erTxt = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // regB
            // 
            this.regB.Animated = true;
            this.regB.BackColor = System.Drawing.Color.Transparent;
            this.regB.Cursor = System.Windows.Forms.Cursors.Default;
            this.regB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.regB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.regB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.regB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.regB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.regB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regB.ForeColor = System.Drawing.Color.White;
            this.regB.Location = new System.Drawing.Point(417, 271);
            this.regB.Name = "regB";
            this.regB.Size = new System.Drawing.Size(200, 46);
            this.regB.TabIndex = 8;
            this.regB.Text = "Register";
            this.regB.Click += new System.EventHandler(this.regB_Click);
            // 
            // psdTxt
            // 
            this.psdTxt.Animated = true;
            this.psdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.psdTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.psdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.psdTxt.CustomizableEdges.BottomRight = false;
            this.psdTxt.CustomizableEdges.TopLeft = false;
            this.psdTxt.CustomizableEdges.TopRight = false;
            this.psdTxt.DefaultText = "";
            this.psdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.psdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.psdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.psdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.psdTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.psdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.psdTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.psdTxt.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.psdTxt.Location = new System.Drawing.Point(184, 194);
            this.psdTxt.Name = "psdTxt";
            this.psdTxt.PasswordChar = '●';
            this.psdTxt.PlaceholderText = "Password";
            this.psdTxt.SelectedText = "";
            this.psdTxt.Size = new System.Drawing.Size(433, 44);
            this.psdTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.psdTxt.TabIndex = 7;
            this.psdTxt.UseSystemPasswordChar = true;
            // 
            // lgBtn
            // 
            this.lgBtn.Animated = true;
            this.lgBtn.BackColor = System.Drawing.Color.Transparent;
            this.lgBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lgBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lgBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lgBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lgBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lgBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.lgBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgBtn.ForeColor = System.Drawing.Color.White;
            this.lgBtn.Location = new System.Drawing.Point(184, 271);
            this.lgBtn.Name = "lgBtn";
            this.lgBtn.Size = new System.Drawing.Size(200, 46);
            this.lgBtn.TabIndex = 6;
            this.lgBtn.Text = "Login";
            this.lgBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // userTxt
            // 
            this.userTxt.Animated = true;
            this.userTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.userTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.userTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTxt.CustomizableEdges.BottomRight = false;
            this.userTxt.CustomizableEdges.TopLeft = false;
            this.userTxt.CustomizableEdges.TopRight = false;
            this.userTxt.DefaultText = "";
            this.userTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.userTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.userTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userTxt.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.userTxt.Location = new System.Drawing.Point(184, 133);
            this.userTxt.Name = "userTxt";
            this.userTxt.PasswordChar = '\0';
            this.userTxt.PlaceholderText = "Username";
            this.userTxt.SelectedText = "";
            this.userTxt.Size = new System.Drawing.Size(433, 44);
            this.userTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.userTxt.TabIndex = 5;
            this.userTxt.TextChanged += new System.EventHandler(this.userTxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(769, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.label1.TabIndex = 10;
            this.label1.Text = "S P A C E Y";
            // 
            // erTxt
            // 
            this.erTxt.AutoSize = true;
            this.erTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erTxt.ForeColor = System.Drawing.Color.IndianRed;
            this.erTxt.Location = new System.Drawing.Point(194, 243);
            this.erTxt.Name = "erTxt";
            this.erTxt.Size = new System.Drawing.Size(152, 17);
            this.erTxt.TabIndex = 11;
            this.erTxt.Text = "Invalid Login Information";
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 14;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(215)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.erTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regB);
            this.Controls.Add(this.psdTxt);
            this.Controls.Add(this.lgBtn);
            this.Controls.Add(this.userTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button regB;
        private Guna.UI2.WinForms.Guna2TextBox psdTxt;
        private Guna.UI2.WinForms.Guna2Button lgBtn;
        private Guna.UI2.WinForms.Guna2TextBox userTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label erTxt;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}

