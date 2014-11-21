using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zoe.Models
{
    public class Surgery
    {
        public int Id { get; set; }
        public int Patient_Id { get; set; }
        public int Doctor_UsersId { get; set; }
        public int SurgeryType_Id { get; set; }
        public Double Costo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy H:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicio { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy H:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaFinalizacion { get; set; }
        public String OjosOperados { get; set; }
        public String AgudezaVisual { get; set; }

    }
}