using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AppProyectoFinalCS4Semestre
{
    [DataContract]
    public class DataSerie
    {
        [DataMember(Name = "fecha")]
        public string Fecha { get; set; }

        [DataMember(Name = "dato")]
        public string Data { get; set; }
    }
}
