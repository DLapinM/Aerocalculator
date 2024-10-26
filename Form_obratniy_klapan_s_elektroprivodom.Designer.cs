namespace Aerocalculator
{
    partial class Form_obratniy_klapan_s_elektroprivodom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_obratniy_klapan_s_elektroprivodom));
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_not_rotated_obratniy_klapan_sigmavent = new System.Windows.Forms.RadioButton();
            this.radioButton_rotated_obratniy_klapan_sigmavent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent = new System.Windows.Forms.NumericUpDown();
            this.button_create_obratniy_klapan_sigmavent = new System.Windows.Forms.Button();
            this.button_cancel_obratniy_klapan_sigmavent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ориентация обратного клапана (Сигмавент):";
            // 
            // radioButton_not_rotated_obratniy_klapan_sigmavent
            // 
            this.radioButton_not_rotated_obratniy_klapan_sigmavent.AutoSize = true;
            this.radioButton_not_rotated_obratniy_klapan_sigmavent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_not_rotated_obratniy_klapan_sigmavent.Location = new System.Drawing.Point(407, 30);
            this.radioButton_not_rotated_obratniy_klapan_sigmavent.Name = "radioButton_not_rotated_obratniy_klapan_sigmavent";
            this.radioButton_not_rotated_obratniy_klapan_sigmavent.Size = new System.Drawing.Size(265, 24);
            this.radioButton_not_rotated_obratniy_klapan_sigmavent.TabIndex = 1;
            this.radioButton_not_rotated_obratniy_klapan_sigmavent.TabStop = true;
            this.radioButton_not_rotated_obratniy_klapan_sigmavent.Text = "клапан расположен нормально";
            this.radioButton_not_rotated_obratniy_klapan_sigmavent.UseVisualStyleBackColor = true;
            this.radioButton_not_rotated_obratniy_klapan_sigmavent.CheckedChanged += new System.EventHandler(this.radioButton_not_rotated_obratniy_klapan_sigmavent_CheckedChanged);
            // 
            // radioButton_rotated_obratniy_klapan_sigmavent
            // 
            this.radioButton_rotated_obratniy_klapan_sigmavent.AutoSize = true;
            this.radioButton_rotated_obratniy_klapan_sigmavent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_rotated_obratniy_klapan_sigmavent.Location = new System.Drawing.Point(407, 81);
            this.radioButton_rotated_obratniy_klapan_sigmavent.Name = "radioButton_rotated_obratniy_klapan_sigmavent";
            this.radioButton_rotated_obratniy_klapan_sigmavent.Size = new System.Drawing.Size(358, 24);
            this.radioButton_rotated_obratniy_klapan_sigmavent.TabIndex = 2;
            this.radioButton_rotated_obratniy_klapan_sigmavent.TabStop = true;
            this.radioButton_rotated_obratniy_klapan_sigmavent.Text = "клапан повёрнут на 90° по оси воздуховода";
            this.radioButton_rotated_obratniy_klapan_sigmavent.UseVisualStyleBackColor = true;
            this.radioButton_rotated_obratniy_klapan_sigmavent.CheckedChanged += new System.EventHandler(this.radioButton_rotated_obratniy_klapan_sigmavent_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество обратных клапанов (Сигмавент) для добавления:";
            // 
            // numericUpDown_kolichestvo_obratnih_klapanov_sigmavent
            // 
            this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent.Location = new System.Drawing.Point(576, 142);
            this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent.Name = "numericUpDown_kolichestvo_obratnih_klapanov_sigmavent";
            this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent.TabIndex = 4;
            this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_create_obratniy_klapan_sigmavent
            // 
            this.button_create_obratniy_klapan_sigmavent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_create_obratniy_klapan_sigmavent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create_obratniy_klapan_sigmavent.Location = new System.Drawing.Point(438, 214);
            this.button_create_obratniy_klapan_sigmavent.Name = "button_create_obratniy_klapan_sigmavent";
            this.button_create_obratniy_klapan_sigmavent.Size = new System.Drawing.Size(237, 33);
            this.button_create_obratniy_klapan_sigmavent.TabIndex = 5;
            this.button_create_obratniy_klapan_sigmavent.Text = "Добавить клапан(ы)";
            this.button_create_obratniy_klapan_sigmavent.UseVisualStyleBackColor = true;
            this.button_create_obratniy_klapan_sigmavent.Click += new System.EventHandler(this.button_create_obratniy_klapan_sigmavent_Click);
            // 
            // button_cancel_obratniy_klapan_sigmavent
            // 
            this.button_cancel_obratniy_klapan_sigmavent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel_obratniy_klapan_sigmavent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel_obratniy_klapan_sigmavent.Location = new System.Drawing.Point(114, 214);
            this.button_cancel_obratniy_klapan_sigmavent.Name = "button_cancel_obratniy_klapan_sigmavent";
            this.button_cancel_obratniy_klapan_sigmavent.Size = new System.Drawing.Size(237, 33);
            this.button_cancel_obratniy_klapan_sigmavent.TabIndex = 6;
            this.button_cancel_obratniy_klapan_sigmavent.Text = "Отмена";
            this.button_cancel_obratniy_klapan_sigmavent.UseVisualStyleBackColor = true;
            // 
            // Form_obratniy_klapan_s_elektroprivodom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 272);
            this.Controls.Add(this.button_cancel_obratniy_klapan_sigmavent);
            this.Controls.Add(this.button_create_obratniy_klapan_sigmavent);
            this.Controls.Add(this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_rotated_obratniy_klapan_sigmavent);
            this.Controls.Add(this.radioButton_not_rotated_obratniy_klapan_sigmavent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(812, 315);
            this.Name = "Form_obratniy_klapan_s_elektroprivodom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление обратного клапана (Сигмавент)";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_obratnih_klapanov_sigmavent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_not_rotated_obratniy_klapan_sigmavent;
        private System.Windows.Forms.RadioButton radioButton_rotated_obratniy_klapan_sigmavent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_kolichestvo_obratnih_klapanov_sigmavent;
        private System.Windows.Forms.Button button_create_obratniy_klapan_sigmavent;
        private System.Windows.Forms.Button button_cancel_obratniy_klapan_sigmavent;
    }
}