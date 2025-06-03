using System.Data;
using capa_datos;
using capaNegocios;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                // ----------- VALIDACI�N DEL MONTO ----------- 
                // Se verifica que el valor ingresado en textmonto sea un n�mero v�lido.
                // En caso de error, se muestra un mensaje y se detiene el proceso.
                if (!decimal.TryParse(textmonto.Text, out decimal monto))
                {
                    MessageBox.Show("El monto ingresado no es v�lido. Por favor, ingresa un n�mero.");
                    return; // Se detiene la ejecuci�n del m�todo si hay error.
                }

                // ----------- VALIDACI�N DE LA FECHA ----------- 
                // Se verifica que el valor ingresado en textfecha sea una fecha v�lida.
                // Si el usuario ingresa un formato incorrecto, se muestra un mensaje de error.
                if (!DateTime.TryParse(textfecha.Text, out DateTime fecha))
                {
                    MessageBox.Show("La fecha ingresada no es v�lida. Usa un formato correcto (dd/mm/aaaa).");
                    return;
                }

                // ----------- VALIDACI�N DEL TIPO DE TRANSACCI�N ----------- 
                // Se verifica que el usuario haya seleccionado un tipo (Ingreso o Gasto).
                // Si no se ha seleccionado ninguna opci�n, se muestra un mensaje de advertencia.
                if (cmbtipo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona un tipo de transacci�n (Ingreso o Gasto).");
                    return;
                }

                string motivo = textmotivo.Text; // Se obtiene el motivo ingresado por el usuario.
                string tipo = cmbtipo.SelectedItem.ToString(); // Se obtiene el tipo de transacci�n seleccionado.

                Transaccion transaccion; // Se declara la variable para almacenar la instancia de la transacci�n.

                // ----------- CREACI�N DE LA INSTANCIA DE TRANSACCI�N ----------- 
                // Se crea una instancia de la clase adecuada seg�n el tipo de transacci�n seleccionado.
                // Si es un "Ingreso", se instancia la clase Ingreso.
                // Si es un "Gasto", se instancia la clase Gasto.
                transaccion = tipo == "Ingreso"
                    ? new Ingreso { Monto = monto, Motivo = motivo, Fecha = fecha }
                    : new Gasto { Monto = monto, Motivo = motivo, Fecha = fecha };

                // ----------- OBTENCI�N Y VALIDACI�N DEL SALDO ACTUAL ----------- 
                // Se obtiene el saldo actual de la cuenta llamando al m�todo ObtenerSaldoActual().
                decimal saldoActual = ObtenerSaldoActual();

                // Se verifica si el saldo es suficiente para realizar la transacci�n.
                if (transaccion.ValidarSaldo(saldoActual))
                {
                    // ----------- REGISTRO DE LA TRANSACCI�N ----------- 
                    // Si el saldo es suficiente, se inserta la transacci�n en la base de datos.
                    TransaccionDatos datos = new TransaccionDatos();
                    datos.InsertarTransaccion(transaccion);

                    // Se muestra un mensaje de confirmaci�n al usuario.
                    MessageBox.Show("Transacci�n registrada exitosamente.");
                }
                else
                {
                    // Si el saldo es insuficiente, se muestra un mensaje de advertencia.
                    MessageBox.Show("Saldo insuficiente para registrar la transacci�n.");
                }
            }
            catch (Exception ex)
            {
                // ----------- MANEJO DE ERRORES ----------- 
                // Se captura cualquier excepci�n que ocurra durante la ejecuci�n del c�digo.
                // Se muestra un mensaje de error detallando la causa del fallo.
                MessageBox.Show("Error al registrar la transacci�n: " + ex.Message);
            }
            Rellenar();
        }

        // ----------- M�TODO PARA OBTENER EL SALDO ACTUAL ----------- 
        // Este m�todo deber�a consultar la base de datos para obtener el saldo real.
        private decimal ObtenerSaldoActual()
        {
            // Simulaci�n de saldo actual (deber�a implementarse consulta a la base de datos).
            return 1000m; // Valor de ejemplo.
        }

        private void conexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(new conexionDatos().Conexion))
                {
                    conn.Open(); // Abre la conexi�n
                    MessageBox.Show("Conectado a la base de datos: " + conn.Database);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexi�n: " + ex.Message);
            }
        }
        public void Rellenar()
        {
            string consulta = "SELECT * FROM transaccion";

            using (SqlConnection Conexion = new SqlConnection("Server=.;Database=Billetera4;Integrated Security=true;TrustServerCertificate=True"))
            {
                Conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, Conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }


        }

           
        private void Form1_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM transaccion";

            using (SqlConnection Conexion = new SqlConnection("Server=.;Database=Billetera4;Integrated Security=true;TrustServerCertificate=True"))
            {
                Conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, Conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }

}
