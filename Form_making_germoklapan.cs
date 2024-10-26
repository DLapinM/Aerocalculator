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
    public partial class Form_making_germoklapan : Form
    {
        public Form_making_germoklapan()
        {
            InitializeComponent();

            radioButton_not_kor_germoklapan.Checked = true;
            radioButton_obschepromishlenniy_germoklapan.Checked = true;
        }

        private void button_create_germoklapan_Click(object sender, EventArgs e)
        {
            DataStatic.germoklapan_kor_or_not = radioButton_kor_germoklapan.Checked;
            
            if (radioButton_obschepromishlenniy_germoklapan.Checked)
            {
                DataStatic.tip_germoklapana = "общепромышленный";
            }
            else if (radioButton_vzrivozaschischenniy_germoklapan.Checked)
            {
                DataStatic.tip_germoklapana = "взрывозащищённый";
            }
            else if (radioButton_jaroprochniy_germoklapan.Checked)
            {
                DataStatic.tip_germoklapana = "жаропрочный";
            }
            else
            {
                DataStatic.tip_germoklapana = "общепромышленный";
            }

            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_germoklapanov.Value;
        }
    }
}
