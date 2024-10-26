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
    public partial class Form_making_dimovoy_klapan : Form
    {
        public Form_making_dimovoy_klapan()
        {
            InitializeComponent();

            radioButton_kanalniy_dimovoy_klapan.Checked = true;
            radioButton_stenovoy_dimovoy_klapan.Checked = false;

            radioButton_not_rotated_dimovoy_klapan.Checked = true;
            radioButton_rotated_dimovoy_klapan.Checked = false;

            if (DataStatic.forma_mestnogo_soprotivlenia == "circle")
            {
                radioButton_not_rotated_dimovoy_klapan.Enabled = false;
                radioButton_rotated_dimovoy_klapan.Enabled = false;
            }
        }

        private void radioButton_kanalniy_dimovoy_klapan_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_stenovoy_dimovoy_klapan.Checked = !radioButton_kanalniy_dimovoy_klapan.Checked;
        }

        private void radioButton_stenovoy_dimovoy_klapan_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_kanalniy_dimovoy_klapan.Checked = !radioButton_stenovoy_dimovoy_klapan.Checked;
        }

        private void radioButton_not_rotated_dimovoy_klapan_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_rotated_dimovoy_klapan.Checked = !radioButton_not_rotated_dimovoy_klapan.Checked;
        }

        private void radioButton_rotated_dimovoy_klapan_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_not_rotated_dimovoy_klapan.Checked = !radioButton_rotated_dimovoy_klapan.Checked;
        }

        private void button_create_dimovoy_klapan_Click(object sender, EventArgs e)
        {
            DataStatic.klapan_kanalniy_true_stenovoy_false = radioButton_kanalniy_dimovoy_klapan.Checked;
            DataStatic.rotated_or_not = radioButton_rotated_dimovoy_klapan.Checked;
            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_dimovih_klapanov.Value;
        }
    }
}
