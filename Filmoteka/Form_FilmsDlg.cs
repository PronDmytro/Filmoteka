using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;


namespace Filmoteka
{
    public partial class Form_FilmsDlg : Form
    {

        public int user_id { get; set; }
        public int user_rights { get; set; }
        public string connectionString { get; set; }

        public int record_id { get; set; }

        public SQLiteConnection con;

        public int ConnectToSQLiteDB()
        {
            con = new SQLiteConnection(connectionString);

            try
            {
                //Console.WriteLine("TRY TO CONNECT : " + connectionString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    ///Console.WriteLine("SQLITE CONNECTED SUCCESSFULLY!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "SQLITE CONNECT ERROR : " + ex.Message,
                                   "SQLite connection error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error,
                                   MessageBoxDefaultButton.Button1, 0);
                return 0;
            }
            return 1;
        }



        public void LoadDataInFiledsByRecordId(int rec_id)
        {
            if (ConnectToSQLiteDB() == 1)
            {

                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT name,genre,directorId,companyId,release_dt FROM films WHERE id=@l";
                        fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@l"].Value = rec_id;

                        SQLiteDataReader r = fmd.ExecuteReader();
                        while (r.Read())
                        {
                            LoadDataInComboboxByTblAndFieldName(ref comboBox_director, "filmDirector", "name", true, Convert.ToInt32((r["companyId"]).ToString()));
                            LoadDataInComboboxByTblAndFieldName(ref comboBox_company, "company", "name", true, Convert.ToInt32((r["directorId"]).ToString()));

                            textBox_genre.Text = (r["genre"]).ToString();
                            dateTimePicker_dtrel.Text = (r["release_dt"]).ToString();
                            textBox_filmName.Text = (r["name"]).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }
                con.Close();
            }
            //sql load records
            // and put it into textboxs
        }

        public void LoadDataInComboboxByTblAndFieldName(ref  ComboBox comboboxtarger, string tblname, string fieldname, bool needID = false, int setid = -1)
        {
            if (ConnectToSQLiteDB() == 1)
            {

                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT id," + fieldname + " FROM " + tblname;
                        //fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        //fmd.Parameters["@l"].Value = rec_id;
                        comboboxtarger.Items.Clear();
                        int curIndex = 0;
                        SQLiteDataReader r = fmd.ExecuteReader();
                        int rememberId = 0;
                        while (r.Read())
                        {
                            comboboxtarger.Items.Add((needID ? r["id"] + " : " : "") + r[fieldname]);
                            string tmpxx = r["id"].ToString();
                            if (r["id"].ToString() == setid.ToString())
                            {
                                rememberId = curIndex;
                            }

                            //Console.WriteLine("->"+ (int)r["id"]);
                            /*
                            textBox_productName.Text = (r["name"]).ToString();
                            textBox_comment.Text = (r["comment"]).ToString();

                            textBox_itemsCount.Text = (r["itemscount"]).ToString();
                            textBox_cost.Text = (r["cost"]).ToString();
                             */
                            curIndex++;

                        }
                        if (setid != -1)
                        {
                            comboboxtarger.SelectedIndex = rememberId;
                        }
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message);
                        //Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }
                con.Close();
            }
            //sql load records
            // and put it into textboxs
        }

        public Form_FilmsDlg()
        {
            InitializeComponent();
        }

        private void Form_SupplylogDlg_Load(object sender, EventArgs e)
        {
            LoadDataInComboboxByTblAndFieldName(ref comboBox_director, "filmDirector", "name", true);
            LoadDataInComboboxByTblAndFieldName(ref comboBox_company, "company", "name", true);

            if (record_id == -1)
            {
                textBox_id.Text = "Новий запис";
                Text = "Додання нового запису";

                string tmp = DateTime.Now.ToString("dd.MM.yyyy");
                tmp = (DateTime.Now.AddMinutes(15)).ToString("dd.MM.yyyy");
                dateTimePicker_dtrel.Text = tmp;
            }
            else
            {
                textBox_id.Text = record_id.ToString();
                Text = "Редагування запису #" + record_id.ToString();
            }
           
        }


        private int GetIdInTextStringBySeparator(string inStr)
        {
            string[] array = inStr.Split(new char[] { ':' });

            if (array.Length > 0)
            {
                try
                {
                    return Convert.ToInt32(array[0].Trim());
                }
                catch
                {
                    return -1;
                }
            }

            return -1;

        }


        private void button_action_Click(object sender, EventArgs e)
        {
                    
            textBox_genre.Text = textBox_genre.Text.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            textBox_genre.Text = textBox_genre.Text.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);



            bool need_to_close_this_window = false;
            if (ConnectToSQLiteDB() == 1)
            {
                int directorId = 0;
                int companyId = 0;
                string genre = "";
                string release_dt = "";
                string name = "";

                genre = textBox_genre.Text.Trim();
                name = textBox_filmName.Text.Trim();
                release_dt = dateTimePicker_dtrel.Text.Trim();
                //-------------------------------------------------------------------------
                directorId = GetIdInTextStringBySeparator(comboBox_director.Text.Trim());
                if (directorId == -1)
                {
                    MessageBox.Show(this, "Режисер",
                                  "id не знайдено (Режисер): ", MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button1, 0);
                    return;
                }
                //-------------------------------------------------------------------------
                companyId = GetIdInTextStringBySeparator(comboBox_company.Text.Trim());
                if (companyId == -1)
                {
                    MessageBox.Show(this, "Компанія",
                                  "id не знайдено (Компанія): ", MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button1, 0);
                    con.Close();
                    return;
                }

                if (record_id == -1)
                {// новий запис

                    // перевіряємо поля, що б не були пусті і через трай кет парсимо інтові значення і зап в змінні

                    using (SQLiteCommand fmd = con.CreateCommand())
                    {
                        
                        //==============================================================================================
                        // [1] Виконуємо вставку в таблицю жуналів
                        //==============================================================================================
                        try
                        {
                            // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                            fmd.CommandText = @"INSERT INTO films (name,genre,release_dt,directorId,companyId) VALUES (@name,@genre,@release_dt,@directorId,@companyId)";
                            
                            
                            fmd.Parameters.Add("@directorId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@directorId"].Value = directorId;

                            fmd.Parameters.Add("@companyId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@companyId"].Value = companyId;


                            fmd.Parameters.Add("@genre", System.Data.DbType.String, -1);
                            fmd.Parameters["@genre"].Value = genre;
                            MessageBox.Show(fmd.Parameters["@genre"].Value.ToString());
                            fmd.Parameters.Add("@release_dt", System.Data.DbType.String, -1);
                            fmd.Parameters["@release_dt"].Value = release_dt;

                            fmd.Parameters.Add("@name", System.Data.DbType.String, -1);
                            fmd.Parameters["@name"].Value = name;
                            MessageBox.Show(fmd.Parameters["@name"].Value.ToString());
                            DialogResult r8 = MessageBox.Show("Додати новий запис?",
                                       "Підтвердження виконання операції", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                            if (r8 == DialogResult.Yes)
                            {
                                fmd.ExecuteNonQuery();
                                need_to_close_this_window = true;
                            }
                            else
                            {
                                need_to_close_this_window = false;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                        }
                        
                    }
                    con.Close();

                    //=============================================================================================
                }
                else
                {// редактування
                    using (SQLiteCommand fmd = con.CreateCommand())
                    {
                        try
                        {
                            // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                            fmd.CommandText = @"UPDATE films SET name=@name,genre=@genre,release_dt=@release_dt,directorId=@directorId,companyId=@companyId WHERE id=@a";

                            fmd.Parameters.Add("@directorId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@directorId"].Value = directorId;

                            fmd.Parameters.Add("@companyId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@companyId"].Value = companyId;

                            fmd.Parameters.Add("@name", System.Data.DbType.String, -1);
                            fmd.Parameters["@name"].Value = name;

                            fmd.Parameters.Add("@genre", System.Data.DbType.String, -1);
                            fmd.Parameters["@genre"].Value = genre;

                            fmd.Parameters.Add("@release_dt", System.Data.DbType.String, -1);
                            fmd.Parameters["@release_dt"].Value = release_dt;

                            fmd.Parameters.Add("@a", System.Data.DbType.String, -1);
                            fmd.Parameters["@a"].Value = record_id.ToString();
                           
                            DialogResult r8 = MessageBox.Show("Редагувати запис?",
                                       "Підтвердження виконання операції", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (r8 == DialogResult.Yes)
                            {
                                fmd.ExecuteNonQuery();
                                need_to_close_this_window = true;
                            }
                            else
                            {
                                need_to_close_this_window = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                        }

                    }
                    con.Close();
                }
            }
            else
            {
                // не можу зєднатися з БД
            }

            if (need_to_close_this_window)
            {
                Close();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
