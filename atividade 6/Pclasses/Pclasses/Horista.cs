using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    class Horista:Empregado
    {
        public double SalHora { get; set; }
        public double NumeroHora { get; set; }
        public int diasFalta { get; set; }
        public override double SalarioBruto()
        {
            return (SalHora * NumeroHora);
        }
        public override int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days - diasFalta);
        }
    }
}
