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
        private ToDo _selectedToDo;
        public ViewToDo(ToDoContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void ViewToDo_Load(object sender, EventArgs e)
        {
            RefreshMe();
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
                RefreshMe();
                return;
            }
            GV_List.DataSource = _list.Where(l => l.Title.Contains(TB_Search.Text) || l.Description.Contains(TB_Search.Text)).ToList();
            ColorDates();
        }

        private void TS_Edit_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<AddToDo>();
            form.SetBook(_selectedToDo);
            form.ShowDialog();
            RefreshMe();
        }

        private void TS_Delete_Click(object sender, EventArgs e)
        {
            _context.Delete(_selectedToDo.Id);
            RefreshMe();
        }

        private void GV_List_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        var hit = GV_List.HitTest(e.X, e.Y);
                        GV_List.ClearSelection();
                        GV_List.Rows[hit.RowIndex].Selected = true;
                        _selectedToDo = _list.ToList()[hit.RowIndex];
                        CT_Context.Show(this, new Point(e.X, e.Y));
                    }
                    break;
            }
        }
        private void RefreshMe()
        {
            _list = _context.GetAll().ToList();
            if (_context == null)
            {
                MessageBox.Show("List empty");
                return;
            }
            GV_List.DataSource = _list;
            ColorDates();
        }
    }
}
