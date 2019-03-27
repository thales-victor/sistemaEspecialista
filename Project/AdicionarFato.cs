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
    public partial class AdicionarFato : Form
    {
        Fato fato = new Fato(0, "");

        public AdicionarFato()
        {
            InitializeComponent();
        }

        private void univalorada_radio_CheckedChanged(object sender, EventArgs e)
        {
            alteraRadio(E_T_RespostaFato.Univalorado);
        }

        private void alteraRadio(E_T_RespostaFato opcao)
        {
            fato.Respostas.Clear();

            switch (opcao)
            {
                case E_T_RespostaFato.Univalorado:
                    {
                        fato.Respostas.Add(new Resposta(0, "Verdadeiro"));
                        fato.Respostas.Add(new Resposta(0, "Falso"));
                        
                    }
                    break;
                case E_T_RespostaFato.Multivalorado:
                    {

                    }
                    break;
                case E_T_RespostaFato.Numerico:
                    {

                    }
                    break;
            }

            listaResposta_listbox.DataSource = fato.Respostas;
        }

        private void AdicionarFato_Load(object sender, EventArgs e)
        {
            alteraRadio(E_T_RespostaFato.Univalorado);

            min_label.Hide();
            max_label.Hide();
            resp_min_txtbox.Hide();
            max_txtbox.Hide();
        }
    }
}
