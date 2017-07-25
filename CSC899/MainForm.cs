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
using CSC899.Forms_DE_Best;
using CSC899.Forms_DE_RandToBest;
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
        // DE/Rand Forms
        private void RastriginForm_Load(object sender, EventArgs e)
        {
            Forms_DE_Rand.RastriginForm rastriginForm = new Forms_DE_Rand.RastriginForm();
            rastriginForm.Show();
        }

        private void AckleyForm_Load(object sender, EventArgs e)
        {
            Forms_DE_Rand.AckleyForm ackleyForm = new Forms_DE_Rand.AckleyForm();
            ackleyForm.Show();
        }

        private void GriewankForm_Load(object sender, EventArgs e)
        {
            Forms_DE_Rand.GriewankForm griewankForm = new Forms_DE_Rand.GriewankForm();
            griewankForm.Show();
        }

        private void RosenbrockForm_Load(object sender, EventArgs e)
        {
            Forms_DE_Rand.RosenbrockForm rosenbrockForm = new Forms_DE_Rand.RosenbrockForm();
            rosenbrockForm.Show();
        }

        private void SphereForm_Load(object sender, EventArgs e)
        {
            
            Forms_DE_Rand.SphereForm sphereForm = new Forms_DE_Rand.SphereForm();
            sphereForm.Show();
        }


        // DE/Best Forms
        private void RastriginForm_Load_Best(object sender, EventArgs e)
        {
            Forms_DE_Best.RastriginForm rastriginForm = new Forms_DE_Best.RastriginForm();
            rastriginForm.Show();
        }

        private void AckleyForm_Load_Best(object sender, EventArgs e)
        {
            Forms_DE_Best.AckleyForm ackleyForm = new Forms_DE_Best.AckleyForm();
            ackleyForm.Show();
        }

        private void GriewankForm_Load_Best(object sender, EventArgs e)
        {
            Forms_DE_Best.GriewankForm griewankForm = new Forms_DE_Best.GriewankForm();
            griewankForm.Show();
        }

        private void RosenbrockForm_Load_Best(object sender, EventArgs e)
        {
            Forms_DE_Best.RosenbrockForm rosenbrockForm = new Forms_DE_Best.RosenbrockForm();
            rosenbrockForm.Show();
        }

        private void SphereForm_Load_Best(object sender, EventArgs e)
        {
            Forms_DE_Best.SphereForm sphereForm = new Forms_DE_Best.SphereForm();
            sphereForm.Show();
        }

        // DE/RandToBest Forms
        private void AckleyForm_Load_RandToBest(object sender, EventArgs e)
        {
            Forms_DE_RandToBest.AckleyForm ackleyForm = new Forms_DE_RandToBest.AckleyForm();
            ackleyForm.Show();
        }

        private void RastriginForm_Load_RandToBest(object sender, EventArgs e)
        {
            Forms_DE_RandToBest.RastriginForm rastriginForm = new Forms_DE_RandToBest.RastriginForm();
            rastriginForm.Show();
        }

        private void GriewankForm_Load_RandToBest(object sender, EventArgs e)
        {
            Forms_DE_RandToBest.GriewankForm griewankForm = new Forms_DE_RandToBest.GriewankForm();
            griewankForm.Show();
            
        }

        private void RosenbrockForm_Load_RandToBest(object sender, EventArgs e)
        {
            Forms_DE_RandToBest.RosenbrockForm rosenbrockForm = new Forms_DE_RandToBest.RosenbrockForm();
            rosenbrockForm.Show();
        }

        private void SphereForm_Load_RandToBest(object sender, EventArgs e)
        {
            Forms_DE_RandToBest.SphereForm sphereForm = new Forms_DE_RandToBest.SphereForm();
            sphereForm.Show();
        }

    }
}
