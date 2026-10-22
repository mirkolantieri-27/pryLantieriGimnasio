using System.Globalization;

namespace pryLantieriGimnasioSP2SP3;

public partial class frmInscripcion : Form
{
    private const decimal PRECIO_MUSCULACION = 15000m;
    private const decimal PRECIO_FUNCIONAL = 18000m;
    private const decimal PRECIO_NATACION = 22000m;
    private const decimal PRECIO_CASILLERO = 3000m;
    private const decimal PRECIO_PASE_LIBRE = 30000m;
    private const int EDAD_MINIMA = 14;
    private const int MESES_MINIMOS = 1;
    private const int MESES_MAXIMOS = 12;
    private const int EDAD_MENOR = 18;
    private const int EDAD_MAYOR = 65;
    private const decimal DESCUENTO_MENOR = 0.25m;
    private const decimal DESCUENTO_MAYOR = 0.30m;
    private const decimal DESCUENTO_ESTUDIANTE = 0.15m;
    private const decimal DESCUENTO_EFECTIVO = 0.10m;
    private const decimal RECARGO_TRES_CUOTAS = 0.10m;
    private const decimal RECARGO_SEIS_CUOTAS = 0.20m;

    public frmInscripcion()
    {
        InitializeComponent();
        txtNombre.KeyPress += txtNombre_KeyPress;
        txtNombre.TextChanged += Datos_TextChanged;
        txtEdad.KeyPress += Numerico_KeyPress;
        txtEdad.TextChanged += Datos_TextChanged;
        txtMeses.KeyPress += Numerico_KeyPress;
        txtMeses.TextChanged += Datos_TextChanged;
        rbtEfectivo.CheckedChanged += rbtPago_CheckedChanged;
        rbtTarjeta.CheckedChanged += rbtPago_CheckedChanged;
        btnCalcular.Click += btnCalcular_Click;
        btnLimpiar.Click += btnLimpiar_Click;
        EstadoInicial();
    }

    private void EstadoInicial()
    {
        txtNombre.Clear();
        txtEdad.Clear();
        txtMeses.Text = MESES_MINIMOS.ToString(CultureInfo.InvariantCulture);
        cboPlan.SelectedIndex = 0;
        cboTurno.SelectedIndex = 0;
        cboCuotas.SelectedIndex = -1;
        chkEstudiante.Checked = false;
        chkCasillero.Checked = false;
        chkPaseLibre.Checked = false;
        rbtEfectivo.Checked = true;
        rbtTarjeta.Checked = false;
        cboCuotas.Enabled = false;
        btnCalcular.Enabled = false;
        txtNombre.Focus();
    }

    private void Numerico_KeyPress(object? sender, KeyPressEventArgs e)
    {
        e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
    }

    private void txtNombre_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (char.IsLower(e.KeyChar))
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }

    private void Datos_TextChanged(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtEdad.Text) ||
            string.IsNullOrWhiteSpace(txtMeses.Text))
        {
            btnCalcular.Enabled = false;
        }
        else
        {
            btnCalcular.Enabled = true;
        }
    }

    private void rbtPago_CheckedChanged(object? sender, EventArgs e)
    {
        if (rbtTarjeta.Checked)
        {
            cboCuotas.Enabled = true;
            cboCuotas.SelectedIndex = 0;
        }
        else
        {
            cboCuotas.Enabled = false;
            cboCuotas.SelectedIndex = -1;
        }
    }

    private void btnLimpiar_Click(object? sender, EventArgs e)
    {
        EstadoInicial();
    }

    private void btnCalcular_Click(object? sender, EventArgs e)
    {
        if (!int.TryParse(txtEdad.Text, out int edad) || !int.TryParse(txtMeses.Text, out int meses))
        {
            return;
        }

        if (edad < EDAD_MINIMA)
        {
            MessageBox.Show("La edad mínima para inscribirse es de 14 años.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (meses < MESES_MINIMOS || meses > MESES_MAXIMOS)
        {
            MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        CalcularSocio(edad, meses);
    }

    private void CalcularSocio(int edad, int meses)
    {
        string nombre = txtNombre.Text.Trim();
        string plan = cboPlan.Text;
        decimal precioMensual;

        switch (plan)
        {
            case "Musculación":
                precioMensual = PRECIO_MUSCULACION;
                break;
            case "Funcional":
                precioMensual = PRECIO_FUNCIONAL;
                break;
            case "Natación":
                precioMensual = PRECIO_NATACION;
                break;
            default:
                MessageBox.Show("El plan seleccionado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
        }

        if (chkPaseLibre.Checked)
        {
            precioMensual = PRECIO_PASE_LIBRE;
        }

        if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;
        decimal subtotal = precioMensual * meses;
        decimal porcentajeDescuento;

        if (edad < EDAD_MENOR)
        {
            porcentajeDescuento = DESCUENTO_MENOR;
        }
        else
        {
            if (edad >= EDAD_MAYOR)
            {
                porcentajeDescuento = DESCUENTO_MAYOR;
            }
            else
            {
                porcentajeDescuento = chkEstudiante.Checked ? DESCUENTO_ESTUDIANTE : 0m;
            }
        }

        decimal importeConDescuento = subtotal * (1m - porcentajeDescuento);
        decimal porcentajeAjuste;
        int cuotas = 1;

        if (rbtEfectivo.Checked)
        {
            porcentajeAjuste = -DESCUENTO_EFECTIVO;
        }
        else
        {
            cuotas = int.Parse(cboCuotas.Text, CultureInfo.InvariantCulture);
            if (cuotas == 1)
            {
                porcentajeAjuste = 0m;
            }
            else if (cuotas == 3)
            {
                porcentajeAjuste = RECARGO_TRES_CUOTAS;
            }
            else
            {
                porcentajeAjuste = RECARGO_SEIS_CUOTAS;
            }
        }

        decimal total = importeConDescuento * (1m + porcentajeAjuste);
        string horario;
        switch (cboTurno.SelectedIndex)
        {
            case 0:
                horario = "Mañana (7 a 12 h)";
                break;
            case 1:
                horario = "Tarde (14 a 18 h)";
                break;
            case 2:
                horario = "Noche (18 a 23 h)";
                break;
            default:
                horario = "Sin turno";
                break;
        }

        string categoria = edad < EDAD_MENOR ? "Menor" : "Mayor";
        string formaPago = rbtEfectivo.Checked ? "Efectivo" : $"Tarjeta en {cuotas} cuotas";
        decimal valorCuota = rbtEfectivo.Checked ? total : total / cuotas;
        SOCIO socio = new()
        {
            Nombre = nombre,
            Edad = edad,
            Categoria = categoria,
            Plan = plan,
            Horario = horario,
            Meses = meses,
            FormaPago = formaPago,
            Total = total,
            ValorCuota = valorCuota
        };

        string moneda(decimal importe) => importe.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
        string resumen = $"Socio: {socio.Nombre}\n" +
                         $"Edad: {socio.Edad} ({socio.Categoria})\n" +
                         $"Plan: {socio.Plan}\n" +
                         $"Horario: {socio.Horario}\n" +
                         $"Meses: {socio.Meses}\n" +
                         $"Forma de pago: {socio.FormaPago}\n" +
                         $"Subtotal: {moneda(subtotal)}\n" +
                         $"Descuento/ajuste: {porcentajeDescuento:P0} / {porcentajeAjuste:P0}\n" +
                         $"Total: {moneda(socio.Total)}\n" +
                         $"Valor de cuota: {moneda(socio.ValorCuota)}";

        MessageBox.Show(resumen, "Gimnasio Siglo XXI — Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
        EstadoInicial();
    }

    private struct SOCIO
    {
        public string Nombre;
        public int Edad;
        public string Categoria;
        public string Plan;
        public string Horario;
        public int Meses;
        public string FormaPago;
        public decimal Total;
        public decimal ValorCuota;
    }
}
