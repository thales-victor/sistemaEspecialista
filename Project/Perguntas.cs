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
        public int Return;
        private List<RadioButton> radioButtons = new List<RadioButton>();
        private Fato Fato;
        public Perguntas(Fato fato)
        {
            Fato = fato;
            InitializeComponent();
        }

        private void Init()
        {
            int y = 130;

            pergunta_label.Text += Fato.Nome;
            pergunta_label.Text += " ?";

            foreach(var resposta in Fato.Respostas)
            {
                var rdbtn = new RadioButton()
                {
                    Text = resposta.Descricao,
                    Location = new Point(148, y),
                    Visible = true,
                    Name = resposta.Id.ToString()
                };
                radioButtons.Add(rdbtn);
                this.Controls.Add(rdbtn);
                y += 25;
            }
        }

        private int RespostaSelecionada()
        {
            int selecionada = -1;
            foreach (var radio in radioButtons)
            {
                if (radio.Checked)
                {
                    selecionada = Convert.ToInt32(radio.Name);
                }
            }
            return selecionada;
        }

        private void Perguntas_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Return = RespostaSelecionada();
            this.Close();
        }
    }
}
