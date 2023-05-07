namespace WinFormsApp1
{
    partial class AddLectur
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
            this.IDSubject = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ADDLectur_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDSubject
            // 
            this.IDSubject.Location = new System.Drawing.Point(139, 64);
            this.IDSubject.Name = "IDSubject";
            this.IDSubject.Size = new System.Drawing.Size(100, 23);
            this.IDSubject.TabIndex = 0;
            this.IDSubject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(255, 64);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(379, 23);
            this.Title.TabIndex = 2;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(139, 123);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(495, 211);
            this.content.TabIndex = 3;
            this.content.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(136, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(550, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Content";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(585, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Title";
            // 
            // ADDLectur_btn
            // 
            this.ADDLectur_btn.Location = new System.Drawing.Point(303, 349);
            this.ADDLectur_btn.Name = "ADDLectur_btn";
            this.ADDLectur_btn.Size = new System.Drawing.Size(154, 56);
            this.ADDLectur_btn.TabIndex = 7;
            this.ADDLectur_btn.Text = "ADD";
            this.ADDLectur_btn.UseVisualStyleBackColor = true;
            this.ADDLectur_btn.Click += new System.EventHandler(this.ADDLectur_btn_Click);
            // 
            // AddLectur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ADDLectur_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.IDSubject);
            this.Name = "AddLectur";
            this.Text = "AddLectur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox IDSubject;
        private TextBox Title;
        private RichTextBox content;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button ADDLectur_btn;
    }
}