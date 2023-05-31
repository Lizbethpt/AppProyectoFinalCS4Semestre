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

    [DataContract]
    public class DataSerie
    {
        [DataMember(Name = "fecha")]
        public string Fecha { get; set; }

        [DataMember(Name = "dato")]
        public string Data { get; set; }
    }

    [DataContract]
    public class SeriesResponse
    {
        [DataMember(Name = "series")]
        public Serie[] Series { get; set; }
    }

    [DataContract]
    public class Response
    {
        [DataMember(Name = "bmx")]
        public SeriesResponse seriesResponse { get; set; }
    }

}
