using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.ApplicationCore.Domain
{
    public class Equipe
    {  
        public string AdresseLocal { get; set; }
        public int EquipeId { get; set; }
        public string Logo { get; set; }
        public string NomEquipe { get; set; }
        public ICollection<Trophee> Trophees { get; set; }
        public ICollection<Contrat> Contrats { get; set; }
    }
}
