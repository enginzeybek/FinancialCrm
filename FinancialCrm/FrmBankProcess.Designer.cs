namespace FinancialCrm
{
	partial class FrmBankProcess
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnBanks = new System.Windows.Forms.Button();
			this.btnSpending = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnBills = new System.Windows.Forms.Button();
			this.btnCategories = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.lblAmount = new System.Windows.Forms.Label();
			this.cmbBank = new System.Windows.Forms.ComboBox();
			this.lblBankId = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnProcessDelete = new System.Windows.Forms.Button();
			this.lblBankProcessId = new System.Windows.Forms.Label();
			this.btnProcessUpdate = new System.Windows.Forms.Button();
			this.txtBankProcessId = new System.Windows.Forms.TextBox();
			this.btnProcessAdd = new System.Windows.Forms.Button();
			this.lblDescription = new System.Windows.Forms.Label();
			this.btnProcessList = new System.Windows.Forms.Button();
			this.lblProcessDate = new System.Windows.Forms.Label();
			this.txtProcessType = new System.Windows.Forms.TextBox();
			this.txtProcessDate = new System.Windows.Forms.TextBox();
			this.lblProcessType = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.panel2.Controls.Add(this.btnLogin);
			this.panel2.Controls.Add(this.btnBanks);
			this.panel2.Controls.Add(this.btnSpending);
			this.panel2.Controls.Add(this.btnExit);
			this.panel2.Controls.Add(this.btnDashboard);
			this.panel2.Controls.Add(this.btnBills);
			this.panel2.Controls.Add(this.btnCategories);
			this.panel2.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.panel2.Location = new System.Drawing.Point(2, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(279, 745);
			this.panel2.TabIndex = 26;
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
			// btnBanks
			// 
			this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBanks.ForeColor = System.Drawing.Color.White;
			this.btnBanks.Location = new System.Drawing.Point(12, 252);
			this.btnBanks.Name = "btnBanks";
			this.btnBanks.Size = new System.Drawing.Size(243, 71);
			this.btnBanks.TabIndex = 9;
			this.btnBanks.Text = "BANKALAR";
			this.btnBanks.UseVisualStyleBackColor = true;
			this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
			// 
			// btnSpending
			// 
			this.btnSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpending.ForeColor = System.Drawing.Color.White;
			this.btnSpending.Location = new System.Drawing.Point(12, 175);
			this.btnSpending.Name = "btnSpending";
			this.btnSpending.Size = new System.Drawing.Size(243, 71);
			this.btnSpending.TabIndex = 8;
			this.btnSpending.Text = "GİDERLER";
			this.btnSpending.UseVisualStyleBackColor = true;
			this.btnSpending.Click += new System.EventHandler(this.btnSpending_Click);
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
			this.panel1.Controls.Add(this.txtAmount);
			this.panel1.Controls.Add(this.lblAmount);
			this.panel1.Controls.Add(this.cmbBank);
			this.panel1.Controls.Add(this.lblBankId);
			this.panel1.Controls.Add(this.txtDescription);
			this.panel1.Controls.Add(this.btnProcessDelete);
			this.panel1.Controls.Add(this.lblBankProcessId);
			this.panel1.Controls.Add(this.btnProcessUpdate);
			this.panel1.Controls.Add(this.txtBankProcessId);
			this.panel1.Controls.Add(this.btnProcessAdd);
			this.panel1.Controls.Add(this.lblDescription);
			this.panel1.Controls.Add(this.btnProcessList);
			this.panel1.Controls.Add(this.lblProcessDate);
			this.panel1.Controls.Add(this.txtProcessType);
			this.panel1.Controls.Add(this.txtProcessDate);
			this.panel1.Controls.Add(this.lblProcessType);
			this.panel1.Location = new System.Drawing.Point(280, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1165, 431);
			this.panel1.TabIndex = 27;
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(292, 234);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(861, 22);
			this.txtAmount.TabIndex = 27;
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(144)))), ((int)(((byte)(102)))));
			this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblAmount.Location = new System.Drawing.Point(12, 230);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(91, 25);
			this.lblAmount.TabIndex = 26;
			this.lblAmount.Text = "TUTAR:";
			// 
			// cmbBank
			// 
			this.cmbBank.FormattingEnabled = true;
			this.cmbBank.Location = new System.Drawing.Point(252, 287);
			this.cmbBank.Name = "cmbBank";
			this.cmbBank.Size = new System.Drawing.Size(198, 24);
			this.cmbBank.TabIndex = 25;
			// 
			// lblBankId
			// 
			this.lblBankId.AutoSize = true;
			this.lblBankId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(144)))), ((int)(((byte)(102)))));
			this.lblBankId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBankId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblBankId.Location = new System.Drawing.Point(12, 286);
			this.lblBankId.Name = "lblBankId";
			this.lblBankId.Size = new System.Drawing.Size(93, 25);
			this.lblBankId.TabIndex = 24;
			this.lblBankId.Text = "BANKA:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(292, 69);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(861, 22);
			this.txtDescription.TabIndex = 15;
			// 
			// btnProcessDelete
			// 
			this.btnProcessDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
			this.btnProcessDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcessDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnProcessDelete.ForeColor = System.Drawing.Color.Black;
			this.btnProcessDelete.Location = new System.Drawing.Point(881, 329);
			this.btnProcessDelete.Name = "btnProcessDelete";
			this.btnProcessDelete.Size = new System.Drawing.Size(200, 71);
			this.btnProcessDelete.TabIndex = 23;
			this.btnProcessDelete.Text = "HAREKET SİL";
			this.btnProcessDelete.UseVisualStyleBackColor = false;
			this.btnProcessDelete.Click += new System.EventHandler(this.btnProcessDelete_Click);
			// 
			// lblBankProcessId
			// 
			this.lblBankProcessId.AutoSize = true;
			this.lblBankProcessId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(144)))), ((int)(((byte)(102)))));
			this.lblBankProcessId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBankProcessId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblBankProcessId.Location = new System.Drawing.Point(12, 17);
			this.lblBankProcessId.Name = "lblBankProcessId";
			this.lblBankProcessId.Size = new System.Drawing.Size(233, 25);
			this.lblBankProcessId.TabIndex = 12;
			this.lblBankProcessId.Text = "BANKA HAREKETİ ID:";
			// 
			// btnProcessUpdate
			// 
			this.btnProcessUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
			this.btnProcessUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcessUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnProcessUpdate.ForeColor = System.Drawing.Color.Black;
			this.btnProcessUpdate.Location = new System.Drawing.Point(660, 329);
			this.btnProcessUpdate.Name = "btnProcessUpdate";
			this.btnProcessUpdate.Size = new System.Drawing.Size(191, 71);
			this.btnProcessUpdate.TabIndex = 22;
			this.btnProcessUpdate.Text = "HAREKET GÜNCELLE";
			this.btnProcessUpdate.UseVisualStyleBackColor = false;
			this.btnProcessUpdate.Click += new System.EventHandler(this.btnProcessUpdate_Click);
			// 
			// txtBankProcessId
			// 
			this.txtBankProcessId.Location = new System.Drawing.Point(292, 20);
			this.txtBankProcessId.Name = "txtBankProcessId";
			this.txtBankProcessId.Size = new System.Drawing.Size(861, 22);
			this.txtBankProcessId.TabIndex = 13;
			// 
			// btnProcessAdd
			// 
			this.btnProcessAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
			this.btnProcessAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcessAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnProcessAdd.ForeColor = System.Drawing.Color.Black;
			this.btnProcessAdd.Location = new System.Drawing.Point(438, 329);
			this.btnProcessAdd.Name = "btnProcessAdd";
			this.btnProcessAdd.Size = new System.Drawing.Size(183, 71);
			this.btnProcessAdd.TabIndex = 21;
			this.btnProcessAdd.Text = "HAREKET EKLE";
			this.btnProcessAdd.UseVisualStyleBackColor = false;
			this.btnProcessAdd.Click += new System.EventHandler(this.btnProcessAdd_Click);
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(144)))), ((int)(((byte)(102)))));
			this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblDescription.Location = new System.Drawing.Point(12, 65);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(131, 25);
			this.lblDescription.TabIndex = 14;
			this.lblDescription.Text = "AÇIKLAMA:";
			// 
			// btnProcessList
			// 
			this.btnProcessList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
			this.btnProcessList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcessList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnProcessList.ForeColor = System.Drawing.Color.Black;
			this.btnProcessList.Location = new System.Drawing.Point(219, 329);
			this.btnProcessList.Name = "btnProcessList";
			this.btnProcessList.Size = new System.Drawing.Size(178, 71);
			this.btnProcessList.TabIndex = 20;
			this.btnProcessList.Text = "HAREKET LİSTELE";
			this.btnProcessList.UseVisualStyleBackColor = false;
			this.btnProcessList.Click += new System.EventHandler(this.btnProcessList_Click);
			// 
			// lblProcessDate
			// 
			this.lblProcessDate.AutoSize = true;
			this.lblProcessDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(144)))), ((int)(((byte)(102)))));
			this.lblProcessDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProcessDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblProcessDate.Location = new System.Drawing.Point(12, 121);
			this.lblProcessDate.Name = "lblProcessDate";
			this.lblProcessDate.Size = new System.Drawing.Size(196, 25);
			this.lblProcessDate.TabIndex = 16;
			this.lblProcessDate.Text = "HAREKET TARİHİ:";
			// 
			// txtProcessType
			// 
			this.txtProcessType.Location = new System.Drawing.Point(292, 181);
			this.txtProcessType.Name = "txtProcessType";
			this.txtProcessType.Size = new System.Drawing.Size(861, 22);
			this.txtProcessType.TabIndex = 19;
			// 
			// txtProcessDate
			// 
			this.txtProcessDate.Location = new System.Drawing.Point(292, 121);
			this.txtProcessDate.Name = "txtProcessDate";
			this.txtProcessDate.Size = new System.Drawing.Size(861, 22);
			this.txtProcessDate.TabIndex = 17;
			// 
			// lblProcessType
			// 
			this.lblProcessType.AutoSize = true;
			this.lblProcessType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(144)))), ((int)(((byte)(102)))));
			this.lblProcessType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProcessType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblProcessType.Location = new System.Drawing.Point(12, 177);
			this.lblProcessType.Name = "lblProcessType";
			this.lblProcessType.Size = new System.Drawing.Size(166, 25);
			this.lblProcessType.TabIndex = 18;
			this.lblProcessType.Text = "HAREKET TİPİ:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(165)))), ((int)(((byte)(194)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(280, 423);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1165, 322);
			this.dataGridView1.TabIndex = 28;
			// 
			// FrmBankProcess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1445, 749);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "FrmBankProcess";
			this.Text = "FrmBankProcess";
			this.Load += new System.EventHandler(this.FrmBankProcess_Load);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnBanks;
		private System.Windows.Forms.Button btnSpending;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnBills;
		private System.Windows.Forms.Button btnCategories;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cmbBank;
		private System.Windows.Forms.Label lblBankId;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnProcessDelete;
		private System.Windows.Forms.Label lblBankProcessId;
		private System.Windows.Forms.Button btnProcessUpdate;
		private System.Windows.Forms.TextBox txtBankProcessId;
		private System.Windows.Forms.Button btnProcessAdd;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Button btnProcessList;
		private System.Windows.Forms.Label lblProcessDate;
		private System.Windows.Forms.TextBox txtProcessType;
		private System.Windows.Forms.TextBox txtProcessDate;
		private System.Windows.Forms.Label lblProcessType;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label lblAmount;
	}
}