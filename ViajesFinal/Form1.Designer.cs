
namespace ViajesFinal
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lstViajes = new System.Windows.Forms.ListBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rbtInternacional = new System.Windows.Forms.RadioButton();
            this.rbtNacional = new System.Windows.Forms.RadioButton();
            this.cboTransporte = new System.Windows.Forms.ComboBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(429, 293);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Location = new System.Drawing.Point(204, 293);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(30, 293);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lstViajes
            // 
            this.lstViajes.FormattingEnabled = true;
            this.lstViajes.Location = new System.Drawing.Point(338, 31);
            this.lstViajes.Name = "lstViajes";
            this.lstViajes.Size = new System.Drawing.Size(166, 199);
            this.lstViajes.TabIndex = 25;
            this.lstViajes.SelectedIndexChanged += new System.EventHandler(this.lstViajes_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(106, 221);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // rbtInternacional
            // 
            this.rbtInternacional.AutoSize = true;
            this.rbtInternacional.Location = new System.Drawing.Point(204, 180);
            this.rbtInternacional.Name = "rbtInternacional";
            this.rbtInternacional.Size = new System.Drawing.Size(101, 17);
            this.rbtInternacional.TabIndex = 5;
            this.rbtInternacional.TabStop = true;
            this.rbtInternacional.Text = "2 - Internacional";
            this.rbtInternacional.UseVisualStyleBackColor = true;
            // 
            // rbtNacional
            // 
            this.rbtNacional.AutoSize = true;
            this.rbtNacional.Location = new System.Drawing.Point(106, 180);
            this.rbtNacional.Name = "rbtNacional";
            this.rbtNacional.Size = new System.Drawing.Size(82, 17);
            this.rbtNacional.TabIndex = 4;
            this.rbtNacional.TabStop = true;
            this.rbtNacional.Text = "1 - Nacional";
            this.rbtNacional.UseVisualStyleBackColor = true;
            // 
            // cboTransporte
            // 
            this.cboTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransporte.FormattingEnabled = true;
            this.cboTransporte.Location = new System.Drawing.Point(106, 136);
            this.cboTransporte.Name = "cboTransporte";
            this.cboTransporte.Size = new System.Drawing.Size(163, 21);
            this.cboTransporte.TabIndex = 3;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(106, 82);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(163, 20);
            this.txtDestino.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(106, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(27, 228);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(27, 182);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Tipo";
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Location = new System.Drawing.Point(27, 139);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(58, 13);
            this.lblTransporte.TabIndex = 16;
            this.lblTransporte.Text = "Transporte";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(27, 89);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 14;
            this.lblDestino.Text = "Destino";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Código";
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(113, 293);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(348, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 341);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstViajes);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.rbtInternacional);
            this.Controls.Add(this.rbtNacional);
            this.Controls.Add(this.cboTransporte);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ListBox lstViajes;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RadioButton rbtInternacional;
        private System.Windows.Forms.RadioButton rbtNacional;
        private System.Windows.Forms.ComboBox cboTransporte;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

