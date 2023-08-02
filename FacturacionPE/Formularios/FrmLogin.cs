using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionPE.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //Eliminar al final del desarrollo del software
            if (e.Shift & e.KeyCode == Keys.Up)
            {
                BtnIngresoDirecto.Visible = true;
            }
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            ObjetosGlobales.MiFormularioPrincipal.Show();
            this.Hide();
        }

        private void PbVerPass_MouseDown(object sender, MouseEventArgs e)
        {
            TxTContra.UseSystemPasswordChar = false;
        }

        private void PbVerPass_MouseUp(object sender, MouseEventArgs e)
        {
            TxTContra.UseSystemPasswordChar = true;
        }


        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxTName.Text.Trim()) && 
                !string.IsNullOrEmpty(TxTContra.Text.Trim()) &&
                Validacion.ValidarEmail(TxTName.Text.Trim()))
            {
                R = true;

            }
            else
            {
                if (string.IsNullOrEmpty(TxTName.Text.Trim()))
                {

                    MessageBox.Show("Es necesario ingresar un Usuario para Ingresar", "Error de Validación", MessageBoxButtons.OK);
                    TxTName.Focus();
                    return false;

                }
                if (string.IsNullOrEmpty(TxTContra.Text.Trim()))
                {
                    MessageBox.Show("Es necesario ingresar la contraseña para Ingresar", "Error de Validación", MessageBoxButtons.OK);
                    TxTContra.Focus();
                    return false;
                }
                if (!Validacion.ValidarEmail(TxTName.Text.Trim()))
                {
                    MessageBox.Show("El nombre de usuario no tiene el formato correcto", "Error de Validación", MessageBoxButtons.OK);
                    TxTName.Focus();
                    TxTName.SelectAll();
                    return false;
                }
            }




            return R;

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

                string user = TxTName.Text.Trim();
                string pass = TxTContra.Text.Trim();

                ObjetosGlobales.MiUsuarioGlobal = MiUsuario.ValidarIngreso(user, pass);

                if (ObjetosGlobales.MiUsuarioGlobal != null && 
                    ObjetosGlobales.MiUsuarioGlobal.IDUsuario > 0)
                {
                    ObjetosGlobales.MiFormularioPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de Validación", MessageBoxButtons.OK);
                    TxTContra.Focus();
                    TxTContra.SelectAll();
                }

            }

        }

        private void TxTContra_TextChanged(object sender, EventArgs e)
        {
            if (TxTContra.Text.Trim() != string.Empty)
            {
                PbVerPass.Visible = true;

            }
            else
            {
                PbVerPass.Visible = false;
            }
        }
    }
}
