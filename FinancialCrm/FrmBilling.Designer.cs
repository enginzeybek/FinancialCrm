namespace FinancialCrm
{
	partial class FrmBilling
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnBanks = new System.Windows.Forms.Button();
			this.btnCategories = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBillingDelete = new System.Windows.Forms.Button();
			this.btnBillingUpdate = new System.Windows.Forms.Button();
			this.btnBillingAdd = new System.Windows.Forms.Button();
			this.btnBillingList = new System.Windows.Forms.Button();
			this.txtBillingPeriod = new System.Windows.Forms.TextBox();
			this.lblBillingPeriod = new System.Windows.Forms.Label();
			this.txtBillingAmount = new System.Windows.Forms.TextBox();
			this.lblBillingAmount = new System.Windows.Forms.Label();
			this.txtBillingTitle = new System.Windows.Forms.TextBox();
			this.lblBillingTitle = new System.Windows.Forms.Label();
			this.txtBillingId = new System.Windows.Forms.TextBox();
			this.lblBillingId = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnSpending = new System.Windows.Forms.Button();
			this.btnBankProcess = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.btnBankProcess);
			this.panel1.Controls.Add(this.btnSpending);
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.btnDashboard);
			this.panel1.Controls.Add(this.btnBanks);
			this.panel1.Controls.Add(this.btnCategories);
			this.panel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(269, 739);
			this.panel1.TabIndex = 1;
			// 
			// btnExit
			// 
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Location = new System.Drawing.Point(11, 492);
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
			this.btnDashboard.Location = new System.Drawing.Point(12, 338);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Size = new System.Drawing.Size(243, 71);
			this.btnDashboard.TabIndex = 5;
			this.btnDashboard.Text = "DASHBOARD";
			this.btnDashboard.UseVisualStyleBackColor = true;
			this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
			// 
			// btnBanks
			// 
			this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBanks.ForeColor = System.Drawing.Color.White;
			this.btnBanks.Location = new System.Drawing.Point(12, 261);
			this.btnBanks.Name = "btnBanks";
			this.btnBanks.Size = new System.Drawing.Size(243, 71);
			this.btnBanks.TabIndex = 1;
			this.btnBanks.Text = "BANKALAR";
			this.btnBanks.UseVisualStyleBackColor = true;
			this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
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
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.panel2.Controls.Add(this.btnBillingDelete);
			this.panel2.Controls.Add(this.btnBillingUpdate);
			this.panel2.Controls.Add(this.btnBillingAdd);
			this.panel2.Controls.Add(this.btnBillingList);
			this.panel2.Controls.Add(this.txtBillingPeriod);
			this.panel2.Controls.Add(this.lblBillingPeriod);
			this.panel2.Controls.Add(this.txtBillingAmount);
			this.panel2.Controls.Add(this.lblBillingAmount);
			this.panel2.Controls.Add(this.txtBillingTitle);
			this.panel2.Controls.Add(this.lblBillingTitle);
			this.panel2.Controls.Add(this.txtBillingId);
			this.panel2.Controls.Add(this.lblBillingId);
			this.panel2.Location = new System.Drawing.Point(276, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1128, 343);
			this.panel2.TabIndex = 2;
			// 
			// btnBillingDelete
			// 
			this.btnBillingDelete.BackColor = System.Drawing.Color.Goldenrod;
			this.btnBillingDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillingDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillingDelete.ForeColor = System.Drawing.Color.Black;
			this.btnBillingDelete.Location = new System.Drawing.Point(885, 232);
			this.btnBillingDelete.Name = "btnBillingDelete";
			this.btnBillingDelete.Size = new System.Drawing.Size(218, 71);
			this.btnBillingDelete.TabIndex = 11;
			this.btnBillingDelete.Text = "ÖDEME SİL";
			this.btnBillingDelete.UseVisualStyleBackColor = false;
			this.btnBillingDelete.Click += new System.EventHandler(this.btnBillingDelete_Click);
			// 
			// btnBillingUpdate
			// 
			this.btnBillingUpdate.BackColor = System.Drawing.Color.Goldenrod;
			this.btnBillingUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillingUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillingUpdate.ForeColor = System.Drawing.Color.Black;
			this.btnBillingUpdate.Location = new System.Drawing.Point(664, 232);
			this.btnBillingUpdate.Name = "btnBillingUpdate";
			this.btnBillingUpdate.Size = new System.Drawing.Size(209, 71);
			this.btnBillingUpdate.TabIndex = 10;
			this.btnBillingUpdate.Text = "ÖDEME GÜNCELLE";
			this.btnBillingUpdate.UseVisualStyleBackColor = false;
			this.btnBillingUpdate.Click += new System.EventHandler(this.btnBillingUpdate_Click);
			// 
			// btnBillingAdd
			// 
			this.btnBillingAdd.BackColor = System.Drawing.Color.Goldenrod;
			this.btnBillingAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillingAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillingAdd.ForeColor = System.Drawing.Color.Black;
			this.btnBillingAdd.Location = new System.Drawing.Point(442, 232);
			this.btnBillingAdd.Name = "btnBillingAdd";
			this.btnBillingAdd.Size = new System.Drawing.Size(201, 71);
			this.btnBillingAdd.TabIndex = 9;
			this.btnBillingAdd.Text = "ÖDEME EKLE";
			this.btnBillingAdd.UseVisualStyleBackColor = false;
			this.btnBillingAdd.Click += new System.EventHandler(this.btnBillingAdd_Click);
			// 
			// btnBillingList
			// 
			this.btnBillingList.BackColor = System.Drawing.Color.Goldenrod;
			this.btnBillingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillingList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillingList.ForeColor = System.Drawing.Color.Black;
			this.btnBillingList.Location = new System.Drawing.Point(223, 232);
			this.btnBillingList.Name = "btnBillingList";
			this.btnBillingList.Size = new System.Drawing.Size(196, 71);
			this.btnBillingList.TabIndex = 8;
			this.btnBillingList.Text = "ÖDEME LİSTELE";
			this.btnBillingList.UseVisualStyleBackColor = false;
			this.btnBillingList.Click += new System.EventHandler(this.btnBillingList_Click);
			// 
			// txtBillingPeriod
			// 
			this.txtBillingPeriod.Location = new System.Drawing.Point(259, 181);
			this.txtBillingPeriod.Name = "txtBillingPeriod";
			this.txtBillingPeriod.Size = new System.Drawing.Size(844, 22);
			this.txtBillingPeriod.TabIndex = 7;
			// 
			// lblBillingPeriod
			// 
			this.lblBillingPeriod.AutoSize = true;
			this.lblBillingPeriod.BackColor = System.Drawing.Color.Black;
			this.lblBillingPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillingPeriod.Location = new System.Drawing.Point(19, 177);
			this.lblBillingPeriod.Name = "lblBillingPeriod";
			this.lblBillingPeriod.Size = new System.Drawing.Size(188, 25);
			this.lblBillingPeriod.TabIndex = 6;
			this.lblBillingPeriod.Text = "ÖDEME DÖNEMİ:";
			// 
			// txtBillingAmount
			// 
			this.txtBillingAmount.Location = new System.Drawing.Point(259, 121);
			this.txtBillingAmount.Name = "txtBillingAmount";
			this.txtBillingAmount.Size = new System.Drawing.Size(880, 22);
			this.txtBillingAmount.TabIndex = 5;
			// 
			// lblBillingAmount
			// 
			this.lblBillingAmount.AutoSize = true;
			this.lblBillingAmount.BackColor = System.Drawing.Color.Black;
			this.lblBillingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillingAmount.Location = new System.Drawing.Point(19, 121);
			this.lblBillingAmount.Name = "lblBillingAmount";
			this.lblBillingAmount.Size = new System.Drawing.Size(181, 25);
			this.lblBillingAmount.TabIndex = 4;
			this.lblBillingAmount.Text = "ÖDEME TUTARI:";
			// 
			// txtBillingTitle
			// 
			this.txtBillingTitle.Location = new System.Drawing.Point(259, 69);
			this.txtBillingTitle.Name = "txtBillingTitle";
			this.txtBillingTitle.Size = new System.Drawing.Size(844, 22);
			this.txtBillingTitle.TabIndex = 3;
			// 
			// lblBillingTitle
			// 
			this.lblBillingTitle.AutoSize = true;
			this.lblBillingTitle.BackColor = System.Drawing.Color.Black;
			this.lblBillingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillingTitle.Location = new System.Drawing.Point(19, 65);
			this.lblBillingTitle.Name = "lblBillingTitle";
			this.lblBillingTitle.Size = new System.Drawing.Size(187, 25);
			this.lblBillingTitle.TabIndex = 2;
			this.lblBillingTitle.Text = "ÖDEME BAŞLIĞI:";
			// 
			// txtBillingId
			// 
			this.txtBillingId.Location = new System.Drawing.Point(259, 20);
			this.txtBillingId.Name = "txtBillingId";
			this.txtBillingId.Size = new System.Drawing.Size(844, 22);
			this.txtBillingId.TabIndex = 1;
			// 
			// lblBillingId
			// 
			this.lblBillingId.AutoSize = true;
			this.lblBillingId.BackColor = System.Drawing.Color.Black;
			this.lblBillingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillingId.Location = new System.Drawing.Point(19, 17);
			this.lblBillingId.Name = "lblBillingId";
			this.lblBillingId.Size = new System.Drawing.Size(124, 25);
			this.lblBillingId.TabIndex = 0;
			this.lblBillingId.Text = "ÖDEME ID:";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel3.Location = new System.Drawing.Point(276, 350);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1128, 400);
			this.panel3.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1128, 400);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnSpending
			// 
			this.btnSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpending.ForeColor = System.Drawing.Color.White;
			this.btnSpending.Location = new System.Drawing.Point(11, 99);
			this.btnSpending.Name = "btnSpending";
			this.btnSpending.Size = new System.Drawing.Size(243, 71);
			this.btnSpending.TabIndex = 9;
			this.btnSpending.Text = "GİDERLER";
			this.btnSpending.UseVisualStyleBackColor = true;
			this.btnSpending.Click += new System.EventHandler(this.btnSpending_Click);
			// 
			// btnBankProcess
			// 
			this.btnBankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBankProcess.ForeColor = System.Drawing.Color.White;
			this.btnBankProcess.Location = new System.Drawing.Point(11, 181);
			this.btnBankProcess.Name = "btnBankProcess";
			this.btnBankProcess.Size = new System.Drawing.Size(243, 71);
			this.btnBankProcess.TabIndex = 10;
			this.btnBankProcess.Text = "BANKA HAREKETLERİ";
			this.btnBankProcess.UseVisualStyleBackColor = true;
			this.btnBankProcess.Click += new System.EventHandler(this.btnBankProcess_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(11, 415);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(243, 71);
			this.btnLogin.TabIndex = 11;
			this.btnLogin.Text = "LOGİN";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// FrmBilling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(1407, 752);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Name = "FrmBilling";
			this.Text = "FrmBilling";
			this.Load += new System.EventHandler(this.FrmBilling_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnBanks;
		private System.Windows.Forms.Button btnCategories;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtBillingPeriod;
		private System.Windows.Forms.Label lblBillingPeriod;
		private System.Windows.Forms.TextBox txtBillingAmount;
		private System.Windows.Forms.Label lblBillingAmount;
		private System.Windows.Forms.TextBox txtBillingTitle;
		private System.Windows.Forms.Label lblBillingTitle;
		private System.Windows.Forms.TextBox txtBillingId;
		private System.Windows.Forms.Label lblBillingId;
		private System.Windows.Forms.Button btnBillingDelete;
		private System.Windows.Forms.Button btnBillingUpdate;
		private System.Windows.Forms.Button btnBillingAdd;
		private System.Windows.Forms.Button btnBillingList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSpending;
		private System.Windows.Forms.Button btnBankProcess;
		private System.Windows.Forms.Button btnLogin;
	}
}