namespace ChartApp
{
    partial class Main
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
            btnCPU = new System.Windows.Forms.Button();
            btnMemory = new System.Windows.Forms.Button();
            btnDisk = new System.Windows.Forms.Button();
            btnPauseResume = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnCPU
            // 
            btnCPU.Location = new System.Drawing.Point(953, 384);
            btnCPU.Name = "btnCPU";
            btnCPU.Size = new System.Drawing.Size(162, 54);
            btnCPU.TabIndex = 0;
            btnCPU.Text = "CPU (ON)";
            btnCPU.UseVisualStyleBackColor = true;
            btnCPU.Click += btnCPU_Click;
            // 
            // btnMemory
            // 
            btnMemory.Location = new System.Drawing.Point(953, 460);
            btnMemory.Name = "btnMemory";
            btnMemory.Size = new System.Drawing.Size(162, 61);
            btnMemory.TabIndex = 1;
            btnMemory.Text = "MEMORY (OFF)";
            btnMemory.UseVisualStyleBackColor = true;
            btnMemory.Click += btnMemory_Click;
            // 
            // btnDisk
            // 
            btnDisk.Location = new System.Drawing.Point(953, 537);
            btnDisk.Name = "btnDisk";
            btnDisk.Size = new System.Drawing.Size(151, 69);
            btnDisk.TabIndex = 2;
            btnDisk.Text = "DISK (OFF)";
            btnDisk.UseVisualStyleBackColor = true;
            btnDisk.Click += btnDisk_Click;
            // 
            // btnPauseResume
            // 
            btnPauseResume.Location = new System.Drawing.Point(953, 319);
            btnPauseResume.Name = "btnPauseResume";
            btnPauseResume.Size = new System.Drawing.Size(151, 59);
            btnPauseResume.TabIndex = 3;
            btnPauseResume.Text = "Pause ||";
            btnPauseResume.UseVisualStyleBackColor = true;
            btnPauseResume.Click += btnPauseResume_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1140, 858);
            Controls.Add(btnPauseResume);
            Controls.Add(btnDisk);
            Controls.Add(btnMemory);
            Controls.Add(btnCPU);
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Name = "Main";
            Text = "System Metrics";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnDisk;
        private System.Windows.Forms.Button btnPauseResume;
    }
}

