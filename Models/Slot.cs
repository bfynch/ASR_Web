using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Asr.Data;

namespace Asr.Models
{
    public class Slot
    {

        [Required]
        public string RoomID { get; set; }
        public virtual Room Room { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime StartTime { get; set; }

        [Required]
        public string StaffID { get; set; }
        public virtual Staff Staff { get; set; }

        public string StudentID { get; set; }
        public virtual Student Student { get; set; }
    }
}
