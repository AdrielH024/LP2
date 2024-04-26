using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    abstract class Empregado{
        private int matricula;
        private String nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public char HomeOffice {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        public String VerificaHome()
        {
            if(homeOffice == 'S')
            {
                return "empregado trabalha em home-oficce";
            }
            else
            {
                return "Empregado não trabalha em home-oficce";
            }

        }
        public virtual int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(dataEntradaEmpresa);
            return (span.Days);
        }

        public abstract double SalarioBruto();
    }
}
