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
    public partial class Form_making_klapan_obratniy : Form
    {
        public Form_making_klapan_obratniy()
        {
            InitializeComponent();
            radioButton_obratniy_klapan_na_gorizontali.Checked = true;
            radioButton_obratniy_klapan_na_vertikali.Checked = !radioButton_obratniy_klapan_na_gorizontali.Checked;
            radioButton_not_rotated_obratniy_klapan.Checked = true;
            radioButton_rotated_obratniy_klapan.Checked = !radioButton_not_rotated_obratniy_klapan.Checked;

            if (DataStatic.forma_mestnogo_soprotivlenia == "circle")
            {
                radioButton_not_rotated_obratniy_klapan.Enabled = false;
                radioButton_rotated_obratniy_klapan.Enabled = false;
            }
        }

        private void radioButton_obratniy_klapan_na_gorizontali_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_obratniy_klapan_na_vertikali.Checked = !radioButton_obratniy_klapan_na_gorizontali.Checked;
        }

        private void radioButton_obratniy_klapan_na_vertikali_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_obratniy_klapan_na_gorizontali.Checked = !radioButton_obratniy_klapan_na_vertikali.Checked;
        }

        private void radioButton_not_rotated_obratniy_klapan_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_rotated_obratniy_klapan.Checked = !radioButton_not_rotated_obratniy_klapan.Checked;
        }

        private void radioButton_rotated_obratniy_klapan_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_not_rotated_obratniy_klapan.Checked = !radioButton_rotated_obratniy_klapan.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataStatic.klapan_na_gorizontali_1_na_vertikali_2 = (radioButton_obratniy_klapan_na_gorizontali.Checked ? 1 : 2);
            DataStatic.rotated_or_not = radioButton_rotated_obratniy_klapan.Checked;
            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_obratnih_klapanov.Value;
        }
    }
}
