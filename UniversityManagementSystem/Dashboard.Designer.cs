
namespace UniversityManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.StudentBtn = new System.Windows.Forms.Button();
            this.TeacherBtn = new System.Windows.Forms.Button();
            this.UserBtn = new System.Windows.Forms.Button();
            this.LibraryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentBtn
            // 
            this.StudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentBtn.Location = new System.Drawing.Point(48, 379);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.Size = new System.Drawing.Size(251, 55);
            this.StudentBtn.TabIndex = 0;
            this.StudentBtn.Text = "STUDENT CRUD";
            this.StudentBtn.UseVisualStyleBackColor = true;
            this.StudentBtn.Click += new System.EventHandler(this.StudentBtn_Click);
            // 
            // TeacherBtn
            // 
            this.TeacherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherBtn.Location = new System.Drawing.Point(370, 379);
            this.TeacherBtn.Name = "TeacherBtn";
            this.TeacherBtn.Size = new System.Drawing.Size(251, 55);
            this.TeacherBtn.TabIndex = 1;
            this.TeacherBtn.Text = "TEACHER CRUD";
            this.TeacherBtn.UseVisualStyleBackColor = true;
            this.TeacherBtn.Click += new System.EventHandler(this.TeacherBtn_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.Location = new System.Drawing.Point(709, 379);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(251, 55);
            this.UserBtn.TabIndex = 2;
            this.UserBtn.Text = "USER CRUD";
            this.UserBtn.UseVisualStyleBackColor = true;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // LibraryBtn
            // 
            this.LibraryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryBtn.Location = new System.Drawing.Point(370, 268);
            this.LibraryBtn.Name = "LibraryBtn";
            this.LibraryBtn.Size = new System.Drawing.Size(251, 55);
            this.LibraryBtn.TabIndex = 3;
            this.LibraryBtn.Text = "LIBRARY CRUD";
            this.LibraryBtn.UseVisualStyleBackColor = true;
            this.LibraryBtn.Click += new System.EventHandler(this.LibraryBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 487);
            this.Controls.Add(this.LibraryBtn);
            this.Controls.Add(this.UserBtn);
            this.Controls.Add(this.TeacherBtn);
            this.Controls.Add(this.StudentBtn);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentBtn;
        private System.Windows.Forms.Button TeacherBtn;
        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.Button LibraryBtn;
    }
}