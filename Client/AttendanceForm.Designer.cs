namespace Client
{
    partial class AttendanceForm
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
            _parrentForm.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.lv_students = new System.Windows.Forms.ListView();
            this.sName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_groups = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_dontExist = new System.Windows.Forms.Button();
            this.btn_exist = new System.Windows.Forms.Button();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відвідуваністьСтуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відвідуваністьГрупиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відвідуваністьПредметуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_students
            // 
            this.lv_students.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_students.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_students.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sName,
            this.name,
            this.pName,
            this.columnHeader1});
            this.lv_students.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lv_students.FullRowSelect = true;
            this.lv_students.GridLines = true;
            this.lv_students.Location = new System.Drawing.Point(6, 33);
            this.lv_students.MultiSelect = false;
            this.lv_students.Name = "lv_students";
            this.lv_students.Size = new System.Drawing.Size(458, 182);
            this.lv_students.TabIndex = 37;
            this.lv_students.UseCompatibleStateImageBehavior = false;
            this.lv_students.View = System.Windows.Forms.View.Details;
            // 
            // sName
            // 
            this.sName.Text = "Прізвище";
            this.sName.Width = 122;
            // 
            // name
            // 
            this.name.Text = "Ім\'я";
            this.name.Width = 105;
            // 
            // pName
            // 
            this.pName.Text = "По-батькові";
            this.pName.Width = 129;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Присутність";
            this.columnHeader1.Width = 98;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(this.btn_info);
            this.panel4.Controls.Add(this.btn_dontExist);
            this.panel4.Controls.Add(this.btn_exist);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lv_students);
            this.panel4.Location = new System.Drawing.Point(182, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 225);
            this.panel4.TabIndex = 38;
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
            // lb_groups
            // 
            this.lb_groups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_groups.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_groups.FormattingEnabled = true;
            this.lb_groups.ItemHeight = 18;
            this.lb_groups.Items.AddRange(new object[] {
            " "});
            this.lb_groups.Location = new System.Drawing.Point(21, 75);
            this.lb_groups.Name = "lb_groups";
            this.lb_groups.Size = new System.Drawing.Size(147, 182);
            this.lb_groups.TabIndex = 40;
            this.lb_groups.SelectedIndexChanged += new System.EventHandler(this.lb_groups_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(70, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Групи";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(15, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 225);
            this.panel3.TabIndex = 41;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(600, 273);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 35);
            this.button10.TabIndex = 42;
            this.button10.Text = "Вийти";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статистикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.Transparent;
            this.btn_info.BackgroundImage = global::Client.Properties.Resources.informacion_0;
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Location = new System.Drawing.Point(470, 136);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(44, 35);
            this.btn_info.TabIndex = 40;
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_dontExist
            // 
            this.btn_dontExist.BackColor = System.Drawing.Color.Transparent;
            this.btn_dontExist.BackgroundImage = global::Client.Properties.Resources.w512h5121380984637delete1;
            this.btn_dontExist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_dontExist.FlatAppearance.BorderSize = 0;
            this.btn_dontExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dontExist.Location = new System.Drawing.Point(470, 95);
            this.btn_dontExist.Name = "btn_dontExist";
            this.btn_dontExist.Size = new System.Drawing.Size(44, 35);
            this.btn_dontExist.TabIndex = 39;
            this.btn_dontExist.UseVisualStyleBackColor = false;
            this.btn_dontExist.Click += new System.EventHandler(this.btn_dontExist_Click);
            // 
            // btn_exist
            // 
            this.btn_exist.BackColor = System.Drawing.Color.Transparent;
            this.btn_exist.BackgroundImage = global::Client.Properties.Resources.check;
            this.btn_exist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exist.FlatAppearance.BorderSize = 0;
            this.btn_exist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exist.Location = new System.Drawing.Point(470, 54);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(44, 35);
            this.btn_exist.TabIndex = 37;
            this.btn_exist.Tag = "Додати";
            this.btn_exist.UseVisualStyleBackColor = false;
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відвідуваністьСтуToolStripMenuItem,
            this.відвідуваністьГрупиToolStripMenuItem,
            this.відвідуваністьПредметуToolStripMenuItem});
            this.статистикаToolStripMenuItem.Image = global::Client.Properties.Resources.w256h2561372351012Increase256;
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // відвідуваністьСтуToolStripMenuItem
            // 
            this.відвідуваністьСтуToolStripMenuItem.Image = global::Client.Properties.Resources.выпускник;
            this.відвідуваністьСтуToolStripMenuItem.Name = "відвідуваністьСтуToolStripMenuItem";
            this.відвідуваністьСтуToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.відвідуваністьСтуToolStripMenuItem.Text = "Відвідуваність студента";
            // 
            // відвідуваністьГрупиToolStripMenuItem
            // 
            this.відвідуваністьГрупиToolStripMenuItem.Image = global::Client.Properties.Resources.w128h1281338911352group;
            this.відвідуваністьГрупиToolStripMenuItem.Name = "відвідуваністьГрупиToolStripMenuItem";
            this.відвідуваністьГрупиToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.відвідуваністьГрупиToolStripMenuItem.Text = "Відвідуваність групи";
            // 
            // відвідуваністьПредметуToolStripMenuItem
            // 
            this.відвідуваністьПредметуToolStripMenuItem.Image = global::Client.Properties.Resources.notifications;
            this.відвідуваністьПредметуToolStripMenuItem.Name = "відвідуваністьПредметуToolStripMenuItem";
            this.відвідуваністьПредметуToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.відвідуваністьПредметуToolStripMenuItem.Text = "Відвідуваність предмету";
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(719, 316);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.lb_groups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моніторинг відвідуваності";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_students;
        private System.Windows.Forms.ColumnHeader sName;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader pName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_dontExist;
        private System.Windows.Forms.Button btn_exist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListBox lb_groups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відвідуваністьСтуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відвідуваністьГрупиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відвідуваністьПредметуToolStripMenuItem;
    }
}