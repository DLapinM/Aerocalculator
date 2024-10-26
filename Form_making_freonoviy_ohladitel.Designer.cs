namespace Aerocalculator
{
    partial class Form_making_freonoviy_ohladitel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_making_freonoviy_ohladitel));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_kolichestvo_freonovih_ohladiteley = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_freonovih_ohladiteley)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество фреоновых охладителей для добавления:";
            // 
            // numericUpDown_kolichestvo_freonovih_ohladiteley
            // 
            this.numericUpDown_kolichestvo_freonovih_ohladiteley.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_kolichestvo_freonovih_ohladiteley.Location = new System.Drawing.Point(502, 38);
            this.numericUpDown_kolichestvo_freonovih_ohladiteley.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_freonovih_ohladiteley.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_freonovih_ohladiteley.Name = "numericUpDown_kolichestvo_freonovih_ohladiteley";
            this.numericUpDown_kolichestvo_freonovih_ohladiteley.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_kolichestvo_freonovih_ohladiteley.TabIndex = 1;
            this.numericUpDown_kolichestvo_freonovih_ohladiteley.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(352, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить охладитель";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(80, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form_making_freonoviy_ohladitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 172);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_kolichestvo_freonovih_ohladiteley);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(691, 215);
            this.Name = "Form_making_freonoviy_ohladitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление фреонового охладителя";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_freonovih_ohladiteley)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_kolichestvo_freonovih_ohladiteley;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}