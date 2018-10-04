using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depozit.Forms
{
	public partial class ShowAll : Form
	{
		public ShowAll()
		{
			InitializeComponent();
		}

		private void ShowAll_Load(object sender, EventArgs e)
		{
			using (DepozitDbEntities2 dbEntities=new DepozitDbEntities2())
			{
				dtgrid_show.DataSource = dbEntities.usp_People().ToList();
			}
		}
	}
}
