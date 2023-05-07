namespace WinFormsApp1
{
    partial class AddItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Subject = new System.Windows.Forms.Button();
            this.Lectur = new System.Windows.Forms.Button();
            this.Mark = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.Button();
            this.Exam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(250, 106);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(146, 60);
            this.Subject.TabIndex = 0;
            this.Subject.Text = "Subject";
            this.Subject.UseVisualStyleBackColor = true;
            // 
            // Lectur
            // 
            this.Lectur.Location = new System.Drawing.Point(250, 181);
            this.Lectur.Name = "Lectur";
            this.Lectur.Size = new System.Drawing.Size(146, 60);
            this.Lectur.TabIndex = 1;
            this.Lectur.Text = "Lectur";
            this.Lectur.UseVisualStyleBackColor = true;
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(250, 256);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(146, 60);
            this.Mark.TabIndex = 2;
            this.Mark.Text = "Mark";
            this.Mark.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.Student.Location = new System.Drawing.Point(407, 106);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(146, 60);
            this.Student.TabIndex = 3;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(407, 181);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(146, 60);
            this.Department.TabIndex = 4;
            this.Department.Text = "Department";
            this.Department.UseVisualStyleBackColor = true;
            // 
            // Exam
            // 
            this.Exam.Location = new System.Drawing.Point(407, 256);
            this.Exam.Name = "Exam";
            this.Exam.Size = new System.Drawing.Size(146, 60);
            this.Exam.TabIndex = 5;
            this.Exam.Text = "Exam";
            this.Exam.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exam);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.Lectur);
            this.Controls.Add(this.Subject);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Subject;
        private Button Lectur;
        private Button Mark;
        private Button Student;
        private Button Department;
        private Button Exam;
    }
}