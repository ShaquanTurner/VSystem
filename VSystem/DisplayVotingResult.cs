using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSystem
{
    public partial class DisplayVotingResult : Form
    {
        public DisplayVotingResult()//string value)
        {
            InitializeComponent();
            //string parishdisplay = Form1.Parishdisplay;
            //parishdisplay= lblParishR.ToString();
            
        }

        private void DisplayVotingResult_Load(object sender, EventArgs e)
        {
            
               lblParishR.Text = Form1.pdisplay;
                lblCommunityR.Text = Form1.cdisplay;
            this.lblProblemsR.Text = Form1.prodisplay;
           










        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
