namespace Aerocalculator
{
    partial class Form_edit_uchastok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_edit_uchastok));
            this.radioButton_forma_priamougolnaia_edit_uchastok = new System.Windows.Forms.RadioButton();
            this.radioButton_forma_kruglaia_edit_uchastok = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_material_edit_uchastok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_temperatura_edit_uchastok = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_rashod_edit_uchastok = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_dlina_edit_uchastok = new System.Windows.Forms.NumericUpDown();
            this.label_diameter_edit_uchastok = new System.Windows.Forms.Label();
            this.numericUpDown_diametr_edit_uchastok = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_shirina_edit_uchastok = new System.Windows.Forms.NumericUpDown();
            this.label_shirina_edit_uchastok = new System.Windows.Forms.Label();
            this.numericUpDown_visota_edit_uchastok = new System.Windows.Forms.NumericUpDown();
            this.label_visota_edit_uchastok = new System.Windows.Forms.Label();
            this.button_edit_uchastok_ok = new System.Windows.Forms.Button();
            this.button_edit_uchastok_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temperatura_edit_uchastok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rashod_edit_uchastok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dlina_edit_uchastok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diametr_edit_uchastok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_shirina_edit_uchastok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_visota_edit_uchastok)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_forma_priamougolnaia_edit_uchastok
            // 
            this.radioButton_forma_priamougolnaia_edit_uchastok.AutoSize = true;
            this.radioButton_forma_priamougolnaia_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_forma_priamougolnaia_edit_uchastok.Location = new System.Drawing.Point(26, 19);
            this.radioButton_forma_priamougolnaia_edit_uchastok.Name = "radioButton_forma_priamougolnaia_edit_uchastok";
            this.radioButton_forma_priamougolnaia_edit_uchastok.Size = new System.Drawing.Size(263, 24);
            this.radioButton_forma_priamougolnaia_edit_uchastok.TabIndex = 0;
            this.radioButton_forma_priamougolnaia_edit_uchastok.TabStop = true;
            this.radioButton_forma_priamougolnaia_edit_uchastok.Text = "Форма участка прямоугольная";
            this.radioButton_forma_priamougolnaia_edit_uchastok.UseVisualStyleBackColor = true;
            // 
            // radioButton_forma_kruglaia_edit_uchastok
            // 
            this.radioButton_forma_kruglaia_edit_uchastok.AutoSize = true;
            this.radioButton_forma_kruglaia_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_forma_kruglaia_edit_uchastok.Location = new System.Drawing.Point(314, 19);
            this.radioButton_forma_kruglaia_edit_uchastok.Name = "radioButton_forma_kruglaia_edit_uchastok";
            this.radioButton_forma_kruglaia_edit_uchastok.Size = new System.Drawing.Size(206, 24);
            this.radioButton_forma_kruglaia_edit_uchastok.TabIndex = 1;
            this.radioButton_forma_kruglaia_edit_uchastok.TabStop = true;
            this.radioButton_forma_kruglaia_edit_uchastok.Text = "Форма участка круглая";
            this.radioButton_forma_kruglaia_edit_uchastok.UseVisualStyleBackColor = true;
            this.radioButton_forma_kruglaia_edit_uchastok.CheckedChanged += new System.EventHandler(this.radioButton_forma_kruglaia_edit_uchastok_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Материал стенок участка:";
            // 
            // comboBox_material_edit_uchastok
            // 
            this.comboBox_material_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_material_edit_uchastok.FormattingEnabled = true;
            this.comboBox_material_edit_uchastok.Items.AddRange(new object[] {
            "листовая сталь",
            "винипласт",
            "асбест",
            "фанера",
            "шлакоалебастровые плиты",
            "кирпич",
            "штукатурка",
            "бетон"});
            this.comboBox_material_edit_uchastok.Location = new System.Drawing.Point(249, 61);
            this.comboBox_material_edit_uchastok.Name = "comboBox_material_edit_uchastok";
            this.comboBox_material_edit_uchastok.Size = new System.Drawing.Size(324, 28);
            this.comboBox_material_edit_uchastok.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Температура воздуха на участке, t [°C]:";
            // 
            // numericUpDown_temperatura_edit_uchastok
            // 
            this.numericUpDown_temperatura_edit_uchastok.DecimalPlaces = 2;
            this.numericUpDown_temperatura_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_temperatura_edit_uchastok.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_temperatura_edit_uchastok.Location = new System.Drawing.Point(341, 110);
            this.numericUpDown_temperatura_edit_uchastok.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_temperatura_edit_uchastok.Minimum = new decimal(new int[] {
            273,
            0,
            0,
            -2147483648});
            this.numericUpDown_temperatura_edit_uchastok.Name = "numericUpDown_temperatura_edit_uchastok";
            this.numericUpDown_temperatura_edit_uchastok.Size = new System.Drawing.Size(232, 26);
            this.numericUpDown_temperatura_edit_uchastok.TabIndex = 5;
            this.numericUpDown_temperatura_edit_uchastok.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расход на участке, L [м³/ч]:";
            // 
            // numericUpDown_rashod_edit_uchastok
            // 
            this.numericUpDown_rashod_edit_uchastok.DecimalPlaces = 2;
            this.numericUpDown_rashod_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_rashod_edit_uchastok.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_rashod_edit_uchastok.Location = new System.Drawing.Point(283, 160);
            this.numericUpDown_rashod_edit_uchastok.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_rashod_edit_uchastok.Name = "numericUpDown_rashod_edit_uchastok";
            this.numericUpDown_rashod_edit_uchastok.Size = new System.Drawing.Size(290, 26);
            this.numericUpDown_rashod_edit_uchastok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Длина участка, [м]:";
            // 
            // numericUpDown_dlina_edit_uchastok
            // 
            this.numericUpDown_dlina_edit_uchastok.DecimalPlaces = 3;
            this.numericUpDown_dlina_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_dlina_edit_uchastok.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_dlina_edit_uchastok.Location = new System.Drawing.Point(283, 209);
            this.numericUpDown_dlina_edit_uchastok.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_dlina_edit_uchastok.Name = "numericUpDown_dlina_edit_uchastok";
            this.numericUpDown_dlina_edit_uchastok.Size = new System.Drawing.Size(290, 26);
            this.numericUpDown_dlina_edit_uchastok.TabIndex = 9;
            // 
            // label_diameter_edit_uchastok
            // 
            this.label_diameter_edit_uchastok.AutoSize = true;
            this.label_diameter_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_diameter_edit_uchastok.Location = new System.Drawing.Point(22, 259);
            this.label_diameter_edit_uchastok.Name = "label_diameter_edit_uchastok";
            this.label_diameter_edit_uchastok.Size = new System.Drawing.Size(362, 20);
            this.label_diameter_edit_uchastok.TabIndex = 10;
            this.label_diameter_edit_uchastok.Text = "Диаметр поперечного сечения участка, d [мм]:";
            // 
            // numericUpDown_diametr_edit_uchastok
            // 
            this.numericUpDown_diametr_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_diametr_edit_uchastok.Location = new System.Drawing.Point(394, 257);
            this.numericUpDown_diametr_edit_uchastok.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_diametr_edit_uchastok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_diametr_edit_uchastok.Name = "numericUpDown_diametr_edit_uchastok";
            this.numericUpDown_diametr_edit_uchastok.Size = new System.Drawing.Size(179, 26);
            this.numericUpDown_diametr_edit_uchastok.TabIndex = 11;
            this.numericUpDown_diametr_edit_uchastok.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_shirina_edit_uchastok
            // 
            this.numericUpDown_shirina_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_shirina_edit_uchastok.Location = new System.Drawing.Point(394, 307);
            this.numericUpDown_shirina_edit_uchastok.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_shirina_edit_uchastok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_shirina_edit_uchastok.Name = "numericUpDown_shirina_edit_uchastok";
            this.numericUpDown_shirina_edit_uchastok.Size = new System.Drawing.Size(179, 26);
            this.numericUpDown_shirina_edit_uchastok.TabIndex = 13;
            this.numericUpDown_shirina_edit_uchastok.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_shirina_edit_uchastok
            // 
            this.label_shirina_edit_uchastok.AutoSize = true;
            this.label_shirina_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_shirina_edit_uchastok.Location = new System.Drawing.Point(22, 309);
            this.label_shirina_edit_uchastok.Name = "label_shirina_edit_uchastok";
            this.label_shirina_edit_uchastok.Size = new System.Drawing.Size(354, 20);
            this.label_shirina_edit_uchastok.TabIndex = 12;
            this.label_shirina_edit_uchastok.Text = "Ширина поперечного сечения участка, A [мм]:";
            // 
            // numericUpDown_visota_edit_uchastok
            // 
            this.numericUpDown_visota_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_visota_edit_uchastok.Location = new System.Drawing.Point(394, 356);
            this.numericUpDown_visota_edit_uchastok.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_visota_edit_uchastok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_visota_edit_uchastok.Name = "numericUpDown_visota_edit_uchastok";
            this.numericUpDown_visota_edit_uchastok.Size = new System.Drawing.Size(179, 26);
            this.numericUpDown_visota_edit_uchastok.TabIndex = 15;
            this.numericUpDown_visota_edit_uchastok.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_visota_edit_uchastok
            // 
            this.label_visota_edit_uchastok.AutoSize = true;
            this.label_visota_edit_uchastok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_visota_edit_uchastok.Location = new System.Drawing.Point(22, 358);
            this.label_visota_edit_uchastok.Name = "label_visota_edit_uchastok";
            this.label_visota_edit_uchastok.Size = new System.Drawing.Size(353, 20);
            this.label_visota_edit_uchastok.TabIndex = 14;
            this.label_visota_edit_uchastok.Text = "Высота поперечного сечения участка, B [мм]:";
            // 
            // button_edit_uchastok_ok
            // 
            this.button_edit_uchastok_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_edit_uchastok_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit_uchastok_ok.Location = new System.Drawing.Point(320, 410);
            this.button_edit_uchastok_ok.Name = "button_edit_uchastok_ok";
            this.button_edit_uchastok_ok.Size = new System.Drawing.Size(217, 33);
            this.button_edit_uchastok_ok.TabIndex = 16;
            this.button_edit_uchastok_ok.Text = "Внести изменения";
            this.button_edit_uchastok_ok.UseVisualStyleBackColor = true;
            this.button_edit_uchastok_ok.Click += new System.EventHandler(this.button_edit_uchastok_ok_Click);
            // 
            // button_edit_uchastok_cancel
            // 
            this.button_edit_uchastok_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_edit_uchastok_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit_uchastok_cancel.Location = new System.Drawing.Point(58, 410);
            this.button_edit_uchastok_cancel.Name = "button_edit_uchastok_cancel";
            this.button_edit_uchastok_cancel.Size = new System.Drawing.Size(217, 33);
            this.button_edit_uchastok_cancel.TabIndex = 17;
            this.button_edit_uchastok_cancel.Text = "Отмена";
            this.button_edit_uchastok_cancel.UseVisualStyleBackColor = true;
            // 
            // Form_edit_uchastok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 463);
            this.Controls.Add(this.button_edit_uchastok_cancel);
            this.Controls.Add(this.button_edit_uchastok_ok);
            this.Controls.Add(this.numericUpDown_visota_edit_uchastok);
            this.Controls.Add(this.label_visota_edit_uchastok);
            this.Controls.Add(this.numericUpDown_shirina_edit_uchastok);
            this.Controls.Add(this.label_shirina_edit_uchastok);
            this.Controls.Add(this.numericUpDown_diametr_edit_uchastok);
            this.Controls.Add(this.label_diameter_edit_uchastok);
            this.Controls.Add(this.numericUpDown_dlina_edit_uchastok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_rashod_edit_uchastok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_temperatura_edit_uchastok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_material_edit_uchastok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_forma_kruglaia_edit_uchastok);
            this.Controls.Add(this.radioButton_forma_priamougolnaia_edit_uchastok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(614, 506);
            this.Name = "Form_edit_uchastok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование параметров участка";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temperatura_edit_uchastok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rashod_edit_uchastok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dlina_edit_uchastok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diametr_edit_uchastok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_shirina_edit_uchastok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_visota_edit_uchastok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_forma_priamougolnaia_edit_uchastok;
        private System.Windows.Forms.RadioButton radioButton_forma_kruglaia_edit_uchastok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_material_edit_uchastok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_temperatura_edit_uchastok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_rashod_edit_uchastok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_dlina_edit_uchastok;
        private System.Windows.Forms.Label label_diameter_edit_uchastok;
        private System.Windows.Forms.NumericUpDown numericUpDown_diametr_edit_uchastok;
        private System.Windows.Forms.NumericUpDown numericUpDown_shirina_edit_uchastok;
        private System.Windows.Forms.Label label_shirina_edit_uchastok;
        private System.Windows.Forms.NumericUpDown numericUpDown_visota_edit_uchastok;
        private System.Windows.Forms.Label label_visota_edit_uchastok;
        private System.Windows.Forms.Button button_edit_uchastok_ok;
        private System.Windows.Forms.Button button_edit_uchastok_cancel;
    }
}