namespace Depozit.Forms
{
	partial class ShowAll
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
			this.dtgrid_show = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dtgrid_show)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgrid_show
			// 
			this.dtgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgrid_show.Location = new System.Drawing.Point(36, 40);
			this.dtgrid_show.Name = "dtgrid_show";
			this.dtgrid_show.Size = new System.Drawing.Size(374, 260);
			this.dtgrid_show.TabIndex = 0;
			// 
			// ShowAll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 450);
			this.Controls.Add(this.dtgrid_show);
			this.Name = "ShowAll";
			this.Text = "ShowAll";
			this.Load += new System.EventHandler(this.ShowAll_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgrid_show)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgrid_show;
	}
}