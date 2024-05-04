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
    public partial class FormAddProfile : Form
    {
        DataBase dataBase = new DataBase();
        public FormAddProfile()
        {
            dataBase.GetConnection();
            InitializeComponent();
        }

        private void FormAddProfile_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DoRefresh();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAddEquip formAddEquip = new FormAddEquip();
            formAddEquip.Show();
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tbIdSector.Text == "" || tbIdEquip.Text == "")
            {
                MessageBox.Show("Данные введены некорректно");
                DoClean();
                return;
            }
            SqlCommand cmd = dataBase.SqlInsert("insert into Profiles values ('" + tbIdSector.Text + "', '" + tbIdEquip.Text + "')");
            MessageBox.Show("Добавлен профиль");
            DoRefresh();
            DoClean();
        }
        private void DoClean()
        {
            tbIdSector.Text = "";
            tbIdEquip.Text = "";
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
           FormAddData formAddData = new FormAddData();
            formAddData.Show();
            this.Close();
        }
        private void DoRefresh()
        {
            dataBase.OpenConnection();
            DataTable dt = dataBase.SqlSelect("select * from Profiles");
            dataGridView1.DataSource = dt;
            dataBase.CloseConnection();
        }
    }
}
