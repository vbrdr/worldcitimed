namespace worldcitimed_adm
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.ttdash = new System.Windows.Forms.ToolTip(this.components);
            this.msDASH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnHMO = new System.Windows.Forms.Button();
            this.btnADM = new System.Windows.Forms.Button();
            this.btnOPD = new System.Windows.Forms.Button();
            this.btnCASH = new System.Windows.Forms.Button();
            this.btnBILL = new System.Windows.Forms.Button();
            this.btnPH = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "940 Aurora Boulevard, Quezon City, Metro Manila";
            // 
            // pMain
            // 
            this.pMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMain.Location = new System.Drawing.Point(278, -9);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(465, 524);
            this.pMain.TabIndex = 20;
            // 
            // msDASH
            // 
            this.msDASH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCreate,
            this.tsmLogout,
            this.logoutToolStripMenuItem});
            this.msDASH.Name = "msDASH";
            this.msDASH.Size = new System.Drawing.Size(60, 24);
            this.msDASH.Text = "Menu";
            // 
            // tsmCreate
            // 
            this.tsmCreate.Name = "tsmCreate";
            this.tsmCreate.Size = new System.Drawing.Size(171, 26);
            this.tsmCreate.Text = "Account";
            this.tsmCreate.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(171, 26);
            this.tsmLogout.Text = "Print Report";
            this.tsmLogout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msDASH});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnHMO
            // 
            this.btnHMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHMO.Image = global::worldcitimed_adm.Properties.Resources.appro__1_;
            this.btnHMO.Location = new System.Drawing.Point(14, 425);
            this.btnHMO.Name = "btnHMO";
            this.btnHMO.Size = new System.Drawing.Size(252, 51);
            this.btnHMO.TabIndex = 26;
            this.btnHMO.Text = " HMO Approval";
            this.btnHMO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHMO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHMO.UseVisualStyleBackColor = true;
            this.btnHMO.Click += new System.EventHandler(this.btnHMO_Click);
            // 
            // btnADM
            // 
            this.btnADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADM.Image = global::worldcitimed_adm.Properties.Resources.admit__1_;
            this.btnADM.Location = new System.Drawing.Point(14, 368);
            this.btnADM.Name = "btnADM";
            this.btnADM.Size = new System.Drawing.Size(252, 51);
            this.btnADM.TabIndex = 25;
            this.btnADM.Text = "  Admission";
            this.btnADM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnADM.UseVisualStyleBackColor = true;
            this.btnADM.Click += new System.EventHandler(this.btnADM_Click);
            // 
            // btnOPD
            // 
            this.btnOPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPD.Image = global::worldcitimed_adm.Properties.Resources.regis__1_;
            this.btnOPD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOPD.Location = new System.Drawing.Point(14, 311);
            this.btnOPD.Name = "btnOPD";
            this.btnOPD.Size = new System.Drawing.Size(252, 51);
            this.btnOPD.TabIndex = 24;
            this.btnOPD.Text = " OPD Registration";
            this.btnOPD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOPD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOPD.UseVisualStyleBackColor = true;
            this.btnOPD.Click += new System.EventHandler(this.btnOPD_Click);
            // 
            // btnCASH
            // 
            this.btnCASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCASH.Image = global::worldcitimed_adm.Properties.Resources.cashier__2_;
            this.btnCASH.Location = new System.Drawing.Point(14, 254);
            this.btnCASH.Name = "btnCASH";
            this.btnCASH.Size = new System.Drawing.Size(252, 51);
            this.btnCASH.TabIndex = 23;
            this.btnCASH.Text = " Cashier";
            this.btnCASH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCASH.UseVisualStyleBackColor = true;
            this.btnCASH.Click += new System.EventHandler(this.btnCASH_Click);
            // 
            // btnBILL
            // 
            this.btnBILL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBILL.Image = global::worldcitimed_adm.Properties.Resources.billl__1_;
            this.btnBILL.Location = new System.Drawing.Point(14, 197);
            this.btnBILL.Name = "btnBILL";
            this.btnBILL.Size = new System.Drawing.Size(252, 51);
            this.btnBILL.TabIndex = 22;
            this.btnBILL.Text = " Billing";
            this.btnBILL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBILL.UseVisualStyleBackColor = true;
            this.btnBILL.Click += new System.EventHandler(this.btnBILL_Click);
            // 
            // btnPH
            // 
            this.btnPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPH.Image = global::worldcitimed_adm.Properties.Resources.ph__2___1_;
            this.btnPH.Location = new System.Drawing.Point(14, 140);
            this.btnPH.Name = "btnPH";
            this.btnPH.Size = new System.Drawing.Size(252, 51);
            this.btnPH.TabIndex = 21;
            this.btnPH.Text = "PhilHealth";
            this.btnPH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPH.UseVisualStyleBackColor = true;
            this.btnPH.Click += new System.EventHandler(this.btnPH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::worldcitimed_adm.Properties.Resources.Screenshot_2025_04_26_213459;
            this.pictureBox1.Location = new System.Drawing.Point(32, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AcceptButton = this.btnHMO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 505);
            this.Controls.Add(this.btnHMO);
            this.Controls.Add(this.btnADM);
            this.Controls.Add(this.btnOPD);
            this.Controls.Add(this.btnCASH);
            this.Controls.Add(this.btnBILL);
            this.Controls.Add(this.btnPH);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnPH;
        private System.Windows.Forms.Button btnBILL;
        private System.Windows.Forms.Button btnCASH;
        private System.Windows.Forms.Button btnOPD;
        private System.Windows.Forms.Button btnADM;
        private System.Windows.Forms.Button btnHMO;
        private System.Windows.Forms.ToolTip ttdash;
        private System.Windows.Forms.ToolStripMenuItem msDASH;
        private System.Windows.Forms.ToolStripMenuItem tsmCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}