using MenadzerZadan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenadzerZadan.Controllers
{
    public class TaskController : Controller
    {
    
        public void AddToDatabase(TaskModel taskModel) { 

        TasksContext db = new TasksContext();
        db.TaskModels.Add(taskModel);
            db.SaveChanges();
        }

        private static IList<TaskModel> tasks = new List<TaskModel>()
        {
            new TaskModel(){ TaskId = 1, Name= "Wizyta u lekarza", Description= " Godzina 17:00", Done = false},
            new TaskModel(){ TaskId = 2, Name= "Zrobć obiad", Description= "Pierogi", Done = false},
        };
        
        //zmiana w pliku TaskController
        
        // GET: Task
        public ActionResult Index()
        {
            return View(tasks.Where(x => x.Done == false));
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View(new TaskModel());
        }

        // POST: Task/Create
        [HttpPost]
        public ActionResult Create(TaskModel taskModel)
        {
            taskModel.TaskId = tasks.Count + 1; //dodanie ID zadania 
            // TODO: Add insert logic here
            tasks.Add(taskModel);

            
            

            return RedirectToAction("Index"); //przekierowuje do akcji
           
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        // POST: Task/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TaskModel taskModel)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.TaskId == id);
            task.Name = taskModel.Name;
            task.Description = taskModel.Description;
                return RedirectToAction("Index");
          
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        // POST: Task/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, TaskModel taskModel)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.TaskId == id);
            tasks.Remove(task);
            return RedirectToAction("Index");
            
        }
        // GET: Task/Done/5
        public ActionResult Done(int id)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.TaskId == id);
            task.Done = true;

            return RedirectToAction("Index");
        }

    }
}
