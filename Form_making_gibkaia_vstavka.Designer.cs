namespace Aerocalculator
{
    partial class Form_making_gibkaia_vstavka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_making_gibkaia_vstavka));
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_gibkaia_vstavka_veza = new System.Windows.Forms.RadioButton();
            this.radioButton_gibkaia_vstavka_arktika = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_kolichestvo_gibkih_vstavok = new System.Windows.Forms.NumericUpDown();
            this.button_create_gibkaia_vstavka = new System.Windows.Forms.Button();
            this.button_cancel_gibkaia_vstavka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_gibkih_vstavok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Производитель гибкой вставки:";
            // 
            // radioButton_gibkaia_vstavka_veza
            // 
            this.radioButton_gibkaia_vstavka_veza.AutoSize = true;
            this.radioButton_gibkaia_vstavka_veza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_gibkaia_vstavka_veza.Location = new System.Drawing.Point(314, 26);
            this.radioButton_gibkaia_vstavka_veza.Name = "radioButton_gibkaia_vstavka_veza";
            this.radioButton_gibkaia_vstavka_veza.Size = new System.Drawing.Size(64, 24);
            this.radioButton_gibkaia_vstavka_veza.TabIndex = 1;
            this.radioButton_gibkaia_vstavka_veza.TabStop = true;
            this.radioButton_gibkaia_vstavka_veza.Text = "Веза";
            this.radioButton_gibkaia_vstavka_veza.UseVisualStyleBackColor = true;
            // 
            // radioButton_gibkaia_vstavka_arktika
            // 
            this.radioButton_gibkaia_vstavka_arktika.AutoSize = true;
            this.radioButton_gibkaia_vstavka_arktika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_gibkaia_vstavka_arktika.Location = new System.Drawing.Point(314, 72);
            this.radioButton_gibkaia_vstavka_arktika.Name = "radioButton_gibkaia_vstavka_arktika";
            this.radioButton_gibkaia_vstavka_arktika.Size = new System.Drawing.Size(90, 24);
            this.radioButton_gibkaia_vstavka_arktika.TabIndex = 2;
            this.radioButton_gibkaia_vstavka_arktika.TabStop = true;
            this.radioButton_gibkaia_vstavka_arktika.Text = "Арктика";
            this.radioButton_gibkaia_vstavka_arktika.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество гибких вставок для добавления:";
            // 
            // numericUpDown_kolichestvo_gibkih_vstavok
            // 
            this.numericUpDown_kolichestvo_gibkih_vstavok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_kolichestvo_gibkih_vstavok.Location = new System.Drawing.Point(403, 131);
            this.numericUpDown_kolichestvo_gibkih_vstavok.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_gibkih_vstavok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_gibkih_vstavok.Name = "numericUpDown_kolichestvo_gibkih_vstavok";
            this.numericUpDown_kolichestvo_gibkih_vstavok.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_kolichestvo_gibkih_vstavok.TabIndex = 4;
            this.numericUpDown_kolichestvo_gibkih_vstavok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_create_gibkaia_vstavka
            // 
            this.button_create_gibkaia_vstavka.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_create_gibkaia_vstavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create_gibkaia_vstavka.Location = new System.Drawing.Point(277, 197);
            this.button_create_gibkaia_vstavka.Name = "button_create_gibkaia_vstavka";
            this.button_create_gibkaia_vstavka.Size = new System.Drawing.Size(229, 36);
            this.button_create_gibkaia_vstavka.TabIndex = 5;
            this.button_create_gibkaia_vstavka.Text = "Добавить гибкую вставку";
            this.button_create_gibkaia_vstavka.UseVisualStyleBackColor = true;
            this.button_create_gibkaia_vstavka.Click += new System.EventHandler(this.button_create_gibkaia_vstavka_Click);
            // 
            // button_cancel_gibkaia_vstavka
            // 
            this.button_cancel_gibkaia_vstavka.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel_gibkaia_vstavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel_gibkaia_vstavka.Location = new System.Drawing.Point(52, 197);
            this.button_cancel_gibkaia_vstavka.Name = "button_cancel_gibkaia_vstavka";
            this.button_cancel_gibkaia_vstavka.Size = new System.Drawing.Size(179, 36);
            this.button_cancel_gibkaia_vstavka.TabIndex = 6;
            this.button_cancel_gibkaia_vstavka.Text = "Отмена";
            this.button_cancel_gibkaia_vstavka.UseVisualStyleBackColor = true;
            // 
            // Form_making_gibkaia_vstavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 263);
            this.Controls.Add(this.button_cancel_gibkaia_vstavka);
            this.Controls.Add(this.button_create_gibkaia_vstavka);
            this.Controls.Add(this.numericUpDown_kolichestvo_gibkih_vstavok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_gibkaia_vstavka_arktika);
            this.Controls.Add(this.radioButton_gibkaia_vstavka_veza);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(577, 306);
            this.Name = "Form_making_gibkaia_vstavka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление гибкой вставки";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_gibkih_vstavok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_gibkaia_vstavka_veza;
        private System.Windows.Forms.RadioButton radioButton_gibkaia_vstavka_arktika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_kolichestvo_gibkih_vstavok;
        private System.Windows.Forms.Button button_create_gibkaia_vstavka;
        private System.Windows.Forms.Button button_cancel_gibkaia_vstavka;
    }
}