namespace pryBenavidezGimnasio
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
            EstadoInicial();
        }
        private void EstadoInicial()
        {
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
            chkEstudiante.Checked = false;
            cboPlan.SelectedIndex = -1;
            cboTurno.SelectedIndex = -1;
            txtMeses.Text = string.Empty;
            chkCasillero.Checked = false;
            rbtEfectivo.Checked = false;
            rbtTarjeta.Checked = false;
            cboCuotas.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial(); 
        }
    }
}
