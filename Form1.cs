using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KesselRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Button fakeButton = (Button) sender;
            ButtonSwitch(fakeButton.Name);
        }


        public void ButtonSwitch(string ButNum)

        {
            {
                switch (ButNum)
                {
                    case "btnStart":

                        break;
                    case "btnReset":
                        break;
                    case "btnWager":
                        break;
                    case "4":
                        break;
                }





            }



        }

    }
}
