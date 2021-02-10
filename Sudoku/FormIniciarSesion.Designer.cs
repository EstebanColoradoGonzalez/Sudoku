
namespace Sudoku
{
    partial class FormIniciarSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIniciarSesion));
            this.logoSudoku = new System.Windows.Forms.PictureBox();
            this.labelIngresarUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.buttonIniciarJuego = new System.Windows.Forms.Button();
            this.labelCreated = new System.Windows.Forms.Label();
            this.labelFirmaE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoSudoku)).BeginInit();
            this.SuspendLayout();
            // 
            // logoSudoku
            // 
            this.logoSudoku.BackColor = System.Drawing.Color.Transparent;
            this.logoSudoku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoSudoku.BackgroundImage")));
            this.logoSudoku.Location = new System.Drawing.Point(318, 13);
            this.logoSudoku.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoSudoku.Name = "logoSudoku";
            this.logoSudoku.Size = new System.Drawing.Size(340, 140);
            this.logoSudoku.TabIndex = 0;
            this.logoSudoku.TabStop = false;
            // 
            // labelIngresarUsuario
            // 
            this.labelIngresarUsuario.AutoSize = true;
            this.labelIngresarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelIngresarUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresarUsuario.Location = new System.Drawing.Point(403, 179);
            this.labelIngresarUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIngresarUsuario.Name = "labelIngresarUsuario";
            this.labelIngresarUsuario.Size = new System.Drawing.Size(157, 23);
            this.labelIngresarUsuario.TabIndex = 1;
            this.labelIngresarUsuario.Text = "Ingresar Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(365, 214);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(222, 31);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // buttonIniciarJuego
            // 
            this.buttonIniciarJuego.BackColor = System.Drawing.Color.White;
            this.buttonIniciarJuego.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonIniciarJuego.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarJuego.Location = new System.Drawing.Point(407, 260);
            this.buttonIniciarJuego.Name = "buttonIniciarJuego";
            this.buttonIniciarJuego.Size = new System.Drawing.Size(142, 34);
            this.buttonIniciarJuego.TabIndex = 3;
            this.buttonIniciarJuego.Text = "Iniciar Juego";
            this.buttonIniciarJuego.UseVisualStyleBackColor = false;
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.BackColor = System.Drawing.Color.Transparent;
            this.labelCreated.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreated.Location = new System.Drawing.Point(416, 416);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(114, 23);
            this.labelCreated.TabIndex = 4;
            this.labelCreated.Text = "Created By";
            // 
            // labelFirmaE
            // 
            this.labelFirmaE.AutoSize = true;
            this.labelFirmaE.BackColor = System.Drawing.Color.Transparent;
            this.labelFirmaE.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirmaE.Location = new System.Drawing.Point(362, 448);
            this.labelFirmaE.Name = "labelFirmaE";
            this.labelFirmaE.Size = new System.Drawing.Size(198, 27);
            this.labelFirmaE.TabIndex = 5;
            this.labelFirmaE.Text = "Esteban Colorado González";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Juan Diego Valencia Sanchez";
            // 
            // FormIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFirmaE);
            this.Controls.Add(this.labelCreated);
            this.Controls.Add(this.buttonIniciarJuego);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelIngresarUsuario);
            this.Controls.Add(this.logoSudoku);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormIniciarSesion";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.FormIniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoSudoku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoSudoku;
        private System.Windows.Forms.Label labelIngresarUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button buttonIniciarJuego;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Label labelFirmaE;
        private System.Windows.Forms.Label label1;
    }
}