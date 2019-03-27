using Project.Estruturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Perguntas : Form
    {
        private Condicao Condicao;
        public Perguntas(Condicao condicao)
        {
            Condicao = condicao;
            InitializeComponent();
        }

        private void Init()
        {
            int y = 130;

            pergunta_label.Text += Condicao.Fato.Nome;
            pergunta_label.Text += " ?";

            foreach(var resposta in Condicao.Fato.Respostas)
            {
                var rdbtn = new RadioButton()
                {
                    Text = resposta.Descricao,
                    Location = new Point(148, y),
                    Visible = true,
                
                };
                this.Controls.Add(rdbtn);
                y += 25;
            }
        }

        private void Perguntas_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
