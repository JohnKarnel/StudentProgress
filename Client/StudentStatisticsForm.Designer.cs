namespace Client
{
    partial class StudentStatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentStatisticsForm));
            this.lb_presences = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_progylu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_presences
            // 
            this.lb_presences.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_presences.FormattingEnabled = true;
            this.lb_presences.ItemHeight = 18;
            this.lb_presences.Location = new System.Drawing.Point(9, 7);
            this.lb_presences.Name = "lb_presences";
            this.lb_presences.Size = new System.Drawing.Size(203, 238);
            this.lb_presences.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прогули";
            // 
            // tb_progylu
            // 
            this.tb_progylu.BackColor = System.Drawing.Color.White;
            this.tb_progylu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_progylu.Location = new System.Drawing.Point(78, 251);
            this.tb_progylu.Name = "tb_progylu";
            this.tb_progylu.ReadOnly = true;
            this.tb_progylu.Size = new System.Drawing.Size(42, 26);
            this.tb_progylu.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lb_presences);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_progylu);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 290);
            this.panel1.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(134, 251);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(78, 27);
            this.btn_exit.TabIndex = 47;
            this.btn_exit.Text = "Вийти";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // StudentStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(255, 317);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentStatisticsForm";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StudentStatisticsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_presences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_progylu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
    }
}