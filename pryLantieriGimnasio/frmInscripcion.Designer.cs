namespace pryLantieriGimnasio
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblEdad = new Label();
            lblPlanes = new Label();
            lblTurno = new Label();
            lblMeses = new Label();
            lblPago = new Label();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            txtNombre = new TextBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            txtEdad = new TextBox();
            chkCasillero = new CheckBox();
            chkEstudiante = new CheckBox();
            cboCuotas = new ComboBox();
            grpPagos = new GroupBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            txtMeses = new TextBox();
            grpPagos.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(164, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "INSCRIPCIÓN";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Yu Gothic", 18F, FontStyle.Bold);
            lblNombre.Location = new Point(51, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(114, 31);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Yu Gothic", 18F, FontStyle.Bold);
            lblEdad.Location = new Point(84, 142);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(81, 31);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad:";
            // 
            // lblPlanes
            // 
            lblPlanes.AutoSize = true;
            lblPlanes.Font = new Font("Yu Gothic", 18F, FontStyle.Bold);
            lblPlanes.Location = new Point(89, 189);
            lblPlanes.Name = "lblPlanes";
            lblPlanes.Size = new Size(74, 31);
            lblPlanes.TabIndex = 4;
            lblPlanes.Text = "Plan:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Yu Gothic", 18F, FontStyle.Bold);
            lblTurno.Location = new Point(75, 230);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(88, 31);
            lblTurno.TabIndex = 5;
            lblTurno.Text = "Turno:";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Font = new Font("Yu Gothic", 18F, FontStyle.Bold);
            lblMeses.Location = new Point(65, 273);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(98, 31);
            lblMeses.TabIndex = 6;
            lblMeses.Text = "Meses:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Yu Gothic", 18F, FontStyle.Bold);
            lblPago.Location = new Point(65, 358);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(207, 31);
            lblPago.TabIndex = 8;
            lblPago.Text = "Formas de pago:";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Location = new Point(176, 197);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 4;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Location = new Point(176, 239);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(176, 110);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(128, 23);
            txtNombre.TabIndex = 1;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Font = new Font("Yu Gothic Medium", 14.25F, FontStyle.Bold);
            rbtEfectivo.Location = new Point(9, 23);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(110, 29);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Font = new Font("Yu Gothic Medium", 14.25F, FontStyle.Bold);
            rbtTarjeta.Location = new Point(125, 23);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(100, 29);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(176, 150);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(33, 23);
            txtEdad.TabIndex = 2;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCasillero.Location = new Point(74, 310);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(135, 35);
            chkCasillero.TabIndex = 7;
            chkCasillero.Text = "Casillero";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEstudiante.Location = new Point(217, 148);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(118, 25);
            chkEstudiante.TabIndex = 3;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
          
            // 
            // cboCuotas
            // 
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(101, 66);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 23);
            cboCuotas.TabIndex = 2;
            // 
            // grpPagos
            // 
            grpPagos.Controls.Add(rbtTarjeta);
            grpPagos.Controls.Add(cboCuotas);
            grpPagos.Controls.Add(rbtEfectivo);
            grpPagos.Location = new Point(278, 338);
            grpPagos.Name = "grpPagos";
            grpPagos.Size = new Size(228, 95);
            grpPagos.TabIndex = 9;
            grpPagos.TabStop = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnCalcular.Location = new Point(69, 453);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(130, 35);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnLimpiar.Location = new Point(217, 453);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 35);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(176, 282);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(128, 23);
            txtMeses.TabIndex = 6;
            txtMeses.KeyPress += txtMeses_KeyPress;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 513);
            Controls.Add(txtMeses);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grpPagos);
            Controls.Add(chkEstudiante);
            Controls.Add(chkCasillero);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(cboTurno);
            Controls.Add(cboPlan);
            Controls.Add(lblPago);
            Controls.Add(lblMeses);
            Controls.Add(lblTurno);
            Controls.Add(lblPlanes);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            Load += frmInscripcion_Load;
            grpPagos.ResumeLayout(false);
            grpPagos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblPlanes;
        private Label lblTurno;
        private Label lblMeses;
        private Label lblPago;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private TextBox txtNombre;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private TextBox txtEdad;
        private CheckBox chkCasillero;
        private CheckBox chkEstudiante;
        private ComboBox cboCuotas;
        private GroupBox grpPagos;
        private Button btnCalcular;
        private Button btnLimpiar;
        private TextBox txtMeses;
    }
}
