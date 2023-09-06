using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_1_B
{
    public partial class frmNumbersCalculations : Form
    {
        //Declare and Initialize constant fields.
        private const int DICE_1 = 1;
        private const int DICE_2 = 2;
        private const int DICE_3 = 3;
        private const int DICE_4 = 4;

        //Declare and initialize field variables to hold the total value. 
        private int total_value = 0;
        private int total_clickcount = 0;
        private int local_click1 = 0;
        private int local_click2 = 0;
        private int local_click3 = 0;
        private int local_click4 = 0;

        public frmNumbersCalculations()
        {
            InitializeComponent();
        }

        private void pbxDice1_Click(object sender, EventArgs e)
        {
            //Declare and initialize constant fields for counting clicks. 
            const int DICE1_click = 1; 

            //Add local click1 count and display in proper Dice 1 label. 
            local_click1 += DICE1_click;
            lblDice1Count.Text = local_click1.ToString();

            //Add total number of clicks to total click count variable. 
            total_clickcount += DICE1_click;
            //Display the total click count in the final click count label. 
            lblActualTotalCount.Text = total_clickcount.ToString();

            //Add value of Dice 1 to the total value of all dice being clicked (total number of pips). 
            total_value += DICE_1;
            //Display this total dice value (total pips) in proper label, formatted as an int.
            lblActualTotalValue.Text = total_value.ToString();

        }

        private void pbsDice2_Click(object sender, EventArgs e)
        {
            //Declare and initialize constant fields for counting clicks. 
            const int DICE2_click = 1;

            //Add local click1 count and display in proper Dice 1 label.
            local_click2 += DICE2_click;
            lblDice2Count.Text = local_click2.ToString();

            //Add total number of clicks to total click count variable. 
            total_clickcount += DICE2_click;
            //Display the total click count in the final click count label. 
            lblActualTotalCount.Text = total_clickcount.ToString();

            //Add value of Dice 1 to the total value of all dice being clicked (total number of pips). 
            total_value += DICE_2;
            //Display this total dice value (total pips) in proper label, formatted as an int. 
            lblActualTotalValue.Text = total_value.ToString();
        }

        private void pbxDice3_Click(object sender, EventArgs e)
        {
            //Declare and initialize constant fields for counting clicks. 
            const int DICE3_click = 1;

            //Add local click1 count and display in proper Dice 1 label.
            local_click3 += DICE3_click;
            lblDice3Count.Text = local_click3.ToString();

            //Add total number of clicks to total click count variable. 
            total_clickcount += DICE3_click;
            //Display the total click count in the final click count label. 
            lblActualTotalCount.Text = total_clickcount.ToString();

            //Add value of Dice 1 to the total value of all dice being clicked (total number of pips). 
            total_value += DICE_3;
            //Display this total dice value (total pips) in proper label, formatted as an int. 
            lblActualTotalValue.Text = total_value.ToString();


        }

        private void pbxDice4_Click(object sender, EventArgs e)
        {
            //Declare and initialize constant fields for counting clicks. 
            const int DICE4_click = 1;

            //Add local click1 count and display in proper Dice 1 label.
            local_click4 += DICE4_click;
            lblDice4Count.Text = local_click4.ToString();

            //Add total number of clicks to total click count variable. 
            total_clickcount += DICE4_click;
            //Display the total click count in the final click count label. 
            lblActualTotalCount.Text = total_clickcount.ToString();

            //Add value of Dice 1 to the total value of all dice being clicked (total number of pips). 
            total_value += DICE_4;
            //Display this total dice value (total pips) in proper label, formatted as an int. 
            lblActualTotalValue.Text = total_value.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clears all labels that contain text. 
            lblDice1Count.Text = "";
            lblDice2Count.Text = "";
            lblDice3Count.Text = "";
            lblDice4Count.Text = "";
            lblActualTotalValue.Text = "";
            lblActualTotalCount.Text = "";
            total_value = 0;
            total_clickcount = 0;
            local_click1 = 0;
            local_click2 = 0;
            local_click3 = 0;
            local_click4 = 0;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the form entirely. 
            this.Close();
        }
    }
}
