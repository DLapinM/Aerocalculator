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
    public partial class Form_making_mestnoe_soprotivlenie : Form
    {
        public Form_making_mestnoe_soprotivlenie()
        {
            InitializeComponent();
            comboBox_tip_mestnogo_soprotivlenia.Text = "Отвод";
        }

        private void Form_making_mestnoe_soprotivlenie_Load(object sender, EventArgs e)
        {

        }

        private void button_vibor_mestnogo_soprotivlenia_dalee_Click(object sender, EventArgs e)
        {
            DataStatic.tip_mestnogo_soprotivlenia = comboBox_tip_mestnogo_soprotivlenia.Text;
        }
    }
}
