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
                        listaResposta_label.Show();
                        listaResposta_listbox.Show();
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
                        listaResposta_label.Show();
                        listaResposta_listbox.Show();
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
                        listaResposta_label.Hide();
                        listaResposta_listbox.Hide();
                    }
                    break;
            }
            AtualizaListBox();
        }

        private void AtualizaListBox()
        {
            listaResposta_listbox.DataSource = Respostas.Select(o => o.Descricao).ToList();
        }

        private void GerarRespostasUnivalorado()
        {
            var verdadeiro = new Resposta(0, "Verdadeiro");
            var falso = new Resposta(1, "Falso");

            Respostas.Add(verdadeiro);
            Respostas.Add(falso);
        }

        private void GerarRespostasNumerico()
        {
            var min = new Resposta(0, resp_min_txtbox.Text);
            var max = new Resposta(1, max_txtbox.Text);

            Respostas.Add(min);
            Respostas.Add(max);
        }


        private void FecharFormAdicionarFato()
        {
            this.Close();
        }

        private void CriarNovoFato()
        {
            if (!IsValid())
            {
                MessageBox.Show("Preencha corretamente os campos para poder salvar!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var nome = nomeFato_txtbox.Text;
            var tipo = BuscaTipoRespostaSelecionada();

            if (tipo == TipoResposta.Numerico)
            {
                GerarRespostasNumerico();
            }

            Manager.instance.CriarFato(nome, tipo.Value, Respostas);

            FecharFormAdicionarFato();
        }

        public TipoResposta? BuscaTipoRespostaSelecionada()
        {
            if (univalorada_radio.Checked)
                return TipoResposta.Univalorado;
            else if (multivalorada_radio.Checked)
                return TipoResposta.Multivalorado;
            else if (numerica_radio.Checked)
                return TipoResposta.Numerico;

            return null;
        }

        public void AdicionarResposta()
        {
            int id = Respostas.Count + 1;
            string desc = resp_min_txtbox.Text;

            Respostas.Add(new Resposta(id, desc));

            resp_min_txtbox.Text = string.Empty;
            resp_min_txtbox.Focus();

            AtualizaListBox();
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(nomeFato_txtbox.Text))
                return false;

            var tipo = BuscaTipoRespostaSelecionada();

            if (tipo == null)
                return false;

            /*
            if (Respostas.Count <= 0)
                return false;*/

            return true;
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
        private void addResposta_btn_Click(object sender, EventArgs e)
        {
            AdicionarResposta();
        }
        #endregion --------------------- EVENTOS ---------------------

    }
}
