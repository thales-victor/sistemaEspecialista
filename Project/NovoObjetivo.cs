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
    public partial class NovoObjetivo : Form
    {
        Estruturas.Regra regra;

        public NovoObjetivo(Estruturas.Regra Regra)
        {
            InitializeComponent();
            regra = Regra;

            InserirFatos();
            InserirOperadores();
            InserirRespostas();
        }


        void InserirFatos()
        {
            var fatos = Manager.instance.ListarFatos();
            fato_combobox.DataSource = fatos.Select(x => x.Nome).ToArray();

            if (fato_combobox.Items.Count > 0)
                fato_combobox.SelectedIndex = 0;
        }

        void InserirOperadores()
        {

            var fatoIndex = fato_combobox.SelectedIndex;
            var fato = Manager.instance.GetFatoById(fatoIndex);

            if (fato == null)
                return;

            var operadores = Estruturas.Util.ListarOperadores(fato.Tipo);
            operador_combobox.DataSource = operadores;

            operador_combobox.SelectedIndex = 0;
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

        private void ok_btn_Click(object sender, EventArgs e)
        {
            var fatoIndex = fato_combobox.SelectedIndex;
            var operadorIndex = operador_combobox.SelectedIndex;
            var respostaIndex = resposta_combobox.SelectedIndex;

            var fato = Manager.instance.GetFatoById(fatoIndex);

            var resposta = fato.Respostas[respostaIndex];


            //var objetivo = Manager.instance.CriarObjetivo();

            regra.CondicaoObjetivo(fato, (Estruturas.Operador)operadorIndex, resposta);        

            this.Close();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
