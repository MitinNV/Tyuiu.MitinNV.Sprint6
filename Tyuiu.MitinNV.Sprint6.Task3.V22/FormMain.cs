using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MitinNV.Sprint6.Task3.V22.Lib;

namespace Tyuiu.MitinNV.Sprint6.Task3.V22
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
            DataService ds = new DataService();
            var mat = new int[,] { { 17, 0, 19, -8, -1 }, { 9, 4, -5, 7, 15 }, { 11, 13, 4, -4, -14 }, { 11, 14, 5, -15, 16 }, { 2, -14, -2, 11, 11 } };
            var resMat = ds.Calculate(mat);
            for (int i = 0; i < 5; i++)
            {
                dataGridRes_MNV.Rows.Add(resMat[i, 0], resMat[i, 1], resMat[i, 2], resMat[i, 3], resMat[i, 4]);
            }
        }
        private void buttonInfoDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт #6 | Таск #3 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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