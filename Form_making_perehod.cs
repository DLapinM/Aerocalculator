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
    public partial class Form_making_perehod : Form
    {
        public Form_making_perehod()
        {
            InitializeComponent();

            if (DataStatic.number_uchastok_before < 1)
            {
                radioButton_perehodnik_after.Checked = true;
                radioButton_perehodnik_before.Enabled = false;
                radioButton_perehodnik_after.Enabled = false;
            }
            else if (DataStatic.number_uchastok_after > DataStatic.kolichestvo_uchastkov)
            {
                radioButton_perehodnik_before.Checked = true;
                radioButton_perehodnik_before.Enabled = false;
                radioButton_perehodnik_after.Enabled = false;
            }
            else
            {
                radioButton_perehodnik_after.Checked = true;
                radioButton_perehodnik_before.Enabled = true;
                radioButton_perehodnik_after.Enabled = true;
            }

            if (DataStatic.vnezapniy_perehod)
            {
                numericUpDown_perehodnik_dlina.Value = 0;
                numericUpDown_perehodnik_dlina.Enabled = false;
            }
            else
            {
                numericUpDown_perehodnik_dlina.Value = 200;
                numericUpDown_perehodnik_dlina.Enabled = true;
            }
        }

        private void button_create_perehodnik_Click(object sender, EventArgs e)
        {
            if (radioButton_perehodnik_after.Checked)
            {
                DataStatic.first_uchastok_number = DataStatic.number_uchastok_current;
                DataStatic.second_uchastok_number = DataStatic.number_uchastok_after;
            }
            else if (radioButton_perehodnik_before.Checked)
            {
                DataStatic.first_uchastok_number = DataStatic.number_uchastok_before;
                DataStatic.second_uchastok_number = DataStatic.number_uchastok_current;
            }
            else
            {
                DataStatic.first_uchastok_number = DataStatic.number_uchastok_current;
                DataStatic.second_uchastok_number = DataStatic.number_uchastok_after;
            }

            DataStatic.perehod_dlina = (double)numericUpDown_perehodnik_dlina.Value;
        }
    }
}
