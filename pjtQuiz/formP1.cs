using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtQuiz
{
    public partial class formP1 : Form
    {
        public formP1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            if (rbtncerta.Checked == true)
            {
                MessageBox.Show("certa resposta", "Quiz");
                //somar na variavel global acertos
                VariaveisGlobais.Acertos += 1;
                formP2 p2 = new formP2();
                p2.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("resposta incorreta", "Quiz");
                //somar na variavel global erros
                VariaveisGlobais.Erros += 1;
                formP2 p2 = new formP2();
                p2.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("escolha uma alternativa");
            }
        }
    }
}
