namespace Dbsys.Forms
{
    partial class Frm_Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin_Dashboard));
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(89, 66);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.Size = new System.Drawing.Size(453, 280);
            this.dgv_main.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Linen;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "User:";
            // 
            // toolStripStatusUser
            // 
            this.toolStripStatusUser.Name = "toolStripStatusUser";
            this.toolStripStatusUser.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusUser.Text = "NA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Linen;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.homePageToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(700, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(84, 461);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.editInfoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(77, 19);
            this.fileToolStripMenuItem.Text = "Settings";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userToolStripMenuItem.Text = "Accounts";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createUserToolStripMenuItem.Text = "Edit User Accounts";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home Page";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.logOutToolStripMenuItem.Text = "Sign out";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "User\'s";
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewUsersToolStripMenuItem.Text = "View User\'s";
            // 
            // editInfoToolStripMenuItem
            // 
            this.editInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminInformationToolStripMenuItem});
            this.editInfoToolStripMenuItem.Name = "editInfoToolStripMenuItem";
            this.editInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editInfoToolStripMenuItem.Text = "Edit Info";
            // 
            // adminInformationToolStripMenuItem
            // 
            this.adminInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsInformationToolStripMenuItem});
            this.adminInformationToolStripMenuItem.Name = "adminInformationToolStripMenuItem";
            this.adminInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminInformationToolStripMenuItem.Text = "Admin Information";
            // 
            // studentsInformationToolStripMenuItem
            // 
            this.studentsInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffInformationToolStripMenuItem});
            this.studentsInformationToolStripMenuItem.Name = "studentsInformationToolStripMenuItem";
            this.studentsInformationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.studentsInformationToolStripMenuItem.Text = "Student\'s Information";
            // 
            // staffInformationToolStripMenuItem
            // 
            this.staffInformationToolStripMenuItem.Name = "staffInformationToolStripMenuItem";
            this.staffInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.staffInformationToolStripMenuItem.Text = "Staff Information";
            // 
            // Frm_Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgv_main);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Admin_Dashboard";
            this.Text = "Frm_Admin_Dashboard";
            this.Load += new System.EventHandler(this.Frm_Admin_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffInformationToolStripMenuItem;
    }
}