using ModeloDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio
{
    public partial class Laboratorio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDadosPagina();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {


            string nome = txtNome.Text;
            int qtdComputadores = Convert.ToInt32(txtQtdComputadores.Text);
            int qtdAlunos = Convert.ToInt32(txtQtdAlunos.Text);
            Boolean projetor = Convert.ToBoolean(txtProjetor.Text);
            string software1 = txtSoftware1.Text;
            string software2 = txtSoftware2.Text;
            string software3 = txtSoftware3.Text;
            string sistemaOperacional = txtSistemaOperacional.Text;

            if ((qtdComputadores <= 1) || (qtdAlunos <= 4) || (software1 == null) || (software2 == null) || (software3 == null) || (nome.Length <= 2)){

                //PageUtility.MessageBox("<script>alert('Laboratorio não cadastrado. \n Por favor, revise o cadastro'); </script>"); 

               // Environment.Exit(0);

            }

            if (projetor == false)
            {


                Response.Write("Para utilização do projetor é necessário abrir uma solicitação para o help desk");


            }


            tb_laboratorio l = new tb_laboratorio() {nome = nome, qtdComputadores = qtdComputadores ,
                  qtdAlunos = qtdAlunos, projetor = projetor, software1 = software1, software2 = software2,
                  software3 = software3, sistemaOperacional = sistemaOperacional };

             DB_LaboratorioEntities contextLaboratorio = new DB_LaboratorioEntities();

            contextLaboratorio.tb_laboratorio.Add(l);
                 lblmsg.Text = "Registro Inserido";
                 Clear();

             contextLaboratorio.SaveChanges();
        }

        private void Clear()
        {


            txtNome.Text = "";
            txtQtdComputadores.Text = "";
            txtQtdAlunos.Text = "";
            txtProjetor.Text = "";
            txtSoftware1.Text = "";
            txtSoftware2.Text = "";
            txtSoftware3.Text = "";
            txtSistemaOperacional.Text = "";

            txtNome.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;

            tb_laboratorio laboratorio = new tb_laboratorio();
            DB_LaboratorioEntities contextLaboratorio = new DB_LaboratorioEntities();

            if (!String.IsNullOrEmpty(valor))
            {
                idItem = Convert.ToInt32(valor);
                laboratorio = contextLaboratorio.tb_laboratorio.First(c => c.id == idItem);



                txtNome.Text = laboratorio.nome;
                txtQtdComputadores.Text = Convert.ToString(laboratorio.qtdComputadores);
                txtQtdAlunos.Text = Convert.ToString(laboratorio.qtdAlunos);
                txtProjetor.Text = Convert.ToString(laboratorio.projetor);
                txtSoftware1.Text = laboratorio.software1;
                txtSoftware2.Text = laboratorio.software2;
                txtSoftware3.Text = laboratorio.software3;
                txtSistemaOperacional.Text = laboratorio.sistemaOperacional;


            }
        }
    }
}