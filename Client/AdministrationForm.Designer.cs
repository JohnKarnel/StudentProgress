namespace Client
{
    partial class AdministrationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationForm));
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.предметиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.групиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_students = new System.Windows.Forms.ListView();
            this.sName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_subjects = new System.Windows.Forms.ListBox();
            this.lb_groups = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_subjectName = new System.Windows.Forms.TextBox();
            this.btn_addSubject = new System.Windows.Forms.Button();
            this.btn_editSubject = new System.Windows.Forms.Button();
            this.btn_removeSubject = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_groupName = new System.Windows.Forms.TextBox();
            this.btn_removeGroup = new System.Windows.Forms.Button();
            this.btn_editGroup = new System.Windows.Forms.Button();
            this.btn_addGroup = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_studentDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_removeStudent = new System.Windows.Forms.Button();
            this.btn_editStudent = new System.Windows.Forms.Button();
            this.btn_addStudent = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(625, 543);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 35);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "Вийти";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Предмети";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Групи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(150, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Студенти";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.предметиToolStripMenuItem,
            this.групиToolStripMenuItem,
            this.студентиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // предметиToolStripMenuItem
            // 
            this.предметиToolStripMenuItem.Image = global::Client.Properties.Resources.notifications;
            this.предметиToolStripMenuItem.Name = "предметиToolStripMenuItem";
            this.предметиToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.предметиToolStripMenuItem.Text = "Предмети";
            // 
            // групиToolStripMenuItem
            // 
            this.групиToolStripMenuItem.Image = global::Client.Properties.Resources.w128h1281338911352group;
            this.групиToolStripMenuItem.Name = "групиToolStripMenuItem";
            this.групиToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.групиToolStripMenuItem.Text = "Групи";
            // 
            // студентиToolStripMenuItem
            // 
            this.студентиToolStripMenuItem.Image = global::Client.Properties.Resources.выпускник;
            this.студентиToolStripMenuItem.Name = "студентиToolStripMenuItem";
            this.студентиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.студентиToolStripMenuItem.Text = "Студенти";
            // 
            // lv_students
            // 
            this.lv_students.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_students.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_students.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sName,
            this.name,
            this.pName});
            this.lv_students.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lv_students.FullRowSelect = true;
            this.lv_students.GridLines = true;
            this.lv_students.Location = new System.Drawing.Point(8, 33);
            this.lv_students.MultiSelect = false;
            this.lv_students.Name = "lv_students";
            this.lv_students.Size = new System.Drawing.Size(526, 340);
            this.lv_students.TabIndex = 30;
            this.lv_students.UseCompatibleStateImageBehavior = false;
            this.lv_students.View = System.Windows.Forms.View.Details;
            // 
            // sName
            // 
            this.sName.Text = "Прізвище";
            this.sName.Width = 195;
            // 
            // name
            // 
            this.name.Text = "Ім\'я";
            this.name.Width = 151;
            // 
            // pName
            // 
            this.pName.Text = "По-батькові";
            this.pName.Width = 180;
            // 
            // lb_subjects
            // 
            this.lb_subjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_subjects.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_subjects.FormattingEnabled = true;
            this.lb_subjects.ItemHeight = 18;
            this.lb_subjects.Items.AddRange(new object[] {
            " "});
            this.lb_subjects.Location = new System.Drawing.Point(18, 71);
            this.lb_subjects.Name = "lb_subjects";
            this.lb_subjects.Size = new System.Drawing.Size(147, 146);
            this.lb_subjects.TabIndex = 31;
            // 
            // lb_groups
            // 
            this.lb_groups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_groups.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_groups.FormattingEnabled = true;
            this.lb_groups.ItemHeight = 18;
            this.lb_groups.Items.AddRange(new object[] {
            " "});
            this.lb_groups.Location = new System.Drawing.Point(8, 35);
            this.lb_groups.Name = "lb_groups";
            this.lb_groups.Size = new System.Drawing.Size(147, 146);
            this.lb_groups.TabIndex = 32;
            this.lb_groups.SelectedIndexChanged += new System.EventHandler(this.lb_groups_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.tb_subjectName);
            this.panel1.Controls.Add(this.btn_addSubject);
            this.panel1.Controls.Add(this.btn_editSubject);
            this.panel1.Controls.Add(this.btn_removeSubject);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 262);
            this.panel1.TabIndex = 33;
            // 
            // tb_subjectName
            // 
            this.tb_subjectName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_subjectName.Location = new System.Drawing.Point(6, 185);
            this.tb_subjectName.Name = "tb_subjectName";
            this.tb_subjectName.Size = new System.Drawing.Size(147, 26);
            this.tb_subjectName.TabIndex = 22;
            // 
            // btn_addSubject
            // 
            this.btn_addSubject.BackColor = System.Drawing.Color.Transparent;
            this.btn_addSubject.BackgroundImage = global::Client.Properties.Resources.plus;
            this.btn_addSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addSubject.FlatAppearance.BorderSize = 0;
            this.btn_addSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSubject.Location = new System.Drawing.Point(10, 217);
            this.btn_addSubject.Name = "btn_addSubject";
            this.btn_addSubject.Size = new System.Drawing.Size(44, 35);
            this.btn_addSubject.TabIndex = 19;
            this.btn_addSubject.Tag = "Додати";
            this.btn_addSubject.UseVisualStyleBackColor = false;
            this.btn_addSubject.Click += new System.EventHandler(this.btn_addSubject_Click);
            // 
            // btn_editSubject
            // 
            this.btn_editSubject.BackColor = System.Drawing.Color.Transparent;
            this.btn_editSubject.BackgroundImage = global::Client.Properties.Resources.w512h5121380984696edit;
            this.btn_editSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editSubject.FlatAppearance.BorderSize = 0;
            this.btn_editSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editSubject.Location = new System.Drawing.Point(59, 217);
            this.btn_editSubject.Name = "btn_editSubject";
            this.btn_editSubject.Size = new System.Drawing.Size(44, 35);
            this.btn_editSubject.TabIndex = 20;
            this.btn_editSubject.UseVisualStyleBackColor = false;
            this.btn_editSubject.Click += new System.EventHandler(this.btn_editSubject_Click);
            // 
            // btn_removeSubject
            // 
            this.btn_removeSubject.BackColor = System.Drawing.Color.Transparent;
            this.btn_removeSubject.BackgroundImage = global::Client.Properties.Resources.minus;
            this.btn_removeSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_removeSubject.FlatAppearance.BorderSize = 0;
            this.btn_removeSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeSubject.Location = new System.Drawing.Point(109, 217);
            this.btn_removeSubject.Name = "btn_removeSubject";
            this.btn_removeSubject.Size = new System.Drawing.Size(44, 35);
            this.btn_removeSubject.TabIndex = 21;
            this.btn_removeSubject.UseVisualStyleBackColor = false;
            this.btn_removeSubject.Click += new System.EventHandler(this.btn_removeSubject_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.lb_groups);
            this.panel3.Controls.Add(this.tb_groupName);
            this.panel3.Controls.Add(this.btn_removeGroup);
            this.panel3.Controls.Add(this.btn_editGroup);
            this.panel3.Controls.Add(this.btn_addGroup);
            this.panel3.Location = new System.Drawing.Point(12, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 262);
            this.panel3.TabIndex = 35;
            // 
            // tb_groupName
            // 
            this.tb_groupName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_groupName.Location = new System.Drawing.Point(9, 189);
            this.tb_groupName.Name = "tb_groupName";
            this.tb_groupName.Size = new System.Drawing.Size(146, 26);
            this.tb_groupName.TabIndex = 37;
            // 
            // btn_removeGroup
            // 
            this.btn_removeGroup.BackColor = System.Drawing.Color.Transparent;
            this.btn_removeGroup.BackgroundImage = global::Client.Properties.Resources.minus;
            this.btn_removeGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_removeGroup.FlatAppearance.BorderSize = 0;
            this.btn_removeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeGroup.Location = new System.Drawing.Point(109, 221);
            this.btn_removeGroup.Name = "btn_removeGroup";
            this.btn_removeGroup.Size = new System.Drawing.Size(44, 35);
            this.btn_removeGroup.TabIndex = 36;
            this.btn_removeGroup.UseVisualStyleBackColor = false;
            this.btn_removeGroup.Click += new System.EventHandler(this.btn_removeGroup_Click);
            // 
            // btn_editGroup
            // 
            this.btn_editGroup.BackColor = System.Drawing.Color.Transparent;
            this.btn_editGroup.BackgroundImage = global::Client.Properties.Resources.w512h5121380984696edit;
            this.btn_editGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editGroup.FlatAppearance.BorderSize = 0;
            this.btn_editGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editGroup.Location = new System.Drawing.Point(60, 221);
            this.btn_editGroup.Name = "btn_editGroup";
            this.btn_editGroup.Size = new System.Drawing.Size(44, 35);
            this.btn_editGroup.TabIndex = 35;
            this.btn_editGroup.UseVisualStyleBackColor = false;
            this.btn_editGroup.Click += new System.EventHandler(this.btn_editGroup_Click);
            // 
            // btn_addGroup
            // 
            this.btn_addGroup.BackColor = System.Drawing.Color.Transparent;
            this.btn_addGroup.BackgroundImage = global::Client.Properties.Resources.plus;
            this.btn_addGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addGroup.FlatAppearance.BorderSize = 0;
            this.btn_addGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addGroup.Location = new System.Drawing.Point(10, 221);
            this.btn_addGroup.Name = "btn_addGroup";
            this.btn_addGroup.Size = new System.Drawing.Size(44, 35);
            this.btn_addGroup.TabIndex = 34;
            this.btn_addGroup.Tag = "Додати";
            this.btn_addGroup.UseVisualStyleBackColor = false;
            this.btn_addGroup.Click += new System.EventHandler(this.btn_addGroup_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(this.dgv_studentDetails);
            this.panel4.Controls.Add(this.lv_students);
            this.panel4.Controls.Add(this.btn_removeStudent);
            this.panel4.Controls.Add(this.btn_editStudent);
            this.panel4.Controls.Add(this.btn_addStudent);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(187, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 493);
            this.panel4.TabIndex = 36;
            // 
            // dgv_studentDetails
            // 
            this.dgv_studentDetails.AllowUserToResizeColumns = false;
            this.dgv_studentDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_studentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_studentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_studentDetails.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_studentDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_studentDetails.Location = new System.Drawing.Point(8, 379);
            this.dgv_studentDetails.Name = "dgv_studentDetails";
            this.dgv_studentDetails.RowHeadersVisible = false;
            this.dgv_studentDetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_studentDetails.Size = new System.Drawing.Size(526, 51);
            this.dgv_studentDetails.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Прізвище";
            this.Column1.Name = "Column1";
            this.Column1.Width = 195;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ім\'я";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "По-батькові";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // btn_removeStudent
            // 
            this.btn_removeStudent.BackColor = System.Drawing.Color.Transparent;
            this.btn_removeStudent.BackgroundImage = global::Client.Properties.Resources.minus;
            this.btn_removeStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_removeStudent.FlatAppearance.BorderSize = 0;
            this.btn_removeStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeStudent.Location = new System.Drawing.Point(306, 442);
            this.btn_removeStudent.Name = "btn_removeStudent";
            this.btn_removeStudent.Size = new System.Drawing.Size(44, 35);
            this.btn_removeStudent.TabIndex = 39;
            this.btn_removeStudent.UseVisualStyleBackColor = false;
            this.btn_removeStudent.Click += new System.EventHandler(this.btn_removeStudent_Click);
            // 
            // btn_editStudent
            // 
            this.btn_editStudent.BackColor = System.Drawing.Color.Transparent;
            this.btn_editStudent.BackgroundImage = global::Client.Properties.Resources.w512h5121380984696edit;
            this.btn_editStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editStudent.FlatAppearance.BorderSize = 0;
            this.btn_editStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editStudent.Location = new System.Drawing.Point(257, 442);
            this.btn_editStudent.Name = "btn_editStudent";
            this.btn_editStudent.Size = new System.Drawing.Size(44, 35);
            this.btn_editStudent.TabIndex = 38;
            this.btn_editStudent.UseVisualStyleBackColor = false;
            this.btn_editStudent.Click += new System.EventHandler(this.btn_editStudent_Click);
            // 
            // btn_addStudent
            // 
            this.btn_addStudent.BackColor = System.Drawing.Color.Transparent;
            this.btn_addStudent.BackgroundImage = global::Client.Properties.Resources.plus;
            this.btn_addStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addStudent.FlatAppearance.BorderSize = 0;
            this.btn_addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addStudent.Location = new System.Drawing.Point(207, 442);
            this.btn_addStudent.Name = "btn_addStudent";
            this.btn_addStudent.Size = new System.Drawing.Size(44, 35);
            this.btn_addStudent.TabIndex = 37;
            this.btn_addStudent.Tag = "Додати";
            this.btn_addStudent.UseVisualStyleBackColor = false;
            this.btn_addStudent.Click += new System.EventHandler(this.btn_addStudent_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(747, 590);
            this.Controls.Add(this.lb_subjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання інформації";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem групиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиToolStripMenuItem;
        private System.Windows.Forms.Button btn_addSubject;
        private System.Windows.Forms.Button btn_editSubject;
        private System.Windows.Forms.Button btn_removeSubject;
        private System.Windows.Forms.ListView lv_students;
        private System.Windows.Forms.ColumnHeader sName;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader pName;
        private System.Windows.Forms.ListBox lb_subjects;
        private System.Windows.Forms.ListBox lb_groups;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_removeGroup;
        private System.Windows.Forms.Button btn_editGroup;
        private System.Windows.Forms.Button btn_addGroup;
        private System.Windows.Forms.Button btn_removeStudent;
        private System.Windows.Forms.Button btn_editStudent;
        private System.Windows.Forms.Button btn_addStudent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_subjectName;
        private System.Windows.Forms.TextBox tb_groupName;
        private System.Windows.Forms.DataGridView dgv_studentDetails;
        private System.Windows.Forms.ToolStripMenuItem предметиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}