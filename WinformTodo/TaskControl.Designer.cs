namespace WinformTodo
{
    partial class TaskControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnComplete = new Button();
            label1 = new Label();
            label2 = new Label();
            lblDueDate = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // btnComplete
            // 
            btnComplete.AutoSize = true;
            btnComplete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComplete.Location = new Point(154, 2);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(99, 25);
            btnComplete.TabIndex = 0;
            btnComplete.Text = "Mark Complete";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Due Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(83, 3);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(65, 15);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "2025-01-01";
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(1, 33);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(250, 25);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "This is a description of some";
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(lblDescription);
            Controls.Add(lblDueDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnComplete);
            Name = "TaskControl";
            Size = new Size(256, 58);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComplete;
        private Label label1;
        private Label label2;
        private Label lblDueDate;
        private Label lblDescription;
    }
}
