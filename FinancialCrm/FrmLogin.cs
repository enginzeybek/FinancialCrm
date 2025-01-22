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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void btnEntry_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;

			string password = txtPassword.Text;

			if (userName == "Admin" && password == "1234")
			{
				FrmCategories frmCategories = new FrmCategories();

				frmCategories.ShowDialog();
			}
			else 
			{
				MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRE","HATA",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
			}
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
