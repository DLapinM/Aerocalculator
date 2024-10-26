namespace Aerocalculator
{
    partial class Form_making_uchastok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_making_uchastok));
            this.radioButton_forma_rectangle = new System.Windows.Forms.RadioButton();
            this.radioButton_forma_circle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_rashod_na_uchastke = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_material_uchastka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_temperatura_vozduha_na_uchastke = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_dlina_uchastka = new System.Windows.Forms.NumericUpDown();
            this.label_diameter_uchastka = new System.Windows.Forms.Label();
            this.numericUpDown_diametr_uchastka = new System.Windows.Forms.NumericUpDown();
            this.label_shirina_uchastka = new System.Windows.Forms.Label();
            this.numericUpDown_shirina_uchastka = new System.Windows.Forms.NumericUpDown();
            this.label_visota_uchastka = new System.Windows.Forms.Label();
            this.numericUpDown_visota_uchastka = new System.Windows.Forms.NumericUpDown();
            this.button_create_uchastok_ok = new System.Windows.Forms.Button();
            this.button_create_uchastok_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rashod_na_uchastke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temperatura_vozduha_na_uchastke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dlina_uchastka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diametr_uchastka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_shirina_uchastka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_visota_uchastka)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_forma_rectangle
            // 
            this.radioButton_forma_rectangle.AutoSize = true;
            this.radioButton_forma_rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_forma_rectangle.Location = new System.Drawing.Point(81, 30);
            this.radioButton_forma_rectangle.Name = "radioButton_forma_rectangle";
            this.radioButton_forma_rectangle.Size = new System.Drawing.Size(263, 24);
            this.radioButton_forma_rectangle.TabIndex = 2;
            this.radioButton_forma_rectangle.TabStop = true;
            this.radioButton_forma_rectangle.Text = "Форма участка прямоугольная";
            this.radioButton_forma_rectangle.UseVisualStyleBackColor = true;
            this.radioButton_forma_rectangle.CheckedChanged += new System.EventHandler(this.radioButton_forma_rectangle_CheckedChanged);
            // 
            // radioButton_forma_circle
            // 
            this.radioButton_forma_circle.AutoSize = true;
            this.radioButton_forma_circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_forma_circle.Location = new System.Drawing.Point(399, 30);
            this.radioButton_forma_circle.Name = "radioButton_forma_circle";
            this.radioButton_forma_circle.Size = new System.Drawing.Size(206, 24);
            this.radioButton_forma_circle.TabIndex = 3;
            this.radioButton_forma_circle.TabStop = true;
            this.radioButton_forma_circle.Text = "Форма участка круглая";
            this.radioButton_forma_circle.UseVisualStyleBackColor = true;
            this.radioButton_forma_circle.CheckedChanged += new System.EventHandler(this.radioButton_forma_circle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Расход на участке, L [м³/ч]:";
            // 
            // numericUpDown_rashod_na_uchastke
            // 
            this.numericUpDown_rashod_na_uchastke.DecimalPlaces = 2;
            this.numericUpDown_rashod_na_uchastke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_rashod_na_uchastke.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_rashod_na_uchastke.Location = new System.Drawing.Point(311, 196);
            this.numericUpDown_rashod_na_uchastke.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_rashod_na_uchastke.Name = "numericUpDown_rashod_na_uchastke";
            this.numericUpDown_rashod_na_uchastke.Size = new System.Drawing.Size(294, 26);
            this.numericUpDown_rashod_na_uchastke.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(77, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Материал стенок участка:";
            // 
            // comboBox_material_uchastka
            // 
            this.comboBox_material_uchastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_material_uchastka.FormattingEnabled = true;
            this.comboBox_material_uchastka.Items.AddRange(new object[] {
            "листовая сталь",
            "винипласт",
            "асбест",
            "фанера",
            "шлакоалебастровые плиты",
            "кирпич",
            "штукатурка",
            "бетон"});
            this.comboBox_material_uchastka.Location = new System.Drawing.Point(311, 84);
            this.comboBox_material_uchastka.Name = "comboBox_material_uchastka";
            this.comboBox_material_uchastka.Size = new System.Drawing.Size(294, 28);
            this.comboBox_material_uchastka.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(77, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Температура воздуха на участке, t [°C]:";
            // 
            // numericUpDown_temperatura_vozduha_na_uchastke
            // 
            this.numericUpDown_temperatura_vozduha_na_uchastke.DecimalPlaces = 2;
            this.numericUpDown_temperatura_vozduha_na_uchastke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_temperatura_vozduha_na_uchastke.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_temperatura_vozduha_na_uchastke.Location = new System.Drawing.Point(398, 140);
            this.numericUpDown_temperatura_vozduha_na_uchastke.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_temperatura_vozduha_na_uchastke.Minimum = new decimal(new int[] {
            273,
            0,
            0,
            -2147483648});
            this.numericUpDown_temperatura_vozduha_na_uchastke.Name = "numericUpDown_temperatura_vozduha_na_uchastke";
            this.numericUpDown_temperatura_vozduha_na_uchastke.Size = new System.Drawing.Size(207, 26);
            this.numericUpDown_temperatura_vozduha_na_uchastke.TabIndex = 9;
            this.numericUpDown_temperatura_vozduha_na_uchastke.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(77, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Длина участка, [м]:";
            // 
            // numericUpDown_dlina_uchastka
            // 
            this.numericUpDown_dlina_uchastka.DecimalPlaces = 3;
            this.numericUpDown_dlina_uchastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_dlina_uchastka.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_dlina_uchastka.Location = new System.Drawing.Point(311, 253);
            this.numericUpDown_dlina_uchastka.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_dlina_uchastka.Name = "numericUpDown_dlina_uchastka";
            this.numericUpDown_dlina_uchastka.Size = new System.Drawing.Size(294, 26);
            this.numericUpDown_dlina_uchastka.TabIndex = 11;
            // 
            // label_diameter_uchastka
            // 
            this.label_diameter_uchastka.AutoSize = true;
            this.label_diameter_uchastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_diameter_uchastka.Location = new System.Drawing.Point(77, 320);
            this.label_diameter_uchastka.Name = "label_diameter_uchastka";
            this.label_diameter_uchastka.Size = new System.Drawing.Size(362, 20);
            this.label_diameter_uchastka.TabIndex = 12;
            this.label_diameter_uchastka.Text = "Диаметр поперечного сечения участка, d [мм]:";
            // 
            // numericUpDown_diametr_uchastka
            // 
            this.numericUpDown_diametr_uchastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_diametr_uchastka.Location = new System.Drawing.Point(451, 318);
            this.numericUpDown_diametr_uchastka.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_diametr_uchastka.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_diametr_uchastka.Name = "numericUpDown_diametr_uchastka";
            this.numericUpDown_diametr_uchastka.Size = new System.Drawing.Size(154, 26);
            this.numericUpDown_diametr_uchastka.TabIndex = 13;
            this.numericUpDown_diametr_uchastka.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_shirina_uchastka
            // 
            this.label_shirina_uchastka.AutoSize = true;
            this.label_shirina_uchastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_shirina_uchastka.Location = new System.Drawing.Point(77, 386);
            this.label_shirina_uchastka.Name = "label_shirina_uchastka";
            this.label_shirina_uchastka.Size = new System.Drawing.Size(354, 20);
            this.label_shirina_uchastka.TabIndex = 14;
            this.label_shirina_uchastka.Text = "Ширина поперечного сечения участка, A [мм]:";
            // 
            // numericUpDown_shirina_uchastka
            // 
            this.numericUpDown_shirina_uchastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_shirina_uchastka.Location = new System.Drawing.Point(451, 384);
            this.numericUpDown_shirina_uchastka.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_shirina_uchastka.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_shirina_uchastka.Name = "numericUpDown_shirina_uchastka";
            this.numericUpDown_shirina_uchastka.Size = new System.Drawing.Size(154, 26);
            this.numericUpDown_shirina_uchastka.TabIndex = 15;
            this.numericUpDown_shirina_uchastka.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_visota_uchastka
            // 
            this.label_visota_uchastka.AutoSize = true;
            this.label_visota_uchastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_visota_uchastka.Location = new System.Drawing.Point(77, 453);
            this.label_visota_uchastka.Name = "label_visota_uchastka";
            this.label_visota_uchastka.Size = new System.Drawing.Size(353, 20);
            this.label_visota_uchastka.TabIndex = 16;
            this.label_visota_uchastka.Text = "Высота поперечного сечения участка, B [мм]:";
            // 
            // numericUpDown_visota_uchastka
            // 
            this.numericUpDown_visota_uchastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_visota_uchastka.Location = new System.Drawing.Point(451, 451);
            this.numericUpDown_visota_uchastka.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_visota_uchastka.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_visota_uchastka.Name = "numericUpDown_visota_uchastka";
            this.numericUpDown_visota_uchastka.Size = new System.Drawing.Size(154, 26);
            this.numericUpDown_visota_uchastka.TabIndex = 17;
            this.numericUpDown_visota_uchastka.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button_create_uchastok_ok
            // 
            this.button_create_uchastok_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_create_uchastok_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create_uchastok_ok.Location = new System.Drawing.Point(391, 509);
            this.button_create_uchastok_ok.Name = "button_create_uchastok_ok";
            this.button_create_uchastok_ok.Size = new System.Drawing.Size(214, 33);
            this.button_create_uchastok_ok.TabIndex = 18;
            this.button_create_uchastok_ok.Text = "Создать участок";
            this.button_create_uchastok_ok.UseVisualStyleBackColor = true;
            this.button_create_uchastok_ok.Click += new System.EventHandler(this.button_create_uchastok_ok_Click);
            // 
            // button_create_uchastok_cancel
            // 
            this.button_create_uchastok_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_create_uchastok_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create_uchastok_cancel.Location = new System.Drawing.Point(81, 509);
            this.button_create_uchastok_cancel.Name = "button_create_uchastok_cancel";
            this.button_create_uchastok_cancel.Size = new System.Drawing.Size(214, 33);
            this.button_create_uchastok_cancel.TabIndex = 19;
            this.button_create_uchastok_cancel.Text = "Отмена";
            this.button_create_uchastok_cancel.UseVisualStyleBackColor = true;
            // 
            // Form_making_uchastok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 574);
            this.Controls.Add(this.button_create_uchastok_cancel);
            this.Controls.Add(this.button_create_uchastok_ok);
            this.Controls.Add(this.numericUpDown_visota_uchastka);
            this.Controls.Add(this.label_visota_uchastka);
            this.Controls.Add(this.numericUpDown_shirina_uchastka);
            this.Controls.Add(this.label_shirina_uchastka);
            this.Controls.Add(this.numericUpDown_diametr_uchastka);
            this.Controls.Add(this.label_diameter_uchastka);
            this.Controls.Add(this.numericUpDown_dlina_uchastka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_temperatura_vozduha_na_uchastke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_material_uchastka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_rashod_na_uchastke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_forma_circle);
            this.Controls.Add(this.radioButton_forma_rectangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(704, 617);
            this.Name = "Form_making_uchastok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание участка системы вентиляции";
            this.Load += new System.EventHandler(this.Form_making_uchastok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rashod_na_uchastke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temperatura_vozduha_na_uchastke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dlina_uchastka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diametr_uchastka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_shirina_uchastka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_visota_uchastka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton_forma_rectangle;
        private System.Windows.Forms.RadioButton radioButton_forma_circle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_rashod_na_uchastke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_material_uchastka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_temperatura_vozduha_na_uchastke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_dlina_uchastka;
        private System.Windows.Forms.Label label_diameter_uchastka;
        private System.Windows.Forms.NumericUpDown numericUpDown_diametr_uchastka;
        private System.Windows.Forms.Label label_shirina_uchastka;
        private System.Windows.Forms.NumericUpDown numericUpDown_shirina_uchastka;
        private System.Windows.Forms.Label label_visota_uchastka;
        private System.Windows.Forms.NumericUpDown numericUpDown_visota_uchastka;
        private System.Windows.Forms.Button button_create_uchastok_ok;
        private System.Windows.Forms.Button button_create_uchastok_cancel;
    }
}