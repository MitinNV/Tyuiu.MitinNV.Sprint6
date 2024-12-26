using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MitinNV.Sprint6.Task5.V27.Lib;

namespace Tyuiu.MitinNV.Sprint6.Task5.V27
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
                dataGridViewRes_MNV.Columns[0].Width = 75;
                dataGridViewRes_MNV.Rows.Clear();
                var res = ds.LoadFromDataFile("C:\\DataSprint5\\InPutDataFileTask5V27.txt");
                foreach (var item in res)
                {
                    dataGridViewRes_MNV.Rows.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось вывести данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfoDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт #6 | Таск #5 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}