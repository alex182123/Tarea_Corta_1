using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
namespace Tarea_Corta_1
{
    public partial class Form1 : Form
    {
        int tipoConexion;
        string nombreInstancia;
        string nombreUsuario;
        string contrasenaSQL;
        string [] palabras_reservadas_sql = new string[] {"where","into","insert","from","select","values","delete","update","alter"};
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opf_Menu_Script.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Desactivar opciones de edicion de comandos sql
            cbl_BD.Enabled = false;
            btn_desconectar.Enabled = false;
            btn_desconectarSQL.Enabled = false;
            l_lblSelectNinguna.Enabled = false;
            l_lbl_SelectTodas.Enabled = false;
            rtxt_CompiladorScript.Enabled = false;
            btn_ejecutar_comando.Enabled = false;
            btn_limpiar_comando.Enabled = false;
        }

        private void btn_Conectar_BD_Click(object sender, EventArgs e)
        {
            Class_BD obj_Conexion = new Class_BD();
            //Validacion para que el usuario deba ingresar los datos necesarios
            if (string.IsNullOrEmpty(txt_NombreInstancia.Text))
            {
                MessageBox.Show(null,"Ingrese un nombre de instacia sql server valido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    tipoConexion = 1;
                    nombreInstancia = txt_NombreInstancia.Text;
                    obj_Conexion.ConsultarBases(nombreInstancia,tipoConexion);//Uso de metodo para consultar las base de datos de la instancia conectada
                    //Carga de los nombres de las bases de datos de la instancia al checkboxlist 
                    ((ListBox)cbl_BD).DataSource = obj_Conexion.ds;
                    ((ListBox)cbl_BD).DisplayMember = "name";
                    ((ListBox)cbl_BD).ValueMember = "name";
                    //Desactivar opciones de SQL server authentication
                    btn_ConectarSQL.Enabled = false;
                    btn_desconectarSQL.Enabled = false;
                    txt_ContraseñaSQL.Enabled = false;
                    txt_NombreInstaciaSQL.Enabled = false;
                    txt_NombreUsuarioSQL.Enabled = false;
                    //Activar opciones Windows Authentication
                    btn_desconectar.Enabled = true;
                    cbl_BD.Enabled = true;
                    l_lblSelectNinguna.Enabled = true;
                    l_lbl_SelectTodas.Enabled = true;
                    rtxt_CompiladorScript.Enabled = true;
                    btn_ejecutar_comando.Enabled = true;
                    btn_limpiar_comando.Enabled = true;
                    //Desactivar opciones Windows Authentication
                    btn_Conectar_BD.Enabled = false;
                    txt_NombreInstancia.Enabled = false;
                    //Otros
                    MessageBox.Show(null, "Conexion establecida", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_resultado_script_bd.Text = "";
                    txt_resultado_script_bd.Text = "Conexion establecida por medio de Windows Autentication" + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                //MessageBox.Show(obj_Conexion.ConsultarBases());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Desactivar opciones de Windows Authentication
            btn_desconectar.Enabled = false;
            //Desactivar opciones de SQL Server Authentication
            l_lblSelectNinguna.Enabled = false;
            l_lbl_SelectTodas.Enabled = false;
            btn_desconectarSQL.Enabled = false;
            btn_ejecutar_comando.Enabled = false;
            btn_limpiar_comando.Enabled = false;
            rtxt_CompiladorScript.Enabled = false;
            //Activar opciones de SQL Server Authentication
            btn_ConectarSQL.Enabled = true;
            txt_NombreInstaciaSQL.Enabled = true;
            txt_NombreUsuarioSQL.Enabled = true;
            txt_ContraseñaSQL.Enabled = true;
            //Activar opciones de Windows Authentication
            txt_NombreInstancia.Enabled = true;
            btn_Conectar_BD.Enabled = true;
            //Otros
            tipoConexion = 0;
            nombreInstancia = "";
            ((ListBox)cbl_BD).DataSource = null; //Para limpiar el listcheckbox de las bd
            txt_resultado_script_bd.Text = ""; //Para limpiar el textbox de resultados
            txt_resultado_script_bd.Text = "Esperando conexion..."; //Cambio de mensaje para indicar que no se encuentra conectado a una instancia SQL
        }

        //Funcion para seleccionar todas las bases de datos listadas en el checkboxlist
        private void l_lbl_SelectTodas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for(int i=0;i<cbl_BD.Items.Count;i++) 
            {
                cbl_BD.SetItemChecked(i, true);
            }
        }

        //Funcion para deseleccionar todas las bases de datos listadas en el checkboxlist
        private void l_lblSelectNinguna_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < cbl_BD.Items.Count; i++)
            {
                cbl_BD.SetItemChecked(i, false);
            }
        }

        private void btn_ConectarSQL_Click(object sender, EventArgs e)
        {
            Class_BD obj_Conexion = new Class_BD();
            //Validacion para que el usuario deba ingresar los datos necesarios
            if (string.IsNullOrEmpty(txt_NombreInstaciaSQL.Text) || string.IsNullOrEmpty(txt_NombreUsuarioSQL.Text) || string.IsNullOrEmpty(txt_ContraseñaSQL.Text))
            {
                MessageBox.Show(null,"Debe ingresar los datos necesarios para poder conectarse a la instancia SQL","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    nombreInstancia = txt_NombreInstaciaSQL.Text;
                    nombreUsuario = txt_NombreUsuarioSQL.Text;
                    contrasenaSQL = txt_ContraseñaSQL.Text;
                    tipoConexion = 2;
                    obj_Conexion.ConsultarBases(nombreInstancia,tipoConexion,nombreUsuario,contrasenaSQL);//Uso de metodo para consultar las base de datos de la instancia conectada
                    //Carga de los nombres de las bases de datos de la instancia al checkboxlist 
                    ((ListBox)cbl_BD).DataSource = obj_Conexion.ds;
                    ((ListBox)cbl_BD).DisplayMember = "name";
                    ((ListBox)cbl_BD).ValueMember = "name";
                    //Activar opciones de SQL server authentication
                    btn_desconectarSQL.Enabled = true;
                    cbl_BD.Enabled = true;
                    l_lblSelectNinguna.Enabled = true;
                    l_lbl_SelectTodas.Enabled = true;
                    rtxt_CompiladorScript.Enabled = true;
                    btn_ejecutar_comando.Enabled = true;
                    btn_limpiar_comando.Enabled = true;
                    //Desactivar opciones de SQL server authentication
                    btn_ConectarSQL.Enabled = false;
                    txt_ContraseñaSQL.Enabled = false;
                    txt_NombreUsuarioSQL.Enabled = false;
                    txt_NombreInstaciaSQL.Enabled = false;
                    //Desactivar opciones de Windows Autenthication
                    txt_NombreInstancia.Enabled = false;
                    btn_Conectar_BD.Enabled = false;
                    btn_desconectar.Enabled = false;
                    //Otros
                    MessageBox.Show(null, "Conexion establecida", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_resultado_script_bd.Text = "";
                    txt_resultado_script_bd.Text = "Conexion establecida por medio de SQL Server Authentication" + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_desconectarSQL_Click(object sender, EventArgs e)
        {
            //Desactivar opciones de Windows Authentication
            
            //Desactivar opciones de SQL Server Authentication
            l_lblSelectNinguna.Enabled = false;
            l_lbl_SelectTodas.Enabled = false;
            btn_desconectarSQL.Enabled = false;
            btn_ejecutar_comando.Enabled = false;
            btn_limpiar_comando.Enabled = false;
            rtxt_CompiladorScript.Enabled = false;
            //Activar opciones de SQL Server Authentication
            btn_ConectarSQL.Enabled = true;
            txt_NombreInstaciaSQL.Enabled = true;
            txt_NombreUsuarioSQL.Enabled = true;
            txt_ContraseñaSQL.Enabled = true;
            //Activar opciones de Windows Authentication
            txt_NombreInstancia.Enabled = true;
            btn_Conectar_BD.Enabled = true;
            //Otros
            tipoConexion = 0;
            nombreInstancia = "";
            nombreUsuario = "";
            contrasenaSQL = "";
            ((ListBox)cbl_BD).DataSource = null; //Para limpiar el listcheckbox de las bd
            txt_resultado_script_bd.Text = ""; //Para limpiar el textbox de resultados
            txt_resultado_script_bd.Text = "Esperando conexion..."; //Cambio de mensaje para indicar que no se encuentra conectado a una instancia SQL
            
        }

        private void btn_ejecutar_comando_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxt_CompiladorScript.Text) != true)
            {
                if (cbl_BD.CheckedItems.Count != 0)
                {
                    Class_BD obj_Conexion = new Class_BD();
                    string[] Lista_seleccionadas_DB = new string[cbl_BD.CheckedItems.Count];
                    int x = 0;
                    int filasafectadas;
                    foreach (DataRowView Vista in cbl_BD.CheckedItems)
                    {
                        Lista_seleccionadas_DB[x] = Vista.Row[0].ToString();
                        x++;
                    }
                    for (int i = 0; i < cbl_BD.CheckedItems.Count; i++)
                    {
                        try
                        {
                            filasafectadas = 0;
                            filasafectadas = obj_Conexion.EjecutarScript(nombreInstancia, tipoConexion, Lista_seleccionadas_DB[i], rtxt_CompiladorScript.Text, nombreUsuario, contrasenaSQL);
                            txt_resultado_script_bd.Text += "Base de datos : " + Environment.NewLine + "Resultado al ejecutar en " + Lista_seleccionadas_DB[i] + ": " + filasafectadas + Environment.NewLine;
                        }
                        catch (Exception ex)
                        {
                            txt_resultado_script_bd.Text += ex.Message + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(null, "Debe seleccionar una base de datos", "Debe seleccionar una base de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(null, "Por favor digite un mando válido.", "Ingresar comando valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void btn_limpiar_comando_Click(object sender, EventArgs e)
        {
            rtxt_CompiladorScript.Text = "";
        }



        private void rtxt_CompiladorScript_TextChanged(object sender, EventArgs e)
        {
            var palabras = this.rtxt_CompiladorScript.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var resultado = from b in palabras_reservadas_sql
                            from c in palabras
                            where c == b
                            select b;
            int inicio = 0;
            foreach (var item in resultado)
            {
                inicio = this.rtxt_CompiladorScript.Text.IndexOf(item, inicio);
                if(inicio == -1)
                {
                    inicio = 0;
                }
                this.rtxt_CompiladorScript.Select(inicio, item.Length);
                this.rtxt_CompiladorScript.SelectionColor = Color.Blue;
                this.rtxt_CompiladorScript.SelectionStart = this.rtxt_CompiladorScript.Text.Length;
                inicio++;
            }

            this.rtxt_CompiladorScript.SelectionColor = Color.Black;
            this.rtxt_CompiladorScript.SelectionStart = this.rtxt_CompiladorScript.Text.Length;
        }

    }
}
