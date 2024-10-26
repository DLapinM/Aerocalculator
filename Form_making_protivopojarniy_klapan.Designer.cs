namespace Aerocalculator
{
    partial class Form_making_protivopojarniy_klapan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_making_protivopojarniy_klapan));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_kpu_oboznachenie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_kpu_naznachenie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_kpu_ispolnenie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_kpu_tip_klapana = new System.Windows.Forms.ComboBox();
            this.textBox_kpu_show_marka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_kolichestvo_klapanov_kpu = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton_kpu_not_rotated = new System.Windows.Forms.RadioButton();
            this.radioButton_kpu_rotated = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_klapanov_kpu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Обозначение:";
            // 
            // comboBox_kpu_oboznachenie
            // 
            this.comboBox_kpu_oboznachenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_kpu_oboznachenie.FormattingEnabled = true;
            this.comboBox_kpu_oboznachenie.Items.AddRange(new object[] {
            "КПУ-1Н",
            "КПУ-2Н",
            "КПУ-3-ДД"});
            this.comboBox_kpu_oboznachenie.Location = new System.Drawing.Point(168, 38);
            this.comboBox_kpu_oboznachenie.Name = "comboBox_kpu_oboznachenie";
            this.comboBox_kpu_oboznachenie.Size = new System.Drawing.Size(121, 28);
            this.comboBox_kpu_oboznachenie.TabIndex = 3;
            this.comboBox_kpu_oboznachenie.Text = "КПУ-1Н";
            this.comboBox_kpu_oboznachenie.SelectedIndexChanged += new System.EventHandler(this.comboBox_kpu_oboznachenie_SelectedIndexChanged);
            this.comboBox_kpu_oboznachenie.TextUpdate += new System.EventHandler(this.comboBox_kpu_oboznachenie_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Назначение:";
            // 
            // comboBox_kpu_naznachenie
            // 
            this.comboBox_kpu_naznachenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_kpu_naznachenie.FormattingEnabled = true;
            this.comboBox_kpu_naznachenie.Items.AddRange(new object[] {
            "О - нормально открытый",
            "З - нормально закрытый",
            "Д - дымовой"});
            this.comboBox_kpu_naznachenie.Location = new System.Drawing.Point(168, 96);
            this.comboBox_kpu_naznachenie.Name = "comboBox_kpu_naznachenie";
            this.comboBox_kpu_naznachenie.Size = new System.Drawing.Size(271, 28);
            this.comboBox_kpu_naznachenie.TabIndex = 5;
            this.comboBox_kpu_naznachenie.Text = "О - нормально открытый";
            this.comboBox_kpu_naznachenie.SelectedIndexChanged += new System.EventHandler(this.comboBox_kpu_naznachenie_SelectedIndexChanged);
            this.comboBox_kpu_naznachenie.TextUpdate += new System.EventHandler(this.comboBox_kpu_naznachenie_TextUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Исполнение:";
            // 
            // comboBox_kpu_ispolnenie
            // 
            this.comboBox_kpu_ispolnenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_kpu_ispolnenie.FormattingEnabled = true;
            this.comboBox_kpu_ispolnenie.Items.AddRange(new object[] {
            "Н - общепромышленное",
            "В - взрывозащищённое",
            "К - коррозионностойкое",
            "ВК - взрывозащищённое коррозионностойкое",
            "МС - морозостойкое",
            "МСК - морозостойкое коррозионностойкое",
            "ВМС - взрывозащищённое морозостойкое",
            "ВМСК - взрывозащищённое морозостойкое коррозионностойкое"});
            this.comboBox_kpu_ispolnenie.Location = new System.Drawing.Point(168, 151);
            this.comboBox_kpu_ispolnenie.Name = "comboBox_kpu_ispolnenie";
            this.comboBox_kpu_ispolnenie.Size = new System.Drawing.Size(596, 28);
            this.comboBox_kpu_ispolnenie.TabIndex = 7;
            this.comboBox_kpu_ispolnenie.Text = "Н - общепромышленное";
            this.comboBox_kpu_ispolnenie.SelectedIndexChanged += new System.EventHandler(this.comboBox_kpu_ispolnenie_SelectedIndexChanged);
            this.comboBox_kpu_ispolnenie.TextUpdate += new System.EventHandler(this.comboBox_kpu_ispolnenie_TextUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип клапана:";
            // 
            // comboBox_kpu_tip_klapana
            // 
            this.comboBox_kpu_tip_klapana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_kpu_tip_klapana.FormattingEnabled = true;
            this.comboBox_kpu_tip_klapana.Items.AddRange(new object[] {
            "1*ф - стеновой",
            "2*ф - канальный"});
            this.comboBox_kpu_tip_klapana.Location = new System.Drawing.Point(168, 203);
            this.comboBox_kpu_tip_klapana.Name = "comboBox_kpu_tip_klapana";
            this.comboBox_kpu_tip_klapana.Size = new System.Drawing.Size(271, 28);
            this.comboBox_kpu_tip_klapana.TabIndex = 9;
            this.comboBox_kpu_tip_klapana.Text = "2*ф - канальный";
            this.comboBox_kpu_tip_klapana.SelectedIndexChanged += new System.EventHandler(this.comboBox_kpu_tip_klapana_SelectedIndexChanged);
            this.comboBox_kpu_tip_klapana.TextUpdate += new System.EventHandler(this.comboBox_kpu_tip_klapana_TextUpdate);
            // 
            // textBox_kpu_show_marka
            // 
            this.textBox_kpu_show_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_kpu_show_marka.Location = new System.Drawing.Point(168, 354);
            this.textBox_kpu_show_marka.Name = "textBox_kpu_show_marka";
            this.textBox_kpu_show_marka.Size = new System.Drawing.Size(271, 26);
            this.textBox_kpu_show_marka.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(48, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество клапанов для добавления:";
            // 
            // numericUpDown_kolichestvo_klapanov_kpu
            // 
            this.numericUpDown_kolichestvo_klapanov_kpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_kolichestvo_klapanov_kpu.Location = new System.Drawing.Point(385, 405);
            this.numericUpDown_kolichestvo_klapanov_kpu.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_klapanov_kpu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_klapanov_kpu.Name = "numericUpDown_kolichestvo_klapanov_kpu";
            this.numericUpDown_kolichestvo_klapanov_kpu.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_kolichestvo_klapanov_kpu.TabIndex = 12;
            this.numericUpDown_kolichestvo_klapanov_kpu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(429, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить клапан(ы)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(104, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton_kpu_not_rotated
            // 
            this.radioButton_kpu_not_rotated.AutoSize = true;
            this.radioButton_kpu_not_rotated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_kpu_not_rotated.Location = new System.Drawing.Point(45, 258);
            this.radioButton_kpu_not_rotated.Name = "radioButton_kpu_not_rotated";
            this.radioButton_kpu_not_rotated.Size = new System.Drawing.Size(407, 24);
            this.radioButton_kpu_not_rotated.TabIndex = 15;
            this.radioButton_kpu_not_rotated.TabStop = true;
            this.radioButton_kpu_not_rotated.Text = "Противопожарный клапан установлен нормально";
            this.radioButton_kpu_not_rotated.UseVisualStyleBackColor = true;
            this.radioButton_kpu_not_rotated.CheckedChanged += new System.EventHandler(this.radioButton_kpu_not_rotated_CheckedChanged);
            // 
            // radioButton_kpu_rotated
            // 
            this.radioButton_kpu_rotated.AutoSize = true;
            this.radioButton_kpu_rotated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_kpu_rotated.Location = new System.Drawing.Point(45, 306);
            this.radioButton_kpu_rotated.Name = "radioButton_kpu_rotated";
            this.radioButton_kpu_rotated.Size = new System.Drawing.Size(465, 24);
            this.radioButton_kpu_rotated.TabIndex = 16;
            this.radioButton_kpu_rotated.TabStop = true;
            this.radioButton_kpu_rotated.Text = "Противопожарный клапан повёрнут на 90° по оси участка";
            this.radioButton_kpu_rotated.UseVisualStyleBackColor = true;
            this.radioButton_kpu_rotated.CheckedChanged += new System.EventHandler(this.radioButton_kpu_rotated_CheckedChanged);
            // 
            // Form_making_protivopojarniy_klapan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 530);
            this.Controls.Add(this.radioButton_kpu_rotated);
            this.Controls.Add(this.radioButton_kpu_not_rotated);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_kolichestvo_klapanov_kpu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_kpu_show_marka);
            this.Controls.Add(this.comboBox_kpu_tip_klapana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_kpu_ispolnenie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_kpu_naznachenie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_kpu_oboznachenie);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 573);
            this.Name = "Form_making_protivopojarniy_klapan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление противопожарного клапана на участок";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_klapanov_kpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_kpu_oboznachenie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_kpu_naznachenie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_kpu_ispolnenie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_kpu_tip_klapana;
        private System.Windows.Forms.TextBox textBox_kpu_show_marka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_kolichestvo_klapanov_kpu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton_kpu_not_rotated;
        private System.Windows.Forms.RadioButton radioButton_kpu_rotated;
    }
}