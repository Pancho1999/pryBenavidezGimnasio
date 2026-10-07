namespace pryBenavidezGimnasio
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }
        private void EstadoInicial()
        {
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
            chkEstudiante.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            txtMeses.Text = "1";
            chkCasillero.Checked = false;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }
    }
}
