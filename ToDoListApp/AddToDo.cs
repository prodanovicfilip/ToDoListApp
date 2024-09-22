using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListApp.Models;

namespace ToDoListApp
{
    public partial class AddToDo : Form
    {
        private readonly ToDoContext _context;
        public AddToDo(ToDoContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void AddToDo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.GetService<Form1>().Show();
        }

        private void BT_AddToList_Click(object sender, EventArgs e)
        {
            string title = TB_Title.Text;
            string desc = TB_Desc.Text;
            DateTime deadline = DT_DeadLine.Value;
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("Missing fields");
                return;
            }
            var entity = new ToDo();
            entity.Title = title;
            entity.Description = desc;
            entity.Deadline = deadline;
            _context.ToDoList.Add(entity);
            _context.SaveChanges();
            this.Close();
        }
    }
}
