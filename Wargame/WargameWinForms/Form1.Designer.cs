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
            this.tbDefense = new System.Windows.Forms.TextBox();
            this.tbAttack = new System.Windows.Forms.TextBox();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRandomise = new System.Windows.Forms.Button();
            this.btnAddWarrior = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBattle = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.lbxMessages = new System.Windows.Forms.ListBox();
            this.lbxWarriors = new System.Windows.Forms.ListBox();
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
            this.tabControl1.Size = new System.Drawing.Size(558, 255);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Harcos hozzáadása";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbDefense, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbAttack, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbHP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRandomise, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAddWarrior, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 223);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbDefense
            // 
            this.tbDefense.Location = new System.Drawing.Point(275, 147);
            this.tbDefense.Name = "tbDefense";
            this.tbDefense.Size = new System.Drawing.Size(100, 20);
            this.tbDefense.TabIndex = 7;
            // 
            // tbAttack
            // 
            this.tbAttack.Location = new System.Drawing.Point(275, 99);
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.Size = new System.Drawing.Size(100, 20);
            this.tbAttack.TabIndex = 6;
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(275, 51);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(100, 20);
            this.tbHP.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Védés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Támadás";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Életerő";
            // 
            // btnRandomise
            // 
            this.btnRandomise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRandomise.Location = new System.Drawing.Point(275, 195);
            this.btnRandomise.Name = "btnRandomise";
            this.btnRandomise.Size = new System.Drawing.Size(266, 25);
            this.btnRandomise.TabIndex = 2;
            this.btnRandomise.Text = "Véletlenszerű értékek";
            this.btnRandomise.UseVisualStyleBackColor = true;
            this.btnRandomise.Click += new System.EventHandler(this.btnRandomise_Click);
            // 
            // btnAddWarrior
            // 
            this.btnAddWarrior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddWarrior.Location = new System.Drawing.Point(3, 195);
            this.btnAddWarrior.Name = "btnAddWarrior";
            this.btnAddWarrior.Size = new System.Drawing.Size(266, 25);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBattle);
            this.tabPage2.Controls.Add(this.btnDeleteSelected);
            this.tabPage2.Controls.Add(this.lbxMessages);
            this.tabPage2.Controls.Add(this.lbxWarriors);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 229);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 255);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRandomise;
        private System.Windows.Forms.Button btnAddWarrior;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbDefense;
        private System.Windows.Forms.TextBox tbAttack;
        private System.Windows.Forms.TextBox tbHP;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.ListBox lbxMessages;
        private System.Windows.Forms.ListBox lbxWarriors;
    }
}

