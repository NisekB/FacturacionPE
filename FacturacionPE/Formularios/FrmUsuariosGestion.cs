using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionPE.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {

       public Logica.Models.Usuario MiUsuarioLocal { get; set; }


        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();

        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            ListarUsuariosActivos();

            CargarRolUsuario();



        }


        private void ListarUsuariosActivos()
        {
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();
            DataTable dt = MiUsuario.ListarActivos();

            DgvListaUsuarios.DataSource = dt;

            DgvListaUsuarios.ClearSelection();
        }


        private void CargarRolUsuario()
        {
            Logica.Models.UsuarioRol ObjRolUSuario = new Logica.Models.UsuarioRol();
            DataTable ListaRoles = new DataTable();
            ListaRoles = ObjRolUSuario.Listar();

            CboxTipoUsuario.ValueMember = "ID";
            CboxTipoUsuario.DisplayMember = "D";

            CboxTipoUsuario.DataSource = ListaRoles;
            CboxTipoUsuario.SelectedIndex = -1;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            MiUsuarioLocal.Nombre = TxTNombre.Text.Trim();
            MiUsuarioLocal.Email = TxTEmail.Text.Trim();
            MiUsuarioLocal.Telefono = TxTEmail.Text.Trim();
            MiUsuarioLocal.EmailRespaldo = TxTRespaldo.Text.Trim();
            MiUsuarioLocal.Contra = TxTContra.Text.Trim();
            MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
            MiUsuarioLocal.MiRol.IDRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);


            bool A = MiUsuarioLocal.ConsultarPorCedula();

            bool B = MiUsuarioLocal.ConsultarPorEmail();

            if (!A && !B)
            {

                //bool OK = MiUsuarioLocal.Agregar();

                if (MiUsuarioLocal.Agregar())
                {
                    MessageBox.Show("Usuario Agregado Correctamente!!!", ":D", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al agregar el Usuario", ":C", MessageBoxButtons.OK);
                }

                ListarUsuariosActivos();

            }
            else
            {
                if (A)
                {
                    MessageBox.Show("Ya Existe un usuario con la cédula digitada", "Error de Validación", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    TxtCedula.SelectAll();
                }
                if (B)
                {
                    MessageBox.Show("Ya Existe un usuario con el Email digitado", "Error de Validación", MessageBoxButtons.OK);
                    TxTEmail.Focus();
                    TxTEmail.SelectAll();
                }
            }


        }

        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaUsuarios.ClearSelection();
        }
    }
}
