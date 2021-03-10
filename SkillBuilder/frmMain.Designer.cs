namespace SkillBuilder
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCharacter = new System.Windows.Forms.ComboBox();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.grpCharacterInfo = new System.Windows.Forms.GroupBox();
            this.btnSaveCharacter = new System.Windows.Forms.Button();
            this.numSP = new System.Windows.Forms.NumericUpDown();
            this.numMP = new System.Windows.Forms.NumericUpDown();
            this.numHP = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGear = new System.Windows.Forms.Button();
            this.btnPassives = new System.Windows.Forms.Button();
            this.btnSkills = new System.Windows.Forms.Button();
            this.btnDeleteCharacter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCharacterInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Infinite Dungeon Crawl - Proof of Concept";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboCharacter
            // 
            this.cboCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCharacter.FormattingEnabled = true;
            this.cboCharacter.Items.AddRange(new object[] {
            "Add..."});
            this.cboCharacter.Location = new System.Drawing.Point(113, 50);
            this.cboCharacter.Name = "cboCharacter";
            this.cboCharacter.Size = new System.Drawing.Size(499, 21);
            this.cboCharacter.TabIndex = 1;
            this.cboCharacter.SelectedIndexChanged += new System.EventHandler(this.UpdateSelectedCharacter);
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Location = new System.Drawing.Point(12, 53);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(95, 13);
            this.lblCharacter.TabIndex = 2;
            this.lblCharacter.Text = "Select a Character";
            // 
            // grpCharacterInfo
            // 
            this.grpCharacterInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCharacterInfo.Controls.Add(this.btnSaveCharacter);
            this.grpCharacterInfo.Controls.Add(this.numSP);
            this.grpCharacterInfo.Controls.Add(this.numMP);
            this.grpCharacterInfo.Controls.Add(this.numHP);
            this.grpCharacterInfo.Controls.Add(this.txtName);
            this.grpCharacterInfo.Controls.Add(this.btnGear);
            this.grpCharacterInfo.Controls.Add(this.btnPassives);
            this.grpCharacterInfo.Controls.Add(this.btnSkills);
            this.grpCharacterInfo.Controls.Add(this.btnDeleteCharacter);
            this.grpCharacterInfo.Controls.Add(this.label7);
            this.grpCharacterInfo.Controls.Add(this.lblSP);
            this.grpCharacterInfo.Controls.Add(this.lblMP);
            this.grpCharacterInfo.Controls.Add(this.lblHP);
            this.grpCharacterInfo.Controls.Add(this.lblName);
            this.grpCharacterInfo.Location = new System.Drawing.Point(15, 77);
            this.grpCharacterInfo.Name = "grpCharacterInfo";
            this.grpCharacterInfo.Size = new System.Drawing.Size(597, 242);
            this.grpCharacterInfo.TabIndex = 3;
            this.grpCharacterInfo.TabStop = false;
            this.grpCharacterInfo.Text = "Character Info";
            // 
            // btnSaveCharacter
            // 
            this.btnSaveCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCharacter.Location = new System.Drawing.Point(465, 193);
            this.btnSaveCharacter.Name = "btnSaveCharacter";
            this.btnSaveCharacter.Size = new System.Drawing.Size(126, 43);
            this.btnSaveCharacter.TabIndex = 13;
            this.btnSaveCharacter.Text = "Save";
            this.btnSaveCharacter.UseVisualStyleBackColor = true;
            // 
            // numSP
            // 
            this.numSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numSP.DecimalPlaces = 2;
            this.numSP.ForeColor = System.Drawing.Color.White;
            this.numSP.Location = new System.Drawing.Point(98, 114);
            this.numSP.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numSP.Name = "numSP";
            this.numSP.Size = new System.Drawing.Size(166, 20);
            this.numSP.TabIndex = 12;
            // 
            // numMP
            // 
            this.numMP.BackColor = System.Drawing.Color.Blue;
            this.numMP.DecimalPlaces = 2;
            this.numMP.ForeColor = System.Drawing.Color.White;
            this.numMP.Location = new System.Drawing.Point(98, 88);
            this.numMP.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMP.Name = "numMP";
            this.numMP.Size = new System.Drawing.Size(166, 20);
            this.numMP.TabIndex = 11;
            // 
            // numHP
            // 
            this.numHP.BackColor = System.Drawing.Color.Red;
            this.numHP.DecimalPlaces = 2;
            this.numHP.ForeColor = System.Drawing.Color.White;
            this.numHP.Location = new System.Drawing.Point(98, 62);
            this.numHP.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numHP.Name = "numHP";
            this.numHP.Size = new System.Drawing.Size(166, 20);
            this.numHP.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 20);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnGear
            // 
            this.btnGear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGear.Enabled = false;
            this.btnGear.Location = new System.Drawing.Point(270, 193);
            this.btnGear.Name = "btnGear";
            this.btnGear.Size = new System.Drawing.Size(126, 43);
            this.btnGear.TabIndex = 8;
            this.btnGear.Text = "Gear";
            this.btnGear.UseVisualStyleBackColor = true;
            this.btnGear.Click += new System.EventHandler(this.btnGear_Click);
            // 
            // btnPassives
            // 
            this.btnPassives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPassives.Location = new System.Drawing.Point(138, 193);
            this.btnPassives.Name = "btnPassives";
            this.btnPassives.Size = new System.Drawing.Size(126, 43);
            this.btnPassives.TabIndex = 7;
            this.btnPassives.Text = "Passives";
            this.btnPassives.UseVisualStyleBackColor = true;
            this.btnPassives.Click += new System.EventHandler(this.btnPassives_Click);
            // 
            // btnSkills
            // 
            this.btnSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSkills.Location = new System.Drawing.Point(6, 193);
            this.btnSkills.Name = "btnSkills";
            this.btnSkills.Size = new System.Drawing.Size(126, 43);
            this.btnSkills.TabIndex = 6;
            this.btnSkills.Text = "Skills";
            this.btnSkills.UseVisualStyleBackColor = true;
            this.btnSkills.Click += new System.EventHandler(this.btnSkills_Click);
            // 
            // btnDeleteCharacter
            // 
            this.btnDeleteCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCharacter.Location = new System.Drawing.Point(516, 19);
            this.btnDeleteCharacter.Name = "btnDeleteCharacter";
            this.btnDeleteCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCharacter.TabIndex = 5;
            this.btnDeleteCharacter.Text = "Delete...";
            this.btnDeleteCharacter.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Other stats will go here later";
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(66, 116);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(24, 13);
            this.lblSP.TabIndex = 3;
            this.lblSP.Text = "SP:";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Location = new System.Drawing.Point(66, 90);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(26, 13);
            this.lblMP.TabIndex = 2;
            this.lblMP.Text = "MP:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(67, 64);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(25, 13);
            this.lblHP.TabIndex = 1;
            this.lblHP.Text = "HP:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skillsToolStripMenuItem,
            this.passivesToolStripMenuItem,
            this.gearToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // skillsToolStripMenuItem
            // 
            this.skillsToolStripMenuItem.Name = "skillsToolStripMenuItem";
            this.skillsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.skillsToolStripMenuItem.Text = "Skills...";
            // 
            // passivesToolStripMenuItem
            // 
            this.passivesToolStripMenuItem.Name = "passivesToolStripMenuItem";
            this.passivesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.passivesToolStripMenuItem.Text = "Passives...";
            // 
            // gearToolStripMenuItem
            // 
            this.gearToolStripMenuItem.Name = "gearToolStripMenuItem";
            this.gearToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.gearToolStripMenuItem.Text = "Gear...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 331);
            this.Controls.Add(this.grpCharacterInfo);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.cboCharacter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Dungeon Crawler POC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.grpCharacterInfo.ResumeLayout(false);
            this.grpCharacterInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCharacter;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.GroupBox grpCharacterInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnGear;
        private System.Windows.Forms.Button btnPassives;
        private System.Windows.Forms.Button btnSkills;
        private System.Windows.Forms.Button btnDeleteCharacter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numSP;
        private System.Windows.Forms.NumericUpDown numMP;
        private System.Windows.Forms.NumericUpDown numHP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSaveCharacter;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gearToolStripMenuItem;
    }
}