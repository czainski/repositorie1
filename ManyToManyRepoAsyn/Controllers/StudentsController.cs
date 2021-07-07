using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManyToManyCore.Models;
using RelationshipManyToManyCore3.Models;
using BC.Context;
using System.Collections.Generic;
using RelationshipManyToManyCore3.Other;

namespace RelationshipManyToManyCore3.Controllers
{
    public class StudentsController : Controller
    {
        IRepository<Project>  _repositorySub;
        IRepository<Student> _repositoryOver;
        //
        string junctionTable = "StudentProjectJunction";
        string junctionTableInclude = "Project";
        string idDeleteCascade = "StudentId";
        //                
        public StudentsController(Db db)
        {
            _repositoryOver = new Repository<Student>(db);
            _repositorySub  = new Repository<Project>(db);
        }
        //
        public async Task<ActionResult> index()
        {
            IEnumerable<Student> students = await _repositoryOver.Select
                        (includes: $"{junctionTable},{junctionTable}.{junctionTableInclude}",
                        orderBy: Common.orderByStudent, where: null);
            
            ViewBag.DistinctList =  await Task.Run(() => Common.DistinctList(_repositoryOver, e=>e.LastName));
            return View(await Task.Run(() => new StudentViewModel
            {
                Students = students
            }));
        }
        // POST: 
        [HttpPost]
        [ValidateAntiForgeryToken]
         public async Task<ActionResult> index(DateTime Od, DateTime Do, string DistinctList)
        {
            (Od, Do) = DateMathod.TestDate(Od, Do);

            IEnumerable<Student> students = null;

            if (DistinctList == "All")
                students = await _repositoryOver.Select
                                    (includes: $"{junctionTable},{junctionTable}.{junctionTableInclude}",
                                    orderBy: Common.orderByStudent,
                                    where: e => e.Date >= Od && e.Date <= Do
                                    );
            else
                students = await _repositoryOver.Select
                                                    (includes: $"{junctionTable},{junctionTable}.{junctionTableInclude}",
                                                    orderBy: Common.orderByStudent,
                                                     where: e => e.Date >= Od && e.Date <= Do && DistinctList == e.LastName
                                                    );

            ViewBag.DistinctList = await Task.Run(() => Common.DistinctList(_repositoryOver, e => e.LastName));
            return View(await Task.Run(() => new StudentViewModel
            {
                Students = students
            }));
        }
        //        
        public async Task<ActionResult> Create()
        {
            ViewBag.Projects = await  _repositorySub.Select
             (includes: null, orderBy: Common.orderByProject, where: null);
            
            return View("Creator", await Task.Run(() => new Student()));
        }

        //
        //
        public async Task<ActionResult> Insert(Student student, long[] checkbox)
        {
            await Task.Run(() =>Common.Completion(student, checkbox));
            await _repositoryOver.Insert(student);
            return RedirectToAction(nameof(Index));
        }
        //
        public async Task<ActionResult> Edit(long id)
        {
            ViewBag.Projects = await _repositorySub.Select
                (includes: $"{junctionTable}", orderBy: Common.orderByProject, where: null);
            
            return View("Editor", await _repositoryOver.Find(id));
        }
        //
        public async Task<ActionResult> Update (Student old, long[] checkbox)
        {
            Student student = await _repositoryOver.FindExplicitLoading(old.Id, $"{junctionTable}");
             
            await Task.Run(() =>Common.Completion(student, checkbox,old));
            await _repositoryOver.Update(student);
            return RedirectToAction(nameof(Index));
        }
        //
        public async Task<ActionResult> Delete(long? id)
        {
            if(id!=null) 
                await _repositoryOver.DeleteCascade
                    (junctionTable, idDeleteCascade, id);
            return RedirectToAction(nameof(Index));
        }
        //
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
