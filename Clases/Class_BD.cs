using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Clases
{
    public class Class_BD
    {
        private string str_conexion;
        int x = 0;
        SqlConnection Conexion;
        public DataTable ds { get; } = new DataTable();

        //public void CrearStringConexionInicial(string NombreInstancia,string nombreBD)
        //{
        //    DataSource = NombreInstancia;
        //    //DataSource = "DESKTOP-7G4BD9C";
        //    IntegratedSecurity = "SSPI";
        //    if(nombreBD.Length != 0)
        //    {
        //        str_conexion = "Data Source =" + DataSource
        //        + "; Initial Catalog =" + nombreBD
        //        + "; Integrated Security=" + IntegratedSecurity;
        //    }
        //    else
        //    {
        //        str_conexion = "Data Source =" + DataSource
        //         + "; Initial Catalog =" + "Master"
        //         + "; Integrated Security=" + IntegratedSecurity;
        //    }

        //}

        public void Crear_StringConexion(string NombreInstancia, string NombreUsuario, string Contrasena, string nombre_BD, int tipoConexion)
        {
            if (tipoConexion == 1)//Si el tipo de conexion es igual a 1, entonces el string de conexion es de windows Authentication
            {
                if (nombre_BD.Length != 0)
                {
                    str_conexion = "Data Source =" + NombreInstancia
                    + "; Initial Catalog =" + nombre_BD
                    + "; Integrated Security=" + "SSPI";
                }
                else
                {
                    str_conexion = "Data Source =" + NombreInstancia
                    + "; Initial Catalog =" + "Master"
                    + "; Integrated Security=" + "SSPI";
                }

            }
            else//Si el tipo de conexion es igual a 1, entonces el string de conexion es de SQL Server Authentication
            {
                if (nombre_BD.Length != 0)
                {
                    str_conexion = "Data Source =" + NombreInstancia
                    + "; Initial Catalog =" + nombre_BD
                    + "; User ID=" + NombreUsuario +
                    "; Password=" + Contrasena;
                }
                else
                {
                    str_conexion = "Data Source =" + NombreInstancia
                    + "; Initial Catalog =" + "Master"
                    + "; User ID=" + NombreUsuario +
                    "; Password=" + Contrasena;
                }
            }
        }
        //public void CrearStringSQLAuthentication(string NombreInstancia, string NombreUsuario, string Contrasena)
        //{
        //    DataSource = NombreInstancia;
        //    //DataSource = "DESKTOP-7G4BD9C";
        //    InitialCatalog = "Master";
        //    IntegratedSecurity = "SSPI";
        //    Id_User = NombreUsuario;
        //    Password = Contrasena;

        //}
        public void AbrirConexion()
        {
            try
            {
                Conexion = new SqlConnection(str_conexion);
                Conexion.Open();
                //Conexion.
            } catch (Exception ex)
            {
                throw new Exception("No ha sido posible lograr la conexión con los datos indicados, por favor intente de nuevo.");
            }

        }
        public void CerrarConexion()
        {
            try
            {
                Conexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }
        public void ConsultarBases(string NombreInstancia, int tipoconexion, string nombreusuario = "", string contrasena = "")
        {
            try
            {
                Crear_StringConexion(NombreInstancia, nombreusuario, contrasena, "", tipoconexion);
                if (ds.Rows.Count > 0)
                {
                    ds.Clear();
                }
                AbrirConexion();
                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases where database_id >= 5 and database_id <> 12", Conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                CerrarConexion();
            }
        }
        public int EjecutarScript(string NombreInstancia, int tipoconexion, string nombre, string Comando, string nombreusuario = "", string contrasena = "")
        {
            try
            {
                Crear_StringConexion(NombreInstancia, nombreusuario, contrasena, nombre, tipoconexion);
                AbrirConexion();
                //Conexion.ChangeDatabase(nombre);
                SqlCommand cmd = new SqlCommand(Comando, Conexion);
                x++;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Base de datos : " + Environment.NewLine + "Excepcion al ejecutar una instruccion o un proceso por lotes Transact-SQL." + nombre);
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
