namespace Programari_cabinet_medical
{
    partial class Adaugare
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumePacient = new System.Windows.Forms.TextBox();
            this.tbOra = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpecializare = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume Pacient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ora:";
            // 
            // tbNumePacient
            // 
            this.tbNumePacient.Location = new System.Drawing.Point(95, 23);
            this.tbNumePacient.Name = "tbNumePacient";
            this.tbNumePacient.Size = new System.Drawing.Size(150, 20);
            this.tbNumePacient.TabIndex = 4;
            // 
            // tbOra
            // 
            this.tbOra.Location = new System.Drawing.Point(95, 79);
            this.tbOra.Name = "tbOra";
            this.tbOra.Size = new System.Drawing.Size(48, 20);
            this.tbOra.TabIndex = 5;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(95, 51);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(150, 20);
            this.dtpData.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Specialitate:";
            // 
            // cbSpecializare
            // 
            this.cbSpecializare.FormattingEnabled = true;
            this.cbSpecializare.Location = new System.Drawing.Point(95, 110);
            this.cbSpecializare.Name = "cbSpecializare";
            this.cbSpecializare.Size = new System.Drawing.Size(150, 21);
            this.cbSpecializare.TabIndex = 10;
            // 
            // Adaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 183);
            this.Controls.Add(this.cbSpecializare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.tbOra);
            this.Controls.Add(this.tbNumePacient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Adaugare";
            this.Text = "Adaugare";
            this.Load += new System.EventHandler(this.Adaugare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumePacient;
        private System.Windows.Forms.TextBox tbOra;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSpecializare;
    }
}