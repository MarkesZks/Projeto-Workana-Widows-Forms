using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atv_m2
{
    public partial class Form3 : Form
    {
        Cadastro cadastro = new Cadastro();


        public Form3()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
       
            //salvamos todas as informaçoes das caixas de texto para OBJETO
            cadastro.setNome(textBox1.Text);
            cadastro.setSobrenome(textBox2.Text);
            cadastro.setEmail(textBox3.Text);
            cadastro.setSenha(textBox4.Text);
            cadastro.setConfirmaSenha(textBox4.Text);
            cadastro.setCPf(maskedTextBox1.Text);
            cadastro.setIdade(int.Parse(textBox9.Text));
            cadastro.setSexo(comboBox2.Text);
            cadastro.setTelefone(maskedTextBox2.Text);
            cadastro.setProfissao(textBox4.Text);
            cadastro.setEstado(comboBox1.Text);
            MessageBox.Show("Dados armazenados com sucesso!", "Salvar dados [OBJETO] ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //Conexao com o banco de dados

            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=atividadem2; password=''");

            //Querry de inserção de informaçoes para o BD
            MySqlCommand sqlQuery = new MySqlCommand(
                "INSERT INTO cadastro(Nome,Sobrenome,Email,Senha,CPF,Idade,Sexo,Telefone,Profissao,Estado) " +
                $"VALUES('{cadastro.getNome()}', " +
                $"'{cadastro.getSobrenome()}'," +
                $"'{cadastro.getEmail()}'," +
                $"'{cadastro.getSenha()}'," +
                $"'{cadastro.getCPf()}'," +
                $"{cadastro.getIdade()}," +
                $"'{cadastro.getSexo()}'," +
                $"'{cadastro.getTelefone()}'," +
                $"'{cadastro.getProfissao()}'," +
                $"'{cadastro.getEstado()}');", conexao);

            //Tentativa de abrir e enviar para o BD
            try
            {
                conexao.Open();
                sqlQuery.ExecuteReader();
                MessageBox.Show("Dados armazenados com sucesso!", "Salvar dados [DB] ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
