namespace Aerocalculator
{
    partial class Form_making_otvod_s_ostrimi_kromkami
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_making_otvod_s_ostrimi_kromkami));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota = new System.Windows.Forms.NumericUpDown();
            this.radioButton_povorot_vokrug_visoti = new System.Windows.Forms.RadioButton();
            this.radioButton_povorot_vokrug_shirini = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami = new System.Windows.Forms.NumericUpDown();
            this.button_add_otvod_s_ostrimi_kromkami = new System.Windows.Forms.Button();
            this.button_cancel_otvod_s_ostrimi_kromkami = new System.Windows.Forms.Button();
            this.pictureBox_povorot_vokrug_visoti = new System.Windows.Forms.PictureBox();
            this.pictureBox_povorot_vokrug_shirini = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_povorot_vokrug_visoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_povorot_vokrug_shirini)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Угол поворота отвода с острыми кромками:";
            // 
            // numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota
            // 
            this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Location = new System.Drawing.Point(421, 24);
            this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Name = "numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota";
            this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.TabIndex = 1;
            this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.ValueChanged += new System.EventHandler(this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota_ValueChanged);
            // 
            // radioButton_povorot_vokrug_visoti
            // 
            this.radioButton_povorot_vokrug_visoti.AutoSize = true;
            this.radioButton_povorot_vokrug_visoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_povorot_vokrug_visoti.Location = new System.Drawing.Point(208, 109);
            this.radioButton_povorot_vokrug_visoti.Name = "radioButton_povorot_vokrug_visoti";
            this.radioButton_povorot_vokrug_visoti.Size = new System.Drawing.Size(353, 24);
            this.radioButton_povorot_vokrug_visoti.TabIndex = 2;
            this.radioButton_povorot_vokrug_visoti.TabStop = true;
            this.radioButton_povorot_vokrug_visoti.Text = "Поворот вдоль оси, параллельной высоте";
            this.radioButton_povorot_vokrug_visoti.UseVisualStyleBackColor = true;
            this.radioButton_povorot_vokrug_visoti.CheckedChanged += new System.EventHandler(this.radioButton_povorot_vokrug_visoti_CheckedChanged);
            // 
            // radioButton_povorot_vokrug_shirini
            // 
            this.radioButton_povorot_vokrug_shirini.AutoSize = true;
            this.radioButton_povorot_vokrug_shirini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_povorot_vokrug_shirini.Location = new System.Drawing.Point(208, 248);
            this.radioButton_povorot_vokrug_shirini.Name = "radioButton_povorot_vokrug_shirini";
            this.radioButton_povorot_vokrug_shirini.Size = new System.Drawing.Size(356, 24);
            this.radioButton_povorot_vokrug_shirini.TabIndex = 3;
            this.radioButton_povorot_vokrug_shirini.TabStop = true;
            this.radioButton_povorot_vokrug_shirini.Text = "Поворот вдоль оси, параллельной ширине";
            this.radioButton_povorot_vokrug_shirini.UseVisualStyleBackColor = true;
            this.radioButton_povorot_vokrug_shirini.CheckedChanged += new System.EventHandler(this.radioButton_povorot_vokrug_shirini_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество отводов для добавления на участок:";
            // 
            // numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami
            // 
            this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami.Location = new System.Drawing.Point(443, 346);
            this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami.Name = "numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami";
            this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami.TabIndex = 5;
            this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_add_otvod_s_ostrimi_kromkami
            // 
            this.button_add_otvod_s_ostrimi_kromkami.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add_otvod_s_ostrimi_kromkami.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_otvod_s_ostrimi_kromkami.Location = new System.Drawing.Point(229, 416);
            this.button_add_otvod_s_ostrimi_kromkami.Name = "button_add_otvod_s_ostrimi_kromkami";
            this.button_add_otvod_s_ostrimi_kromkami.Size = new System.Drawing.Size(334, 39);
            this.button_add_otvod_s_ostrimi_kromkami.TabIndex = 6;
            this.button_add_otvod_s_ostrimi_kromkami.Text = "Добавить отвод(ы) с острыми кромками";
            this.button_add_otvod_s_ostrimi_kromkami.UseVisualStyleBackColor = true;
            this.button_add_otvod_s_ostrimi_kromkami.Click += new System.EventHandler(this.button_add_otvod_s_ostrimi_kromkami_Click);
            // 
            // button_cancel_otvod_s_ostrimi_kromkami
            // 
            this.button_cancel_otvod_s_ostrimi_kromkami.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel_otvod_s_ostrimi_kromkami.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel_otvod_s_ostrimi_kromkami.Location = new System.Drawing.Point(36, 416);
            this.button_cancel_otvod_s_ostrimi_kromkami.Name = "button_cancel_otvod_s_ostrimi_kromkami";
            this.button_cancel_otvod_s_ostrimi_kromkami.Size = new System.Drawing.Size(127, 39);
            this.button_cancel_otvod_s_ostrimi_kromkami.TabIndex = 7;
            this.button_cancel_otvod_s_ostrimi_kromkami.Text = "Отмена";
            this.button_cancel_otvod_s_ostrimi_kromkami.UseVisualStyleBackColor = true;
            // 
            // pictureBox_povorot_vokrug_visoti
            // 
            this.pictureBox_povorot_vokrug_visoti.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_povorot_vokrug_visoti.Image")));
            this.pictureBox_povorot_vokrug_visoti.Location = new System.Drawing.Point(40, 73);
            this.pictureBox_povorot_vokrug_visoti.Name = "pictureBox_povorot_vokrug_visoti";
            this.pictureBox_povorot_vokrug_visoti.Size = new System.Drawing.Size(150, 100);
            this.pictureBox_povorot_vokrug_visoti.TabIndex = 8;
            this.pictureBox_povorot_vokrug_visoti.TabStop = false;
            // 
            // pictureBox_povorot_vokrug_shirini
            // 
            this.pictureBox_povorot_vokrug_shirini.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_povorot_vokrug_shirini.Image")));
            this.pictureBox_povorot_vokrug_shirini.Location = new System.Drawing.Point(40, 209);
            this.pictureBox_povorot_vokrug_shirini.Name = "pictureBox_povorot_vokrug_shirini";
            this.pictureBox_povorot_vokrug_shirini.Size = new System.Drawing.Size(150, 100);
            this.pictureBox_povorot_vokrug_shirini.TabIndex = 9;
            this.pictureBox_povorot_vokrug_shirini.TabStop = false;
            // 
            // Form_making_otvod_s_ostrimi_kromkami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 486);
            this.Controls.Add(this.pictureBox_povorot_vokrug_shirini);
            this.Controls.Add(this.pictureBox_povorot_vokrug_visoti);
            this.Controls.Add(this.button_cancel_otvod_s_ostrimi_kromkami);
            this.Controls.Add(this.button_add_otvod_s_ostrimi_kromkami);
            this.Controls.Add(this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_povorot_vokrug_shirini);
            this.Controls.Add(this.radioButton_povorot_vokrug_visoti);
            this.Controls.Add(this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(617, 529);
            this.Name = "Form_making_otvod_s_ostrimi_kromkami";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление отвода с острыми кромками";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_povorot_vokrug_visoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_povorot_vokrug_shirini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota;
        private System.Windows.Forms.RadioButton radioButton_povorot_vokrug_visoti;
        private System.Windows.Forms.RadioButton radioButton_povorot_vokrug_shirini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami;
        private System.Windows.Forms.Button button_add_otvod_s_ostrimi_kromkami;
        private System.Windows.Forms.Button button_cancel_otvod_s_ostrimi_kromkami;
        private System.Windows.Forms.PictureBox pictureBox_povorot_vokrug_visoti;
        private System.Windows.Forms.PictureBox pictureBox_povorot_vokrug_shirini;
    }
}