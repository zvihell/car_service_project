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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 xy = new Form3();
            xy.Show();
            this.Hide();
            xy.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 xy = new Form4();
            xy.Show();
            this.Hide();
            xy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 xy = new Form5();
            xy.Show();
            this.Hide();
            xy.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 xy = new Form6();
            xy.Show();
            this.Hide();
            xy.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 xy = new Form7();
            xy.Show();
            this.Hide();
            xy.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 xy = new Form8();
            xy.Show();
            this.Hide();
            xy.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 xy = new Form9();
            xy.Show();
            this.Hide();
            xy.Show();
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void нашиРеквизитыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 xy = new Form10();
            xy.Show();
            this.Hide();
            xy.Show();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 xy = new Form2();
            xy.Show();
            this.Hide();
            xy.Show();
        }

       
    }
}
