using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGit2Sharp;

namespace GitVisualizer
{
    public partial class Form1 : Form
    {
        private Repository repo = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadRepo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!Repository.IsValid(dialog.SelectedPath))
                {
                    MessageBox.Show("Error not valid repo path");
                    return;
                }

                this.repo = new Repository(dialog.SelectedPath);
            }
        }
        
        private void mainWindow_Paint(object sender, PaintEventArgs e)
        {
            if (this.repo != null)
            {
                
            }
        }
    }
}
