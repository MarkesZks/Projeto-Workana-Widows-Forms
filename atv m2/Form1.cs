using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {

        int qtd_registros;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=atividadem2; password=''"); // Conexão - Server: porta / DB
            MySqlCommand sqlQuery = new MySqlCommand("SELECT * FROM cadastro;", conexao); // Instr. SQL
            dataGridView1.Rows.Clear();


            try
            {
                conexao.Open();
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();

                while (dataReader.Read())
                {
                    object[] registro = new object[dataReader.FieldCount];

                    if (dataGridView1.Rows.Count == 0)
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            dataGridView1.Columns.Add(dataReader.GetName(i), dataReader.GetName(i));
                        }
                    }

                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        registro[i] = dataReader.GetValue(i); // monta o registro.
                    }
                    dataGridView1.Rows.Add(registro); // Adiciona a linha

                    qtd_registros++;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 telaprincipal = new Form2();
            this.Hide();
            telaprincipal.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
