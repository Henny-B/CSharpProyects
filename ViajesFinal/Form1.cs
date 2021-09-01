using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ViajesFinal
{
    public partial class Form1 : Form
    {
        Viaje[] aViaje = new Viaje[300];
        int contador;
        bool nuevo = false;


        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AGENCIAVIAJES;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            habilitar(false);
            CargarCombo(cboTransporte, "Transportes", "nombreTransporte", "idTransporte");
            cboTransporte.SelectedIndex = -1;
            CargarLista(lstViajes, "Viajes");
            btnNuevo.Focus();


        }

        private void habilitar(bool x)
        {

            txtCodigo.Enabled = x;
            txtDestino.Enabled = x;
            cboTransporte.Enabled = x;            
            rbtInternacional.Enabled = x;
            rbtNacional.Enabled = x;
            dtpFecha.Enabled = x;
            btnNuevo.Enabled = !x;
            btnGrabar.Enabled = !x;
            btnEditar.Enabled = !x;
            btnCancelar.Enabled = !x;            
            btnSalir.Enabled = !x;


        }


        private void limpiar()
        {
            txtCodigo.Text = "";
            txtDestino.Text = "";
            cboTransporte.SelectedIndex = -1;
            rbtInternacional.Checked = false;
            rbtNacional.Checked = false;
            txtCodigo.Focus();

        }


        private void CargarCombo(ComboBox combo, string nombTabla, string displayMember, string valueMember)
        {
            DataTable tabla = ConsultarTabla(nombTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private DataTable ConsultarTabla(string nombreTabla)
        {
            cnn.Open();

            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + nombreTabla;

            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());

            cnn.Close();

            return tabla;

        }


        private void CargarLista(ListBox lista, string nombTabla)
        {
            contador = 0;

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + nombTabla;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Viaje v = new Viaje();
                if (!reader.IsDBNull(0))
                    v.pCodigo = reader.GetInt32(0);
                if (!reader.IsDBNull(1))
                    v.pDestino = reader.GetString(1);
                if (!reader.IsDBNull(2))
                    v.pTransporte = reader.GetInt32(2);
                if (!reader.IsDBNull(3))
                    v.pTipo = reader.GetInt32(3);                    
                if (!reader.IsDBNull(4))
                    v.pFecha = reader.GetDateTime(4);

                aViaje[contador] = v;
                contador++;

            }

            reader.Close();
            cnn.Close();
            lista.Items.Clear();

            for (int i = 0; i < contador; i++)
            {
                lista.Items.Add(aViaje[i].ToString());

            }
            lista.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            habilitar(true);
            limpiar();
            btnGrabar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = true;
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtCodigo.Enabled = false;
            txtDestino.Focus();
            btnCancelar.Enabled = true;
            btnGrabar.Enabled = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {


            Viaje v = new Viaje();
            v.pCodigo = Convert.ToInt32(txtCodigo.Text);
            v.pDestino = txtDestino.Text;
            v.pTransporte = Convert.ToInt32(cboTransporte.SelectedValue);
            if (rbtNacional.Checked)
                v.pTipo = 1;
            else
                v.pTipo = 2;
            v.pFecha = dtpFecha.Value;

            if (nuevo)
            {
                try
                {
                    if (txtCodigo.Text == "" || txtDestino.Text == "")
                    {
                        MessageBox.Show("Olvidó ingresar un campo!");
                        return;
                    }
                    if (cboTransporte.SelectedIndex < 0)
                    {
                        MessageBox.Show("Olvidó seleccionar una marca!");
                        return;
                    }

                    try
                    {
                        int codigo = Convert.ToInt32(txtCodigo.Text);


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El código debe ser numérico!");
                        return;
                    }

                    cnn.Open();
                    cmd = new SqlCommand("INSERT INTO Viajes VALUES (@codigo, @destino, @transporte, @tipo, @fecha)", cnn);
                    cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@destino", txtDestino.Text);
                    cmd.Parameters.AddWithValue("@transporte", cboTransporte.SelectedValue);
                    cmd.Parameters.AddWithValue("@tipo", v.pTipo);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                    cmd.ExecuteNonQuery();
                    cnn.Close();


                    
                    CargarLista(lstViajes, "Viajes");
                    habilitar(false);

                    MessageBox.Show("Viaje guardado!");
                    limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el viaje");
                    MessageBox.Show(ex.Message);
                }

                btnNuevo.Focus();
            } else
            {

                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Viajes SET codigo=@codigo," +
                                                       " destino=@destino," +
                                                       " transporte=@transporte," +
                                                       " tipo=@tipo," +
                                                       " fecha=@fecha" +                                                       
                                                       " WHERE codigo=@codigo";
                cmd.Parameters.AddWithValue("@codigo", v.pCodigo);
                cmd.Parameters.AddWithValue("@destino",v.pDestino);
                cmd.Parameters.AddWithValue("@transporte",v.pTransporte);
                cmd.Parameters.AddWithValue("@tipo", v.pTipo);
                cmd.Parameters.AddWithValue("@fecha", v.pFecha);


                cmd.ExecuteNonQuery();
                cnn.Close();



            }

                CargarLista(lstViajes, "Viajes");
                habilitar(false);
                nuevo = false;

        }

        private void cargarCampos(int posicion)
        {
            txtCodigo.Text = aViaje[posicion].pCodigo.ToString();
            txtDestino.Text = aViaje[posicion].pDestino;
            cboTransporte.SelectedValue = aViaje[posicion].pTransporte;
            if (aViaje[posicion].pTipo == 1)
                rbtNacional.Checked = true;
            else
                rbtInternacional.Checked = true;
            dtpFecha.Value = aViaje[posicion].pFecha;


        }


        private void lstViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarCampos(lstViajes.SelectedIndex);
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(false);
            nuevo = false;
            btnNuevo.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
                    "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

      
    }
}
