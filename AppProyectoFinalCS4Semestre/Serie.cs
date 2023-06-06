using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AppProyectoFinalCS4Semestre
{
    [DataContract]
    public class Serie
    {
        [DataMember(Name = "titulo")]
        public string Title { get; set; }

        [DataMember(Name = "idSerie")]
        public string IdSerie { get; set; }

        [DataMember(Name = "datos")]
        public DataSerie[] Data { get; set; }
    }

}
