﻿
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opf_Menu_Script = new System.Windows.Forms.OpenFileDialog();
            this.btn_Conectar_BD = new System.Windows.Forms.Button();
            this.cbl_BD = new System.Windows.Forms.CheckedListBox();
            this.txt_NombreInstancia = new System.Windows.Forms.TextBox();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.lbl_NombreInstancia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_lblSelectNinguna = new System.Windows.Forms.LinkLabel();
            this.l_lbl_SelectTodas = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_resultado_script_bd = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // opf_Menu_Script
            // 
            this.opf_Menu_Script.FileName = "openFileDialog1";
            // 
            // btn_Conectar_BD
            // 
            this.btn_Conectar_BD.Location = new System.Drawing.Point(19, 66);
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
            this.cbl_BD.Location = new System.Drawing.Point(19, 27);
            this.cbl_BD.Name = "cbl_BD";
            this.cbl_BD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbl_BD.ScrollAlwaysVisible = true;
            this.cbl_BD.Size = new System.Drawing.Size(177, 274);
            this.cbl_BD.TabIndex = 2;
            // 
            // txt_NombreInstancia
            // 
            this.txt_NombreInstancia.Location = new System.Drawing.Point(19, 30);
            this.txt_NombreInstancia.Name = "txt_NombreInstancia";
            this.txt_NombreInstancia.Size = new System.Drawing.Size(177, 20);
            this.txt_NombreInstancia.TabIndex = 3;
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(116, 66);
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
            this.lbl_NombreInstancia.Location = new System.Drawing.Point(50, 11);
            this.lbl_NombreInstancia.Name = "lbl_NombreInstancia";
            this.lbl_NombreInstancia.Size = new System.Drawing.Size(113, 16);
            this.lbl_NombreInstancia.TabIndex = 5;
            this.lbl_NombreInstancia.Text = "Nombre Instancia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_NombreInstancia);
            this.panel1.Controls.Add(this.btn_desconectar);
            this.panel1.Controls.Add(this.txt_NombreInstancia);
            this.panel1.Controls.Add(this.btn_Conectar_BD);
            this.panel1.Location = new System.Drawing.Point(16, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 110);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.l_lblSelectNinguna);
            this.panel2.Controls.Add(this.cbl_BD);
            this.panel2.Controls.Add(this.l_lbl_SelectTodas);
            this.panel2.Location = new System.Drawing.Point(16, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 306);
            this.panel2.TabIndex = 7;
            // 
            // l_lblSelectNinguna
            // 
            this.l_lblSelectNinguna.AutoSize = true;
            this.l_lblSelectNinguna.Location = new System.Drawing.Point(98, 6);
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
            this.l_lbl_SelectTodas.Location = new System.Drawing.Point(3, 6);
            this.l_lbl_SelectTodas.Name = "l_lbl_SelectTodas";
            this.l_lbl_SelectTodas.Size = new System.Drawing.Size(92, 13);
            this.l_lbl_SelectTodas.TabIndex = 8;
            this.l_lbl_SelectTodas.TabStop = true;
            this.l_lbl_SelectTodas.Text = "Seleccionar todas";
            this.l_lbl_SelectTodas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_lbl_SelectTodas_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(12, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(631, 196);
            this.textBox1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(265, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 227);
            this.panel3.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(265, 338);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 122);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_resultado_script_bd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 96);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resultados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_resultado_script_bd
            // 
            this.txt_resultado_script_bd.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_resultado_script_bd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_resultado_script_bd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado_script_bd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_resultado_script_bd.Location = new System.Drawing.Point(0, 0);
            this.txt_resultado_script_bd.Multiline = true;
            this.txt_resultado_script_bd.Name = "txt_resultado_script_bd";
            this.txt_resultado_script_bd.ReadOnly = true;
            this.txt_resultado_script_bd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_resultado_script_bd.Size = new System.Drawing.Size(649, 142);
            this.txt_resultado_script_bd.TabIndex = 9;
            this.txt_resultado_script_bd.Text = "Esperando conexion...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(973, 488);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tarea Corta 1 | Administrador de base de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel l_lbl_SelectTodas;
        private System.Windows.Forms.LinkLabel l_lblSelectNinguna;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_resultado_script_bd;
    }
}

