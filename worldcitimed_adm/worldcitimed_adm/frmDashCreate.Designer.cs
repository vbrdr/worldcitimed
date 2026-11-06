namespace worldcitimed_adm
{
    partial class frmDashCreate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToDashboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnCreate = new System.Windows.Forms.Panel();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.backToDashboToolStripMenuItem,
            this.backToDashboardToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.createAccountToolStripMenuItem.Text = "Create Admin Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // backToDashboToolStripMenuItem
            // 
            this.backToDashboToolStripMenuItem.Name = "backToDashboToolStripMenuItem";
            this.backToDashboToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.backToDashboToolStripMenuItem.Text = "Create Staff Account";
            this.backToDashboToolStripMenuItem.Click += new System.EventHandler(this.backToDashboToolStripMenuItem_Click);
            // 
            // backToDashboardToolStripMenuItem
            // 
            this.backToDashboardToolStripMenuItem.Name = "backToDashboardToolStripMenuItem";
            this.backToDashboardToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.backToDashboardToolStripMenuItem.Text = "Back to Dashboard";
            this.backToDashboardToolStripMenuItem.Click += new System.EventHandler(this.backToDashboardToolStripMenuItem_Click);
            // 
            // pnCreate
            // 
            this.pnCreate.Location = new System.Drawing.Point(0, 140);
            this.pnCreate.Name = "pnCreate";
            this.pnCreate.Size = new System.Drawing.Size(743, 369);
            this.pnCreate.TabIndex = 18;
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "Admin Account",
            "Staff Account"});
            this.cbSelect.Location = new System.Drawing.Point(120, 113);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(202, 21);
            this.cbSelect.TabIndex = 19;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::worldcitimed_adm.Properties.Resources.Screenshot_2025_04_26_213459;
            this.pictureBox1.Location = new System.Drawing.Point(267, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmDashCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.pnCreate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToDashboToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem backToDashboardToolStripMenuItem;
        private System.Windows.Forms.Panel pnCreate;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label1;
    }
}