using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KesselRun.Business;
using KesselRun.Business.AllPunters;
using System.Media;


namespace KesselRun
{
    public partial class Form1 : Form
    {
        public void Gameover()

        {
            SoundPlayer sn1Player = new SoundPlayer(Resource1.Game_over3);
            sn1Player.Play();

        }
        private BettingDetails bettingDetails = new BettingDetails();
        // Create my Ships
        Ships[] ships = new Ships[4];
        Punter[] myPunter = new Punter[4];
        Punter CurrantPunter = new Snoke();

        private int ShipWinner;
        public Form1()
        {
            InitializeComponent();
            LoadShips();
            LoadPunters();
            //PunterCash just loads the balance of cash each punter has
            PunterCash();



        }

        // this is a fake button and switch for all buttons
        #region Buttons & switch method

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Button fakeButton = (Button)sender;
            ButtonSwitch(fakeButton.Name);
        }
        public void ButtonSwitch(string ButNum)

        {
            {
                switch (ButNum)
                {
                    case "btnStart":
                        Parsec();
                        break;
                    case "btnReset":
                        ResetAll();
                        break;
                    case "btnWager":
                        Wager();
                        ShipNum();
                        break;
                    case "4":

                        break;
                }
            }
        }
        #endregion

        // this is a fake radio button and switch for all radio buttons
        #region Radio buttons & switch method

        private void RbWatto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton fakeRb = new RadioButton();
            fakeRb = (RadioButton)sender;


            if (fakeRb.Checked == true)

            {
                // look for the name of the person we have clicked on
                this.Name = fakeRb.Name;

                // pass the data across to currentPunter.
                switch (fakeRb.Name)
                {

                    case "RbCreedo":
                        CurrantPunter = myPunter[0];
                        // lblCreedoCash.Text = myPunter[0].Cash.ToString();
                        break;


                    case "RbJubba":
                        CurrantPunter = myPunter[1];
                        break;


                    case "RbSnoke":
                        CurrantPunter = myPunter[2];
                        break;
                    case "RbWatto":
                        CurrantPunter = myPunter[3];
                        break;

                }

                this.Name = CurrantPunter.PunterName + " is the currant Punter";
            }



            UdBet.Maximum = (decimal)CurrantPunter.Cash;



        }

        #endregion

        #region Methods & stuff



        // just gets the ship 
        private void Wager()
        {
            CurrantPunter.Bet = (float)UdBet.Value;
            lblWagerName.Text += CurrantPunter.PunterName + " Bets " + CurrantPunter.Bet + Environment.NewLine;
        }
        // This just puts the value of Cash each Punter has on the form
        private void PunterCash()
        {
            lblCreedoCash.Text = myPunter[0].Cash.ToString();
            lblJubbaCash.Text = myPunter[1].Cash.ToString();
            lblSnokeCash.Text = myPunter[2].Cash.ToString();
            lblWattoCash.Text = myPunter[3].Cash.ToString();
        }


        // this checks at end of game if plays have no cash and if so, turns off their radio button and cash text box
        private void CashCheck()
        {    // this IF statement does a comparison to see if punter "0" has zero cash
            if (myPunter[0].Cash == 0)
            {   // tures off radio button
                RbCreedo.Enabled = false;
                // prints text Busted to this players cash label 
                lblCreedoCash.Text += "  Busted";
                // turns off the cash label 
                lblCreedoCash.Enabled = false;
                // changes the value in the List  "AllBusted" to false, for this player that is element "0"
                bettingDetails.AllBusted[0] = false;
            }
            if (myPunter[1].Cash == 0)
            {
                RbJubba.Enabled = false;
                lblJubbaCash.Text += "  Busted";
                lblJubbaCash.Enabled = false;
                bettingDetails.AllBusted[1] = false;
            }
            if (myPunter[2].Cash == 0)
            {
                RbSnoke.Enabled = false;
                lblSnokeCash.Text += "  Busted";
                lblSnokeCash.Enabled = false;
                bettingDetails.AllBusted[2] = false;
            }
            if (myPunter[3].Cash == 0)
            {
                RbWatto.Enabled = false;
                lblWattoCash.Text += "  Busted";
                lblWattoCash.Enabled = false;
                bettingDetails.AllBusted[3] = false;

            }
        }

        // updates how much cash each player has
        private void PunterCashUpdate()

        {

            lblCreedoCash.Text = myPunter[0].Cash.ToString();

            lblJubbaCash.Text = myPunter[1].Cash.ToString();

            lblSnokeCash.Text = myPunter[2].Cash.ToString();
            lblWattoCash.Text = myPunter[3].Cash.ToString();
            if (myPunter[0].Cash == 0) RbCreedo.Enabled = false;
            if (myPunter[1].Cash == 0) RbJubba.Enabled = false;
            if (myPunter[2].Cash == 0) RbSnoke.Enabled = false;
            if (myPunter[3].Cash == 0) RbWatto.Enabled = false;



        }
        // if no player has cash Game over
        private void EndGame()
        {

            if (BettingDetails.End == false)
            {

                splitContainer1.Panel1.BackgroundImage = (Resource1.end2);
                splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Tile;
                Gameover();



            }

        }



        // just connects ship number to ship name 
        private void ShipNum()
        {
            CurrantPunter.Ships = (int)UdShip.Value;
            lblWagerName.Text += CurrantPunter.PunterName + " Ship " + ships[CurrantPunter.Ships].Name + Environment.NewLine;



        }
        private void ResetAll()

        {
            this.Text = "";
            // resets the left to 10 for the race 
            for (int i = 0; i < 4; i++)
            {
                ships[i].myPB.Left = 10;
            }

            PunterCash();
            lblWagerName.Text = "";
            lblWinner.Text = "";

        }

        // loads all the punters with a for loop, using the Factory Class and the GetAPunter Switch statement 
        private void LoadPunters()

        {
            for (int i = 0; i < 4; i++)
            {
                myPunter[i] = Factory.GetAPunter(i);
                myPunter[i].LabelWinner = lblWinner;
            }


        }
        // this loads the ships name and image, I have hard coded the ship image to each picture box, but it would be just as ease to use something like, monster[0].myPB.BackgroundImage = Resource1.Agor;
        private void LoadShips()
        {
            ships[0] = new Ships { Lenght = 0, myPB = Pb1, Name = "Falcon" };
            // monster[0].myPB.BackgroundImage = Resource1.Agor;
            ships[1] = new Ships { Lenght = 0, myPB = Pb2, Name = "Scimitar" };
            ships[2] = new Ships { Lenght = 0, myPB = Pb3, Name = "Slave 1" };
            ships[3] = new Ships { Lenght = 0, myPB = Pb4, Name = "Rage" };

            //   string winner = ships[0].Name;
        }
        #endregion
        #region Win and Lose 
        // this is the heart of the program , it just loops through adding a random number to the back of each Picture box and checks if one has gotten to the end
        // as well as  runs the Bet check method. 
        private void Parsec()
        {
            // while we haven't reached the end then keep looping
            bool end = false;
            // create a random number generator
            Random myRand = new Random();
            Random myrandstop = new Random();
            while (end != true)

            {
                for (int i = 0; i < 4; i++)

                {
                    ships[i].myPB.Left += myRand.Next(1, 15);
                    //50% of the time it takes 8 off the left which makes it go back
                    if (myrandstop.Next(1, 3) == 2)
                    {
                        ships[i].myPB.Left -= 1;
                    }
                    // if the monster reaches the end of the form 
                    if (ships[i].myPB.Left > Form1.ActiveForm.Width - ships[i].myPB.Width - 20)
                    {
                        end = true; // loop until end = true
                        this.Text = ships[i].Name + " the Ship has won";
                        // this is the ship that won
                        ShipWinner = i;



                    }



                }

            }


            BetCheck();
        }
        // Just another Loop , checks if any player has bet on the winning ship, if so it adds to the player cash, if not it deducts form player cash
        // if any player has no cash it all so shows busted, and if all busted runs the ENDGame method.
        #endregion
        private void BetCheck()
        {
            for (int i = 0; i < 4; i++)
            {
                if (myPunter[i].Ships == ShipWinner)// the ship the punter bet on
                {
                    myPunter[i].Cash += myPunter[i].Bet;
                    lblWinner.Text = myPunter[i].PunterName + "  " + myPunter[i].Cash;

                    // myPunter[i].LabelWinner = lblWinner;

                }
                else
                {
                    myPunter[i].Cash -= myPunter[i].Bet;
                }

                PunterCashUpdate();
                CashCheck();
                bettingDetails.CheckDead(bettingDetails.AllBusted);

                EndGame();
                // update Punter Cash
                //myPunter[i] = Factory.GetAPunter(i);
                //myPunter[i].LabelWinner = lblWinner;

            }
        }
        // just shows who , how much and what ship bet on.
        private void LblWagerName_Click(object sender, EventArgs e)
        {

        }
    }
}
