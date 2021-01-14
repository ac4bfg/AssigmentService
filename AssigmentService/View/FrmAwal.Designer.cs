namespace AssigmentService.View
{
    partial class FrmAwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAwal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gbCreate = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.pgSignUp = new AssigmentService.View.PageSignUp();
            this.lblCreate = new System.Windows.Forms.Label();
            this.pgLogin = new AssigmentService.View.pageLogin();
            this.ckcRemember = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.gbCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(1097, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.gbCreate);
            this.guna2Panel1.Controls.Add(this.pgSignUp);
            this.guna2Panel1.Controls.Add(this.lblCreate);
            this.guna2Panel1.Controls.Add(this.pgLogin);
            this.guna2Panel1.Controls.Add(this.ckcRemember);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Location = new System.Drawing.Point(648, 49);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(435, 652);
            this.guna2Panel1.TabIndex = 0;
            // 
            // gbCreate
            // 
            this.gbCreate.BackColor = System.Drawing.Color.Transparent;
            this.gbCreate.BorderColor = System.Drawing.Color.Transparent;
            this.gbCreate.Controls.Add(this.label6);
            this.gbCreate.Controls.Add(this.label5);
            this.gbCreate.Controls.Add(this.btnCreate);
            this.gbCreate.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbCreate.FillColor = System.Drawing.Color.Transparent;
            this.gbCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbCreate.ForeColor = System.Drawing.Color.Transparent;
            this.gbCreate.Location = new System.Drawing.Point(24, 492);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.ShadowDecoration.Parent = this.gbCreate;
            this.gbCreate.Size = new System.Drawing.Size(408, 116);
            this.gbCreate.TabIndex = 29;
            this.gbCreate.Text = "guna2GroupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.label5.Location = new System.Drawing.Point(25, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "Dengan menekan tombol Create";
            // 
            // btnCreate
            // 
            this.btnCreate.AutoRoundedCorners = true;
            this.btnCreate.BorderRadius = 25;
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.CustomImages.Parent = this.btnCreate;
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.btnCreate.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.HoverState.Parent = this.btnCreate;
            this.btnCreate.Location = new System.Drawing.Point(98, 54);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(180, 52);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pgSignUp
            // 
            this.pgSignUp.Location = new System.Drawing.Point(0, 12);
            this.pgSignUp.Name = "pgSignUp";
            this.pgSignUp.Size = new System.Drawing.Size(435, 507);
            this.pgSignUp.TabIndex = 27;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.lblCreate.Location = new System.Drawing.Point(119, 522);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(204, 23);
            this.lblCreate.TabIndex = 26;
            this.lblCreate.Text = "Don\'t have an account? ";
            this.lblCreate.Click += new System.EventHandler(this.lblCreate_Click);
            // 
            // pgLogin
            // 
            this.pgLogin.BackColor = System.Drawing.Color.White;
            this.pgLogin.Location = new System.Drawing.Point(0, -1);
            this.pgLogin.Name = "pgLogin";
            this.pgLogin.Size = new System.Drawing.Size(435, 389);
            this.pgLogin.TabIndex = 22;
            // 
            // ckcRemember
            // 
            this.ckcRemember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.ckcRemember.CheckedState.BorderRadius = 2;
            this.ckcRemember.CheckedState.BorderThickness = 0;
            this.ckcRemember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.ckcRemember.CheckedState.Parent = this.ckcRemember;
            this.ckcRemember.Location = new System.Drawing.Point(52, 394);
            this.ckcRemember.Name = "ckcRemember";
            this.ckcRemember.ShadowDecoration.Parent = this.ckcRemember;
            this.ckcRemember.Size = new System.Drawing.Size(20, 20);
            this.ckcRemember.TabIndex = 21;
            this.ckcRemember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.ckcRemember.UncheckedState.BorderRadius = 2;
            this.ckcRemember.UncheckedState.BorderThickness = 0;
            this.ckcRemember.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.ckcRemember.UncheckedState.Parent = this.ckcRemember;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.label3.Location = new System.Drawing.Point(78, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Remember me";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BorderRadius = 25;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.btnLogin.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(123, 445);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 52);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.label4.Location = new System.Drawing.Point(1082, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 34);
            this.label4.TabIndex = 20;
            this.label4.Text = "  X  ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.label6.Location = new System.Drawing.Point(25, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "anda telah setuju dengan persyaratan dan kebijakan kami";
            // 
            // FrmAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1135, 757);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAwal";
            this.Load += new System.EventHandler(this.FrmAwal_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ckcRemember;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2Button btnLogin;
        private pageLogin pgLogin;
        private System.Windows.Forms.Label label4;
        private PageSignUp pgSignUp;
        private System.Windows.Forms.Label lblCreate;
        private Guna.UI2.WinForms.Guna2GroupBox gbCreate;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2Button btnCreate;
        private System.Windows.Forms.Label label6;
    }
}