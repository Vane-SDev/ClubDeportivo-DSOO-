using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClubDeportivo.Datos
{
    internal class Persona
    {
        public string Nuevo_Registro(E_Persona personas)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Nuevo_Registro",sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nom", MySqlDbType.VarChar).Value = personas.nombre;
                comando.Parameters.Add("ape", MySqlDbType.VarChar).Value = personas.apellido;
                comando.Parameters.Add("tipo", MySqlDbType.VarChar).Value = personas.tipodoc;
                comando.Parameters.Add("doc", MySqlDbType.Int32).Value = personas.nrodoc;
                comando.Parameters.Add("apto", MySqlDbType.Int32).Value = personas.aptofisico;
                comando.Parameters.Add("cond", MySqlDbType.Int32).Value = personas.condicion;
                //comando.Parameters.Add("apto", MySqlDbType.BOO)
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "res";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }// como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;
        }
    }
}

      
   
