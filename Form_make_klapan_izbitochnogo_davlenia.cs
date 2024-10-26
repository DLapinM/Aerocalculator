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
    public partial class Form_make_klapan_izbitochnogo_davlenia : Form
    {
        public Form_make_klapan_izbitochnogo_davlenia()
        {
            InitializeComponent();
            radioButton_not_rotated_klapan_izbitochnogo_davlenia.Checked = true;
            radioButton_rotated_klapan_izbitochnogo_davlenia.Checked = !radioButton_not_rotated_klapan_izbitochnogo_davlenia.Checked;

            if (DataStatic.forma_mestnogo_soprotivlenia == "circle")
            {
                radioButton_not_rotated_klapan_izbitochnogo_davlenia.Enabled = false;
                radioButton_rotated_klapan_izbitochnogo_davlenia.Enabled = false;
            }
        }

        private void radioButton_not_rotated_klapan_izbitochnogo_davlenia_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_rotated_klapan_izbitochnogo_davlenia.Checked = !radioButton_not_rotated_klapan_izbitochnogo_davlenia.Checked;
        }

        private void radioButton_rotated_klapan_izbitochnogo_davlenia_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_not_rotated_klapan_izbitochnogo_davlenia.Checked = !radioButton_rotated_klapan_izbitochnogo_davlenia.Checked;
        }

        private void button_create_klapan_izbitochnogo_davlenia_Click(object sender, EventArgs e)
        {
            DataStatic.rotated_or_not = radioButton_rotated_klapan_izbitochnogo_davlenia.Checked;
            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_klapanov_izbitochnogo_davlenia.Value;
        }
    }
}
