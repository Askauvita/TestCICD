using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCalculator
{
    public partial class BankCalculator : Form
    {
        public BankCalculator()
        {
            InitializeComponent();
        }

        static void DiffCredit(double sum, int months, double rate, out double[] sumBefore,
            out double[] sumAfter, out double[] AfterPay, out double[] payments, out double overpayment)
        {
            rate /= 12;
            sumBefore = new double[months];
            sumAfter = new double[months];
            AfterPay = new double[months];
            payments = new double[months];
            overpayment = 0;

            rate += 1;

            for (int i = 0; i < months; i++)
            {
                sumBefore[i] = i == 0 ? sum : AfterPay[i - 1];
                sumAfter[i] = Math.Round(sumBefore[i] * rate, 2);
                AfterPay[i] = Math.Round(sum * (months - 1 - i) / months, 2);
                payments[i] = Math.Round(sumAfter[i] - AfterPay[i], 2);

                overpayment += payments[i];
            }

            overpayment -= sum;
        }

        static void AnnCredit(int sum, int months, double rate,
            out double[] sumBefore, out double[] sumAfter, out double[] AfterPay, out double payment, out double overpayment)
        {
            rate /= 12;
            rate += 1;
            double rateSum = 1;
            double newRate = rate;

            sumBefore = new double[months];
            sumAfter = new double[months];
            AfterPay = new double[months];

            for (int i = 0; i < months - 1; i++)
            {
                rateSum += newRate;
                newRate *= rate;
            }

            payment = newRate * sum / rateSum;

            for (int i = 0; i < months; i++)
            {
                sumBefore[i] = i == 0 ? sum : AfterPay[i - 1];
                sumAfter[i] = Math.Round(sumBefore[i] * rate, 2);
                AfterPay[i] = i == months - 1 ? 0 : Math.Round(sumAfter[i] - payment, 2);
            }

            payment = Math.Round(payment, 2);

            overpayment = Math.Round(payment * months - sum, 2);
        }

        static void Deposit(double sum, int months, double rate, out double[] before, out double[] after, out double[] percentages)
        {
            rate /= 12;
            rate += 1;
            before = new double[months];
            after = new double[months];
            percentages = new double[months];

            before[0] = sum;
            after[0] = Math.Round(rate * sum, 2);
            percentages[0] = rate;

            for (int i = 1; i < months; i++)
            {
                before[i] = after[i - 1];
                after[i] = Math.Round(rate * before[i], 2);
                percentages[i] = Math.Round(rate * percentages[i - 1], 2);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int months = Convert.ToInt32(cbMonthsAnn.Value);

            AnnCredit(
                Convert.ToInt32(cbSumAnn.Value),
                months,
                Convert.ToDouble(cbPercAnn.Value) / 100,
                out double[] sumBefore, out double[] sumAfter, out double[] AfterPay, out double payment, out double overpayment);

            lblMonPayAnn.Text = payment.ToString() + "₽";
            lblOvPayAnn.Text = overpayment.ToString() + "₽";

            tableAnn.Rows.Clear();

            for (int i = 0; i < months; i++)
            {
                tableAnn.Rows.Add(i + 1, sumBefore[i], sumAfter[i], AfterPay[i]);
            }
        }

        private void sumVNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int months = Convert.ToInt32(cbMonthsDep.Value);

            Deposit(
                Convert.ToInt32(cbSumDep.Value),
                months,
                Convert.ToDouble(cbPerDep.Value) / 100,
                out double[] before, out double[] after, out double[] percentages);

            lblPercsDep.Text = percentages[months - 1].ToString() + "%";
            lblResSumDep.Text = after[months - 1].ToString() + "₽";

            tableDep.Rows.Clear();

            for (int i = 0; i < months; i++)
            {
                tableDep.Rows.Add(i + 1, before[i], after[i], percentages[i]);
            }
        }

        private void sumDNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int months = Convert.ToInt32(cbMonthsDif.Value);

            DiffCredit(
                Convert.ToInt32(cbSumDif.Value),
                months,
                Convert.ToSingle(cbPercDif.Value) / 100,
                out double[] sumBefore, out double[] sumAfter, out double[] AfterPay, out double[] payments, out double overpayment);

            lblOvPayDif.Text = overpayment.ToString() + "₽";

            tableDif.Rows.Clear();

            for (int i = 0; i < months; i++)
            {
                tableDif.Rows.Add(i + 1, sumBefore[i], sumAfter[i], AfterPay[i], payments[i]);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void overDLabel_Click(object sender, EventArgs e)
        {

        }

        private void lblOvPayAnn_Click(object sender, EventArgs e)
        {

        }
    }
}
