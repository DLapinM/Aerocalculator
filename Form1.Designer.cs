namespace Aerocalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_vent_systems = new System.Windows.Forms.ListBox();
            this.button_add_vent_sys = new System.Windows.Forms.Button();
            this.button_delete_vent_sys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_uchastki = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_mestnie_soprotivlenia = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_create_uchastok = new System.Windows.Forms.Button();
            this.button_edit_uchastok = new System.Windows.Forms.Button();
            this.button_delete_uchastok = new System.Windows.Forms.Button();
            this.button_create_mestnoe_soprotivlenie = new System.Windows.Forms.Button();
            this.button_delete_mestnoe_soprotivlenie = new System.Windows.Forms.Button();
            this.button_move_vent_system_up = new System.Windows.Forms.Button();
            this.button_move_vent_system_down = new System.Windows.Forms.Button();
            this.button_delete_mestnie_soprotivlenia_before = new System.Windows.Forms.Button();
            this.button_delete_mestnie_soprotivlenia_after = new System.Windows.Forms.Button();
            this.button_delete_mestnie_soprotivlenia_all = new System.Windows.Forms.Button();
            this.button_move_mestnoe_soprotivlenie_up = new System.Windows.Forms.Button();
            this.button_move_mestnoe_soprotivlenie_down = new System.Windows.Forms.Button();
            this.button_move_uchastok_up = new System.Windows.Forms.Button();
            this.button_move_uchastok_down = new System.Windows.Forms.Button();
            this.button_edit_vent_sys = new System.Windows.Forms.Button();
            this.button_make_airodynamic_calculation = new System.Windows.Forms.Button();
            this.button_save_data = new System.Windows.Forms.Button();
            this.button_add_data = new System.Windows.Forms.Button();
            this.button_clear_all_data = new System.Windows.Forms.Button();
            this.button_data_analizing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вызвать консоль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_vent_systems
            // 
            this.listBox_vent_systems.FormattingEnabled = true;
            this.listBox_vent_systems.Location = new System.Drawing.Point(43, 47);
            this.listBox_vent_systems.Name = "listBox_vent_systems";
            this.listBox_vent_systems.Size = new System.Drawing.Size(217, 446);
            this.listBox_vent_systems.TabIndex = 1;
            this.listBox_vent_systems.SelectedIndexChanged += new System.EventHandler(this.listBox_vent_systems_SelectedIndexChanged);
            this.listBox_vent_systems.SelectedValueChanged += new System.EventHandler(this.listBox_vent_systems_SelectedValueChanged);
            // 
            // button_add_vent_sys
            // 
            this.button_add_vent_sys.Location = new System.Drawing.Point(57, 518);
            this.button_add_vent_sys.Name = "button_add_vent_sys";
            this.button_add_vent_sys.Size = new System.Drawing.Size(190, 34);
            this.button_add_vent_sys.TabIndex = 2;
            this.button_add_vent_sys.Text = "Добавить систему вентиляции";
            this.button_add_vent_sys.UseVisualStyleBackColor = true;
            this.button_add_vent_sys.Click += new System.EventHandler(this.button_add_vent_sys_Click);
            // 
            // button_delete_vent_sys
            // 
            this.button_delete_vent_sys.Location = new System.Drawing.Point(57, 618);
            this.button_delete_vent_sys.Name = "button_delete_vent_sys";
            this.button_delete_vent_sys.Size = new System.Drawing.Size(190, 34);
            this.button_delete_vent_sys.TabIndex = 3;
            this.button_delete_vent_sys.Text = "Удалить систему вентиляции";
            this.button_delete_vent_sys.UseVisualStyleBackColor = true;
            this.button_delete_vent_sys.EnabledChanged += new System.EventHandler(this.button_delete_vent_sys_EnabledChanged);
            this.button_delete_vent_sys.Click += new System.EventHandler(this.button_delete_vent_sys_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список систем вентиляции:";
            // 
            // listBox_uchastki
            // 
            this.listBox_uchastki.FormattingEnabled = true;
            this.listBox_uchastki.Location = new System.Drawing.Point(325, 47);
            this.listBox_uchastki.Name = "listBox_uchastki";
            this.listBox_uchastki.Size = new System.Drawing.Size(612, 446);
            this.listBox_uchastki.TabIndex = 5;
            this.listBox_uchastki.SelectedIndexChanged += new System.EventHandler(this.listBox_uchastki_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список участков системы:";
            // 
            // listBox_mestnie_soprotivlenia
            // 
            this.listBox_mestnie_soprotivlenia.FormattingEnabled = true;
            this.listBox_mestnie_soprotivlenia.Location = new System.Drawing.Point(1005, 47);
            this.listBox_mestnie_soprotivlenia.Name = "listBox_mestnie_soprotivlenia";
            this.listBox_mestnie_soprotivlenia.Size = new System.Drawing.Size(457, 446);
            this.listBox_mestnie_soprotivlenia.TabIndex = 7;
            this.listBox_mestnie_soprotivlenia.SelectedIndexChanged += new System.EventHandler(this.listBox_mestnie_soprotivlenia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1145, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Список местных сопротивлений:";
            // 
            // button_create_uchastok
            // 
            this.button_create_uchastok.Location = new System.Drawing.Point(395, 518);
            this.button_create_uchastok.Name = "button_create_uchastok";
            this.button_create_uchastok.Size = new System.Drawing.Size(143, 34);
            this.button_create_uchastok.TabIndex = 9;
            this.button_create_uchastok.Text = "Добавить участок";
            this.button_create_uchastok.UseVisualStyleBackColor = true;
            this.button_create_uchastok.Click += new System.EventHandler(this.button_create_uchastok_Click);
            // 
            // button_edit_uchastok
            // 
            this.button_edit_uchastok.Location = new System.Drawing.Point(561, 518);
            this.button_edit_uchastok.Name = "button_edit_uchastok";
            this.button_edit_uchastok.Size = new System.Drawing.Size(143, 34);
            this.button_edit_uchastok.TabIndex = 10;
            this.button_edit_uchastok.Text = "Редактировать участок";
            this.button_edit_uchastok.UseVisualStyleBackColor = true;
            this.button_edit_uchastok.Click += new System.EventHandler(this.button_edit_uchastok_Click);
            // 
            // button_delete_uchastok
            // 
            this.button_delete_uchastok.Location = new System.Drawing.Point(728, 518);
            this.button_delete_uchastok.Name = "button_delete_uchastok";
            this.button_delete_uchastok.Size = new System.Drawing.Size(143, 34);
            this.button_delete_uchastok.TabIndex = 11;
            this.button_delete_uchastok.Text = "Удалить участок";
            this.button_delete_uchastok.UseVisualStyleBackColor = true;
            this.button_delete_uchastok.EnabledChanged += new System.EventHandler(this.button_delete_uchastok_EnabledChanged);
            this.button_delete_uchastok.Click += new System.EventHandler(this.button_delete_uchastok_Click);
            // 
            // button_create_mestnoe_soprotivlenie
            // 
            this.button_create_mestnoe_soprotivlenie.Location = new System.Drawing.Point(1005, 518);
            this.button_create_mestnoe_soprotivlenie.Name = "button_create_mestnoe_soprotivlenie";
            this.button_create_mestnoe_soprotivlenie.Size = new System.Drawing.Size(216, 34);
            this.button_create_mestnoe_soprotivlenie.TabIndex = 12;
            this.button_create_mestnoe_soprotivlenie.Text = "Добавить местное сопротивление";
            this.button_create_mestnoe_soprotivlenie.UseVisualStyleBackColor = true;
            this.button_create_mestnoe_soprotivlenie.EnabledChanged += new System.EventHandler(this.button_create_mestnoe_soprotivlenie_EnabledChanged);
            this.button_create_mestnoe_soprotivlenie.Click += new System.EventHandler(this.button_create_mestnoe_soprotivlenie_Click);
            // 
            // button_delete_mestnoe_soprotivlenie
            // 
            this.button_delete_mestnoe_soprotivlenie.Location = new System.Drawing.Point(1005, 568);
            this.button_delete_mestnoe_soprotivlenie.Name = "button_delete_mestnoe_soprotivlenie";
            this.button_delete_mestnoe_soprotivlenie.Size = new System.Drawing.Size(216, 34);
            this.button_delete_mestnoe_soprotivlenie.TabIndex = 13;
            this.button_delete_mestnoe_soprotivlenie.Text = "Удалить местное сопротивление";
            this.button_delete_mestnoe_soprotivlenie.UseVisualStyleBackColor = true;
            this.button_delete_mestnoe_soprotivlenie.EnabledChanged += new System.EventHandler(this.button_delete_mestnoe_soprotivlenie_EnabledChanged);
            this.button_delete_mestnoe_soprotivlenie.Click += new System.EventHandler(this.button_delete_mestnoe_soprotivlenie_Click);
            // 
            // button_move_vent_system_up
            // 
            this.button_move_vent_system_up.Image = ((System.Drawing.Image)(resources.GetObject("button_move_vent_system_up.Image")));
            this.button_move_vent_system_up.Location = new System.Drawing.Point(270, 160);
            this.button_move_vent_system_up.Name = "button_move_vent_system_up";
            this.button_move_vent_system_up.Size = new System.Drawing.Size(45, 75);
            this.button_move_vent_system_up.TabIndex = 14;
            this.button_move_vent_system_up.UseVisualStyleBackColor = true;
            this.button_move_vent_system_up.Click += new System.EventHandler(this.button_move_vent_system_up_Click);
            // 
            // button_move_vent_system_down
            // 
            this.button_move_vent_system_down.Image = ((System.Drawing.Image)(resources.GetObject("button_move_vent_system_down.Image")));
            this.button_move_vent_system_down.Location = new System.Drawing.Point(270, 292);
            this.button_move_vent_system_down.Name = "button_move_vent_system_down";
            this.button_move_vent_system_down.Size = new System.Drawing.Size(45, 75);
            this.button_move_vent_system_down.TabIndex = 15;
            this.button_move_vent_system_down.UseVisualStyleBackColor = true;
            this.button_move_vent_system_down.Click += new System.EventHandler(this.button_move_vent_system_down_Click);
            // 
            // button_delete_mestnie_soprotivlenia_before
            // 
            this.button_delete_mestnie_soprotivlenia_before.Location = new System.Drawing.Point(1249, 518);
            this.button_delete_mestnie_soprotivlenia_before.Name = "button_delete_mestnie_soprotivlenia_before";
            this.button_delete_mestnie_soprotivlenia_before.Size = new System.Drawing.Size(213, 34);
            this.button_delete_mestnie_soprotivlenia_before.TabIndex = 16;
            this.button_delete_mestnie_soprotivlenia_before.Text = "Удалить всё до выделения";
            this.button_delete_mestnie_soprotivlenia_before.UseVisualStyleBackColor = true;
            this.button_delete_mestnie_soprotivlenia_before.Click += new System.EventHandler(this.button_delete_mestnie_soprotivlenia_before_Click);
            // 
            // button_delete_mestnie_soprotivlenia_after
            // 
            this.button_delete_mestnie_soprotivlenia_after.Location = new System.Drawing.Point(1249, 568);
            this.button_delete_mestnie_soprotivlenia_after.Name = "button_delete_mestnie_soprotivlenia_after";
            this.button_delete_mestnie_soprotivlenia_after.Size = new System.Drawing.Size(213, 34);
            this.button_delete_mestnie_soprotivlenia_after.TabIndex = 17;
            this.button_delete_mestnie_soprotivlenia_after.Text = "Удалить всё после выделения";
            this.button_delete_mestnie_soprotivlenia_after.UseVisualStyleBackColor = true;
            this.button_delete_mestnie_soprotivlenia_after.Click += new System.EventHandler(this.button_delete_mestnie_soprotivlenia_after_Click);
            // 
            // button_delete_mestnie_soprotivlenia_all
            // 
            this.button_delete_mestnie_soprotivlenia_all.Location = new System.Drawing.Point(1249, 618);
            this.button_delete_mestnie_soprotivlenia_all.Name = "button_delete_mestnie_soprotivlenia_all";
            this.button_delete_mestnie_soprotivlenia_all.Size = new System.Drawing.Size(213, 34);
            this.button_delete_mestnie_soprotivlenia_all.TabIndex = 18;
            this.button_delete_mestnie_soprotivlenia_all.Text = "Удалить все сопротивления";
            this.button_delete_mestnie_soprotivlenia_all.UseVisualStyleBackColor = true;
            this.button_delete_mestnie_soprotivlenia_all.Click += new System.EventHandler(this.button_delete_mestnie_soprotivlenia_all_Click);
            // 
            // button_move_mestnoe_soprotivlenie_up
            // 
            this.button_move_mestnoe_soprotivlenie_up.Image = ((System.Drawing.Image)(resources.GetObject("button_move_mestnoe_soprotivlenie_up.Image")));
            this.button_move_mestnoe_soprotivlenie_up.Location = new System.Drawing.Point(1476, 160);
            this.button_move_mestnoe_soprotivlenie_up.Name = "button_move_mestnoe_soprotivlenie_up";
            this.button_move_mestnoe_soprotivlenie_up.Size = new System.Drawing.Size(45, 75);
            this.button_move_mestnoe_soprotivlenie_up.TabIndex = 19;
            this.button_move_mestnoe_soprotivlenie_up.UseVisualStyleBackColor = true;
            this.button_move_mestnoe_soprotivlenie_up.Click += new System.EventHandler(this.button_move_mestnoe_soprotivlenie_up_Click);
            // 
            // button_move_mestnoe_soprotivlenie_down
            // 
            this.button_move_mestnoe_soprotivlenie_down.Image = ((System.Drawing.Image)(resources.GetObject("button_move_mestnoe_soprotivlenie_down.Image")));
            this.button_move_mestnoe_soprotivlenie_down.Location = new System.Drawing.Point(1476, 292);
            this.button_move_mestnoe_soprotivlenie_down.Name = "button_move_mestnoe_soprotivlenie_down";
            this.button_move_mestnoe_soprotivlenie_down.Size = new System.Drawing.Size(45, 75);
            this.button_move_mestnoe_soprotivlenie_down.TabIndex = 20;
            this.button_move_mestnoe_soprotivlenie_down.UseVisualStyleBackColor = true;
            this.button_move_mestnoe_soprotivlenie_down.Click += new System.EventHandler(this.button_move_mestnoe_soprotivlenie_down_Click);
            // 
            // button_move_uchastok_up
            // 
            this.button_move_uchastok_up.Image = ((System.Drawing.Image)(resources.GetObject("button_move_uchastok_up.Image")));
            this.button_move_uchastok_up.Location = new System.Drawing.Point(949, 160);
            this.button_move_uchastok_up.Name = "button_move_uchastok_up";
            this.button_move_uchastok_up.Size = new System.Drawing.Size(45, 75);
            this.button_move_uchastok_up.TabIndex = 21;
            this.button_move_uchastok_up.UseVisualStyleBackColor = true;
            this.button_move_uchastok_up.Click += new System.EventHandler(this.button_move_uchastok_up_Click);
            // 
            // button_move_uchastok_down
            // 
            this.button_move_uchastok_down.Image = ((System.Drawing.Image)(resources.GetObject("button_move_uchastok_down.Image")));
            this.button_move_uchastok_down.Location = new System.Drawing.Point(949, 292);
            this.button_move_uchastok_down.Name = "button_move_uchastok_down";
            this.button_move_uchastok_down.Size = new System.Drawing.Size(45, 75);
            this.button_move_uchastok_down.TabIndex = 22;
            this.button_move_uchastok_down.UseVisualStyleBackColor = true;
            this.button_move_uchastok_down.Click += new System.EventHandler(this.button_move_uchastok_down_Click);
            // 
            // button_edit_vent_sys
            // 
            this.button_edit_vent_sys.Location = new System.Drawing.Point(57, 568);
            this.button_edit_vent_sys.Name = "button_edit_vent_sys";
            this.button_edit_vent_sys.Size = new System.Drawing.Size(190, 34);
            this.button_edit_vent_sys.TabIndex = 23;
            this.button_edit_vent_sys.Text = "Редактировать систему";
            this.button_edit_vent_sys.UseVisualStyleBackColor = true;
            this.button_edit_vent_sys.Click += new System.EventHandler(this.button_edit_vent_sys_Click);
            // 
            // button_make_airodynamic_calculation
            // 
            this.button_make_airodynamic_calculation.Location = new System.Drawing.Point(395, 568);
            this.button_make_airodynamic_calculation.Name = "button_make_airodynamic_calculation";
            this.button_make_airodynamic_calculation.Size = new System.Drawing.Size(476, 34);
            this.button_make_airodynamic_calculation.TabIndex = 24;
            this.button_make_airodynamic_calculation.Text = "Выполнить аэродинамический расчёт систем вентиляции и сформировать отчёт";
            this.button_make_airodynamic_calculation.UseVisualStyleBackColor = true;
            this.button_make_airodynamic_calculation.Click += new System.EventHandler(this.button_make_airodynamic_calculation_Click);
            // 
            // button_save_data
            // 
            this.button_save_data.Location = new System.Drawing.Point(313, 618);
            this.button_save_data.Name = "button_save_data";
            this.button_save_data.Size = new System.Drawing.Size(143, 34);
            this.button_save_data.TabIndex = 25;
            this.button_save_data.Text = "Сохранить данные...";
            this.button_save_data.UseVisualStyleBackColor = true;
            this.button_save_data.Click += new System.EventHandler(this.button_save_data_Click);
            // 
            // button_add_data
            // 
            this.button_add_data.Location = new System.Drawing.Point(479, 618);
            this.button_add_data.Name = "button_add_data";
            this.button_add_data.Size = new System.Drawing.Size(143, 34);
            this.button_add_data.TabIndex = 26;
            this.button_add_data.Text = "Загрузить данные...";
            this.button_add_data.UseVisualStyleBackColor = true;
            this.button_add_data.Click += new System.EventHandler(this.button_add_data_Click);
            // 
            // button_clear_all_data
            // 
            this.button_clear_all_data.Location = new System.Drawing.Point(646, 618);
            this.button_clear_all_data.Name = "button_clear_all_data";
            this.button_clear_all_data.Size = new System.Drawing.Size(143, 34);
            this.button_clear_all_data.TabIndex = 27;
            this.button_clear_all_data.Text = "Очистить все данные";
            this.button_clear_all_data.UseVisualStyleBackColor = true;
            this.button_clear_all_data.Click += new System.EventHandler(this.button_clear_all_data_Click);
            // 
            // button_data_analizing
            // 
            this.button_data_analizing.Location = new System.Drawing.Point(812, 618);
            this.button_data_analizing.Name = "button_data_analizing";
            this.button_data_analizing.Size = new System.Drawing.Size(143, 34);
            this.button_data_analizing.TabIndex = 28;
            this.button_data_analizing.Text = "Анализировать данные...\r\n";
            this.button_data_analizing.UseVisualStyleBackColor = true;
            this.button_data_analizing.Click += new System.EventHandler(this.button_data_analizing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 670);
            this.Controls.Add(this.button_data_analizing);
            this.Controls.Add(this.button_clear_all_data);
            this.Controls.Add(this.button_add_data);
            this.Controls.Add(this.button_save_data);
            this.Controls.Add(this.button_make_airodynamic_calculation);
            this.Controls.Add(this.button_edit_vent_sys);
            this.Controls.Add(this.button_move_uchastok_down);
            this.Controls.Add(this.button_move_uchastok_up);
            this.Controls.Add(this.button_move_mestnoe_soprotivlenie_down);
            this.Controls.Add(this.button_move_mestnoe_soprotivlenie_up);
            this.Controls.Add(this.button_delete_mestnie_soprotivlenia_all);
            this.Controls.Add(this.button_delete_mestnie_soprotivlenia_after);
            this.Controls.Add(this.button_delete_mestnie_soprotivlenia_before);
            this.Controls.Add(this.button_move_vent_system_down);
            this.Controls.Add(this.button_move_vent_system_up);
            this.Controls.Add(this.button_delete_mestnoe_soprotivlenie);
            this.Controls.Add(this.button_create_mestnoe_soprotivlenie);
            this.Controls.Add(this.button_delete_uchastok);
            this.Controls.Add(this.button_edit_uchastok);
            this.Controls.Add(this.button_create_uchastok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_mestnie_soprotivlenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_uchastki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_delete_vent_sys);
            this.Controls.Add(this.button_add_vent_sys);
            this.Controls.Add(this.listBox_vent_systems);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1552, 713);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аэродинамический калькулятор инженера Лапина (версия 1.0)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_vent_systems;
        private System.Windows.Forms.Button button_add_vent_sys;
        private System.Windows.Forms.Button button_delete_vent_sys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_uchastki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_mestnie_soprotivlenia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_create_uchastok;
        private System.Windows.Forms.Button button_edit_uchastok;
        private System.Windows.Forms.Button button_delete_uchastok;
        private System.Windows.Forms.Button button_create_mestnoe_soprotivlenie;
        private System.Windows.Forms.Button button_delete_mestnoe_soprotivlenie;
        private System.Windows.Forms.Button button_move_vent_system_up;
        private System.Windows.Forms.Button button_move_vent_system_down;
        private System.Windows.Forms.Button button_delete_mestnie_soprotivlenia_before;
        private System.Windows.Forms.Button button_delete_mestnie_soprotivlenia_after;
        private System.Windows.Forms.Button button_delete_mestnie_soprotivlenia_all;
        private System.Windows.Forms.Button button_move_mestnoe_soprotivlenie_up;
        private System.Windows.Forms.Button button_move_mestnoe_soprotivlenie_down;
        private System.Windows.Forms.Button button_move_uchastok_up;
        private System.Windows.Forms.Button button_move_uchastok_down;
        private System.Windows.Forms.Button button_edit_vent_sys;
        private System.Windows.Forms.Button button_make_airodynamic_calculation;
        private System.Windows.Forms.Button button_save_data;
        private System.Windows.Forms.Button button_add_data;
        private System.Windows.Forms.Button button_clear_all_data;
        private System.Windows.Forms.Button button_data_analizing;
    }
}

