using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            string a = textBox2.Text;
            string t = textBox3.Text;
            string i = textBox4.Text;
            string m = textBox4.Text;
            dataGridView1.Rows.Add(p, a, t, i, m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 xy = new Form2();
            xy.Show();
            this.Hide();
            xy.Show();
        }
    }
}
