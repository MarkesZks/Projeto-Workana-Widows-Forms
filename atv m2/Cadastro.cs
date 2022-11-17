using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Gabriel Marques - 11221102170
Programa Atividade M2
 */

class Cadastro
{
    //Definição de variaveis
    private string nome;
    private string sobrenome;
    private string email;
    private string senha;
    private string confirmaSenha;
    private string estado;
    private string cpf;
    private string profissao;
    private string sexo;
    private int idade;
    private string telefone;



    public Cadastro()
    {

        this.nome = "";
        this.sobrenome = "";
        this.email = "";
        this.senha = "";
        this.confirmaSenha = "";
        this.estado = "";
        this.cpf = "";
        this.profissao = "";
        this.sexo = "";
        this.idade = 0;
        this.telefone = "";
    }

    public Cadastro(

    string p_nome,
    string p_sobrenome,
    string p_email,
    string p_senha,
    string p_confirmaSenha,
    string p_estado,
    string p_cpf,
    string p_profissao,
    string p_sexo,
    int p_idade,
    string p_telefone
        )
    {
        this.nome = p_nome;
        this.sobrenome = p_sobrenome;
        this.cpf = p_cpf;
        this.email = p_email;
        this.senha = p_senha;
        this.confirmaSenha = p_confirmaSenha;
        this.idade = p_idade;
        this.sexo = p_sexo;
        this.profissao = p_profissao;
        this.telefone = p_telefone;
        this.estado = p_estado;
    }

    //Nome- Metodos
    public string getNome()
    { return this.nome; }
    public void setNome(string p_nome)
    { this.nome = p_nome; }

    //Sobrenome- Metodos
    public string getSobrenome()
    { return this.sobrenome; }
    public void setSobrenome(string p_sobrenome)
    { this.sobrenome = p_sobrenome; }

    //CPF- Metodos
    public string getCPf()
    { return this.cpf; }
    public void setCPf(string p_cpf)
    { this.cpf = p_cpf; }

    //Email- Metodos
    public string getEmail()
    { return this.email; }
    public void setEmail(string p_email)
    { this.email = p_email; }

    //Senha- Metodos
    public string getSenha()
    { return this.senha; }
    public void setSenha(string p_senha)
    { this.senha = p_senha; }

    //Confirmar Senha- Metodos
    public string getConfirmaSenha()
    { return this.confirmaSenha; }
    public void setConfirmaSenha(string p_confirmaSenha)
    { this.confirmaSenha = p_confirmaSenha; }

    //Idade- Metodos
    public int getIdade()
    { return this.idade; }
    public void setIdade(int p_idade)
    { this.idade = p_idade; }

    //Sexo- Metodos
    public string getSexo()
    { return this.sexo; }
    public void setSexo(string p_sexo)
    { this.sexo = p_sexo; }

    //Telefone- Metodos
    public string getTelefone()
    { return this.telefone; }
    public void setTelefone(string p_telefone)
    { this.telefone = p_telefone; }

    //Profissao- Metodos
    public string getProfissao()
    { return this.profissao; }
    public void setProfissao(string p_profissao)
    { this.profissao = p_profissao; }

    //Estado- Metodos
    public string getEstado()
    { return this.estado; }
    public void setEstado(string p_estado)
    { this.estado = p_estado; }

}


