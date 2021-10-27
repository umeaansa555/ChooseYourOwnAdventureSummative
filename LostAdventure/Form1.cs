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
            option3Label.Visible = false;
            option3Button.Visible = false;

            SoundPlayer openingPlayer = new SoundPlayer(Properties.Resources.Opening___Title_Screen___Pokémon_Red_Green_Blue);
            openingPlayer.Play();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            
            if (page == 1)
            {
                Random randGen = new Random();
                int randValue = randGen.Next(1, 101);
                if (randValue < 55)
                {
                    page = 2;
                }
                else
                {
                    page = 4;
                }
                
            }

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
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    SoundPlayer openingPlayer = new SoundPlayer(Properties.Resources.Opening___Title_Screen___Pokémon_Red_Green_Blue);
                    openingPlayer.Play();

                    imageBox.Image = (Properties.Resources.Pallet_Town_RBY);
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
                    option3Label.Visible = false;
                    option3Button.Visible = false;
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


                case 10:
                    outputLabel.Text = "You find yourself in Viridian forest.";
                    output2Label.Text = "What will you do in Viridian Forest?";
                    option1Label.Text = "Beat up the youngsters while procedurally working through the forest";
                    option2Label.Text = "Avoid battles, opting to walk through the grass";
                    break;
                case 11:
                    outputLabel.Text = "You beat all the trainers in the area. Bug Catchers are now an endangered species.";
                    output2Label.Text = "They're all begging for mercy. Do you spare them and their metapods?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 12:
                    outputLabel.Text = "You drain these poor bug catchers of their exp and pocket money. You're the strongest trainer in the forest and maybe even all of kanto but at what cost... Was it worth it?";
                    output2Label.Text = "Was it worth it?\n MERCILESS ENDING";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 13:
                    outputLabel.Text = "Uh oh. Its a level 100 Nidoking";
                    output2Label.Text = "Do you fight, and attempt to catch it, or run?";
                    option1Label.Text = "Fight";
                    option2Label.Text = "Run";
                    break;
                case 14:
                    outputLabel.Text = "You get one attack in and then Nidoking whips your {chosenStarter} and the rest of your team promptly.";
                    output2Label.Text = "What were you thinking???";
                    option1Label.Text = "uhmmm";
                    option2Label.Text = "uhhh";
                    break;
                case 15:
                    outputLabel.Text = "You make it out of the forest (not wholly the same person as you were before) and arrive at Pewter City.";
                    output2Label.Text = "What will you do in Pewter City?";
                    option1Label.Text = "talk to the team rocket member loitering";
                    option2Label.Text = "challenge the gym";
                    break;
                case 16:
                    outputLabel.Text = "She tries to convince you to join team rocket quite persuasively too. Good insurance benefits";
                    output2Label.Text = "Do you join Team Rocket?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "She lied?? theres no opportunity at team Rocket. You spend the rest if your life as a measly rocket grunt, never promoted";
                    output2Label.Text = "ROCKET ENDING";
                    option1Label.Text = " ";
                    option2Label.Text = " ";
                    break;
                case 18:
                    outputLabel.Text = "Your good sense and reason have brought you this far. You challenge Brock and win!";
                    output2Label.Text = "GYM LEADER ENDING";
                    option1Label.Text = " ";
                    option2Label.Text = " ";
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
