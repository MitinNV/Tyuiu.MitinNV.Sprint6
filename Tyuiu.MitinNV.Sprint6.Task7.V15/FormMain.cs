using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MitinNV.Sprint6.Task7.V15.Lib;

namespace Tyuiu.MitinNV.Sprint6.Task7.V15
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
            dataGridRes_MNV.Rows.Clear();
            var matrix = new int[,] { { -18, 0, -9, -10, -18, -17, -19, 20, 14, -16 }, { -10, -17, 6, -7, -20, 17, -13, 15, -4, -18 }, { -11, -12, -20, -20, 10, -13, 3, 11, 14, 16 }, { 18, 4, -20, 7, -8, 6, -11, -15, 7, -2 }, { -14, -15, -12, 16, -12, 19, 12, -10, -4, 13 }, { 4, -6, -11, 3, 13, 1, -20, 13, -5, 13 }, { 9, -4, -17, 19, 5, 5, -1, -17, -4, 9 }, { -20, -9, -15, 19, 17, 10, -7, -3, 5, 15 }, { -16, -5, 20, -16, 19, 0, 3, 12, -17, 2 }, { -20, 8, -2, 8, 12, 12, -8, 0, 1, 19 } };
            for (int i = 0; i < 10; i++)
            {
                dataGridRes_MNV.Rows.Add(matrix[i, 0], matrix[i, 1], matrix[i, 2], matrix[i, 3], matrix[i, 4], matrix[i, 5], matrix[i, 6], matrix[i, 7], matrix[i, 8], matrix[i, 9]);
            }
        }
        private void buttonInfoDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт #6 | Таск #7 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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