namespace CSC899.Forms_DE_Best
{
    partial class RosenbrockForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDimension = new System.Windows.Forms.Button();
            this.txtUpperBound = new System.Windows.Forms.TextBox();
            this.txtLowerBound = new System.Windows.Forms.TextBox();
            this.txtPopulationSize = new System.Windows.Forms.TextBox();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.btnUpperBound = new System.Windows.Forms.Button();
            this.btnLowerBound = new System.Windows.Forms.Button();
            this.btnPopulationSize = new System.Windows.Forms.Button();
            this.btnIterations = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScaleFactor = new System.Windows.Forms.Button();
            this.btnCrossOver = new System.Windows.Forms.Button();
            this.txtScalingFactor = new System.Windows.Forms.TextBox();
            this.txtCrossOver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNumOfRuns = new System.Windows.Forms.Button();
            this.txtNumOfRuns = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDimension);
            this.groupBox1.Controls.Add(this.txtUpperBound);
            this.groupBox1.Controls.Add(this.txtLowerBound);
            this.groupBox1.Controls.Add(this.txtPopulationSize);
            this.groupBox1.Controls.Add(this.txtDimension);
            this.groupBox1.Controls.Add(this.txtIterations);
            this.groupBox1.Controls.Add(this.btnUpperBound);
            this.groupBox1.Controls.Add(this.btnLowerBound);
            this.groupBox1.Controls.Add(this.btnPopulationSize);
            this.groupBox1.Controls.Add(this.btnIterations);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Static Variables";
            // 
            // btnDimension
            // 
            this.btnDimension.Location = new System.Drawing.Point(277, 48);
            this.btnDimension.Name = "btnDimension";
            this.btnDimension.Size = new System.Drawing.Size(113, 23);
            this.btnDimension.TabIndex = 15;
            this.btnDimension.Text = "Set Dimension";
            this.btnDimension.UseVisualStyleBackColor = true;
            this.btnDimension.Click += new System.EventHandler(this.btnDimension_Click);
            // 
            // txtUpperBound
            // 
            this.txtUpperBound.Location = new System.Drawing.Point(131, 148);
            this.txtUpperBound.Name = "txtUpperBound";
            this.txtUpperBound.Size = new System.Drawing.Size(100, 20);
            this.txtUpperBound.TabIndex = 14;
            // 
            // txtLowerBound
            // 
            this.txtLowerBound.Location = new System.Drawing.Point(131, 118);
            this.txtLowerBound.Name = "txtLowerBound";
            this.txtLowerBound.Size = new System.Drawing.Size(100, 20);
            this.txtLowerBound.TabIndex = 13;
            // 
            // txtPopulationSize
            // 
            this.txtPopulationSize.Location = new System.Drawing.Point(131, 83);
            this.txtPopulationSize.Name = "txtPopulationSize";
            this.txtPopulationSize.Size = new System.Drawing.Size(100, 20);
            this.txtPopulationSize.TabIndex = 12;
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(131, 54);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(100, 20);
            this.txtDimension.TabIndex = 11;
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(131, 21);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(100, 20);
            this.txtIterations.TabIndex = 10;
            // 
            // btnUpperBound
            // 
            this.btnUpperBound.Location = new System.Drawing.Point(277, 149);
            this.btnUpperBound.Name = "btnUpperBound";
            this.btnUpperBound.Size = new System.Drawing.Size(113, 23);
            this.btnUpperBound.TabIndex = 9;
            this.btnUpperBound.Text = "Set Upper Bound";
            this.btnUpperBound.UseVisualStyleBackColor = true;
            this.btnUpperBound.Click += new System.EventHandler(this.btnUpperBound_Click);
            // 
            // btnLowerBound
            // 
            this.btnLowerBound.Location = new System.Drawing.Point(277, 115);
            this.btnLowerBound.Name = "btnLowerBound";
            this.btnLowerBound.Size = new System.Drawing.Size(113, 23);
            this.btnLowerBound.TabIndex = 8;
            this.btnLowerBound.Text = "Set Lower Bound";
            this.btnLowerBound.UseVisualStyleBackColor = true;
            this.btnLowerBound.Click += new System.EventHandler(this.btnLowerBound_Click);
            // 
            // btnPopulationSize
            // 
            this.btnPopulationSize.Location = new System.Drawing.Point(277, 80);
            this.btnPopulationSize.Name = "btnPopulationSize";
            this.btnPopulationSize.Size = new System.Drawing.Size(113, 23);
            this.btnPopulationSize.TabIndex = 7;
            this.btnPopulationSize.Text = "Set Population Size";
            this.btnPopulationSize.UseVisualStyleBackColor = true;
            this.btnPopulationSize.Click += new System.EventHandler(this.btnPopulationSize_Click);
            // 
            // btnIterations
            // 
            this.btnIterations.Location = new System.Drawing.Point(277, 19);
            this.btnIterations.Name = "btnIterations";
            this.btnIterations.Size = new System.Drawing.Size(113, 23);
            this.btnIterations.TabIndex = 5;
            this.btnIterations.Text = "Set No Of Iterations";
            this.btnIterations.UseVisualStyleBackColor = true;
            this.btnIterations.Click += new System.EventHandler(this.btnIterations_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Upper Bound";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lower Bound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size of Population";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vector Dimension";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Iterations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnScaleFactor);
            this.groupBox2.Controls.Add(this.btnCrossOver);
            this.groupBox2.Controls.Add(this.txtScalingFactor);
            this.groupBox2.Controls.Add(this.txtCrossOver);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(515, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Changeable Variables";
            // 
            // btnScaleFactor
            // 
            this.btnScaleFactor.Location = new System.Drawing.Point(315, 55);
            this.btnScaleFactor.Name = "btnScaleFactor";
            this.btnScaleFactor.Size = new System.Drawing.Size(113, 23);
            this.btnScaleFactor.TabIndex = 18;
            this.btnScaleFactor.Text = "Set Scaling Factor";
            this.btnScaleFactor.UseVisualStyleBackColor = true;
            this.btnScaleFactor.Click += new System.EventHandler(this.btnScaleFactor_Click);
            // 
            // btnCrossOver
            // 
            this.btnCrossOver.Location = new System.Drawing.Point(315, 22);
            this.btnCrossOver.Name = "btnCrossOver";
            this.btnCrossOver.Size = new System.Drawing.Size(113, 23);
            this.btnCrossOver.TabIndex = 17;
            this.btnCrossOver.Text = "Set CrossOver Probability";
            this.btnCrossOver.UseVisualStyleBackColor = true;
            this.btnCrossOver.Click += new System.EventHandler(this.btnCrossOver_Click);
            // 
            // txtScalingFactor
            // 
            this.txtScalingFactor.Location = new System.Drawing.Point(177, 58);
            this.txtScalingFactor.Name = "txtScalingFactor";
            this.txtScalingFactor.Size = new System.Drawing.Size(100, 20);
            this.txtScalingFactor.TabIndex = 16;
            // 
            // txtCrossOver
            // 
            this.txtCrossOver.Location = new System.Drawing.Point(177, 25);
            this.txtCrossOver.Name = "txtCrossOver";
            this.txtCrossOver.Size = new System.Drawing.Size(100, 20);
            this.txtCrossOver.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Scaling Factor(F)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "CrossOver Probability(CR)";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(13, 252);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisplay.Size = new System.Drawing.Size(962, 204);
            this.txtDisplay.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAbort);
            this.groupBox3.Controls.Add(this.btnResume);
            this.groupBox3.Controls.Add(this.btnPause);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Location = new System.Drawing.Point(515, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 93);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execution Control";
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(326, 35);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 3;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(209, 35);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(87, 23);
            this.btnResume.TabIndex = 2;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(109, 34);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNumOfRuns
            // 
            this.btnNumOfRuns.Location = new System.Drawing.Point(289, 198);
            this.btnNumOfRuns.Name = "btnNumOfRuns";
            this.btnNumOfRuns.Size = new System.Drawing.Size(113, 23);
            this.btnNumOfRuns.TabIndex = 19;
            this.btnNumOfRuns.Text = "Set Number Of Runs";
            this.btnNumOfRuns.UseVisualStyleBackColor = true;
            this.btnNumOfRuns.Click += new System.EventHandler(this.btnNumOfRuns_Click);
            // 
            // txtNumOfRuns
            // 
            this.txtNumOfRuns.Location = new System.Drawing.Point(143, 201);
            this.txtNumOfRuns.Name = "txtNumOfRuns";
            this.txtNumOfRuns.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfRuns.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Number Of Runs";
            // 
            // RosenbrockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 494);
            this.Controls.Add(this.btnNumOfRuns);
            this.Controls.Add(this.txtNumOfRuns);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RosenbrockForm";
            this.Text = "Rosenbrock Function - DE/Best/";
            this.Load += new System.EventHandler(this.RosenbrockForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpperBound;
        private System.Windows.Forms.TextBox txtLowerBound;
        private System.Windows.Forms.TextBox txtPopulationSize;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Button btnUpperBound;
        private System.Windows.Forms.Button btnLowerBound;
        private System.Windows.Forms.Button btnPopulationSize;
        private System.Windows.Forms.Button btnIterations;
        private System.Windows.Forms.Button btnScaleFactor;
        private System.Windows.Forms.Button btnCrossOver;
        private System.Windows.Forms.TextBox txtScalingFactor;
        private System.Windows.Forms.TextBox txtCrossOver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDimension;
        private System.Windows.Forms.Button btnNumOfRuns;
        private System.Windows.Forms.TextBox txtNumOfRuns;
        private System.Windows.Forms.Label label8;
    }
}