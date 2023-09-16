namespace EjercicioPreParcial
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
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblDirectorTecnico = new System.Windows.Forms.Label();
            this.lblCamiseta = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.txtDirectorTecnico = new System.Windows.Forms.TextBox();
            this.cbPersonas = new System.Windows.Forms.ComboBox();
            this.nudCamiseta = new System.Windows.Forms.NumericUpDown();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.btnAceotar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCamiseta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamiseta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(43, 51);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(43, 13);
            this.lblEquipo.TabIndex = 0;
            this.lblEquipo.Text = "Equipo:";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(40, 140);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(46, 13);
            this.lblPersona.TabIndex = 1;
            this.lblPersona.Text = "Persona";
            // 
            // lblDirectorTecnico
            // 
            this.lblDirectorTecnico.AutoSize = true;
            this.lblDirectorTecnico.Location = new System.Drawing.Point(40, 80);
            this.lblDirectorTecnico.Name = "lblDirectorTecnico";
            this.lblDirectorTecnico.Size = new System.Drawing.Size(89, 13);
            this.lblDirectorTecnico.TabIndex = 2;
            this.lblDirectorTecnico.Text = "Director Tecnico:";
            // 
            // lblCamiseta
            // 
            this.lblCamiseta.AutoSize = true;
            this.lblCamiseta.Location = new System.Drawing.Point(186, 139);
            this.lblCamiseta.Name = "lblCamiseta";
            this.lblCamiseta.Size = new System.Drawing.Size(70, 13);
            this.lblCamiseta.TabIndex = 3;
            this.lblCamiseta.Text = "Nro Camiseta";
            this.lblCamiseta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(259, 139);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(47, 13);
            this.lblPosicion.TabIndex = 4;
            this.lblPosicion.Text = "Posicion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Jugadores";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(135, 48);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(423, 20);
            this.txtEquipo.TabIndex = 6;
            // 
            // txtDirectorTecnico
            // 
            this.txtDirectorTecnico.Location = new System.Drawing.Point(135, 80);
            this.txtDirectorTecnico.Name = "txtDirectorTecnico";
            this.txtDirectorTecnico.Size = new System.Drawing.Size(423, 20);
            this.txtDirectorTecnico.TabIndex = 7;
            // 
            // cbPersonas
            // 
            this.cbPersonas.FormattingEnabled = true;
            this.cbPersonas.Location = new System.Drawing.Point(43, 156);
            this.cbPersonas.Name = "cbPersonas";
            this.cbPersonas.Size = new System.Drawing.Size(140, 21);
            this.cbPersonas.TabIndex = 8;
            this.cbPersonas.SelectedIndexChanged += new System.EventHandler(this.cbPersonas_SelectedIndexChanged);
            // 
            // nudCamiseta
            // 
            this.nudCamiseta.Location = new System.Drawing.Point(189, 157);
            this.nudCamiseta.Name = "nudCamiseta";
            this.nudCamiseta.Size = new System.Drawing.Size(67, 20);
            this.nudCamiseta.TabIndex = 9;
            this.nudCamiseta.ValueChanged += new System.EventHandler(this.nudCamiseta_ValueChanged);
            // 
            // cbPosicion
            // 
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Location = new System.Drawing.Point(262, 155);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(190, 21);
            this.cbPosicion.TabIndex = 10;
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clJugador,
            this.clCamiseta,
            this.clPosicion,
            this.btnQuitar});
            this.dgvJugadores.Location = new System.Drawing.Point(43, 181);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.ReadOnly = true;
            this.dgvJugadores.Size = new System.Drawing.Size(515, 150);
            this.dgvJugadores.TabIndex = 11;
            this.dgvJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAceotar
            // 
            this.btnAceotar.Location = new System.Drawing.Point(171, 401);
            this.btnAceotar.Name = "btnAceotar";
            this.btnAceotar.Size = new System.Drawing.Size(75, 23);
            this.btnAceotar.TabIndex = 12;
            this.btnAceotar.Text = "Aceptar";
            this.btnAceotar.UseVisualStyleBackColor = true;
            this.btnAceotar.Click += new System.EventHandler(this.btnAceotar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(483, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(264, 401);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // clId
            // 
            this.clId.HeaderText = "id";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            // 
            // clJugador
            // 
            this.clJugador.HeaderText = "Jugador";
            this.clJugador.Name = "clJugador";
            this.clJugador.ReadOnly = true;
            // 
            // clCamiseta
            // 
            this.clCamiseta.HeaderText = "Camiseta";
            this.clCamiseta.Name = "clCamiseta";
            this.clCamiseta.ReadOnly = true;
            // 
            // clPosicion
            // 
            this.clPosicion.HeaderText = "Posicion";
            this.clPosicion.Name = "clPosicion";
            this.clPosicion.ReadOnly = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.HeaderText = "Quitar";
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAceotar);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.nudCamiseta);
            this.Controls.Add(this.cbPersonas);
            this.Controls.Add(this.txtDirectorTecnico);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblCamiseta);
            this.Controls.Add(this.lblDirectorTecnico);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.lblEquipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCamiseta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label lblDirectorTecnico;
        private System.Windows.Forms.Label lblCamiseta;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.TextBox txtDirectorTecnico;
        private System.Windows.Forms.ComboBox cbPersonas;
        private System.Windows.Forms.NumericUpDown nudCamiseta;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Button btnAceotar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCamiseta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPosicion;
        private System.Windows.Forms.DataGridViewButtonColumn btnQuitar;
    }
}

