namespace BC_Students
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPS = new System.Windows.Forms.Button();
            this.btnDM = new System.Windows.Forms.Button();
            this.btnSM = new System.Windows.Forms.Button();
            this.btnSI = new System.Windows.Forms.Button();
            this.btnMI = new System.Windows.Forms.Button();
            this.printStudents1 = new BC_Students.PrintStudents();
            this.deleteMarks1 = new BC_Students.DeleteMarks();
            this.printMarks1 = new BC_Students.PrintMarks();
            this.modules1 = new BC_Students.Modules();
            this.studentManagement1 = new BC_Students.StudentManagement();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnPS);
            this.panel2.Controls.Add(this.btnDM);
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.btnSM);
            this.panel2.Controls.Add(this.btnSI);
            this.panel2.Controls.Add(this.btnMI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 583);
            this.panel2.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(22)))), ((int)(((byte)(7)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentManagement1);
            this.panel1.Controls.Add(this.modules1);
            this.panel1.Controls.Add(this.printMarks1);
            this.panel1.Controls.Add(this.deleteMarks1);
            this.panel1.Controls.Add(this.printStudents1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(209, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 583);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(22)))), ((int)(((byte)(7)))));
            this.btnExit.Location = new System.Drawing.Point(776, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "BC STUDENT MANAGEMENT SERVICE";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(22)))), ((int)(((byte)(7)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(33, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 143);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(22)))), ((int)(((byte)(7)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(111, 10);
            this.panel5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "BCSM";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(22)))), ((int)(((byte)(7)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 10);
            this.panel3.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(568, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 34);
            this.button10.TabIndex = 8;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(526, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 34);
            this.button9.TabIndex = 9;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(484, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 34);
            this.button8.TabIndex = 10;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BC_Students.Properties.Resources.mortarboard__1_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::BC_Students.Properties.Resources.log_out;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 546);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(36, 34);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnPS
            // 
            this.btnPS.FlatAppearance.BorderSize = 0;
            this.btnPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPS.ForeColor = System.Drawing.Color.White;
            this.btnPS.Image = global::BC_Students.Properties.Resources.printer;
            this.btnPS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPS.Location = new System.Drawing.Point(12, 281);
            this.btnPS.Name = "btnPS";
            this.btnPS.Size = new System.Drawing.Size(197, 54);
            this.btnPS.TabIndex = 17;
            this.btnPS.Text = "       Print Students";
            this.btnPS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPS.UseVisualStyleBackColor = true;
            this.btnPS.Click += new System.EventHandler(this.btnPS_Click);
            // 
            // btnDM
            // 
            this.btnDM.FlatAppearance.BorderSize = 0;
            this.btnDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDM.ForeColor = System.Drawing.Color.White;
            this.btnDM.Image = global::BC_Students.Properties.Resources.trash;
            this.btnDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDM.Location = new System.Drawing.Point(12, 227);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(197, 54);
            this.btnDM.TabIndex = 11;
            this.btnDM.Text = "       Delete Marks";
            this.btnDM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDM.UseVisualStyleBackColor = true;
            this.btnDM.Click += new System.EventHandler(this.btnDM_Click);
            // 
            // btnSM
            // 
            this.btnSM.FlatAppearance.BorderSize = 0;
            this.btnSM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSM.ForeColor = System.Drawing.Color.White;
            this.btnSM.Image = global::BC_Students.Properties.Resources.seo_report1;
            this.btnSM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSM.Location = new System.Drawing.Point(12, 173);
            this.btnSM.Name = "btnSM";
            this.btnSM.Size = new System.Drawing.Size(197, 54);
            this.btnSM.TabIndex = 12;
            this.btnSM.Text = "       Student Marks";
            this.btnSM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSM.UseVisualStyleBackColor = true;
            this.btnSM.Click += new System.EventHandler(this.btnSM_Click);
            // 
            // btnSI
            // 
            this.btnSI.FlatAppearance.BorderSize = 0;
            this.btnSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSI.ForeColor = System.Drawing.Color.White;
            this.btnSI.Image = global::BC_Students.Properties.Resources.student1;
            this.btnSI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSI.Location = new System.Drawing.Point(12, 59);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(197, 54);
            this.btnSI.TabIndex = 16;
            this.btnSI.Text = "       Students Info";
            this.btnSI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSI.UseVisualStyleBackColor = true;
            this.btnSI.Click += new System.EventHandler(this.btnSI_Click);
            // 
            // btnMI
            // 
            this.btnMI.FlatAppearance.BorderSize = 0;
            this.btnMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMI.ForeColor = System.Drawing.Color.White;
            this.btnMI.Image = global::BC_Students.Properties.Resources.information;
            this.btnMI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMI.Location = new System.Drawing.Point(12, 119);
            this.btnMI.Name = "btnMI";
            this.btnMI.Size = new System.Drawing.Size(197, 54);
            this.btnMI.TabIndex = 14;
            this.btnMI.Text = "       Modules Info";
            this.btnMI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMI.UseVisualStyleBackColor = true;
            this.btnMI.Click += new System.EventHandler(this.btnMI_Click);
            // 
            // printStudents1
            // 
            this.printStudents1.Location = new System.Drawing.Point(1, 156);
            this.printStudents1.Name = "printStudents1";
            this.printStudents1.Size = new System.Drawing.Size(817, 423);
            this.printStudents1.TabIndex = 12;
            // 
            // deleteMarks1
            // 
            this.deleteMarks1.Location = new System.Drawing.Point(1, 156);
            this.deleteMarks1.Name = "deleteMarks1";
            this.deleteMarks1.Size = new System.Drawing.Size(817, 423);
            this.deleteMarks1.TabIndex = 13;
            // 
            // printMarks1
            // 
            this.printMarks1.Location = new System.Drawing.Point(1, 156);
            this.printMarks1.Name = "printMarks1";
            this.printMarks1.Size = new System.Drawing.Size(817, 423);
            this.printMarks1.TabIndex = 14;
            // 
            // modules1
            // 
            this.modules1.Location = new System.Drawing.Point(1, 156);
            this.modules1.Name = "modules1";
            this.modules1.Size = new System.Drawing.Size(817, 423);
            this.modules1.TabIndex = 15;
            // 
            // studentManagement1
            // 
            this.studentManagement1.Location = new System.Drawing.Point(1, 156);
            this.studentManagement1.Name = "studentManagement1";
            this.studentManagement1.Size = new System.Drawing.Size(817, 423);
            this.studentManagement1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1026, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPS;
        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnSM;
        private System.Windows.Forms.Button btnSI;
        private System.Windows.Forms.Button btnMI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnExit;
        private PrintMarks printMarks1;
        private DeleteMarks deleteMarks1;
        private PrintStudents printStudents1;
        private StudentManagement studentManagement1;
        private Modules modules1;
    }
}