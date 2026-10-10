using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;

namespace pryLantieriGimnasio
{
    public partial class frmInscripcion : Form
    {
        const int MUSCULACION = 15000;
        const int FUNCIONAL = 18000;
        const int NATACION = 22000;
        const int CASILLERO = 3000;
        const decimal DESCUENTO_MENOR = 0.25m;
        const decimal DESCUENTO_MAYOR = 0.30m;
        const decimal DESCUENTO_ESTUDIANTE = 0.15m;
        const decimal DESCUENTO_PAGO = 0.10m;
        const decimal RECARGO_CUOTA3 = 0.10m;
        const decimal RECARGO_CUOTA6 = 0.30m;
        string nombre, edad, planes, turno, meses, pagos;
        decimal precio, descuento, recargo, total, descuento_pago;

        int Edad, Meses, Cuotas;


        public frmInscripcion()
        {
            InitializeComponent();

        }


        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }


        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

       


        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Clear();
            txtMeses.Text = "1";
            cboTurno.SelectedIndex = 0;
            cboPlan.SelectedIndex = 0;
            cboCuotas.SelectedIndex = -1;
            rbtEfectivo.Checked = true;
            rbtTarjeta.Checked = false;
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
            Edad = 0;
            Meses = 0;
            total = 0;
            precio = 0;
            descuento = 0;
            descuento_pago = 0;
            recargo = 0;

        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {

            cboCuotas.Items.Add(1);
            cboCuotas.Items.Add(3);
            cboCuotas.Items.Add(6);
            cboTurno.Items.Add("Mañana");
            cboTurno.Items.Add("Tarde");
            cboTurno.Items.Add("Noche");
            cboPlan.Items.Add("Musculación");
            cboPlan.Items.Add("Natación");
            cboPlan.Items.Add("Funcional");
            EstadoInicial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            if (txtNombre.Text != "")
            {
                txtEdad.Enabled = true;

            }
            else
            {
                txtEdad.Enabled = false;
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            edad = txtEdad.Text;
            if (txtEdad.Text != "")
            {
                cboPlan.Enabled = true;
                Edad = Convert.ToInt32(txtEdad.Text);
            }
            else
            {
                cboPlan.Enabled = false;
            }
        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            planes = cboPlan.Text;

            if (cboPlan.Text != "")
            {
                cboTurno.Enabled = true;
            }
            else
            {
                cboTurno.Enabled = false;
            }
        }

        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTurno.Text != "")
            {
                txtMeses.Enabled = true;
            }
            else
            {
                txtMeses.Enabled = false;
            }
        }

        private void cboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCuotas.Text != "")
            {
                Cuotas = Convert.ToInt32(cboCuotas.Text);
            }
            else
            {
                Cuotas = 0;
            }
        }

        private void cboPlan_Click(object sender, EventArgs e)
        {
            if (Edad < 18)
            {
                edad = "Menor";
                if (Edad <= 14)
                {
                    MessageBox.Show("No se puede inscribir a menores de 14 años");
                    cboPlan.Enabled = false;
                    txtEdad.Focus();
                    txtEdad.Clear();
                }
            }
            else
            {
                if (Edad >= 65)
                {
                    edad = "Mayor";
                }
            }
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            pagos = "Tarjeta";

            if (rbtTarjeta.Checked == true)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
                pagos = "Efectivo";
            }
        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {
            if (txtMeses.Text != "")
            {
                Meses = Convert.ToInt32(txtMeses.Text);
                if (Meses > 12)
                {
                    MessageBox.Show("No se puede inscribir por más de 12 meses");
                    txtMeses.Clear();
                    txtMeses.Focus();
                }


            }
            if (txtMeses.Text != "" && txtEdad.Text != "" && txtNombre.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }
        public struct SOCIO
        {
            public string nombre;
            public string edad;

            public string plan;

            public string meses;
            public string estudiante;
            public string casillero;

            public string formaDePago;
            public decimal total;
            public decimal valorDeCuota;

            
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            precio = 0;
            
            switch (planes)
            {
                case "Musculación":

                    if (chkCasillero.Checked == true)
                    {
                        precio = precio + (MUSCULACION + CASILLERO) * Meses;
                    }
                    else
                    {
                        precio = precio + (MUSCULACION * Meses);
                    }
                    break;
                case "Funcional":
                    if (chkCasillero.Checked == true)
                    {
                        precio = precio + (FUNCIONAL + CASILLERO) * Meses;
                    }
                    else
                    {
                        precio = precio + (FUNCIONAL * Meses);
                    }
                    break;
                case "Natación":
                    if (chkCasillero.Checked == true)
                    {
                        precio = precio + (NATACION + CASILLERO) * Meses;
                    }
                    else
                    {
                        precio = precio + (NATACION * Meses);
                    }
                    break;
            }
            int edad = int.Parse(txtEdad.Text);

            switch (edad)
            {
                case >= 18: // Supongamos que mayor es 18 o más
                    descuento = precio * DESCUENTO_MAYOR;
                    precio = precio - descuento;
                    break;

                case >= 15: // Entre 15 y 17
                    descuento = precio * DESCUENTO_MENOR;
                    precio = precio - descuento;
                    break;

                default: // Menores de 15
                    if (chkEstudiante.Checked == true)
                    {
                        descuento = precio * DESCUENTO_ESTUDIANTE;
                        precio = precio - descuento;
                    }
                    break;
            }

            if (rbtEfectivo.Checked)
            {
                descuento_pago = precio * DESCUENTO_PAGO;
                precio = precio - descuento_pago;
            }
            else if (pagos == "Tarjeta" && Cuotas == 3)
            {
                recargo = precio * RECARGO_CUOTA3;
                precio = precio + recargo;
            }
            else if (pagos == "Tarjeta" && Cuotas == 6)
            {
                recargo = precio * RECARGO_CUOTA6;
                precio = precio + recargo;
            }

            
            MessageBox.Show("El total a pagar es: " + precio);

            SOCIO socio = new SOCIO();
            socio.nombre = txtNombre.Text;
            socio.edad = txtEdad.Text;
            socio.plan = cboPlan.Text;
            socio.meses = txtMeses.Text;
            if (chkEstudiante.Checked)
            {
                socio.estudiante = "Si";
            }
            else
            {
                socio.estudiante = "No";
            }

            if (chkCasillero.Checked)
            {
                socio.casillero = "Si";
            }
            else
            {
                socio.casillero = "No";
            }


            MessageBox.Show(
                "Socio: " + socio.nombre +
                "\nEdad: " + socio.edad +
                "\nPlan: " + socio.plan +
                "\nMeses: " + socio.meses +
                "\nEstudiante: " + socio.estudiante +
                "\nCasillero: " + socio.casillero +
                "\nForma de pago: " + socio.formaDePago +
                "\nTotal: " + socio.total.ToString("C2") +
                "\nValor de cuota: " + socio.valorDeCuota.ToString("C2"),
                "Inscripción al gimnasio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            EstadoInicial();
        }
    }
}