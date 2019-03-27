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
        private Manager mgr;

        public frmMain(Manager manager)
        {
            this.mgr = manager;
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*var fato = mgr.GetFatoById(1);
            if(fato != null)
            {
                MessageBox.Show(fato.Nome);
            }*/
            var addFato = new AdicionarFato();
            addFato.ShowDialog();

           // mgr.CriarFato("NomeFato1", Estruturas.E_T_RespostaFato.UniValorado, "SIM");
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var regras = Manager.instance.ListarRegras();
            if (regras.Count == 0)
                return;
            var regra = regras.FirstOrDefault();
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
