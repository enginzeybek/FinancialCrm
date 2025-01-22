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
	public partial class FrmBilling : Form
	{
		public FrmBilling()
		{
			InitializeComponent();
		}

		FinancialCrmDbEntities dbEntities = new FinancialCrmDbEntities();
		private void FrmBilling_Load(object sender, EventArgs e)
		{
			var value = dbEntities.Bills.ToList();

			dataGridView1.DataSource = value;
		}

		private void btnBillingList_Click(object sender, EventArgs e)
		{
			var value = dbEntities.Bills.ToList();

			dataGridView1.DataSource = value;
		}

		private void btnBillingAdd_Click(object sender, EventArgs e)
		{
			string billTitle = txtBillingTitle.Text;

			decimal billAmount = Convert.ToDecimal(txtBillingAmount.Text);

			string billPeriod = txtBillingPeriod.Text;

			Bills bills = new Bills()
			{
				BillAmount = billAmount,
				BillPeriod = billPeriod,
				BillTitle = billTitle
			};

			dbEntities.Bills.Add(bills);

			dbEntities.SaveChanges();

			MessageBox.Show("ÖDEME EKLENDİ");
		}

		private void btnBillingUpdate_Click(object sender, EventArgs e)
		{
			int billId = int.Parse(txtBillingId.Text);

			var valuesUpdated = dbEntities.Bills.Find(billId);

			string billTitle = txtBillingTitle.Text;

			decimal billAmount = Convert.ToDecimal(txtBillingAmount.Text);

			string billPeriod = txtBillingPeriod.Text;

			valuesUpdated.BillAmount = billAmount;
			valuesUpdated.BillPeriod = billPeriod;
			valuesUpdated.BillTitle = billTitle;

			dbEntities.SaveChanges();

			MessageBox.Show("ÖDEME GÜNCELLENDİ");
		}

		private void btnBillingDelete_Click(object sender, EventArgs e)
		{
			int billId = int.Parse(txtBillingId.Text);

			var valuesDeleted = dbEntities.Bills.Find(billId);

			dbEntities.Bills.Remove(valuesDeleted);

			dbEntities.SaveChanges();

			MessageBox.Show("ÖDEME SİLİNDİ");
		}

		private void btnBanks_Click(object sender, EventArgs e)
		{
			FrmBanks frmBanks = new FrmBanks();

			frmBanks.ShowDialog();

		}

		private void btnCategories_Click(object sender, EventArgs e)
		{
			FrmCategories frmCategories = new FrmCategories();

			frmCategories.ShowDialog();
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

		private void btnLogin_Click(object sender, EventArgs e)
		{
			FrmLogin frmLogin = new FrmLogin();

			frmLogin.ShowDialog();
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
	}
}
