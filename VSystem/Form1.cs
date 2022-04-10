
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


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
          
    
    }
        public static string pdisplay = "";
        public static string cdisplay = "";
        public static string prodisplay = "";
        private void ParishesCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommunityCBox.Items.Clear();
            ProblemCLBox.Items.Clear();
            if (ParishesCBox.SelectedItem.ToString() == "Kingston")
            {
                
                CommunityCBox.Items.Add("Red Hills");
                CommunityCBox.Items.Add("Old hope road");
                CommunityCBox.Items.Add("Papine");
                CommunityCBox.Items.Add("Gordon Town");
                ProblemCLBox.Items.Add("Water pipe brust");
                ProblemCLBox.Items.Add("noise pollution");
                ProblemCLBox.Items.Add("Scamming");
                ProblemCLBox.Items.Add("Corruption");
                ProblemCLBox.Items.Add("Break-ins");
                ProblemCLBox.Items.Add("Stealing");
                ProblemCLBox.Items.Add("Deforestation");
                ProblemCLBox.Items.Add("Robberies");
                ProblemCLBox.Items.Add("Aggravated Assaults");
                ProblemCLBox.Items.Add("Shootings");
                ProblemCLBox.Items.Add("Rapes");
                ProblemCLBox.Items.Add("Car Crashes");
                ProblemCLBox.Items.Add("Bad roads");
            } 
            else if(ParishesCBox.SelectedItem.ToString()== "Hanover")
            {
                CommunityCBox.Items.Add("Sandy Bay");
                CommunityCBox.Items.Add("Westfield");
                CommunityCBox.Items.Add("Lucea");
                CommunityCBox.Items.Add("Georgia");
                ProblemCLBox.Items.Add("Lack of access to public transportation ");
                ProblemCLBox.Items.Add("A power outage ");
                ProblemCLBox.Items.Add("Bad roads");
                ProblemCLBox.Items.Add("Corruption");
                ProblemCLBox.Items.Add("Break-ins");
                ProblemCLBox.Items.Add(" Lack of water");
                ProblemCLBox.Items.Add(" lack of tourism activity,");
                ProblemCLBox.Items.Add("Aggravated Assaults");
            }
            else if (ParishesCBox.SelectedItem.ToString() == "Westmoreland")
            {
                CommunityCBox.Items.Add("Savanna la Mar");
                CommunityCBox.Items.Add("Bluefields");
                CommunityCBox.Items.Add("Negril");
                CommunityCBox.Items.Add("Seaford Town");
                ProblemCLBox.Items.Add("Lack of access to public transportation ");
                ProblemCLBox.Items.Add("A power outage ");
                ProblemCLBox.Items.Add("Bad roads");
                ProblemCLBox.Items.Add("Corruption");
                ProblemCLBox.Items.Add(" Lack of water");
                ProblemCLBox.Items.Add("Water pollution");
                ProblemCLBox.Items.Add("Gang wars ");
            }
            else if (ParishesCBox.SelectedItem.ToString() == "St.Mary")
            {
                CommunityCBox.Items.Add("Port Maria");
                CommunityCBox.Items.Add("Annotto Bay"); //Toxic Algae Blooms toxic water
                CommunityCBox.Items.Add("Oracabessa");
                CommunityCBox.Items.Add("Stony Hill");
                ProblemCLBox.Items.Add("A power outage ");// mosquito problem
                ProblemCLBox.Items.Add("Corruption");
                ProblemCLBox.Items.Add(" Lack of water");
                ProblemCLBox.Items.Add("Water pollution");
                ProblemCLBox.Items.Add("Gang wars ");
                ProblemCLBox.Items.Add("Toxic Algae Blooms Grand lake");
                ProblemCLBox.Items.Add("Mosquito  Infestation");
            }
            else if (ParishesCBox.SelectedItem.ToString() == "St.Catherine")
            {
                CommunityCBox.Items.Add("Portmore");
                CommunityCBox.Items.Add("Old Harbour"); 
                CommunityCBox.Items.Add("Spanish Town");
                CommunityCBox.Items.Add("Bog Walk");
                ProblemCLBox.Items.Add("A power outage ");
                ProblemCLBox.Items.Add("Corruption");
                ProblemCLBox.Items.Add(" Lack of water");
                ProblemCLBox.Items.Add("Water pollution");
                ProblemCLBox.Items.Add("Lost acess to Flow wifi ");
            }

        }

        private void CommunityCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
               //Community for Kingston
            ProblemCLBox.Items.Clear();
            if (CommunityCBox.SelectedItem.ToString() == "Red Hills")
            {
                ProblemCLBox.Items.Add("Water Pipe Brust");
                ProblemCLBox.Items.Add("Rapes");

            }
            else if(CommunityCBox.SelectedItem.ToString() == "Old hope road")
            {
                ProblemCLBox.Items.Add("Scamming");
                ProblemCLBox.Items.Add("Corruption");
            }
            else if(CommunityCBox.SelectedItem.ToString()== "Papine")
            {
                ProblemCLBox.Items.Add("Scamming");
                ProblemCLBox.Items.Add("Car Crashes");
                ProblemCLBox.Items.Add("Corruption");
                ProblemCLBox.Items.Add("Shooting");
            }

            else if (CommunityCBox.SelectedItem.ToString() == "Gordon Town")
            {
            
                ProblemCLBox.Items.Add("Car Crashes");
                ProblemCLBox.Items.Add("Corruption");
                ProblemCLBox.Items.Add("Bad roads");
            }

            //Community for Hanover

            if (CommunityCBox.SelectedItem.ToString() == "Sandy Bay")
            {
                ProblemCLBox.Items.Add("Lack of access to public transportation");
                ProblemCLBox.Items.Add(" Lack of water");
            }

            else if (CommunityCBox.SelectedItem.ToString() == "Westfield")
            {
                ProblemCLBox.Items.Add("Lack of access to public transportation");
                ProblemCLBox.Items.Add(" Lack of water");
                ProblemCLBox.Items.Add("A power outage ");
            }
            else if (CommunityCBox.SelectedItem.ToString() == "Lucea")
            {
                ProblemCLBox.Items.Add("Lack of access to public transportation");
                ProblemCLBox.Items.Add(" Lack of water");
                ProblemCLBox.Items.Add("A power outage ");
                ProblemCLBox.Items.Add(" lack of tourism activity,");
            }
                
            else if(CommunityCBox.SelectedItem.ToString() == "Georgia")
            {
                ProblemCLBox.Items.Add(" Lack of water");
                ProblemCLBox.Items.Add("A power outage ");
                ProblemCLBox.Items.Add("Bad roads");

            }
            //Community for Westmoreland
            if (CommunityCBox.SelectedItem.ToString() == "Savanna la Mar")
            {
                ProblemCLBox.Items.Add("Water pollution");
                ProblemCLBox.Items.Add("Bad roads");
                ProblemCLBox.Items.Add("Corruption");
            }
            

            else if (CommunityCBox.SelectedItem.ToString() == "Bluefields")
            {
                ProblemCLBox.Items.Add("Water population");
                ProblemCLBox.Items.Add("Gang wars ");
            }
            else if (CommunityCBox.SelectedItem.ToString() == "Negril")
            {
                ProblemCLBox.Items.Add("Water population");
                ProblemCLBox.Items.Add("Lack of access to public transportation ");
            }

            else if (CommunityCBox.SelectedItem.ToString() == "Seaford Town")
            {
                ProblemCLBox.Items.Add("Lack of access to public transportation ");
                ProblemCLBox.Items.Add("Corruption");
            }
            //Commnunity for St.Mary

            if (CommunityCBox.SelectedItem.ToString() == "Port Maria")
            {
                ProblemCLBox.Items.Add("Mosquito  Infestation");
                ProblemCLBox.Items.Add("Toxic Algae Blooms Grand lake");

            }

            else if (CommunityCBox.SelectedItem.ToString() == "Annotto Bay")
            {
                ProblemCLBox.Items.Add("Mosquito  Infestation");
                ProblemCLBox.Items.Add("Corruption");
            }
            else if (CommunityCBox.SelectedItem.ToString() == "Oracabessa")
            {
                ProblemCLBox.Items.Add("Mosquito  Infestation");
                ProblemCLBox.Items.Add("Gang wars ");
            }

            else if (CommunityCBox.SelectedItem.ToString() == "Stony Hill")
            {
                ProblemCLBox.Items.Add("Mosquito  Infestation");
                ProblemCLBox.Items.Add(" Lack of water");


            }

            if (CommunityCBox.SelectedItem.ToString() == "Portmore")
            {
                ProblemCLBox.Items.Add("Lost acess to Flow wifi ");
                ProblemCLBox.Items.Add("Corruption");

            }

            else if (CommunityCBox.SelectedItem.ToString() == "Old Harbour")
            {
                ProblemCLBox.Items.Add("Lost acess to Flow wifi ");
                ProblemCLBox.Items.Add("Water pollution");
            }
            else if (CommunityCBox.SelectedItem.ToString() == "Spanish Town")
            {
                ProblemCLBox.Items.Add("Lost acess to Flow wifi ");
                ProblemCLBox.Items.Add(" Lack of water");

            }

            else if (CommunityCBox.SelectedItem.ToString() == "Bog Walk")
            {

                ProblemCLBox.Items.Add("Lost acess to Flow wifi ");

            }


        }

        private void ProblemCLBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // if(ParishesCBox.SelectedItem.ToString() =="")
            pdisplay = ParishesCBox.Text;
            cdisplay = CommunityCBox.Text;
            prodisplay = ProblemCLBox.Text;
            /*foreach(object SelectedItem in ProblemCLBox.Items)
            {
                MessageBox.Show(SelectedItem.ToString());
            }*/

            
           
           
            if (ParishesCBox.Text == "")
            {
                MessageBox.Show("Error Select your Parish ", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ParishesCBox.Focus();


            }
           
            else if(CommunityCBox.Text=="")
            {
                MessageBox.Show("Error Select your Community ", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CommunityCBox.Focus();
            }

           else if (ProblemCLBox.CheckedItems.Count<1)
            {
                MessageBox.Show("Error Select at least 1 Problem ", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProblemCLBox.Focus();
            }

            else {
            MessageBox.Show("Thanks for Voting ");
                DisplayVotingResult form = new DisplayVotingResult();
                form.Show();



            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
