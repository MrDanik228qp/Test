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
    public partial class Raboti : Form
    {
        public Raboti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Raboti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "radchenko_Ychot_rabotDataSet.Ychot_rabot". При необходимости она может быть перемещена или удалена.
            this.ychot_rabotTableAdapter.Fill(this.radchenko_Ychot_rabotDataSet.Ychot_rabot);

        }
    }
}
