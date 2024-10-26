namespace Aerocalculator
{
    partial class Form_edit_vent_sys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_edit_vent_sys));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomer_vent_sys_edit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_napor_vent_sys_edit = new System.Windows.Forms.NumericUpDown();
            this.button_vent_sys_edit_ok = new System.Windows.Forms.Button();
            this.button_vent_sys_edit_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_napor_vent_sys_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер системы вентиляции (после буквенного обозначения):";
            // 
            // textBox_nomer_vent_sys_edit
            // 
            this.textBox_nomer_vent_sys_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_nomer_vent_sys_edit.Location = new System.Drawing.Point(528, 25);
            this.textBox_nomer_vent_sys_edit.Name = "textBox_nomer_vent_sys_edit";
            this.textBox_nomer_vent_sys_edit.Size = new System.Drawing.Size(161, 26);
            this.textBox_nomer_vent_sys_edit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Напор вентилятора или вентиляционной установки, Па:";
            // 
            // numericUpDown_napor_vent_sys_edit
            // 
            this.numericUpDown_napor_vent_sys_edit.DecimalPlaces = 2;
            this.numericUpDown_napor_vent_sys_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_napor_vent_sys_edit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_napor_vent_sys_edit.Location = new System.Drawing.Point(528, 101);
            this.numericUpDown_napor_vent_sys_edit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_napor_vent_sys_edit.Name = "numericUpDown_napor_vent_sys_edit";
            this.numericUpDown_napor_vent_sys_edit.Size = new System.Drawing.Size(161, 26);
            this.numericUpDown_napor_vent_sys_edit.TabIndex = 3;
            // 
            // button_vent_sys_edit_ok
            // 
            this.button_vent_sys_edit_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_vent_sys_edit_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_vent_sys_edit_ok.Location = new System.Drawing.Point(409, 183);
            this.button_vent_sys_edit_ok.Name = "button_vent_sys_edit_ok";
            this.button_vent_sys_edit_ok.Size = new System.Drawing.Size(205, 38);
            this.button_vent_sys_edit_ok.TabIndex = 4;
            this.button_vent_sys_edit_ok.Text = "Внести изменения";
            this.button_vent_sys_edit_ok.UseVisualStyleBackColor = true;
            this.button_vent_sys_edit_ok.Click += new System.EventHandler(this.button_vent_sys_edit_ok_Click);
            // 
            // button_vent_sys_edit_cancel
            // 
            this.button_vent_sys_edit_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_vent_sys_edit_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_vent_sys_edit_cancel.Location = new System.Drawing.Point(109, 183);
            this.button_vent_sys_edit_cancel.Name = "button_vent_sys_edit_cancel";
            this.button_vent_sys_edit_cancel.Size = new System.Drawing.Size(205, 38);
            this.button_vent_sys_edit_cancel.TabIndex = 5;
            this.button_vent_sys_edit_cancel.Text = "Отмена";
            this.button_vent_sys_edit_cancel.UseVisualStyleBackColor = true;
            // 
            // Form_edit_vent_sys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 251);
            this.Controls.Add(this.button_vent_sys_edit_cancel);
            this.Controls.Add(this.button_vent_sys_edit_ok);
            this.Controls.Add(this.numericUpDown_napor_vent_sys_edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nomer_vent_sys_edit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(745, 290);
            this.Name = "Form_edit_vent_sys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование параметров системы вентиляции";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_napor_vent_sys_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nomer_vent_sys_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_napor_vent_sys_edit;
        private System.Windows.Forms.Button button_vent_sys_edit_ok;
        private System.Windows.Forms.Button button_vent_sys_edit_cancel;
    }
}