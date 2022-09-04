using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Entry_Application
{
    public partial class DataEntryForm : Form
    {

        TimeSpan timeElapsed;
        DateTime lastElapsed;
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           txtAddress.Clear();
            txtCity.Clear();
            txtName.Clear();
            txtState.Clear();
            txtTimer.Clear();
            txtZip.Clear();
            txtName.Focus();    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            btnStart.Enabled = false;
            tickTimer.Enabled = true;
            grpDataEntry.Enabled=true;
            txtName.Focus();
            lastElapsed=DateTime.Now;

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            grpDataEntry.Enabled = false;
            tickTimer.Enabled=false;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            timeElapsed = DateTime.Now - lastElapsed;
            lastElapsed = DateTime.Now;
        }
    }
}
