namespace CSC899
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basicDEDERandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rastriginFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ackleyFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griewankFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosenbrockFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicDEDEBestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rastriginFunctionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ackleyFunctionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.griewankFunctionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rosenbrockFunctionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicDEDERandToBestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rastriginFunctionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ackleyFunctionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.griewankFunctionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rosenbrockFunctionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereFunctionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selfAdaptiveDERandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rastriginFunctionToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ackleyFunctionToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.griewankFunctionToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.rosenbrockFunctionToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereFunctionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.selfAdaptiveModifiedDERandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rastriginFunctionToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ackleyFunctionToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.griewankFunctionToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.rosenbrockFunctionToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereFunctionToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicDEDERandToolStripMenuItem,
            this.basicDEDEBestToolStripMenuItem,
            this.basicDEDERandToBestToolStripMenuItem,
            this.selfAdaptiveDERandToolStripMenuItem,
            this.selfAdaptiveModifiedDERandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basicDEDERandToolStripMenuItem
            // 
            this.basicDEDERandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rastriginFunctionToolStripMenuItem,
            this.ackleyFunctionToolStripMenuItem,
            this.griewankFunctionToolStripMenuItem,
            this.rosenbrockFunctionToolStripMenuItem,
            this.sphereFunctionToolStripMenuItem});
            this.basicDEDERandToolStripMenuItem.Name = "basicDEDERandToolStripMenuItem";
            this.basicDEDERandToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.basicDEDERandToolStripMenuItem.Text = "Basic DE - DE/Rand/";
            // 
            // rastriginFunctionToolStripMenuItem
            // 
            this.rastriginFunctionToolStripMenuItem.Name = "rastriginFunctionToolStripMenuItem";
            this.rastriginFunctionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.rastriginFunctionToolStripMenuItem.Text = "Rastrigin Function";
            this.rastriginFunctionToolStripMenuItem.Click += new System.EventHandler(this.RastriginForm_Load);
            // 
            // ackleyFunctionToolStripMenuItem
            // 
            this.ackleyFunctionToolStripMenuItem.Name = "ackleyFunctionToolStripMenuItem";
            this.ackleyFunctionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ackleyFunctionToolStripMenuItem.Text = "Ackley Function";
            this.ackleyFunctionToolStripMenuItem.Click += new System.EventHandler(this.AckleyForm_Load);
            // 
            // griewankFunctionToolStripMenuItem
            // 
            this.griewankFunctionToolStripMenuItem.Name = "griewankFunctionToolStripMenuItem";
            this.griewankFunctionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.griewankFunctionToolStripMenuItem.Text = "Griewank Function";
            this.griewankFunctionToolStripMenuItem.Click += new System.EventHandler(this.GriewankForm_Load);
            // 
            // rosenbrockFunctionToolStripMenuItem
            // 
            this.rosenbrockFunctionToolStripMenuItem.Name = "rosenbrockFunctionToolStripMenuItem";
            this.rosenbrockFunctionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.rosenbrockFunctionToolStripMenuItem.Text = "Rosenbrock Function";
            this.rosenbrockFunctionToolStripMenuItem.Click += new System.EventHandler(this.RosenbrockForm_Load);
            // 
            // sphereFunctionToolStripMenuItem
            // 
            this.sphereFunctionToolStripMenuItem.Name = "sphereFunctionToolStripMenuItem";
            this.sphereFunctionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.sphereFunctionToolStripMenuItem.Text = "Sphere Function";
            this.sphereFunctionToolStripMenuItem.Click += new System.EventHandler(this.SphereForm_Load);
            // 
            // basicDEDEBestToolStripMenuItem
            // 
            this.basicDEDEBestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rastriginFunctionToolStripMenuItem1,
            this.ackleyFunctionToolStripMenuItem1,
            this.griewankFunctionToolStripMenuItem1,
            this.rosenbrockFunctionToolStripMenuItem1,
            this.squareToolStripMenuItem});
            this.basicDEDEBestToolStripMenuItem.Name = "basicDEDEBestToolStripMenuItem";
            this.basicDEDEBestToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.basicDEDEBestToolStripMenuItem.Text = "Basic DE - DE/Best/";
            // 
            // rastriginFunctionToolStripMenuItem1
            // 
            this.rastriginFunctionToolStripMenuItem1.Name = "rastriginFunctionToolStripMenuItem1";
            this.rastriginFunctionToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.rastriginFunctionToolStripMenuItem1.Text = "Rastrigin Function";
            this.rastriginFunctionToolStripMenuItem1.Click += new System.EventHandler(this.RastriginForm_Load_Best);
            // 
            // ackleyFunctionToolStripMenuItem1
            // 
            this.ackleyFunctionToolStripMenuItem1.Name = "ackleyFunctionToolStripMenuItem1";
            this.ackleyFunctionToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.ackleyFunctionToolStripMenuItem1.Text = "Ackley Function";
            this.ackleyFunctionToolStripMenuItem1.Click += new System.EventHandler(this.AckleyForm_Load_Best);
            // 
            // griewankFunctionToolStripMenuItem1
            // 
            this.griewankFunctionToolStripMenuItem1.Name = "griewankFunctionToolStripMenuItem1";
            this.griewankFunctionToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.griewankFunctionToolStripMenuItem1.Text = "Griewank Function";
            this.griewankFunctionToolStripMenuItem1.Click += new System.EventHandler(this.GriewankForm_Load_Best);
            // 
            // rosenbrockFunctionToolStripMenuItem1
            // 
            this.rosenbrockFunctionToolStripMenuItem1.Name = "rosenbrockFunctionToolStripMenuItem1";
            this.rosenbrockFunctionToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.rosenbrockFunctionToolStripMenuItem1.Text = "Rosenbrock Function";
            this.rosenbrockFunctionToolStripMenuItem1.Click += new System.EventHandler(this.RosenbrockForm_Load_Best);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.squareToolStripMenuItem.Text = "Sphere Function";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.SphereForm_Load_Best);
            // 
            // basicDEDERandToBestToolStripMenuItem
            // 
            this.basicDEDERandToBestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rastriginFunctionToolStripMenuItem2,
            this.ackleyFunctionToolStripMenuItem2,
            this.griewankFunctionToolStripMenuItem2,
            this.rosenbrockFunctionToolStripMenuItem2,
            this.sphereFunctionToolStripMenuItem1});
            this.basicDEDERandToBestToolStripMenuItem.Name = "basicDEDERandToBestToolStripMenuItem";
            this.basicDEDERandToBestToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.basicDEDERandToBestToolStripMenuItem.Text = "Basic DE - DE/RandToBest/";
            // 
            // rastriginFunctionToolStripMenuItem2
            // 
            this.rastriginFunctionToolStripMenuItem2.Name = "rastriginFunctionToolStripMenuItem2";
            this.rastriginFunctionToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.rastriginFunctionToolStripMenuItem2.Text = "Rastrigin Function";
            this.rastriginFunctionToolStripMenuItem2.Click += new System.EventHandler(this.RastriginForm_Load_RandToBest);
            // 
            // ackleyFunctionToolStripMenuItem2
            // 
            this.ackleyFunctionToolStripMenuItem2.Name = "ackleyFunctionToolStripMenuItem2";
            this.ackleyFunctionToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.ackleyFunctionToolStripMenuItem2.Text = "Ackley Function";
            this.ackleyFunctionToolStripMenuItem2.Click += new System.EventHandler(this.AckleyForm_Load_RandToBest);
            // 
            // griewankFunctionToolStripMenuItem2
            // 
            this.griewankFunctionToolStripMenuItem2.Name = "griewankFunctionToolStripMenuItem2";
            this.griewankFunctionToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.griewankFunctionToolStripMenuItem2.Text = "Griewank Function";
            this.griewankFunctionToolStripMenuItem2.Click += new System.EventHandler(this.GriewankForm_Load_RandToBest);
            // 
            // rosenbrockFunctionToolStripMenuItem2
            // 
            this.rosenbrockFunctionToolStripMenuItem2.Name = "rosenbrockFunctionToolStripMenuItem2";
            this.rosenbrockFunctionToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.rosenbrockFunctionToolStripMenuItem2.Text = "Rosenbrock Function";
            this.rosenbrockFunctionToolStripMenuItem2.Click += new System.EventHandler(this.RosenbrockForm_Load_RandToBest);
            // 
            // sphereFunctionToolStripMenuItem1
            // 
            this.sphereFunctionToolStripMenuItem1.Name = "sphereFunctionToolStripMenuItem1";
            this.sphereFunctionToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.sphereFunctionToolStripMenuItem1.Text = "Sphere Function";
            this.sphereFunctionToolStripMenuItem1.Click += new System.EventHandler(this.SphereForm_Load_RandToBest);
            // 
            // selfAdaptiveDERandToolStripMenuItem
            // 
            this.selfAdaptiveDERandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rastriginFunctionToolStripMenuItem3,
            this.ackleyFunctionToolStripMenuItem3,
            this.griewankFunctionToolStripMenuItem3,
            this.rosenbrockFunctionToolStripMenuItem3,
            this.sphereFunctionToolStripMenuItem2});
            this.selfAdaptiveDERandToolStripMenuItem.Name = "selfAdaptiveDERandToolStripMenuItem";
            this.selfAdaptiveDERandToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.selfAdaptiveDERandToolStripMenuItem.Text = "Self Adaptive - DE/Rand";
            // 
            // rastriginFunctionToolStripMenuItem3
            // 
            this.rastriginFunctionToolStripMenuItem3.Name = "rastriginFunctionToolStripMenuItem3";
            this.rastriginFunctionToolStripMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.rastriginFunctionToolStripMenuItem3.Text = "Rastrigin Function";
            this.rastriginFunctionToolStripMenuItem3.Click += new System.EventHandler(this.RastriginForm_Load_RandToBest_SA);
            // 
            // ackleyFunctionToolStripMenuItem3
            // 
            this.ackleyFunctionToolStripMenuItem3.Name = "ackleyFunctionToolStripMenuItem3";
            this.ackleyFunctionToolStripMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.ackleyFunctionToolStripMenuItem3.Text = "Ackley Function";
            this.ackleyFunctionToolStripMenuItem3.Click += new System.EventHandler(this.AckleyForm_Load_RandToBest_SA);
            // 
            // griewankFunctionToolStripMenuItem3
            // 
            this.griewankFunctionToolStripMenuItem3.Name = "griewankFunctionToolStripMenuItem3";
            this.griewankFunctionToolStripMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.griewankFunctionToolStripMenuItem3.Text = "Griewank Function";
            this.griewankFunctionToolStripMenuItem3.Click += new System.EventHandler(this.GriewankForm_Load_RandToBest_SA);
            // 
            // rosenbrockFunctionToolStripMenuItem3
            // 
            this.rosenbrockFunctionToolStripMenuItem3.Name = "rosenbrockFunctionToolStripMenuItem3";
            this.rosenbrockFunctionToolStripMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.rosenbrockFunctionToolStripMenuItem3.Text = "Rosenbrock Function";
            this.rosenbrockFunctionToolStripMenuItem3.Click += new System.EventHandler(this.RosenbrockForm_Load_RandToBest_SA);
            // 
            // sphereFunctionToolStripMenuItem2
            // 
            this.sphereFunctionToolStripMenuItem2.Name = "sphereFunctionToolStripMenuItem2";
            this.sphereFunctionToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.sphereFunctionToolStripMenuItem2.Text = "Sphere Function";
            this.sphereFunctionToolStripMenuItem2.Click += new System.EventHandler(this.SphereForm_Load_RandToBest_SA);
            // 
            // selfAdaptiveModifiedDERandToolStripMenuItem
            // 
            this.selfAdaptiveModifiedDERandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rastriginFunctionToolStripMenuItem4,
            this.ackleyFunctionToolStripMenuItem4,
            this.griewankFunctionToolStripMenuItem4,
            this.rosenbrockFunctionToolStripMenuItem4,
            this.sphereFunctionToolStripMenuItem3});
            this.selfAdaptiveModifiedDERandToolStripMenuItem.Name = "selfAdaptiveModifiedDERandToolStripMenuItem";
            this.selfAdaptiveModifiedDERandToolStripMenuItem.Size = new System.Drawing.Size(193, 20);
            this.selfAdaptiveModifiedDERandToolStripMenuItem.Text = "Self Adaptive Modified- DE/Rand";
            // 
            // rastriginFunctionToolStripMenuItem4
            // 
            this.rastriginFunctionToolStripMenuItem4.Name = "rastriginFunctionToolStripMenuItem4";
            this.rastriginFunctionToolStripMenuItem4.Size = new System.Drawing.Size(186, 22);
            this.rastriginFunctionToolStripMenuItem4.Text = "Rastrigin Function";
            this.rastriginFunctionToolStripMenuItem4.Click += new System.EventHandler(this.RastriginForm_Load_RandToBest_SA_MO);
            // 
            // ackleyFunctionToolStripMenuItem4
            // 
            this.ackleyFunctionToolStripMenuItem4.Name = "ackleyFunctionToolStripMenuItem4";
            this.ackleyFunctionToolStripMenuItem4.Size = new System.Drawing.Size(186, 22);
            this.ackleyFunctionToolStripMenuItem4.Text = "Ackley Function";
            this.ackleyFunctionToolStripMenuItem4.Click += new System.EventHandler(this.AckleyForm_Load_RandToBest_SA_MO);
            // 
            // griewankFunctionToolStripMenuItem4
            // 
            this.griewankFunctionToolStripMenuItem4.Name = "griewankFunctionToolStripMenuItem4";
            this.griewankFunctionToolStripMenuItem4.Size = new System.Drawing.Size(186, 22);
            this.griewankFunctionToolStripMenuItem4.Text = "Griewank Function";
            this.griewankFunctionToolStripMenuItem4.Click += new System.EventHandler(this.GriewankForm_Load_RandToBest_SA_MO);
            // 
            // rosenbrockFunctionToolStripMenuItem4
            // 
            this.rosenbrockFunctionToolStripMenuItem4.Name = "rosenbrockFunctionToolStripMenuItem4";
            this.rosenbrockFunctionToolStripMenuItem4.Size = new System.Drawing.Size(186, 22);
            this.rosenbrockFunctionToolStripMenuItem4.Text = "Rosenbrock Function";
            this.rosenbrockFunctionToolStripMenuItem4.Click += new System.EventHandler(this.RosenbrockForm_Load_RandToBest_SA_MO);
            // 
            // sphereFunctionToolStripMenuItem3
            // 
            this.sphereFunctionToolStripMenuItem3.Name = "sphereFunctionToolStripMenuItem3";
            this.sphereFunctionToolStripMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.sphereFunctionToolStripMenuItem3.Text = "Sphere Function";
            this.sphereFunctionToolStripMenuItem3.Click += new System.EventHandler(this.SphereForm_Load_RandToBest_SA_MO);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 456);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Differential Evolution Research";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basicDEDERandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rastriginFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ackleyFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griewankFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosenbrockFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sphereFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicDEDEBestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rastriginFunctionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ackleyFunctionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem griewankFunctionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rosenbrockFunctionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicDEDERandToBestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rastriginFunctionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ackleyFunctionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem griewankFunctionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rosenbrockFunctionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sphereFunctionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selfAdaptiveDERandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rastriginFunctionToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ackleyFunctionToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem griewankFunctionToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem rosenbrockFunctionToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sphereFunctionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem selfAdaptiveModifiedDERandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rastriginFunctionToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ackleyFunctionToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem griewankFunctionToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem rosenbrockFunctionToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sphereFunctionToolStripMenuItem3;
    }
}

