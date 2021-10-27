using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;

        public Form1()
        {
            InitializeComponent();

            // Display initial message and options
            outputLabel.Text = "It's time you become a trainer. Your mom kicks you out";
            output2Label.Text = "Where will you go?";
            option1Label.Text = "Straight into the grass. No pokeballs. (55 % success)";
            option2Label.Text = "Oak's house";

            SoundPlayer junglePlayer = new SoundPlayer(Properties.Resources.jungle);
            junglePlayer.Play();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1) { page = 2; }
            else if (page == 2) { page = 99; }
            else if (page == 3) { page = 5; }
            else if (page == 4) { page = 6; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 98; }
            else if (page == 7) { page = 9; }
            else if (page == 9) { page = 96; }

            else if (page == 99) { page = 1; }
            else if (page == 98) { page = 1; }
            else if (page == 97) { page = 1; }


            /// Display text and game options to screen based on the 
            /// current page

            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2

            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2) { page = 99; }
            else if (page == 3) { page = 5; }
            else if (page == 4) { page = 5; }
            else if (page == 5) { page = 7; }
            else if (page == 6) { page = 99; }
            else if (page == 7) { page = 99; }
            else if (page == 8) { page = 98; }
            else if (page == 9) { page = 96; }

            else if (page == 99) { page = 96; }
            else if (page == 98) { page = 96; }
            else if (page == 97) { page = 96; }


            /// Display text and game options to screen based on the 
            /// current page
            /// 
            DisplayPage();

        }


        private void option3Button_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2

            if (page == 3) {page = 5; }
            else if (page == 5) { page = 7; }


            /// Display text and game options to screen based on the 
            /// current page
            /// 
            DisplayPage();
        }

        private void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    // Display initial message and options
                    outputLabel.Text = "It's time you become a trainer. Your mom kicks you out";
                    output2Label.Text = "Where will you go?";
                    option1Label.Text = "Straight into the grass. No pokeballs. (55 % success)";
                    option2Label.Text = "Oak's house";
                    SoundPlayer junglePlayer = new SoundPlayer(Properties.Resources.jungle);
                    junglePlayer.Play();

                    imageBox.Image = (Properties.Resources.deepBrush);
                    break;
                case 2:
                    // Display page message and options
                    outputLabel.Text = "You get pecked to death by a pidgey. Idiot";

                    option1Label.Text = "Yes";
                    option2Label.Text = ".";
                    SoundPlayer brookPlayer = new SoundPlayer(Properties.Resources.brook);
                    brookPlayer.Play();


                    break;
                case 3:
                    // Display page message and options
                    outputLabel.Text = "He offers you a starter pokemon";
                    output2Label.Text = "Which do you pick?";
                    option1Label.Text = "Charmander";
                    option2Label.Text = "Squirtle";
                    option3Label.Text = "Bulbasaur";
                    option3Label.Visible = true;
                    option3Button.Visible = true;

                    break;
                case 4:
                    // Display page message and options
                    outputLabel.Text = "Beating the odds, you made it through to Viridian City!";
                    output2Label.Text = "What will you do in Viridian City?";
                    option1Label.Text = "Talk to the local elderly men";
                    option2Label.Text = "Challenge the gym (diifcult)";
                    option3Label.Text = "Move on to the next city (which is a better fit for your level)";
                    option3Label.Visible = true;
                    option3Button.Visible = true;
                    break;
                case 5:
                    // Display page message and options
                    outputLabel.Text = $"Your pokemon gets you through the route safely. What will you do in Viridian City?";
                    output2Label.Text = "What will you do in Viridian City?";
                    option1Label.Text = "Talk to the local elderly men";
                    option2Label.Text = "Challenge the gym (diifcult)";
                    option3Label.Text = "Move on to the next city (which is a better fit for your level)";
                    option3Label.Visible = true;
                    option3Button.Visible = true;
                    break;
                case 6:
                    // Display page message and options
                    outputLabel.Text = $"He tells you suspiciously that he knows a place in Celadon where you can get rich (quick!), and that he's going there soon and can take you.";
                    output2Label.Text = "Do you go to Celadon City with him? (OLD MAN)";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 7:
                    // Display page message and options
                    outputLabel.Text = $"It's much higher than your current skill level. The gym leader is also a gang boss. Do you still challenge Giovanni?";
                    output2Label.Text = $"Do you still want to challenge the gym?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 8:
                    outputLabel.Text = $"You get rich as promised and completely forget about your old life. You can't remember why you ever wanted to be a pokemon trainer at all. Play again?";
                    output2Label.Text = $"OLD MAN ENDING";
                    option1Label.Text = ".";
                    option2Label.Text = ".";
                    break;
                case 9:
                    outputLabel.Text = $"Your sad level 9 team gets swept. Try again from the beginning.";
                    output2Label.Text = $"Play again??";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 99:
                    // Display page message and options
                    outputLabel.Text = "You black out and wake up at a pokemon center. Get up and try your journey again?";
                    output2Label.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 98:
                    outputLabel.Text = "You Win! Try to find the other endings ;)";
                    output2Label.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 97:
                    outputLabel.Text = "You.. Win? Theres another win option! Try to find the other endings;)";
                    output2Label.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 96:
                    outputLabel.Text = "Thanks for playing :)";
                    output2Label.Text = " ";
                    option1Label.Text = " ";
                    option2Label.Text = " ";
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
