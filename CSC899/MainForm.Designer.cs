﻿namespace CSC899
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicDEDERandToolStripMenuItem,
            this.basicDEDEBestToolStripMenuItem});
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
            // 
            // ackleyFunctionToolStripMenuItem1
            // 
            this.ackleyFunctionToolStripMenuItem1.Name = "ackleyFunctionToolStripMenuItem1";
            this.ackleyFunctionToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.ackleyFunctionToolStripMenuItem1.Text = "Ackley Function";
            // 
            // griewankFunctionToolStripMenuItem1
            // 
            this.griewankFunctionToolStripMenuItem1.Name = "griewankFunctionToolStripMenuItem1";
            this.griewankFunctionToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.griewankFunctionToolStripMenuItem1.Text = "Griewank Function";
            // 
            // rosenbrockFunctionToolStripMenuItem1
            // 
            this.rosenbrockFunctionToolStripMenuItem1.Name = "rosenbrockFunctionToolStripMenuItem1";
            this.rosenbrockFunctionToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.rosenbrockFunctionToolStripMenuItem1.Text = "Rosenbrock Function";
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.squareToolStripMenuItem.Text = "Sphere Function";
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
    }
}
