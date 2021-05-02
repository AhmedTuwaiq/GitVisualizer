
namespace GitVisualizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.btnLoadRepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadRepo
            // 
            this.btnLoadRepo.Location = new System.Drawing.Point(8, -3);
            this.btnLoadRepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadRepo.Name = "btnLoadRepo";
            this.btnLoadRepo.Size = new System.Drawing.Size(94, 23);
            this.btnLoadRepo.TabIndex = 0;
            this.btnLoadRepo.Text = "Visualize";
            this.btnLoadRepo.UseVisualStyleBackColor = true;
            this.btnLoadRepo.Click += new System.EventHandler(this.btnLoadRepo_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.btnLoadRepo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainWindow";
            this.Text = "Git Visualizer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainWindow_Paint);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnLoadRepo;
    }
}

