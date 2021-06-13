﻿using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Filmoteka
{
    public partial class Form_DirectorsDlg : Form
    {
        public int user_id { get; set; }
        public int user_rights { get; set; }

        public int record_id { get; set; }

        public string connectionString { get; set; }

        public SQLiteConnection con;


        public Form_DirectorsDlg()
        {
            InitializeComponent();
        }

        public int ConnectToSQLiteDB()
        {
            con = new SQLiteConnection(connectionString);

            try
            {
                //MessageBox.Show("TRY TO CONNECT : " + connectionString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    ///MessageBox.Show("SQLITE CONNECTED SUCCESSFULLY!");
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
                        fmd.CommandText = @"SELECT name FROM filmDirector WHERE id=@l";
                        fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@l"].Value = rec_id;


                        SQLiteDataReader r = fmd.ExecuteReader();
                        while (r.Read())
                        {
                            //MessageBox.Show("->"+ (int)r["id"]);
                            textBox_id.Text = rec_id.ToString();
                            textBox_name.Text = (r["name"]).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }
                con.Close();
            }
            //sql load records
            // and put it into textboxs
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            bool need_to_close_this_window = false;
            if (ConnectToSQLiteDB() == 1)
            {
                string name = "";

                name = textBox_name.Text.Trim();

                if (record_id == -1)
                {// новий запис

                    // перевіряємо поля, що б не були пусті і через трай кет парсимо інтові значення і зап в змінні

                    using (SQLiteCommand fmd = con.CreateCommand())
                    {
                        try
                        {
                            // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                            fmd.CommandText = @"INSERT INTO filmDirector (name) VALUES (@n)";
                            fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                            fmd.Parameters["@n"].Value = name;

                            DialogResult r8 = MessageBox.Show("Додати новий запис?",
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
                else
                {// редактування
                    using (SQLiteCommand fmd = con.CreateCommand())
                    {
                        try
                        {
                            fmd.CommandText = @"UPDATE filmDirector SET name=@n WHERE id=@a";
                            fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                            fmd.Parameters["@n"].Value = name;

                            fmd.Parameters.Add("@a", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@a"].Value = record_id;

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
