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
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

namespace Project
{
    public partial class NovaRegra : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        bool primeiraRegra;
        Regra regra;

        public NovaRegra(Regra Regra)
        {
            InitializeComponent();

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            primeiraRegra = Regra.Condicao.Count == 0;
            gb_Group.Enabled = !primeiraRegra;
            regra = Regra;

            InserirFatos();
            InserirOperadores();
            InserirRespostas();
        }


        void InserirOperadores()
        {
            var fatoIndex = fato_combobox.SelectedIndex;
            var fato = Manager.instance.GetFatoById(fatoIndex);

            if(fato == null)
                return;

            var operadores = Estruturas.Util.ListarOperadores(fato.Tipo);
            operador_combobox.DataSource = operadores;

            operador_combobox.SelectedIndex = 0;
        }

        void InserirFatos()
        {
            var fatos = Manager.instance.ListarFatos();
            fato_combobox.DataSource = fatos.Select(x => x.Nome).ToArray();

            if (fato_combobox.Items.Count > 0)
            {
                fato_combobox.SelectedIndex = 0;
                CheckTipoRespostaNumerico(fatos[0]);
            }

        }

        void InserirRespostas(int index = 0)
        {
            var fato = Manager.instance.GetFatoById(index);

            if (fato == null)
                return;

            var respostas = fato.ListarRespostas();
            resposta_combobox.DataSource = respostas.Select(x => x.Descricao).ToArray();

            if (resposta_combobox.Items.Count != 0)
                resposta_combobox.SelectedIndex = 0;
            else
                ok_btn.Enabled = false;
        }

        private void fato_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = fato_combobox.SelectedIndex;
            var fato = Manager.instance.GetFatoById(index);

            if (fato != null)
            {
                InserirRespostas(index);
                InserirOperadores();

                CheckTipoRespostaNumerico(fato);
            }
            
        }

        private void CheckTipoRespostaNumerico(Fato fato)
        {
            if (fato.Tipo == TipoResposta.Numerico)
            {
                resposta_combobox.Hide();
                respostaNumerica.Show();
                respostaNumerica.Minimum = Convert.ToInt32(fato.Respostas[0].Descricao);
                respostaNumerica.Maximum = Convert.ToInt32(fato.Respostas[1].Descricao);
            }
            else
            {
                resposta_combobox.Show();
                respostaNumerica.Hide();
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            var fatoIndex = fato_combobox.SelectedIndex;
            var operadorIndex = operador_combobox.SelectedIndex;
            var respostaIndex = resposta_combobox.SelectedIndex;

            Conectivo conectivo = e_radio.Checked ? Conectivo.E : Conectivo.OU;

            var fato = Manager.instance.GetFatoById(fatoIndex);

            var resposta = fato.Respostas[respostaIndex];

            if (fato.Tipo == TipoResposta.Numerico)
                regra.AdicionarCondicao(primeiraRegra, conectivo, fato, (Operador)operadorIndex, new Resposta(0, (int)respostaNumerica.Value));
            else
                regra.AdicionarCondicao(primeiraRegra, conectivo, fato, (Operador)operadorIndex, resposta);

            regra.Save();//Salvar o ID da regra

            this.Close();
            
        }

        private void NovaRegra_Load(object sender, EventArgs e)
        {

        }
    }
}
