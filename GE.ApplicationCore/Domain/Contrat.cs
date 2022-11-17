using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.ApplicationCore.Domain
{
    public class Contrat
    {
        public DateTime DateContrat { get; set; }
        public int DureeMois { get; set; }
        public double Salaire { get; set; }
        public Equipe Equipe { get; set; }

        public Membre Membre { get; set; }

    }
}
