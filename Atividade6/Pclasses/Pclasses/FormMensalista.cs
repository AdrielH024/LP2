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
    public partial class FormMensalista : Form
    {
        public FormMensalista()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void instanciarBtn_Click(object sender, EventArgs e)
        {
            Mensalista mensalista = new Mensalista();

            mensalista.Matricula = Convert.ToInt32(MatTxt.Text);
            mensalista.NomeEmpregado = NomeTxt.Text;
            mensalista.DataEntradaEmpresa = Convert.ToDateTime(DataEntTxt.Text);
            mensalista.SalarioMensal = Convert.ToDouble(SalTXt.Text);
            if (HomeS.Checked)
            {
                mensalista.HomeOffice = 'S';
            }
            else
            {
                mensalista.HomeOffice = 'N';
            }

            MessageBox.Show("Matrícula: " + mensalista.Matricula +
               '\n' + '\n' + "Data De entrada: " + mensalista.DataEntradaEmpresa.ToShortDateString() +
               '\n' + '\n' + "Salário Bruto: " + mensalista.SalarioBruto().ToString("N2") +
               '\n' + '\n' + "Tempo Empresa(Dias): " + mensalista.TempoTrabalho() +
                '\n' + '\n' + mensalista.VerificaHome()
              );
        }

        private void InstParamBtn_Click(object sender, EventArgs e)
        {
            Mensalista mensalista = new Mensalista(
            Convert.ToInt32(MatTxt.Text),
            NomeTxt.Text,
            Convert.ToDateTime(DataEntTxt.Text),
           Convert.ToDouble(SalTXt.Text)
            );
            if (HomeS.Checked)
            {
                mensalista.HomeOffice = 'S';
            }
            else
            {
                mensalista.HomeOffice = 'N';
            }

            MessageBox.Show("Matrícula: " + mensalista.Matricula +
               '\n' + '\n' + "Data De entrada: " + mensalista.DataEntradaEmpresa.ToShortDateString() +
               '\n' + '\n' + "Salário Bruto: " + mensalista.SalarioBruto().ToString("N2") +
               '\n' + '\n' + "Tempo Empresa(Dias): " + mensalista.TempoTrabalho() +
                '\n' + '\n' + mensalista.VerificaHome()
              );
        }
    }
}
