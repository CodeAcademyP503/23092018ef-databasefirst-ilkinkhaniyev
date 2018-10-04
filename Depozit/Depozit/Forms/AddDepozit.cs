using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depozit.Forms
{
	public partial class AddDepozit : Form
	{
		public AddDepozit()
		{
			InitializeComponent();
		}
		Person person;
		private void AddDepozit_Load(object sender, EventArgs e)
		{
			using (DepozitDbEntities2 dbEntities=new DepozitDbEntities2())
			{
				person = dbEntities.People.ToList().LastOrDefault();
				lbl_addName.Text = person.Name;
			}
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			using (DepozitDbEntities2 dbEntities=new DepozitDbEntities2())
			{
				decimal price; 
				Decimal.TryParse(txbx_addprice.Text, out price);
				if (price!=0)
				{
					dbEntities.Credits.Add(new Credit()
					{
						Price = price,
						 Date_of_Credit=dateTimePicker1.Value,
						  People_Id=person.Id,
						   Person=person
					});
					dbEntities.SaveChanges();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new ShowAll().ShowDialog();
		}
	}
}
