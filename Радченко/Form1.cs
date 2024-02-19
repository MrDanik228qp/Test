using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Радченко
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radchenkoYchotrabotDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "radchenko_Ychot_rabotDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            //this.sotrudnikiTableAdapter.Fill(this.radchenko_Ychot_rabotDataSet.Sotrudniki);
            ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sotrydniki sotrydniki = new Sotrydniki();
            Hide();
            sotrydniki.ShowDialog();
            Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stydents stydents = new Stydents();
            Hide();
            stydents.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raboti raboti = new Raboti();
            Hide();
            raboti.ShowDialog();
            Show();
        }
    }
}
