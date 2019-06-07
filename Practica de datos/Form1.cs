using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Practica_de_datos
{
    public partial class Form1 : Form
    {
        CTelefonosDataAccess dataAcces;
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            MostrarImagenCarga(  true);
            dataAcces = new CTelefonosDataAccess();
            CTelefonos registro;
            Guid registroId = Guid.Empty;

            Guid.TryParse(lbId.Text, out registroId);
            registro = returnObjectCtelefono();
            if (!validarCampos(registro))
            {
                MostrarImagenCarga(false);
                return;
            }

            try
            {
                if (registroId == Guid.Empty)
                {
                    registroId = dataAcces.NuevoRegistro(registro);
                    lbFechaCreado.Text = DateTime.Now.ToString("dd, MMM yyyy hh:mm");
                    lbId.Text = registroId.ToString();
                    habilitarCampos(true);
                    MessageBox.Show("Registro guardado exitosamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dataAcces.ActualizarRegistro(registro))
                    {
                        MessageBox.Show("Registro actualizado", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("El registro no ha sido actualizado.", "Guardar Registro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                        {
                            btAdd.PerformClick();
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarImagenCarga(false); 
                if (MessageBox.Show("Error al guardar el registro: \n" + ex.Message, "Guardar Registro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    btAdd.PerformClick();
                }
                return;
            }
            MostrarImagenCarga(false);
            ActualizarContador();
        }
        private void btNuevo_Click(object sender, EventArgs e)
        {

            lbNregistros.Text = "Nuevo";
            LimprarCampos();
            habilitarCampos(false);

        }
        private void btBorrar_Click(object sender, EventArgs e)
        {


            CTelefonos registro = returnObjectCtelefono();
            if (registro._IdTelefono == Guid.Empty)
            {
                MessageBox.Show("Registro no valido para ser eliminado", "Borrar registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Esta seguro de eliminar este registro?", "Borrar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                dataAcces = new CTelefonosDataAccess();
                if (dataAcces.EliminarRegistro(registro))
                {
                    MessageBox.Show("Registro elimiado", "Borrar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimprarCampos();
                    btPrimero.PerformClick();
                }
                else
                {
                    if (MessageBox.Show("El registro no ha sido borrado", "Borrar Registro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    {
                        btBorrar.PerformClick(); return;
                    }
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Error al borrar el registro: \n" + ex.Message, "Borrar Registro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    btBorrar.PerformClick(); return;
                }
            }
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            LimprarCampos();
            btPrimero.PerformClick();
        }
        private void btPrimero_Click(object sender, EventArgs e)
        {
            List<CTelefonos> listaTelefonos;
            try
            {
                dataAcces = new CTelefonosDataAccess();
                listaTelefonos = dataAcces.ListaDeTelefonos();

                if (listaTelefonos == null || listaTelefonos.Count <= 0)
                {
                    MessageBox.Show("No hay registros!", "Lista telefonica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lbNregistros.Text = "0/0";
                    lbId.Text = string.Empty;
                    tbNombre.Focus();
                    return;
                }
                else
                {
                    lbId.Text = listaTelefonos[0]._IdTelefono.ToString();
                    tbDireccion.Text = listaTelefonos[0]._Direccion;
                    tbNombre.Text = listaTelefonos[0]._Nombre;
                    tbNota.Text = listaTelefonos[0]._Nota;
                    tbTelefono.Text = listaTelefonos[0]._Telefono;
                    lbFechaCreado.Text = listaTelefonos[0]._FechaCreacion.ToString("dd, MMM yyyy hh:mm");
                    habilitarCampos(true);
                }

                ActualizarContador();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en lectura de base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btUltimo_Click(object sender, EventArgs e)
        {
            List<CTelefonos> listaTelefonos;
            try
            {
                dataAcces = new CTelefonosDataAccess();
                listaTelefonos = dataAcces.ListaDeTelefonos();

                if (listaTelefonos == null || listaTelefonos.Count <= 0)
                {
                    MessageBox.Show("No hay registros!", "Lista telefonica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lbNregistros.Text = "0/0";
                    lbId.Text = string.Empty;
                    tbNombre.Focus();
                    return;
                }
                else
                {
                    lbId.Text = listaTelefonos[listaTelefonos.Count - 1]._IdTelefono.ToString();
                    tbDireccion.Text = listaTelefonos[listaTelefonos.Count - 1]._Direccion;
                    tbNombre.Text = listaTelefonos[listaTelefonos.Count - 1]._Nombre;
                    tbNota.Text = listaTelefonos[listaTelefonos.Count - 1]._Nota;
                    tbTelefono.Text = listaTelefonos[listaTelefonos.Count - 1]._Telefono;
                    lbFechaCreado.Text = listaTelefonos[listaTelefonos.Count - 1]._FechaCreacion.ToString("dd, MMM yyyy hh:mm");

                    habilitarCampos(true);
                }
                ActualizarContador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en lectura de base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btAnterior_Click(object sender, EventArgs e)
        {
            List<CTelefonos> listaTelefonos;
            try
            {
                dataAcces = new CTelefonosDataAccess();
                listaTelefonos = dataAcces.ListaDeTelefonos();
                Guid registroId = new Guid(lbId.Text);


                if (listaTelefonos == null || listaTelefonos.Count <= 0)
                {
                    MessageBox.Show("No hay registros!", "Lista telefonica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lbNregistros.Text = "";
                    lbId.Text = string.Empty;
                    return;
                }
                else
                {
                    int indice = listaTelefonos.IndexOf(listaTelefonos.Where(x => x._IdTelefono == registroId).FirstOrDefault());
                    if (indice > 0)
                    {
                        lbId.Text = listaTelefonos[indice - 1]._IdTelefono.ToString();
                        tbDireccion.Text = listaTelefonos[indice - 1]._Direccion;
                        tbNombre.Text = listaTelefonos[indice - 1]._Nombre;
                        tbNota.Text = listaTelefonos[indice - 1]._Nota;
                        tbTelefono.Text = listaTelefonos[indice - 1]._Telefono;
                        lbFechaCreado.Text = listaTelefonos[indice - 1]._FechaCreacion.ToString("dd, MMM yyyy hh:mm");
                    }
                    else
                    {
                        MessageBox.Show("Este es el primer registro!", "Lista telefonica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ActualizarContador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en lectura de base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btSiguiente_Click(object sender, EventArgs e)
        {
            List<CTelefonos> listaTelefonos;
            try
            {
                dataAcces = new CTelefonosDataAccess();
                listaTelefonos = dataAcces.ListaDeTelefonos();
                Guid registroId = new Guid(lbId.Text);


                if (listaTelefonos == null || listaTelefonos.Count <= 0)
                {
                    MessageBox.Show("No hay registros!", "Lista telefonica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lbNregistros.Text = "";
                    lbId.Text = string.Empty;
                    return;
                }
                else
                {
                    int indice = listaTelefonos.IndexOf(listaTelefonos.Where(x => x._IdTelefono == registroId).FirstOrDefault());
                    if (indice < listaTelefonos.Count - 1)
                    {
                        lbId.Text = listaTelefonos[indice + 1]._IdTelefono.ToString();
                        tbDireccion.Text = listaTelefonos[indice + 1]._Direccion;
                        tbNombre.Text = listaTelefonos[indice + 1]._Nombre;
                        tbNota.Text = listaTelefonos[indice + 1]._Nota;
                        tbTelefono.Text = listaTelefonos[indice + 1]._Telefono;
                        lbFechaCreado.Text = listaTelefonos[indice + 1]._FechaCreacion.ToString("dd, MMM yyyy hh:mm");
                    }
                    else
                    {
                        MessageBox.Show("Este es el ultimo registro!", "Lista telefonica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ActualizarContador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en lectura de base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBuscar.Text.Trim()))
            {
                MessageBox.Show("Introduzca un nombre valido a buscar", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBuscar.Focus();
                return;
            }
            List<CTelefonos> listaTelefonos;

            try
            {
                dataAcces = new CTelefonosDataAccess();
                listaTelefonos = dataAcces.ListaDeTelefonos(tbBuscar.Text);

                if (listaTelefonos == null || listaTelefonos.Count <= 0)
                {
                    MessageBox.Show("No hay registros con este nombre!", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //  lbNregistros.Text = "";
                    //  lbId.Text = string.Empty;
                    return;
                }
                else
                {
                    bool encontrado = false;
                    for (int i = 0; i <= listaTelefonos.Count - 1; i++)
                    {
                        if (MessageBox.Show("Es <" + listaTelefonos[i]._Nombre + "> el registro que esta buscando?", "Busqueda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            lbId.Text = listaTelefonos[i]._IdTelefono.ToString();
                            tbDireccion.Text = listaTelefonos[i]._Direccion;
                            tbNombre.Text = listaTelefonos[i]._Nombre;
                            tbNota.Text = listaTelefonos[i]._Nota;
                            tbTelefono.Text = listaTelefonos[i]._Telefono;
                            lbFechaCreado.Text = listaTelefonos[i]._FechaCreacion.ToString("dd, MMM yyyy hh:mm");
                            encontrado = true;
                            habilitarCampos(true);
                            ActualizarContador();
                            tbBuscar.Text = "";
                            tbNombre.Focus();
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        MessageBox.Show("El  registro no ha sido encontrado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbBuscar.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en lectura de base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #region Metodos auxiliares

        /// <summary>
        /// Lee los datos del formulario y crea un objeto 
        /// para ser guardado en la DB
        /// </summary>
        /// <returns></returns>
        private CTelefonos returnObjectCtelefono()
        {
            CTelefonos cTelefonos = new CTelefonos();

            cTelefonos._IdTelefono = (string.IsNullOrEmpty(lbId.Text) ? Guid.Empty : new Guid(lbId.Text));

            cTelefonos._Direccion = tbDireccion.Text;
            cTelefonos._Nombre = tbNombre.Text;
            cTelefonos._Nota = tbNota.Text;
            cTelefonos._Telefono = tbTelefono.Text;

            return cTelefonos;
        }

        /// <summary>
        /// Verifica que los campos requeridos 
        /// del objeto esten completos
        /// </summary>
        /// <param name="cTelefonos"></param>
        /// <returns></returns>
        private bool validarCampos(CTelefonos cTelefonos)
        {
            bool valido = false;
            string mensaje = "Por favor revise los campos antes de continuar";

            valido = string.IsNullOrEmpty(cTelefonos._Direccion.Trim());
            valido = string.IsNullOrEmpty(cTelefonos._Nombre.Trim());
            valido = string.IsNullOrEmpty(cTelefonos._Telefono.Trim());
            valido = (!tbTelefono.MaskFull);

            if (valido)
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return !valido;
        }

        /// <summary>
        /// Actualiza el label que muestra el total y la ubicacion 
        /// de la navegacion de la app
        /// </summary>
        private void ActualizarContador()
        {
            List<CTelefonos> listaTelefonos;
            Guid registroId = new Guid(lbId.Text);
            try
            {
                dataAcces = new CTelefonosDataAccess();
                listaTelefonos = dataAcces.ListaDeTelefonos();

                if (listaTelefonos != null && listaTelefonos.Count > 0)
                {
                    int indice = listaTelefonos.IndexOf(listaTelefonos.Where(x => x._IdTelefono == registroId).FirstOrDefault()) + 1;
                    lbNregistros.Text = indice + "/" + listaTelefonos.Count;
                }
                else
                {
                    lbNregistros.Text = "0/0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en lectura de base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lbNregistros.Text = "Error :(";
            }

        }

        /// <summary>
        /// controla la habilitacion y la vision 
        /// de elementos del formulario que se estan utilizando la app
        /// </summary>
        /// <param name="habilitar"></param>
        private void habilitarCampos(bool habilitar)
        {
            btBorrar.Enabled = habilitar;
            btBuscar.Enabled = habilitar;
            tbBuscar.Enabled = habilitar;
            btPrimero.Enabled = habilitar;
            btSiguiente.Enabled = habilitar;
            btUltimo.Enabled = habilitar;
            btAnterior.Enabled = habilitar;
            btNuevo.Enabled = habilitar;
            btCancelar.Visible = !habilitar;
            btBorrar.Visible = habilitar;
        }

        /// <summary>
        /// Limpia los textbox del formulario
        /// </summary>
        private void LimprarCampos()
        {
            tbBuscar.Clear();
            tbDireccion.Clear();
            tbNombre.Clear();
            tbNota.Clear();
            tbTelefono.Clear();
            lbId.Text = "";
            lbFechaCreado.Text = "";
        }

        /// <summary>
        /// Muestra u oculta un pictureBox con una imagen de carga
        /// mintras la app esta procesando la informacion
        /// </summary>
        /// <param name="mostrar"></param>
        private void MostrarImagenCarga( bool mostrar)
        {
            pbLoader.Visible = mostrar;
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            btPrimero.PerformClick();
        }
    }
}
