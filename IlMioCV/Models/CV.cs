using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlMioCV.Models
{
    public class CV
    {
        public InformazioniPersonali InfoPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; }
        public List<Impiego> Impieghi { get; set; }

        public CV()
        {
            StudiEffettuati = new List<Studi>();
            Impieghi = new List<Impiego>();
        }
    }
}
