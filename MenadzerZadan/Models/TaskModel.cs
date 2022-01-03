using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MenadzerZadan.Models
{


        public class TaskModel : IValidatableObject
    {
        [Key]
        public int TaskId { get; set; }
        [Display(Name ="Nazwa:")]
        [Required(ErrorMessage = "Pole Nazwa jest wymagane.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "Opis:")]
        [MaxLength(2000)]
        public string Description { get; set; }
        public bool Done { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Name == null) {
            yield return  new ValidationResult("Nie przekazałeś imienia", new string[] {"Imie"});
            }
        }
    }

    public class TasksContext : DbContext
    {
        public TasksContext() 
            : base("TasksConnectionString")
            {
            
            }
        public DbSet<TaskModel> TaskModels { get; set; }
    }
}