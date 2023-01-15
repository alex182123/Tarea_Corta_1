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
            obj_Conexion.ConsultarBases();
            ((ListBox)cbl_BD).DataSource = obj_Conexion.ds;
            ((ListBox)cbl_BD).DisplayMember = "name";
            ((ListBox)cbl_BD).ValueMember = "name";
            //MessageBox.Show(obj_Conexion.ConsultarBases());
        }

        private void btn_Conectar_BD_Click(object sender, EventArgs e)
        {
            Class_BD obj_Conexion = new Class_BD();
            //MessageBox.Show(obj_Conexion.ConsultarBases());
        }
    }
}
