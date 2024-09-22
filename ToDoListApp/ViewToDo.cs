using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListApp.Models;

namespace ToDoListApp
{
    public partial class ViewToDo : Form
    {
        private readonly ToDoContext _context;
        private IEnumerable<ToDo> _list;
        public ViewToDo(ToDoContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void ViewToDo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.GetService<Form1>().Show();
        }

        private void ViewToDo_Load(object sender, EventArgs e)
        {
            if (_context == null)
            {
                MessageBox.Show("List empty");
                return;
            }
            _list = _context.GetAll();
            GV_List.DataSource = _list;
            ColorDates();
        }

        private void ColorDates()
        {
            foreach (DataGridViewRow row in GV_List.Rows)
            {
                DateTime value = Convert.ToDateTime(row.Cells["DeadLine"].Value);
                DateTime citeria = DateTime.Now;

                int result = DateTime.Compare(value, citeria);

                if (result < 0)
                    ColorRow(row, Color.Red);
            }
        }
        private void ColorRow(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = color;
            }
        }

        private void BT_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Search.Text))
            {
                GV_List.DataSource = _list;
                return;
            }
            GV_List.DataSource = _list.Where(l => l.Title.Contains(TB_Search.Text)).ToList();
            ColorDates();
        }
    }
}
