using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace estudio
{
    class Modalidade
    {
        private string Descricao;
        private float Preco;
        private int qtde_alunos, qntde_aulas;

        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public int Qntde_aulas { get => qntde_aulas; set => qntde_aulas = value; }
    }

    public Modalidade(string descricao, float preco, int qntde_alunos, int qntde_aulas)
    {
        setDescricao1(descricao);
        setPreco1(preco);
        setQtde_alunos(qntde_alunos);
        setQntde_aulas(qntde_aulas);
    }

    public Modalidade(string descricao)
    {
        setDescricao(descricao);
    }

    public Modalidade()
    {

    }

    public bool CadastrarModalidade()
    {
        bool cad = false;

        try
        {
            DAO_Conexao.con.Open();
            MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade (descricaoMod, precoMod, qtdeAlunos, qtdeAulas) values ('" + Descricao + "','" + Preco + "','" + qtdeAlunos + "','" + qtdeAulas + "')", DAO_Conexao.con);
            insere.ExecuteNonQuery();
            cad = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            DAO_Conexao.con.Close();
        }

        return cad;

    }

    public MySqlDataReader ConsultarModalidade()
    {
        bool existe = false;
        try
        {
            DAO_Conexao.con.Open();
            MySqlCommand consulta = new MySqlCommand("select * from Estudio_Modalidade where descricaoMod='" + Descricao + "'", DAO_Conexao.con);
            MySqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                existe = true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            DAO_Conexao.con.Close();
        }

        return existe;

    }

    public MySqlDataReader ConsultarTodasModalidade()
    {

    }

    public bool atualizarModalidade()
    {
        bool exc = false;

        try
        {
            DAO_Conexao.con.Open();
            MySqlCommand atualiza = new MySqlCommand("update Estudio_Modalidade set descricaoMod = '" + Descricao + "', precoMod = '" + Preco + "', qtdeAlunos = '" + qtdeAlunos + "', qtdeAulas = '" + qtdeAulas + "'", DAO_Conexao.con);
            atualiza.ExecuteNonQuery();
            exc = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            DAO_Conexao.con.Close();
        }

        return exc;

    }

    public bool excluirModalidade()
    {
        bool exc = false;
        try
        {
            DAO_Conexao.con.Open();
            MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidade set ativo = 1 where descricaoMod='" + Descricao + "'", DAO_Conexao.con);
            exclui.ExecuteNonQuery();
            exc = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            DAO_Conexao.con.Close();
        }

        return exc;

    }







}
