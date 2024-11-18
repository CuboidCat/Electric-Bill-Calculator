using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CIT125_P3C
{
    public partial class Form1 : Form
    {
        //Declaring Variables


        //ErrorHandling
        //negativeNumber input error
        Boolean negativeNumber = false;
        Boolean errorThrown=false;
        string errorTxt = string.Empty;

        //total numbers
        double totalKWH = 0;
        double totalKWHDiscount = 0;
        double KWHCharge = 0;
        double totalDue = 0;
        double extraCharges = 0;

        //User input
        //Meter Aray
        double[,] meterInfo = new double[3, 3];
        double meter1 = 0;
        double meter2 = 0;
        double meter3 = 0;

        //rehab
        Boolean rehab = false;
        double rehabDiscount = 0;

        double priorBalance = 0;

        int meterCount = 0;

        public Form1()
        {
            InitializeComponent();
        }


        //Form management
        private void clearLables()
        {
            clearKWHLables();

            //Reset all lables coresponding to the total cost.
            chkBoxApptChg.Checked = false;
            chkBoxAfterHoursChg.Checked = false;


            lblAfterHoursResult.Text = "$0.00";
            lblMissedApptResult.Text = "$0.00";
            clearTotalLables();


        }

        private void clearKWHLables()
        {
            //Reset lables for each meter's used kwh
            lblMeter1KWHUsed.Text = "0.00";
            lblMeter2KWHUsed.Text = "0.00";
            lblMeter3KWHUsed.Text = "0.00";


            //Reset total KWH used
            lblTotalKWHResult.Text = "0";
        }

        private void clearTotalLables()
        {
            lblKWHChargeResult.Text = "$0.00";
            lblMeterChargeResult.Text = "$0.00";
            lblTotalResult.Text = "$0.00";
        }
        private void clearTextBoxes()
        {
            clearMeterKWHTextBoxes();
            clearPriorBalanceTextBox();
            clearMeterTextBox();
        }

        private void clearMeterKWHTextBoxes()
        {
            //Text Boxes
            txtbxMeter1Start.Text = "0";
            txtbxMeter2Start.Text = "0";
            txtbxMeter3Start.Text = "0";
            txtbxMeter1End.Text = "0";
            txtbxMeter2End.Text = "0";
            txtbxMeter3End.Text = "0";
        }

        private void clearPriorBalanceTextBox()
        {
            txtbxPriorBalance.Text = "0";
        }

        private void clearMeterTextBox()
        {
            txtbxMeterCount.Text = "0";
        }

        private void clearError()
        {
            lblError.Text = String.Empty;
            errorTxt = String.Empty;
            errorThrown = false;
            negativeNumber = false;
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.BackColor = Color.White;
                }
            }
        }

        //Error Managment
        private void throwError(string error)
        {
            errorThrown = true;
            if (errorTxt == string.Empty) {
                errorTxt += error; 
            }
            else
            {
                errorTxt += "\n\n" + error;
            }
        }
        private void requiredValue(TextBox textbox, string requiredElement)
        {
            throwError(requiredElement + " is required");
            textbox.BackColor = Color.LightYellow;
        }
        private void updateErrorLable()
        {
            if (negativeNumber)
            {
                errorTxt += "Excluding the prior balance field,\nplease enter positive values only.\n\n";
            }
            lblError.Text = errorTxt;
        }
       
        
        
        
        //Methods to set various lables in the program

        private void setAfterHours(Double amount)
        {
            lblAfterHoursResult.Text = amount.ToString("C");
        }
        private void setMissedAppt(Double amount)
        {
            lblMissedApptResult.Text = amount.ToString("C");
        }
        private void setMeterCharge(int meterCount)
        {
            int meterCharge = meterCount * 25;
            extraCharges += meterCharge;
            lblMeterChargeResult.Text = meterCharge.ToString("C");

        }
        private void setKWHCharge()
        {
            lblKWHChargeResult.Text = KWHCharge.ToString("C");
        }
        private void setKWHTotal(Double totalKWW)
        {
            lblTotalKWHResult.Text = totalKWW.ToString("0");
        }

        private void setKWHUsed()
        {
            lblMeter1KWHUsed.Text = meter1.ToString("0.00");

            lblMeter2KWHUsed.Text = meter2.ToString("0.00");

            lblMeter3KWHUsed.Text = meter3.ToString("0.00");
        }

        private void setRehabLable()
        {
            lblRehabDiscountResult.Text = rehabDiscount.ToString("C");
        }


        private void setTotal(Double total)
        {
            lblTotalResult.Text = total.ToString("C");
        }



        //Data Access


        //Fill in the meter array with info from the meter start/end text boxes
        private Boolean getMeterInfo()
        {

            Boolean converted = (

                Double.TryParse(txtbxMeter1Start.Text, out meterInfo[0, 0]) &&
                Double.TryParse(txtbxMeter1End.Text, out meterInfo[0, 1]) &&
                Double.TryParse(txtbxMeter2Start.Text, out meterInfo[1, 0]) &&
                Double.TryParse(txtbxMeter2End.Text, out meterInfo[1, 1]) &&
                Double.TryParse(txtbxMeter3Start.Text, out meterInfo[2, 0]) &&
                Double.TryParse(txtbxMeter3End.Text, out meterInfo[2, 1])
                );

            if (txtbxMeter1Start.Text.Equals(String.Empty))
            {
                requiredValue(txtbxMeter1Start, "Meter 1 Starting");
                converted = false;
            }
            if (txtbxMeter1End.Text.Equals(String.Empty))
            {
                requiredValue(txtbxMeter1End, "Meter 2 Ending");
                converted = false;
            }

            if (txtbxMeter1Start.Text != String.Empty && txtbxMeter1End.Text != String.Empty)
            {
                converted = true;
            }

            for (int i = 0; i < 3; i++) { 
                for (int j = 0; j < 3; j++)
                    {
                    if (meterInfo[i,j] < 0)
                    {
                        negativeNumber = true;
                        break;
                    }
                }
            }


            return converted;
        }


        private Boolean getMeterCount()
        {
          
            Boolean converted = int.TryParse(txtbxMeterCount.Text, out meterCount);
            if (converted)
            {
                if (meterCount < 0)
                {
                    converted = false;
                    negativeNumber = true;
                }
            }
            if (!converted)
            {
                if (txtbxMeterCount.Text.Equals(String.Empty))
                {
                    requiredValue(txtbxMeterCount, "Meter Count");
                }
            }

            return converted;
        }

        private Boolean getPriorBalance()
        {
            Boolean converted = false;
            converted = Double.TryParse(txtbxPriorBalance.Text, out priorBalance);

            if (!converted)
            {
                if (txtbxPriorBalance.Text.Equals(String.Empty))
                {
                    requiredValue(txtbxPriorBalance, "Prior Balance");
                }
            }
            return converted;
        }



        //Variable Management
        private void clearVariables()
        {
            //total numbers
            totalKWH = 0;
            KWHCharge = 0;
            meter1 = 0;
            meter2 = 0;
            meter3 = 0;
            totalDue = 0;

            //User input
            meterInfo = new double[3, 3];


            priorBalance = 0;

            meterCount = 0;
        }












        //Main Calculations

        //Use the difference of the values in the meterInfo Array to determine the totalKWH
        private void determineTotalKWH()
        {



            meter1 = (meterInfo[0, 1] - meterInfo[0, 0]);
            meter1 = calculateRollOver(meterInfo[0, 1], meterInfo[0, 0]);
            calculateKWHCharge(meter1);
            meter2 = (meterInfo[1, 1] - meterInfo[1, 0]);
            meter2 = calculateRollOver(meterInfo[1,1], meterInfo[1,0]);
            calculateKWHCharge(meter2);

            meter3 = (meterInfo[2, 1] - meterInfo[2, 0]);
            meter3 = calculateRollOver(meterInfo[2, 1], meterInfo[2, 0]);
            calculateKWHCharge(meter3);


            totalKWH = meter1 + meter2 + meter3;
        }
        private double calculateRollOver(double meterEnd, double meterStart)
        {
            if ((meterEnd-meterStart) >= 0) { return meterEnd - meterStart; }

            return (9999 - meterStart) + meterEnd +1;
        }


        private double calculateKWHCharge(double meter)
        {
            if (meter <= 7000) {
                KWHCharge += meter * 0.082;

            }
            else if (meter <= 9000)
            {
                totalKWHDiscount += (meter - 7000) * 0.077;
                KWHCharge += (7000 * 0.082) + totalKWHDiscount;
            }
            else
            {
                double overNineThousandDiscount = (meter - 9000) * 0.07685;
                totalKWHDiscount += overNineThousandDiscount + (1999 * 0.077);
                KWHCharge += overNineThousandDiscount + (1999 * 0.077) + (7000 * 0.082);
            }
            return totalKWHDiscount;
        }
        private void calculateTotal()
        {
            totalDue = (KWHCharge) + (meterCount * 25) + priorBalance + extraCharges;
        }

        //Rehab
        private void calculateRehab()
        {
            if (!rehab)
            {
                return;
            }
            if (extraCharges <= 55)
            {
                return;
            }

            rehabDiscount = extraCharges - 55;
            extraCharges = 55;

        }


        //Events

        private void Form1_Load(object sender, EventArgs e)
        {
            clearLables();
            clearVariables();
            clearError();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearLables();
            clearVariables();
            clearTextBoxes();
            clearError();
        }



        private void btnReCalc_Click(object sender, EventArgs e)
        {
            //clear lables
            clearError();
            clearVariables();

            //Set the KWH variables using the info in the meter start/end text boxes
            Boolean meterDataAccepted = getMeterInfo();
            if (!meterDataAccepted)
            {
                throwError("Meter data invalid.");
                clearMeterKWHTextBoxes();
                clearKWHLables();
                clearTotalLables();
            }
            else { /*no else */ }

            //Set meterCount variable to input in text box
            Boolean meterCountAccepted = getMeterCount();
            if (!meterCountAccepted)
            {
                throwError("Meter count invalid.");
                clearMeterTextBox();
                clearTotalLables();
            }
            else { /*no else */ }

            //Set priorBalance variable to input in text box
            Boolean priorBalanceAccepted = getPriorBalance();
            if (!priorBalanceAccepted)
            {
                throwError("Prior balance invalid");
                clearPriorBalanceTextBox();
                clearTotalLables();
            }
            else { /*no else*/}
            updateErrorLable();
            //Do not display total if there are errors.
            if (errorThrown || negativeNumber) {
                updateErrorLable();
                return; 
            }

            //Calculations for KWH
            determineTotalKWH();

            setKWHUsed();
            setKWHCharge();
            setKWHTotal(totalKWH);

            //Meter calculations
            setMeterCharge(meterCount);

            //Rehab calculations
            calculateRehab();
            setRehabLable();

            //Calculate total
            calculateTotal();
            setTotal(totalDue);

        }

        private void chkBoxAfterHoursChg_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAfterHoursChg.Checked)
            {
                extraCharges += 50;
                setAfterHours(50);
            }
            else
            {
                extraCharges -= 50;
                setAfterHours(0);
            }

        }

        private void chkBoxApptChg_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxApptChg.Checked)
            {
                extraCharges += 25;
                setMissedAppt(25);
            }
            else
            {
                extraCharges -= 25;
                setMissedAppt(0);
            }
        }

        private void RadioRehabYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxApptChg.Checked)
            {
                rehab = true;
            }
            else
            {
                rehab = false;
            }
        }

        private void RadioRehabNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxApptChg.Checked)
            {
                rehab = false;
            }
            else
            {
                rehab = true;
            }
        }
    }
}
