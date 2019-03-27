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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            AtualizarRegrasCriadas();
        }

        void AtualizarRegrasCriadas()
        {
            regrasCriadas_listbox.DataSource = Manager.instance.ListarRegras();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addFato = new AdicionarFato();
            addFato.ShowDialog();
        }

        private void criarObjetivo_btn_Click(object sender, EventArgs e)
        {
            var addObjetivo = new AdicionarObjetivo();
            addObjetivo.ShowDialog();
        }

        private void criarRegra_btn_Click(object sender, EventArgs e)
        {
            var addRegra = new AdicionarRegra();
            addRegra.ShowDialog();

            AtualizarRegrasCriadas();
        }

        private void regrasCriadas_listbox_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Estruturas.Regra)
            {
                Estruturas.Regra regra = (Estruturas.Regra)e.ListItem;

                e.Value = string.Format($"{regra.Nome}");

            }
            else
            {
                e.Value = "Item desconhecido";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var regras = Manager.instance.ListarRegras();

            if (regras.Length == 0)
                return;
            foreach (var regra in regras)
            {
                var condicoes = regra.Condicao;
                if (condicoes.Count == 0)
                    return;
                foreach (var condicao in condicoes)
                {
                    using (var perguntas = new Perguntas(condicao))
                    {
                        perguntas.ShowDialog();
                    }
                }
            }
        }
    }
}
