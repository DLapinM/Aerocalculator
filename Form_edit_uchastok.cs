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
    public partial class Form_edit_uchastok : Form
    {
        public Form_edit_uchastok()
        {
            InitializeComponent();

            if (DataStatic.uchastok_rectangle_or_not)
            {
                numericUpDown_shirina_edit_uchastok.Value = (decimal)DataStatic.uchastok_shirina_mm;
                numericUpDown_visota_edit_uchastok.Value = (decimal)DataStatic.uchastok_visota_mm;

                numericUpDown_diametr_edit_uchastok.Value = 100;

                radioButton_forma_priamougolnaia_edit_uchastok.Checked = true;
                radioButton_forma_kruglaia_edit_uchastok.Checked = false;

                label_diameter_edit_uchastok.Visible = false;
                numericUpDown_diametr_edit_uchastok.Visible = false;

                label_shirina_edit_uchastok.Visible = true;
                numericUpDown_shirina_edit_uchastok.Visible = true;

                label_visota_edit_uchastok.Visible = true;
                numericUpDown_visota_edit_uchastok.Visible = true;
            }
            else
            {
                numericUpDown_diametr_edit_uchastok.Value = (decimal)DataStatic.uchastok_diameter_mm;

                numericUpDown_shirina_edit_uchastok.Value = 100;
                numericUpDown_visota_edit_uchastok.Value = 100;

                radioButton_forma_kruglaia_edit_uchastok.Checked = true;
                radioButton_forma_priamougolnaia_edit_uchastok.Checked = false;

                label_diameter_edit_uchastok.Visible = true;
                numericUpDown_diametr_edit_uchastok.Visible = true;

                label_shirina_edit_uchastok.Visible = false;
                numericUpDown_shirina_edit_uchastok.Visible = false;

                label_visota_edit_uchastok.Visible = false;
                numericUpDown_visota_edit_uchastok.Visible = false;
            }

            comboBox_material_edit_uchastok.Text = DataStatic.uchastok_material;
            numericUpDown_temperatura_edit_uchastok.Value = (decimal)DataStatic.uchastok_temperatura;
            numericUpDown_rashod_edit_uchastok.Value = (decimal)DataStatic.uchastok_rashod_m3_in_hour;
            numericUpDown_dlina_edit_uchastok.Value = (decimal)DataStatic.uchastok_dlina_m;
        }

        private void radioButton_forma_kruglaia_edit_uchastok_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_forma_kruglaia_edit_uchastok.Checked)
            {
                label_diameter_edit_uchastok.Visible = true;
                numericUpDown_diametr_edit_uchastok.Visible = true;

                label_shirina_edit_uchastok.Visible = false;
                numericUpDown_shirina_edit_uchastok.Visible = false;

                label_visota_edit_uchastok.Visible = false;
                numericUpDown_visota_edit_uchastok.Visible = false;
            }
            else
            {
                label_diameter_edit_uchastok.Visible = false;
                numericUpDown_diametr_edit_uchastok.Visible = false;

                label_shirina_edit_uchastok.Visible = true;
                numericUpDown_shirina_edit_uchastok.Visible = true;

                label_visota_edit_uchastok.Visible = true;
                numericUpDown_visota_edit_uchastok.Visible = true;
            }
        }

        private void button_edit_uchastok_ok_Click(object sender, EventArgs e)
        {
            DataStatic.uchastok_rectangle_or_not = radioButton_forma_priamougolnaia_edit_uchastok.Checked;
            DataStatic.uchastok_material = comboBox_material_edit_uchastok.Text;
            DataStatic.uchastok_temperatura = (double)numericUpDown_temperatura_edit_uchastok.Value;
            DataStatic.uchastok_rashod_m3_in_hour = (double)numericUpDown_rashod_edit_uchastok.Value;
            DataStatic.uchastok_dlina_m = (double)numericUpDown_dlina_edit_uchastok.Value;

            if (radioButton_forma_priamougolnaia_edit_uchastok.Checked)
            {
                DataStatic.uchastok_shirina_mm = (double)numericUpDown_shirina_edit_uchastok.Value;
                DataStatic.uchastok_visota_mm = (double)numericUpDown_visota_edit_uchastok.Value;
            }
            else
            {
                DataStatic.uchastok_diameter_mm = (double)numericUpDown_diametr_edit_uchastok.Value;
            }
        }
    }
}
