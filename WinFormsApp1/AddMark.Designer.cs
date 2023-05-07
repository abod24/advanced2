namespace WinFormsApp1
{
    partial class AddMark
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
            this.Mark = new System.Windows.Forms.TextBox();
            this.IDExam = new System.Windows.Forms.TextBox();
            this.IDStudent = new System.Windows.Forms.TextBox();
            this.AddExam_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(145, 177);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(129, 23);
            this.Mark.TabIndex = 0;
            this.Mark.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IDExam
            // 
            this.IDExam.Location = new System.Drawing.Point(321, 177);
            this.IDExam.Name = "IDExam";
            this.IDExam.Size = new System.Drawing.Size(129, 23);
            this.IDExam.TabIndex = 1;
            // 
            // IDStudent
            // 
            this.IDStudent.Location = new System.Drawing.Point(499, 177);
            this.IDStudent.Name = "IDStudent";
            this.IDStudent.Size = new System.Drawing.Size(129, 23);
            this.IDStudent.TabIndex = 2;
            // 
            // AddExam_btn
            // 
            this.AddExam_btn.Location = new System.Drawing.Point(312, 253);
            this.AddExam_btn.Name = "AddExam_btn";
            this.AddExam_btn.Size = new System.Drawing.Size(146, 46);
            this.AddExam_btn.TabIndex = 3;
            this.AddExam_btn.Text = "ADD";
            this.AddExam_btn.UseVisualStyleBackColor = true;
            this.AddExam_btn.Click += new System.EventHandler(this.AddExam_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(514, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "StudentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(350, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ExamID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mark";
            // 
            // AddMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 374);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddExam_btn);
            this.Controls.Add(this.IDStudent);
            this.Controls.Add(this.IDExam);
            this.Controls.Add(this.Mark);
            this.Name = "AddMark";
            this.Text = "AddMark";
            this.Load += new System.EventHandler(this.AddMark_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Mark;
        private TextBox IDExam;
        private TextBox IDStudent;
        private Button AddExam_btn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}