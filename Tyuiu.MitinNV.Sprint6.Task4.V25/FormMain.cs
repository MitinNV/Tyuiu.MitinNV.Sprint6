using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MitinNV.Sprint6.Task4.V25.Lib;

namespace Tyuiu.MitinNV.Sprint6.Task4.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                dataGridViewRes_MNV.Columns[0].Width = 100;
                dataGridViewRes_MNV.Columns[1].Width = 100;
                dataGridViewRes_MNV.Rows.Clear();
                var x = Convert.ToInt32(textBoxValueX_MNV.Text);
                var res = ds.GetMassFunction(x, Convert.ToInt32(textBoxValueY_MNV.Text));
                foreach (var item in res)
                {
                    dataGridViewRes_MNV.Rows.Add(x, item);
                    x++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfoDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт #6 | Таск #4 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxResult_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxValueX_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxValueX_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxCondition_MNV_Enter(object sender, EventArgs e)
        {

        }

        private void labelCond_MNV_Click(object sender, EventArgs e)
        {

        }

        private void labelResult_MNV_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSaveToFile_MNV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                var arr = ds.GetMassFunction(Convert.ToInt32(textBoxValueX_MNV.Text), Convert.ToInt32(textBoxValueY_MNV.Text));
                var s = "F(x)\n";
                foreach (var item in arr)
                {
                    s += $"{item}\n";
                }

                var path = Path.Combine(Path.GetTempPath(), "dataSprint6Task4.txt");

                File.WriteAllText(path, s);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при сохранении в файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}