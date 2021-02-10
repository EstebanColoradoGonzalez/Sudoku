
namespace Sudoku
{
    partial class FormSudoku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSudoku));
            this.logoSudoku = new System.Windows.Forms.PictureBox();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.dificultadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoMuyFacil = new System.Windows.Forms.ToolStripMenuItem();
            this.modoFacil = new System.Windows.Forms.ToolStripMenuItem();
            this.modoNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.modoDificil = new System.Windows.Forms.ToolStripMenuItem();
            this.modoMuyDificil = new System.Windows.Forms.ToolStripMenuItem();
            this.modoExperto = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonHistorial = new System.Windows.Forms.Button();
            this.buttonDatos = new System.Windows.Forms.Button();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.textBoxMinuto = new System.Windows.Forms.TextBox();
            this.textBoxSegundo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonJugarConT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelIngreseTiempo = new System.Windows.Forms.Label();
            this.labelHoras = new System.Windows.Forms.Label();
            this.labelMinutos = new System.Windows.Forms.Label();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.buttonJugarSinT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResultado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoSudoku)).BeginInit();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoSudoku
            // 
            this.logoSudoku.BackColor = System.Drawing.Color.Transparent;
            this.logoSudoku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoSudoku.BackgroundImage")));
            this.logoSudoku.Location = new System.Drawing.Point(409, 30);
            this.logoSudoku.Name = "logoSudoku";
            this.logoSudoku.Size = new System.Drawing.Size(172, 72);
            this.logoSudoku.TabIndex = 83;
            this.logoSudoku.TabStop = false;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.Gainsboro;
            this.menu1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dificultadToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(734, 27);
            this.menu1.TabIndex = 84;
            // 
            // dificultadToolStripMenuItem
            // 
            this.dificultadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoMuyFacil,
            this.modoFacil,
            this.modoNormal,
            this.modoDificil,
            this.modoMuyDificil,
            this.modoExperto});
            this.dificultadToolStripMenuItem.Name = "dificultadToolStripMenuItem";
            this.dificultadToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.dificultadToolStripMenuItem.Text = "Dificultad";
            // 
            // modoMuyFacil
            // 
            this.modoMuyFacil.Name = "modoMuyFacil";
            this.modoMuyFacil.Size = new System.Drawing.Size(156, 24);
            this.modoMuyFacil.Text = "Muy Facil";
            // 
            // modoFacil
            // 
            this.modoFacil.Name = "modoFacil";
            this.modoFacil.Size = new System.Drawing.Size(156, 24);
            this.modoFacil.Text = "Facil";
            // 
            // modoNormal
            // 
            this.modoNormal.Checked = true;
            this.modoNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modoNormal.Name = "modoNormal";
            this.modoNormal.Size = new System.Drawing.Size(156, 24);
            this.modoNormal.Text = "Normal";
            this.modoNormal.ToolTipText = "Modo de Juego Predeterminado";
            // 
            // modoDificil
            // 
            this.modoDificil.Name = "modoDificil";
            this.modoDificil.Size = new System.Drawing.Size(156, 24);
            this.modoDificil.Text = "Dificil";
            // 
            // modoMuyDificil
            // 
            this.modoMuyDificil.Name = "modoMuyDificil";
            this.modoMuyDificil.Size = new System.Drawing.Size(156, 24);
            this.modoMuyDificil.Text = "Muy Dificil";
            // 
            // modoExperto
            // 
            this.modoExperto.Name = "modoExperto";
            this.modoExperto.Size = new System.Drawing.Size(156, 24);
            this.modoExperto.Text = "Experto";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(328, 542);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(338, 27);
            this.dateTimePicker1.TabIndex = 85;
            // 
            // buttonHistorial
            // 
            this.buttonHistorial.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonHistorial.Location = new System.Drawing.Point(195, 110);
            this.buttonHistorial.Name = "buttonHistorial";
            this.buttonHistorial.Size = new System.Drawing.Size(86, 36);
            this.buttonHistorial.TabIndex = 86;
            this.buttonHistorial.Text = "Historial";
            this.buttonHistorial.UseVisualStyleBackColor = false;
            // 
            // buttonDatos
            // 
            this.buttonDatos.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonDatos.Location = new System.Drawing.Point(12, 110);
            this.buttonDatos.Name = "buttonDatos";
            this.buttonDatos.Size = new System.Drawing.Size(169, 36);
            this.buttonDatos.TabIndex = 87;
            this.buttonDatos.Text = "Datos del Jugador";
            this.buttonDatos.UseVisualStyleBackColor = false;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonFinalizar.Location = new System.Drawing.Point(296, 48);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(86, 36);
            this.buttonFinalizar.TabIndex = 88;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = false;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonReiniciar.Location = new System.Drawing.Point(609, 48);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(86, 36);
            this.buttonReiniciar.TabIndex = 89;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = false;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // textBoxHora
            // 
            this.textBoxHora.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHora.Location = new System.Drawing.Point(58, 365);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.ReadOnly = true;
            this.textBoxHora.Size = new System.Drawing.Size(37, 32);
            this.textBoxHora.TabIndex = 90;
            this.textBoxHora.Text = "00";
            this.textBoxHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMinuto
            // 
            this.textBoxMinuto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinuto.Location = new System.Drawing.Point(101, 365);
            this.textBoxMinuto.Name = "textBoxMinuto";
            this.textBoxMinuto.ReadOnly = true;
            this.textBoxMinuto.Size = new System.Drawing.Size(37, 32);
            this.textBoxMinuto.TabIndex = 91;
            this.textBoxMinuto.Text = "00";
            this.textBoxMinuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSegundo
            // 
            this.textBoxSegundo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSegundo.Location = new System.Drawing.Point(144, 365);
            this.textBoxSegundo.Name = "textBoxSegundo";
            this.textBoxSegundo.ReadOnly = true;
            this.textBoxSegundo.Size = new System.Drawing.Size(37, 32);
            this.textBoxSegundo.TabIndex = 92;
            this.textBoxSegundo.Text = "00";
            this.textBoxSegundo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(89, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 93;
            this.label1.Text = "Tiempo";
            // 
            // buttonJugarConT
            // 
            this.buttonJugarConT.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonJugarConT.Location = new System.Drawing.Point(40, 403);
            this.buttonJugarConT.Name = "buttonJugarConT";
            this.buttonJugarConT.Size = new System.Drawing.Size(159, 36);
            this.buttonJugarConT.TabIndex = 94;
            this.buttonJugarConT.Text = "Jugar con Tiempo";
            this.buttonJugarConT.UseVisualStyleBackColor = false;
            this.buttonJugarConT.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelIngreseTiempo
            // 
            this.labelIngreseTiempo.AutoSize = true;
            this.labelIngreseTiempo.ForeColor = System.Drawing.Color.Maroon;
            this.labelIngreseTiempo.Location = new System.Drawing.Point(54, 162);
            this.labelIngreseTiempo.Name = "labelIngreseTiempo";
            this.labelIngreseTiempo.Size = new System.Drawing.Size(145, 19);
            this.labelIngreseTiempo.TabIndex = 95;
            this.labelIngreseTiempo.Text = "Ingrese el Tiempo";
            // 
            // labelHoras
            // 
            this.labelHoras.AutoSize = true;
            this.labelHoras.ForeColor = System.Drawing.Color.Maroon;
            this.labelHoras.Location = new System.Drawing.Point(8, 213);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(52, 19);
            this.labelHoras.TabIndex = 96;
            this.labelHoras.Text = "Horas";
            // 
            // labelMinutos
            // 
            this.labelMinutos.AutoSize = true;
            this.labelMinutos.ForeColor = System.Drawing.Color.Maroon;
            this.labelMinutos.Location = new System.Drawing.Point(8, 251);
            this.labelMinutos.Name = "labelMinutos";
            this.labelMinutos.Size = new System.Drawing.Size(67, 19);
            this.labelMinutos.TabIndex = 97;
            this.labelMinutos.Text = "Minutos";
            // 
            // labelSegundos
            // 
            this.labelSegundos.AutoSize = true;
            this.labelSegundos.ForeColor = System.Drawing.Color.Maroon;
            this.labelSegundos.Location = new System.Drawing.Point(8, 289);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Size = new System.Drawing.Size(85, 19);
            this.labelSegundos.TabIndex = 98;
            this.labelSegundos.Text = "Segundos";
            // 
            // textBoxH
            // 
            this.textBoxH.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxH.Location = new System.Drawing.Point(101, 207);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(37, 32);
            this.textBoxH.TabIndex = 99;
            this.textBoxH.Text = "00";
            this.textBoxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxM
            // 
            this.textBoxM.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxM.Location = new System.Drawing.Point(101, 245);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(37, 32);
            this.textBoxM.TabIndex = 100;
            this.textBoxM.Text = "00";
            this.textBoxM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxS
            // 
            this.textBoxS.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxS.Location = new System.Drawing.Point(101, 283);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(37, 32);
            this.textBoxS.TabIndex = 101;
            this.textBoxS.Text = "00";
            this.textBoxS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonJugarSinT
            // 
            this.buttonJugarSinT.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonJugarSinT.Location = new System.Drawing.Point(40, 442);
            this.buttonJugarSinT.Name = "buttonJugarSinT";
            this.buttonJugarSinT.Size = new System.Drawing.Size(159, 36);
            this.buttonJugarSinT.TabIndex = 102;
            this.buttonJugarSinT.Text = "Jugar sin Tiempo";
            this.buttonJugarSinT.UseVisualStyleBackColor = false;
            this.buttonJugarSinT.Click += new System.EventHandler(this.buttonJugarSinT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(316, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 368);
            this.panel1.TabIndex = 104;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonResultado
            // 
            this.buttonResultado.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonResultado.Location = new System.Drawing.Point(428, 484);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(153, 35);
            this.buttonResultado.TabIndex = 105;
            this.buttonResultado.Text = "Mostrar Resultado";
            this.buttonResultado.UseVisualStyleBackColor = false;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // FormSudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonJugarSinT);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.labelSegundos);
            this.Controls.Add(this.labelMinutos);
            this.Controls.Add(this.labelHoras);
            this.Controls.Add(this.labelIngreseTiempo);
            this.Controls.Add(this.buttonJugarConT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSegundo);
            this.Controls.Add(this.textBoxMinuto);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.buttonDatos);
            this.Controls.Add(this.buttonHistorial);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.logoSudoku);
            this.Controls.Add(this.menu1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormSudoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.FormSudoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoSudoku)).EndInit();
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logoSudoku;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem dificultadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoMuyFacil;
        private System.Windows.Forms.ToolStripMenuItem modoFacil;
        private System.Windows.Forms.ToolStripMenuItem modoNormal;
        private System.Windows.Forms.ToolStripMenuItem modoDificil;
        private System.Windows.Forms.ToolStripMenuItem modoMuyDificil;
        private System.Windows.Forms.ToolStripMenuItem modoExperto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonHistorial;
        private System.Windows.Forms.Button buttonDatos;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.TextBox textBoxMinuto;
        private System.Windows.Forms.TextBox textBoxSegundo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonJugarConT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelIngreseTiempo;
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.Label labelMinutos;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Button buttonJugarSinT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonResultado;
    }
}

