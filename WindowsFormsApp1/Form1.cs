using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        GameDoubler game;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }


        void UpdateInfo()
        {
            lblCount.Text = game.Count.ToString();
            lblCurrent.Text = game.Current.ToString();
            lblFinish.Text = game.Finish.ToString();
            lblSteps.Text = game.Steps.ToString();
            lblResult.Text = game.Status;            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new GameDoubler();
            game.action += UpdateInfo;
            UpdateInfo();
            btnMulti.Enabled = true;
            btnPlus.Enabled = true;
            btnBack.Enabled = true;
            btnReset.Enabled = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            game.Plus();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            game.Multi();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            game.Back();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            game.Reset();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
