namespace FinancialCrm
{
	partial class FrmLogin
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
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.btnEntry = new System.Windows.Forms.Button();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblLoginPage = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
			this.panel1.Controls.Add(this.txtUserName);
			this.panel1.Controls.Add(this.lblUserName);
			this.panel1.Controls.Add(this.btnEntry);
			this.panel1.Controls.Add(this.lblPassword);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Location = new System.Drawing.Point(1, 192);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1454, 346);
			this.panel1.TabIndex = 28;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(252, 69);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(911, 22);
			this.txtUserName.TabIndex = 15;
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
			this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblUserName.Location = new System.Drawing.Point(12, 65);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(173, 25);
			this.lblUserName.TabIndex = 14;
			this.lblUserName.Text = "KULLANICI ADI:";
			// 
			// btnEntry
			// 
			this.btnEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
			this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEntry.ForeColor = System.Drawing.Color.Black;
			this.btnEntry.Location = new System.Drawing.Point(545, 195);
			this.btnEntry.Name = "btnEntry";
			this.btnEntry.Size = new System.Drawing.Size(178, 71);
			this.btnEntry.TabIndex = 20;
			this.btnEntry.Text = "GİRİŞ YAP";
			this.btnEntry.UseVisualStyleBackColor = false;
			this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblPassword.Location = new System.Drawing.Point(12, 121);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(81, 25);
			this.lblPassword.TabIndex = 16;
			this.lblPassword.Text = "ŞİFRE:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(252, 121);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(911, 22);
			this.txtPassword.TabIndex = 17;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
			this.panel2.Controls.Add(this.lblLoginPage);
			this.panel2.Location = new System.Drawing.Point(1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1454, 194);
			this.panel2.TabIndex = 29;
			// 
			// lblLoginPage
			// 
			this.lblLoginPage.AutoSize = true;
			this.lblLoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
			this.lblLoginPage.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblLoginPage.Location = new System.Drawing.Point(475, 60);
			this.lblLoginPage.Name = "lblLoginPage";
			this.lblLoginPage.Size = new System.Drawing.Size(399, 73);
			this.lblLoginPage.TabIndex = 2;
			this.lblLoginPage.Text = "LOGİN SAYFASI";
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(1458, 741);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmLogin";
			this.Text = "FrmLogin";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Button btnEntry;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblLoginPage;
	}
}