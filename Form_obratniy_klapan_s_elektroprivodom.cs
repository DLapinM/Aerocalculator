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
    public partial class Form_obratniy_klapan_s_elektroprivodom : Form
    {
        public Form_obratniy_klapan_s_elektroprivodom()
        {
            InitializeComponent();

            radioButton_not_rotated_obratniy_klapan_sigmavent.Checked = true;
            radioButton_rotated_obratniy_klapan_sigmavent.Checked = !radioButton_not_rotated_obratniy_klapan_sigmavent.Checked;

            if (DataStatic.forma_mestnogo_soprotivlenia == "circle")
            {
                radioButton_not_rotated_obratniy_klapan_sigmavent.Enabled = false;
                radioButton_rotated_obratniy_klapan_sigmavent.Enabled = false;
            }
        }

        private void radioButton_not_rotated_obratniy_klapan_sigmavent_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_rotated_obratniy_klapan_sigmavent.Checked = !radioButton_not_rotated_obratniy_klapan_sigmavent.Checked;
        }

        private void radioButton_rotated_obratniy_klapan_sigmavent_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_not_rotated_obratniy_klapan_sigmavent.Checked = !radioButton_rotated_obratniy_klapan_sigmavent.Checked;
        }

        private void button_create_obratniy_klapan_sigmavent_Click(object sender, EventArgs e)
        {
            DataStatic.rotated_or_not = radioButton_rotated_obratniy_klapan_sigmavent.Checked;
            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_obratnih_klapanov_sigmavent.Value;
        }
    }
}
