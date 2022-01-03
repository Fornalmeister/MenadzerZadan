using MenadzerZadan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenadzerZadan.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public TaskModel Get(int taskId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TaskModel> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public void ADD(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public void Update(int taskId, TaskModel task)
        {
            throw new NotImplementedException();
        }

        public void Delete(int taskId)
        {
            throw new NotImplementedException();
        }    
    }
}