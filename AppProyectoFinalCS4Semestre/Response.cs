using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AppProyectoFinalCS4Semestre
{
    [DataContract]
    public class Response
    {
        [DataMember(Name = "bmx")]
        public SeriesResponse seriesResponse { get; set; }
    }
}
