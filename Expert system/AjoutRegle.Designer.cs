namespace Systemes_Experts
{
    partial class AjoutRegle
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
            this.RegleTxtbox = new System.Windows.Forms.TextBox();
            this.NonBtn = new System.Windows.Forms.Button();
            this.PermisseTxtbox = new System.Windows.Forms.TextBox();
            this.PremisseBtn = new System.Windows.Forms.Button();
            this.ConclusionTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmerBtn = new System.Windows.Forms.Button();
            this.AnuulerBtn = new System.Windows.Forms.Button();
            this.etBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Si";
            // 
            // RegleTxtbox
            // 
            this.RegleTxtbox.Location = new System.Drawing.Point(61, 92);
            this.RegleTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegleTxtbox.Multiline = true;
            this.RegleTxtbox.Name = "RegleTxtbox";
            this.RegleTxtbox.ReadOnly = true;
            this.RegleTxtbox.Size = new System.Drawing.Size(352, 40);
            this.RegleTxtbox.TabIndex = 1;
            // 
            // NonBtn
            // 
            this.NonBtn.Location = new System.Drawing.Point(15, 176);
            this.NonBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NonBtn.Name = "NonBtn";
            this.NonBtn.Size = new System.Drawing.Size(49, 48);
            this.NonBtn.TabIndex = 2;
            this.NonBtn.Text = "Non";
            this.NonBtn.UseVisualStyleBackColor = true;
            this.NonBtn.Click += new System.EventHandler(this.NonBtn_Click);
            // 
            // PermisseTxtbox
            // 
            this.PermisseTxtbox.Location = new System.Drawing.Point(87, 207);
            this.PermisseTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PermisseTxtbox.Name = "PermisseTxtbox";
            this.PermisseTxtbox.Size = new System.Drawing.Size(121, 22);
            this.PermisseTxtbox.TabIndex = 3;
            // 
            // PremisseBtn
            // 
            this.PremisseBtn.Location = new System.Drawing.Point(87, 166);
            this.PremisseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PremisseBtn.Name = "PremisseBtn";
            this.PremisseBtn.Size = new System.Drawing.Size(123, 33);
            this.PremisseBtn.TabIndex = 5;
            this.PremisseBtn.Text = "Premisse";
            this.PremisseBtn.UseVisualStyleBackColor = true;
            this.PremisseBtn.Click += new System.EventHandler(this.PremisseBtn_Click);
            // 
            // ConclusionTxtbox
            // 
            this.ConclusionTxtbox.Location = new System.Drawing.Point(481, 102);
            this.ConclusionTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConclusionTxtbox.Name = "ConclusionTxtbox";
            this.ConclusionTxtbox.Size = new System.Drawing.Size(139, 22);
            this.ConclusionTxtbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ajouter une nouvelle règle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "alors";
            // 
            // ConfirmerBtn
            // 
            this.ConfirmerBtn.Location = new System.Drawing.Point(481, 174);
            this.ConfirmerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmerBtn.Name = "ConfirmerBtn";
            this.ConfirmerBtn.Size = new System.Drawing.Size(125, 52);
            this.ConfirmerBtn.TabIndex = 11;
            this.ConfirmerBtn.Text = "Confirmer";
            this.ConfirmerBtn.UseVisualStyleBackColor = true;
            this.ConfirmerBtn.Click += new System.EventHandler(this.ConfirmerBtn_Click);
            // 
            // AnuulerBtn
            // 
            this.AnuulerBtn.Location = new System.Drawing.Point(320, 185);
            this.AnuulerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnuulerBtn.Name = "AnuulerBtn";
            this.AnuulerBtn.Size = new System.Drawing.Size(93, 33);
            this.AnuulerBtn.TabIndex = 12;
            this.AnuulerBtn.Text = "Annuler";
            this.AnuulerBtn.UseVisualStyleBackColor = true;
            this.AnuulerBtn.Click += new System.EventHandler(this.AnuulerBtn_Click);
            // 
            // etBtn
            // 
            this.etBtn.Location = new System.Drawing.Point(244, 176);
            this.etBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.etBtn.Name = "etBtn";
            this.etBtn.Size = new System.Drawing.Size(49, 48);
            this.etBtn.TabIndex = 13;
            this.etBtn.Text = "ET";
            this.etBtn.UseVisualStyleBackColor = true;
            this.etBtn.Click += new System.EventHandler(this.etBtn_Click);
            // 
            // AjoutRegle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 250);
            this.Controls.Add(this.etBtn);
            this.Controls.Add(this.AnuulerBtn);
            this.Controls.Add(this.ConfirmerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConclusionTxtbox);
            this.Controls.Add(this.PremisseBtn);
            this.Controls.Add(this.PermisseTxtbox);
            this.Controls.Add(this.NonBtn);
            this.Controls.Add(this.RegleTxtbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AjoutRegle";
            this.Text = "AjoutRegle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegleTxtbox;
        private System.Windows.Forms.Button NonBtn;
        private System.Windows.Forms.TextBox PermisseTxtbox;
        private System.Windows.Forms.Button PremisseBtn;
        private System.Windows.Forms.TextBox ConclusionTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConfirmerBtn;
        private System.Windows.Forms.Button AnuulerBtn;
        private System.Windows.Forms.Button etBtn;
    }
}