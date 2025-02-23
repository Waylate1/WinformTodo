using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTodo
{
    public partial class TaskControl : UserControl
    {
        private Todo TaskData;
        public TaskControl(Todo task)
        {
            InitializeComponent();
            TaskData = task;

            lblDescription.Text = TaskData.TaskDescription;
            lblDueDate.Text = TaskData.DueDate.ToShortDateString();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
