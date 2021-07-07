using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManyToManyCore.Models {
    public class Project : EntityBase
    {
        [Required]
        public string Name { get; set; }
        //
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
        //
        public ICollection<StudentProjectJunction> StudentProjectJunction { get; set; }
        //
        public Project() {
            StudentProjectJunction = new HashSet<StudentProjectJunction>();
        }
    }
}
