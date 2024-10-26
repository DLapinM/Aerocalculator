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
    public partial class Form_making_vozdushnaia_zaslonka : Form
    {
        public Form_making_vozdushnaia_zaslonka()
        {
            InitializeComponent();
            radioButton_vozdushnaia_zaslonka_not_rotated.Checked = true;

            if (DataStatic.forma_mestnogo_soprotivlenia == "circle")
            {
                radioButton_vozdushnaia_zaslonka_not_rotated.Enabled = false;
                radioButton_vozdushnaia_zaslonka_rotated.Enabled = false;
            }
        }

        private void radioButton_vozdushnaia_zaslonka_not_rotated_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_vozdushnaia_zaslonka_rotated.Checked = !radioButton_vozdushnaia_zaslonka_not_rotated.Checked;
        }

        private void radioButton_vozdushnaia_zaslonka_rotated_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_vozdushnaia_zaslonka_not_rotated.Checked = !radioButton_vozdushnaia_zaslonka_rotated.Checked;
        }

        private void button_create_vozdushnaia_zaslonka_Click(object sender, EventArgs e)
        {
            DataStatic.rotated_or_not = radioButton_vozdushnaia_zaslonka_rotated.Checked;
            DataStatic.marka_before_razmeri = textBox_vozdushnaia_zaslonka_marka.Text;
            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_vozdushnih_zaslonok.Value;
        }
    }
}
