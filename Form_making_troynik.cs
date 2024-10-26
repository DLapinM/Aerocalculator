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
    public partial class Form_making_troynik : Form
    {
        public Form_making_troynik()
        {
            InitializeComponent();

            if (DataStatic.number_uchastok_before < 1)
            {
                radioButton_troynik_after.Checked = true;
                radioButton_troynik_before.Enabled = false;
                radioButton_troynik_after.Enabled = false;
            }
            else if (DataStatic.number_uchastok_after > DataStatic.kolichestvo_uchastkov)
            {
                radioButton_troynik_before.Checked = true;
                radioButton_troynik_before.Enabled = false;
                radioButton_troynik_after.Enabled = false;
            }
            else
            {
                radioButton_troynik_after.Checked = true;
                radioButton_troynik_before.Enabled = true;
                radioButton_troynik_after.Enabled = true;
            }

            if (DataStatic.vent_sys_type == "П")
            {
                radioButton_troynik_after.Checked = true;
                radioButton_troynik_nagnetanie_prohod.Checked = true;
            }
            else
            {
                radioButton_troynik_before.Checked = true;
                radioButton_troynik_vsasivanie_prohod.Checked = true;
            }

            if (DataStatic.forma_mestnogo_soprotivlenia == "circle")
            {
                label_troynik_3uch_diameter.Visible = true;
                numericUpDown_troynik_diameter.Visible = true;

                label_troynik_3uch_width.Visible = false;
                numericUpDown_troynik_width.Visible = false;

                label_troynik_3uch_height.Visible = false;
                numericUpDown_troynik_height.Visible = false;

                radioButton_troynik_uch3_krugliy.Checked = true;
            }
            else
            {
                label_troynik_3uch_diameter.Visible = false;
                numericUpDown_troynik_diameter.Visible = false;

                label_troynik_3uch_width.Visible = true;
                numericUpDown_troynik_width.Visible = true;

                label_troynik_3uch_height.Visible = true;
                numericUpDown_troynik_height.Visible = true;

                radioButton_troynik_uch3_priamougolniy.Checked = true;
            }
        }

        private void button_create_troynik_Click(object sender, EventArgs e)
        {
            if (radioButton_troynik_after.Checked)
            {
                DataStatic.first_uchastok_number = DataStatic.number_uchastok_current;
                DataStatic.second_uchastok_number = DataStatic.number_uchastok_after;
            }
            else if (radioButton_troynik_before.Checked)
            {
                DataStatic.first_uchastok_number = DataStatic.number_uchastok_before;
                DataStatic.second_uchastok_number = DataStatic.number_uchastok_current;
            }
            else
            {
                DataStatic.first_uchastok_number = DataStatic.number_uchastok_current;
                DataStatic.second_uchastok_number = DataStatic.number_uchastok_after;
            }

            if (radioButton_troynik_uch3_priamougolniy.Checked)
            {
                DataStatic.other_uchastok_width = (double)numericUpDown_troynik_width.Value;
                DataStatic.other_uchastok_height = (double)numericUpDown_troynik_height.Value;
                DataStatic.other_uchastok_diameter = 0;
            }
            else
            {
                DataStatic.other_uchastok_width = 0;
                DataStatic.other_uchastok_height = 0;
                DataStatic.other_uchastok_diameter = (double)numericUpDown_troynik_diameter.Value;
            }

            if (radioButton_troynik_vsasivanie_prohod.Checked) DataStatic.troynik_type = "всасывание-проход";
            else if (radioButton_troynik_vsasivanie_otvetvlenie.Checked) DataStatic.troynik_type = "всасывание-ответвление";
            else if (radioButton_troynik_protivotok.Checked) DataStatic.troynik_type = "противоток";
            else if (radioButton_troynik_nagnetanie_prohod.Checked) DataStatic.troynik_type = "нагнетание-проход";
            else if (radioButton_troynik_nagnetanie_otvetvlenie.Checked) DataStatic.troynik_type = "нагнетание-ответвление";
            else if (radioButton_troynik_rastekanie.Checked) DataStatic.troynik_type = "растекание";
            else DataStatic.troynik_type = "всасывание-проход";
        }

        private void radioButton_troynik_uch3_krugliy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_troynik_uch3_krugliy.Checked)
            {
                label_troynik_3uch_diameter.Visible = true;
                numericUpDown_troynik_diameter.Visible = true;
            }
            else
            {
                label_troynik_3uch_diameter.Visible = false;
                numericUpDown_troynik_diameter.Visible = false;
            }
        }

        private void radioButton_troynik_uch3_priamougolniy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_troynik_uch3_priamougolniy.Checked)
            {
                label_troynik_3uch_width.Visible = true;
                numericUpDown_troynik_width.Visible = true;

                label_troynik_3uch_height.Visible = true;
                numericUpDown_troynik_height.Visible = true;
            }
            else
            {
                label_troynik_3uch_width.Visible = false;
                numericUpDown_troynik_width.Visible = false;

                label_troynik_3uch_height.Visible = false;
                numericUpDown_troynik_height.Visible = false;
            }
        }
    }
}
