using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_m2
{
    public partial class Form2 : Form
    {
        Form3 cadastro = new Form3();

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 consulta = new Form1();
            this.Hide();
            consulta.Show();
        }
  
    }
}
