namespace WinformTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var date = DateTime.Parse(txtDueDate.Text);
            //where we handle the add event
            Todo myTodo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));

            MessageBox.Show(myTodo.ToString());
        }
    }
}
