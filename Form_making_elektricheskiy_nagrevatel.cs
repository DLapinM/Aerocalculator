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
    public partial class Form_making_elektricheskiy_nagrevatel : Form
    {
        public Form_making_elektricheskiy_nagrevatel()
        {
            InitializeComponent();
        }

        private void button_create_nagrevatel_Click(object sender, EventArgs e)
        {
            DataStatic.moschnost_nagrevatelia = (double)numericUpDown_moschnost_nagrevatelia.Value;
            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_nagrevateley.Value;
        }
    }
}
