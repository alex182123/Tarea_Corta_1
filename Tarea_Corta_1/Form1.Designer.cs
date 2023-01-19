
namespace Tarea_Corta_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarArchivoSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opf_Menu_Script = new System.Windows.Forms.OpenFileDialog();
            this.btn_Conectar_BD = new System.Windows.Forms.Button();
            this.cbl_BD = new System.Windows.Forms.CheckedListBox();
            this.txt_NombreInstancia = new System.Windows.Forms.TextBox();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.lbl_NombreInstancia = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_lblSelectNinguna = new System.Windows.Forms.LinkLabel();
            this.l_lbl_SelectTodas = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Copiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxt_CompiladorScript = new System.Windows.Forms.RichTextBox();
            this.btn_limpiar_comando = new System.Windows.Forms.Button();
            this.btn_ejecutar_comando = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_resultado_script_bd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tp0_WindowsAuthentication = new System.Windows.Forms.TabPage();
            this.tp1_SQLAuthentication = new System.Windows.Forms.TabPage();
            this.txt_ContraseñaSQL = new System.Windows.Forms.TextBox();
            this.txt_NombreUsuarioSQL = new System.Windows.Forms.TextBox();
            this.txt_NombreInstaciaSQL = new System.Windows.Forms.TextBox();
            this.btn_desconectarSQL = new System.Windows.Forms.Button();
            this.btn_ConectarSQL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_btn_ejecutarComando = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tp0_WindowsAuthentication.SuspendLayout();
            this.tp1_SQLAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarArchivoSQLToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // cargarArchivoSQLToolStripMenuItem
            // 
            this.cargarArchivoSQLToolStripMenuItem.Name = "cargarArchivoSQLToolStripMenuItem";
            this.cargarArchivoSQLToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cargarArchivoSQLToolStripMenuItem.Text = "Cargar archivo SQL";
            this.cargarArchivoSQLToolStripMenuItem.Click += new System.EventHandler(this.cargarArchivoSQLToolStripMenuItem_Click);
            // 
            // opf_Menu_Script
            // 
            this.opf_Menu_Script.FileName = "openFileDialog1";
            // 
            // btn_Conectar_BD
            // 
            this.btn_Conectar_BD.Location = new System.Drawing.Point(25, 120);
            this.btn_Conectar_BD.Name = "btn_Conectar_BD";
            this.btn_Conectar_BD.Size = new System.Drawing.Size(80, 23);
            this.btn_Conectar_BD.TabIndex = 1;
            this.btn_Conectar_BD.Text = "Conectar";
            this.btn_Conectar_BD.UseVisualStyleBackColor = true;
            this.btn_Conectar_BD.Click += new System.EventHandler(this.btn_Conectar_BD_Click);
            // 
            // cbl_BD
            // 
            this.cbl_BD.FormattingEnabled = true;
            this.cbl_BD.HorizontalScrollbar = true;
            this.cbl_BD.Location = new System.Drawing.Point(22, 42);
            this.cbl_BD.Name = "cbl_BD";
            this.cbl_BD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbl_BD.ScrollAlwaysVisible = true;
            this.cbl_BD.Size = new System.Drawing.Size(201, 199);
            this.cbl_BD.TabIndex = 2;
            // 
            // txt_NombreInstancia
            // 
            this.txt_NombreInstancia.Location = new System.Drawing.Point(25, 63);
            this.txt_NombreInstancia.Name = "txt_NombreInstancia";
            this.txt_NombreInstancia.Size = new System.Drawing.Size(177, 20);
            this.txt_NombreInstancia.TabIndex = 3;
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(115, 120);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(80, 23);
            this.btn_desconectar.TabIndex = 4;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_NombreInstancia
            // 
            this.lbl_NombreInstancia.AutoSize = true;
            this.lbl_NombreInstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreInstancia.Location = new System.Drawing.Point(60, 36);
            this.lbl_NombreInstancia.Name = "lbl_NombreInstancia";
            this.lbl_NombreInstancia.Size = new System.Drawing.Size(113, 16);
            this.lbl_NombreInstancia.TabIndex = 5;
            this.lbl_NombreInstancia.Text = "Nombre Instancia";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.l_lblSelectNinguna);
            this.panel2.Controls.Add(this.cbl_BD);
            this.panel2.Controls.Add(this.l_lbl_SelectTodas);
            this.panel2.Location = new System.Drawing.Point(16, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 250);
            this.panel2.TabIndex = 7;
            // 
            // l_lblSelectNinguna
            // 
            this.l_lblSelectNinguna.AutoSize = true;
            this.l_lblSelectNinguna.Location = new System.Drawing.Point(119, 10);
            this.l_lblSelectNinguna.Name = "l_lblSelectNinguna";
            this.l_lblSelectNinguna.Size = new System.Drawing.Size(104, 13);
            this.l_lblSelectNinguna.TabIndex = 9;
            this.l_lblSelectNinguna.TabStop = true;
            this.l_lblSelectNinguna.Text = "Seleccionar ninguna";
            this.l_lblSelectNinguna.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_lblSelectNinguna_LinkClicked);
            // 
            // l_lbl_SelectTodas
            // 
            this.l_lbl_SelectTodas.AutoSize = true;
            this.l_lbl_SelectTodas.Location = new System.Drawing.Point(19, 10);
            this.l_lbl_SelectTodas.Name = "l_lbl_SelectTodas";
            this.l_lbl_SelectTodas.Size = new System.Drawing.Size(92, 13);
            this.l_lbl_SelectTodas.TabIndex = 8;
            this.l_lbl_SelectTodas.TabStop = true;
            this.l_lbl_SelectTodas.Text = "Seleccionar todas";
            this.l_lbl_SelectTodas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_lbl_SelectTodas_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Copiar);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rtxt_CompiladorScript);
            this.panel3.Controls.Add(this.btn_limpiar_comando);
            this.panel3.Controls.Add(this.btn_ejecutar_comando);
            this.panel3.Location = new System.Drawing.Point(294, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 235);
            this.panel3.TabIndex = 9;
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Copiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Copiar.Location = new System.Drawing.Point(347, 7);
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(98, 23);
            this.btn_Copiar.TabIndex = 13;
            this.btn_Copiar.Text = "Copiar script";
            this.btn_Copiar.UseVisualStyleBackColor = false;
            this.btn_Copiar.Click += new System.EventHandler(this.btn_Copiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Controles :";
            // 
            // rtxt_CompiladorScript
            // 
            this.rtxt_CompiladorScript.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_CompiladorScript.Location = new System.Drawing.Point(14, 36);
            this.rtxt_CompiladorScript.Name = "rtxt_CompiladorScript";
            this.rtxt_CompiladorScript.Size = new System.Drawing.Size(638, 186);
            this.rtxt_CompiladorScript.TabIndex = 12;
            this.rtxt_CompiladorScript.Text = "";
            this.rtxt_CompiladorScript.TextChanged += new System.EventHandler(this.rtxt_CompiladorScript_TextChanged);
            // 
            // btn_limpiar_comando
            // 
            this.btn_limpiar_comando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_limpiar_comando.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpiar_comando.Location = new System.Drawing.Point(226, 7);
            this.btn_limpiar_comando.Name = "btn_limpiar_comando";
            this.btn_limpiar_comando.Size = new System.Drawing.Size(115, 23);
            this.btn_limpiar_comando.TabIndex = 10;
            this.btn_limpiar_comando.Text = "Limpiar Comando";
            this.btn_limpiar_comando.UseVisualStyleBackColor = false;
            this.btn_limpiar_comando.Click += new System.EventHandler(this.btn_limpiar_comando_Click);
            // 
            // btn_ejecutar_comando
            // 
            this.btn_ejecutar_comando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ejecutar_comando.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ejecutar_comando.Location = new System.Drawing.Point(88, 7);
            this.btn_ejecutar_comando.Name = "btn_ejecutar_comando";
            this.btn_ejecutar_comando.Size = new System.Drawing.Size(132, 23);
            this.btn_ejecutar_comando.TabIndex = 9;
            this.btn_ejecutar_comando.Text = "Ejecutar comando SQL";
            this.btn_ejecutar_comando.UseVisualStyleBackColor = false;
            this.btn_ejecutar_comando.Click += new System.EventHandler(this.btn_ejecutar_comando_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(294, 325);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 214);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txt_resultado_script_bd);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 188);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resultados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_resultado_script_bd
            // 
            this.txt_resultado_script_bd.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_resultado_script_bd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_resultado_script_bd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado_script_bd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_resultado_script_bd.Location = new System.Drawing.Point(-1, 40);
            this.txt_resultado_script_bd.Multiline = true;
            this.txt_resultado_script_bd.Name = "txt_resultado_script_bd";
            this.txt_resultado_script_bd.ReadOnly = true;
            this.txt_resultado_script_bd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_resultado_script_bd.Size = new System.Drawing.Size(652, 147);
            this.txt_resultado_script_bd.TabIndex = 9;
            this.txt_resultado_script_bd.Text = "Esperando conexion...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultados de la ejecucion";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tp0_WindowsAuthentication);
            this.tabControl2.Controls.Add(this.tp1_SQLAuthentication);
            this.tabControl2.Location = new System.Drawing.Point(19, 46);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(240, 236);
            this.tabControl2.TabIndex = 11;
            // 
            // tp0_WindowsAuthentication
            // 
            this.tp0_WindowsAuthentication.BackColor = System.Drawing.Color.White;
            this.tp0_WindowsAuthentication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tp0_WindowsAuthentication.Controls.Add(this.lbl_NombreInstancia);
            this.tp0_WindowsAuthentication.Controls.Add(this.txt_NombreInstancia);
            this.tp0_WindowsAuthentication.Controls.Add(this.btn_Conectar_BD);
            this.tp0_WindowsAuthentication.Controls.Add(this.btn_desconectar);
            this.tp0_WindowsAuthentication.Location = new System.Drawing.Point(4, 22);
            this.tp0_WindowsAuthentication.Name = "tp0_WindowsAuthentication";
            this.tp0_WindowsAuthentication.Padding = new System.Windows.Forms.Padding(3);
            this.tp0_WindowsAuthentication.Size = new System.Drawing.Size(232, 210);
            this.tp0_WindowsAuthentication.TabIndex = 0;
            this.tp0_WindowsAuthentication.Text = "Windows Authentication";
            // 
            // tp1_SQLAuthentication
            // 
            this.tp1_SQLAuthentication.BackColor = System.Drawing.Color.White;
            this.tp1_SQLAuthentication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tp1_SQLAuthentication.Controls.Add(this.txt_ContraseñaSQL);
            this.tp1_SQLAuthentication.Controls.Add(this.txt_NombreUsuarioSQL);
            this.tp1_SQLAuthentication.Controls.Add(this.txt_NombreInstaciaSQL);
            this.tp1_SQLAuthentication.Controls.Add(this.btn_desconectarSQL);
            this.tp1_SQLAuthentication.Controls.Add(this.btn_ConectarSQL);
            this.tp1_SQLAuthentication.Controls.Add(this.label3);
            this.tp1_SQLAuthentication.Controls.Add(this.label2);
            this.tp1_SQLAuthentication.Controls.Add(this.label1);
            this.tp1_SQLAuthentication.Location = new System.Drawing.Point(4, 22);
            this.tp1_SQLAuthentication.Name = "tp1_SQLAuthentication";
            this.tp1_SQLAuthentication.Padding = new System.Windows.Forms.Padding(3);
            this.tp1_SQLAuthentication.Size = new System.Drawing.Size(232, 210);
            this.tp1_SQLAuthentication.TabIndex = 1;
            this.tp1_SQLAuthentication.Text = "SQL Authentication";
            // 
            // txt_ContraseñaSQL
            // 
            this.txt_ContraseñaSQL.Location = new System.Drawing.Point(42, 121);
            this.txt_ContraseñaSQL.Name = "txt_ContraseñaSQL";
            this.txt_ContraseñaSQL.PasswordChar = '*';
            this.txt_ContraseñaSQL.Size = new System.Drawing.Size(145, 20);
            this.txt_ContraseñaSQL.TabIndex = 13;
            // 
            // txt_NombreUsuarioSQL
            // 
            this.txt_NombreUsuarioSQL.Location = new System.Drawing.Point(42, 79);
            this.txt_NombreUsuarioSQL.Name = "txt_NombreUsuarioSQL";
            this.txt_NombreUsuarioSQL.Size = new System.Drawing.Size(145, 20);
            this.txt_NombreUsuarioSQL.TabIndex = 12;
            // 
            // txt_NombreInstaciaSQL
            // 
            this.txt_NombreInstaciaSQL.Location = new System.Drawing.Point(42, 37);
            this.txt_NombreInstaciaSQL.Name = "txt_NombreInstaciaSQL";
            this.txt_NombreInstaciaSQL.Size = new System.Drawing.Size(145, 20);
            this.txt_NombreInstaciaSQL.TabIndex = 11;
            // 
            // btn_desconectarSQL
            // 
            this.btn_desconectarSQL.Location = new System.Drawing.Point(132, 163);
            this.btn_desconectarSQL.Name = "btn_desconectarSQL";
            this.btn_desconectarSQL.Size = new System.Drawing.Size(85, 23);
            this.btn_desconectarSQL.TabIndex = 10;
            this.btn_desconectarSQL.Text = "Desconectar";
            this.btn_desconectarSQL.UseVisualStyleBackColor = true;
            this.btn_desconectarSQL.Click += new System.EventHandler(this.btn_desconectarSQL_Click);
            // 
            // btn_ConectarSQL
            // 
            this.btn_ConectarSQL.Location = new System.Drawing.Point(16, 163);
            this.btn_ConectarSQL.Name = "btn_ConectarSQL";
            this.btn_ConectarSQL.Size = new System.Drawing.Size(75, 23);
            this.btn_ConectarSQL.TabIndex = 9;
            this.btn_ConectarSQL.Text = "Conectar";
            this.btn_ConectarSQL.UseVisualStyleBackColor = true;
            this.btn_ConectarSQL.Click += new System.EventHandler(this.btn_ConectarSQL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Constraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Instancia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 587);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tarea Corta 1 | Administrador de base de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tp0_WindowsAuthentication.ResumeLayout(false);
            this.tp0_WindowsAuthentication.PerformLayout();
            this.tp1_SQLAuthentication.ResumeLayout(false);
            this.tp1_SQLAuthentication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog opf_Menu_Script;
        private System.Windows.Forms.Button btn_Conectar_BD;
        private System.Windows.Forms.CheckedListBox cbl_BD;
        private System.Windows.Forms.TextBox txt_NombreInstancia;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Label lbl_NombreInstancia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel l_lbl_SelectTodas;
        private System.Windows.Forms.LinkLabel l_lblSelectNinguna;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_resultado_script_bd;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tp0_WindowsAuthentication;
        private System.Windows.Forms.TabPage tp1_SQLAuthentication;
        private System.Windows.Forms.TextBox txt_ContraseñaSQL;
        private System.Windows.Forms.TextBox txt_NombreUsuarioSQL;
        private System.Windows.Forms.TextBox txt_NombreInstaciaSQL;
        private System.Windows.Forms.Button btn_desconectarSQL;
        private System.Windows.Forms.Button btn_ConectarSQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ejecutar_comando;
        private System.Windows.Forms.Button btn_limpiar_comando;
        private System.Windows.Forms.RichTextBox rtxt_CompiladorScript;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip tp_btn_ejecutarComando;
        private System.Windows.Forms.Button btn_Copiar;
        private System.Windows.Forms.ToolStripMenuItem cargarArchivoSQLToolStripMenuItem;
    }
}

