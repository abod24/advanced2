namespace WinFormsApp1
{
    partial class AddDepartment
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
            this.DepartmentAdd = new System.Windows.Forms.Button();
            this.DepartmentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DepartmentAdd
            // 
            this.DepartmentAdd.Location = new System.Drawing.Point(339, 224);
            this.DepartmentAdd.Name = "DepartmentAdd";
            this.DepartmentAdd.Size = new System.Drawing.Size(142, 59);
            this.DepartmentAdd.TabIndex = 0;
            this.DepartmentAdd.Text = "Add";
            this.DepartmentAdd.UseVisualStyleBackColor = true;
            this.DepartmentAdd.Click += new System.EventHandler(this.DepartmentAdd_Click);
            // 
            // DepartmentName
            // 
            this.DepartmentName.Location = new System.Drawing.Point(164, 146);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Size = new System.Drawing.Size(478, 23);
            this.DepartmentName.TabIndex = 1;
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepartmentName);
            this.Controls.Add(this.DepartmentAdd);
            this.Name = "AddDepartment";
            this.Text = "AddDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DepartmentAdd;
        private TextBox DepartmentName;
    }
}