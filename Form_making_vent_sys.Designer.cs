namespace Aerocalculator
{
    partial class Form_making_vent_sys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_making_vent_sys));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_vent_sys_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_vent_sys_number = new System.Windows.Forms.TextBox();
            this.richTextBox_show_sys_name = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_create_vent_sys = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_napor_ventiliatora = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_napor_ventiliatora)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип системы вентиляции:";
            // 
            // comboBox_vent_sys_type
            // 
            this.comboBox_vent_sys_type.AllowDrop = true;
            this.comboBox_vent_sys_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_vent_sys_type.FormattingEnabled = true;
            this.comboBox_vent_sys_type.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox_vent_sys_type.Items.AddRange(new object[] {
            "П (приточная общеобменная с механическим побуждением)",
            "В (вытяжная общеобменная с механическим побуждением)",
            "ПЕ (приточная общеобменная с естественным побужением)",
            "ВЕ (вытяжная общеобменная с естественным побуждением)",
            "ДП (подпор воздуха)",
            "ДВ (дымоудаление)",
            "У (для воздушной завесы)"});
            this.comboBox_vent_sys_type.Location = new System.Drawing.Point(248, 32);
            this.comboBox_vent_sys_type.Name = "comboBox_vent_sys_type";
            this.comboBox_vent_sys_type.Size = new System.Drawing.Size(662, 28);
            this.comboBox_vent_sys_type.TabIndex = 1;
            this.comboBox_vent_sys_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер системы вентиляции (после буквенного обозначения):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_vent_sys_number
            // 
            this.textBox_vent_sys_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_vent_sys_number.Location = new System.Drawing.Point(524, 88);
            this.textBox_vent_sys_number.Name = "textBox_vent_sys_number";
            this.textBox_vent_sys_number.Size = new System.Drawing.Size(187, 26);
            this.textBox_vent_sys_number.TabIndex = 3;
            this.textBox_vent_sys_number.TextChanged += new System.EventHandler(this.textBox_vent_sys_number_TextChanged);
            // 
            // richTextBox_show_sys_name
            // 
            this.richTextBox_show_sys_name.Enabled = false;
            this.richTextBox_show_sys_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_show_sys_name.Location = new System.Drawing.Point(185, 271);
            this.richTextBox_show_sys_name.Name = "richTextBox_show_sys_name";
            this.richTextBox_show_sys_name.Size = new System.Drawing.Size(556, 108);
            this.richTextBox_show_sys_name.TabIndex = 4;
            this.richTextBox_show_sys_name.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(359, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Итоговое имя системы:";
            // 
            // button_create_vent_sys
            // 
            this.button_create_vent_sys.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_create_vent_sys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create_vent_sys.Location = new System.Drawing.Point(302, 420);
            this.button_create_vent_sys.Name = "button_create_vent_sys";
            this.button_create_vent_sys.Size = new System.Drawing.Size(353, 43);
            this.button_create_vent_sys.TabIndex = 6;
            this.button_create_vent_sys.Text = "Создать систему вентиляции";
            this.button_create_vent_sys.UseVisualStyleBackColor = true;
            this.button_create_vent_sys.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Напор вентилятора или вентиляционной установки, Па:";
            // 
            // numericUpDown_napor_ventiliatora
            // 
            this.numericUpDown_napor_ventiliatora.DecimalPlaces = 2;
            this.numericUpDown_napor_ventiliatora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_napor_ventiliatora.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_napor_ventiliatora.Location = new System.Drawing.Point(524, 141);
            this.numericUpDown_napor_ventiliatora.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_napor_ventiliatora.Name = "numericUpDown_napor_ventiliatora";
            this.numericUpDown_napor_ventiliatora.Size = new System.Drawing.Size(187, 31);
            this.numericUpDown_napor_ventiliatora.TabIndex = 8;
            // 
            // Form_making_vent_sys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 505);
            this.Controls.Add(this.numericUpDown_napor_ventiliatora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_create_vent_sys);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_show_sys_name);
            this.Controls.Add(this.textBox_vent_sys_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_vent_sys_type);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(968, 548);
            this.Name = "Form_making_vent_sys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание системы вентиляции";
            this.Load += new System.EventHandler(this.Form_making_vent_sys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_napor_ventiliatora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_vent_sys_number;
        private System.Windows.Forms.RichTextBox richTextBox_show_sys_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_create_vent_sys;
        private System.Windows.Forms.ComboBox comboBox_vent_sys_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_napor_ventiliatora;
    }
}