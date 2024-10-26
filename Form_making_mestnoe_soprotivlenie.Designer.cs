namespace Aerocalculator
{
    partial class Form_making_mestnoe_soprotivlenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_making_mestnoe_soprotivlenie));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tip_mestnogo_soprotivlenia = new System.Windows.Forms.ComboBox();
            this.button_vibor_mestnogo_soprotivlenia_dalee = new System.Windows.Forms.Button();
            this.button_vibor_mestnogo_soprotivlenia_otmena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип местного сопротивления:";
            // 
            // comboBox_tip_mestnogo_soprotivlenia
            // 
            this.comboBox_tip_mestnogo_soprotivlenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_tip_mestnogo_soprotivlenia.FormattingEnabled = true;
            this.comboBox_tip_mestnogo_soprotivlenia.Items.AddRange(new object[] {
            "Отвод",
            "Отвод с острыми кромками",
            "Воздушная заслонка (дроссель)",
            "Противопожарный клапан",
            "Дымовой клапан",
            "Обратный клапан",
            "Обратный клапан (Сигмавент)",
            "Клапан избыточного давления",
            "Гермоклапан",
            "Фильтр воздушный",
            "Нагреватель электрический",
            "Охладитель фреоновый",
            "Шумоглушитель",
            "Гибкая вставка",
            "Решётка воздухораспределительная",
            "Сетка воздухораспределительная",
            "Диффузор (воздухораспределитель)",
            "Диффузор со статической камерой",
            "Внезапный переход",
            "Переходник",
            "Тройник"});
            this.comboBox_tip_mestnogo_soprotivlenia.Location = new System.Drawing.Point(57, 107);
            this.comboBox_tip_mestnogo_soprotivlenia.Name = "comboBox_tip_mestnogo_soprotivlenia";
            this.comboBox_tip_mestnogo_soprotivlenia.Size = new System.Drawing.Size(411, 28);
            this.comboBox_tip_mestnogo_soprotivlenia.TabIndex = 1;
            // 
            // button_vibor_mestnogo_soprotivlenia_dalee
            // 
            this.button_vibor_mestnogo_soprotivlenia_dalee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_vibor_mestnogo_soprotivlenia_dalee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_vibor_mestnogo_soprotivlenia_dalee.Location = new System.Drawing.Point(326, 190);
            this.button_vibor_mestnogo_soprotivlenia_dalee.Name = "button_vibor_mestnogo_soprotivlenia_dalee";
            this.button_vibor_mestnogo_soprotivlenia_dalee.Size = new System.Drawing.Size(142, 32);
            this.button_vibor_mestnogo_soprotivlenia_dalee.TabIndex = 2;
            this.button_vibor_mestnogo_soprotivlenia_dalee.Text = "Далее";
            this.button_vibor_mestnogo_soprotivlenia_dalee.UseVisualStyleBackColor = true;
            this.button_vibor_mestnogo_soprotivlenia_dalee.Click += new System.EventHandler(this.button_vibor_mestnogo_soprotivlenia_dalee_Click);
            // 
            // button_vibor_mestnogo_soprotivlenia_otmena
            // 
            this.button_vibor_mestnogo_soprotivlenia_otmena.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_vibor_mestnogo_soprotivlenia_otmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_vibor_mestnogo_soprotivlenia_otmena.Location = new System.Drawing.Point(57, 190);
            this.button_vibor_mestnogo_soprotivlenia_otmena.Name = "button_vibor_mestnogo_soprotivlenia_otmena";
            this.button_vibor_mestnogo_soprotivlenia_otmena.Size = new System.Drawing.Size(142, 32);
            this.button_vibor_mestnogo_soprotivlenia_otmena.TabIndex = 3;
            this.button_vibor_mestnogo_soprotivlenia_otmena.Text = "Отмена";
            this.button_vibor_mestnogo_soprotivlenia_otmena.UseVisualStyleBackColor = true;
            // 
            // Form_making_mestnoe_soprotivlenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 259);
            this.Controls.Add(this.button_vibor_mestnogo_soprotivlenia_otmena);
            this.Controls.Add(this.button_vibor_mestnogo_soprotivlenia_dalee);
            this.Controls.Add(this.comboBox_tip_mestnogo_soprotivlenia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(543, 302);
            this.Name = "Form_making_mestnoe_soprotivlenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление местного сопротивления на участок";
            this.Load += new System.EventHandler(this.Form_making_mestnoe_soprotivlenie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tip_mestnogo_soprotivlenia;
        private System.Windows.Forms.Button button_vibor_mestnogo_soprotivlenia_dalee;
        private System.Windows.Forms.Button button_vibor_mestnogo_soprotivlenia_otmena;
    }
}