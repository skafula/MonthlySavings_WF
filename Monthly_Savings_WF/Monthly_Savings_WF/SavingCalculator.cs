using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Monthly_Savings_WF
{
    public class SavingCalculator
    {
        // Private fields

        #region Fields
        double _initialDeposit;
        double _monthlyDeposit;
        int _period;
        double _growth;
        double _fees;
        double _yearlyDeposit;
        #endregion

        // Methods to Set and Get the values

        #region Set and Get methods for private fields
        public void SetInitialDeposit(double value)
        {
            if (value > 0)
                _initialDeposit = value;
            else
                _initialDeposit = 0;
        }
        public double GetInitialDeposit()
        {
            return _initialDeposit; 
        }
        public void SetMonthlyDeposit(double value)
        {
            if (value > 0)
                _monthlyDeposit = value;
            else
                _monthlyDeposit = 0;
        }
        public double GetMonthlyDeposit()
        {
            return _monthlyDeposit;
        }
        public void SetPeriod(int value)
        {
            if (value > 0)
                _period = value;
            else 
                _period = 0;
        }
        public int GetPeriod()
        {
            return _period;
        }
        public void SetGrowth(double value)
        {
            if (value > 0)
                _growth = value * 0.01;
            else
                _growth = 0;
        }
        public double GetGrowth()
        {
            return _growth;
        }
        public void SetFees(double value)
        {
            if (value > 0)
                _fees = value * 0.01;
            else
                _fees = 0;
        }
        public double GetFees()
        {
            return _fees;
        }
        public void SetYearlyDeposit()
        {
            _yearlyDeposit = _monthlyDeposit * 12;
        }
        public double GetYearlyDeposit()
        {
            return _yearlyDeposit;
        }
        #endregion

        // Calculating results

        #region Calculations
        public double CalculateAmountPaid()
        {
            return _yearlyDeposit * _period;
        }
        public double CalculateTotalFees()
        {
            return CalculateAmountPaid() * _fees;
        }
        public double CalculateAmountEarned()
        {
            
            double result = _initialDeposit + _yearlyDeposit;
            for (int i = 0; i < _period; i++)
            {
                result += result * _growth;
            }
            if (_fees > 0)
                return result - CalculateTotalFees() - _yearlyDeposit - _initialDeposit;
            else
                return result - _initialDeposit - _yearlyDeposit;
        }
        public double CalculateFinalBalance()
        {
            return _initialDeposit + CalculateAmountEarned() + CalculateAmountPaid();
        }
        #endregion
    }
}
