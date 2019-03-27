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

        List<Resposta> Respostas = new List<Resposta>();

        public AdicionarFato()
        {
            InitializeComponent();
        }

        private void AlteraRadio(TipoResposta opcao)
        {
            Respostas.Clear();
            switch (opcao)
            {
                case TipoResposta.Univalorado:
                    {
                        min_label.Hide();
                        max_label.Hide();
                        resp_min_txtbox.Hide();
                        max_txtbox.Hide();
                        addResposta_btn.Hide();
                        resposta_label.Hide();
                        GerarRespostasUnivalorado();
                    }
                    break;
                case TipoResposta.Multivalorado:
                    {
                        min_label.Hide();
                        max_label.Hide();
                        resp_min_txtbox.Show();
                        max_txtbox.Hide();
                        addResposta_btn.Show();
                        resposta_label.Show();
                    }
                    break;
                case TipoResposta.Numerico:
                    {
                        min_label.Show();
                        max_label.Show();
                        resp_min_txtbox.Show();
                        max_txtbox.Show();
                        addResposta_btn.Hide();
                        resposta_label.Show();
                    }
                    break;
            }
            listaResposta_listbox.DataSource = Respostas.Select(o => o.Descricao).ToList();
        }

        private void GerarRespostasUnivalorado()
        {
            var verdadeiro = new Resposta(1, "Verdadeiro");
            var falso = new Resposta(2, "Falso");

            Respostas.Add(verdadeiro);
            Respostas.Add(falso);
        }


        private void FecharFormAdicionarFato()
        {
            this.Close();
        }

        private void CriarNovoFato()
        {
            var manager = new Manager();
            var nome = nomeFato_txtbox.Text;
            var tipo = BuscaTipoRespostaSelecionada();

            manager.CriarFato(nome, tipo, Respostas);
        }

        public TipoResposta BuscaTipoRespostaSelecionada()
        {
            if (univalorada_radio.Checked)
                return TipoResposta.Univalorado;
            else if (multivalorada_radio.Checked)
                return TipoResposta.Multivalorado;
            else
                return TipoResposta.Numerico;
        }

        #region --------------------- EVENTOS ---------------------

        private void AdicionarFato_Load(object sender, EventArgs e)
        {
            univalorada_radio.Checked = true;
            AlteraRadio(TipoResposta.Univalorado);
        }

        private void univalorada_radio_CheckedChanged(object sender, EventArgs e)
        {
            AlteraRadio(TipoResposta.Univalorado);
        }

        private void multivalorada_radio_CheckedChanged(object sender, EventArgs e)
        {
            AlteraRadio(TipoResposta.Multivalorado);
        }

        private void numerica_radio_CheckedChanged(object sender, EventArgs e)
        {
            AlteraRadio(TipoResposta.Numerico);
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            FecharFormAdicionarFato();
        }

        private void salvarFato_btn_Click(object sender, EventArgs e)
        {
            CriarNovoFato();
        }
        #endregion --------------------- EVENTOS ---------------------
    }
}
