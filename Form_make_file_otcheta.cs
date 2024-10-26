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
    public partial class Form_make_file_otcheta : Form
    {
        public Form_make_file_otcheta()
        {
            InitializeComponent();

            button_otchet_create.Enabled = false;
            textBox_folder_otchet_path.Enabled = false;
        }

        private void button_otchet_create_Click(object sender, EventArgs e)
        {
            DataStatic.file_otchet_name = textBox_name_of_file_otcheta.Text;
            DataStatic.file_otchet_path = textBox_folder_otchet_path.Text;
        }

        private void textBox_name_of_file_otcheta_TextChanged(object sender, EventArgs e)
        {
            if (textBox_name_of_file_otcheta.Text == "")
            {
                button_search_of_folders.Enabled = false;
            }
            else
            {
                button_search_of_folders.Enabled = true;
            }
        }

        private void button_search_of_folders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder_dialog = new FolderBrowserDialog();

            folder_dialog.ShowNewFolderButton = false;

            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_folder_otchet_path.Text = folder_dialog.SelectedPath;

                if (textBox_folder_otchet_path.Text != "")
                {
                    button_otchet_create.Enabled = true;
                }
            }
        }
    }
}
