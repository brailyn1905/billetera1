using System;
using System.Transactions;
using capa_datos;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace capaNegocios
{
    public  class Transaccion
    {
        public int Id{  get; set; }
        public decimal Monto{  get; set; }
        public DateTime Fecha {  get; set; }
        public string Motivo {  get; set; }
        public virtual string Tipo { get; }

        //metodo para validar saldo
        public virtual bool ValidarSaldo(decimal saldoActual)
        {
            return saldoActual >= Monto;
        }
        //metodo para registrar la operacion 
        public void RegistrarOperacion()
        {
            Console.WriteLine($"transacción registrada: {Monto} - {Motivo} - {Fecha.ToShortDateString()}");
        }


    } 
    //primera clase derivada ingreso
    public class Ingreso : Transaccion
    {
        public override string Tipo => "Ingreso";
        
      //
        public override bool ValidarSaldo(decimal saldoActual)
        {
            return true; // Siempre válido porque es un ingreso
        }

        


    }
    //segunda clase deribada gasto
    public class Gasto : Transaccion
    {
        public override string Tipo => "gasto";

        //le agregamos una condicion para ver si el saldo de los ingresos es sificiente 
        public override bool ValidarSaldo(decimal saldoActual)
        {
            if (saldoActual < Monto)
            {
                Console.WriteLine("Saldo insuficiente. No se puede registrar el gasto.");
                return false;
            }
            
            return true; // Solo válido si hay suficiente saldo
        }

        public void RegistrarOperacion(decimal saldoActual)
        {
            if (ValidarSaldo(saldoActual))
            {
                Console.WriteLine($"Gasto registrado: {Monto} - {Motivo} - {Fecha.ToShortDateString()}");
            }
        }
    }


    public class TransaccionDatos
    {
        
        public void InsertarTransaccion(Transaccion transaccion)
        {
            using (SqlConnection conn = new SqlConnection( new conexionDatos().Conexion))
            {
                string query = "INSERT INTO transaccion (Monto, Fecha, Motivo, Tipo) VALUES (@Monto, @Fecha, @Motivo, @Tipo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Monto", transaccion.Monto);
                cmd.Parameters.AddWithValue("@Fecha", transaccion.Fecha);
                cmd.Parameters.AddWithValue("@Motivo", transaccion.Motivo);
                cmd.Parameters.AddWithValue("@Tipo", transaccion is Ingreso ? "Ingreso" : "Gasto");

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }   }
