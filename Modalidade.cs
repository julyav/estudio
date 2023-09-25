using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        setDescricao(descricao);
        setPreco(preco);

    }

    public Modalidade(string descricao)
    {

    }

    public Modalidade()
    {

    }

    public bool cadastrarModalidade()
    {

    }

    public MySqlDataReader consultarModalidade()
    {

    }

    public MySqlDataReader consultarTodasModalidade()
    {

    }

    public bool atualizar





}
