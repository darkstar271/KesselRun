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

namespace KesselRun
{
    public partial class Form1 : Form
    {
        // Create my Ships
        Ships[] ships = new Ships[4];
        Punter[] myPunter = new Punter[4];
        Punter CurrantPunter = new Snoke();
        public Form1()
        {
            InitializeComponent();
            LoadPunters();
            LoadShips();
        }

        #region Radio & Button Switch
        // this is a fake button and switch for all buttons
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
                        // HyperSpace();
                        break;
                    case "btnReset":
                        ResetAll();
                        break;
                    case "btnWager":

                        Wager();
                        break;
                    case "4":
                        break;
                }
            }
        }

        // this is a fake radio button and switch for all radio buttons
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

        private void Wager()
        {
            CurrantPunter.Bet = (float)UdBet.Value;
            lblWagerName.Text += CurrantPunter.PunterName + " Bets" + CurrantPunter.Bet + Environment.NewLine;
        }

        private void ResetAll()

        {
            this.Text = "";
            // resets the left to 10 for the race 
            for (int i = 0; i < 4; i++)
            {
                ships[i].myPB.Left = 10;
            }


        }

        private void LoadPunters()

        {
            for (int i = 0; i < 4; i++)
            {
                myPunter[i] = Factory.GetAPunter(i);
                //   myPunter[i].LabelWinner =  lblWinner;
            }


        }

        private void LoadShips()
        {
            ships[0] = new Ships { Lenght = 0, myPB = Pb1, Name = "Falcon" };
            // monster[0].myPB.BackgroundImage = Resource1.Agor;
            ships[1] = new Ships { Lenght = 0, myPB = Pb2, Name = "Scimitar" };
            ships[2] = new Ships { Lenght = 0, myPB = Pb3, Name = "Slave 1" };
            ships[3] = new Ships { Lenght = 0, myPB = Pb4, Name = "Rage" };
        }
    }
}
