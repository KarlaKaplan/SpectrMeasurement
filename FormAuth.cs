using SpectrMeasure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SpectMeasure
{

    public partial class FormAuth : Form
    {
        DataBase dataBase = new DataBase();
        public FormAuth()
        {
            dataBase.GetConnection();
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPass.Text))
            {
                MessageBox.Show("Некорректные данные");
                CleanForm();
                return;
            }

            try
            {
                dataBase.OpenConnection();

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Login", textBoxLogin.Text)
                };

                DataTable dt = dataBase.SqlSelect("SELECT Pass FROM Users WHERE Login = @Login", parameters);


                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Неверный логин или пароль");
                    CleanForm();
                    return;
                }

                string storedPassword = dt.Rows[0][0].ToString();
                string enteredPassword = textBoxPass.Text;

                if (storedPassword != enteredPassword)
                {
                    MessageBox.Show("Неверный логин или пароль");
                    CleanForm();
                    return;
                }

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                CleanForm();
            }
            finally
            {
                dataBase.CloseConnection();
            }
        }
        private void CleanForm()
        {
            textBoxLogin.Text = "";
            textBoxPass.Text = "";
            dataBase.CloseConnection();
        }

        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
