
namespace Pclasses
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MatTxt = new System.Windows.Forms.TextBox();
            this.NomeTxt = new System.Windows.Forms.TextBox();
            this.SalTXt = new System.Windows.Forms.TextBox();
            this.NumHoras = new System.Windows.Forms.TextBox();
            this.DataEntTxt = new System.Windows.Forms.TextBox();
            this.Falta = new System.Windows.Forms.TextBox();
            this.InstantBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHomeS = new System.Windows.Forms.RadioButton();
            this.rdHomeN = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário por hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de horas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de  entrada na emrpesa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "dias de Faltas";
            // 
            // MatTxt
            // 
            this.MatTxt.Location = new System.Drawing.Point(163, 25);
            this.MatTxt.Name = "MatTxt";
            this.MatTxt.Size = new System.Drawing.Size(329, 20);
            this.MatTxt.TabIndex = 6;
            // 
            // NomeTxt
            // 
            this.NomeTxt.Location = new System.Drawing.Point(163, 52);
            this.NomeTxt.Name = "NomeTxt";
            this.NomeTxt.Size = new System.Drawing.Size(329, 20);
            this.NomeTxt.TabIndex = 7;
            // 
            // SalTXt
            // 
            this.SalTXt.Location = new System.Drawing.Point(163, 78);
            this.SalTXt.Name = "SalTXt";
            this.SalTXt.Size = new System.Drawing.Size(329, 20);
            this.SalTXt.TabIndex = 8;
            // 
            // NumHoras
            // 
            this.NumHoras.Location = new System.Drawing.Point(163, 103);
            this.NumHoras.Name = "NumHoras";
            this.NumHoras.Size = new System.Drawing.Size(329, 20);
            this.NumHoras.TabIndex = 9;
            // 
            // DataEntTxt
            // 
            this.DataEntTxt.Location = new System.Drawing.Point(163, 139);
            this.DataEntTxt.Name = "DataEntTxt";
            this.DataEntTxt.Size = new System.Drawing.Size(329, 20);
            this.DataEntTxt.TabIndex = 10;
            // 
            // Falta
            // 
            this.Falta.Location = new System.Drawing.Point(163, 171);
            this.Falta.Name = "Falta";
            this.Falta.Size = new System.Drawing.Size(329, 20);
            this.Falta.TabIndex = 11;
            // 
            // InstantBtn
            // 
            this.InstantBtn.Location = new System.Drawing.Point(16, 208);
            this.InstantBtn.Name = "InstantBtn";
            this.InstantBtn.Size = new System.Drawing.Size(202, 64);
            this.InstantBtn.TabIndex = 12;
            this.InstantBtn.Text = "instanciar";
            this.InstantBtn.UseVisualStyleBackColor = true;
            this.InstantBtn.Click += new System.EventHandler(this.InstantBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHomeN);
            this.groupBox1.Controls.Add(this.rdHomeS);
            this.groupBox1.Location = new System.Drawing.Point(516, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 145);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "homeOffice";
            // 
            // rdHomeS
            // 
            this.rdHomeS.AutoSize = true;
            this.rdHomeS.Location = new System.Drawing.Point(7, 20);
            this.rdHomeS.Name = "rdHomeS";
            this.rdHomeS.Size = new System.Drawing.Size(40, 17);
            this.rdHomeS.TabIndex = 0;
            this.rdHomeS.TabStop = true;
            this.rdHomeS.Text = "sim";
            this.rdHomeS.UseVisualStyleBackColor = true;
            // 
            // rdHomeN
            // 
            this.rdHomeN.AutoSize = true;
            this.rdHomeN.Location = new System.Drawing.Point(6, 52);
            this.rdHomeN.Name = "rdHomeN";
            this.rdHomeN.Size = new System.Drawing.Size(43, 17);
            this.rdHomeN.TabIndex = 1;
            this.rdHomeN.TabStop = true;
            this.rdHomeN.Text = "não";
            this.rdHomeN.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InstantBtn);
            this.Controls.Add(this.Falta);
            this.Controls.Add(this.DataEntTxt);
            this.Controls.Add(this.NumHoras);
            this.Controls.Add(this.SalTXt);
            this.Controls.Add(this.NomeTxt);
            this.Controls.Add(this.MatTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MatTxt;
        private System.Windows.Forms.TextBox NomeTxt;
        private System.Windows.Forms.TextBox SalTXt;
        private System.Windows.Forms.TextBox NumHoras;
        private System.Windows.Forms.TextBox DataEntTxt;
        private System.Windows.Forms.TextBox Falta;
        private System.Windows.Forms.Button InstantBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHomeN;
        private System.Windows.Forms.RadioButton rdHomeS;
    }
}