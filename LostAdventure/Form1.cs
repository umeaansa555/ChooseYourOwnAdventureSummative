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
        SoundPlayer pressPlayer = new SoundPlayer(Properties.Resources.SFX_PRESS_AB);
        

        public Form1()
        {
            InitializeComponent();

            // Display initial message and options
            outputLabel.Text = "It's time you become a trainer. Your mom kicks you out";
            output2Label.Text = "Where will you go?";
            option1Label.Text = "Straight into the grass. No pokeballs. (45 % success)";
            option2Label.Text = "Oak's house";
            option3Label.Visible = false;
            option3Button.Visible = false;

            SoundPlayer openingPlayer = new SoundPlayer(Properties.Resources.Opening___Title_Screen___Pokémon_Red_Green_Blue);
            openingPlayer.Play();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            pressPlayer.Play();

            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1


            if (page == 1)
            {
                Random randGen = new Random();
                int randValue = randGen.Next(1, 101);
                if (randValue < 45)
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
            else if (page == 6) { page = 8; }
            else if (page == 7) { page = 9; }
            else if (page == 8) { page = 98; }
            else if (page == 9) { page = 99; }

            else if (page == 10) { page = 11; }
            else if (page == 11) { page = 12; }
            else if (page == 12) { page = 97; }
            else if (page == 13) { page = 14; }
            else if (page == 14) { page = 99; }
            else if (page == 15) { page = 16; }
            else if (page == 16) { page = 17; }
            else if (page == 17) { page = 97; }
            else if (page == 18) { page = 98; }




            else if (page == 99) { page = 1; }
            else if (page == 98) { page = 1; }
            else if (page == 97) { page = 1; }


            /// Display text and game options to screen based on the 
            /// current page

            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            pressPlayer.Play();

            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2

            if (page == 1) { page = 3; }
            else if (page == 2) { page = 99; }
            else if (page == 3) { page = 5; }
            else if (page == 4) { page = 7; }
            else if (page == 5) { page = 7; }
            else if (page == 6) { page = 5; }
            else if (page == 7) { page = 5; }
            else if (page == 8) { page = 98; }
            else if (page == 9) { page = 99; }

            else if (page == 10) { page = 13; }
            else if (page == 11) { page = 15; }
            else if (page == 12) { page = 97; }

            else if (page == 13)
            {
                Random randGen2 = new Random();
                int randValue2 = randGen2.Next(1, 101);
                if (randValue2 < 90)
                {
                    page = 15;
                }
                else
                {
                    page = 99;
                }

            }

            else if (page == 14) { page = 99; }
            else if (page == 15) { page = 18; }
            else if (page == 16) { page = 15; }
            else if (page == 17) { page = 97; }
            else if (page == 18) { page = 98; }

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
            pressPlayer.Play();

            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2

            if (page == 3) {page = 5; }
            else if (page == 4) { page = 10; }
            else if (page == 5) { page = 10; }


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
                    option1Label.Text = "Straight into the grass. No pokeballs. (45 % success)";
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
                    output2Label.Text = "IDIOT ENDING";
                    option1Label.Text = "Yeah, that was stupid";
                    option2Label.Text = "...";
                    imageBox.Image = Properties.Resources.Spr_RG_Red_1;
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
                    imageBox.Image = Properties.Resources.Professor_Oak_Lab_inside_RB;
                    break;
                case 4:
                    // Display page message and options
                    outputLabel.Text = "Beating the odds, you made it through to Viridian City!";
                    output2Label.Text = "What will you do in Viridian City?";
                    option1Label.Text = "Talk to the local elderly men";
                    option2Label.Text = "Challenge the gym (difficult)";
                    option3Label.Text = "Move on to the next city (better fit for your level)";
                    option3Label.Visible = true;
                    option3Button.Visible = true;
                    imageBox.Image = Properties.Resources.Viridian_City_RBY;
                    break;
                case 5:
                    // Display page message and options
                    outputLabel.Text = "You're in the heart of Viridian now. What's your next move?";
                    output2Label.Text = "What will you do in Viridian City?";
                    option1Label.Text = "Talk to the local elderly men";
                    option2Label.Text = "Challenge the gym (difficult)";
                    option3Label.Text = "Move on to the next city (better fit for your level)";
                    option3Label.Visible = true;
                    option3Button.Visible = true;
                    imageBox.Image = Properties.Resources.Viridian_City_RBY;
                    break;
                case 6:
                    // Display page message and options
                    outputLabel.Text = "He tells you shiftily that he knows a place in Celadon where you can get rich (quick!), and that he's going there soon and can take you.";
                    output2Label.Text = "Do you go to Celadon City with him? ***(OLD MAN)***";
                    option1Label.Text = "Yea lol";
                    option2Label.Text = "No way? Dude";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    imageBox.Image = Properties.Resources.Oldman2;

                    break;
                case 7:
                    // Display page message and options
                    outputLabel.Text = "It's much higher than your current skill level. The gym leader is also an infamous gang boss. Do you still challenge Giovanni?";
                    output2Label.Text = "Do you still want to challenge the gym?";
                    option1Label.Text = "I can take him";
                    option2Label.Text = "What? No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    imageBox.Image = Properties.Resources.d11b9fce62be74ec16023d75d22eda79ffdd6680r1_320_320v2_00;
                    break;
                case 8:
                    outputLabel.Text = "You get rich as promised and completely forget about your old life. You can't remember why you ever wanted to be a pokemon trainer at all. Play again?";
                    output2Label.Text = "OLD MAN ENDING";
                    option1Label.Text = "By the way, this game does not reflect my values";
                    option2Label.Text = "Don't try this in real life.";
                    imageBox.Image = Properties.Resources.Celadon_Game_Corner_RBY;
                    SoundPlayer casinoPlayer = new SoundPlayer(Properties.Resources.Pokemon_Blue_Red___Team_Rocket_Game_Corner);
                    casinoPlayer.Play();
                    break;
                case 9:
                    outputLabel.Text = "Your sad level 9 team gets swept. Don't know what you expected.";
                    output2Label.Text = "NOOB ENDING";
                    option1Label.Text = ":(";
                    option2Label.Text = ":(";
                    imageBox.Image = (Properties.Resources.Spr_RG_Red_1);
                    break;


                case 10:
                    outputLabel.Text = "You find yourself in Viridian forest.";
                    output2Label.Text = "What will you do in Viridian Forest?";
                    option1Label.Text = "Beat up all the youngsters, coldly and methodically";
                    option2Label.Text = "Avoid battles, opting to walk through the grass";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    imageBox.Image = Properties.Resources.Viridian_Forest_RBY;
                    break;
                case 11:
                    outputLabel.Text = "You beat all the trainers in the area. Bug Catchers are now an endangered species.";
                    output2Label.Text = "They're all begging for mercy. Do you spare them and their metapods?";
                    option1Label.Text = "No mercy.";
                    option2Label.Text = "Yes mercy?!";
                    break;
                case 12:
                    outputLabel.Text = "You drain these poor bug catchers of their exp and pocket money. You're the strongest trainer in the forest and maybe even all of Kanto but at what cost...\nWas it worth it?";
                    output2Label.Text = "MERCILESS ENDING";
                    option1Label.Text = "...";
                    option2Label.ForeColor = Color.Red;
                    option2Label.Text = "...";
                    break;
                case 13:
                    outputLabel.Text = "Uh oh. It's a level 100 Nidoking. Wyd";
                    output2Label.Text = "Do you fight, and attempt to catch it, or run?";
                    option1Label.Text = "Fight";
                    option2Label.Text = "Run";
                    break;
                case 14:
                    // the variable isn't meant to work i threw it in as a joke
                    outputLabel.Text = "You get one attack in and then Nidoking whips your {chosenStarter} and the rest of your team promptly.";
                    output2Label.Text = "What were you thinking???\nFAIL ENDING";
                    option1Label.Text = "Ummm";
                    option2Label.Text = "Uhhh";
                    break;
                case 15:
                    outputLabel.Text = "You make it out of the forest (not wholly the same person as you were before) and arrive at Pewter City.";
                    output2Label.Text = "What will you do in Pewter City?";
                    option1Label.Text = "Talk to the team rocket member loitering";
                    option2Label.Text = "Challenge the gym (Brock)";
                    break;
                case 16:
                    outputLabel.Text = "She tries to convince you to join team rocket quite persuasively too. Good insurance benefits";
                    output2Label.Text = "Do you join Team Rocket?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "She lied?? There's no opportunity at Team Rocket. You spend the rest if your life as a measly rocket grunt, never promoted";
                    output2Label.Text = "ROCKET ENDING";
                    option1Label.Text = "Shoot";
                    option2Label.Text = "Darn";
                    break;
                case 18:
                    outputLabel.Text = "Your good sense and reason have brought you this far. You challenge Brock and win!";
                    output2Label.Text = "GYM LEADER ENDING";
                    option1Label.Text = "Awesome!";
                    option2Label.Text = "Nice!";
                    imageBox.Image = Properties.Resources.Pewter_Gym_RBY;
                    break;

                case 99:
                    // Display page message and options
                    outputLabel.Text = "You black out and wake up at a Pokemon Center. Get up and try again!";
                    output2Label.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    SoundPlayer healPlayer = new SoundPlayer(Properties.Resources.Pokemon_Red_Blue_Yellow_Music___Pokemon_Recovery);
                    healPlayer.Play();
                    break;

                case 98:
                    outputLabel.Text = "You Win! Try to find the other endings ;)";
                    output2Label.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    SoundPlayer winPlayer = new SoundPlayer(Properties.Resources.SFX_GET_KEY_ITEM);
                    winPlayer.Play();
                    break;
                case 97:
                    outputLabel.Text = "You.. Win? But that's not the true ending! Keep playing to find them all ;)\nHint: There's 7";
                    output2Label.Text = "Play again?";
                    option1Label.ForeColor = Color.Black;
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    SoundPlayer losePlayer = new SoundPlayer(Properties.Resources.SFX_GET_ITEM_2);
                    losePlayer.Play();
                    break;
                case 96:
                    outputLabel.Text = "Thanks for playing :)";
                    output2Label.Text = "";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                        SoundPlayer endPlayer = new SoundPlayer(Properties.Resources.SFX_TURN_OFF_PC);
                        endPlayer.Play();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
