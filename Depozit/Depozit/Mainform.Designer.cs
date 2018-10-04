namespace Depozit
{
	partial class Mainform
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
			this.lbl_name = new System.Windows.Forms.Label();
			this.txbx_name = new System.Windows.Forms.TextBox();
			this.lbl_surname = new System.Windows.Forms.Label();
			this.txbx_surname = new System.Windows.Forms.TextBox();
			this.btn_save = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.Location = new System.Drawing.Point(35, 54);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(61, 24);
			this.lbl_name.TabIndex = 0;
			this.lbl_name.Text = "Name";
			// 
			// txbx_name
			// 
			this.txbx_name.Location = new System.Drawing.Point(144, 57);
			this.txbx_name.Name = "txbx_name";
			this.txbx_name.Size = new System.Drawing.Size(239, 29);
			this.txbx_name.TabIndex = 1;
			// 
			// lbl_surname
			// 
			this.lbl_surname.AutoSize = true;
			this.lbl_surname.Location = new System.Drawing.Point(35, 115);
			this.lbl_surname.Name = "lbl_surname";
			this.lbl_surname.Size = new System.Drawing.Size(87, 24);
			this.lbl_surname.TabIndex = 0;
			this.lbl_surname.Text = "Surname";
			// 
			// txbx_surname
			// 
			this.txbx_surname.Location = new System.Drawing.Point(144, 118);
			this.txbx_surname.Name = "txbx_surname";
			this.txbx_surname.Size = new System.Drawing.Size(239, 29);
			this.txbx_surname.TabIndex = 1;
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(251, 202);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(123, 39);
			this.btn_save.TabIndex = 2;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// Mainform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 335);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.txbx_surname);
			this.Controls.Add(this.lbl_surname);
			this.Controls.Add(this.txbx_name);
			this.Controls.Add(this.lbl_name);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Mainform";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.TextBox txbx_name;
		private System.Windows.Forms.Label lbl_surname;
		private System.Windows.Forms.TextBox txbx_surname;
		private System.Windows.Forms.Button btn_save;
	}
}

