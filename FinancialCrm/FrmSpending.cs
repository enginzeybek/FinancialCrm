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
	public partial class FrmSpending : Form
	{
		public FrmSpending()
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

		private void btnBanks_Click(object sender, EventArgs e)
		{
			FrmBanks frmBanks = new FrmBanks();

			frmBanks.ShowDialog();
		}

		private void btnBankProcess_Click(object sender, EventArgs e)
		{
			FrmBankProcess frmBankProcess = new FrmBankProcess();

			frmBankProcess.ShowDialog();
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

		private void btnSpendingList_Click(object sender, EventArgs e)
		{
			var value = dbEntities.Spendings.Join(dbEntities.Categories,
				Spendings => Spendings.CategoryId,
				Categories => Categories.CategoryId,
				(Spendings, Categories) => new
				{
					SpendingId = Spendings.SpendingID,
					SpendingTitle = Spendings.SpendingTitle,
					SpendingAmount = Spendings.SpendingAmount,
					SpendingDate = Spendings.SpendingDate,
					CategoryName = Categories.CategoryName,
					CategoryId = Spendings.CategoryId
				}).ToList();

			dataGridView1.DataSource = value;
		}

		private void FrmSpending_Load(object sender, EventArgs e)
		{
			var value = dbEntities.Spendings.Join(dbEntities.Categories,
				Spendings => Spendings.CategoryId,
				Categories => Categories.CategoryId,
				(Spendings, Categories) => new
				{
					SpendingId = Spendings.SpendingID,
					SpendingTitle = Spendings.SpendingTitle,
					SpendingAmount = Spendings.SpendingAmount,
					SpendingDate = Spendings.SpendingDate,
					CategoryName = Categories.CategoryName,
					CategoryId = Categories.CategoryId
				}).ToList();

			dataGridView1.DataSource = value;

			cmbSpendingCategory.ValueMember = "CategoryId";

			cmbSpendingCategory.DisplayMember = "CategoryName";

			cmbSpendingCategory.DataSource = value;

			

		}

		private void btnSpendingAdd_Click(object sender, EventArgs e)
		{
			string SpendingTitle = txtSpendingTitle.Text;

			decimal SpendingAmount = decimal.Parse(txtSpendingAmount.Text);

			DateTime SpendingDate = DateTime.Parse(txtSpendingDate.Text);

			int CategoryId = Convert.ToInt32(cmbSpendingCategory.SelectedValue);

			Spendings spendings = new Spendings()
			{
				SpendingTitle = SpendingTitle,
				SpendingAmount = SpendingAmount,
				SpendingDate = SpendingDate,
				CategoryId=CategoryId
			};

			dbEntities.Spendings.Add(spendings);

			MessageBox.Show("VERİ EKLENDİ");

			dbEntities.SaveChanges();


		}

		private void btnSpendingUpdate_Click(object sender, EventArgs e)
		{
			int updatedId = int.Parse(txtSpendingId.Text);

			var updatedValue = dbEntities.Spendings.Find(updatedId);

			updatedValue.SpendingTitle = txtSpendingTitle.Text;

			updatedValue.SpendingAmount = Convert.ToDecimal(txtSpendingAmount.Text);

			updatedValue.SpendingDate = DateTime.Parse(txtSpendingDate.Text);

			updatedValue.CategoryId = int.Parse(cmbSpendingCategory.SelectedValue.ToString());

			MessageBox.Show("VERİ GÜNCELLENDİ");

			dbEntities.SaveChanges();
		}

		private void btnSpendingDelete_Click(object sender, EventArgs e)
		{
			int deletedId = int.Parse(txtSpendingId.Text);

			var deletedValue = dbEntities.Spendings.Find(deletedId);

			dbEntities.Spendings.Remove(deletedValue);

			MessageBox.Show("VERİ SİLİNDİ");

			dbEntities.SaveChanges();
		}
	}
}
