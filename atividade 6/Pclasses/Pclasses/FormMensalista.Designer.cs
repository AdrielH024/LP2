
namespace Pclasses
{
    partial class FormMensalista
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
            this.MatTxt = new System.Windows.Forms.TextBox();
            this.NomeTxt = new System.Windows.Forms.TextBox();
            this.SalTXt = new System.Windows.Forms.TextBox();
            this.DataEntTxt = new System.Windows.Forms.TextBox();
            this.Homeoffice = new System.Windows.Forms.GroupBox();
            this.HomeS = new System.Windows.Forms.RadioButton();
            this.HomeN = new System.Windows.Forms.RadioButton();
            this.instanciarBtn = new System.Windows.Forms.Button();
            this.InstParamBtn = new System.Windows.Forms.Button();
            this.Homeoffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "salário mensal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Entrada";
            // 
            // MatTxt
            // 
            this.MatTxt.Location = new System.Drawing.Point(104, 32);
            this.MatTxt.Name = "MatTxt";
            this.MatTxt.Size = new System.Drawing.Size(332, 20);
            this.MatTxt.TabIndex = 4;
            // 
            // NomeTxt
            // 
            this.NomeTxt.Location = new System.Drawing.Point(104, 58);
            this.NomeTxt.Name = "NomeTxt";
            this.NomeTxt.Size = new System.Drawing.Size(332, 20);
            this.NomeTxt.TabIndex = 5;
            // 
            // SalTXt
            // 
            this.SalTXt.Location = new System.Drawing.Point(104, 89);
            this.SalTXt.Name = "SalTXt";
            this.SalTXt.Size = new System.Drawing.Size(332, 20);
            this.SalTXt.TabIndex = 6;
            // 
            // DataEntTxt
            // 
            this.DataEntTxt.Location = new System.Drawing.Point(104, 115);
            this.DataEntTxt.Name = "DataEntTxt";
            this.DataEntTxt.Size = new System.Drawing.Size(332, 20);
            this.DataEntTxt.TabIndex = 7;
            // 
            // Homeoffice
            // 
            this.Homeoffice.Controls.Add(this.HomeN);
            this.Homeoffice.Controls.Add(this.HomeS);
            this.Homeoffice.Location = new System.Drawing.Point(478, 35);
            this.Homeoffice.Name = "Homeoffice";
            this.Homeoffice.Size = new System.Drawing.Size(140, 100);
            this.Homeoffice.TabIndex = 8;
            this.Homeoffice.TabStop = false;
            this.Homeoffice.Text = "Homeoffice";
            // 
            // HomeS
            // 
            this.HomeS.AutoSize = true;
            this.HomeS.Location = new System.Drawing.Point(7, 20);
            this.HomeS.Name = "HomeS";
            this.HomeS.Size = new System.Drawing.Size(40, 17);
            this.HomeS.TabIndex = 0;
            this.HomeS.TabStop = true;
            this.HomeS.Text = "sim";
            this.HomeS.UseVisualStyleBackColor = true;
            this.HomeS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // HomeN
            // 
            this.HomeN.AutoSize = true;
            this.HomeN.Location = new System.Drawing.Point(7, 54);
            this.HomeN.Name = "HomeN";
            this.HomeN.Size = new System.Drawing.Size(43, 17);
            this.HomeN.TabIndex = 1;
            this.HomeN.TabStop = true;
            this.HomeN.Text = "não";
            this.HomeN.UseVisualStyleBackColor = true;
            this.HomeN.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // instanciarBtn
            // 
            this.instanciarBtn.Location = new System.Drawing.Point(26, 155);
            this.instanciarBtn.Name = "instanciarBtn";
            this.instanciarBtn.Size = new System.Drawing.Size(174, 87);
            this.instanciarBtn.TabIndex = 9;
            this.instanciarBtn.Text = "instanciar mensalista";
            this.instanciarBtn.UseVisualStyleBackColor = true;
            this.instanciarBtn.Click += new System.EventHandler(this.instanciarBtn_Click);
            // 
            // InstParamBtn
            // 
            this.InstParamBtn.Location = new System.Drawing.Point(218, 155);
            this.InstParamBtn.Name = "InstParamBtn";
            this.InstParamBtn.Size = new System.Drawing.Size(174, 87);
            this.InstParamBtn.TabIndex = 10;
            this.InstParamBtn.Text = "instanciar passando parametros";
            this.InstParamBtn.UseVisualStyleBackColor = true;
            this.InstParamBtn.Click += new System.EventHandler(this.InstParamBtn_Click);
            // 
            // FormMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 254);
            this.Controls.Add(this.InstParamBtn);
            this.Controls.Add(this.instanciarBtn);
            this.Controls.Add(this.Homeoffice);
            this.Controls.Add(this.DataEntTxt);
            this.Controls.Add(this.SalTXt);
            this.Controls.Add(this.NomeTxt);
            this.Controls.Add(this.MatTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMensalista";
            this.Text = "matrícular";
            this.Homeoffice.ResumeLayout(false);
            this.Homeoffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MatTxt;
        private System.Windows.Forms.TextBox NomeTxt;
        private System.Windows.Forms.TextBox SalTXt;
        private System.Windows.Forms.TextBox DataEntTxt;
        private System.Windows.Forms.GroupBox Homeoffice;
        private System.Windows.Forms.RadioButton HomeN;
        private System.Windows.Forms.RadioButton HomeS;
        private System.Windows.Forms.Button instanciarBtn;
        private System.Windows.Forms.Button InstParamBtn;
    }
}