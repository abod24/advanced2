namespace WinFormsApp1
{
    partial class AddExam
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
            this.Term = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.SubjectID = new System.Windows.Forms.TextBox();
            this.ADDExam_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Term
            // 
            this.Term.Location = new System.Drawing.Point(150, 159);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(142, 23);
            this.Term.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(320, 159);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(142, 23);
            this.Date.TabIndex = 1;
            // 
            // SubjectID
            // 
            this.SubjectID.Location = new System.Drawing.Point(485, 159);
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.Size = new System.Drawing.Size(142, 23);
            this.SubjectID.TabIndex = 2;
            // 
            // ADDExam_btn
            // 
            this.ADDExam_btn.Location = new System.Drawing.Point(324, 237);
            this.ADDExam_btn.Name = "ADDExam_btn";
            this.ADDExam_btn.Size = new System.Drawing.Size(138, 47);
            this.ADDExam_btn.TabIndex = 3;
            this.ADDExam_btn.Text = "button1";
            this.ADDExam_btn.UseVisualStyleBackColor = true;
            this.ADDExam_btn.Click += new System.EventHandler(this.ADDExam_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(407, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(528, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "SubjectID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADDExam_btn);
            this.Controls.Add(this.SubjectID);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Term);
            this.Name = "AddExam";
            this.Text = "AddExam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Term;
        private TextBox Date;
        private TextBox SubjectID;
        private Button ADDExam_btn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}