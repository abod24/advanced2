namespace WinFormsApp1
{
    partial class UpdateOrDelete
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
            this.Exam = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.Mark = new System.Windows.Forms.Button();
            this.Lectur = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exam
            // 
            this.Exam.Location = new System.Drawing.Point(406, 270);
            this.Exam.Name = "Exam";
            this.Exam.Size = new System.Drawing.Size(146, 60);
            this.Exam.TabIndex = 11;
            this.Exam.Text = "Exam";
            this.Exam.UseVisualStyleBackColor = true;
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(406, 195);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(146, 60);
            this.Department.TabIndex = 10;
            this.Department.Text = "Department";
            this.Department.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.Student.Location = new System.Drawing.Point(406, 120);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(146, 60);
            this.Student.TabIndex = 9;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(249, 270);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(146, 60);
            this.Mark.TabIndex = 8;
            this.Mark.Text = "Mark";
            this.Mark.UseVisualStyleBackColor = true;
            // 
            // Lectur
            // 
            this.Lectur.Location = new System.Drawing.Point(249, 195);
            this.Lectur.Name = "Lectur";
            this.Lectur.Size = new System.Drawing.Size(146, 60);
            this.Lectur.TabIndex = 7;
            this.Lectur.Text = "Lectur";
            this.Lectur.UseVisualStyleBackColor = true;
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(249, 120);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(146, 60);
            this.Subject.TabIndex = 6;
            this.Subject.Text = "Subject";
            this.Subject.UseVisualStyleBackColor = true;
            // 
            // UpdateOrDelete
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
            this.Name = "UpdateOrDelete";
            this.Text = "UpdateOrDelete";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Exam;
        private Button Department;
        private Button Student;
        private Button Mark;
        private Button Lectur;
        private Button Subject;
    }
}