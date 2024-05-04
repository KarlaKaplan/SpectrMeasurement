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
using System.Windows.Forms.DataVisualization.Charting;

namespace SpectMeasure
{
    public partial class MainForm : Form
    {
        DataBase dataBase = new DataBase();
        private Series profileSeries;
        public MainForm()
        {
            dataBase.GetConnection();
            InitializeComponent();

            profileSeries = new Series();
            profileSeries.ChartType = SeriesChartType.Line;
            profileSeries.Name = "Profile";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataBase.OpenConnection();

            DataTable dt = dataBase.SqlSelect("select P.IdProfile, PD.IdData, M.DateMeas, S.NameSector, PD.Depth, PD.SoilType, E.SerialNumber FROM Profiles P JOIN Sectors S ON P.IdSector = S.IdSector JOIN Measurements M ON P.IdProfile = M.IdProfile JOIN ProfileData PD ON P.IdProfile = PD.IdProfile JOIN Equipment E ON P.IdEquipment = E.IdEquipment;");
            dataGridView1.DataSource = dt;
            dataBase.CloseConnection();

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                MessageBox.Show("Введите параметр для поиска");
                return;
            }
            dataBase.OpenConnection();
            DataTable dt = new DataTable();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        dt = dataBase.SqlSelect("select  P.IdProfile, PD.IdData, M.DateMeas, S.NameSector, PD.Depth, PD.SoilType, E.SerialNumber FROM Profiles P JOIN Sectors S ON P.IdSector = S.IdSector JOIN Measurements M ON P.IdProfile = M.IdProfile JOIN ProfileData PD ON P.IdProfile = PD.IdProfile JOIN Equipment E ON P.IdEquipment = E.IdEquipment where P.IdProfile = '" + textBoxSearch.Text + "'");
                    }
                    break;
                case 1:
                    {
                        dt = dataBase.SqlSelect("select  P.IdProfile, PD.IdData, M.DateMeas, S.NameSector, PD.Depth, PD.SoilType, E.SerialNumber FROM Profiles P JOIN Sectors S ON P.IdSector = S.IdSector JOIN Measurements M ON P.IdProfile = M.IdProfile JOIN ProfileData PD ON P.IdProfile = PD.IdProfile JOIN Equipment E ON P.IdEquipment = E.IdEquipment where PD.IdData = '" + textBoxSearch.Text + "'");
                    }
                    break;
                case 2:
                    {
                        dt = dataBase.SqlSelect("select P.IdProfile, PD.IdData, M.DateMeas, S.NameSector, PD.Depth, PD.SoilType, E.SerialNumber FROM Profiles P JOIN Sectors S ON P.IdSector = S.IdSector JOIN Measurements M ON P.IdProfile = M.IdProfile JOIN ProfileData PD ON P.IdProfile = PD.IdProfile JOIN Equipment E ON P.IdEquipment = E.IdEquipment where S.NameSector = '" + textBoxSearch.Text + "'");
                    }
                    break;
         
                case 3:
                    {
                        dt = dataBase.SqlSelect("select P.IdProfile, PD.IdData, M.DateMeas, S.NameSector, PD.Depth, PD.SoilType, E.SerialNumber FROM Profiles P JOIN Sectors S ON P.IdSector = S.IdSector JOIN Measurements M ON P.IdProfile = M.IdProfile JOIN ProfileData PD ON P.IdProfile = PD.IdProfile JOIN Equipment E ON P.IdEquipment = E.IdEquipment where PD.SoilType = '" + textBoxSearch.Text + "'");
                    }
                    break;
                case 4:
                    {
                        dt = dataBase.SqlSelect("select P.IdProfile, PD.IdData, M.DateMeas, S.NameSector, PD.Depth, PD.SoilType, E.SerialNumber FROM Profiles P JOIN Sectors S ON P.IdSector = S.IdSector JOIN Measurements M ON P.IdProfile = M.IdProfile JOIN ProfileData PD ON P.IdProfile = PD.IdProfile JOIN Equipment E ON P.IdEquipment = E.IdEquipment where E.SerialNumber = '" + textBoxSearch.Text + "'");
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Выберете параметр для поиска");
                        dataBase.CloseConnection();
                        return;
                    }
            }
            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
            }

            dataBase.CloseConnection();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Убедитесь, что была выбрана хотя бы одна строка
            {
                int profileId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column1"].Value);
                FormGraph formGraph = new FormGraph(profileId);
                formGraph.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Выберите профиль для построения графика.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddSector formAddSector = new FormAddSector();
            formAddSector.Show();
            this.Hide();

        }
    }
}
