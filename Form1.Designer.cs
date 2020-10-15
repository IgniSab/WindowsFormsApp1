namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.infoAudio = new System.Windows.Forms.Button();
            this.infoBios = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.infoSystem = new System.Windows.Forms.Button();
            this.infoRAM = new System.Windows.Forms.Button();
            this.infoStorage = new System.Windows.Forms.Button();
            this.infoMotherBoard = new System.Windows.Forms.Button();
            this.infoGPU = new System.Windows.Forms.Button();
            this.infoCPU = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.infoAudio);
            this.panel1.Controls.Add(this.infoBios);
            this.panel1.Controls.Add(this.ReportButton);
            this.panel1.Controls.Add(this.infoSystem);
            this.panel1.Controls.Add(this.infoRAM);
            this.panel1.Controls.Add(this.infoStorage);
            this.panel1.Controls.Add(this.infoMotherBoard);
            this.panel1.Controls.Add(this.infoGPU);
            this.panel1.Controls.Add(this.infoCPU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 859);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 779);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 80);
            this.button1.TabIndex = 9;
            this.button1.Text = "Performance evaluation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoAudio
            // 
            this.infoAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoAudio.FlatAppearance.BorderSize = 0;
            this.infoAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoAudio.Location = new System.Drawing.Point(0, 617);
            this.infoAudio.Name = "infoAudio";
            this.infoAudio.Size = new System.Drawing.Size(131, 80);
            this.infoAudio.TabIndex = 8;
            this.infoAudio.Text = "Audio";
            this.infoAudio.UseVisualStyleBackColor = true;
            this.infoAudio.Click += new System.EventHandler(this.infoAudio_Click);
            // 
            // infoBios
            // 
            this.infoBios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoBios.FlatAppearance.BorderSize = 0;
            this.infoBios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBios.Location = new System.Drawing.Point(0, 543);
            this.infoBios.Name = "infoBios";
            this.infoBios.Size = new System.Drawing.Size(131, 80);
            this.infoBios.TabIndex = 7;
            this.infoBios.Text = "Bios";
            this.infoBios.UseVisualStyleBackColor = true;
            this.infoBios.Click += new System.EventHandler(this.infoBios_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Location = new System.Drawing.Point(0, 690);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(131, 80);
            this.ReportButton.TabIndex = 6;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // infoSystem
            // 
            this.infoSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoSystem.FlatAppearance.BorderSize = 0;
            this.infoSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoSystem.Location = new System.Drawing.Point(0, 457);
            this.infoSystem.Name = "infoSystem";
            this.infoSystem.Size = new System.Drawing.Size(131, 80);
            this.infoSystem.TabIndex = 5;
            this.infoSystem.Text = "System";
            this.infoSystem.UseVisualStyleBackColor = true;
            this.infoSystem.Click += new System.EventHandler(this.infoSystem_Click);
            // 
            // infoRAM
            // 
            this.infoRAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoRAM.FlatAppearance.BorderSize = 0;
            this.infoRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoRAM.Location = new System.Drawing.Point(0, 186);
            this.infoRAM.Name = "infoRAM";
            this.infoRAM.Size = new System.Drawing.Size(131, 81);
            this.infoRAM.TabIndex = 4;
            this.infoRAM.Text = "RAM";
            this.infoRAM.UseVisualStyleBackColor = true;
            this.infoRAM.Click += new System.EventHandler(this.infoRAM_Click_1);
            // 
            // infoStorage
            // 
            this.infoStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoStorage.FlatAppearance.BorderSize = 0;
            this.infoStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoStorage.Location = new System.Drawing.Point(0, 358);
            this.infoStorage.Name = "infoStorage";
            this.infoStorage.Size = new System.Drawing.Size(131, 93);
            this.infoStorage.TabIndex = 3;
            this.infoStorage.Text = "Storage";
            this.infoStorage.UseVisualStyleBackColor = true;
            this.infoStorage.Click += new System.EventHandler(this.infoStorage_Click_1);
            // 
            // infoMotherBoard
            // 
            this.infoMotherBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoMotherBoard.FlatAppearance.BorderSize = 0;
            this.infoMotherBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoMotherBoard.Location = new System.Drawing.Point(0, 273);
            this.infoMotherBoard.Name = "infoMotherBoard";
            this.infoMotherBoard.Size = new System.Drawing.Size(131, 96);
            this.infoMotherBoard.TabIndex = 2;
            this.infoMotherBoard.Text = "Motherboard";
            this.infoMotherBoard.UseVisualStyleBackColor = true;
            this.infoMotherBoard.Click += new System.EventHandler(this.infoMotherBoard_Click_1);
            // 
            // infoGPU
            // 
            this.infoGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoGPU.FlatAppearance.BorderSize = 0;
            this.infoGPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoGPU.Location = new System.Drawing.Point(0, 91);
            this.infoGPU.Name = "infoGPU";
            this.infoGPU.Size = new System.Drawing.Size(131, 89);
            this.infoGPU.TabIndex = 1;
            this.infoGPU.Text = "GPU";
            this.infoGPU.UseVisualStyleBackColor = true;
            this.infoGPU.Click += new System.EventHandler(this.infoGPU_Click_1);
            // 
            // infoCPU
            // 
            this.infoCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.infoCPU.FlatAppearance.BorderSize = 0;
            this.infoCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoCPU.Location = new System.Drawing.Point(0, 3);
            this.infoCPU.Name = "infoCPU";
            this.infoCPU.Size = new System.Drawing.Size(131, 92);
            this.infoCPU.TabIndex = 0;
            this.infoCPU.Text = "CPU";
            this.infoCPU.UseVisualStyleBackColor = true;
            this.infoCPU.Click += new System.EventHandler(this.infoCPU_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.richTextBox1.Location = new System.Drawing.Point(137, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(808, 810);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(957, 859);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonitoringPC";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button infoCPU;
        private System.Windows.Forms.Button infoGPU;
        private System.Windows.Forms.Button infoMotherBoard;
        private System.Windows.Forms.Button infoRAM;
        private System.Windows.Forms.Button infoSystem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button infoBios;
        private System.Windows.Forms.Button infoAudio;
        private System.Windows.Forms.Button infoStorage;
        private System.Windows.Forms.Button button1;
    }
}

