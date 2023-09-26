using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudio
{
    public partial class ExcluirModalidade : Form
    {
        public ExcluirModalidade()
        {
            InitializeComponent();
        }

        private void ExcluirModalidade_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           Modalidade modalidade = new Modalidade(comboBox1.Text);
            if (e.KeyChar == 13)
            {
                if (modalidade.consultarModalidade())
                {
                    if (modalidade.excluirModalidade())
                    {
                        MessageBox.Show("Modalidade Excluído com sucesso!");
                    }
                }
            }
        }

   
    }
}
