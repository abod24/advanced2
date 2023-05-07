namespace WinFormsApp1
{
    partial class AddSubject
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
            this.ADDSbject_btn = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Term = new System.Windows.Forms.TextBox();
            this.MinimumDegree = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ADDSbject_btn
            // 
            this.ADDSbject_btn.Location = new System.Drawing.Point(344, 282);
            this.ADDSbject_btn.Name = "ADDSbject_btn";
            this.ADDSbject_btn.Size = new System.Drawing.Size(148, 53);
            this.ADDSbject_btn.TabIndex = 0;
            this.ADDSbject_btn.Text = "ADD";
            this.ADDSbject_btn.UseVisualStyleBackColor = true;
            this.ADDSbject_btn.Click += new System.EventHandler(this.ADDSbject_btn_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(491, 104);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(218, 23);
            this.Name.TabIndex = 1;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(95, 228);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(267, 23);
            this.Year.TabIndex = 2;
            // 
            // Term
            // 
            this.Term.Location = new System.Drawing.Point(95, 166);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(267, 23);
            this.Term.TabIndex = 3;
            // 
            // MinimumDegree
            // 
            this.MinimumDegree.Location = new System.Drawing.Point(95, 104);
            this.MinimumDegree.Name = "MinimumDegree";
            this.MinimumDegree.Size = new System.Drawing.Size(267, 23);
            this.MinimumDegree.TabIndex = 4;
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(493, 164);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(218, 23);
            this.Department.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "MinimumDegree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(561, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "DepartmentID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(638, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(308, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(300, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Term";
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.MinimumDegree);
            this.Controls.Add(this.Term);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ADDSbject_btn);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ADDSbject_btn;
        private TextBox Name;
        private TextBox Year;
        private TextBox Term;
        private TextBox MinimumDegree;
        private TextBox Department;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}