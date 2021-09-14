using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Senior_Educator
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string HistoryOfJobs { get; set; }
        public string Comment { get; set; }
        public Guid? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }
    }
}