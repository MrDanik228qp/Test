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
    public partial class Stydents : Form
    {
        public Stydents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Stydents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "radchenko_Ychot_rabotDataSet.Stydenti". При необходимости она может быть перемещена или удалена.
            this.stydentiTableAdapter.Fill(this.radchenko_Ychot_rabotDataSet.Stydenti);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.stydentiTableAdapter.Update(this.radchenko_Ychot_rabotDataSet.Stydenti);
        }
    }
}
