using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManyToManyCore.Models 
{
    public class Student : EntityBase
    {
        //
        public string LastName { get; set; }
        //
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime?  Date { get; set; }
        //
        public ICollection<StudentProjectJunction> StudentProjectJunction { get; set; }
        //    
        public Student()  {
            StudentProjectJunction = new HashSet<StudentProjectJunction>();
        }
    }
}