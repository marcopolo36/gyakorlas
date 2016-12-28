namespace WargameWinForms
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddWarrior = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelFaj = new System.Windows.Forms.Label();
            this.comboBoxHarcosTipusa = new System.Windows.Forms.ComboBox();
            this.labelTamadoE = new System.Windows.Forms.Label();
            this.checkBoxTamadoE = new System.Windows.Forms.CheckBox();
            this.labelSzarmazas = new System.Windows.Forms.Label();
            this.textBoxSzarmazas = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBattle = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.lbxMessages = new System.Windows.Forms.ListBox();
            this.lbxWarriors = new System.Windows.Forms.ListBox();
            this.buttonVeletlen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 254);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Harcos hozzáadása";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddWarrior, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFaj, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxHarcosTipusa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTamadoE, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxTamadoE, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelSzarmazas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSzarmazas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonVeletlen, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 222);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // btnAddWarrior
            // 
            this.btnAddWarrior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddWarrior.Location = new System.Drawing.Point(3, 195);
            this.btnAddWarrior.Name = "btnAddWarrior";
            this.btnAddWarrior.Size = new System.Drawing.Size(266, 24);
            this.btnAddWarrior.TabIndex = 3;
            this.btnAddWarrior.Text = "Hozzáadás";
            this.btnAddWarrior.UseVisualStyleBackColor = true;
            this.btnAddWarrior.Click += new System.EventHandler(this.btnAddWarrior_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(275, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            // 
            // labelFaj
            // 
            this.labelFaj.AutoSize = true;
            this.labelFaj.Location = new System.Drawing.Point(3, 48);
            this.labelFaj.Name = "labelFaj";
            this.labelFaj.Size = new System.Drawing.Size(21, 13);
            this.labelFaj.TabIndex = 8;
            this.labelFaj.Text = "Faj";
            // 
            // comboBoxHarcosTipusa
            // 
            this.comboBoxHarcosTipusa.FormattingEnabled = true;
            this.comboBoxHarcosTipusa.Items.AddRange(new object[] {
            "Ember",
            "Szörny"});
            this.comboBoxHarcosTipusa.Location = new System.Drawing.Point(275, 51);
            this.comboBoxHarcosTipusa.Name = "comboBoxHarcosTipusa";
            this.comboBoxHarcosTipusa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHarcosTipusa.TabIndex = 9;
            this.comboBoxHarcosTipusa.SelectedIndexChanged += new System.EventHandler(this.comboBoxHarcosTipusa_SelectedIndexChanged);
            // 
            // labelTamadoE
            // 
            this.labelTamadoE.AutoSize = true;
            this.labelTamadoE.Location = new System.Drawing.Point(3, 144);
            this.labelTamadoE.Name = "labelTamadoE";
            this.labelTamadoE.Size = new System.Drawing.Size(61, 13);
            this.labelTamadoE.TabIndex = 6;
            this.labelTamadoE.Text = "Támadó-e?";
            // 
            // checkBoxTamadoE
            // 
            this.checkBoxTamadoE.AutoSize = true;
            this.checkBoxTamadoE.Location = new System.Drawing.Point(275, 147);
            this.checkBoxTamadoE.Name = "checkBoxTamadoE";
            this.checkBoxTamadoE.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTamadoE.TabIndex = 7;
            this.checkBoxTamadoE.UseVisualStyleBackColor = true;
            // 
            // labelSzarmazas
            // 
            this.labelSzarmazas.AutoSize = true;
            this.labelSzarmazas.Location = new System.Drawing.Point(3, 96);
            this.labelSzarmazas.Name = "labelSzarmazas";
            this.labelSzarmazas.Size = new System.Drawing.Size(64, 13);
            this.labelSzarmazas.TabIndex = 10;
            this.labelSzarmazas.Text = "[Szarmazás]";
            // 
            // textBoxSzarmazas
            // 
            this.textBoxSzarmazas.Location = new System.Drawing.Point(275, 99);
            this.textBoxSzarmazas.Name = "textBoxSzarmazas";
            this.textBoxSzarmazas.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzarmazas.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBattle);
            this.tabPage2.Controls.Add(this.btnDeleteSelected);
            this.tabPage2.Controls.Add(this.lbxMessages);
            this.tabPage2.Controls.Add(this.lbxWarriors);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Csata";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBattle
            // 
            this.btnBattle.Location = new System.Drawing.Point(106, 198);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(86, 23);
            this.btnBattle.TabIndex = 3;
            this.btnBattle.Text = "Csata indítása";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(8, 198);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(92, 23);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Kijelölt törlése";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // lbxMessages
            // 
            this.lbxMessages.FormattingEnabled = true;
            this.lbxMessages.Location = new System.Drawing.Point(198, 6);
            this.lbxMessages.Name = "lbxMessages";
            this.lbxMessages.Size = new System.Drawing.Size(344, 212);
            this.lbxMessages.TabIndex = 1;
            // 
            // lbxWarriors
            // 
            this.lbxWarriors.FormattingEnabled = true;
            this.lbxWarriors.Location = new System.Drawing.Point(8, 6);
            this.lbxWarriors.Name = "lbxWarriors";
            this.lbxWarriors.Size = new System.Drawing.Size(184, 186);
            this.lbxWarriors.TabIndex = 0;
            // 
            // buttonVeletlen
            // 
            this.buttonVeletlen.Location = new System.Drawing.Point(275, 195);
            this.buttonVeletlen.Name = "buttonVeletlen";
            this.buttonVeletlen.Size = new System.Drawing.Size(264, 23);
            this.buttonVeletlen.TabIndex = 12;
            this.buttonVeletlen.Text = "Véletlenszerű értékek";
            this.buttonVeletlen.UseVisualStyleBackColor = true;
            this.buttonVeletlen.Click += new System.EventHandler(this.buttonVeletlen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 254);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Wargame Winforms";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddWarrior;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.ListBox lbxMessages;
        private System.Windows.Forms.ListBox lbxWarriors;
        private System.Windows.Forms.Label labelTamadoE;
        private System.Windows.Forms.CheckBox checkBoxTamadoE;
        private System.Windows.Forms.Label labelFaj;
        private System.Windows.Forms.ComboBox comboBoxHarcosTipusa;
        private System.Windows.Forms.Label labelSzarmazas;
        private System.Windows.Forms.TextBox textBoxSzarmazas;
        private System.Windows.Forms.Button buttonVeletlen;
    }
}

