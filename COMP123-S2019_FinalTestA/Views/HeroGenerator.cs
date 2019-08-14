using COMP123_S2019_FinalTestA.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Student Name : Juneyeong Lee
 * Student Id : 301043697
 * Description : This is the Hero Data Container Class
 */

namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is event handler for Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadNames(object sender, EventArgs e)
        {
            GenerateNames();
        }

        /// <summary>
        /// This is the event handler for the Backbutton Click Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        /// This is the event handler for the Nextbutton Click Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateNames()
        {
            string FirstNamesFile = @"..\..\Data\firstNames.txt";
            var ReadFirstNames = File.ReadAllLines(FirstNamesFile);
            List<string> FirstNameList = ReadFirstNames.ToList();
            int FirstNameEndNumber = ReadFirstNames.Length;
            int FirstNameRadomNumber = new Random().Next(0, FirstNameEndNumber);
            FirstNameDataLabel.Text = FirstNameList[FirstNameRadomNumber];
            Program.character.FirstName = FirstNameDataLabel.Text;

            string LastNamesFile = @"..\..\Data\lastNames.txt";
            var ReadLastNames = File.ReadAllLines(LastNamesFile);
            List<string> LastNameList = ReadLastNames.ToList();
            int LastNameEndNumber = ReadLastNames.Length;
            int LastNameRadomNumber = new Random().Next(0, LastNameEndNumber);
            LastNameDataLabel.Text = LastNameList[LastNameRadomNumber];
            Program.character.LastName = LastNameList[LastNameRadomNumber];

            HeroNameTextBox.Text = FirstNameDataLabel.Text + ' ' + LastNameDataLabel.Text;
            Program.character.HeroName = HeroNameTextBox.Text;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                int number;

                do number = new Random().Next(10, 51);
                while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }

            FightingDataLabel.Text = randomNumbers[0].ToString();
            AgilityDataLabel.Text = randomNumbers[1].ToString();
            StrengthDataLabel.Text = randomNumbers[2].ToString();
            EnduranceDataLabel.Text = randomNumbers[3].ToString();
            ReasonDataLabel.Text = randomNumbers[4].ToString();
            IntuituonDataLabel.Text = randomNumbers[5].ToString();
            PsycheDataLabel.Text = randomNumbers[6].ToString();
            PopulariyDataLabel.Text = randomNumbers[7].ToString();

            Program.character.Fighting = FightingDataLabel.Text;
            Program.character.Agility = AgilityDataLabel.Text;
            Program.character.Strength = StrengthDataLabel.Text;
            Program.character.Endurance = EnduranceDataLabel.Text;
            Program.character.Reason = ReasonDataLabel.Text;
            Program.character.Intuition = IntuituonDataLabel.Text;
            Program.character.Psyche = PsycheDataLabel.Text;
            Program.character.Popularity = PopulariyDataLabel.Text;

        }



        private void GeneratePowersButton_Click(object sender, EventArgs e)
        {
            string PowerFile = @"..\..\Data\powers.txt";
            var ReadPowers = File.ReadAllLines(PowerFile);
            List<string> PowerList = ReadPowers.ToList();
            int PowerEndNumber = ReadPowers.Length;

            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                int number;

                do number = new Random().Next(0, PowerEndNumber);
                while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }
            label1.Text = PowerList[0];
            label2.Text = PowerList[1];
            label3.Text = PowerList[2];
            label4.Text = PowerList[3];
            label5.Text = PowerList[4];
            label6.Text = PowerList[5];
            label7.Text = PowerList[6];
            label8.Text = PowerList[7];

            Power p1 = new Power();
            p1.Name = label1.Text;
            Power p2 = new Power();
            p2.Name = label2.Text;
            Power p3 = new Power();
            p3.Name = label3.Text;
            Power p4 = new Power();
            p4.Name = label4.Text;
            Power p5 = new Power();
            p5.Name = label5.Text;
            Power p6 = new Power();
            p6.Name = label6.Text;
            Power p7 = new Power();
            p7.Name = label7.Text;
            Power p8 = new Power();
            p8.Name = label8.Text;

            Program.character.Powers.Add(p1);
            Program.character.Powers.Add(p2);
            Program.character.Powers.Add(p3);
            Program.character.Powers.Add(p4);
            Program.character.Powers.Add(p5);
            Program.character.Powers.Add(p6);
            Program.character.Powers.Add(p7);
            Program.character.Powers.Add(p8);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        //----------------------------------------------------
        private void EnduranceDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReasonLabel_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReasonDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenerateEverythingPowers()
        {
            string PowerFile = @"..\..\Data\powers.txt";
            var ReadPowers = File.ReadAllLines(PowerFile);
            List<string> PowerList = ReadPowers.ToList();
            int PowerEndNumber = ReadPowers.Length;

            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                int number;

                do number = new Random().Next(0, PowerEndNumber);
                while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }
            GP1Label.Text = PowerList[0];
            GP2Label.Text = PowerList[1];
            GP3Label.Text = PowerList[2];
            GP4Label.Text = PowerList[3];

            Power p1 = new Power();
            p1.Name = GP1Label.Text;
            Power p2 = new Power();
            p2.Name = GP2Label.Text;
            Power p3 = new Power();
            p3.Name = GP3Label.Text;
            Power p4 = new Power();
            p4.Name = GP4Label.Text;

            Program.character.Powers.Add(p1);
            Program.character.Powers.Add(p2);
            Program.character.Powers.Add(p3);
            Program.character.Powers.Add(p4);
        }
            private void GenerateEverythingAvility()
        {
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                int number;

                do number = new Random().Next(10, 51);
                while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }

            GA1Label.Text = randomNumbers[0].ToString();
            GA2Label.Text = randomNumbers[1].ToString();
            GA3Label.Text = randomNumbers[2].ToString();
            GA4Label.Text = randomNumbers[3].ToString();

            Program.character.Fighting = GA1Label.Text;
            Program.character.Agility = GA2Label.Text;
            Program.character.Strength = GA3Label.Text;
            Program.character.Endurance = GA4Label.Text;
            
        }
        private void GenerateEverythingButton_Click(object sender, EventArgs e)
        {

            GenerateEverythingAvility();

            GenerateEverythingPowers();

        }
    }
}
