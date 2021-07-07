using System.Collections.Generic;

namespace ManyToManyCore.Models
{
    public class StudentViewModel
    {
       public IEnumerable<Student> Students { get; set; }
    }

    public class ProjectViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
    }
}
