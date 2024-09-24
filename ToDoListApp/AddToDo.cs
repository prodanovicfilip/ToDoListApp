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
        private ToDo _selectedToDo;
        public AddToDo(ToDoContext context)
        {
            InitializeComponent();
            _context = context;
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
            if (_selectedToDo == null)
                _selectedToDo = new ToDo();
            _selectedToDo.Title = title;
            _selectedToDo.Description = desc;
            _selectedToDo.Deadline = deadline;
            _context.ToDoList.Add(_selectedToDo);
            if (_context.ToDoList.Find(_selectedToDo.Id) == _selectedToDo)
                _context.ToDoList.Update(_selectedToDo);
            else
                _context.ToDoList.Add(_selectedToDo);
            _context.SaveChanges();
            this.Close();
        }
        public void SetBook(ToDo todo)
        {
            _selectedToDo = todo;
            TB_Title.Text = _selectedToDo.Title;
            TB_Desc.Text = _selectedToDo.Description;
            DT_DeadLine.Value = _selectedToDo.Deadline;
        }
    }
}
