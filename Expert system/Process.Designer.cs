namespace Systemes_Experts
{
    partial class Process
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
            this.datadgv = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premisse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.strategyLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.regledgv = new System.Windows.Forms.DataGridView();
            this.numCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bfdgv = new System.Windows.Forms.DataGridView();
            this.numCycleBF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datadgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regledgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bfdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // datadgv
            // 
            this.datadgv.AllowUserToAddRows = false;
            this.datadgv.AllowUserToDeleteRows = false;
            this.datadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.premisse,
            this.Conclusion});
            this.datadgv.Location = new System.Drawing.Point(16, 95);
            this.datadgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datadgv.Name = "datadgv";
            this.datadgv.ReadOnly = true;
            this.datadgv.Size = new System.Drawing.Size(615, 345);
            this.datadgv.TabIndex = 0;
            // 
            // num
            // 
            this.num.HeaderText = "Num";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 50;
            // 
            // premisse
            // 
            this.premisse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.premisse.HeaderText = "Premisse";
            this.premisse.Name = "premisse";
            this.premisse.ReadOnly = true;
            // 
            // Conclusion
            // 
            this.Conclusion.HeaderText = "Conclusion";
            this.Conclusion.Name = "Conclusion";
            this.Conclusion.ReadOnly = true;
            this.Conclusion.Width = 150;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des règles choisis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1139, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "La base des faits";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(659, 403);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultat:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.resultLabel.Location = new System.Drawing.Point(783, 403);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(597, 28);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stratégie:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // strategyLabel
            // 
            this.strategyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strategyLabel.Location = new System.Drawing.Point(790, 96);
            this.strategyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.strategyLabel.Name = "strategyLabel";
            this.strategyLabel.Size = new System.Drawing.Size(579, 59);
            this.strategyLabel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(19, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1361, 58);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precessus Chainage Avant";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regledgv
            // 
            this.regledgv.AllowUserToAddRows = false;
            this.regledgv.AllowUserToDeleteRows = false;
            this.regledgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regledgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCycle,
            this.regles});
            this.regledgv.Location = new System.Drawing.Point(653, 193);
            this.regledgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regledgv.Name = "regledgv";
            this.regledgv.ReadOnly = true;
            this.regledgv.Size = new System.Drawing.Size(353, 185);
            this.regledgv.TabIndex = 8;
            // 
            // numCycle
            // 
            this.numCycle.HeaderText = "Num cycle";
            this.numCycle.Name = "numCycle";
            this.numCycle.ReadOnly = true;
            this.numCycle.Width = 80;
            // 
            // regles
            // 
            this.regles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regles.HeaderText = "Règles";
            this.regles.Name = "regles";
            this.regles.ReadOnly = true;
            // 
            // bfdgv
            // 
            this.bfdgv.AllowUserToAddRows = false;
            this.bfdgv.AllowUserToDeleteRows = false;
            this.bfdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bfdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCycleBF,
            this.bf});
            this.bfdgv.Location = new System.Drawing.Point(1027, 193);
            this.bfdgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bfdgv.Name = "bfdgv";
            this.bfdgv.ReadOnly = true;
            this.bfdgv.Size = new System.Drawing.Size(356, 185);
            this.bfdgv.TabIndex = 9;
            // 
            // numCycleBF
            // 
            this.numCycleBF.HeaderText = "Num cycle";
            this.numCycleBF.Name = "numCycleBF";
            this.numCycleBF.ReadOnly = true;
            this.numCycleBF.Width = 80;
            // 
            // bf
            // 
            this.bf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bf.HeaderText = "BF";
            this.bf.Name = "bf";
            this.bf.ReadOnly = true;
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1393, 452);
            this.Controls.Add(this.bfdgv);
            this.Controls.Add(this.regledgv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.strategyLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datadgv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Process";
            this.Text = "Process";
            this.Load += new System.EventHandler(this.Process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datadgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regledgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bfdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datadgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label strategyLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView regledgv;
        private System.Windows.Forms.DataGridView bfdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn premisse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conclusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn regles;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCycleBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn bf;
    }
}