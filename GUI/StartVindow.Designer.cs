using System;

namespace GUI
{
	partial class StartVindow
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.cbTypeRice = new System.Windows.Forms.ComboBox();
            this.cbSalad = new System.Windows.Forms.ComboBox();
            this.cbStarterPlate = new System.Windows.Forms.ComboBox();
            this.cbProtein = new System.Windows.Forms.ComboBox();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.cbSoup = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bebida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sopa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ensalada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Principio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Proteína";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Arroz";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(133, 60);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(182, 20);
            this.tbCode.TabIndex = 7;
            // 
            // cbTypeRice
            // 
            this.cbTypeRice.FormattingEnabled = true;
            this.cbTypeRice.Location = new System.Drawing.Point(133, 98);
            this.cbTypeRice.Name = "cbTypeRice";
            this.cbTypeRice.Size = new System.Drawing.Size(182, 21);
            this.cbTypeRice.TabIndex = 8;
            this.cbTypeRice.Text = "Seleccione una opcion";
            // 
            // cbSalad
            // 
            this.cbSalad.FormattingEnabled = true;
            this.cbSalad.Location = new System.Drawing.Point(133, 219);
            this.cbSalad.Name = "cbSalad";
            this.cbSalad.Size = new System.Drawing.Size(182, 21);
            this.cbSalad.TabIndex = 9;
            this.cbSalad.Text = "Seleccione una opcion";
            // 
            // cbStarterPlate
            // 
            this.cbStarterPlate.FormattingEnabled = true;
            this.cbStarterPlate.Location = new System.Drawing.Point(133, 178);
            this.cbStarterPlate.Name = "cbStarterPlate";
            this.cbStarterPlate.Size = new System.Drawing.Size(182, 21);
            this.cbStarterPlate.TabIndex = 10;
            this.cbStarterPlate.Text = "Seleccione una opcion";
            // 
            // cbProtein
            // 
            this.cbProtein.FormattingEnabled = true;
            this.cbProtein.Location = new System.Drawing.Point(133, 138);
            this.cbProtein.Name = "cbProtein";
            this.cbProtein.Size = new System.Drawing.Size(182, 21);
            this.cbProtein.TabIndex = 11;
            this.cbProtein.Text = "Seleccione una opcion";
            // 
            // cbDrink
            // 
            this.cbDrink.FormattingEnabled = true;
            this.cbDrink.Location = new System.Drawing.Point(133, 292);
            this.cbDrink.Name = "cbDrink";
            this.cbDrink.Size = new System.Drawing.Size(182, 21);
            this.cbDrink.TabIndex = 12;
            this.cbDrink.Text = "Seleccione una opcion";
            // 
            // cbSoup
            // 
            this.cbSoup.FormattingEnabled = true;
            this.cbSoup.Location = new System.Drawing.Point(133, 256);
            this.cbSoup.Name = "cbSoup";
            this.cbSoup.Size = new System.Drawing.Size(182, 21);
            this.cbSoup.TabIndex = 13;
            this.cbSoup.Text = "Seleccione una opcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Aplicación de Reservas de Almuerzos";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(53, 352);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "Guardar";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(240, 352);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 16;
            this.btLoad.Text = "Cargar";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // StartVindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 392);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSoup);
            this.Controls.Add(this.cbDrink);
            this.Controls.Add(this.cbProtein);
            this.Controls.Add(this.cbStarterPlate);
            this.Controls.Add(this.cbSalad);
            this.Controls.Add(this.cbTypeRice);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartVindow";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbCode;
		private System.Windows.Forms.ComboBox cbTypeRice;
		private System.Windows.Forms.ComboBox cbSalad;
		private System.Windows.Forms.ComboBox cbStarterPlate;
		private System.Windows.Forms.ComboBox cbProtein;
		private System.Windows.Forms.ComboBox cbDrink;
		private System.Windows.Forms.ComboBox cbSoup;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btLoad;

    }
}

