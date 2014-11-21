using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoe.Models
{
    public class SurgeryType
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Horas { get; set; }
        public int Minutos { get; set; }
    }
}