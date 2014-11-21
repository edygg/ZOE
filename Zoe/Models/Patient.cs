using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoe.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string NoExpediente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Domicilio { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoCelular { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Nacionalidad { get; set; }
        public int Edad { get; set; }
        public string EstadoCivil { get; set; }
        public int NoHijos { get; set; }
        public string Ocupacion { get; set; }
        public string Observaciones { get; set; }

        public string NombreCompleto
        {
            get
            {
                return this.Nombres + " " + this.Apellidos;
            }
        }
    }
}