using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
	public partial class FrmDashboard : Form
	{
		public FrmDashboard()
		{
			InitializeComponent();
		}

		FinancialCrmDbEntities dbEntities = new FinancialCrmDbEntities();
		int count = 0;
		private void FrmDashboard_Load(object sender, EventArgs e)
		{
			#region Toplam Bakiye
			decimal TotalBalance = Convert.ToDecimal(dbEntities.Banks.Sum(x => x.BankBalance));

			lblTotalBalanceShow.Text = TotalBalance.ToString() + " " + "₺";
			#endregion

			#region Son gelen havale
			var lastIncoming = dbEntities.BankProcess.OrderByDescending(x => x.BankProcessId)
				.Take(1).Select(y => y.Amount).FirstOrDefault();

			lblIncomingAmount.Text = lastIncoming.ToString() + " " + "₺";
			#endregion

			#region Chart 1
			var bankData = dbEntities.Banks.Select(x => new
			{
				x.BankTitle,
				x.BankBalance
			}).ToList();
			chart1.Series.Clear();
			var series = chart1.Series.Add("Series 1");
			foreach (var item in bankData)
			{
				series.Points.AddXY(item.BankTitle, item.BankBalance);
			}
			#endregion

			#region Chart 2
			var billData = dbEntities.Bills.Select(x => new
			{
				x.BillTitle,
				x.BillAmount
			}).ToList();

			chart2.Series.Clear();

			var series2 = chart2.Series.Add("Series 2");

			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;

			foreach (var item in billData)
			{
				series2.Points.AddXY(item.BillTitle, item.BillAmount);
			}
			#endregion
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			count++;
			if (count % 4 == 0)
			{
				var value = dbEntities.Bills.Where(x => x.BillTitle == "ELEKTRİK FATURASI")
					.Select(y => y.BillAmount).FirstOrDefault();

				lblBillTitle.Text = "ELEKTRİK FATURASI";
				lblBillAmount.Text = value.ToString() + " " + "₺";
			}
			if (count % 4 == 1)
			{
				var value = dbEntities.Bills.Where(x => x.BillTitle == "DOĞALGAZ FATURASI")
					.Select(y => y.BillAmount).FirstOrDefault();

				lblBillTitle.Text = "DOĞALGAZ FATURASI";
				lblBillAmount.Text = value.ToString() + " " + "₺";
			}
			if (count % 4 == 2)
			{
				var value = dbEntities.Bills.Where(x => x.BillTitle == "SU FATURASI")
					.Select(y => y.BillAmount).FirstOrDefault();

				lblBillTitle.Text = "SU FATURASI";
				lblBillAmount.Text = value.ToString() + " " + "₺";
			}
			if (count % 4 == 3)
			{
				var value = dbEntities.Bills.Where(x => x.BillTitle == "İNTERNET FATURASI")
					.Select(y => y.BillAmount).FirstOrDefault();

				lblBillTitle.Text = "İNTERNET FATURASI";
				lblBillAmount.Text = value.ToString() + " " + "₺";
			}
		}

		private void btnCategories_Click(object sender, EventArgs e)
		{
			FrmCategories frmCategories = new FrmCategories();

			frmCategories.ShowDialog();
		}

		private void btnBanks_Click(object sender, EventArgs e)
		{
			FrmBanks frmBanks = new FrmBanks();

			frmBanks.ShowDialog();
		}

		private void btnBills_Click(object sender, EventArgs e)
		{
			FrmBilling frmBilling = new FrmBilling();

			frmBilling.ShowDialog();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSpending_Click(object sender, EventArgs e)
		{
			FrmSpending frmSpending = new FrmSpending();

			frmSpending.ShowDialog();
		}

		private void btnBankProcess_Click(object sender, EventArgs e)
		{
			FrmBankProcess frmBankProcess = new FrmBankProcess();

			frmBankProcess.ShowDialog();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			FrmLogin frmLogin = new FrmLogin();

			frmLogin.ShowDialog();
		}
	}
}
