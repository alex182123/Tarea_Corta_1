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
            Class_BD obj_Conexion = new Class_BD();
            cbl_BD.Enabled = false;
            btn_desconectar.Enabled = false;

        }

        private void btn_Conectar_BD_Click(object sender, EventArgs e)
        {
            Class_BD obj_Conexion = new Class_BD();
            if (string.IsNullOrEmpty(txt_NombreInstancia.Text))
            {
                MessageBox.Show(null,"Ingrese un nombre de instacia sql server valido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    obj_Conexion.ConsultarBases(txt_NombreInstancia.Text);
                    ((ListBox)cbl_BD).DataSource = obj_Conexion.ds;
                    ((ListBox)cbl_BD).DisplayMember = "name";
                    ((ListBox)cbl_BD).ValueMember = "name";
                    btn_desconectar.Enabled = true;
                    btn_Conectar_BD.Enabled = false;
                    cbl_BD.Enabled = true;
                    txt_NombreInstancia.Enabled = false;
                    MessageBox.Show(null, "Conexion establecida", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btn_desconectar.Enabled = false;
            btn_Conectar_BD.Enabled = true;
            ((ListBox)cbl_BD).DataSource = null;
            txt_NombreInstancia.Enabled = true;
        }

        private void l_lbl_SelectTodas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for(int i=0;i<cbl_BD.Items.Count;i++) 
            {
                cbl_BD.SetItemChecked(i, true);
            }
        }

        private void l_lblSelectNinguna_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < cbl_BD.Items.Count; i++)
            {
                cbl_BD.SetItemChecked(i, false);
            }
        }
    }
}
