// This is feature/TestFeature4 branch
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //take the form title from the App.config file
            this.Text = ConfigurationManager.AppSettings["ApplicationTitle"];
        }

        private void btnOkRoom_Click(object sender, EventArgs e)
        {
            Circle c1 = new Circle(new Point3D(0, 0, 0), 70);
            design1.Entities.Add(c1, Color.Blue);
            design1.Invalidate();
        }
        private void btnroomno3_Click(object sender, EventArgs e)
        {
            Circle c1 = new Circle(new Point3D(0, 0, 0), 50);
            design1.Entities.Add(c1, Color.Red);
            design1.Invalidate();
        }
    }
}
