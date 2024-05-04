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
    public partial class FormAddData : Form
    {
        DataBase dataBase = new DataBase();
        public FormAddData()
        {
            dataBase.GetConnection();
            InitializeComponent();
        }

        private void FormAddData_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DoRefresh();
        }
        private void DoRefresh()
        {
            dataBase.OpenConnection();
            DataTable dt = dataBase.SqlSelect("select * from ProfileData");
            dataGridView1.DataSource = dt;
            dataBase.CloseConnection();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tbIdProfile.Text == "" || tbDepth.Text == "" || tbSoil.Text == "")
            {
                MessageBox.Show("Данные введены некорректно");
                DoClean();
                return;
            }
            SqlCommand cmd = dataBase.SqlInsert("insert into ProfileData values ('" + tbIdProfile.Text + "', '" + tbDepth.Text + "', '"+ tbSoil.Text+"')");
            MessageBox.Show("Добавлены данные профиля");
            DoRefresh();
            DoClean();
        }
        private void DoClean()
        {
            tbIdProfile.Text = "";
            tbDepth.Text = "";
            tbSoil.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAddProfile frm = new FormAddProfile();
            frm.Show();
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            FormAddMeas formAddMeas = new FormAddMeas();
            formAddMeas.Show();
            this.Close();
        }
    }
}
