using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VechicleAppPractice2.Model;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        Vehical vehical = new Vehical();

        List<double> speeds = new List<double>();

        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
            vehical.Name = vehicleNameTextBox.Text;
            vehical.RegistrationNo = regNoTextBox.Text;

            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(speedTextBox.Text))
            {
                    speeds.Add(Convert.ToDouble(speedTextBox.Text));
                    speedTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter speed");
                return;
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            vehicleNameTextBox.Text = vehical.Name;
            regNoTextBox.Text = vehical.RegistrationNo;

            minSpeedTextBox.Text = speeds.Min().ToString();
            maxSpeedTextBox.Text = speeds.Max().ToString();
            averageSpeedTextBox.Text = speeds.Average().ToString();
        }
    }
}
