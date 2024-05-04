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
using SpectrMeasure;

namespace SpectMeasure
{
    public partial class FormAddMeas : Form
    {
        DataBase dataBase = new DataBase();
        public FormAddMeas()
        {
            dataBase.GetConnection();
            InitializeComponent();
        }

        private void FormAddMeas_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DoRefresh();
        }
        private void DoRefresh()
        {
            dataBase.OpenConnection();
            DataTable dt = dataBase.SqlSelect("select * from Measurements");
            dataGridView1.DataSource = dt;
            dataBase.CloseConnection();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tbDate.Text == "" || tbIdProfile.Text == "" || tbCom.Text == "" )
            {
                MessageBox.Show("Данные введены некорректно");
                DoClean();
                return;
            }
            SqlCommand cmd = dataBase.SqlInsert("insert into Measurements values ('" + tbDate.Text + "', '" + tbIdProfile.Text + "', '" + tbCom.Text + "')");
            MessageBox.Show("Добавлено измерение");
            DoRefresh();
            DoClean();
        }
        private void DoClean()
        {
            tbDate.Text = "";
            tbIdProfile.Text = "";
            tbCom.Text = "";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAddData formAddData = new FormAddData();
            formAddData.Show();
            this.Close();
        }
    }
}
