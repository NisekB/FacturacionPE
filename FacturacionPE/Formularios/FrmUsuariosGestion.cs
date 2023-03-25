﻿using System;
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

            LimpiarFormulario();

        }

        private void LimpiarFormulario()
        {
            TxTCodigo.Clear();
            TxTNombre.Clear();
            TxTEmail.Clear();
            TxtCedula.Clear();
            TxTContra.Clear();
            TxTRespaldo.Clear();
            TxTTelefono.Clear();
            CboxTipoUsuario.SelectedIndex = -1;

        }

        private void ListarUsuariosActivos()
        {
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();
            DataTable dt = MiUsuario.ListarActivos();

            DgvListaUsuarios.DataSource = dt;

            DgvListaUsuarios.ClearSelection();
        }

        private bool ValidarDatosRequeridos()
        {

            bool R = false;
            if (!string.IsNullOrEmpty(TxTNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxTEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxTTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxTRespaldo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxTContra.Text.Trim()) &&
                CboxTipoUsuario.SelectedIndex > -1
                )
            {
                R = true;
            }
            else{

                if (string.IsNullOrEmpty(TxTNombre.Text.Trim()))
                {
                    MessageBox.Show("El nombre del Usuario es Requerido", "Error de validación", MessageBoxButtons.OK);
                    TxTNombre.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxTEmail.Text.Trim()))
                {
                    MessageBox.Show("El Email del Usuario es Requerido", "Error de validación", MessageBoxButtons.OK);
                    TxTEmail.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("La Cédula del Usuario es Requerida", "Error de validación", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxTTelefono.Text.Trim()))
                {
                    MessageBox.Show("El número de Teléfono del Usuario es Requerido", "Error de validación", MessageBoxButtons.OK);
                    TxTTelefono.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxTRespaldo.Text.Trim()))
                {
                    MessageBox.Show("El Email de Respaldo del Usuario es Requerido", "Error de validación", MessageBoxButtons.OK);
                    TxTRespaldo.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxTContra.Text.Trim()))
                {
                    MessageBox.Show("La Contraseña del Usuario es Requerida", "Error de validación", MessageBoxButtons.OK);
                    TxTContra.Focus();
                    return false;
                }
                if (CboxTipoUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("El Tipo de Usuario es Requerido", "Error de validación", MessageBoxButtons.OK);
                    CboxTipoUsuario.Focus();
                    return false;
                }

            }
            return R;
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
            if (ValidarDatosRequeridos())
            {

             string Pregunta = String.Format("Está seguro que desea agregar al nuevo usuario {0}?", TxTNombre.Text.Trim());

             DialogResult RespuestaDelUsuario = MessageBox.Show(Pregunta, "Deseas continuar???", MessageBoxButtons.YesNo);

            if (RespuestaDelUsuario == DialogResult.Yes)
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

                LimpiarFormulario();

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
            }

        }

        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaUsuarios.ClearSelection();
        }

        private void TxTNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, true);
        }

        private void TxTEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, false, true);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e, true);
        }

        private void TxTTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e, true);
        }

        private void TxTRespaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, false, true);
        }

        private void TxTContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e);
        }

        private void TxTEmail_Leave(object sender, EventArgs e)
        {
            if (TxTEmail.Text.Trim() != string.Empty)
            {
                if (Validacion.ValidarEmail(TxTEmail.Text.Trim()) == false)
                {
                    MessageBox.Show("Correo no tiene el formato correcto!!", ":(", MessageBoxButtons.OK);
                    TxTEmail.Focus();
                    TxTEmail.SelectAll();
                }
            }
        }

        private void TxTRespaldo_Leave(object sender, EventArgs e)
        {
            if (TxTRespaldo.Text.Trim() != string.Empty)
            {
                if (Validacion.ValidarEmail(TxTRespaldo.Text.Trim()) == false)
                {
                    MessageBox.Show("Correo de respaldo no tiene el formato correcto!!", ":(", MessageBoxButtons.OK);
                    TxTRespaldo.Focus();
                    TxTRespaldo.SelectAll();
                }
            }
        }



        private bool ValidacionParaContraseñas(string pass)
        {

            CbMayuscula.Checked = false; CbMinuscula.Checked = false; CbNumero.Checked = false; CbEspecial.Checked = false; CbMinimo.Checked = false; ;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass.Length >= 6)
                {
                    CbMinimo.Checked = true;
                }
                if (Char.IsUpper(pass, i))
                {
                    CbMayuscula.Checked = true;
                }
                else if (Char.IsLower(pass, i))
                {
                    CbMinuscula.Checked = true;
                }
                else if (Char.IsDigit(pass, i))
                {
                    CbNumero.Checked = true;
                }
                else
                {
                    CbEspecial.Checked = true;
                }
            }
            if (CbMayuscula.Checked && CbMinuscula.Checked && CbNumero.Checked && CbEspecial.Checked && pass.Length >= 6)
            {
                return true;
            }

            return false;

        }


        private void ValidarComplejidad()
        {

            
           if (!CbMayuscula.Checked)
           {
             MessageBox.Show("Contraseña no tiene el formato correcto", ":(", MessageBoxButtons.OK);
             TxTContra.Focus();
             return;
            }
           if (!CbMinimo.Checked)
            {
                MessageBox.Show("Contraseña no tiene el formato correcto", ":(", MessageBoxButtons.OK);
                TxTContra.Focus();
                return;
            }
           if (!CbNumero.Checked)
            {
                MessageBox.Show("Contraseña no tiene el formato correcto", ":(", MessageBoxButtons.OK);
                TxTContra.Focus();
                return;
            }
           if (!CbEspecial.Checked)
            {
                MessageBox.Show("Contraseña no tiene el formato correcto", ":(", MessageBoxButtons.OK);
                TxTContra.Focus();
                return;
            }
           if (!CbMinuscula.Checked)
            {
                MessageBox.Show("Contraseña no tiene el formato correcto", ":(", MessageBoxButtons.OK);
                TxTContra.Focus();
                return;
            }


        }

        private void TxTContra_TextChanged(object sender, EventArgs e)
        {

            ValidacionParaContraseñas(TxTContra.Text);
                     
        }

        private void TxTContra_Leave(object sender, EventArgs e)
        {
            ValidarComplejidad();
        }

        private void BtnLimpiarForm_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaUsuarios.SelectedRows[0];

                int IDUsuarioSeleccionado = Convert.ToInt32(Fila.Cells["CIDUsuario"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IDUsuarioSeleccionado);

                if (MiUsuarioLocal.IDUsuario > 0)
                {

                    LimpiarFormulario();

                    TxTCodigo.Text = MiUsuarioLocal.IDUsuario.ToString();
                    TxTNombre.Text = MiUsuarioLocal.Nombre;
                    TxTEmail.Text =MiUsuarioLocal.Email;
                    TxTTelefono.Text = MiUsuarioLocal.Telefono;
                    TxTRespaldo.Text = MiUsuarioLocal.EmailRespaldo;
                    TxtCedula.Text = MiUsuarioLocal.Cedula;

                    CboxTipoUsuario.SelectedValue = MiUsuarioLocal.MiRol.IDRol;

                }

            }
        }
    }
}
