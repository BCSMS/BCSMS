using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_Students
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SidePanel.Height = btnSI.Height;
            SidePanel.Top = btnSI.Top;
            StudentManagement studentManagement1 = new StudentManagement();
            this.studentManagement1.BringToFront();
            this.studentManagement1.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSI.Height;
            SidePanel.Top = btnSI.Top;
            StudentManagement studentManagement1 = new StudentManagement();
            this.studentManagement1.BringToFront();
            this.studentManagement1.Visible = true;
        }

        private void btnMI_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMI.Height;
            SidePanel.Top = btnMI.Top;
            Modules modules1 = new Modules();
            this.studentManagement1.Visible = false;
            this.printMarks1.Visible = false;
            this.deleteMarks1.Visible = false;
            this.printStudents1.Visible = false;
            this.modules1.BringToFront();
            this.modules1.Visible = true;
        }

        private void btnSM_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSM.Height;
            SidePanel.Top = btnSM.Top;
            this.printMarks1.BringToFront();
            this.printMarks1.Visible = true;
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDM.Height;
            SidePanel.Top = btnDM.Top;
            this.deleteMarks1.BringToFront();
            this.deleteMarks1.Visible = true;
        }

        private void btnPS_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPS.Height;
            SidePanel.Top = btnPS.Top;
            this.printStudents1.BringToFront();
            this.printStudents1.Visible = true;
        }
    }
}
