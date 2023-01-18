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
        private string DataSource;
        private string InitialCatalog;
        private string IntegratedSecurity;
        private string str_conexion;
        private string Id_User;
        private string Password;
        SqlConnection Conexion;
        public DataTable ds { get; } = new DataTable();

        public void CrearStringConexionInicial(string NombreInstancia)
        {
            DataSource = NombreInstancia;
            //DataSource = "DESKTOP-7G4BD9C";
            InitialCatalog = "Master";
            IntegratedSecurity = "SSPI";
            str_conexion = "Data Source =" + DataSource
                + "; Initial Catalog =" + InitialCatalog
                + "; Integrated Security=" + IntegratedSecurity;
        }
        public void CrearStringSQLAuthentication(string NombreInstancia, string NombreUsuario, string Contrasena)
        {
            DataSource = NombreInstancia;
            //DataSource = "DESKTOP-7G4BD9C";
            InitialCatalog = "Master";
            IntegratedSecurity = "SSPI";
            Id_User = NombreUsuario;
            Password = Contrasena;
            str_conexion = "Data Source =" + DataSource
                + "; Initial Catalog =" + InitialCatalog
                + "; User ID=" + Id_User +
                "; Password=" + Password;
        }
        public void AbrirConexion()
        {
            try
            {
                Conexion = new SqlConnection(str_conexion);
                Conexion.Open();
                //Conexion.
            }catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
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
                if (tipoconexion == 1)
                {
                    CrearStringConexionInicial(NombreInstancia);
                }
                else {
                    CrearStringSQLAuthentication(NombreInstancia,nombreusuario,contrasena);
                }
                if(ds.Rows.Count > 0)
                {
                    ds.Clear();
                }
                AbrirConexion();
                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases where database_id >= 5",Conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                //SqlDataReader dr = cmd.ExecuteReader();
                //if (dr.Read())
                //{
                //    string lista = "";
                //    for (int x = 0; x < dr.FieldCount; x++)
                //    {
                //        lista += dr[x] + "\n";
                //    }
                //    return dr["name"].ToString();
                //}
                //else
                //{
                //    return "No funciono";
                //}
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
      
    }
}
