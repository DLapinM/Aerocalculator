namespace Aerocalculator
{
    partial class Form_making_perehod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_making_perehod));
            this.radioButton_perehodnik_before = new System.Windows.Forms.RadioButton();
            this.radioButton_perehodnik_after = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_perehodnik_dlina = new System.Windows.Forms.NumericUpDown();
            this.button_create_perehodnik = new System.Windows.Forms.Button();
            this.button_cancel_perehodnik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_perehodnik_dlina)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_perehodnik_before
            // 
            this.radioButton_perehodnik_before.AutoSize = true;
            this.radioButton_perehodnik_before.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_perehodnik_before.Location = new System.Drawing.Point(46, 101);
            this.radioButton_perehodnik_before.Name = "radioButton_perehodnik_before";
            this.radioButton_perehodnik_before.Size = new System.Drawing.Size(622, 24);
            this.radioButton_perehodnik_before.TabIndex = 0;
            this.radioButton_perehodnik_before.TabStop = true;
            this.radioButton_perehodnik_before.Text = "Добавить переходник с предыдущего (по номеру) участка на текущий участок";
            this.radioButton_perehodnik_before.UseVisualStyleBackColor = true;
            // 
            // radioButton_perehodnik_after
            // 
            this.radioButton_perehodnik_after.AutoSize = true;
            this.radioButton_perehodnik_after.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_perehodnik_after.Location = new System.Drawing.Point(46, 36);
            this.radioButton_perehodnik_after.Name = "radioButton_perehodnik_after";
            this.radioButton_perehodnik_after.Size = new System.Drawing.Size(634, 24);
            this.radioButton_perehodnik_after.TabIndex = 1;
            this.radioButton_perehodnik_after.TabStop = true;
            this.radioButton_perehodnik_after.Text = "Добавить переходник с текущего участка на  последующий (по номеру) участок";
            this.radioButton_perehodnik_after.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "(Участки вытяжных систем нумеруются по ходу движения воздуха,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(96, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(484, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "а участки приточных систем - против хода движения воздуха.)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(185, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Длина переходника:";
            // 
            // numericUpDown_perehodnik_dlina
            // 
            this.numericUpDown_perehodnik_dlina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_perehodnik_dlina.Location = new System.Drawing.Point(372, 287);
            this.numericUpDown_perehodnik_dlina.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_perehodnik_dlina.Name = "numericUpDown_perehodnik_dlina";
            this.numericUpDown_perehodnik_dlina.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_perehodnik_dlina.TabIndex = 6;
            this.numericUpDown_perehodnik_dlina.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // button_create_perehodnik
            // 
            this.button_create_perehodnik.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_create_perehodnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create_perehodnik.Location = new System.Drawing.Point(415, 365);
            this.button_create_perehodnik.Name = "button_create_perehodnik";
            this.button_create_perehodnik.Size = new System.Drawing.Size(207, 36);
            this.button_create_perehodnik.TabIndex = 7;
            this.button_create_perehodnik.Text = "Добавить переходник";
            this.button_create_perehodnik.UseVisualStyleBackColor = true;
            this.button_create_perehodnik.Click += new System.EventHandler(this.button_create_perehodnik_Click);
            // 
            // button_cancel_perehodnik
            // 
            this.button_cancel_perehodnik.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel_perehodnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel_perehodnik.Location = new System.Drawing.Point(94, 365);
            this.button_cancel_perehodnik.Name = "button_cancel_perehodnik";
            this.button_cancel_perehodnik.Size = new System.Drawing.Size(207, 36);
            this.button_cancel_perehodnik.TabIndex = 8;
            this.button_cancel_perehodnik.Text = "Отмена";
            this.button_cancel_perehodnik.UseVisualStyleBackColor = true;
            // 
            // Form_making_perehod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 435);
            this.Controls.Add(this.button_cancel_perehodnik);
            this.Controls.Add(this.button_create_perehodnik);
            this.Controls.Add(this.numericUpDown_perehodnik_dlina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_perehodnik_after);
            this.Controls.Add(this.radioButton_perehodnik_before);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(741, 478);
            this.Name = "Form_making_perehod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление переходника";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_perehodnik_dlina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_perehodnik_before;
        private System.Windows.Forms.RadioButton radioButton_perehodnik_after;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_perehodnik_dlina;
        private System.Windows.Forms.Button button_create_perehodnik;
        private System.Windows.Forms.Button button_cancel_perehodnik;
    }
}