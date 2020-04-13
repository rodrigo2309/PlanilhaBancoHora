namespace PlanilhaBancoHora
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
            this.BtnGerar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskIntSegEnt1 = new System.Windows.Forms.MaskedTextBox();
            this.MskIntSegEnt2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskIntSegSai2 = new System.Windows.Forms.MaskedTextBox();
            this.MskIntSegSai1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGerar
            // 
            this.BtnGerar.Location = new System.Drawing.Point(140, 140);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(75, 23);
            this.BtnGerar.TabIndex = 0;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mês e Ano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intervalo em segundos(ENT) :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MskIntSegEnt1
            // 
            this.MskIntSegEnt1.Location = new System.Drawing.Point(165, 54);
            this.MskIntSegEnt1.Name = "MskIntSegEnt1";
            this.MskIntSegEnt1.Size = new System.Drawing.Size(29, 20);
            this.MskIntSegEnt1.TabIndex = 4;
            this.MskIntSegEnt1.Text = "50";
            // 
            // MskIntSegEnt2
            // 
            this.MskIntSegEnt2.Location = new System.Drawing.Point(216, 54);
            this.MskIntSegEnt2.Name = "MskIntSegEnt2";
            this.MskIntSegEnt2.Size = new System.Drawing.Size(29, 20);
            this.MskIntSegEnt2.TabIndex = 5;
            this.MskIntSegEnt2.Text = "59";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            // 
            // MskIntSegSai2
            // 
            this.MskIntSegSai2.Location = new System.Drawing.Point(216, 80);
            this.MskIntSegSai2.Name = "MskIntSegSai2";
            this.MskIntSegSai2.Size = new System.Drawing.Size(29, 20);
            this.MskIntSegSai2.TabIndex = 9;
            this.MskIntSegSai2.Text = "59";
            // 
            // MskIntSegSai1
            // 
            this.MskIntSegSai1.Location = new System.Drawing.Point(165, 80);
            this.MskIntSegSai1.Name = "MskIntSegSai1";
            this.MskIntSegSai1.Size = new System.Drawing.Size(29, 20);
            this.MskIntSegSai1.TabIndex = 8;
            this.MskIntSegSai1.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Intervalo em segundos(SAI) :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(371, 233);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskIntSegSai2);
            this.Controls.Add(this.MskIntSegSai1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MskIntSegEnt2);
            this.Controls.Add(this.MskIntSegEnt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskIntSegEnt1;
        private System.Windows.Forms.MaskedTextBox MskIntSegEnt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskIntSegSai2;
        private System.Windows.Forms.MaskedTextBox MskIntSegSai1;
        private System.Windows.Forms.Label label5;
    }
}

