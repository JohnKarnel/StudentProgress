namespace Client
{
    partial class CreationTimeTableForm
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
            _parentForm.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationTimeTableForm));
            this.lv_timeTable = new System.Windows.Forms.ListView();
            this.weekType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumPair = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.audit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_weekType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_room = new System.Windows.Forms.TextBox();
            this.cb_group = new System.Windows.Forms.ComboBox();
            this.cb_subject = new System.Windows.Forms.ComboBox();
            this.cb_pairNum = new System.Windows.Forms.ComboBox();
            this.cb_day = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_goNext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_timeTable
            // 
            this.lv_timeTable.BackColor = System.Drawing.Color.White;
            this.lv_timeTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_timeTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.weekType,
            this.Day,
            this.NumPair,
            this.subj,
            this.gr,
            this.audit});
            this.lv_timeTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lv_timeTable.FullRowSelect = true;
            this.lv_timeTable.GridLines = true;
            this.lv_timeTable.Location = new System.Drawing.Point(16, 14);
            this.lv_timeTable.MultiSelect = false;
            this.lv_timeTable.Name = "lv_timeTable";
            this.lv_timeTable.Size = new System.Drawing.Size(782, 259);
            this.lv_timeTable.TabIndex = 6;
            this.lv_timeTable.UseCompatibleStateImageBehavior = false;
            this.lv_timeTable.View = System.Windows.Forms.View.Details;
            // 
            // weekType
            // 
            this.weekType.Text = "Тиждень";
            this.weekType.Width = 131;
            // 
            // Day
            // 
            this.Day.Text = "День";
            this.Day.Width = 134;
            // 
            // NumPair
            // 
            this.NumPair.Text = "Пара";
            this.NumPair.Width = 128;
            // 
            // subj
            // 
            this.subj.Text = "Предмет";
            this.subj.Width = 136;
            // 
            // gr
            // 
            this.gr.Text = "Група";
            this.gr.Width = 129;
            // 
            // audit
            // 
            this.audit.Text = "Аудиторія";
            this.audit.Width = 122;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(774, 379);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 35);
            this.btn_exit.TabIndex = 46;
            this.btn_exit.Text = "Вийти";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.cb_weekType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_room);
            this.panel1.Controls.Add(this.cb_group);
            this.panel1.Controls.Add(this.cb_subject);
            this.panel1.Controls.Add(this.cb_pairNum);
            this.panel1.Controls.Add(this.cb_day);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lv_timeTable);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 360);
            this.panel1.TabIndex = 47;
            // 
            // cb_weekType
            // 
            this.cb_weekType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_weekType.FormattingEnabled = true;
            this.cb_weekType.Items.AddRange(new object[] {
            "Перший",
            "Другий"});
            this.cb_weekType.Location = new System.Drawing.Point(20, 314);
            this.cb_weekType.Name = "cb_weekType";
            this.cb_weekType.Size = new System.Drawing.Size(121, 26);
            this.cb_weekType.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 53;
            this.label6.Text = "Тиждень";
            // 
            // tb_room
            // 
            this.tb_room.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_room.Location = new System.Drawing.Point(676, 314);
            this.tb_room.Name = "tb_room";
            this.tb_room.Size = new System.Drawing.Size(122, 26);
            this.tb_room.TabIndex = 52;
            // 
            // cb_group
            // 
            this.cb_group.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_group.FormattingEnabled = true;
            this.cb_group.Location = new System.Drawing.Point(550, 314);
            this.cb_group.Name = "cb_group";
            this.cb_group.Size = new System.Drawing.Size(120, 26);
            this.cb_group.TabIndex = 51;
            // 
            // cb_subject
            // 
            this.cb_subject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_subject.FormattingEnabled = true;
            this.cb_subject.Location = new System.Drawing.Point(423, 314);
            this.cb_subject.Name = "cb_subject";
            this.cb_subject.Size = new System.Drawing.Size(122, 26);
            this.cb_subject.TabIndex = 50;
            // 
            // cb_pairNum
            // 
            this.cb_pairNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_pairNum.FormattingEnabled = true;
            this.cb_pairNum.Items.AddRange(new object[] {
            "Перша",
            "Друга",
            "Третя",
            "Четверта",
            "П\'ята"});
            this.cb_pairNum.Location = new System.Drawing.Point(285, 314);
            this.cb_pairNum.Name = "cb_pairNum";
            this.cb_pairNum.Size = new System.Drawing.Size(132, 26);
            this.cb_pairNum.TabIndex = 49;
            // 
            // cb_day
            // 
            this.cb_day.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_day.FormattingEnabled = true;
            this.cb_day.Items.AddRange(new object[] {
            "Понеділок",
            "Вівторок",
            "Середа",
            "Четверг",
            "П\'ятниця",
            "Субота"});
            this.cb_day.Location = new System.Drawing.Point(147, 314);
            this.cb_day.Name = "cb_day";
            this.cb_day.Size = new System.Drawing.Size(132, 26);
            this.cb_day.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(673, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Аудиторія";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(547, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Група";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(420, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Предмет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(282, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Пара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "День";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BackgroundImage = global::Client.Properties.Resources.w512h5121380984696edit;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(815, 269);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(44, 35);
            this.btn_edit.TabIndex = 41;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = global::Client.Properties.Resources.minus;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(814, 228);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(44, 35);
            this.btn_delete.TabIndex = 42;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = global::Client.Properties.Resources.plus;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(815, 310);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(44, 35);
            this.btn_add.TabIndex = 40;
            this.btn_add.Tag = "Додати";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_goNext
            // 
            this.btn_goNext.BackColor = System.Drawing.SystemColors.Control;
            this.btn_goNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_goNext.Image = global::Client.Properties.Resources.Иконка_стрелки_вправо__ei__svg;
            this.btn_goNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_goNext.Location = new System.Drawing.Point(688, 379);
            this.btn_goNext.Name = "btn_goNext";
            this.btn_goNext.Size = new System.Drawing.Size(80, 35);
            this.btn_goNext.TabIndex = 44;
            this.btn_goNext.Text = "Далі";
            this.btn_goNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_goNext.UseVisualStyleBackColor = true;
            this.btn_goNext.Visible = false;
            // 
            // CreationTimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 426);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_goNext);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreationTimeTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення розкладу";
            this.Load += new System.EventHandler(this.CreationTimeTableForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_timeTable;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader NumPair;
        private System.Windows.Forms.ColumnHeader subj;
        private System.Windows.Forms.ColumnHeader gr;
        private System.Windows.Forms.ColumnHeader audit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_goNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_room;
        private System.Windows.Forms.ComboBox cb_group;
        private System.Windows.Forms.ComboBox cb_subject;
        private System.Windows.Forms.ComboBox cb_pairNum;
        private System.Windows.Forms.ComboBox cb_day;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader weekType;
        private System.Windows.Forms.ComboBox cb_weekType;
        private System.Windows.Forms.Label label6;
    }
}