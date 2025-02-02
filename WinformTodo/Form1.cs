using System.Diagnostics.CodeAnalysis;

namespace WinformTodo
{
    public partial class Form1 : Form
    {

        private List<Todo> TaskList { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitForm(object sender, EventArgs e)
        {
            if (Validators.IsEmptyText(txtTaskDescription))
            {
                MessageBox.Show("Description is empty please provide a description.");
                return;
            }

            if (Validators.IsTextNull(txtTaskDescription))
            {
                MessageBox.Show("Description needs to be created.");
            }

            if (Validators.IsEmptyText(txtDueDate))
            {
                MessageBox.Show("Missing a due date.");
                return;
            }

           if (!Validators.IsValidDate(txtDueDate))
            {
                MessageBox.Show("Date is incorrectly formated please resubmit.");
                return;
            }
           
            //where we handle the add event
            Todo myTodo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));

            TaskList.Add(myTodo);

            UpdateListBox();

            ClearForm();
        }
        public void UpdateListBox()
        {
            //Clear the contents of the list box
            lbTaskList.Items.Clear();

            //Transform the list
            var list = TaskList
                .Where(t => !t.IsDone)
                .OrderBy(t => t.DueDate)
                .ToList();
            //read in new contents
            for (int i = 0; i < list.Count; i++)
            {
                lbTaskList.Items.Add(list[i].ToString());
            }
            //cleanup if needed

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("Form Cleared");
        }
        private void ClearForm()
        {
            txtTaskDescription.Clear();
            txtDueDate.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                submitForm(sender, e);
            }
        }
    }
}
