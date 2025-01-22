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
	public partial class FrmBankProcess : Form
	{
		public FrmBankProcess()
		{
			InitializeComponent();
		}

		FinancialCrmDbEntities dbEntities = new FinancialCrmDbEntities();
		private void btnCategories_Click(object sender, EventArgs e)
		{
			FrmCategories frmCategories = new FrmCategories();

			frmCategories.ShowDialog();
		}

		private void btnBills_Click(object sender, EventArgs e)
		{
			FrmBilling frmBilling = new FrmBilling();

			frmBilling.ShowDialog();
		}

		private void btnSpending_Click(object sender, EventArgs e)
		{
			FrmSpending frmSpending = new FrmSpending();

			frmSpending.ShowDialog();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			FrmDashboard frmDashboard = new FrmDashboard();

			frmDashboard.ShowDialog();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			FrmLogin frmLogin = new FrmLogin();

			frmLogin.ShowDialog();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmBankProcess_Load(object sender, EventArgs e)
		{
			var value = dbEntities.BankProcess.Join(dbEntities.Banks,
				BankProcess => BankProcess.BankId,
				Banks => Banks.BankId,
				(BankProcess,Banks) => new
				{
					BankProcess = BankProcess.BankProcessId,
					Description = BankProcess.Description,
					ProcessDate = BankProcess.ProcessDate,
					ProcessType = BankProcess.ProcessType,
					Amount = BankProcess.Amount,
					BankTitle = Banks.BankTitle,
					BankId = Banks.BankId
				}).ToList();

			dataGridView1.DataSource = value;

			cmbBank.ValueMember = "BankId";

			cmbBank.DisplayMember = "BankTitle";

			cmbBank.DataSource = value;


		}

		private void btnProcessList_Click(object sender, EventArgs e)
		{
			var value = dbEntities.BankProcess.Join(dbEntities.Banks,
				BankProcess => BankProcess.BankId,
				Banks => Banks.BankId,
				(BankProcess, Banks) => new
				{
					BankProcess = BankProcess.BankProcessId,
					Description = BankProcess.Description,
					ProcessDate = BankProcess.ProcessDate,
					ProcessType = BankProcess.ProcessType,
					Amount = BankProcess.Amount,
					BankTitle = Banks.BankTitle,
					BankId = Banks.BankId
				}).ToList();

			dataGridView1.DataSource = value;

			
		}

		private void btnProcessAdd_Click(object sender, EventArgs e)
		{
			string description = txtDescription.Text;

			DateTime processDate = DateTime.Parse(txtProcessDate.Text);

			string processType = txtProcessType.Text;

			decimal amount = Convert.ToDecimal(txtAmount.Text);

			int bankId = int.Parse(cmbBank.SelectedValue.ToString());

			BankProcess bankProcess = new BankProcess()
			{
				Amount = amount,
				BankId = bankId,
				Description = description,
				ProcessDate = processDate,
				ProcessType = processType,
			};

			dbEntities.BankProcess.Add(bankProcess);

			MessageBox.Show("VERİ EKLENDİ");

			dbEntities.SaveChanges();


		}

		private void btnProcessUpdate_Click(object sender, EventArgs e)
		{
			int updatedId = int.Parse(txtBankProcessId.Text);

			var updatedValue = dbEntities.BankProcess.Find(updatedId);

			updatedValue.Description = txtDescription.Text;

			updatedValue.ProcessDate = DateTime.Parse(txtProcessDate.Text);

			updatedValue.ProcessType = txtProcessType.Text;

			updatedValue.Amount = decimal.Parse(txtAmount.Text);

			updatedValue.BankId = int.Parse(cmbBank.SelectedValue.ToString());

			MessageBox.Show("VERİ GÜNCELLENDİ");

			dbEntities.SaveChanges();

			
		}

		private void btnProcessDelete_Click(object sender, EventArgs e)
		{
			int deletedId = int.Parse(txtBankProcessId.Text);

			var deletedValue = dbEntities.BankProcess.Find(deletedId);

			dbEntities.BankProcess.Remove(deletedValue);

			MessageBox.Show("VERİ SİLİNDİ");

			dbEntities.SaveChanges();
		}

		private void btnBanks_Click(object sender, EventArgs e)
		{
			FrmBanks frmBanks = new FrmBanks();

			frmBanks.ShowDialog();
		}
	}
}
