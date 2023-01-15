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
        SqlConnection Conexion;
        public DataTable ds { get; } = new DataTable();

        public void CrearStringConexionInicial()
        {
            DataSource = "DESKTOP-7G4BD9C";
            InitialCatalog = "Master";
            IntegratedSecurity = "SSPI";
            str_conexion = "Data Source =" + DataSource
                + "; Initial Catalog =" + InitialCatalog
                + "; Integrated Security=" + IntegratedSecurity;
        }
        public string AbrirConexion()
        {
            try
            {
                Conexion = new SqlConnection(str_conexion);
                Conexion.Open();
                return Conexion.State.ToString();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            
        }
        public string CerrarConexion()
        {
            try
            {
                Conexion.Close();
                return Conexion.State.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            
        }
        public void ConsultarBases()
        {
            try
            {
                
                CrearStringConexionInicial();
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
