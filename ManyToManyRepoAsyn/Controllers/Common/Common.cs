using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelationshipManyToManyCore3.Models;
using ManyToManyCore.Models;
using System.Linq.Expressions;

namespace RelationshipManyToManyCore3.Controllers
{
    static public class Common
    {

       public static Func<IQueryable<Student>, IOrderedQueryable<Student>>
            orderByStudent = q => q.OrderBy(e => e.LastName);

       public  static Func<IQueryable<Project>, IOrderedQueryable<Project>>
            orderByProject = q => q.OrderBy(e => e.Name);
        public   static SelectList DistinctList(IRepository<Project> _repositoryOver, Expression<Func<Project, string>> what)
        {
            IList<string> distinctList = _repositoryOver.DistinctList(what);
            distinctList.Insert(0, "All");

            return new SelectList(distinctList, 1);
        }
        //
        public   static SelectList DistinctList(IRepository<Student> _repositoryOver, Expression<Func<Student, string>> what)
        {
            IList<string> distinctList = _repositoryOver.DistinctList(what);
            distinctList.Insert(0, "All");

            return new SelectList(distinctList, 1);
        }
        //
        public static void Completion(Student student, long[] checkbox, Student old = null)
        {
            if (old != null)
            {
                student.LastName = old.LastName;
                student.Date = old.Date;
                //...etc.
            }
            student.StudentProjectJunction = checkbox.Select(selectedId
               => new StudentProjectJunction
               {
                   StudentId = student.Id,
                   ProjectId = selectedId
               }).ToList();
        }
        //
        public static void Completion(Project project, long[] checkbox, Project old = null)
        {
            if (old != null)
            {
                project.Name = old.Name;
                project.Date = old.Date;
                //... etc.
            }
            project.StudentProjectJunction = checkbox.Select(selectedId
               => new StudentProjectJunction
               {
                   ProjectId = project.Id,
                   StudentId = selectedId
               }).ToList();
        }
        //
    }
}
