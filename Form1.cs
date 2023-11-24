using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaVolumeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Ensure that at least one radio button is selected
            if (!CylinderRadioButton.Checked && !SphereRadioButton.Checked && !ConeRadioButton.Checked)
            {
                MessageBox.Show("Please select a shape.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse input values
            if (!double.TryParse(RadiusTextBox.Text, out double radius) || !double.TryParse(HeightTextBox.Text, out double height))
            {
                MessageBox.Show("Please enter valid numeric values for Radius and Height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate Surface Area and Volume based on selected shape
            double surfaceArea = 0, volume = 0;

            if (CylinderRadioButton.Checked)
            {
                surfaceArea = 2 * Math.PI * radius * (radius + height);
                volume = Math.PI * Math.Pow(radius, 2) * height;
            }
            else if (SphereRadioButton.Checked)
            {
                surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
                volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            }
            else if (ConeRadioButton.Checked)
            {
                surfaceArea = Math.PI * radius * (radius + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius, 2)));
                volume = (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
            }

            // Display the results
            SurfaceAreaTextBox.Text = surfaceArea.ToString();
            VolumeTextBox.Text = volume.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all text boxes and radio buttons
            RadiusTextBox.Clear();
            HeightTextBox.Clear();
            SurfaceAreaTextBox.Clear();
            VolumeTextBox.Clear();
            CylinderRadioButton.Checked = false;
            SphereRadioButton.Checked = false;
            ConeRadioButton.Checked = false;
        }

    }
}
