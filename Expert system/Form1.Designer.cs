namespace Systemes_Experts
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
            this.reglesdgv = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premisse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AjouterRegleBtn = new System.Windows.Forms.Button();
            this.Faitdgv = new System.Windows.Forms.DataGridView();
            this.faits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faitCombo = new System.Windows.Forms.ComboBox();
            this.ajouterFaitBtn = new System.Windows.Forms.Button();
            this.but = new System.Windows.Forms.Label();
            this.butCombo = new System.Windows.Forms.ComboBox();
            this.butBtn = new System.Windows.Forms.Button();
            this.normalStrategyRadio = new System.Windows.Forms.RadioButton();
            this.otherStrategyRadio = new System.Windows.Forms.RadioButton();
            this.testBtn = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteFait = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reglesdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Faitdgv)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // reglesdgv
            // 
            this.reglesdgv.AllowUserToAddRows = false;
            this.reglesdgv.AllowUserToDeleteRows = false;
            this.reglesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reglesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.premisse,
            this.conclusion});
            this.reglesdgv.Location = new System.Drawing.Point(12, 70);
            this.reglesdgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reglesdgv.Name = "reglesdgv";
            this.reglesdgv.ReadOnly = true;
            this.reglesdgv.RowHeadersWidth = 51;
            this.reglesdgv.RowTemplate.Height = 24;
            this.reglesdgv.Size = new System.Drawing.Size(607, 368);
            this.reglesdgv.TabIndex = 0;
            // 
            // num
            // 
            this.num.FillWeight = 76.14214F;
            this.num.HeaderText = "Num";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 50;
            // 
            // premisse
            // 
            this.premisse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.premisse.FillWeight = 7.614212F;
            this.premisse.HeaderText = "Premisses";
            this.premisse.MinimumWidth = 6;
            this.premisse.Name = "premisse";
            this.premisse.ReadOnly = true;
            // 
            // conclusion
            // 
            this.conclusion.FillWeight = 216.2437F;
            this.conclusion.HeaderText = "Conclusion";
            this.conclusion.MinimumWidth = 6;
            this.conclusion.Name = "conclusion";
            this.conclusion.ReadOnly = true;
            this.conclusion.Width = 150;
            // 
            // AjouterRegleBtn
            // 
            this.AjouterRegleBtn.Location = new System.Drawing.Point(488, 455);
            this.AjouterRegleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AjouterRegleBtn.Name = "AjouterRegleBtn";
            this.AjouterRegleBtn.Size = new System.Drawing.Size(131, 46);
            this.AjouterRegleBtn.TabIndex = 1;
            this.AjouterRegleBtn.Text = "Ajouter une regle";
            this.AjouterRegleBtn.UseVisualStyleBackColor = true;
            this.AjouterRegleBtn.Click += new System.EventHandler(this.AjouterRegleBtn_Click);
            // 
            // Faitdgv
            // 
            this.Faitdgv.AllowUserToAddRows = false;
            this.Faitdgv.AllowUserToDeleteRows = false;
            this.Faitdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Faitdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faits});
            this.Faitdgv.Location = new System.Drawing.Point(653, 70);
            this.Faitdgv.Margin = new System.Windows.Forms.Padding(4);
            this.Faitdgv.Name = "Faitdgv";
            this.Faitdgv.ReadOnly = true;
            this.Faitdgv.RowHeadersWidth = 51;
            this.Faitdgv.Size = new System.Drawing.Size(187, 258);
            this.Faitdgv.TabIndex = 2;
            // 
            // faits
            // 
            this.faits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.faits.HeaderText = "Faits";
            this.faits.MinimumWidth = 6;
            this.faits.Name = "faits";
            this.faits.ReadOnly = true;
            // 
            // faitCombo
            // 
            this.faitCombo.FormattingEnabled = true;
            this.faitCombo.Location = new System.Drawing.Point(653, 352);
            this.faitCombo.Margin = new System.Windows.Forms.Padding(4);
            this.faitCombo.Name = "faitCombo";
            this.faitCombo.Size = new System.Drawing.Size(185, 24);
            this.faitCombo.TabIndex = 3;
            // 
            // ajouterFaitBtn
            // 
            this.ajouterFaitBtn.Location = new System.Drawing.Point(757, 399);
            this.ajouterFaitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ajouterFaitBtn.Name = "ajouterFaitBtn";
            this.ajouterFaitBtn.Size = new System.Drawing.Size(83, 39);
            this.ajouterFaitBtn.TabIndex = 4;
            this.ajouterFaitBtn.Text = "Ajouter";
            this.ajouterFaitBtn.UseVisualStyleBackColor = true;
            this.ajouterFaitBtn.Click += new System.EventHandler(this.ajouterFaitBtn_Click);
            // 
            // but
            // 
            this.but.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but.Location = new System.Drawing.Point(895, 216);
            this.but.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(133, 28);
            this.but.TabIndex = 5;
            this.but.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butCombo
            // 
            this.butCombo.FormattingEnabled = true;
            this.butCombo.Location = new System.Drawing.Point(880, 115);
            this.butCombo.Margin = new System.Windows.Forms.Padding(4);
            this.butCombo.Name = "butCombo";
            this.butCombo.Size = new System.Drawing.Size(160, 24);
            this.butCombo.TabIndex = 6;
            // 
            // butBtn
            // 
            this.butBtn.Location = new System.Drawing.Point(897, 166);
            this.butBtn.Margin = new System.Windows.Forms.Padding(4);
            this.butBtn.Name = "butBtn";
            this.butBtn.Size = new System.Drawing.Size(129, 36);
            this.butBtn.TabIndex = 7;
            this.butBtn.Text = "Choisir un but";
            this.butBtn.UseVisualStyleBackColor = true;
            this.butBtn.Click += new System.EventHandler(this.butBtn_Click);
            // 
            // normalStrategyRadio
            // 
            this.normalStrategyRadio.Location = new System.Drawing.Point(32, 39);
            this.normalStrategyRadio.Margin = new System.Windows.Forms.Padding(4);
            this.normalStrategyRadio.Name = "normalStrategyRadio";
            this.normalStrategyRadio.Size = new System.Drawing.Size(128, 61);
            this.normalStrategyRadio.TabIndex = 8;
            this.normalStrategyRadio.TabStop = true;
            this.normalStrategyRadio.Text = "Choisir la règle dans l’ordre d’apparition des règles";
            this.normalStrategyRadio.UseVisualStyleBackColor = true;
            // 
            // otherStrategyRadio
            // 
            this.otherStrategyRadio.Location = new System.Drawing.Point(32, 110);
            this.otherStrategyRadio.Margin = new System.Windows.Forms.Padding(4);
            this.otherStrategyRadio.Name = "otherStrategyRadio";
            this.otherStrategyRadio.Size = new System.Drawing.Size(128, 61);
            this.otherStrategyRadio.TabIndex = 9;
            this.otherStrategyRadio.TabStop = true;
            this.otherStrategyRadio.Text = "Choisir la règle ayant le plus de prémisses";
            this.otherStrategyRadio.UseVisualStyleBackColor = true;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(943, 455);
            this.testBtn.Margin = new System.Windows.Forms.Padding(4);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(141, 46);
            this.testBtn.TabIndex = 10;
            this.testBtn.Text = "Tester";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.normalStrategyRadio);
            this.groupBox.Controls.Add(this.otherStrategyRadio);
            this.groupBox.Location = new System.Drawing.Point(881, 258);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(183, 180);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Stratégie";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(910, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Liste des buts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1072, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Insertion des données";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteFait
            // 
            this.deleteFait.Location = new System.Drawing.Point(650, 399);
            this.deleteFait.Name = "deleteFait";
            this.deleteFait.Size = new System.Drawing.Size(100, 39);
            this.deleteFait.TabIndex = 14;
            this.deleteFait.Text = "Supprimer";
            this.deleteFait.UseVisualStyleBackColor = true;
            this.deleteFait.Click += new System.EventHandler(this.deleteFait_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 526);
            this.Controls.Add(this.deleteFait);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.butBtn);
            this.Controls.Add(this.butCombo);
            this.Controls.Add(this.but);
            this.Controls.Add(this.ajouterFaitBtn);
            this.Controls.Add(this.faitCombo);
            this.Controls.Add(this.Faitdgv);
            this.Controls.Add(this.AjouterRegleBtn);
            this.Controls.Add(this.reglesdgv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reglesdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Faitdgv)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reglesdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn premisse;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusion;
        private System.Windows.Forms.Button AjouterRegleBtn;
        private System.Windows.Forms.DataGridView Faitdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn faits;
        private System.Windows.Forms.ComboBox faitCombo;
        private System.Windows.Forms.Button ajouterFaitBtn;
        private System.Windows.Forms.Label but;
        private System.Windows.Forms.ComboBox butCombo;
        private System.Windows.Forms.Button butBtn;
        private System.Windows.Forms.RadioButton normalStrategyRadio;
        private System.Windows.Forms.RadioButton otherStrategyRadio;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteFait;
    }
}

