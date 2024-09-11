namespace RepasoParcial1
{
    partial class FormPrincipal
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
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.btnIniciarPresupuesto = new System.Windows.Forms.Button();
            this.btnCerrarPresupuesto = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lbProductos = new System.Windows.Forms.Label();
            this.tbPrecioB = new System.Windows.Forms.TextBox();
            this.lbPrecioB = new System.Windows.Forms.Label();
            this.lbAncho = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbLargo = new System.Windows.Forms.Label();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.lbGrosor = new System.Windows.Forms.Label();
            this.tbGrosor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.rbMesa = new System.Windows.Forms.RadioButton();
            this.rbBanco = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(62, 53);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(39, 13);
            this.lbCliente.TabIndex = 0;
            this.lbCliente.Text = "Cliente";
            this.lbCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(83, 88);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(83, 133);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(55, 13);
            this.lbDireccion.TabIndex = 2;
            this.lbDireccion.Text = "Direccion:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(136, 85);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(136, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(136, 130);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(136, 20);
            this.tbDir.TabIndex = 4;
            // 
            // btnIniciarPresupuesto
            // 
            this.btnIniciarPresupuesto.Location = new System.Drawing.Point(86, 172);
            this.btnIniciarPresupuesto.Name = "btnIniciarPresupuesto";
            this.btnIniciarPresupuesto.Size = new System.Drawing.Size(75, 43);
            this.btnIniciarPresupuesto.TabIndex = 5;
            this.btnIniciarPresupuesto.Text = "Iniciar Presupuesto";
            this.btnIniciarPresupuesto.UseVisualStyleBackColor = true;
            this.btnIniciarPresupuesto.Click += new System.EventHandler(this.btnIniciarPresupuesto_Click);
            // 
            // btnCerrarPresupuesto
            // 
            this.btnCerrarPresupuesto.Location = new System.Drawing.Point(197, 172);
            this.btnCerrarPresupuesto.Name = "btnCerrarPresupuesto";
            this.btnCerrarPresupuesto.Size = new System.Drawing.Size(75, 43);
            this.btnCerrarPresupuesto.TabIndex = 6;
            this.btnCerrarPresupuesto.Text = "Cerrar Presupuesto";
            this.btnCerrarPresupuesto.UseVisualStyleBackColor = true;
            this.btnCerrarPresupuesto.Click += new System.EventHandler(this.btnCerrarPresupuesto_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(207, 230);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(65, 27);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lbProductos
            // 
            this.lbProductos.AutoSize = true;
            this.lbProductos.Location = new System.Drawing.Point(347, 53);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(55, 13);
            this.lbProductos.TabIndex = 10;
            this.lbProductos.Text = "Productos";
            // 
            // tbPrecioB
            // 
            this.tbPrecioB.Location = new System.Drawing.Point(400, 81);
            this.tbPrecioB.Name = "tbPrecioB";
            this.tbPrecioB.Size = new System.Drawing.Size(65, 20);
            this.tbPrecioB.TabIndex = 11;
            // 
            // lbPrecioB
            // 
            this.lbPrecioB.AutoSize = true;
            this.lbPrecioB.Location = new System.Drawing.Point(347, 84);
            this.lbPrecioB.Name = "lbPrecioB";
            this.lbPrecioB.Size = new System.Drawing.Size(50, 13);
            this.lbPrecioB.TabIndex = 12;
            this.lbPrecioB.Text = "Precio B:";
            // 
            // lbAncho
            // 
            this.lbAncho.AutoSize = true;
            this.lbAncho.Location = new System.Drawing.Point(347, 117);
            this.lbAncho.Name = "lbAncho";
            this.lbAncho.Size = new System.Drawing.Size(41, 13);
            this.lbAncho.TabIndex = 13;
            this.lbAncho.Text = "Ancho:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(347, 159);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(43, 13);
            this.lbCodigo.TabIndex = 14;
            this.lbCodigo.Text = "Codigo:";
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(400, 117);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(65, 20);
            this.tbAncho.TabIndex = 15;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(400, 156);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(65, 20);
            this.tbCodigo.TabIndex = 16;
            // 
            // lbLargo
            // 
            this.lbLargo.AutoSize = true;
            this.lbLargo.Location = new System.Drawing.Point(492, 84);
            this.lbLargo.Name = "lbLargo";
            this.lbLargo.Size = new System.Drawing.Size(37, 13);
            this.lbLargo.TabIndex = 17;
            this.lbLargo.Text = "Largo:";
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(539, 81);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(65, 20);
            this.tbLargo.TabIndex = 19;
            // 
            // lbGrosor
            // 
            this.lbGrosor.AutoSize = true;
            this.lbGrosor.Location = new System.Drawing.Point(492, 117);
            this.lbGrosor.Name = "lbGrosor";
            this.lbGrosor.Size = new System.Drawing.Size(41, 13);
            this.lbGrosor.TabIndex = 20;
            this.lbGrosor.Text = "Grosor:";
            // 
            // tbGrosor
            // 
            this.tbGrosor.Location = new System.Drawing.Point(539, 114);
            this.tbGrosor.Name = "tbGrosor";
            this.tbGrosor.Size = new System.Drawing.Size(65, 20);
            this.tbGrosor.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(505, 156);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 32);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(80, 234);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 25;
            // 
            // rbMesa
            // 
            this.rbMesa.AutoSize = true;
            this.rbMesa.Location = new System.Drawing.Point(435, 51);
            this.rbMesa.Name = "rbMesa";
            this.rbMesa.Size = new System.Drawing.Size(51, 17);
            this.rbMesa.TabIndex = 26;
            this.rbMesa.TabStop = true;
            this.rbMesa.Text = "Mesa";
            this.rbMesa.UseVisualStyleBackColor = true;
            // 
            // rbBanco
            // 
            this.rbBanco.AutoSize = true;
            this.rbBanco.Location = new System.Drawing.Point(505, 51);
            this.rbBanco.Name = "rbBanco";
            this.rbBanco.Size = new System.Drawing.Size(56, 17);
            this.rbBanco.TabIndex = 27;
            this.rbBanco.TabStop = true;
            this.rbBanco.Text = "Banco";
            this.rbBanco.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 289);
            this.Controls.Add(this.rbBanco);
            this.Controls.Add(this.rbMesa);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbGrosor);
            this.Controls.Add(this.lbGrosor);
            this.Controls.Add(this.tbLargo);
            this.Controls.Add(this.lbLargo);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbAncho);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbAncho);
            this.Controls.Add(this.lbPrecioB);
            this.Controls.Add(this.tbPrecioB);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCerrarPresupuesto);
            this.Controls.Add(this.btnIniciarPresupuesto);
            this.Controls.Add(this.tbDir);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCliente);
            this.Name = "FormPrincipal";
            this.Text = "Fabrica de plasticos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Button btnIniciarPresupuesto;
        private System.Windows.Forms.Button btnCerrarPresupuesto;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lbProductos;
        private System.Windows.Forms.TextBox tbPrecioB;
        private System.Windows.Forms.Label lbPrecioB;
        private System.Windows.Forms.Label lbAncho;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbLargo;
        private System.Windows.Forms.TextBox tbLargo;
        private System.Windows.Forms.Label lbGrosor;
        private System.Windows.Forms.TextBox tbGrosor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.RadioButton rbMesa;
        private System.Windows.Forms.RadioButton rbBanco;
    }
}

