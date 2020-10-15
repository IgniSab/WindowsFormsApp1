namespace WindowsFormsApp1
{
    partial class PerfEv
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
            this.CpuThread = new System.Windows.Forms.Label();
            this.raitingCPU = new System.Windows.Forms.Label();
            this.RatingRAM = new System.Windows.Forms.Label();
            this.RAMcapacity = new System.Windows.Forms.Label();
            this.Windows_RAT = new System.Windows.Forms.Label();
            this.raitingWindows = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CpuThread
            // 
            this.CpuThread.AutoSize = true;
            this.CpuThread.Location = new System.Drawing.Point(13, 9);
            this.CpuThread.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CpuThread.Name = "CpuThread";
            this.CpuThread.Size = new System.Drawing.Size(107, 21);
            this.CpuThread.TabIndex = 0;
            this.CpuThread.Text = "Cpu_Thread";
            // 
            // raitingCPU
            // 
            this.raitingCPU.AutoSize = true;
            this.raitingCPU.Location = new System.Drawing.Point(12, 45);
            this.raitingCPU.Name = "raitingCPU";
            this.raitingCPU.Size = new System.Drawing.Size(106, 21);
            this.raitingCPU.TabIndex = 1;
            this.raitingCPU.Text = "Raiting CPU:";
            // 
            // RatingRAM
            // 
            this.RatingRAM.AutoSize = true;
            this.RatingRAM.Location = new System.Drawing.Point(13, 76);
            this.RatingRAM.Name = "RatingRAM";
            this.RatingRAM.Size = new System.Drawing.Size(111, 21);
            this.RatingRAM.TabIndex = 2;
            this.RatingRAM.Text = "Raiting RAM:";
            // 
            // RAMcapacity
            // 
            this.RAMcapacity.AutoSize = true;
            this.RAMcapacity.Location = new System.Drawing.Point(128, 9);
            this.RAMcapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RAMcapacity.Name = "RAMcapacity";
            this.RAMcapacity.Size = new System.Drawing.Size(130, 21);
            this.RAMcapacity.TabIndex = 3;
            this.RAMcapacity.Text = "RAM_Capacity";
            // 
            // Windows_RAT
            // 
            this.Windows_RAT.AutoSize = true;
            this.Windows_RAT.Location = new System.Drawing.Point(275, 9);
            this.Windows_RAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Windows_RAT.Name = "Windows_RAT";
            this.Windows_RAT.Size = new System.Drawing.Size(118, 21);
            this.Windows_RAT.TabIndex = 4;
            this.Windows_RAT.Text = "Windows_RAT";
            // 
            // raitingWindows
            // 
            this.raitingWindows.AutoSize = true;
            this.raitingWindows.Location = new System.Drawing.Point(13, 110);
            this.raitingWindows.Name = "raitingWindows";
            this.raitingWindows.Size = new System.Drawing.Size(142, 21);
            this.raitingWindows.TabIndex = 5;
            this.raitingWindows.Text = "Raiting Windows:";
            // 
            // PerfEv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(414, 265);
            this.Controls.Add(this.raitingWindows);
            this.Controls.Add(this.Windows_RAT);
            this.Controls.Add(this.RAMcapacity);
            this.Controls.Add(this.RatingRAM);
            this.Controls.Add(this.raitingCPU);
            this.Controls.Add(this.CpuThread);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PerfEv";
            this.Text = "Оценка системы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CpuThread;
        private System.Windows.Forms.Label raitingCPU;
        private System.Windows.Forms.Label RatingRAM;
        private System.Windows.Forms.Label RAMcapacity;
        private System.Windows.Forms.Label Windows_RAT;
        private System.Windows.Forms.Label raitingWindows;
    }
}