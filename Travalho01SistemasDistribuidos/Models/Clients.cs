using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Travalho01SistemasDistribuidos.Models
{
    [DataContract]
    public class Clients
    {
        [DataMember]

        public int Id { get; set; }
        [DataMember]

        public string Nome { get; set; }
        [DataMember]

        public int Idade { get; set; }
        [DataMember]

        public string Email { get; set; }

        public Clients()
        {
          

        }
    }
}