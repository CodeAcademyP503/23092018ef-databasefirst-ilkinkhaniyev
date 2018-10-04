namespace Depozit.Forms
{
	partial class AddDepozit
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
			this.lbl_addName = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lbl_date = new System.Windows.Forms.Label();
			this.txbx_addprice = new System.Windows.Forms.TextBox();
			this.lbl_addprice = new System.Windows.Forms.Label();
			this.btn_add = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_addName
			// 
			this.lbl_addName.AutoSize = true;
			this.lbl_addName.Location = new System.Drawing.Point(55, 46);
			this.lbl_addName.Name = "lbl_addName";
			this.lbl_addName.Size = new System.Drawing.Size(61, 24);
			this.lbl_addName.TabIndex = 1;
			this.lbl_addName.Text = "Name";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "YYYY-MM-dd";
			this.dateTimePicker1.Location = new System.Drawing.Point(221, 92);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(333, 29);
			this.dateTimePicker1.TabIndex = 2;
			this.dateTimePicker1.Value = new System.DateTime(2018, 9, 23, 0, 0, 0, 0);
			// 
			// lbl_date
			// 
			this.lbl_date.AutoSize = true;
			this.lbl_date.Location = new System.Drawing.Point(55, 92);
			this.lbl_date.Name = "lbl_date";
			this.lbl_date.Size = new System.Drawing.Size(136, 24);
			this.lbl_date.TabIndex = 1;
			this.lbl_date.Text = "Date of Depozit";
			// 
			// txbx_addprice
			// 
			this.txbx_addprice.Location = new System.Drawing.Point(221, 141);
			this.txbx_addprice.Name = "txbx_addprice";
			this.txbx_addprice.Size = new System.Drawing.Size(239, 29);
			this.txbx_addprice.TabIndex = 4;
			// 
			// lbl_addprice
			// 
			this.lbl_addprice.AutoSize = true;
			this.lbl_addprice.Location = new System.Drawing.Point(59, 141);
			this.lbl_addprice.Name = "lbl_addprice";
			this.lbl_addprice.Size = new System.Drawing.Size(53, 24);
			this.lbl_addprice.TabIndex = 3;
			this.lbl_addprice.Text = "Price";
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(386, 216);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(135, 41);
			this.btn_add.TabIndex = 5;
			this.btn_add.Text = "Add";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(446, 274);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 33);
			this.button1.TabIndex = 6;
			this.button1.Text = "Show";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AddDepozit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 319);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.txbx_addprice);
			this.Controls.Add(this.lbl_addprice);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.lbl_date);
			this.Controls.Add(this.lbl_addName);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "AddDepozit";
			this.Text = "AddDepozit";
			this.Load += new System.EventHandler(this.AddDepozit_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_addName;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lbl_date;
		private System.Windows.Forms.TextBox txbx_addprice;
		private System.Windows.Forms.Label lbl_addprice;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button button1;
	}
}