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
	public partial class FrmCategories : Form
	{
		public FrmCategories()
		{
			InitializeComponent();
		}

		private void btnBanks_Click(object sender, EventArgs e)
		{
			FrmBanks frmBanks = new FrmBanks();

			frmBanks.ShowDialog();
		}

		private void btnBilling_Click(object sender, EventArgs e)
		{
			FrmBilling frmBilling = new FrmBilling();

			frmBilling.ShowDialog();
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

		private void btnSpending_Click(object sender, EventArgs e)
		{
			FrmSpending frmSpending = new FrmSpending();

			frmSpending.ShowDialog();
		}
	}
}
