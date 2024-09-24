using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace ToDoListApp.Models
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> ToDoList {  get; set; }
        public IEnumerable<ToDo> GetAll()
        {
            return ToDoList.ToList();
        }
        public bool Delete(int id)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException();
            var entity = ToDoList.FirstOrDefault(b => b.Id == id);
            if (entity == null) throw new Exception();
            ToDoList.Remove(entity);
            return this.SaveChanges() > 0;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EBPQHUK;Initial Catalog=ToDoListDB;Integrated Security=SSPI;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
