namespace SkillBuilder
{
    partial class frmSkillCrafter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cboSkill = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skillPartsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // skillPartsToolStripMenuItem
            // 
            this.skillPartsToolStripMenuItem.Name = "skillPartsToolStripMenuItem";
            this.skillPartsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.skillPartsToolStripMenuItem.Text = "Skill Parts";
            this.skillPartsToolStripMenuItem.Click += new System.EventHandler(this.skillPartsToolStripMenuItem_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 10;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(12, 81);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 5;
            this.lblCost.Text = "Cost";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Location = new System.Drawing.Point(13, 107);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(640, 52);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // cboSkill
            // 
            this.cboSkill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill.FormattingEnabled = true;
            this.cboSkill.Location = new System.Drawing.Point(12, 37);
            this.cboSkill.Name = "cboSkill";
            this.cboSkill.Size = new System.Drawing.Size(641, 21);
            this.cboSkill.TabIndex = 7;
            this.cboSkill.SelectedIndexChanged += new System.EventHandler(this.cboSkill_SelectedIndexChanged);
            // 
            // frmSkillCrafter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(665, 632);
            this.Controls.Add(this.cboSkill);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSkillCrafter";
            this.Text = "Skill Crafter";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmSkillCrafter_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillPartsToolStripMenuItem;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cboSkill;
    }
}

