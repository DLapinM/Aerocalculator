namespace Aerocalculator
{
    partial class Form_making_elektricheskiy_nagrevatel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_making_elektricheskiy_nagrevatel));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_moschnost_nagrevatelia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_kolichestvo_nagrevateley = new System.Windows.Forms.NumericUpDown();
            this.button_create_nagrevatel = new System.Windows.Forms.Button();
            this.button_cancel_nagrevatel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_moschnost_nagrevatelia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_nagrevateley)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номинальная мощность электрического нагревателя, кВт:";
            // 
            // numericUpDown_moschnost_nagrevatelia
            // 
            this.numericUpDown_moschnost_nagrevatelia.DecimalPlaces = 3;
            this.numericUpDown_moschnost_nagrevatelia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_moschnost_nagrevatelia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_moschnost_nagrevatelia.Location = new System.Drawing.Point(515, 27);
            this.numericUpDown_moschnost_nagrevatelia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_moschnost_nagrevatelia.Name = "numericUpDown_moschnost_nagrevatelia";
            this.numericUpDown_moschnost_nagrevatelia.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_moschnost_nagrevatelia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество электрических нагревателей для добавления:";
            // 
            // numericUpDown_kolichestvo_nagrevateley
            // 
            this.numericUpDown_kolichestvo_nagrevateley.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_kolichestvo_nagrevateley.Location = new System.Drawing.Point(515, 100);
            this.numericUpDown_kolichestvo_nagrevateley.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_nagrevateley.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_nagrevateley.Name = "numericUpDown_kolichestvo_nagrevateley";
            this.numericUpDown_kolichestvo_nagrevateley.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_kolichestvo_nagrevateley.TabIndex = 3;
            this.numericUpDown_kolichestvo_nagrevateley.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_create_nagrevatel
            // 
            this.button_create_nagrevatel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_create_nagrevatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create_nagrevatel.Location = new System.Drawing.Point(370, 164);
            this.button_create_nagrevatel.Name = "button_create_nagrevatel";
            this.button_create_nagrevatel.Size = new System.Drawing.Size(221, 38);
            this.button_create_nagrevatel.TabIndex = 4;
            this.button_create_nagrevatel.Text = "Добавить нагреватель";
            this.button_create_nagrevatel.UseVisualStyleBackColor = true;
            this.button_create_nagrevatel.Click += new System.EventHandler(this.button_create_nagrevatel_Click);
            // 
            // button_cancel_nagrevatel
            // 
            this.button_cancel_nagrevatel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel_nagrevatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel_nagrevatel.Location = new System.Drawing.Point(63, 164);
            this.button_cancel_nagrevatel.Name = "button_cancel_nagrevatel";
            this.button_cancel_nagrevatel.Size = new System.Drawing.Size(221, 38);
            this.button_cancel_nagrevatel.TabIndex = 5;
            this.button_cancel_nagrevatel.Text = "Отмена";
            this.button_cancel_nagrevatel.UseVisualStyleBackColor = true;
            // 
            // Form_making_elektricheskiy_nagrevatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 227);
            this.Controls.Add(this.button_cancel_nagrevatel);
            this.Controls.Add(this.button_create_nagrevatel);
            this.Controls.Add(this.numericUpDown_kolichestvo_nagrevateley);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_moschnost_nagrevatelia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(680, 270);
            this.Name = "Form_making_elektricheskiy_nagrevatel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление электрического нагревателя";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_moschnost_nagrevatelia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_nagrevateley)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_moschnost_nagrevatelia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_kolichestvo_nagrevateley;
        private System.Windows.Forms.Button button_create_nagrevatel;
        private System.Windows.Forms.Button button_cancel_nagrevatel;
    }
}