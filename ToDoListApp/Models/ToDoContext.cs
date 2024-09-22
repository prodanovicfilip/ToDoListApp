using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace ToDoListApp.Models
{
    public class ToDoContext
    {
        public List<ToDo> ToDoList = new List<ToDo>();
        public void Add(ToDo entity)
        {
            if (entity == null) return;
            ToDoList.Add(entity);
        }
        public IEnumerable<ToDo> GetAll()
        {
            return ToDoList.ToList();
        }
    }
}
