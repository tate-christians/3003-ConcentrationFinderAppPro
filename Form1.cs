using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3003_ConcentrationFinderAppPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtb_bc_concentrationInput_TextChanged(object sender, EventArgs e)
        {
            txtb_bc_concentrationConverted.Text = txtb_bc_concentrationInput.Text;
        }

        private void cmbo_bc_volume_SelectionChangeCommitted(object sender, EventArgs e)
        {
            double convertedVolume = 0f;
            bool convertable;
            switch (cmbo_bc_volume.SelectedIndex)
            {
                case 0:
                    // mL
                    convertable = double.TryParse(txtb_bc_volumeInput.Text, out convertedVolume);
                    if (convertable)
                    {
                        convertedVolume /= 1000;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_volume, "Invalid Format");
                    }
                    break;
                case 1:
                    // L
                    convertable = double.TryParse(txtb_bc_volumeInput.Text, out convertedVolume);
                    if (convertable)
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_volume, "Invalid Format");
                    }
                    break;
                case 2:
                    // cm^3
                    convertable = double.TryParse(txtb_bc_volumeInput.Text, out convertedVolume);
                    if (convertable)
                    {
                        convertedVolume /= 1000;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_volume, "Invalid Format");
                    }
                    break;
                case 3:
                    // m^3
                    convertable = double.TryParse(txtb_bc_volumeInput.Text, out convertedVolume);
                    if (convertable)
                    {
                        convertedVolume *= 1000;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_volume, "Invalid Format");
                    }
                    break;
                case 4:
                    // G
                    convertable = double.TryParse(txtb_bc_volumeInput.Text, out convertedVolume);
                    if (convertable)
                    {
                        convertedVolume *= 3.78541;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_volume, "Invalid Format");
                    }
                    break;
                default:
                    break;
            }
            txtb_bc_volumeConverted.Text = convertedVolume.ToString();
        }

        private void btn_bc_calculateMass_Click(object sender, EventArgs e)
        {
            if (txtb_bc_volumeConverted.Text != "" && txtb_bc_concentrationConverted.Text != "")
            {
                double volume = Convert.ToDouble(txtb_bc_volumeConverted.Text);
                double concentration = Convert.ToDouble(txtb_bc_concentrationConverted.Text);
                double mass = volume * concentration;
                txtb_bc_calculatedMass.Text = mass.ToString();
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(label2, "Fill out other sections");
            }
        }

        private void cmbo_bc_mass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            double convertedMass = 0f;
            bool convertable;
            switch (cmbo_bc_mass.SelectedIndex)
            {
                case 0:
                    // ng
                    convertable = double.TryParse(txtb_bc_massInput.Text, out convertedMass);
                    if (convertable)
                    {
                        convertedMass /= 1000000;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_mass, "Invalid Format");
                    }
                    break;
                case 1:
                    // ug
                    convertable = double.TryParse(txtb_bc_massInput.Text, out convertedMass);
                    if (convertable)
                    {
                        convertedMass /= 1000;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_mass, "Invalid Format");
                    }
                    break;
                case 2:
                    // mg
                    convertable = double.TryParse(txtb_bc_massInput.Text, out convertedMass);
                    if (convertable)
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_mass, "Invalid Format");
                    }
                    break;
                case 3:
                    // g
                    convertable = double.TryParse(txtb_bc_massInput.Text, out convertedMass);
                    if (convertable)
                    {
                        convertedMass *= 1000;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_mass, "Invalid Format");
                    }
                    break;
                case 4:
                    // kg
                    convertable = double.TryParse(txtb_bc_massInput.Text, out convertedMass);
                    if (convertable)
                    {
                        convertedMass *= 1000000;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_mass, "Invalid Format");
                    }
                    break;
                case 5:
                    // lb
                    convertable = double.TryParse(txtb_bc_massInput.Text, out convertedMass);
                    if (convertable)
                    {
                        convertedMass *= 453592;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(cmbo_bc_mass, "Invalid Format");
                    }
                    break;
                default:
                    break;

            }
            txtb_bc_massConverted.Text = convertedMass.ToString();
        }

        private void btn_bc_calculateVolume_Click(object sender, EventArgs e)
        {
            if (txtb_bc_massConverted.Text != "" && txtb_bc_concentrationConverted.Text != "")
            {
                double mass = Convert.ToDouble(txtb_bc_massConverted.Text);
                double concentration = Convert.ToDouble(txtb_bc_concentrationConverted.Text);
                double volume = mass / concentration;
                txtb_bc_calculatedVolume.Text = volume.ToString();
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(label6, "Fill out other sections");
            }
        }

        private void btn_bc_calculateConcentration_Click(object sender, EventArgs e)
        {
            if (txtb_bc_massConverted.Text != "" && txtb_bc_volumeConverted.Text != "")
            {
                double mass = Convert.ToDouble(txtb_bc_massConverted.Text);
                double volume = Convert.ToDouble(txtb_bc_volumeConverted.Text);
                double concentration = mass / volume;
                txtb_bc_calculatedConcentration.Text = volume.ToString();
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(label7, "Fill out other sections");
            }
        }
    }
}
