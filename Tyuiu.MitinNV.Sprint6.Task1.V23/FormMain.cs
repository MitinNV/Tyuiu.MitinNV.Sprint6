﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MitinNV.Sprint6.Task1.V23.Lib;

namespace Tyuiu.MitinNV.Sprint6.Task1.V23
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
                var x = Convert.ToInt32(textBoxValueX_MNV.Text);
                var res = ds.GetMassFunction(x, Convert.ToInt32(textBoxValueY_MNV.Text));
                string s = "x     F(x)\n";
                foreach (var item in res)
                {
                    s += $"{x}     {item}\n";

                    x++;
                }

                labelResult_MNV.Text = s;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfoDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт #6 | Таск #1 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}