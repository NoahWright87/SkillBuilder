namespace SkillBuilder
{
    partial class frmPartsEditor
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
            this.cboPartType = new System.Windows.Forms.ComboBox();
            this.lstParts = new System.Windows.Forms.ListBox();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.grpPartInfo = new System.Windows.Forms.GroupBox();
            this.lblExample = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.txtDescription3 = new System.Windows.Forms.TextBox();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.txtDescription2 = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblSPCost = new System.Windows.Forms.Label();
            this.lblMPCost = new System.Windows.Forms.Label();
            this.lblHPCost = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.numSPCost = new System.Windows.Forms.NumericUpDown();
            this.numMPCost = new System.Windows.Forms.NumericUpDown();
            this.numHPCost = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.numModCostFactor = new System.Windows.Forms.NumericUpDown();
            this.numTechCostFactor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPartInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSPCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMPCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHPCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModCostFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTechCostFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPartType
            // 
            this.cboPartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartType.FormattingEnabled = true;
            this.cboPartType.Location = new System.Drawing.Point(12, 12);
            this.cboPartType.Name = "cboPartType";
            this.cboPartType.Size = new System.Drawing.Size(121, 21);
            this.cboPartType.TabIndex = 0;
            this.cboPartType.SelectedIndexChanged += new System.EventHandler(this.cboPartType_SelectedIndexChanged);
            // 
            // lstParts
            // 
            this.lstParts.FormattingEnabled = true;
            this.lstParts.Location = new System.Drawing.Point(12, 39);
            this.lstParts.Name = "lstParts";
            this.lstParts.Size = new System.Drawing.Size(227, 147);
            this.lstParts.TabIndex = 1;
            this.lstParts.SelectedIndexChanged += new System.EventHandler(this.lstParts_SelectedIndexChanged);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(245, 38);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 2;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Location = new System.Drawing.Point(245, 68);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePart.TabIndex = 3;
            this.btnRemovePart.Text = "Remove";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // grpPartInfo
            // 
            this.grpPartInfo.Controls.Add(this.lblType);
            this.grpPartInfo.Controls.Add(this.lblExample);
            this.grpPartInfo.Controls.Add(this.cboType);
            this.grpPartInfo.Controls.Add(this.label3);
            this.grpPartInfo.Controls.Add(this.lblDescription3);
            this.grpPartInfo.Controls.Add(this.txtDescription3);
            this.grpPartInfo.Controls.Add(this.lblDescription2);
            this.grpPartInfo.Controls.Add(this.txtDescription2);
            this.grpPartInfo.Controls.Add(this.lblSPCost);
            this.grpPartInfo.Controls.Add(this.lblMPCost);
            this.grpPartInfo.Controls.Add(this.lblHPCost);
            this.grpPartInfo.Controls.Add(this.lblDescription);
            this.grpPartInfo.Controls.Add(this.lblName);
            this.grpPartInfo.Controls.Add(this.lblId);
            this.grpPartInfo.Controls.Add(this.numSPCost);
            this.grpPartInfo.Controls.Add(this.numMPCost);
            this.grpPartInfo.Controls.Add(this.numHPCost);
            this.grpPartInfo.Controls.Add(this.txtDescription);
            this.grpPartInfo.Controls.Add(this.txtName);
            this.grpPartInfo.Controls.Add(this.txtId);
            this.grpPartInfo.Location = new System.Drawing.Point(14, 192);
            this.grpPartInfo.Name = "grpPartInfo";
            this.grpPartInfo.Size = new System.Drawing.Size(797, 304);
            this.grpPartInfo.TabIndex = 0;
            this.grpPartInfo.TabStop = false;
            this.grpPartInfo.Text = "Part Info";
            // 
            // lblExample
            // 
            this.lblExample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExample.Location = new System.Drawing.Point(48, 212);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(743, 89);
            this.lblExample.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Example use:";
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.Location = new System.Drawing.Point(48, 126);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(69, 13);
            this.lblDescription3.TabIndex = 10;
            this.lblDescription3.Text = "Description 3";
            // 
            // txtDescription3
            // 
            this.txtDescription3.Location = new System.Drawing.Point(124, 123);
            this.txtDescription3.Name = "txtDescription3";
            this.txtDescription3.Size = new System.Drawing.Size(221, 20);
            this.txtDescription3.TabIndex = 4;
            this.txtDescription3.TextChanged += new System.EventHandler(this.UpdateDescription);
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Location = new System.Drawing.Point(48, 100);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(69, 13);
            this.lblDescription2.TabIndex = 9;
            this.lblDescription2.Text = "Description 2";
            // 
            // txtDescription2
            // 
            this.txtDescription2.Location = new System.Drawing.Point(125, 97);
            this.txtDescription2.Name = "txtDescription2";
            this.txtDescription2.Size = new System.Drawing.Size(221, 20);
            this.txtDescription2.TabIndex = 3;
            this.txtDescription2.TextChanged += new System.EventHandler(this.UpdateDescription);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(82, 152);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(124, 149);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(220, 21);
            this.cboType.TabIndex = 5;
            // 
            // lblSPCost
            // 
            this.lblSPCost.AutoSize = true;
            this.lblSPCost.Location = new System.Drawing.Point(442, 126);
            this.lblSPCost.Name = "lblSPCost";
            this.lblSPCost.Size = new System.Drawing.Size(69, 13);
            this.lblSPCost.TabIndex = 17;
            this.lblSPCost.Text = "Stamina Cost";
            // 
            // lblMPCost
            // 
            this.lblMPCost.AutoSize = true;
            this.lblMPCost.Location = new System.Drawing.Point(453, 100);
            this.lblMPCost.Name = "lblMPCost";
            this.lblMPCost.Size = new System.Drawing.Size(58, 13);
            this.lblMPCost.TabIndex = 15;
            this.lblMPCost.Text = "Mana Cost";
            // 
            // lblHPCost
            // 
            this.lblHPCost.AutoSize = true;
            this.lblHPCost.Location = new System.Drawing.Point(449, 74);
            this.lblHPCost.Name = "lblHPCost";
            this.lblHPCost.Size = new System.Drawing.Size(62, 13);
            this.lblHPCost.TabIndex = 16;
            this.lblHPCost.Text = "Health Cost";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(57, 74);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(82, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(101, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id";
            // 
            // numSPCost
            // 
            this.numSPCost.Location = new System.Drawing.Point(517, 124);
            this.numSPCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSPCost.Name = "numSPCost";
            this.numSPCost.Size = new System.Drawing.Size(75, 20);
            this.numSPCost.TabIndex = 14;
            // 
            // numMPCost
            // 
            this.numMPCost.Location = new System.Drawing.Point(517, 98);
            this.numMPCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMPCost.Name = "numMPCost";
            this.numMPCost.Size = new System.Drawing.Size(75, 20);
            this.numMPCost.TabIndex = 13;
            // 
            // numHPCost
            // 
            this.numHPCost.Location = new System.Drawing.Point(517, 72);
            this.numHPCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHPCost.Name = "numHPCost";
            this.numHPCost.Size = new System.Drawing.Size(75, 20);
            this.numHPCost.TabIndex = 12;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(124, 71);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(221, 20);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextChanged += new System.EventHandler(this.UpdateDescription);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 19);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // numModCostFactor
            // 
            this.numModCostFactor.DecimalPlaces = 2;
            this.numModCostFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numModCostFactor.Location = new System.Drawing.Point(570, 41);
            this.numModCostFactor.Name = "numModCostFactor";
            this.numModCostFactor.Size = new System.Drawing.Size(120, 20);
            this.numModCostFactor.TabIndex = 5;
            // 
            // numTechCostFactor
            // 
            this.numTechCostFactor.DecimalPlaces = 2;
            this.numTechCostFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTechCostFactor.Location = new System.Drawing.Point(570, 69);
            this.numTechCostFactor.Name = "numTechCostFactor";
            this.numTechCostFactor.Size = new System.Drawing.Size(120, 20);
            this.numTechCostFactor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modifier Cost Factor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Technique Cost Factor";
            // 
            // frmPartsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTechCostFactor);
            this.Controls.Add(this.numModCostFactor);
            this.Controls.Add(this.grpPartInfo);
            this.Controls.Add(this.btnRemovePart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.lstParts);
            this.Controls.Add(this.cboPartType);
            this.Name = "frmPartsEditor";
            this.Text = "Parts Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPartsEditor_FormClosing);
            this.grpPartInfo.ResumeLayout(false);
            this.grpPartInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSPCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMPCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHPCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModCostFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTechCostFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPartType;
        private System.Windows.Forms.ListBox lstParts;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.GroupBox grpPartInfo;
        private System.Windows.Forms.NumericUpDown numSPCost;
        private System.Windows.Forms.NumericUpDown numMPCost;
        private System.Windows.Forms.NumericUpDown numHPCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblSPCost;
        private System.Windows.Forms.Label lblMPCost;
        private System.Windows.Forms.Label lblHPCost;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown numModCostFactor;
        private System.Windows.Forms.NumericUpDown numTechCostFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblDescription3;
        private System.Windows.Forms.TextBox txtDescription3;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.TextBox txtDescription2;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Label label3;
    }
}