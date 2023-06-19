using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monthly_Savings_WF
{
    public partial class MainForm : Form
    {
        SavingCalculator savingCalc = new SavingCalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        // Build up starting screen with empty fields
        public void InitializeGUI()
        {
            tbFees.Text = string.Empty;
            tbGrowth.Text = string.Empty;  
            tbInitialDepo.Text = string.Empty;
            tbMonthlyDepo.Text = string.Empty;
            tbPeriod.Text = string.Empty;

            lblEarned.Text = string.Empty;
            lblFinalBalance.Text = string.Empty;
            lblPaid.Text = string.Empty;
            lblTotalFees.Text = string.Empty;

            savingCalc.SetInitialDeposit(0);
            savingCalc.SetFees(0);
        }
        
        // Set output results to display -> ___Formatting doesnt work)

        private void DisplayResults()
        {
            lblPaid.Text = /*string.Format("{0:N2}", */savingCalc.CalculateAmountPaid().ToString()/*)*/;
            lblEarned.Text = savingCalc.CalculateAmountEarned().ToString();
            lblTotalFees.Text = savingCalc.CalculateTotalFees().ToString();
            lblFinalBalance.Text = savingCalc.CalculateFinalBalance().ToString();
        }

        // Reading and setting up input data and checking its value (returning bool)

        #region ReadingMethods
        private bool ReadInitialDeposit()
        {
            if (double.TryParse(tbInitialDepo.Text, out double d))
            {
                savingCalc.SetInitialDeposit(d);
                return true;
            }
            else
                return false;
        }
        private bool ReadMonthlyDeposit()
        {
            if (double.TryParse(tbMonthlyDepo.Text, out double d))
            {
                savingCalc.SetMonthlyDeposit(d);
                savingCalc.SetYearlyDeposit();
                return true;
            }
            else
                return false;
        }
        private bool ReadPeriod()
        {
            if (int.TryParse(tbPeriod.Text, out int d))
            {
                savingCalc.SetPeriod(d);
                return true;
            }
            else return false;
        }
        private bool ReadInterest()
        {
            if (double.TryParse(tbGrowth.Text, out double d))
            {
                savingCalc.SetGrowth(d);
                return true;
            }
            else
                return false;
        }
        private bool ReadFees()
        {
            if (double.TryParse(tbFees.Text, out double d))
            {
                savingCalc.SetFees(d);
                return true;
            }
            else
                return false;
        }
        #endregion

        // Bool to check if inputdata is OK

        private bool IsInputOk()
        {
            if (ReadPeriod() && ReadInterest() && ReadFees() && ReadInitialDeposit() && ReadMonthlyDeposit())
                return true;
            else
                return false;
        }

        // EventMethods

        private void btnCalculateSaving_Click(object sender, EventArgs e)
        {
            bool ok = IsInputOk();
            if (ok)
            {
                DisplayResults();
            }
            else
                MessageBox.Show("Hibás, vagy hiányzó érték!");
        }
    }
}
