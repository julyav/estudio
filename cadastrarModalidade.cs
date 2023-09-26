using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace estudio
{
    public partial class CadastrarModalidade : Form
    {
        public CadastrarModalidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int opcao = 0;
            Modalidade modalidade = new Modalidade(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (opcao == 1)
            {
                if (modalidade.CadastrarModalidade())
                {
                    MessageBox.Show("Cadastro Realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
