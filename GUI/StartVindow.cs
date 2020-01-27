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
		private const int NUMBER_FIELDS = 6;

		private ReservationForm rf;

		private List<String> listData;
		private int numberFieldsSelected;
		private int numberDishesSelected;


		public StartVindow()
		{
			InitializeComponent();
			this.rf = new ReservationForm();
			this.listData = new List<string>();
			this.numberFieldsSelected = 0;
			this.numberDishesSelected = 0;
			
			cbTypeRice.Items.Add("Ninguna");
			cbTypeRice.Items.Add("Arroz Blanco");
			cbTypeRice.Items.Add("Arroz Integral");
			cbTypeRice.Items.Add("Arroz Mixto");
			cbTypeRice.Items.Add("Arroz con Pollo");

			cbProtein.Items.Add("Ninguna");
			cbProtein.Items.Add("Fillete de Res");
			cbProtein.Items.Add("Fillete de Pollo");
			cbProtein.Items.Add("Fillete de Pescado");
			cbProtein.Items.Add("Muchacho");
			cbProtein.Items.Add("Milanesa de Pollo");
			cbProtein.Items.Add("Pescado Frito");

			cbStarterPlate.Items.Add("Ninguna");
			cbStarterPlate.Items.Add("Pasta");
			cbStarterPlate.Items.Add("Frijoles");
			cbStarterPlate.Items.Add("Lentejas");
			cbStarterPlate.Items.Add("Garbanzos");
			cbStarterPlate.Items.Add("Blanquillo");

			cbSalad.Items.Add("Ninguna");
			cbSalad.Items.Add("Ensalada Verde");
			cbSalad.Items.Add("Ensalada Roja");
			cbSalad.Items.Add("Ensalada Dulce");

			cbSoup.Items.Add("Ninguna");
			cbSoup.Items.Add("Sancocho");
			cbSoup.Items.Add("Ajiaco");
			cbSoup.Items.Add("Trifasico");

			cbDrink.Items.Add("Ninguna");
			cbDrink.Items.Add("Limonada");
			cbDrink.Items.Add("Jugo de Mora");
			cbDrink.Items.Add("Jugo de lulo");
		}	
			
		private void btSave_Click(object sender, EventArgs e)
		{
			
			if (!validateStudenCode())
			{
				groupData();

				if ((this.listData.Count > 0 && this.numberFieldsSelected == NUMBER_FIELDS) && numberDishesSelected > 0)
				{
					listData.Add("=======================");
					this.rf.writeData(listData);
					resetFields();
					
				}
				else
				{
					MessageBox.Show("Para continuar, todos los espacios deben esar llenados y al menos una comida seleccionada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Para realizar un pedido se debe registrar el codigo institucional", "ERROR", MessageBoxButtons.OK,  MessageBoxIcon.Error);
			}
		}

		private void btLoad_Click(object sender, EventArgs e)
		{
			resetFields();
			ReservationView reservation = new ReservationView();
			reservation.Show();
			reservation.ViewInfo(rf);
		}


		private Boolean validateStudenCode()
		{
			return tbCode.Text.Equals("");
		}

		private void validateTypeRice()
		{
			if (cbTypeRice.SelectedItem != null)
			{
				this.numberFieldsSelected++;
				this.listData.Add(cbTypeRice.SelectedItem.ToString());

				if (!cbTypeRice.SelectedItem.Equals("Ninguna"))
				{
					numberDishesSelected++;
				}
			}
		}

		private void validateProtein()
		{
			if (cbProtein.SelectedItem != null)
			{
				this.numberFieldsSelected++;
				this.listData.Add(cbProtein.SelectedItem.ToString());

				if (!cbProtein.SelectedItem.Equals("Ninguna"))
				{
					numberDishesSelected++;
				}
			}
		}

		private void validateStarterPlate()
		{
			if (cbStarterPlate.SelectedItem != null)
			{
				this.numberFieldsSelected++;
				this.listData.Add(cbStarterPlate.SelectedItem.ToString());

				if (!cbStarterPlate.SelectedItem.Equals("Ninguna"))
				{
					numberDishesSelected++;
				}
			}
		}

		private void validateSalad()
		{
			if (cbSalad.SelectedItem != null)
			{
				this.numberFieldsSelected++;
				this.listData.Add(cbSalad.SelectedItem.ToString());

				if (!cbSalad.SelectedItem.Equals("Ninguna"))
				{
					numberDishesSelected++;
				}
			}
		}

		private void validateSoup()
		{
			if (cbSoup.SelectedItem != null)
			{
				this.numberFieldsSelected++;
				this.listData.Add(cbSoup.SelectedItem.ToString());

				if (!cbSoup.SelectedItem.Equals("Ninguna"))
				{
					numberDishesSelected++;
				}
			}
		}

		private void validateDrink()
		{
			if (cbDrink.SelectedItem != null)
			{
				this.numberFieldsSelected++;
				this.listData.Add(cbDrink.SelectedItem.ToString());

				if (!cbDrink.SelectedItem.Equals("Ninguna"))
				{
					numberDishesSelected++;
				}
			}
		}

		private void groupData()
		{
			this.listData.Clear();
			listData.Add("=======================");
			this.numberFieldsSelected = 0;

			this.listData.Add("Código: " + tbCode.Text);
			validateTypeRice();
			validateProtein();
			validateStarterPlate();
			validateSoup();
			validateSalad();
			validateDrink();
		}

		private void resetFields()
		{
			tbCode.Clear();

			cbTypeRice.SelectedItem = null;
			cbTypeRice.Text = "Seleccione una opcion";

			cbProtein.SelectedItem = null;
			cbProtein.Text = "Seleccione una opcion";

			cbStarterPlate.SelectedItem = null;
			cbStarterPlate.Text = "Seleccione una opcion";

			cbSoup.SelectedItem = null;
			cbSoup.Text = "Seleccione una opcion";

			cbSalad.SelectedItem = null;
			cbSalad.Text = "Seleccione una opcion";

			cbDrink.SelectedItem = null;
			cbDrink.Text = "Seleccione una opcion";
		}
	}
}
