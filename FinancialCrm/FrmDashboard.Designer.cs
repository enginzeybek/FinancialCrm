namespace FinancialCrm
{
	partial class FrmDashboard
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblBillAmount = new System.Windows.Forms.Label();
			this.lblBillTitle = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblIncomingAmount = new System.Windows.Forms.Label();
			this.lblLastIncoming = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblTotalBalanceShow = new System.Windows.Forms.Label();
			this.lblTotalBalance = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblDashboard = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnBills = new System.Windows.Forms.Button();
			this.btnBanks = new System.Windows.Forms.Button();
			this.btnCategories = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lblDescription2 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lblDescription1 = new System.Windows.Forms.Label();
			this.btnSpending = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnBankProcess = new System.Windows.Forms.Button();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.panel4.Controls.Add(this.lblBillAmount);
			this.panel4.Controls.Add(this.lblBillTitle);
			this.panel4.Location = new System.Drawing.Point(658, 99);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(381, 204);
			this.panel4.TabIndex = 6;
			// 
			// lblBillAmount
			// 
			this.lblBillAmount.AutoSize = true;
			this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillAmount.ForeColor = System.Drawing.Color.White;
			this.lblBillAmount.Location = new System.Drawing.Point(105, 76);
			this.lblBillAmount.Name = "lblBillAmount";
			this.lblBillAmount.Size = new System.Drawing.Size(181, 73);
			this.lblBillAmount.TabIndex = 6;
			this.lblBillAmount.Text = "0,00 ₺";
			// 
			// lblBillTitle
			// 
			this.lblBillTitle.AutoSize = true;
			this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillTitle.ForeColor = System.Drawing.Color.White;
			this.lblBillTitle.Location = new System.Drawing.Point(23, 22);
			this.lblBillTitle.Name = "lblBillTitle";
			this.lblBillTitle.Size = new System.Drawing.Size(142, 24);
			this.lblBillTitle.TabIndex = 5;
			this.lblBillTitle.Text = "FATURA BAŞLIĞI";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.panel5.Controls.Add(this.lblIncomingAmount);
			this.panel5.Controls.Add(this.lblLastIncoming);
			this.panel5.Location = new System.Drawing.Point(1045, 99);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(374, 204);
			this.panel5.TabIndex = 7;
			// 
			// lblIncomingAmount
			// 
			this.lblIncomingAmount.AutoSize = true;
			this.lblIncomingAmount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblIncomingAmount.ForeColor = System.Drawing.Color.White;
			this.lblIncomingAmount.Location = new System.Drawing.Point(82, 76);
			this.lblIncomingAmount.Name = "lblIncomingAmount";
			this.lblIncomingAmount.Size = new System.Drawing.Size(181, 73);
			this.lblIncomingAmount.TabIndex = 6;
			this.lblIncomingAmount.Text = "0,00 ₺";
			// 
			// lblLastIncoming
			// 
			this.lblLastIncoming.AutoSize = true;
			this.lblLastIncoming.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblLastIncoming.ForeColor = System.Drawing.Color.White;
			this.lblLastIncoming.Location = new System.Drawing.Point(28, 22);
			this.lblLastIncoming.Name = "lblLastIncoming";
			this.lblLastIncoming.Size = new System.Drawing.Size(175, 24);
			this.lblLastIncoming.TabIndex = 5;
			this.lblLastIncoming.Text = "GELEN SON HAVALE";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
			this.panel3.Controls.Add(this.lblTotalBalanceShow);
			this.panel3.Controls.Add(this.lblTotalBalance);
			this.panel3.Location = new System.Drawing.Point(289, 99);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(363, 204);
			this.panel3.TabIndex = 10;
			// 
			// lblTotalBalanceShow
			// 
			this.lblTotalBalanceShow.AutoSize = true;
			this.lblTotalBalanceShow.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotalBalanceShow.ForeColor = System.Drawing.Color.White;
			this.lblTotalBalanceShow.Location = new System.Drawing.Point(79, 76);
			this.lblTotalBalanceShow.Name = "lblTotalBalanceShow";
			this.lblTotalBalanceShow.Size = new System.Drawing.Size(181, 73);
			this.lblTotalBalanceShow.TabIndex = 4;
			this.lblTotalBalanceShow.Text = "0,00 ₺";
			// 
			// lblTotalBalance
			// 
			this.lblTotalBalance.AutoSize = true;
			this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
			this.lblTotalBalance.Location = new System.Drawing.Point(22, 22);
			this.lblTotalBalance.Name = "lblTotalBalance";
			this.lblTotalBalance.Size = new System.Drawing.Size(145, 24);
			this.lblTotalBalance.TabIndex = 3;
			this.lblTotalBalance.Text = "TOPLAM BAKİYE";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.lblDashboard);
			this.panel2.Location = new System.Drawing.Point(2, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1418, 92);
			this.panel2.TabIndex = 9;
			// 
			// lblDashboard
			// 
			this.lblDashboard.AutoSize = true;
			this.lblDashboard.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDashboard.Location = new System.Drawing.Point(40, 32);
			this.lblDashboard.Name = "lblDashboard";
			this.lblDashboard.Size = new System.Drawing.Size(361, 28);
			this.lblDashboard.TabIndex = 2;
			this.lblDashboard.Text = "DASHBOARD / GENEL BAKIŞ FORMU";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.panel1.Controls.Add(this.btnBankProcess);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.btnSpending);
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.btnBills);
			this.panel1.Controls.Add(this.btnBanks);
			this.panel1.Controls.Add(this.btnCategories);
			this.panel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.panel1.Location = new System.Drawing.Point(2, 99);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(281, 642);
			this.panel1.TabIndex = 8;
			// 
			// btnExit
			// 
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Location = new System.Drawing.Point(21, 472);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(243, 71);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "ÇIKIŞ YAP";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnBills
			// 
			this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBills.ForeColor = System.Drawing.Color.White;
			this.btnBills.Location = new System.Drawing.Point(21, 91);
			this.btnBills.Name = "btnBills";
			this.btnBills.Size = new System.Drawing.Size(243, 71);
			this.btnBills.TabIndex = 2;
			this.btnBills.Text = "FATURALAR";
			this.btnBills.UseVisualStyleBackColor = true;
			this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
			// 
			// btnBanks
			// 
			this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBanks.ForeColor = System.Drawing.Color.White;
			this.btnBanks.Location = new System.Drawing.Point(21, 245);
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
			this.btnCategories.Location = new System.Drawing.Point(21, 13);
			this.btnCategories.Name = "btnCategories";
			this.btnCategories.Size = new System.Drawing.Size(243, 71);
			this.btnCategories.TabIndex = 0;
			this.btnCategories.Text = "KATEGORİLER";
			this.btnCategories.UseVisualStyleBackColor = true;
			this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// chart1
			// 
			chartArea7.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea7);
			legend7.Name = "Legend1";
			this.chart1.Legends.Add(legend7);
			this.chart1.Location = new System.Drawing.Point(289, 408);
			this.chart1.Name = "chart1";
			series7.ChartArea = "ChartArea1";
			series7.Legend = "Legend1";
			series7.Name = "Series1";
			this.chart1.Series.Add(series7);
			this.chart1.Size = new System.Drawing.Size(552, 328);
			this.chart1.TabIndex = 7;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			chartArea8.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea8);
			legend8.Name = "Legend1";
			this.chart2.Legends.Add(legend8);
			this.chart2.Location = new System.Drawing.Point(856, 408);
			this.chart2.Name = "chart2";
			series8.ChartArea = "ChartArea1";
			series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series8.Legend = "Legend1";
			series8.Name = "Series1";
			this.chart2.Series.Add(series8);
			this.chart2.Size = new System.Drawing.Size(552, 325);
			this.chart2.TabIndex = 11;
			this.chart2.Text = "chart2";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
			this.panel6.Controls.Add(this.lblDescription2);
			this.panel6.Location = new System.Drawing.Point(856, 309);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(552, 100);
			this.panel6.TabIndex = 12;
			// 
			// lblDescription2
			// 
			this.lblDescription2.AutoSize = true;
			this.lblDescription2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDescription2.ForeColor = System.Drawing.Color.Black;
			this.lblDescription2.Location = new System.Drawing.Point(29, 33);
			this.lblDescription2.Name = "lblDescription2";
			this.lblDescription2.Size = new System.Drawing.Size(489, 35);
			this.lblDescription2.TabIndex = 6;
			this.lblDescription2.Text = "ÖDENMESİ GEREKEN FATURA TUTARLARI\r\n";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
			this.panel7.Controls.Add(this.lblDescription1);
			this.panel7.Location = new System.Drawing.Point(289, 309);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(552, 100);
			this.panel7.TabIndex = 0;
			// 
			// lblDescription1
			// 
			this.lblDescription1.AutoSize = true;
			this.lblDescription1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDescription1.ForeColor = System.Drawing.Color.Black;
			this.lblDescription1.Location = new System.Drawing.Point(9, 33);
			this.lblDescription1.Name = "lblDescription1";
			this.lblDescription1.Size = new System.Drawing.Size(525, 35);
			this.lblDescription1.TabIndex = 5;
			this.lblDescription1.Text = "BANKA HESAPLARINDAKİ PARA MİKTARLARI";
			// 
			// btnSpending
			// 
			this.btnSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpending.ForeColor = System.Drawing.Color.White;
			this.btnSpending.Location = new System.Drawing.Point(21, 168);
			this.btnSpending.Name = "btnSpending";
			this.btnSpending.Size = new System.Drawing.Size(243, 71);
			this.btnSpending.TabIndex = 9;
			this.btnSpending.Text = "GİDERLER";
			this.btnSpending.UseVisualStyleBackColor = true;
			this.btnSpending.Click += new System.EventHandler(this.btnSpending_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(21, 399);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(243, 71);
			this.btnLogin.TabIndex = 11;
			this.btnLogin.Text = "LOGİN";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnBankProcess
			// 
			this.btnBankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBankProcess.ForeColor = System.Drawing.Color.White;
			this.btnBankProcess.Location = new System.Drawing.Point(21, 322);
			this.btnBankProcess.Name = "btnBankProcess";
			this.btnBankProcess.Size = new System.Drawing.Size(243, 71);
			this.btnBankProcess.TabIndex = 12;
			this.btnBankProcess.Text = "BANKA HAREKETLERİ";
			this.btnBankProcess.UseVisualStyleBackColor = true;
			this.btnBankProcess.Click += new System.EventHandler(this.btnBankProcess_Click);
			// 
			// FrmDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1420, 748);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmDashboard";
			this.Text = "Dashbord Form";
			this.Load += new System.EventHandler(this.FrmDashboard_Load);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblBillAmount;
		private System.Windows.Forms.Label lblBillTitle;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lblIncomingAmount;
		private System.Windows.Forms.Label lblLastIncoming;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblTotalBalanceShow;
		private System.Windows.Forms.Label lblTotalBalance;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblDashboard;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnBills;
		private System.Windows.Forms.Button btnBanks;
		private System.Windows.Forms.Button btnCategories;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label lblDescription1;
		private System.Windows.Forms.Label lblDescription2;
		private System.Windows.Forms.Button btnSpending;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnBankProcess;
	}
}

