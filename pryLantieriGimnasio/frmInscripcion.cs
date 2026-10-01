using System.Reflection.Metadata.Ecma335;

namespace pryLantieriGimnasio
{
    public partial class frmInscripcion : Form
    {

        public frmInscripcion()
        {
            InitializeComponent();
            cboCuotas.Items.Add(1);
            cboCuotas.Items.Add(4);
            cboCuotas.Items.Add(6);
            cboTurno.Items.Add("Mañana");
            cboTurno.Items.Add("Tarde");
            cboTurno.Items.Add("Noche");
            cboPlan.Items.Add("Musculación");
            cboPlan.Items.Add("Natación");
            cboPlan.Items.Add("Funcional");
            const int MUSCULACION = 15000;
            const int FUNCIONAL = 18000;
            const int NATACION = 22000;
            const int CASILLERO = 3000;
        }
        string nombre, edad, planes, turno, meses, pagos;

        int Edad, Meses;


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

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Clear();
            cboTurno.SelectedIndex = -1;
            cboPlan.SelectedIndex = -1;
            rbtEfectivo.Checked = false;
            rbtTarjeta.Checked = false;
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;

        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }
    }
}