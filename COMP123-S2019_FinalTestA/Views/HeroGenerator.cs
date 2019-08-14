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
    }
}
