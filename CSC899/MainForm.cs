using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSC899.Forms_DE_Rand;

namespace CSC899
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Events
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void RastriginForm_Load(object sender, EventArgs e)
        {
            RastriginForm rastriginForm = new RastriginForm();
            rastriginForm.Show();
        }

        private void AckleyForm_Load(object sender, EventArgs e)
        {
            AckleyForm ackleyForm = new AckleyForm();
            ackleyForm.Show();
        }

        private void GriewankForm_Load(object sender, EventArgs e)
        {
            GriewankForm griewankForm = new GriewankForm();
            griewankForm.Show();
        }

        private void RosenbrockForm_Load(object sender, EventArgs e)
        {
            RosenbrockForm rosenbrockForm = new RosenbrockForm();
            rosenbrockForm.Show();
        }


    }
}
