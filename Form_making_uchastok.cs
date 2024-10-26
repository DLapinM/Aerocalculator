using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aerocalculator
{
    public partial class Form_making_uchastok : Form
    {
        public Form_making_uchastok()
        {
            InitializeComponent();

            radioButton_forma_rectangle.Checked = true;
            radioButton_forma_circle.Checked = false;

            comboBox_material_uchastka.Text = "листовая сталь";

            label_diameter_uchastka.Visible = false;
            numericUpDown_diametr_uchastka.Visible = false;

            label_shirina_uchastka.Visible = true;
            numericUpDown_shirina_uchastka.Visible = true;

            label_visota_uchastka.Visible = true;
            numericUpDown_visota_uchastka.Visible = true;
        }

        private void Form_making_uchastok_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_forma_rectangle_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_forma_circle.Checked = !radioButton_forma_rectangle.Checked;
            if (radioButton_forma_rectangle.Checked)
            {
                label_diameter_uchastka.Visible = false;
                numericUpDown_diametr_uchastka.Visible = false;

                label_shirina_uchastka.Visible = true;
                numericUpDown_shirina_uchastka.Visible = true;

                label_visota_uchastka.Visible = true;
                numericUpDown_visota_uchastka.Visible = true;
            }
            else
            {
                label_diameter_uchastka.Visible = true;
                numericUpDown_diametr_uchastka.Visible = true;

                label_shirina_uchastka.Visible = false;
                numericUpDown_shirina_uchastka.Visible = false;

                label_visota_uchastka.Visible = false;
                numericUpDown_visota_uchastka.Visible = false;
            }
        }

        private void radioButton_forma_circle_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_forma_rectangle.Checked = !radioButton_forma_circle.Checked;
        }

        private void button_create_uchastok_ok_Click(object sender, EventArgs e)
        {
            DataStatic.uchastok_rectangle_or_not = radioButton_forma_rectangle.Checked;
            DataStatic.uchastok_material = comboBox_material_uchastka.Text;
            DataStatic.uchastok_temperatura = (double)numericUpDown_temperatura_vozduha_na_uchastke.Value;
            DataStatic.uchastok_rashod_m3_in_hour = (double)numericUpDown_rashod_na_uchastke.Value;
            DataStatic.uchastok_dlina_m = (double)numericUpDown_dlina_uchastka.Value;
            DataStatic.uchastok_diameter_mm = (double)numericUpDown_diametr_uchastka.Value;
            DataStatic.uchastok_shirina_mm = (double)numericUpDown_shirina_uchastka.Value;
            DataStatic.uchastok_visota_mm = (double)numericUpDown_visota_uchastka.Value;
        }
    }
}
