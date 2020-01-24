using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using model;

namespace GUI
{
	public partial class StartVindow : Form
	{

		private ReservationForm rf;


		public StartVindow()
		{
			InitializeComponent();
			rf = new ReservationForm();

			cbPrincipal.Items.Add("Ninguna");
			cbPrincipal.Items.Add("Arroz Blanco");
			cbPrincipal.Items.Add("Arroz Ingegr");
			cbPrincipal.Items.Add("Arroz Mixto");
			cbPrincipal.Items.Add("Arroz con Pollo");

			cbProteine.Items.Add("Ninguna");
			cbProteine.Items.Add("Fillete a la Pancha - Res");
			cbProteine.Items.Add("Fillete a la Pancha - Pollo");
			cbProteine.Items.Add("Fillete a la Pancha - Pescado");
			cbProteine.Items.Add("Muchacho");
			cbProteine.Items.Add("Chuleta de Pollo");
			cbProteine.Items.Add("Pescado Frito");

			cbStartePlate.Items.Add("Ninguna");
			cbStartePlate.Items.Add("Pasta");
			cbStartePlate.Items.Add("Frijoles");
			cbStartePlate.Items.Add("Lentejas");
			cbStartePlate.Items.Add("Garbanzos");
			cbStartePlate.Items.Add("Blanquillo");

			cbSalad.Items.Add("Ninguna");
			cbSalad.Items.Add("Ensalada Verde");
			cbSalad.Items.Add("Ensalada Roja");
			cbSalad.Items.Add("Ensalada Dulce");

			cbSoup.Items.Add("Ninguna");
			cbSoup.Items.Add("Sancocho");
			cbSoup.Items.Add("Ajiaco");
			cbSoup.Items.Add("Trifasico");

			cbDrinck.Items.Add("Ninguna");
			cbDrinck.Items.Add("Limonada");
			cbDrinck.Items.Add("Jugo de Mora");
			cbDrinck.Items.Add("Jugo de lulo");
		}	
			
		private void btSave_Click(object sender, EventArgs e)
		{
			
		}

		private void btLoad_Click(object sender, EventArgs e)
		{

		}
	}
}
