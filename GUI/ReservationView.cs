using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace GUI
{
    public partial class ReservationView : Form
    {
        private List<String> reservationListString = new List<string>();
        
        public ReservationView()
        {
            InitializeComponent();
        }
        public void ViewInfo(ReservationForm reservationForm)
        {
            reservationListString = reservationForm.readData();
            reservationListBox.DataSource = reservationListString;

        }
    }
}
