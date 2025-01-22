namespace FinancialCrm
{
	partial class FrmSpending
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSpendingDelete = new System.Windows.Forms.Button();
			this.btnSpendingUpdate = new System.Windows.Forms.Button();
			this.btnSpendingAdd = new System.Windows.Forms.Button();
			this.btnSpendingList = new System.Windows.Forms.Button();
			this.txtSpendingDate = new System.Windows.Forms.TextBox();
			this.lblSpendingDate = new System.Windows.Forms.Label();
			this.txtSpendingAmount = new System.Windows.Forms.TextBox();
			this.lblSpendingAmount = new System.Windows.Forms.Label();
			this.txtSpendingTitle = new System.Windows.Forms.TextBox();
			this.lblSpendingTitle = new System.Windows.Forms.Label();
			this.txtSpendingId = new System.Windows.Forms.TextBox();
			this.lblSpendingId = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmbSpendingCategory = new System.Windows.Forms.ComboBox();
			this.lblCategoriSpending = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnBankProcess = new System.Windows.Forms.Button();
			this.btnBanks = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnBills = new System.Windows.Forms.Button();
			this.btnCategories = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSpendingDelete
			// 
			this.btnSpendingDelete.BackColor = System.Drawing.Color.Goldenrod;
			this.btnSpendingDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpendingDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpendingDelete.ForeColor = System.Drawing.Color.Black;
			this.btnSpendingDelete.Location = new System.Drawing.Point(881, 282);
			this.btnSpendingDelete.Name = "btnSpendingDelete";
			this.btnSpendingDelete.Size = new System.Drawing.Size(200, 71);
			this.btnSpendingDelete.TabIndex = 23;
			this.btnSpendingDelete.Text = "GİDER SİL";
			this.btnSpendingDelete.UseVisualStyleBackColor = false;
			this.btnSpendingDelete.Click += new System.EventHandler(this.btnSpendingDelete_Click);
			// 
			// btnSpendingUpdate
			// 
			this.btnSpendingUpdate.BackColor = System.Drawing.Color.Goldenrod;
			this.btnSpendingUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpendingUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpendingUpdate.ForeColor = System.Drawing.Color.Black;
			this.btnSpendingUpdate.Location = new System.Drawing.Point(660, 282);
			this.btnSpendingUpdate.Name = "btnSpendingUpdate";
			this.btnSpendingUpdate.Size = new System.Drawing.Size(191, 71);
			this.btnSpendingUpdate.TabIndex = 22;
			this.btnSpendingUpdate.Text = "GİDER GÜNCELLE";
			this.btnSpendingUpdate.UseVisualStyleBackColor = false;
			this.btnSpendingUpdate.Click += new System.EventHandler(this.btnSpendingUpdate_Click);
			// 
			// btnSpendingAdd
			// 
			this.btnSpendingAdd.BackColor = System.Drawing.Color.Goldenrod;
			this.btnSpendingAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpendingAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpendingAdd.ForeColor = System.Drawing.Color.Black;
			this.btnSpendingAdd.Location = new System.Drawing.Point(438, 282);
			this.btnSpendingAdd.Name = "btnSpendingAdd";
			this.btnSpendingAdd.Size = new System.Drawing.Size(183, 71);
			this.btnSpendingAdd.TabIndex = 21;
			this.btnSpendingAdd.Text = "GİDER EKLE";
			this.btnSpendingAdd.UseVisualStyleBackColor = false;
			this.btnSpendingAdd.Click += new System.EventHandler(this.btnSpendingAdd_Click);
			// 
			// btnSpendingList
			// 
			this.btnSpendingList.BackColor = System.Drawing.Color.Goldenrod;
			this.btnSpendingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpendingList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpendingList.ForeColor = System.Drawing.Color.Black;
			this.btnSpendingList.Location = new System.Drawing.Point(219, 282);
			this.btnSpendingList.Name = "btnSpendingList";
			this.btnSpendingList.Size = new System.Drawing.Size(178, 71);
			this.btnSpendingList.TabIndex = 20;
			this.btnSpendingList.Text = "GİDER LİSTELE";
			this.btnSpendingList.UseVisualStyleBackColor = false;
			this.btnSpendingList.Click += new System.EventHandler(this.btnSpendingList_Click);
			// 
			// txtSpendingDate
			// 
			this.txtSpendingDate.Location = new System.Drawing.Point(252, 181);
			this.txtSpendingDate.Name = "txtSpendingDate";
			this.txtSpendingDate.Size = new System.Drawing.Size(826, 22);
			this.txtSpendingDate.TabIndex = 19;
			// 
			// lblSpendingDate
			// 
			this.lblSpendingDate.AutoSize = true;
			this.lblSpendingDate.BackColor = System.Drawing.Color.Black;
			this.lblSpendingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSpendingDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSpendingDate.Location = new System.Drawing.Point(12, 177);
			this.lblSpendingDate.Name = "lblSpendingDate";
			this.lblSpendingDate.Size = new System.Drawing.Size(160, 25);
			this.lblSpendingDate.TabIndex = 18;
			this.lblSpendingDate.Text = "GİDER TARİHİ:";
			// 
			// txtSpendingAmount
			// 
			this.txtSpendingAmount.Location = new System.Drawing.Point(252, 121);
			this.txtSpendingAmount.Name = "txtSpendingAmount";
			this.txtSpendingAmount.Size = new System.Drawing.Size(826, 22);
			this.txtSpendingAmount.TabIndex = 17;
			// 
			// lblSpendingAmount
			// 
			this.lblSpendingAmount.AutoSize = true;
			this.lblSpendingAmount.BackColor = System.Drawing.Color.Black;
			this.lblSpendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSpendingAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSpendingAmount.Location = new System.Drawing.Point(12, 121);
			this.lblSpendingAmount.Name = "lblSpendingAmount";
			this.lblSpendingAmount.Size = new System.Drawing.Size(168, 25);
			this.lblSpendingAmount.TabIndex = 16;
			this.lblSpendingAmount.Text = "GİDER TUTARI:";
			// 
			// txtSpendingTitle
			// 
			this.txtSpendingTitle.Location = new System.Drawing.Point(252, 69);
			this.txtSpendingTitle.Name = "txtSpendingTitle";
			this.txtSpendingTitle.Size = new System.Drawing.Size(826, 22);
			this.txtSpendingTitle.TabIndex = 15;
			// 
			// lblSpendingTitle
			// 
			this.lblSpendingTitle.AutoSize = true;
			this.lblSpendingTitle.BackColor = System.Drawing.Color.Black;
			this.lblSpendingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSpendingTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSpendingTitle.Location = new System.Drawing.Point(12, 65);
			this.lblSpendingTitle.Name = "lblSpendingTitle";
			this.lblSpendingTitle.Size = new System.Drawing.Size(174, 25);
			this.lblSpendingTitle.TabIndex = 14;
			this.lblSpendingTitle.Text = "GİDER BAŞLIĞI:";
			// 
			// txtSpendingId
			// 
			this.txtSpendingId.Location = new System.Drawing.Point(252, 20);
			this.txtSpendingId.Name = "txtSpendingId";
			this.txtSpendingId.Size = new System.Drawing.Size(826, 22);
			this.txtSpendingId.TabIndex = 13;
			// 
			// lblSpendingId
			// 
			this.lblSpendingId.AutoSize = true;
			this.lblSpendingId.BackColor = System.Drawing.Color.Black;
			this.lblSpendingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSpendingId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSpendingId.Location = new System.Drawing.Point(12, 17);
			this.lblSpendingId.Name = "lblSpendingId";
			this.lblSpendingId.Size = new System.Drawing.Size(111, 25);
			this.lblSpendingId.TabIndex = 12;
			this.lblSpendingId.Text = "GİDER ID:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
			this.panel1.Controls.Add(this.cmbSpendingCategory);
			this.panel1.Controls.Add(this.lblCategoriSpending);
			this.panel1.Controls.Add(this.txtSpendingTitle);
			this.panel1.Controls.Add(this.btnSpendingDelete);
			this.panel1.Controls.Add(this.lblSpendingId);
			this.panel1.Controls.Add(this.btnSpendingUpdate);
			this.panel1.Controls.Add(this.txtSpendingId);
			this.panel1.Controls.Add(this.btnSpendingAdd);
			this.panel1.Controls.Add(this.lblSpendingTitle);
			this.panel1.Controls.Add(this.btnSpendingList);
			this.panel1.Controls.Add(this.lblSpendingAmount);
			this.panel1.Controls.Add(this.txtSpendingDate);
			this.panel1.Controls.Add(this.txtSpendingAmount);
			this.panel1.Controls.Add(this.lblSpendingDate);
			this.panel1.Location = new System.Drawing.Point(280, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1149, 383);
			this.panel1.TabIndex = 24;
			// 
			// cmbSpendingCategory
			// 
			this.cmbSpendingCategory.FormattingEnabled = true;
			this.cmbSpendingCategory.Location = new System.Drawing.Point(252, 240);
			this.cmbSpendingCategory.Name = "cmbSpendingCategory";
			this.cmbSpendingCategory.Size = new System.Drawing.Size(198, 24);
			this.cmbSpendingCategory.TabIndex = 25;
			// 
			// lblCategoriSpending
			// 
			this.lblCategoriSpending.AutoSize = true;
			this.lblCategoriSpending.BackColor = System.Drawing.Color.Black;
			this.lblCategoriSpending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCategoriSpending.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblCategoriSpending.Location = new System.Drawing.Point(12, 239);
			this.lblCategoriSpending.Name = "lblCategoriSpending";
			this.lblCategoriSpending.Size = new System.Drawing.Size(222, 25);
			this.lblCategoriSpending.TabIndex = 24;
			this.lblCategoriSpending.Text = "GİDER KATEGORİSİ:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.panel2.Controls.Add(this.btnLogin);
			this.panel2.Controls.Add(this.btnBankProcess);
			this.panel2.Controls.Add(this.btnBanks);
			this.panel2.Controls.Add(this.btnExit);
			this.panel2.Controls.Add(this.btnDashboard);
			this.panel2.Controls.Add(this.btnBills);
			this.panel2.Controls.Add(this.btnCategories);
			this.panel2.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.panel2.Location = new System.Drawing.Point(2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(279, 745);
			this.panel2.TabIndex = 25;
			// 
			// btnLogin
			// 
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(12, 406);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(243, 71);
			this.btnLogin.TabIndex = 10;
			this.btnLogin.Text = "LOGİN";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnBankProcess
			// 
			this.btnBankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBankProcess.ForeColor = System.Drawing.Color.White;
			this.btnBankProcess.Location = new System.Drawing.Point(12, 252);
			this.btnBankProcess.Name = "btnBankProcess";
			this.btnBankProcess.Size = new System.Drawing.Size(243, 71);
			this.btnBankProcess.TabIndex = 9;
			this.btnBankProcess.Text = "BANKA HAREKETLERİ";
			this.btnBankProcess.UseVisualStyleBackColor = true;
			this.btnBankProcess.Click += new System.EventHandler(this.btnBankProcess_Click);
			// 
			// btnBanks
			// 
			this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBanks.ForeColor = System.Drawing.Color.White;
			this.btnBanks.Location = new System.Drawing.Point(12, 175);
			this.btnBanks.Name = "btnBanks";
			this.btnBanks.Size = new System.Drawing.Size(243, 71);
			this.btnBanks.TabIndex = 8;
			this.btnBanks.Text = "BANKALAR";
			this.btnBanks.UseVisualStyleBackColor = true;
			this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
			// 
			// btnExit
			// 
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Location = new System.Drawing.Point(12, 483);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(243, 71);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "ÇIKIŞ YAP";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDashboard
			// 
			this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDashboard.ForeColor = System.Drawing.Color.White;
			this.btnDashboard.Location = new System.Drawing.Point(12, 329);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Size = new System.Drawing.Size(243, 71);
			this.btnDashboard.TabIndex = 5;
			this.btnDashboard.Text = "DASHBOARD";
			this.btnDashboard.UseVisualStyleBackColor = true;
			this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
			// 
			// btnBills
			// 
			this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBills.ForeColor = System.Drawing.Color.White;
			this.btnBills.Location = new System.Drawing.Point(12, 98);
			this.btnBills.Name = "btnBills";
			this.btnBills.Size = new System.Drawing.Size(243, 71);
			this.btnBills.TabIndex = 2;
			this.btnBills.Text = "FATURALAR";
			this.btnBills.UseVisualStyleBackColor = true;
			this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
			// 
			// btnCategories
			// 
			this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCategories.ForeColor = System.Drawing.Color.White;
			this.btnCategories.Location = new System.Drawing.Point(12, 20);
			this.btnCategories.Name = "btnCategories";
			this.btnCategories.Size = new System.Drawing.Size(243, 71);
			this.btnCategories.TabIndex = 0;
			this.btnCategories.Text = "KATEGORİLER";
			this.btnCategories.UseVisualStyleBackColor = true;
			this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(280, 383);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1149, 364);
			this.dataGridView1.TabIndex = 26;
			// 
			// FrmSpending
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1430, 747);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmSpending";
			this.Text = "FrmSpending";
			this.Load += new System.EventHandler(this.FrmSpending_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSpendingDelete;
		private System.Windows.Forms.Button btnSpendingUpdate;
		private System.Windows.Forms.Button btnSpendingAdd;
		private System.Windows.Forms.Button btnSpendingList;
		private System.Windows.Forms.TextBox txtSpendingDate;
		private System.Windows.Forms.Label lblSpendingDate;
		private System.Windows.Forms.TextBox txtSpendingAmount;
		private System.Windows.Forms.Label lblSpendingAmount;
		private System.Windows.Forms.TextBox txtSpendingTitle;
		private System.Windows.Forms.Label lblSpendingTitle;
		private System.Windows.Forms.TextBox txtSpendingId;
		private System.Windows.Forms.Label lblSpendingId;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblCategoriSpending;
		private System.Windows.Forms.ComboBox cmbSpendingCategory;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnBankProcess;
		private System.Windows.Forms.Button btnBanks;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnBills;
		private System.Windows.Forms.Button btnCategories;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}