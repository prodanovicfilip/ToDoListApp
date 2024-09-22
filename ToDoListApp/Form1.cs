namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_View_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<ViewToDo>();
            this.Hide();
            form.ShowDialog();
        }

        private void BT_ADD_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<AddToDo>();
            this.Hide();
            form.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
