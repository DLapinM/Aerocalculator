namespace Aerocalculator
{
    partial class Form_making_otvod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_making_otvod));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_ugol_povorota_otvoda = new System.Windows.Forms.NumericUpDown();
            this.radioButton_povorot_vdol_visoti = new System.Windows.Forms.RadioButton();
            this.radioButton_povorot_vdol_shirini = new System.Windows.Forms.RadioButton();
            this.pictureBox_povorot_vdol_visoti = new System.Windows.Forms.PictureBox();
            this.pictureBox_povorot_vdol_shirini = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_kolichestvo_otvodov = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ugol_povorota_otvoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_povorot_vdol_visoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_povorot_vdol_shirini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_otvodov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Угол поворота отвода:";
            // 
            // numericUpDown_ugol_povorota_otvoda
            // 
            this.numericUpDown_ugol_povorota_otvoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_ugol_povorota_otvoda.Location = new System.Drawing.Point(341, 27);
            this.numericUpDown_ugol_povorota_otvoda.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown_ugol_povorota_otvoda.Name = "numericUpDown_ugol_povorota_otvoda";
            this.numericUpDown_ugol_povorota_otvoda.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_ugol_povorota_otvoda.TabIndex = 1;
            this.numericUpDown_ugol_povorota_otvoda.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // radioButton_povorot_vdol_visoti
            // 
            this.radioButton_povorot_vdol_visoti.AutoSize = true;
            this.radioButton_povorot_vdol_visoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_povorot_vdol_visoti.Location = new System.Drawing.Point(204, 126);
            this.radioButton_povorot_vdol_visoti.Name = "radioButton_povorot_vdol_visoti";
            this.radioButton_povorot_vdol_visoti.Size = new System.Drawing.Size(354, 24);
            this.radioButton_povorot_vdol_visoti.TabIndex = 2;
            this.radioButton_povorot_vdol_visoti.TabStop = true;
            this.radioButton_povorot_vdol_visoti.Text = "Поворот вокруг оси, параллельной высоте";
            this.radioButton_povorot_vdol_visoti.UseVisualStyleBackColor = true;
            this.radioButton_povorot_vdol_visoti.CheckedChanged += new System.EventHandler(this.radioButton_povorot_vdol_visoti_CheckedChanged);
            // 
            // radioButton_povorot_vdol_shirini
            // 
            this.radioButton_povorot_vdol_shirini.AutoSize = true;
            this.radioButton_povorot_vdol_shirini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_povorot_vdol_shirini.Location = new System.Drawing.Point(201, 262);
            this.radioButton_povorot_vdol_shirini.Name = "radioButton_povorot_vdol_shirini";
            this.radioButton_povorot_vdol_shirini.Size = new System.Drawing.Size(357, 24);
            this.radioButton_povorot_vdol_shirini.TabIndex = 3;
            this.radioButton_povorot_vdol_shirini.TabStop = true;
            this.radioButton_povorot_vdol_shirini.Text = "Поворот вокруг оси, параллельной ширине";
            this.radioButton_povorot_vdol_shirini.UseVisualStyleBackColor = true;
            this.radioButton_povorot_vdol_shirini.CheckedChanged += new System.EventHandler(this.radioButton_povorot_vdol_shirini_CheckedChanged);
            // 
            // pictureBox_povorot_vdol_visoti
            // 
            this.pictureBox_povorot_vdol_visoti.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_povorot_vdol_visoti.Image")));
            this.pictureBox_povorot_vdol_visoti.Location = new System.Drawing.Point(35, 84);
            this.pictureBox_povorot_vdol_visoti.Name = "pictureBox_povorot_vdol_visoti";
            this.pictureBox_povorot_vdol_visoti.Size = new System.Drawing.Size(139, 108);
            this.pictureBox_povorot_vdol_visoti.TabIndex = 4;
            this.pictureBox_povorot_vdol_visoti.TabStop = false;
            // 
            // pictureBox_povorot_vdol_shirini
            // 
            this.pictureBox_povorot_vdol_shirini.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_povorot_vdol_shirini.Image")));
            this.pictureBox_povorot_vdol_shirini.Location = new System.Drawing.Point(35, 222);
            this.pictureBox_povorot_vdol_shirini.Name = "pictureBox_povorot_vdol_shirini";
            this.pictureBox_povorot_vdol_shirini.Size = new System.Drawing.Size(139, 108);
            this.pictureBox_povorot_vdol_shirini.TabIndex = 5;
            this.pictureBox_povorot_vdol_shirini.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(331, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить отвод(ы)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(58, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество добавляемых отводов:";
            // 
            // numericUpDown_kolichestvo_otvodov
            // 
            this.numericUpDown_kolichestvo_otvodov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_kolichestvo_otvodov.Location = new System.Drawing.Point(376, 371);
            this.numericUpDown_kolichestvo_otvodov.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_otvodov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_kolichestvo_otvodov.Name = "numericUpDown_kolichestvo_otvodov";
            this.numericUpDown_kolichestvo_otvodov.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_kolichestvo_otvodov.TabIndex = 9;
            this.numericUpDown_kolichestvo_otvodov.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form_making_otvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 504);
            this.Controls.Add(this.numericUpDown_kolichestvo_otvodov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_povorot_vdol_shirini);
            this.Controls.Add(this.pictureBox_povorot_vdol_visoti);
            this.Controls.Add(this.radioButton_povorot_vdol_shirini);
            this.Controls.Add(this.radioButton_povorot_vdol_visoti);
            this.Controls.Add(this.numericUpDown_ugol_povorota_otvoda);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(597, 547);
            this.Name = "Form_making_otvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление отвода";
            this.Load += new System.EventHandler(this.Form_making_otvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ugol_povorota_otvoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_povorot_vdol_visoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_povorot_vdol_shirini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kolichestvo_otvodov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_ugol_povorota_otvoda;
        private System.Windows.Forms.RadioButton radioButton_povorot_vdol_visoti;
        private System.Windows.Forms.RadioButton radioButton_povorot_vdol_shirini;
        private System.Windows.Forms.PictureBox pictureBox_povorot_vdol_visoti;
        private System.Windows.Forms.PictureBox pictureBox_povorot_vdol_shirini;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_kolichestvo_otvodov;
    }
}