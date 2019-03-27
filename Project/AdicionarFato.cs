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
                        removerResposta_btn.Hide();
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
                        removerResposta_btn.Show();
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
                        removerResposta_btn.Hide();
                    }
                    break;
            }
            AtualizaListBoxRespostas();
        }

        private void AtualizaListBoxRespostas()
        {
            listaResposta_listbox.DataSource = Respostas.Select(o => o.Descricao).ToList();
        }

        private void AtualizaListBoxFatos()
        {
            listaFatos_listbox.DataSource = Manager.instance.ListarFatos().Select(o => o.Nome).ToList();
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
            string min = resp_min_txtbox.Text;
            string max = max_txtbox.Text;

            if (!string.IsNullOrEmpty(min) && !string.IsNullOrEmpty(max))
            {
                Respostas.Add(new Resposta(0, min));
                Respostas.Add(new Resposta(1, max));
            }
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



            Manager.instance.CriarFato(nome, tipo.Value, Respostas);
            AtualizaListBoxFatos();
            Init();
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

            AtualizaListBoxRespostas();
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(nomeFato_txtbox.Text))
                return false;

            var tipo = BuscaTipoRespostaSelecionada();

            if (tipo == null)
                return false;

            if (tipo == TipoResposta.Numerico)
            {
                GerarRespostasNumerico();
            }

            if (Respostas.Count == 0)
                return false;

            return true;
        }

        private void Init()
        {
            nomeFato_txtbox.Text = string.Empty;
            univalorada_radio.Checked = true;
            AlteraRadio(TipoResposta.Univalorado);
            AtualizaListBoxFatos();
        }

        #region --------------------- EVENTOS ---------------------

        private void AdicionarFato_Load(object sender, EventArgs e)
        {
            Init();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var sel = listaFatos_listbox.SelectedIndex;

            if (sel != -1)
            {
                Manager.instance.RemoverFatoIndex(sel);
                AtualizaListBoxFatos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sel = listaResposta_listbox.SelectedIndex;

            if (sel != -1)
            {
                Respostas.RemoveAt(sel);
                AtualizaListBoxRespostas();
            }
        }
        #endregion --------------------- EVENTOS ---------------------
    }
}
