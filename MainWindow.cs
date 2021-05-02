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
using Microsoft.VisualBasic.CompilerServices;

namespace GitVisualizer
{
    public partial class Form1 : Form
    {
        private int x = 0;
        private Repository repo = null;
        
        public Form1()
        {
            InitializeComponent();
            Draw.panel = this.panel1;
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
                this.panel1.AutoScrollMinSize = new Size(Draw.point.X + (this.repo.Branches["master"].Commits.Count() * 100), this.panel1.AutoScrollMinSize.Height);
                this.panel1.Invalidate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (this.repo != null)
            {
                Branch branch = this.repo.Branches["master"];

                foreach (var commit in branch.Commits)
                {
                    if (this.repo.Head.Tip.Sha == commit.Sha)
                    {
                        Draw.Head(e.Graphics);
                    }
                    
                    if (branch.Tip.Sha == commit.Sha)
                    {
                        Draw.Branch(e.Graphics, "master");
                    }
                    
                    Draw.Commit(e.Graphics, $"{commit.Sha.Substring(0, 7)}");
                }

                Draw.reset();
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            this.panel1.Invalidate();
        }
    }
}
