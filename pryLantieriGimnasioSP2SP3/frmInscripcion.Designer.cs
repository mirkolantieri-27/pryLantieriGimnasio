namespace pryLantieriGimnasioSP2SP3;

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
        components = new System.ComponentModel.Container();
        var fuente = new Font("Segoe UI", 10F);
        grpDatos = new GroupBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblEdad = new Label();
        txtEdad = new TextBox();
        chkEstudiante = new CheckBox();
        grpPlan = new GroupBox();
        lblPlan = new Label();
        cboPlan = new ComboBox();
        lblTurno = new Label();
        cboTurno = new ComboBox();
        lblMeses = new Label();
        txtMeses = new TextBox();
        chkCasillero = new CheckBox();
        chkPaseLibre = new CheckBox();
        grpPago = new GroupBox();
        rbtEfectivo = new RadioButton();
        rbtTarjeta = new RadioButton();
        lblCuotas = new Label();
        cboCuotas = new ComboBox();
        btnCalcular = new Button();
        btnLimpiar = new Button();
        SuspendLayout();

        grpDatos.Text = "Datos personales";
        grpDatos.Font = fuente;
        grpDatos.Location = new Point(20, 20);
        grpDatos.Size = new Size(360, 155);
        lblNombre.AutoSize = true; lblNombre.Location = new Point(18, 35); lblNombre.Text = "Nombre:";
        txtNombre.Location = new Point(125, 31); txtNombre.MaxLength = 30; txtNombre.Size = new Size(210, 25);
        lblEdad.AutoSize = true; lblEdad.Location = new Point(18, 75); lblEdad.Text = "Edad:";
        txtEdad.Location = new Point(125, 71); txtEdad.MaxLength = 3; txtEdad.Size = new Size(70, 25);
        chkEstudiante.AutoSize = true; chkEstudiante.Location = new Point(125, 110); chkEstudiante.Text = "Estudiante";
        grpDatos.Controls.AddRange(new Control[] { lblNombre, txtNombre, lblEdad, txtEdad, chkEstudiante });

        grpPlan.Text = "Plan";
        grpPlan.Font = fuente;
        grpPlan.Location = new Point(20, 190);
        grpPlan.Size = new Size(360, 225);
        lblPlan.AutoSize = true; lblPlan.Location = new Point(18, 35); lblPlan.Text = "Plan:";
        cboPlan.DropDownStyle = ComboBoxStyle.DropDownList; cboPlan.Location = new Point(125, 31); cboPlan.Size = new Size(210, 25);
        cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
        lblTurno.AutoSize = true; lblTurno.Location = new Point(18, 75); lblTurno.Text = "Turno:";
        cboTurno.DropDownStyle = ComboBoxStyle.DropDownList; cboTurno.Location = new Point(125, 71); cboTurno.Size = new Size(210, 25);
        cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
        lblMeses.AutoSize = true; lblMeses.Location = new Point(18, 115); lblMeses.Text = "Meses:";
        txtMeses.Location = new Point(125, 111); txtMeses.MaxLength = 2; txtMeses.Size = new Size(70, 25);
        chkCasillero.AutoSize = true; chkCasillero.Location = new Point(125, 150); chkCasillero.Text = "Casillero ($ 3.000/mes)";
        chkPaseLibre.AutoSize = true; chkPaseLibre.Location = new Point(125, 180); chkPaseLibre.Text = "Pase libre ($ 30.000/mes)";
        grpPlan.Controls.AddRange(new Control[] { lblPlan, cboPlan, lblTurno, cboTurno, lblMeses, txtMeses, chkCasillero, chkPaseLibre });

        grpPago.Text = "Forma de pago";
        grpPago.Font = fuente;
        grpPago.Location = new Point(410, 20);
        grpPago.Size = new Size(280, 155);
        rbtEfectivo.AutoSize = true; rbtEfectivo.Location = new Point(20, 35); rbtEfectivo.Text = "Efectivo";
        rbtTarjeta.AutoSize = true; rbtTarjeta.Location = new Point(20, 70); rbtTarjeta.Text = "Tarjeta";
        lblCuotas.AutoSize = true; lblCuotas.Location = new Point(20, 110); lblCuotas.Text = "Cuotas:";
        cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList; cboCuotas.Enabled = false; cboCuotas.Location = new Point(100, 106); cboCuotas.Size = new Size(90, 25);
        cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
        grpPago.Controls.AddRange(new Control[] { rbtEfectivo, rbtTarjeta, lblCuotas, cboCuotas });

        btnCalcular.Enabled = false; btnCalcular.Location = new Point(410, 205); btnCalcular.Size = new Size(130, 40); btnCalcular.Text = "&Calcular";
        btnLimpiar.Location = new Point(560, 205); btnLimpiar.Size = new Size(130, 40); btnLimpiar.Text = "&Limpiar";

        AcceptButton = btnCalcular;
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(720, 445);
        Controls.AddRange(new Control[] { grpDatos, grpPlan, grpPago, btnCalcular, btnLimpiar });
        Font = fuente;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "frmInscripcion";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gimnasio Siglo XXI — Inscripción";
        ResumeLayout(false);
    }

    private GroupBox grpDatos, grpPlan, grpPago;
    private Label lblNombre, lblEdad, lblPlan, lblTurno, lblMeses, lblCuotas;
    private TextBox txtNombre, txtEdad, txtMeses;
    private CheckBox chkEstudiante, chkCasillero, chkPaseLibre;
    private ComboBox cboPlan, cboTurno, cboCuotas;
    private RadioButton rbtEfectivo, rbtTarjeta;
    private Button btnCalcular, btnLimpiar;

    #endregion
}
