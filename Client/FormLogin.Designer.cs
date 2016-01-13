namespace Client
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lb_enter = new System.Windows.Forms.Label();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.pb_password = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.llb_registrate = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_enter
            // 
            this.lb_enter.AutoSize = true;
            this.lb_enter.BackColor = System.Drawing.Color.Transparent;
            this.lb_enter.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_enter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_enter.Location = new System.Drawing.Point(38, 18);
            this.lb_enter.Name = "lb_enter";
            this.lb_enter.Size = new System.Drawing.Size(237, 32);
            this.lb_enter.TabIndex = 1;
            this.lb_enter.Text = "Вхід до системи";
            // 
            // pb_login
            // 
            this.pb_login.BackColor = System.Drawing.Color.Gainsboro;
            this.pb_login.BackgroundImage = global::Client.Properties.Resources.employee_login_icon;
            this.pb_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_login.Location = new System.Drawing.Point(220, 70);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(33, 33);
            this.pb_login.TabIndex = 4;
            this.pb_login.TabStop = false;
            // 
            // pb_password
            // 
            this.pb_password.BackColor = System.Drawing.Color.Gainsboro;
            this.pb_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_password.BackgroundImage")));
            this.pb_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_password.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb_password.Location = new System.Drawing.Point(220, 119);
            this.pb_password.Name = "pb_password";
            this.pb_password.Size = new System.Drawing.Size(33, 33);
            this.pb_password.TabIndex = 5;
            this.pb_password.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.Location = new System.Drawing.Point(109, 164);
            this.btn_login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(85, 34);
            this.btn_login.TabIndex = 1;
            this.btn_login.Tag = "Увійти";
            this.btn_login.Text = "Увійти";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_login
            // 
            this.tb_login.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_login.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.ForeColor = System.Drawing.Color.DimGray;
            this.tb_login.Location = new System.Drawing.Point(55, 70);
            this.tb_login.MaximumSize = new System.Drawing.Size(165, 33);
            this.tb_login.MaxLength = 16;
            this.tb_login.MinimumSize = new System.Drawing.Size(165, 33);
            this.tb_login.Name = "tb_login";
            this.tb_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_login.Size = new System.Drawing.Size(165, 33);
            this.tb_login.TabIndex = 2;
            this.tb_login.Text = "Логін";
            this.tb_login.Enter += new System.EventHandler(this.tb_login_Enter);
            this.tb_login.Leave += new System.EventHandler(this.tb_login_Leave);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.ForeColor = System.Drawing.Color.DimGray;
            this.tb_password.Location = new System.Drawing.Point(55, 119);
            this.tb_password.MaximumSize = new System.Drawing.Size(165, 33);
            this.tb_password.MaxLength = 16;
            this.tb_password.MinimumSize = new System.Drawing.Size(165, 33);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(165, 33);
            this.tb_password.TabIndex = 3;
            this.tb_password.Text = "Пароль";
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // llb_registrate
            // 
            this.llb_registrate.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.llb_registrate.AutoSize = true;
            this.llb_registrate.BackColor = System.Drawing.Color.Transparent;
            this.llb_registrate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llb_registrate.LinkColor = System.Drawing.Color.DodgerBlue;
            this.llb_registrate.Location = new System.Drawing.Point(86, 205);
            this.llb_registrate.Name = "llb_registrate";
            this.llb_registrate.Size = new System.Drawing.Size(134, 18);
            this.llb_registrate.TabIndex = 6;
            this.llb_registrate.TabStop = true;
            this.llb_registrate.Text = "Зареєструватися";
            this.llb_registrate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_registrate_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Client.Properties.Resources.kpi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(306, 248);
            this.Controls.Add(this.llb_registrate);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pb_password);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.lb_enter);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_enter;
        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.PictureBox pb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.LinkLabel llb_registrate;
    }
}