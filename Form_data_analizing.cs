using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Aerocalculator
{
    public partial class Form_data_analizing : Form
    {
        public Form_data_analizing()
        {
            InitializeComponent();

            button_db_connect.Enabled = true;

            button_db_disconnect.Enabled = false;
            button_show_all_ventsys.Enabled = false;
            button_show_good_napor_ventsys.Enabled = false;
            button_show_bad_napor_ventsys.Enabled = false;
            button_show_perebor_napor_ventsys.Enabled = false;
        }

        SQLiteConnection connection = null;

        private void ChangeCommaToPoint(ref string s)
        {
            char[] arr_char_s = s.ToCharArray();

            string s_new = "";

            foreach (char ch in arr_char_s)
            {
                if (ch == ',')
                {
                    s_new += ".";
                }
                else
                {
                    s_new += ch.ToString();
                }
            }

            s = s_new;
        }
        private string Get_Insert_VENTSYSTEMS_String()
        {
            string vs_rez = "";

            string vs_name = "";
            string vs_poteri_davlenia = "";
            string vs_napor_trebuemiy = "";
            string vs_napor_facticheskiy = "";

            foreach (Ventilation_system vs in DataStatic.vs_list)
            {
                vs_name = vs.Name_of_sys;
                vs_poteri_davlenia = Math.Round(vs.Poteri_davlenia_v_sisteme_polnie, 2).ToString();
                vs_napor_trebuemiy = Math.Round((vs.Poteri_davlenia_v_sisteme_polnie * 1.2), 0).ToString();
                vs_napor_facticheskiy = Math.Round(vs.Napor_ventiliatora_m3_in_hour, 2).ToString();

                ChangeCommaToPoint(ref vs_poteri_davlenia);
                ChangeCommaToPoint(ref vs_napor_trebuemiy);
                ChangeCommaToPoint(ref vs_napor_facticheskiy);

                vs_rez +=
                    (
                    @"INSERT INTO VENTSYSTEMS" + Environment.NewLine +
                    @"(NAME, POTERI_DAVLENIA, NAPOR_TREBUEMIY, NAPOR_FACTICHESKIY)" + Environment.NewLine +
                    @"VALUES" + Environment.NewLine +
                    @"('" + vs_name + @"', " + vs_poteri_davlenia + @", " + vs_napor_trebuemiy + @", " + vs_napor_facticheskiy + @");" + Environment.NewLine
                    )
                ;
            }

            return vs_rez;
        }

        private string Get_Insert_UCHASTKI_String()
        {
            string uch_rez = "";

            string uch_ventsystem_id = "";
            string uch_number = "";
            string uch_rashod = "";
            string uch_length = "";
            string uch_width = "";
            string uch_height = "";
            string uch_diameter_eql = "";
            string uch_temperature = "";
            string uch_plotnost = "";
            string uch_Re = "";
            string uch_k_ekv = "";
            string uch_liambda = "";
            string uch_square = "";
            string uch_velocity = "";
            string uch_poteri_davlenia_po_dline = "";
            string uch_kms_summa = "";
            string uch_poteri_davlenia_na_mestnie_soprotivlenia = "";
            string uch_poteri_davlenia = "";

            int vs_id = 1;

            foreach (Ventilation_system vs in DataStatic.vs_list)
            {
                uch_ventsystem_id = vs_id.ToString();

                int uch_n = 1;

                foreach (Uchastok u in vs.Spisok_uchastkov)
                {
                    uch_number = uch_n.ToString();

                    uch_rashod = Math.Round(u.Rashod_m3_in_hour, 2).ToString();
                    ChangeCommaToPoint(ref uch_rashod);

                    uch_length = Math.Round(u.Length_m, 3).ToString();
                    ChangeCommaToPoint(ref uch_length);

                    uch_width = Math.Round(u.Width_mm, 0).ToString();
                    ChangeCommaToPoint(ref uch_width);

                    uch_height = Math.Round(u.Height_mm, 0).ToString();
                    ChangeCommaToPoint(ref uch_height);

                    uch_diameter_eql = Math.Round(u.Diameter_mm, 3).ToString();
                    ChangeCommaToPoint(ref uch_diameter_eql);

                    uch_temperature = Math.Round(u.t, 2).ToString();
                    ChangeCommaToPoint(ref uch_temperature);

                    uch_plotnost = Math.Round(u.plotnost, 3).ToString();
                    ChangeCommaToPoint(ref uch_plotnost);

                    uch_Re = Math.Round(u.Re, 2).ToString();
                    ChangeCommaToPoint(ref uch_Re);

                    uch_k_ekv = Math.Round(u.K_ekv, 2).ToString();
                    ChangeCommaToPoint(ref uch_k_ekv);

                    uch_liambda = Math.Round(u.Liambda, 3).ToString();
                    ChangeCommaToPoint(ref uch_liambda);

                    uch_square = Math.Round(u.f, 3).ToString();
                    ChangeCommaToPoint(ref uch_square);

                    uch_velocity = Math.Round(u.v, 3).ToString();
                    ChangeCommaToPoint(ref uch_velocity);

                    uch_poteri_davlenia_po_dline = Math.Round(u.Poteri_davlenia_po_dline_Pa, 3).ToString();
                    ChangeCommaToPoint(ref uch_poteri_davlenia_po_dline);

                    uch_kms_summa = Math.Round(u.Sum_of_kms, 2).ToString();
                    ChangeCommaToPoint(ref uch_kms_summa);

                    uch_poteri_davlenia_na_mestnie_soprotivlenia = Math.Round(u.Poteri_davlenia_na_mestnie_soprotivlenia_Pa, 3).ToString();
                    ChangeCommaToPoint(ref uch_poteri_davlenia_na_mestnie_soprotivlenia);

                    uch_poteri_davlenia = Math.Round(u.Poteri_davlenia_polnie_Pa, 3).ToString();
                    ChangeCommaToPoint(ref uch_poteri_davlenia);

                    uch_rez +=
                        (
                        @"INSERT INTO UCHASTKI " + Environment.NewLine +
                        @"(VENTSYSTEM_ID, NUMBER, RASHOD, LENGTH, WIDTH, HEIGHT, " + Environment.NewLine +
                        @"DIAMETER_EQL, TEMPERATURE, PLOTNOST, RE, K_EKV, LIAMBDA, " + Environment.NewLine +
                        @"SQUARE, VELOCITY, POTERI_DAVLENIA_PO_DLINE, KMS_SUMMA, " + Environment.NewLine +
                        @"POTERI_DAVLENIA_NA_MESTNIE_SOPROTIVLENIA, POTERI_DAVLENIA) " + Environment.NewLine +
                        @"VALUES " + Environment.NewLine +
                        @"(" + uch_ventsystem_id +
                        @", " + uch_number +
                        @", " + uch_rashod +
                        @", " + uch_length +
                        @", " + uch_width +
                        @", " + uch_height +
                        @", " + uch_diameter_eql +
                        @", " + uch_temperature +
                        @", " + uch_plotnost +
                        @", " + uch_Re +
                        @", " + uch_k_ekv +
                        @", " + uch_liambda +
                        @", " + uch_square +
                        @", " + uch_velocity +
                        @", " + uch_poteri_davlenia_po_dline +
                        @", " + uch_kms_summa +
                        @", " + uch_poteri_davlenia_na_mestnie_soprotivlenia +
                        @", " + uch_poteri_davlenia +
                        @");" + Environment.NewLine
                        )
                        ;

                    uch_n++;
                }

                vs_id++;
            }

            return uch_rez;
        }

        private string Get_Insert_MESTNIE_SOPROTIVLENIA_String()
        {
            string ms_rez = "";

            string ms_uchastok_id = "";
            string ms_name = "";
            string ms_kms = "";
            string ms_poteri_davlenia = "";

            string vs_name = "";

            foreach (Ventilation_system vs in DataStatic.vs_list)
            {
                int uch_n = 1;

                vs_name = vs.Name_of_sys;

                foreach (Uchastok u in vs.Spisok_uchastkov)
                {
                    ms_uchastok_id = uch_n.ToString();

                    foreach (Mestnoe_soprotivlenie ms in u.Spisok_soprotivleniy)
                    {
                        ms_name = ms.Name;

                        ms_kms = Math.Round(ms.KMS, 2).ToString();
                        ChangeCommaToPoint(ref ms_kms);

                        ms_poteri_davlenia = Math.Round((ms.KMS * u.plotnost * Math.Pow(u.v, 2.0) * 0.5), 2).ToString();
                        ChangeCommaToPoint(ref ms_poteri_davlenia);

                        ms_rez +=
                            (
                            @"INSERT INTO MESTNIE_SOPROTIVLENIA " + Environment.NewLine +
                            @"(UCHASTOK_ID, NAME, KMS, POTERI_DAVLENIA, VS_NAME) " + Environment.NewLine +
                            @"VALUES " + Environment.NewLine +
                            @"(" + ms_uchastok_id +
                            @", '" + ms_name + "' " +
                            @", " + ms_kms +
                            @", " + ms_poteri_davlenia +
                            @", '" + vs_name + "'" +
                            @");" + Environment.NewLine
                            );
                    }

                    uch_n++;
                }
            }

            return ms_rez;
        }
        private void button_db_connect_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Get_Insert_UCHASTKI_String());
            //System.IO.StreamWriter sw = new System.IO.StreamWriter(@"E:\x.txt");
            //sw.Write(Get_Insert_MESTNIE_SOPROTIVLENIA_String());

            try
            {
                string connectionString = @"data source='vent_systems.db'";

                connection = new SQLiteConnection(connectionString);

                connection.Open();

                SQLiteDataAdapter data_adapter_1 = new SQLiteDataAdapter(
                    @"DROP TABLE IF EXISTS MESTNIE_SOPROTIVLENIA;
                    DROP TABLE IF EXISTS UCHASTKI;
                    DROP TABLE IF EXISTS VENTSYSTEMS;
                    CREATE TABLE 'VENTSYSTEMS' (
	                    'ID'	INTEGER UNIQUE,
	                    'NAME'	TEXT NOT NULL UNIQUE,
	                    'POTERI_DAVLENIA'	REAL NOT NULL,
	                    'NAPOR_TREBUEMIY'	REAL NOT NULL,
	                    'NAPOR_FACTICHESKIY'	REAL NOT NULL,
	                    PRIMARY KEY('ID')
                    );
                    CREATE TABLE 'UCHASTKI' (
	                    'VENTSYSTEM_ID'	INTEGER NOT NULL,
	                    'ID'	INTEGER NOT NULL UNIQUE,
	                    'NUMBER'	INTEGER NOT NULL,
	                    'RASHOD'	REAL NOT NULL,
	                    'LENGTH'	REAL NOT NULL,
	                    'WIDTH'	REAL,
	                    'HEIGHT'	REAL,
	                    'DIAMETER_EQL'	REAL NOT NULL,
	                    'TEMPERATURE'	REAL NOT NULL,
	                    'PLOTNOST'	REAL NOT NULL,
	                    'RE'	REAL NOT NULL,
	                    'K_EKV'	REAL NOT NULL,
	                    'LIAMBDA'	REAL NOT NULL,
	                    'SQUARE'	REAL NOT NULL,
	                    'VELOCITY'	REAL NOT NULL,
	                    'POTERI_DAVLENIA_PO_DLINE'	REAL NOT NULL,
	                    'KMS_SUMMA'	REAL NOT NULL,
	                    'POTERI_DAVLENIA_NA_MESTNIE_SOPROTIVLENIA'	REAL NOT NULL,
	                    'POTERI_DAVLENIA'	REAL NOT NULL,
	                    PRIMARY KEY('ID'),
	                    FOREIGN KEY('VENTSYSTEM_ID') REFERENCES 'VENTSYSTEMS'('ID')
                    );
                    CREATE TABLE 'MESTNIE_SOPROTIVLENIA' (
	                    'UCHASTOK_ID'	INTEGER NOT NULL,
	                    'ID'	INTEGER NOT NULL UNIQUE,
	                    'NAME'	TEXT NOT NULL,
	                    'KMS'	REAL NOT NULL,
	                    'POTERI_DAVLENIA'	REAL NOT NULL,
                        'VS_NAME'	TEXT,
	                    PRIMARY KEY('ID'),
	                    FOREIGN KEY('UCHASTOK_ID') REFERENCES 'UCHASTKI'('ID')
                    );"
                    + Get_Insert_VENTSYSTEMS_String()
                    + Get_Insert_UCHASTKI_String()
                    + Get_Insert_MESTNIE_SOPROTIVLENIA_String() +
                    @"SELECT CAST(NAME AS TEXT) AS 'Имя системы',
                    CAST(POTERI_DAVLENIA AS TEXT) AS 'Потери давления, [Па]',
                    CAST(NAPOR_TREBUEMIY AS TEXT) AS 'Требуемый напор вентилятора, [Па]',
                    CAST(NAPOR_FACTICHESKIY AS TEXT) AS 'Фактический напор вентилятора, [Па]'
                    FROM VENTSYSTEMS;
                    ",
                    connection);

                DataSet data_set_1 = new DataSet();

                data_adapter_1.Fill(data_set_1);

                dataGridView_table_vs.DataSource = data_set_1.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_table_vs.Columns)
                {
                    c.Width = 220;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_table_vs.Columns[3].Width = 240;



                SQLiteDataAdapter data_adapter_2 = new SQLiteDataAdapter(
                    @"
                    SELECT
                    CAST(VENTSYSTEMS.NAME AS TEXT) AS 'Имя системы',
                    CAST(UCHASTKI.NUMBER AS TEXT) AS '№ уч.',
                    CAST(UCHASTKI.RASHOD AS TEXT) AS 'L, [м³/ч]',
                    CAST(UCHASTKI.LENGTH AS TEXT) AS 'l, [м]',
                    CAST(UCHASTKI.WIDTH AS TEXT) AS 'A, [мм]',
                    CAST(UCHASTKI.HEIGHT AS TEXT) AS 'B, [мм]',
                    CAST(UCHASTKI.DIAMETER_EQL AS TEXT) AS 'd экв, [мм]',
                    CAST(UCHASTKI.TEMPERATURE AS TEXT) AS 't, [°C]',
                    CAST(UCHASTKI.PLOTNOST AS TEXT) AS 'ρ, [кг/м³]',
                    CAST(UCHASTKI.RE AS TEXT) AS 'Re',
                    CAST(UCHASTKI.K_EKV AS TEXT) AS 'Kэ, [мм]',
                    CAST(UCHASTKI.LIAMBDA AS TEXT) AS 'λ',
                    CAST(UCHASTKI.SQUARE AS TEXT) AS 'Fэкв, [м²]',
                    CAST(UCHASTKI.VELOCITY AS TEXT) AS 'v, [м/с]',
                    CAST(UCHASTKI.POTERI_DAVLENIA_PO_DLINE AS TEXT) AS 'ΔPдл., [Па]',
                    CAST(UCHASTKI.KMS_SUMMA AS TEXT) AS '∑ζ',
                    CAST(UCHASTKI.POTERI_DAVLENIA_NA_MESTNIE_SOPROTIVLENIA AS TEXT) AS '∑Pм.c., [Па]',
                    CAST(UCHASTKI.POTERI_DAVLENIA AS TEXT) AS 'ΔP, [Па]'
                    FROM VENTSYSTEMS
                    INNER JOIN UCHASTKI
                    ON UCHASTKI.VENTSYSTEM_ID = VENTSYSTEMS.ID;
                    ",
                    connection);

                DataSet data_set_2 = new DataSet();

                data_adapter_2.Fill(data_set_2);

                dataGridView_uch.DataSource = data_set_2.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_uch.Columns)
                {
                    c.Width = 75;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_uch.Columns[0].Width = 110;



                SQLiteDataAdapter data_adapter_3 = new SQLiteDataAdapter(
                    @"
                    SELECT
                    CAST(MESTNIE_SOPROTIVLENIA.VS_NAME AS TEXT) AS 'Имя системы',
                    CAST(UCHASTKI.NUMBER AS TEXT) AS '№ уч.',
                    CAST(MESTNIE_SOPROTIVLENIA.NAME AS TEXT) AS 'Наименование местного сопротивления',
                    CAST(MESTNIE_SOPROTIVLENIA.KMS AS TEXT) AS 'ζ',
                    CAST (MESTNIE_SOPROTIVLENIA.POTERI_DAVLENIA AS TEXT) AS 'Pм.c., [Па]'
                    FROM VENTSYSTEMS
                    INNER JOIN UCHASTKI
                    ON UCHASTKI.VENTSYSTEM_ID = VENTSYSTEMS.ID
                    INNER JOIN MESTNIE_SOPROTIVLENIA
                    ON MESTNIE_SOPROTIVLENIA.UCHASTOK_ID = UCHASTKI.ID;
                    ",
                    connection);

                DataSet data_set_3 = new DataSet();

                data_adapter_3.Fill(data_set_3);

                dataGridView_ms.DataSource = data_set_3.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_ms.Columns)
                {
                    c.Width = 100;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_ms.Columns[2].Width = 500;

                button_db_connect.Enabled = false;
                button_db_disconnect.Enabled = true;
                button_show_all_ventsys.Enabled = true;
                button_show_good_napor_ventsys.Enabled = true;
                button_show_bad_napor_ventsys.Enabled = true;
                button_show_perebor_napor_ventsys.Enabled = true;
            }
            catch
            {

            }
        }

        private void dataGridView_table_vs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_db_disconnect_Click(object sender, EventArgs e)
        {
            dataGridView_table_vs.DataSource = null;
            dataGridView_table_vs.Rows.Clear();

            dataGridView_uch.DataSource = null;
            dataGridView_uch.Rows.Clear();

            dataGridView_ms.DataSource = null;
            dataGridView_ms.Rows.Clear();

            connection.Close();

            button_db_connect.Enabled = true;
            button_db_disconnect.Enabled = false;
            button_show_all_ventsys.Enabled = false;
            button_show_good_napor_ventsys.Enabled = false;
            button_show_bad_napor_ventsys.Enabled = false;
            button_show_perebor_napor_ventsys.Enabled = false;
        }

        private void button_show_all_ventsys_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_table_vs.DataSource = null;
                dataGridView_table_vs.Rows.Clear();

                dataGridView_uch.DataSource = null;
                dataGridView_uch.Rows.Clear();

                dataGridView_ms.DataSource = null;
                dataGridView_ms.Rows.Clear();

                SQLiteDataAdapter data_adapter_1 = new SQLiteDataAdapter(
                    @"
                    SELECT CAST(NAME AS TEXT) AS 'Имя системы',
                    CAST(POTERI_DAVLENIA AS TEXT) AS 'Потери давления, [Па]',
                    CAST(NAPOR_TREBUEMIY AS TEXT) AS 'Требуемый напор вентилятора, [Па]',
                    CAST(NAPOR_FACTICHESKIY AS TEXT) AS 'Фактический напор вентилятора, [Па]'
                    FROM VENTSYSTEMS;
                    ",
                    connection);

                DataSet data_set_1 = new DataSet();

                data_adapter_1.Fill(data_set_1);

                dataGridView_table_vs.DataSource = data_set_1.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_table_vs.Columns)
                {
                    c.Width = 220;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_table_vs.Columns[3].Width = 240;



                SQLiteDataAdapter data_adapter_2 = new SQLiteDataAdapter(
                    @"
                    SELECT
                    CAST(VENTSYSTEMS.NAME AS TEXT) AS 'Имя системы',
                    CAST(UCHASTKI.NUMBER AS TEXT) AS '№ уч.',
                    CAST(UCHASTKI.RASHOD AS TEXT) AS 'L, [м³/ч]',
                    CAST(UCHASTKI.LENGTH AS TEXT) AS 'l, [м]',
                    CAST(UCHASTKI.WIDTH AS TEXT) AS 'A, [мм]',
                    CAST(UCHASTKI.HEIGHT AS TEXT) AS 'B, [мм]',
                    CAST(UCHASTKI.DIAMETER_EQL AS TEXT) AS 'd экв, [мм]',
                    CAST(UCHASTKI.TEMPERATURE AS TEXT) AS 't, [°C]',
                    CAST(UCHASTKI.PLOTNOST AS TEXT) AS 'ρ, [кг/м³]',
                    CAST(UCHASTKI.RE AS TEXT) AS 'Re',
                    CAST(UCHASTKI.K_EKV AS TEXT) AS 'Kэ, [мм]',
                    CAST(UCHASTKI.LIAMBDA AS TEXT) AS 'λ',
                    CAST(UCHASTKI.SQUARE AS TEXT) AS 'Fэкв, [м²]',
                    CAST(UCHASTKI.VELOCITY AS TEXT) AS 'v, [м/с]',
                    CAST(UCHASTKI.POTERI_DAVLENIA_PO_DLINE AS TEXT) AS 'ΔPдл., [Па]',
                    CAST(UCHASTKI.KMS_SUMMA AS TEXT) AS '∑ζ',
                    CAST(UCHASTKI.POTERI_DAVLENIA_NA_MESTNIE_SOPROTIVLENIA AS TEXT) AS '∑Pм.c., [Па]',
                    CAST(UCHASTKI.POTERI_DAVLENIA AS TEXT) AS 'ΔP, [Па]'
                    FROM VENTSYSTEMS
                    INNER JOIN UCHASTKI
                    ON UCHASTKI.VENTSYSTEM_ID = VENTSYSTEMS.ID;
                    ",
                    connection);

                DataSet data_set_2 = new DataSet();

                data_adapter_2.Fill(data_set_2);

                dataGridView_uch.DataSource = data_set_2.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_uch.Columns)
                {
                    c.Width = 75;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_uch.Columns[0].Width = 110;



                SQLiteDataAdapter data_adapter_3 = new SQLiteDataAdapter(
                    @"
                    SELECT
                    CAST(MESTNIE_SOPROTIVLENIA.VS_NAME AS TEXT) AS 'Имя системы',
                    CAST(UCHASTKI.NUMBER AS TEXT) AS '№ уч.',
                    CAST(MESTNIE_SOPROTIVLENIA.NAME AS TEXT) AS 'Наименование местного сопротивления',
                    CAST(MESTNIE_SOPROTIVLENIA.KMS AS TEXT) AS 'ζ',
                    CAST (MESTNIE_SOPROTIVLENIA.POTERI_DAVLENIA AS TEXT) AS 'Pм.c., [Па]'
                    FROM VENTSYSTEMS
                    INNER JOIN UCHASTKI
                    ON UCHASTKI.VENTSYSTEM_ID = VENTSYSTEMS.ID
                    INNER JOIN MESTNIE_SOPROTIVLENIA
                    ON MESTNIE_SOPROTIVLENIA.UCHASTOK_ID = UCHASTKI.ID;
                    ",
                    connection);

                DataSet data_set_3 = new DataSet();

                data_adapter_3.Fill(data_set_3);

                dataGridView_ms.DataSource = data_set_3.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_ms.Columns)
                {
                    c.Width = 100;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_ms.Columns[2].Width = 500;
            }
            catch
            {

            }
        }

        private void button_show_good_napor_ventsys_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_table_vs.DataSource = null;
                dataGridView_table_vs.Rows.Clear();

                dataGridView_uch.DataSource = null;
                dataGridView_uch.Rows.Clear();

                dataGridView_ms.DataSource = null;
                dataGridView_ms.Rows.Clear();

                SQLiteDataAdapter data_adapter_1 = new SQLiteDataAdapter(
                    @"
                    SELECT CAST(NAME AS TEXT) AS 'Имя системы',
                    CAST(POTERI_DAVLENIA AS TEXT) AS 'Потери давления, [Па]',
                    CAST(NAPOR_TREBUEMIY AS TEXT) AS 'Требуемый напор вентилятора, [Па]',
                    CAST(NAPOR_FACTICHESKIY AS TEXT) AS 'Фактический напор вентилятора, [Па]'
                    FROM VENTSYSTEMS
                    WHERE ((VENTSYSTEMS.NAPOR_FACTICHESKIY - VENTSYSTEMS.NAPOR_TREBUEMIY) <= 200.0) AND (VENTSYSTEMS.NAPOR_FACTICHESKIY >= VENTSYSTEMS.NAPOR_TREBUEMIY);
                    ",
                    connection);

                DataSet data_set_1 = new DataSet();

                data_adapter_1.Fill(data_set_1);

                dataGridView_table_vs.DataSource = data_set_1.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_table_vs.Columns)
                {
                    c.Width = 220;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_table_vs.Columns[3].Width = 240;



                SQLiteDataAdapter data_adapter_2 = new SQLiteDataAdapter(
                    @"
                    SELECT
                    CAST(VENTSYSTEMS.NAME AS TEXT) AS 'Имя системы',
                    CAST(UCHASTKI.NUMBER AS TEXT) AS '№ уч.',
                    CAST(UCHASTKI.RASHOD AS TEXT) AS 'L, [м³/ч]',
                    CAST(UCHASTKI.LENGTH AS TEXT) AS 'l, [м]',
                    CAST(UCHASTKI.WIDTH AS TEXT) AS 'A, [мм]',
                    CAST(UCHASTKI.HEIGHT AS TEXT) AS 'B, [мм]',
                    CAST(UCHASTKI.DIAMETER_EQL AS TEXT) AS 'd экв, [мм]',
                    CAST(UCHASTKI.TEMPERATURE AS TEXT) AS 't, [°C]',
                    CAST(UCHASTKI.PLOTNOST AS TEXT) AS 'ρ, [кг/м³]',
                    CAST(UCHASTKI.RE AS TEXT) AS 'Re',
                    CAST(UCHASTKI.K_EKV AS TEXT) AS 'Kэ, [мм]',
                    CAST(UCHASTKI.LIAMBDA AS TEXT) AS 'λ',
                    CAST(UCHASTKI.SQUARE AS TEXT) AS 'Fэкв, [м²]',
                    CAST(UCHASTKI.VELOCITY AS TEXT) AS 'v, [м/с]',
                    CAST(UCHASTKI.POTERI_DAVLENIA_PO_DLINE AS TEXT) AS 'ΔPдл., [Па]',
                    CAST(UCHASTKI.KMS_SUMMA AS TEXT) AS '∑ζ',
                    CAST(UCHASTKI.POTERI_DAVLENIA_NA_MESTNIE_SOPROTIVLENIA AS TEXT) AS '∑Pм.c., [Па]',
                    CAST(UCHASTKI.POTERI_DAVLENIA AS TEXT) AS 'ΔP, [Па]'
                    FROM VENTSYSTEMS
                    INNER JOIN UCHASTKI
                    ON UCHASTKI.VENTSYSTEM_ID = VENTSYSTEMS.ID
                    WHERE ((VENTSYSTEMS.NAPOR_FACTICHESKIY - VENTSYSTEMS.NAPOR_TREBUEMIY) <= 200.0) AND (VENTSYSTEMS.NAPOR_FACTICHESKIY >= VENTSYSTEMS.NAPOR_TREBUEMIY);
                    ",
                    connection);

                DataSet data_set_2 = new DataSet();

                data_adapter_2.Fill(data_set_2);

                dataGridView_uch.DataSource = data_set_2.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_uch.Columns)
                {
                    c.Width = 75;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_uch.Columns[0].Width = 110;



                SQLiteDataAdapter data_adapter_3 = new SQLiteDataAdapter(
                    @"
                    SELECT
                    CAST(gr.VS_NAME AS TEXT) AS 'Имя системы',
                    CAST(uch.NUMBER AS TEXT) AS '№ уч.',
                    CAST(gr.NAME AS TEXT) AS 'Наименование местного сопротивления',
                    CAST(gr.KMS AS TEXT) AS 'ζ',
                    CAST(gr.POTERI_DAVLENIA AS TEXT) AS 'Pм.c., [Па]'
                    FROM
                    (
                    SELECT
                    VS_NAME,
                    UCHASTOK_ID,
                    ID,
                    ms.NAME,
                    KMS,
                    POTERI_DAVLENIA
                    FROM
                    (
                    SELECT NAME
                    FROM VENTSYSTEMS
                    WHERE ((VENTSYSTEMS.NAPOR_FACTICHESKIY - VENTSYSTEMS.NAPOR_TREBUEMIY) <= 200.0) AND (VENTSYSTEMS.NAPOR_FACTICHESKIY >= VENTSYSTEMS.NAPOR_TREBUEMIY)
                    ) vs
                    INNER JOIN 
                    (
                    SELECT
                    *
                    FROM
                    MESTNIE_SOPROTIVLENIA
                    ) ms
                    ON (vs.NAME = ms.VS_NAME)
                    ) gr
                    INNER JOIN
                    (
                    SELECT
                    ID,
                    NUMBER
                    FROM
                    UCHASTKI
                    ) uch
                    ON (gr.UCHASTOK_ID = uch.ID);
                    ",
                    connection);

                DataSet data_set_3 = new DataSet();

                data_adapter_3.Fill(data_set_3);

                dataGridView_ms.DataSource = data_set_3.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_ms.Columns)
                {
                    c.Width = 100;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_ms.Columns[2].Width = 500;
            }
            catch
            {

            }
        }

        private void button_show_perebor_napor_ventsys_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_table_vs.DataSource = null;
                dataGridView_table_vs.Rows.Clear();

                dataGridView_uch.DataSource = null;
                dataGridView_uch.Rows.Clear();

                dataGridView_ms.DataSource = null;
                dataGridView_ms.Rows.Clear();

                SQLiteDataAdapter data_adapter_1 = new SQLiteDataAdapter(
                    @"
                    SELECT CAST(NAME AS TEXT) AS 'Имя системы',
                    CAST(POTERI_DAVLENIA AS TEXT) AS 'Потери давления, [Па]',
                    CAST(NAPOR_TREBUEMIY AS TEXT) AS 'Требуемый напор вентилятора, [Па]',
                    CAST(NAPOR_FACTICHESKIY AS TEXT) AS 'Фактический напор вентилятора, [Па]'
                    FROM VENTSYSTEMS
                    WHERE (VENTSYSTEMS.NAPOR_FACTICHESKIY - VENTSYSTEMS.NAPOR_TREBUEMIY) > 200.0;
                    ",
                    connection);

                DataSet data_set_1 = new DataSet();

                data_adapter_1.Fill(data_set_1);

                dataGridView_table_vs.DataSource = data_set_1.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_table_vs.Columns)
                {
                    c.Width = 220;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_table_vs.Columns[3].Width = 240;



                SQLiteDataAdapter data_adapter_2 = new SQLiteDataAdapter(
                    @"
                    SELECT
                    CAST(VENTSYSTEMS.NAME AS TEXT) AS 'Имя системы',
                    CAST(UCHASTKI.NUMBER AS TEXT) AS '№ уч.',
                    CAST(UCHASTKI.RASHOD AS TEXT) AS 'L, [м³/ч]',
                    CAST(UCHASTKI.LENGTH AS TEXT) AS 'l, [м]',
                    CAST(UCHASTKI.WIDTH AS TEXT) AS 'A, [мм]',
                    CAST(UCHASTKI.HEIGHT AS TEXT) AS 'B, [мм]',
                    CAST(UCHASTKI.DIAMETER_EQL AS TEXT) AS 'd экв, [мм]',
                    CAST(UCHASTKI.TEMPERATURE AS TEXT) AS 't, [°C]',
                    CAST(UCHASTKI.PLOTNOST AS TEXT) AS 'ρ, [кг/м³]',
                    CAST(UCHASTKI.RE AS TEXT) AS 'Re',
                    CAST(UCHASTKI.K_EKV AS TEXT) AS 'Kэ, [мм]',
                    CAST(UCHASTKI.LIAMBDA AS TEXT) AS 'λ',
                    CAST(UCHASTKI.SQUARE AS TEXT) AS 'Fэкв, [м²]',
                    CAST(UCHASTKI.VELOCITY AS TEXT) AS 'v, [м/с]',
                    CAST(UCHASTKI.POTERI_DAVLENIA_PO_DLINE AS TEXT) AS 'ΔPдл., [Па]',
                    CAST(UCHASTKI.KMS_SUMMA AS TEXT) AS '∑ζ',
                    CAST(UCHASTKI.POTERI_DAVLENIA_NA_MESTNIE_SOPROTIVLENIA AS TEXT) AS '∑Pм.c., [Па]',
                    CAST(UCHASTKI.POTERI_DAVLENIA AS TEXT) AS 'ΔP, [Па]'
                    FROM VENTSYSTEMS
                    INNER JOIN UCHASTKI
                    ON UCHASTKI.VENTSYSTEM_ID = VENTSYSTEMS.ID
                    WHERE (VENTSYSTEMS.NAPOR_FACTICHESKIY - VENTSYSTEMS.NAPOR_TREBUEMIY) > 200.0;
                    ",
                    connection);

                DataSet data_set_2 = new DataSet();

                data_adapter_2.Fill(data_set_2);

                dataGridView_uch.DataSource = data_set_2.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_uch.Columns)
                {
                    c.Width = 75;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_uch.Columns[0].Width = 110;



                SQLiteDataAdapter data_adapter_3 = new SQLiteDataAdapter(
                    @"
                    SELECT
                    CAST(gr.VS_NAME AS TEXT) AS 'Имя системы',
                    CAST(uch.NUMBER AS TEXT) AS '№ уч.',
                    CAST(gr.NAME AS TEXT) AS 'Наименование местного сопротивления',
                    CAST(gr.KMS AS TEXT) AS 'ζ',
                    CAST(gr.POTERI_DAVLENIA AS TEXT) AS 'Pм.c., [Па]'
                    FROM
                    (
                    SELECT
                    VS_NAME,
                    UCHASTOK_ID,
                    ID,
                    ms.NAME,
                    KMS,
                    POTERI_DAVLENIA
                    FROM
                    (
                    SELECT NAME
                    FROM VENTSYSTEMS
                    WHERE (VENTSYSTEMS.NAPOR_FACTICHESKIY - VENTSYSTEMS.NAPOR_TREBUEMIY) > 200.0
                    ) vs
                    INNER JOIN 
                    (
                    SELECT
                    *
                    FROM
                    MESTNIE_SOPROTIVLENIA
                    ) ms
                    ON (vs.NAME = ms.VS_NAME)
                    ) gr
                    INNER JOIN
                    (
                    SELECT
                    ID,
                    NUMBER
                    FROM
                    UCHASTKI
                    ) uch
                    ON (gr.UCHASTOK_ID = uch.ID);
                    ",
                    connection);

                DataSet data_set_3 = new DataSet();

                data_adapter_3.Fill(data_set_3);

                dataGridView_ms.DataSource = data_set_3.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_ms.Columns)
                {
                    c.Width = 100;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_ms.Columns[2].Width = 500;
            }
            catch
            {

            }
        }

        private void button_show_bad_napor_ventsys_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_table_vs.DataSource = null;
                dataGridView_table_vs.Rows.Clear();

                dataGridView_uch.DataSource = null;
                dataGridView_uch.Rows.Clear();

                dataGridView_ms.DataSource = null;
                dataGridView_ms.Rows.Clear();

                SQLiteDataAdapter data_adapter_1 = new SQLiteDataAdapter(
                    @"
                    SELECT CAST(NAME AS TEXT) AS 'Имя системы',
                    CAST(POTERI_DAVLENIA AS TEXT) AS 'Потери давления, [Па]',
                    CAST(NAPOR_TREBUEMIY AS TEXT) AS 'Требуемый напор вентилятора, [Па]',
                    CAST(NAPOR_FACTICHESKIY AS TEXT) AS 'Фактический напор вентилятора, [Па]'
                    FROM VENTSYSTEMS
                    WHERE VENTSYSTEMS.NAPOR_FACTICHESKIY < VENTSYSTEMS.NAPOR_TREBUEMIY;
                    ",
                    connection);

                DataSet data_set_1 = new DataSet();

                data_adapter_1.Fill(data_set_1);

                dataGridView_table_vs.DataSource = data_set_1.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_table_vs.Columns)
                {
                    c.Width = 220;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_table_vs.Columns[3].Width = 240;



                SQLiteDataAdapter data_adapter_2 = new SQLiteDataAdapter(
                    @"
                    SELECT
                    CAST(VENTSYSTEMS.NAME AS TEXT) AS 'Имя системы',
                    CAST(UCHASTKI.NUMBER AS TEXT) AS '№ уч.',
                    CAST(UCHASTKI.RASHOD AS TEXT) AS 'L, [м³/ч]',
                    CAST(UCHASTKI.LENGTH AS TEXT) AS 'l, [м]',
                    CAST(UCHASTKI.WIDTH AS TEXT) AS 'A, [мм]',
                    CAST(UCHASTKI.HEIGHT AS TEXT) AS 'B, [мм]',
                    CAST(UCHASTKI.DIAMETER_EQL AS TEXT) AS 'd экв, [мм]',
                    CAST(UCHASTKI.TEMPERATURE AS TEXT) AS 't, [°C]',
                    CAST(UCHASTKI.PLOTNOST AS TEXT) AS 'ρ, [кг/м³]',
                    CAST(UCHASTKI.RE AS TEXT) AS 'Re',
                    CAST(UCHASTKI.K_EKV AS TEXT) AS 'Kэ, [мм]',
                    CAST(UCHASTKI.LIAMBDA AS TEXT) AS 'λ',
                    CAST(UCHASTKI.SQUARE AS TEXT) AS 'Fэкв, [м²]',
                    CAST(UCHASTKI.VELOCITY AS TEXT) AS 'v, [м/с]',
                    CAST(UCHASTKI.POTERI_DAVLENIA_PO_DLINE AS TEXT) AS 'ΔPдл., [Па]',
                    CAST(UCHASTKI.KMS_SUMMA AS TEXT) AS '∑ζ',
                    CAST(UCHASTKI.POTERI_DAVLENIA_NA_MESTNIE_SOPROTIVLENIA AS TEXT) AS '∑Pм.c., [Па]',
                    CAST(UCHASTKI.POTERI_DAVLENIA AS TEXT) AS 'ΔP, [Па]'
                    FROM VENTSYSTEMS
                    INNER JOIN UCHASTKI
                    ON UCHASTKI.VENTSYSTEM_ID = VENTSYSTEMS.ID
                    WHERE VENTSYSTEMS.NAPOR_FACTICHESKIY < VENTSYSTEMS.NAPOR_TREBUEMIY;
                    ",
                    connection);

                DataSet data_set_2 = new DataSet();

                data_adapter_2.Fill(data_set_2);

                dataGridView_uch.DataSource = data_set_2.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_uch.Columns)
                {
                    c.Width = 75;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_uch.Columns[0].Width = 110;



                SQLiteDataAdapter data_adapter_3 = new SQLiteDataAdapter(
                    @"
                    SELECT
                    CAST(gr.VS_NAME AS TEXT) AS 'Имя системы',
                    CAST(uch.NUMBER AS TEXT) AS '№ уч.',
                    CAST(gr.NAME AS TEXT) AS 'Наименование местного сопротивления',
                    CAST(gr.KMS AS TEXT) AS 'ζ',
                    CAST(gr.POTERI_DAVLENIA AS TEXT) AS 'Pм.c., [Па]'
                    FROM
                    (
                    SELECT
                    VS_NAME,
                    UCHASTOK_ID,
                    ID,
                    ms.NAME,
                    KMS,
                    POTERI_DAVLENIA
                    FROM
                    (
                    SELECT NAME
                    FROM VENTSYSTEMS
                    WHERE VENTSYSTEMS.NAPOR_FACTICHESKIY < VENTSYSTEMS.NAPOR_TREBUEMIY
                    ) vs
                    INNER JOIN 
                    (
                    SELECT
                    *
                    FROM
                    MESTNIE_SOPROTIVLENIA
                    ) ms
                    ON (vs.NAME = ms.VS_NAME)
                    ) gr
                    INNER JOIN
                    (
                    SELECT
                    ID,
                    NUMBER
                    FROM
                    UCHASTKI
                    ) uch
                    ON (gr.UCHASTOK_ID = uch.ID);
                    ",
                    connection);

                DataSet data_set_3 = new DataSet();

                data_adapter_3.Fill(data_set_3);

                dataGridView_ms.DataSource = data_set_3.Tables[0];

                foreach (DataGridViewColumn c in dataGridView_ms.Columns)
                {
                    c.Width = 100;
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    c.Frozen = true;
                }

                dataGridView_ms.Columns[2].Width = 500;
            }
            catch
            {

            }
        }
    }
}
