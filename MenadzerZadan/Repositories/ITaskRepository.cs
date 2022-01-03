using MenadzerZadan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadzerZadan.Repositories
{
    public interface ITaskRepository
    {
        TaskModel Get(int taskId);
        IQueryable<TaskModel> GetAllActive();
        void ADD(TaskModel task);
        void Update(int taskId,TaskModel task);
        void Delete(int taskId);

    }
}
