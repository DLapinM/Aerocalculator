namespace Aerocalculator
{
    partial class Form_data_analizing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_data_analizing));
            this.button_db_connect = new System.Windows.Forms.Button();
            this.button_db_disconnect = new System.Windows.Forms.Button();
            this.button_show_good_napor_ventsys = new System.Windows.Forms.Button();
            this.button_show_bad_napor_ventsys = new System.Windows.Forms.Button();
            this.button_show_perebor_napor_ventsys = new System.Windows.Forms.Button();
            this.button_show_all_ventsys = new System.Windows.Forms.Button();
            this.dataGridView_table_vs = new System.Windows.Forms.DataGridView();
            this.bindingSource_vs = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_uch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_ms = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table_vs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_vs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_uch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ms)).BeginInit();
            this.SuspendLayout();
            // 
            // button_db_connect
            // 
            this.button_db_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_db_connect.Location = new System.Drawing.Point(360, 773);
            this.button_db_connect.Name = "button_db_connect";
            this.button_db_connect.Size = new System.Drawing.Size(273, 40);
            this.button_db_connect.TabIndex = 0;
            this.button_db_connect.Text = "Подключиться к базе данных";
            this.button_db_connect.UseVisualStyleBackColor = true;
            this.button_db_connect.Click += new System.EventHandler(this.button_db_connect_Click);
            // 
            // button_db_disconnect
            // 
            this.button_db_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_db_disconnect.Location = new System.Drawing.Point(846, 773);
            this.button_db_disconnect.Name = "button_db_disconnect";
            this.button_db_disconnect.Size = new System.Drawing.Size(273, 40);
            this.button_db_disconnect.TabIndex = 1;
            this.button_db_disconnect.Text = "Отключиться от базы данных";
            this.button_db_disconnect.UseVisualStyleBackColor = true;
            this.button_db_disconnect.Click += new System.EventHandler(this.button_db_disconnect_Click);
            // 
            // button_show_good_napor_ventsys
            // 
            this.button_show_good_napor_ventsys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_show_good_napor_ventsys.Location = new System.Drawing.Point(982, 102);
            this.button_show_good_napor_ventsys.Name = "button_show_good_napor_ventsys";
            this.button_show_good_napor_ventsys.Size = new System.Drawing.Size(473, 40);
            this.button_show_good_napor_ventsys.TabIndex = 3;
            this.button_show_good_napor_ventsys.Text = "Показать системы с оптимальным напором вентилятора";
            this.button_show_good_napor_ventsys.UseVisualStyleBackColor = true;
            this.button_show_good_napor_ventsys.Click += new System.EventHandler(this.button_show_good_napor_ventsys_Click);
            // 
            // button_show_bad_napor_ventsys
            // 
            this.button_show_bad_napor_ventsys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_show_bad_napor_ventsys.Location = new System.Drawing.Point(982, 220);
            this.button_show_bad_napor_ventsys.Name = "button_show_bad_napor_ventsys";
            this.button_show_bad_napor_ventsys.Size = new System.Drawing.Size(473, 40);
            this.button_show_bad_napor_ventsys.TabIndex = 4;
            this.button_show_bad_napor_ventsys.Text = "Показать системы с недостатком напора вентилятора";
            this.button_show_bad_napor_ventsys.UseVisualStyleBackColor = true;
            this.button_show_bad_napor_ventsys.Click += new System.EventHandler(this.button_show_bad_napor_ventsys_Click);
            // 
            // button_show_perebor_napor_ventsys
            // 
            this.button_show_perebor_napor_ventsys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_show_perebor_napor_ventsys.Location = new System.Drawing.Point(982, 160);
            this.button_show_perebor_napor_ventsys.Name = "button_show_perebor_napor_ventsys";
            this.button_show_perebor_napor_ventsys.Size = new System.Drawing.Size(473, 40);
            this.button_show_perebor_napor_ventsys.TabIndex = 5;
            this.button_show_perebor_napor_ventsys.Text = "Показать системы с переизбытком напора вентилятора";
            this.button_show_perebor_napor_ventsys.UseVisualStyleBackColor = true;
            this.button_show_perebor_napor_ventsys.Click += new System.EventHandler(this.button_show_perebor_napor_ventsys_Click);
            // 
            // button_show_all_ventsys
            // 
            this.button_show_all_ventsys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_show_all_ventsys.Location = new System.Drawing.Point(982, 43);
            this.button_show_all_ventsys.Name = "button_show_all_ventsys";
            this.button_show_all_ventsys.Size = new System.Drawing.Size(473, 40);
            this.button_show_all_ventsys.TabIndex = 2;
            this.button_show_all_ventsys.Text = "Показать все системы вентиляции";
            this.button_show_all_ventsys.UseVisualStyleBackColor = true;
            this.button_show_all_ventsys.Click += new System.EventHandler(this.button_show_all_ventsys_Click);
            // 
            // dataGridView_table_vs
            // 
            this.dataGridView_table_vs.AllowUserToAddRows = false;
            this.dataGridView_table_vs.AllowUserToDeleteRows = false;
            this.dataGridView_table_vs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table_vs.Location = new System.Drawing.Point(16, 43);
            this.dataGridView_table_vs.Name = "dataGridView_table_vs";
            this.dataGridView_table_vs.ReadOnly = true;
            this.dataGridView_table_vs.Size = new System.Drawing.Size(944, 217);
            this.dataGridView_table_vs.TabIndex = 6;
            this.dataGridView_table_vs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_table_vs_CellContentClick);
            // 
            // dataGridView_uch
            // 
            this.dataGridView_uch.AllowUserToAddRows = false;
            this.dataGridView_uch.AllowUserToDeleteRows = false;
            this.dataGridView_uch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_uch.Location = new System.Drawing.Point(16, 310);
            this.dataGridView_uch.Name = "dataGridView_uch";
            this.dataGridView_uch.ReadOnly = true;
            this.dataGridView_uch.Size = new System.Drawing.Size(1445, 194);
            this.dataGridView_uch.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(376, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Данные систем вентиляции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(578, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Данные участков систем вентиляции";
            // 
            // dataGridView_ms
            // 
            this.dataGridView_ms.AllowUserToAddRows = false;
            this.dataGridView_ms.AllowUserToDeleteRows = false;
            this.dataGridView_ms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ms.Location = new System.Drawing.Point(264, 555);
            this.dataGridView_ms.Name = "dataGridView_ms";
            this.dataGridView_ms.ReadOnly = true;
            this.dataGridView_ms.Size = new System.Drawing.Size(950, 198);
            this.dataGridView_ms.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(492, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Данные местных сопротивлений участков систем вентиляции";
            // 
            // Form_data_analizing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 834);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_ms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_uch);
            this.Controls.Add(this.dataGridView_table_vs);
            this.Controls.Add(this.button_show_perebor_napor_ventsys);
            this.Controls.Add(this.button_show_bad_napor_ventsys);
            this.Controls.Add(this.button_show_good_napor_ventsys);
            this.Controls.Add(this.button_show_all_ventsys);
            this.Controls.Add(this.button_db_disconnect);
            this.Controls.Add(this.button_db_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_data_analizing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализ данных по системам вентиляции";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table_vs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_vs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_uch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_db_connect;
        private System.Windows.Forms.Button button_db_disconnect;
        private System.Windows.Forms.Button button_show_good_napor_ventsys;
        private System.Windows.Forms.Button button_show_bad_napor_ventsys;
        private System.Windows.Forms.Button button_show_perebor_napor_ventsys;
        private System.Windows.Forms.Button button_show_all_ventsys;
        private System.Windows.Forms.DataGridView dataGridView_table_vs;
        private System.Windows.Forms.BindingSource bindingSource_vs;
        private System.Windows.Forms.DataGridView dataGridView_uch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_ms;
        private System.Windows.Forms.Label label3;
    }
}