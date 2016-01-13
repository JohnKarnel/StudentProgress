namespace Client
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.drp_firstWeekDate = new System.Windows.Forms.DateTimePicker();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_goNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть дату першого тижня розкладу";
            // 
            // drp_firstWeekDate
            // 
            this.drp_firstWeekDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drp_firstWeekDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.drp_firstWeekDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drp_firstWeekDate.Location = new System.Drawing.Point(21, 43);
            this.drp_firstWeekDate.Name = "drp_firstWeekDate";
            this.drp_firstWeekDate.Size = new System.Drawing.Size(280, 26);
            this.drp_firstWeekDate.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(210, 84);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 35);
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "Вийти";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_goNext
            // 
            this.btn_goNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_goNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_goNext.Image = global::Client.Properties.Resources.Иконка_стрелки_вправо__ei__svg;
            this.btn_goNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_goNext.Location = new System.Drawing.Point(123, 84);
            this.btn_goNext.Name = "btn_goNext";
            this.btn_goNext.Size = new System.Drawing.Size(81, 35);
            this.btn_goNext.TabIndex = 15;
            this.btn_goNext.Text = "Далі ";
            this.btn_goNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_goNext.UseVisualStyleBackColor = true;
            this.btn_goNext.Click += new System.EventHandler(this.btn_goNext_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 66);
            this.panel1.TabIndex = 17;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 132);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_goNext);
            this.Controls.Add(this.drp_firstWeekDate);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Початкова конфігурація";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker drp_firstWeekDate;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_goNext;
        private System.Windows.Forms.Panel panel1;
    }
}