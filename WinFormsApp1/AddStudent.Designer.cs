namespace WinFormsApp1
{
    partial class AddStudent
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.RegesterData = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.TextBox();
            this.U = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(617, 176);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(135, 23);
            this.FirstName.TabIndex = 0;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(468, 117);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(284, 23);
            this.UserName.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(468, 176);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(143, 23);
            this.LastName.TabIndex = 2;
            this.LastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(21, 117);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(284, 23);
            this.Email.TabIndex = 3;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(21, 176);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(284, 23);
            this.Phone.TabIndex = 4;
            // 
            // RegesterData
            // 
            this.RegesterData.Location = new System.Drawing.Point(21, 233);
            this.RegesterData.Name = "RegesterData";
            this.RegesterData.Size = new System.Drawing.Size(284, 23);
            this.RegesterData.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(468, 251);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(284, 58);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(21, 291);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(284, 23);
            this.Department.TabIndex = 8;
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.U.Location = new System.Drawing.Point(637, 84);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(115, 30);
            this.U.TabIndex = 9;
            this.U.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(681, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "FName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(540, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "LName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(244, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(165, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "RegesterDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(234, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(160, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "DepartmentId";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 374);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.U);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.RegesterData);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.FirstName);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstName;
        private TextBox UserName;
        private TextBox LastName;
        private TextBox Email;
        private TextBox Phone;
        private TextBox RegesterData;
        private Button Add;
        private TextBox Department;
        private Label U;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}