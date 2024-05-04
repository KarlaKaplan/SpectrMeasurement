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
using Microsoft.Data.SqlClient;

namespace SpectMeasure
{
    public partial class FormGraph : Form
    {
        private DataBase dataBase = new DataBase();
        private int selectedProfileId;
        public FormGraph(int profileId)
        {
            //dataBase.GetConnection();
            InitializeComponent();
            selectedProfileId = profileId;
        }

        private void FormGraph_Load(object sender, EventArgs e)
        {
            DataTable profileData = dataBase.SqlSelect("SELECT Depth, SoilType FROM ProfileData WHERE IdProfile = @IdProfile ORDER BY Depth", new SqlParameter[] { new SqlParameter("@IdProfile", selectedProfileId) });

            if (profileData.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для отображения");
                return;
            }
            /////Точечный
            //Chart chart = new Chart();
            //chart.Dock = DockStyle.Fill;

            //// Добавляем область для построения графика
            //ChartArea chartArea = new ChartArea();
            //chartArea.AxisY.Title = "Depth";
            //chartArea.AxisX.IsReversed = true; // чтобы ось X была вверху
            //chart.ChartAreas.Add(chartArea);

            //// Устанавливаем тип графика на точечный (scatter plot)
            //Series series = new Series();
            //series.ChartType = SeriesChartType.Point;

            //// Добавляем точки на график для каждой глубины и типа почвы
            //foreach (DataRow row in profileData.Rows)
            //{
            //    double depth = Convert.ToDouble(row["Depth"]);
            //    string soilType = row["SoilType"].ToString();

            //    // Добавляем точку на график
            //    series.Points.AddXY(soilType, depth);
            //}

            //// Добавляем серию на график
            //chart.Series.Add(series);

            //// Добавляем график на форму
            //Controls.Add(chart);


            ////Линейный
            //Chart chart = new Chart();
            //chart.Dock = DockStyle.Fill;

            //// Добавляем область для построения графика
            //ChartArea chartArea = new ChartArea();
            //chartArea.AxisY.Title = "Depth";
            //chartArea.AxisX.Interval = 1;
            //chartArea.AxisX.IsReversed = true; // чтобы ось X была вверху
            //chart.ChartAreas.Add(chartArea);

            //// Устанавливаем тип графика на линейный
            //Series series = new Series();
            //series.ChartType = SeriesChartType.Line;

            //// Добавляем линии на график для каждой глубины и типа почвы
            //foreach (DataRow row in profileData.Rows)
            //{
            //    double depth = Convert.ToDouble(row["Depth"]);
            //    string soilType = row["SoilType"].ToString();

            //    // Добавляем точку на график
            //    series.Points.AddXY(soilType, depth);
            //}

            //// Добавляем серию на график
            //chart.Series.Add(series);

            //// Добавляем график на форму
            //Controls.Add(chart);


            ////Столбчатый
            // Создаем новый график
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea();
            chartArea.AxisY.Title = "Depth";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.IsReversed = true; // чтобы ось X была вверху
            chart.ChartAreas.Add(chartArea);

            // Устанавливаем тип графика на столбчатый
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;

            // Добавляем линии на график для каждой глубины и типа почвы
            foreach (DataRow row in profileData.Rows)
            {
                double depth = Convert.ToDouble(row["Depth"]);
                string soilType = row["SoilType"].ToString();

                // Добавляем точку на график
                series.Points.AddXY(soilType, depth);
            }

            // Добавляем серию на график
            chart.Series.Add(series);

            // Добавляем график на форму
            Controls.Add(chart);



        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
