using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace pjtQuiz
{
    public partial class formP2 : Form
    {
        public formP2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtncerta.Checked == true)
            {
                MessageBox.Show("certa resposta", "Quiz");
                //somar na variavel global acertos
                VariaveisGlobais.Acertos += 1;
                formP3 p3 = new formP3();
                p3.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked)
            {
                MessageBox.Show("resposta incorreta", "Quiz");
                //somar na variavel global erros
                VariaveisGlobais.Erros += 1;
                formP3 p3 = new formP3();
                p3.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("escolha uma alternativa");
            }
        }
    }
}
