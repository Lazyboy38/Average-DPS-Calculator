namespace Average_DPS_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioADPS = new System.Windows.Forms.RadioButton();
            this.radioDPS = new System.Windows.Forms.RadioButton();
            this.inputRLD = new System.Windows.Forms.TextBox();
            this.inputMAG = new System.Windows.Forms.TextBox();
            this.inputROF = new System.Windows.Forms.TextBox();
            this.inputDMG = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearW1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearW2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioADPS2 = new System.Windows.Forms.RadioButton();
            this.radioDPS2 = new System.Windows.Forms.RadioButton();
            this.inputRLD2 = new System.Windows.Forms.TextBox();
            this.inputMAG2 = new System.Windows.Forms.TextBox();
            this.inputROF2 = new System.Windows.Forms.TextBox();
            this.inputDMG2 = new System.Windows.Forms.TextBox();
            this.btnCalcBoth = new System.Windows.Forms.Button();
            this.lbWeapon1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbWeapon2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioComTtl = new System.Windows.Forms.RadioButton();
            this.radioComAvg = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            resources.ApplyResources(this.btnCalc, "btnCalc");
            this.btnCalc.Name = "btnCalc";
            this.toolTip1.SetToolTip(this.btnCalc, resources.GetString("btnCalc.ToolTip"));
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.radioADPS);
            this.groupBox1.Controls.Add(this.radioDPS);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // radioADPS
            // 
            resources.ApplyResources(this.radioADPS, "radioADPS");
            this.radioADPS.Name = "radioADPS";
            this.radioADPS.TabStop = true;
            this.toolTip1.SetToolTip(this.radioADPS, resources.GetString("radioADPS.ToolTip"));
            this.radioADPS.UseVisualStyleBackColor = true;
            this.radioADPS.CheckedChanged += new System.EventHandler(this.RadioADPS_CheckedChanged);
            // 
            // radioDPS
            // 
            resources.ApplyResources(this.radioDPS, "radioDPS");
            this.radioDPS.Name = "radioDPS";
            this.radioDPS.TabStop = true;
            this.toolTip1.SetToolTip(this.radioDPS, resources.GetString("radioDPS.ToolTip"));
            this.radioDPS.UseVisualStyleBackColor = true;
            this.radioDPS.CheckedChanged += new System.EventHandler(this.RadioDPS_CheckedChanged);
            // 
            // inputRLD
            // 
            resources.ApplyResources(this.inputRLD, "inputRLD");
            this.inputRLD.Name = "inputRLD";
            this.toolTip1.SetToolTip(this.inputRLD, resources.GetString("inputRLD.ToolTip"));
            // 
            // inputMAG
            // 
            resources.ApplyResources(this.inputMAG, "inputMAG");
            this.inputMAG.Name = "inputMAG";
            this.toolTip1.SetToolTip(this.inputMAG, resources.GetString("inputMAG.ToolTip"));
            // 
            // inputROF
            // 
            resources.ApplyResources(this.inputROF, "inputROF");
            this.inputROF.Name = "inputROF";
            this.toolTip1.SetToolTip(this.inputROF, resources.GetString("inputROF.ToolTip"));
            // 
            // inputDMG
            // 
            resources.ApplyResources(this.inputDMG, "inputDMG");
            this.inputDMG.Name = "inputDMG";
            this.toolTip1.SetToolTip(this.inputDMG, resources.GetString("inputDMG.ToolTip"));
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.btnClearW1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnCalc);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.inputRLD);
            this.groupBox3.Controls.Add(this.inputMAG);
            this.groupBox3.Controls.Add(this.inputROF);
            this.groupBox3.Controls.Add(this.inputDMG);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // btnClearW1
            // 
            resources.ApplyResources(this.btnClearW1, "btnClearW1");
            this.btnClearW1.BackColor = System.Drawing.Color.Firebrick;
            this.btnClearW1.Name = "btnClearW1";
            this.toolTip1.SetToolTip(this.btnClearW1, resources.GetString("btnClearW1.ToolTip"));
            this.btnClearW1.UseVisualStyleBackColor = false;
            this.btnClearW1.Click += new System.EventHandler(this.BtnClearW1_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.BackColor = System.Drawing.Color.Gray;
            this.groupBox4.Controls.Add(this.btnClearW2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnCalc2);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.inputRLD2);
            this.groupBox4.Controls.Add(this.inputMAG2);
            this.groupBox4.Controls.Add(this.inputROF2);
            this.groupBox4.Controls.Add(this.inputDMG2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // btnClearW2
            // 
            resources.ApplyResources(this.btnClearW2, "btnClearW2");
            this.btnClearW2.BackColor = System.Drawing.Color.Firebrick;
            this.btnClearW2.Name = "btnClearW2";
            this.toolTip1.SetToolTip(this.btnClearW2, resources.GetString("btnClearW2.ToolTip"));
            this.btnClearW2.UseVisualStyleBackColor = false;
            this.btnClearW2.Click += new System.EventHandler(this.BtnClearW2_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // btnCalc2
            // 
            resources.ApplyResources(this.btnCalc2, "btnCalc2");
            this.btnCalc2.Name = "btnCalc2";
            this.toolTip1.SetToolTip(this.btnCalc2, resources.GetString("btnCalc2.ToolTip"));
            this.btnCalc2.UseVisualStyleBackColor = true;
            this.btnCalc2.Click += new System.EventHandler(this.BtnCalc2_Click);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.radioADPS2);
            this.groupBox5.Controls.Add(this.radioDPS2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox5, resources.GetString("groupBox5.ToolTip"));
            // 
            // radioADPS2
            // 
            resources.ApplyResources(this.radioADPS2, "radioADPS2");
            this.radioADPS2.Name = "radioADPS2";
            this.radioADPS2.TabStop = true;
            this.toolTip1.SetToolTip(this.radioADPS2, resources.GetString("radioADPS2.ToolTip"));
            this.radioADPS2.UseVisualStyleBackColor = true;
            this.radioADPS2.CheckedChanged += new System.EventHandler(this.RadioADPS2_CheckedChanged);
            // 
            // radioDPS2
            // 
            resources.ApplyResources(this.radioDPS2, "radioDPS2");
            this.radioDPS2.Name = "radioDPS2";
            this.radioDPS2.TabStop = true;
            this.toolTip1.SetToolTip(this.radioDPS2, resources.GetString("radioDPS2.ToolTip"));
            this.radioDPS2.UseVisualStyleBackColor = true;
            this.radioDPS2.CheckedChanged += new System.EventHandler(this.RadioDPS2_CheckedChanged);
            // 
            // inputRLD2
            // 
            resources.ApplyResources(this.inputRLD2, "inputRLD2");
            this.inputRLD2.Name = "inputRLD2";
            this.toolTip1.SetToolTip(this.inputRLD2, resources.GetString("inputRLD2.ToolTip"));
            // 
            // inputMAG2
            // 
            resources.ApplyResources(this.inputMAG2, "inputMAG2");
            this.inputMAG2.Name = "inputMAG2";
            this.toolTip1.SetToolTip(this.inputMAG2, resources.GetString("inputMAG2.ToolTip"));
            // 
            // inputROF2
            // 
            resources.ApplyResources(this.inputROF2, "inputROF2");
            this.inputROF2.Name = "inputROF2";
            this.toolTip1.SetToolTip(this.inputROF2, resources.GetString("inputROF2.ToolTip"));
            // 
            // inputDMG2
            // 
            resources.ApplyResources(this.inputDMG2, "inputDMG2");
            this.inputDMG2.Name = "inputDMG2";
            this.toolTip1.SetToolTip(this.inputDMG2, resources.GetString("inputDMG2.ToolTip"));
            // 
            // btnCalcBoth
            // 
            resources.ApplyResources(this.btnCalcBoth, "btnCalcBoth");
            this.btnCalcBoth.BackColor = System.Drawing.Color.Sienna;
            this.btnCalcBoth.Name = "btnCalcBoth";
            this.toolTip1.SetToolTip(this.btnCalcBoth, resources.GetString("btnCalcBoth.ToolTip"));
            this.btnCalcBoth.UseVisualStyleBackColor = false;
            this.btnCalcBoth.Click += new System.EventHandler(this.BtnCalcBoth_Click);
            // 
            // lbWeapon1
            // 
            resources.ApplyResources(this.lbWeapon1, "lbWeapon1");
            this.lbWeapon1.BackColor = System.Drawing.Color.White;
            this.lbWeapon1.Name = "lbWeapon1";
            this.toolTip1.SetToolTip(this.lbWeapon1, resources.GetString("lbWeapon1.ToolTip"));
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.Name = "btnClear";
            this.toolTip1.SetToolTip(this.btnClear, resources.GetString("btnClear.ToolTip"));
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lbWeapon2
            // 
            resources.ApplyResources(this.lbWeapon2, "lbWeapon2");
            this.lbWeapon2.BackColor = System.Drawing.Color.White;
            this.lbWeapon2.Name = "lbWeapon2";
            this.toolTip1.SetToolTip(this.lbWeapon2, resources.GetString("lbWeapon2.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.radioComTtl);
            this.groupBox2.Controls.Add(this.radioComAvg);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // radioComTtl
            // 
            resources.ApplyResources(this.radioComTtl, "radioComTtl");
            this.radioComTtl.Name = "radioComTtl";
            this.radioComTtl.TabStop = true;
            this.toolTip1.SetToolTip(this.radioComTtl, resources.GetString("radioComTtl.ToolTip"));
            this.radioComTtl.UseVisualStyleBackColor = true;
            this.radioComTtl.CheckedChanged += new System.EventHandler(this.RadioComTtl_CheckedChanged);
            // 
            // radioComAvg
            // 
            resources.ApplyResources(this.radioComAvg, "radioComAvg");
            this.radioComAvg.Name = "radioComAvg";
            this.radioComAvg.TabStop = true;
            this.toolTip1.SetToolTip(this.radioComAvg, resources.GetString("radioComAvg.ToolTip"));
            this.radioComAvg.UseVisualStyleBackColor = true;
            this.radioComAvg.CheckedChanged += new System.EventHandler(this.RadioComAvg_CheckedChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // deutschToolStripMenuItem
            // 
            resources.ApplyResources(this.deutschToolStripMenuItem, "deutschToolStripMenuItem");
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            this.deutschToolStripMenuItem.Click += new System.EventHandler(this.deutschToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalcBoth);
            this.Controls.Add(this.lbWeapon2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbWeapon1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioADPS;
        private System.Windows.Forms.RadioButton radioDPS;
        private System.Windows.Forms.TextBox inputRLD;
        private System.Windows.Forms.TextBox inputMAG;
        private System.Windows.Forms.TextBox inputROF;
        private System.Windows.Forms.TextBox inputDMG;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalc2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioADPS2;
        private System.Windows.Forms.RadioButton radioDPS2;
        private System.Windows.Forms.TextBox inputRLD2;
        private System.Windows.Forms.TextBox inputMAG2;
        private System.Windows.Forms.TextBox inputROF2;
        private System.Windows.Forms.TextBox inputDMG2;
        private System.Windows.Forms.Button btnCalcBoth;
        private System.Windows.Forms.Label lbWeapon1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbWeapon2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioComTtl;
        private System.Windows.Forms.RadioButton radioComAvg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearW1;
        private System.Windows.Forms.Button btnClearW2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

