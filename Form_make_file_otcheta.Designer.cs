namespace Aerocalculator
{
    partial class Form_make_file_otcheta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_make_file_otcheta));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name_of_file_otcheta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_search_of_folders = new System.Windows.Forms.Button();
            this.button_otchet_create = new System.Windows.Forms.Button();
            this.button_otchet_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_folder_otchet_path = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите имя файла html с результатами расчёта:";
            // 
            // textBox_name_of_file_otcheta
            // 
            this.textBox_name_of_file_otcheta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name_of_file_otcheta.Location = new System.Drawing.Point(441, 30);
            this.textBox_name_of_file_otcheta.MaximumSize = new System.Drawing.Size(380, 26);
            this.textBox_name_of_file_otcheta.Name = "textBox_name_of_file_otcheta";
            this.textBox_name_of_file_otcheta.Size = new System.Drawing.Size(380, 26);
            this.textBox_name_of_file_otcheta.TabIndex = 1;
            this.textBox_name_of_file_otcheta.Text = "Результаты_аэродинамического_расчёта_1";
            this.textBox_name_of_file_otcheta.TextChanged += new System.EventHandler(this.textBox_name_of_file_otcheta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите папку на компьютере для сохранения файла:";
            // 
            // button_search_of_folders
            // 
            this.button_search_of_folders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search_of_folders.Location = new System.Drawing.Point(471, 104);
            this.button_search_of_folders.Name = "button_search_of_folders";
            this.button_search_of_folders.Size = new System.Drawing.Size(161, 34);
            this.button_search_of_folders.TabIndex = 3;
            this.button_search_of_folders.Text = "Обзор...";
            this.button_search_of_folders.UseVisualStyleBackColor = true;
            this.button_search_of_folders.Click += new System.EventHandler(this.button_search_of_folders_Click);
            // 
            // button_otchet_create
            // 
            this.button_otchet_create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_otchet_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_otchet_create.Location = new System.Drawing.Point(372, 245);
            this.button_otchet_create.Name = "button_otchet_create";
            this.button_otchet_create.Size = new System.Drawing.Size(396, 34);
            this.button_otchet_create.TabIndex = 4;
            this.button_otchet_create.Text = "Выполнить расчёт и сохранить данные";
            this.button_otchet_create.UseVisualStyleBackColor = true;
            this.button_otchet_create.Click += new System.EventHandler(this.button_otchet_create_Click);
            // 
            // button_otchet_cancel
            // 
            this.button_otchet_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_otchet_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_otchet_cancel.Location = new System.Drawing.Point(93, 245);
            this.button_otchet_cancel.Name = "button_otchet_cancel";
            this.button_otchet_cancel.Size = new System.Drawing.Size(152, 34);
            this.button_otchet_cancel.TabIndex = 5;
            this.button_otchet_cancel.Text = "Отмена";
            this.button_otchet_cancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Путь к папке для сохранения:";
            // 
            // textBox_folder_otchet_path
            // 
            this.textBox_folder_otchet_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_folder_otchet_path.Location = new System.Drawing.Point(282, 177);
            this.textBox_folder_otchet_path.Name = "textBox_folder_otchet_path";
            this.textBox_folder_otchet_path.Size = new System.Drawing.Size(539, 26);
            this.textBox_folder_otchet_path.TabIndex = 7;
            // 
            // Form_make_file_otcheta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 311);
            this.Controls.Add(this.textBox_folder_otchet_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_otchet_cancel);
            this.Controls.Add(this.button_otchet_create);
            this.Controls.Add(this.button_search_of_folders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name_of_file_otcheta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_make_file_otcheta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные для сохранения файла отчёта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name_of_file_otcheta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_search_of_folders;
        private System.Windows.Forms.Button button_otchet_create;
        private System.Windows.Forms.Button button_otchet_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_folder_otchet_path;
    }
}