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
    public partial class FormAddSector : Form
    {
        DataBase dataBase = new DataBase();
        public FormAddSector()
        {
            dataBase.GetConnection();
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void FormAddSector_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DoRefresh();
        }
        private void DoRefresh()
        {
            dataBase.OpenConnection();
            DataTable dt = dataBase.SqlSelect("select * from Sectors");
            dataGridView1.DataSource = dt;
            dataBase.CloseConnection();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbCoordX.Text == "" || tbCoordY.Text == "")
            {
                MessageBox.Show("Данные введены некорректно");
                DoClean();
                return;
            }
            SqlCommand cmd = dataBase.SqlInsert("insert into Sectors values ('" + tbName.Text + "', '" + tbCoordX.Text + "', '" + tbCoordY.Text + "')");
            MessageBox.Show("Добавлен участок");
            DoRefresh();
            DoClean();
        }
        private void DoClean()
        {
            tbName.Text = "";
            tbCoordX.Text = "";
            tbCoordY.Text = "";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            FormAddEquip formAddEquip = new FormAddEquip();
            formAddEquip.Show();
            this.Close();
        }
    }
}
