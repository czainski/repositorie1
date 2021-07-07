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
    public class ProjectController : Controller
    {
        IRepository<Project>  _repositoryOver;
        IRepository<Student> _repositorySub;

        string junctionTable = "StudentProjectJunction";
        string junctionTableInclude = "Student";
        string idDeleteCascade = "ProjectId";
        //                
        public ProjectController(Db db)
        {
            _repositorySub = new Repository<Student>(db);
            _repositoryOver = new Repository<Project>(db);
        }
        //
        public async Task<ActionResult> index()
        {
            IEnumerable<Project> projects = await _repositoryOver.Select
            (includes: $"{junctionTable},{junctionTable}.{junctionTableInclude}",
             orderBy: Common.orderByProject, where: null);

            ViewBag.DistinctList = await Task.Run(() => Common.DistinctList(_repositoryOver, e => e.Name));
            return View(await Task.Run(() => new ProjectViewModel
            {
                Projects = projects
            }));
         }
        // POST: 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> index(DateTime Od, DateTime Do, string DistinctList)
        {
            (Od, Do) = DateMathod.TestDate(Od,Do);

            IEnumerable<Project> projects = null;

            if (DistinctList == "All")
                projects = await _repositoryOver.Select
                                    (includes: $"{junctionTable},{junctionTable}.{junctionTableInclude}",
                                    orderBy: Common.orderByProject,
                                    where: e => e.Date >= Od && e.Date <= Do 
                                    );
            else 
                projects = await _repositoryOver.Select
                                    (includes: $"{junctionTable},{junctionTable}.{junctionTableInclude}",
                                    orderBy: Common.orderByProject,
                                    where: e => e.Date >= Od && e.Date <= Do && DistinctList == e.Name
                                    );

            ViewBag.DistinctList = await Task.Run(() => Common.DistinctList(_repositoryOver, e => e.Name));
            return View(await Task.Run(() => new ProjectViewModel
            {
                Projects = projects
            }));
        }
        //
        public async Task<ActionResult> Create()
        {
            ViewBag.Students = await _repositorySub.Select
               (includes: null , orderBy: Common.orderByStudent, where: null);

            return View("Creator", await Task.Run(() => new Project()));
        }
        //
        public async Task<ActionResult> Insert(Project project, long[] checkbox)
        {
            await Task.Run(() =>Common.Completion(project, checkbox));
            await _repositoryOver.Insert(project);
            return RedirectToAction(nameof(Index));
        }
        //
        public async Task<ActionResult> Edit(long id)
        {
            ViewBag.Students = await _repositorySub.Select
                (includes: $"{junctionTable}", orderBy: Common.orderByStudent, where: null);
            
            return View("Editor", await _repositoryOver.Find(id));
        }
        //
        public async Task<ActionResult> Update (Project old, long[] checkbox)
        {
            Project project = await _repositoryOver.FindExplicitLoading(old.Id, $"{junctionTable}");
             
            await Task.Run(() => Common.Completion(project, checkbox,old));
            await _repositoryOver.Update(project);
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
