using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InstantBtn_Click(object sender, EventArgs e)
        {
            Horista horista = new Horista();

            horista.Matricula = Convert.ToInt32(MatTxt.Text);
            horista.NomeEmpregado = NomeTxt.Text;
            horista.DataEntradaEmpresa = Convert.ToDateTime(DataEntTxt.Text);
            horista.SalHora = Convert.ToDouble(SalTXt.Text);
            horista.NumeroHora = Convert.ToDouble(NumHoras.Text);
            horista.diasFalta = Convert.ToInt32(Falta.Text);
            if (rdHomeS.Checked)
            {
                horista.HomeOffice = 'S';
            }
            else
            {
                horista.HomeOffice = 'N';
            }

            MessageBox.Show("Matrícula: " + horista.Matricula +
               '\n' + '\n' + "Data De entrada: " + horista.DataEntradaEmpresa.ToShortDateString() +
               '\n' + '\n' + "Salário Bruto: " + horista.SalarioBruto().ToString("N2") +
               '\n' + '\n' + "Tempo Empresa(Dias): " + horista.TempoTrabalho() +
                '\n' + '\n' + horista.VerificaHome()
              );
        }
    }
}
