using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
	public partial class FrmBanks : Form
	{
		public FrmBanks()
		{
			InitializeComponent();
		}

		FinancialCrmDbEntities financialCrmDb = new FinancialCrmDbEntities();
		private void FrmBanks_Load(object sender, EventArgs e)
		{
			#region Banka Bakiyeleri

			decimal ziraatBalance = decimal.Parse(financialCrmDb.Banks.Where(x => x.BankId == 1)
				.Select(y => y.BankBalance).FirstOrDefault().ToString());

			lblAmountZiraat.Text = ziraatBalance.ToString() + " ₺";

			decimal vakifbankBalance = decimal.Parse(financialCrmDb.Banks.Where(x => x.BankId == 2)
				.Select(y => y.BankBalance).FirstOrDefault().ToString());

			lblAmountVakif.Text = vakifbankBalance.ToString() + " ₺";

			decimal isbankBalance = decimal.Parse(financialCrmDb.Banks.Where(x => x.BankId == 3)
				.Select(y =>y.BankBalance).FirstOrDefault().ToString());

			lblAmountIsBank.Text = isbankBalance.ToString() + " ₺";

			#endregion

			#region Banka Hareketleri
			var bankProcess1 = financialCrmDb.BankProcess.OrderByDescending(x => x.BankProcessId)
				.Take(1).FirstOrDefault();
			//lblText1.Text = "AÇIKLAMA" + Font.Bold.ToString();
			lblText1.Font = new Font(lblText1.Font, FontStyle.Bold);
			lblText1.Text = bankProcess1.Description + " " + bankProcess1.ProcessDate + " " +
				bankProcess1.ProcessType + " " + bankProcess1.Amount + " " + bankProcess1.BankId;

			var bankProcess2 = financialCrmDb.BankProcess.OrderByDescending(x => x.BankProcessId)
				.Take(2).Skip(1).FirstOrDefault();
			lblText2.Font = new Font(lblText2.Font, FontStyle.Bold);
			lblText2.Text = bankProcess2.Description + " " + bankProcess2.ProcessDate + " " +
				bankProcess2.ProcessType + " " + bankProcess2.Amount + " " + bankProcess2.BankId;

			var bankProcess3 = financialCrmDb.BankProcess.OrderByDescending(x => x.BankProcessId)
				.Take(3).Skip(2).FirstOrDefault();
			lblText3.Font = new Font(lblText3.Font, FontStyle.Bold);
			lblText3.Text = bankProcess3.Description + " " + bankProcess3.ProcessDate + " " +
				bankProcess3.ProcessType + " " + bankProcess3.Amount + " " + bankProcess3.BankId;

			var bankProcess4 = financialCrmDb.BankProcess.OrderByDescending(x => x.BankProcessId)
				.Take(4).Skip(3).FirstOrDefault();
			lblText4.Font = new Font(lblText4.Font, FontStyle.Bold);
			lblText4.Text = bankProcess4.Description + " " + bankProcess4.ProcessDate + " " +
				bankProcess4.ProcessType + " " + bankProcess4.Amount + " " + bankProcess4.BankId;

			var bankProcess5 = financialCrmDb.BankProcess.OrderByDescending(x => x.BankProcessId)
				.Take(5).Skip(4).FirstOrDefault();
			lblText5.Font = new Font(lblText5.Font, FontStyle.Bold);
			lblText5.Text = bankProcess5.Description + " " + bankProcess5.ProcessDate + " " +
				bankProcess5.ProcessType + " " + bankProcess5.Amount + " " + bankProcess5.BankId;

			#endregion

		}

		private void btnCategories_Click(object sender, EventArgs e)
		{
			FrmCategories frmCategories = new FrmCategories();

			frmCategories.ShowDialog();
		}

		private void btnBills_Click(object sender, EventArgs e)
		{
			FrmBilling billing = new FrmBilling();

			billing.ShowDialog();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			FrmDashboard frmDashboard = new FrmDashboard();

			frmDashboard.ShowDialog();
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

		private void btnLogin_Click(object sender, EventArgs e)
		{
			FrmLogin frmLogin = new FrmLogin();

			frmLogin.ShowDialog();
		}

		private void btnBankProcess_Click(object sender, EventArgs e)
		{
			FrmBankProcess frmBankProcess = new FrmBankProcess();

			frmBankProcess.ShowDialog();
		}
	}
}
