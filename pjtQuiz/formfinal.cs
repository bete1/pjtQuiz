using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtQuiz
{
    public partial class formfinal : Form
    {
        public formfinal()
        {
            InitializeComponent();
        }

        private void btnnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formfinal_Load(object sender, EventArgs e)
        {
            label4.Text= VariaveisGlobais.Acertos.ToString(); 
            label5.Text= VariaveisGlobais.Erros.ToString();   
        }
    }
}
