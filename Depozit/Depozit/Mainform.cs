using Depozit.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depozit
{
	public partial class Mainform : Form
	{
		public Mainform()
		{
			InitializeComponent();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			using (DepozitDbEntities2 db=new DepozitDbEntities2())
			{
				db.People.Add(new Person()
				{
					Name = txbx_name.Text,
					Surname = txbx_surname.Text
				});

				db.SaveChanges();
			}
			new AddDepozit().ShowDialog();
			
		}
	}
}
