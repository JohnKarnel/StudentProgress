using System.Windows.Forms;
namespace Client
{
    partial class WorkForm
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
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkForm));
            this.lb_pairNameTitle = new System.Windows.Forms.Label();
            this.lb_roomTitle = new System.Windows.Forms.Label();
            this.lb_groupsTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lb_currentPair = new System.Windows.Forms.Label();
            this.lb_currentRoom = new System.Windows.Forms.Label();
            this.lb_currentGroups = new System.Windows.Forms.Label();
            this.lb_pairDateTitle = new System.Windows.Forms.Label();
            this.lb_pairDate = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_nextPairGroups = new System.Windows.Forms.TextBox();
            this.tb_nextPairRoom = new System.Windows.Forms.TextBox();
            this.tb_nextPairSubj = new System.Windows.Forms.TextBox();
            this.tb_nextPairDate = new System.Windows.Forms.TextBox();
            this.tb_currGroups = new System.Windows.Forms.TextBox();
            this.tb_currRoom = new System.Windows.Forms.TextBox();
            this.tb_currSubject = new System.Windows.Forms.TextBox();
            this.tb_currPairDate = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_changePair = new System.Windows.Forms.Button();
            this.btn_deginWork = new System.Windows.Forms.Button();
            this.розкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_pairNameTitle
            // 
            this.lb_pairNameTitle.AutoSize = true;
            this.lb_pairNameTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_pairNameTitle.Location = new System.Drawing.Point(6, 87);
            this.lb_pairNameTitle.Name = "lb_pairNameTitle";
            this.lb_pairNameTitle.Size = new System.Drawing.Size(101, 18);
            this.lb_pairNameTitle.TabIndex = 2;
            this.lb_pairNameTitle.Text = "Дисципліна : ";
            // 
            // lb_roomTitle
            // 
            this.lb_roomTitle.AutoSize = true;
            this.lb_roomTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_roomTitle.Location = new System.Drawing.Point(6, 122);
            this.lb_roomTitle.Name = "lb_roomTitle";
            this.lb_roomTitle.Size = new System.Drawing.Size(88, 18);
            this.lb_roomTitle.TabIndex = 3;
            this.lb_roomTitle.Text = "Аудиторія :";
            // 
            // lb_groupsTitle
            // 
            this.lb_groupsTitle.AutoSize = true;
            this.lb_groupsTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_groupsTitle.Location = new System.Drawing.Point(6, 158);
            this.lb_groupsTitle.Name = "lb_groupsTitle";
            this.lb_groupsTitle.Size = new System.Drawing.Size(60, 18);
            this.lb_groupsTitle.TabIndex = 4;
            this.lb_groupsTitle.Text = "Групи : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розкладToolStripMenuItem,
            this.adminToolStrip,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "ms_monitoring";
            // 
            // lb_currentPair
            // 
            this.lb_currentPair.AutoSize = true;
            this.lb_currentPair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_currentPair.Location = new System.Drawing.Point(78, 124);
            this.lb_currentPair.Name = "lb_currentPair";
            this.lb_currentPair.Size = new System.Drawing.Size(0, 18);
            this.lb_currentPair.TabIndex = 9;
            // 
            // lb_currentRoom
            // 
            this.lb_currentRoom.AutoSize = true;
            this.lb_currentRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_currentRoom.Location = new System.Drawing.Point(78, 146);
            this.lb_currentRoom.Name = "lb_currentRoom";
            this.lb_currentRoom.Size = new System.Drawing.Size(0, 18);
            this.lb_currentRoom.TabIndex = 10;
            // 
            // lb_currentGroups
            // 
            this.lb_currentGroups.AutoSize = true;
            this.lb_currentGroups.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_currentGroups.Location = new System.Drawing.Point(78, 166);
            this.lb_currentGroups.Name = "lb_currentGroups";
            this.lb_currentGroups.Size = new System.Drawing.Size(0, 18);
            this.lb_currentGroups.TabIndex = 11;
            // 
            // lb_pairDateTitle
            // 
            this.lb_pairDateTitle.AutoSize = true;
            this.lb_pairDateTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_pairDateTitle.Location = new System.Drawing.Point(6, 49);
            this.lb_pairDateTitle.Name = "lb_pairDateTitle";
            this.lb_pairDateTitle.Size = new System.Drawing.Size(56, 18);
            this.lb_pairDateTitle.TabIndex = 16;
            this.lb_pairDateTitle.Text = "Дата : ";
            // 
            // lb_pairDate
            // 
            this.lb_pairDate.AutoSize = true;
            this.lb_pairDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_pairDate.Location = new System.Drawing.Point(78, 124);
            this.lb_pairDate.Name = "lb_pairDate";
            this.lb_pairDate.Size = new System.Drawing.Size(0, 18);
            this.lb_pairDate.TabIndex = 17;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(434, 245);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 35);
            this.btn_exit.TabIndex = 49;
            this.btn_exit.Text = "Вийти";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Поточна пара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(343, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Наступна пара";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_pairDateTitle);
            this.panel1.Controls.Add(this.tb_nextPairGroups);
            this.panel1.Controls.Add(this.tb_nextPairRoom);
            this.panel1.Controls.Add(this.tb_nextPairSubj);
            this.panel1.Controls.Add(this.lb_groupsTitle);
            this.panel1.Controls.Add(this.tb_nextPairDate);
            this.panel1.Controls.Add(this.lb_roomTitle);
            this.panel1.Controls.Add(this.tb_currGroups);
            this.panel1.Controls.Add(this.lb_pairNameTitle);
            this.panel1.Controls.Add(this.tb_currRoom);
            this.panel1.Controls.Add(this.tb_currSubject);
            this.panel1.Controls.Add(this.tb_currPairDate);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 202);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(318, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 185);
            this.panel2.TabIndex = 53;
            // 
            // tb_nextPairGroups
            // 
            this.tb_nextPairGroups.BackColor = System.Drawing.Color.White;
            this.tb_nextPairGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nextPairGroups.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nextPairGroups.Location = new System.Drawing.Point(346, 156);
            this.tb_nextPairGroups.Name = "tb_nextPairGroups";
            this.tb_nextPairGroups.ReadOnly = true;
            this.tb_nextPairGroups.Size = new System.Drawing.Size(172, 26);
            this.tb_nextPairGroups.TabIndex = 7;
            // 
            // tb_nextPairRoom
            // 
            this.tb_nextPairRoom.BackColor = System.Drawing.Color.White;
            this.tb_nextPairRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nextPairRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nextPairRoom.Location = new System.Drawing.Point(346, 120);
            this.tb_nextPairRoom.Name = "tb_nextPairRoom";
            this.tb_nextPairRoom.ReadOnly = true;
            this.tb_nextPairRoom.Size = new System.Drawing.Size(172, 26);
            this.tb_nextPairRoom.TabIndex = 6;
            // 
            // tb_nextPairSubj
            // 
            this.tb_nextPairSubj.BackColor = System.Drawing.Color.White;
            this.tb_nextPairSubj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nextPairSubj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nextPairSubj.Location = new System.Drawing.Point(346, 85);
            this.tb_nextPairSubj.Name = "tb_nextPairSubj";
            this.tb_nextPairSubj.ReadOnly = true;
            this.tb_nextPairSubj.Size = new System.Drawing.Size(172, 26);
            this.tb_nextPairSubj.TabIndex = 5;
            // 
            // tb_nextPairDate
            // 
            this.tb_nextPairDate.BackColor = System.Drawing.Color.White;
            this.tb_nextPairDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nextPairDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nextPairDate.Location = new System.Drawing.Point(346, 47);
            this.tb_nextPairDate.Name = "tb_nextPairDate";
            this.tb_nextPairDate.ReadOnly = true;
            this.tb_nextPairDate.Size = new System.Drawing.Size(172, 26);
            this.tb_nextPairDate.TabIndex = 4;
            // 
            // tb_currGroups
            // 
            this.tb_currGroups.BackColor = System.Drawing.Color.White;
            this.tb_currGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_currGroups.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_currGroups.Location = new System.Drawing.Point(121, 156);
            this.tb_currGroups.Name = "tb_currGroups";
            this.tb_currGroups.ReadOnly = true;
            this.tb_currGroups.Size = new System.Drawing.Size(176, 26);
            this.tb_currGroups.TabIndex = 3;
            // 
            // tb_currRoom
            // 
            this.tb_currRoom.BackColor = System.Drawing.Color.White;
            this.tb_currRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_currRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_currRoom.Location = new System.Drawing.Point(121, 120);
            this.tb_currRoom.Name = "tb_currRoom";
            this.tb_currRoom.ReadOnly = true;
            this.tb_currRoom.Size = new System.Drawing.Size(176, 26);
            this.tb_currRoom.TabIndex = 2;
            // 
            // tb_currSubject
            // 
            this.tb_currSubject.BackColor = System.Drawing.Color.White;
            this.tb_currSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_currSubject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_currSubject.Location = new System.Drawing.Point(121, 85);
            this.tb_currSubject.Name = "tb_currSubject";
            this.tb_currSubject.ReadOnly = true;
            this.tb_currSubject.Size = new System.Drawing.Size(176, 26);
            this.tb_currSubject.TabIndex = 1;
            // 
            // tb_currPairDate
            // 
            this.tb_currPairDate.BackColor = System.Drawing.Color.White;
            this.tb_currPairDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_currPairDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_currPairDate.Location = new System.Drawing.Point(121, 47);
            this.tb_currPairDate.Name = "tb_currPairDate";
            this.tb_currPairDate.ReadOnly = true;
            this.tb_currPairDate.Size = new System.Drawing.Size(176, 26);
            this.tb_currPairDate.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gold;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 290);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(562, 22);
            this.statusStrip1.TabIndex = 55;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_changePair
            // 
            this.btn_changePair.FlatAppearance.BorderSize = 0;
            this.btn_changePair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_changePair.Image = global::Client.Properties.Resources.changeя;
            this.btn_changePair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_changePair.Location = new System.Drawing.Point(174, 245);
            this.btn_changePair.Name = "btn_changePair";
            this.btn_changePair.Size = new System.Drawing.Size(140, 35);
            this.btn_changePair.TabIndex = 54;
            this.btn_changePair.Text = "Змінити пару";
            this.btn_changePair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changePair.UseVisualStyleBackColor = true;
            this.btn_changePair.Click += new System.EventHandler(this.btn_changePair_Click);
            // 
            // btn_deginWork
            // 
            this.btn_deginWork.FlatAppearance.BorderSize = 0;
            this.btn_deginWork.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_deginWork.Image = global::Client.Properties.Resources.Иконка_стрелки_вправо__ei__svg;
            this.btn_deginWork.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deginWork.Location = new System.Drawing.Point(12, 245);
            this.btn_deginWork.Name = "btn_deginWork";
            this.btn_deginWork.Size = new System.Drawing.Size(156, 35);
            this.btn_deginWork.TabIndex = 53;
            this.btn_deginWork.Text = "Почати роботу";
            this.btn_deginWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deginWork.UseVisualStyleBackColor = true;
            this.btn_deginWork.Click += new System.EventHandler(this.btn_deginWork_Click);
            // 
            // розкладToolStripMenuItem
            // 
            this.розкладToolStripMenuItem.Image = global::Client.Properties.Resources.todo;
            this.розкладToolStripMenuItem.Name = "розкладToolStripMenuItem";
            this.розкладToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.розкладToolStripMenuItem.Text = "Розклад";
            this.розкладToolStripMenuItem.Click += new System.EventHandler(this.розкладToolStripMenuItem_Click);
            // 
            // adminToolStrip
            // 
            this.adminToolStrip.Image = global::Client.Properties.Resources.w128h1281338911352group;
            this.adminToolStrip.Name = "adminToolStrip";
            this.adminToolStrip.Size = new System.Drawing.Size(127, 20);
            this.adminToolStrip.Text = "Адміністрування";
            this.adminToolStrip.Click += new System.EventHandler(this.групиToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Image = global::Client.Properties.Resources.Setting_icon;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(562, 312);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_changePair);
            this.Controls.Add(this.btn_deginWork);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lb_pairDate);
            this.Controls.Add(this.lb_currentGroups);
            this.Controls.Add(this.lb_currentRoom);
            this.Controls.Add(this.lb_currentPair);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне меню";
            this.Load += new System.EventHandler(this.WorkForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_pairNameTitle;
        private System.Windows.Forms.Label lb_roomTitle;
        private System.Windows.Forms.Label lb_groupsTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem розкладToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStrip;
        private System.Windows.Forms.Label lb_currentPair;
        private System.Windows.Forms.Label lb_currentRoom;
        private System.Windows.Forms.Label lb_currentGroups;
        private System.Windows.Forms.Label lb_pairDateTitle;
        private System.Windows.Forms.Label lb_pairDate;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_nextPairGroups;
        private System.Windows.Forms.TextBox tb_nextPairRoom;
        private System.Windows.Forms.TextBox tb_nextPairSubj;
        private System.Windows.Forms.TextBox tb_nextPairDate;
        private System.Windows.Forms.TextBox tb_currGroups;
        private System.Windows.Forms.TextBox tb_currRoom;
        private System.Windows.Forms.TextBox tb_currSubject;
        private System.Windows.Forms.TextBox tb_currPairDate;
        private System.Windows.Forms.Button btn_deginWork;
        private System.Windows.Forms.Button btn_changePair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}