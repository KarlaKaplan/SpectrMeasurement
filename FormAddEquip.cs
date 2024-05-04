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
using System.Xml.Linq;

namespace SpectMeasure
{
    public partial class FormAddEquip : Form
    {
        DataBase dataBase = new DataBase();
        public FormAddEquip()
        {
            dataBase.GetConnection();
            InitializeComponent();
        }

        private void labelModel_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAddSector formAddSector = new FormAddSector();
            formAddSector.Show();
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            FormAddProfile formAddProfile = new FormAddProfile();
            formAddProfile.Show();
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tbModel.Text == "" || tbSerNum.Text == "")
            {
                MessageBox.Show("Данные введены некорректно");
                DoClean();
                return;
            }
            SqlCommand cmd = dataBase.SqlInsert("insert into Equipment values ('" + tbModel.Text + "', '" + tbSerNum.Text + "')");
            MessageBox.Show("Добавлено оборудование");
            DoRefresh();
            DoClean();
        }
        private void DoClean()
        {
            tbModel.Text = "";
            tbSerNum.Text = "";
        }
        private void FormAddEquip_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DoRefresh();
        }
        private void DoRefresh()
        {
            dataBase.OpenConnection();
            DataTable dt = dataBase.SqlSelect("select * from Equipment");
            dataGridView1.DataSource = dt;
            dataBase.CloseConnection();
        }
    }
}
