namespace pryBenavidezGimnasio
{
    public partial class frmInscripcion : Form
    {
        const decimal PRECIO_MUSCULACION = 15000.00m;
        const decimal PRECIO_FUNCIONAL = 18000.00m;
        const decimal PRECIO_NATACION = 22000.00m;
        const int EDAD_MINIMA = 14;
        const decimal PRECIO_CASILLERO = 3000.00m;
        const decimal PORCENTAJE_RECARGO_6_CUOTAS = 0.20m;
        public struct SOCIO
        {
            public string nombre;
            public int edad;
            public string categoria;
            public string plan;
            public string horario;
            public int meses;
            public string formaDePago;
            public decimal total;
            public decimal valorCuota;
        }
        public frmInscripcion()
        {
            InitializeComponent();
        }
        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtEdad.Text) &&
                !string.IsNullOrWhiteSpace(txtMeses.Text))
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }
        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
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
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidadCuotas = 1;
            decimal subtotal = 0m;
            decimal descuento = 0m;
            decimal total = 0m;

            string nombreIngresado = txtNombre.Text;
            int edadIngresada = int.Parse(txtEdad.Text);
            int cantidadMeses = int.Parse(txtMeses.Text);

            if (edadIngresada < EDAD_MINIMA)
            {
                MessageBox.Show($"La edad ingresada debe ser mayor o igual a la edad mínima permitida ({EDAD_MINIMA} años).",
                                "Edad insuficiente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            if (cantidadMeses < 1 || cantidadMeses > 12)
            {
                MessageBox.Show("La cantidad de meses debe ser un valor entre 1 y 12.",
                                "Cantidad de meses no válida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            decimal precioMensual = 0m;
            string planElegido = cboPlan.Text;

            switch (planElegido)
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
                    MessageBox.Show("Por favor, seleccione un plan válido de la lista.",
                                    "Plan Inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    return;
            }

            int indiceTurno = cboTurno.SelectedIndex;
            string horarioTurno = "";

            switch (indiceTurno)
            {
                case 0:
                    horarioTurno = "Mañana";
                    break;

                case 1:
                    horarioTurno = "Tarde";
                    break;

                case 2:
                    horarioTurno = "Noche";
                    break;

                default:
                    MessageBox.Show("Por favor, seleccione un turno válido de la lista.",
                                    "Turno Inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    return;
            }

            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;
            subtotal = precioMensual * cantidadMeses;

            decimal porcentajeDescuento = 0m;

            if (edadIngresada < 18)
            {
                porcentajeDescuento = 0.25m;
            }
            else
            {
                if (edadIngresada >= 65)
                {
                    porcentajeDescuento = 0.30m;
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        porcentajeDescuento = 0.15m;
                    }
                    else
                    {
                        porcentajeDescuento = 0.00m;
                    }
                }
            }
            descuento = subtotal * porcentajeDescuento;

            decimal porcentajeAjustePago = 0m;

            if (rbtEfectivo.Checked)
            {
                porcentajeAjustePago = -0.10m;
            }
            else
            {
                cantidadCuotas = int.Parse(cboCuotas.Text);

                if (cantidadCuotas == 1)
                {
                    porcentajeAjustePago = 0.00m;
                }
                else if (cantidadCuotas == 3)
                {
                    porcentajeAjustePago = 0.10m;
                }
                else if (cantidadCuotas == 6)
                {
                    porcentajeAjustePago = PORCENTAJE_RECARGO_6_CUOTAS;
                }
            }
            decimal montoConDescuento = subtotal - descuento;
            decimal montoAjuste = montoConDescuento * porcentajeAjustePago;

            total = montoConDescuento + montoAjuste;

            string categoriaSocio = (edadIngresada < 18) ? "Menor" : "Mayor";
            string textoPago = rbtEfectivo.Checked ? "Efectivo" : $"Tarjeta en {cantidadCuotas} cuotas";
            decimal valorCuota = rbtEfectivo.Checked ? total : (total / cantidadCuotas);

            SOCIO datosSocio = new SOCIO();
            datosSocio.nombre = txtNombre.Text;
            datosSocio.edad = edadIngresada;
            datosSocio.categoria = categoriaSocio;
            datosSocio.plan = cboPlan.Text;
            datosSocio.horario = horarioTurno;
            datosSocio.meses = cantidadMeses;
            datosSocio.formaDePago = textoPago;
            datosSocio.total = total;
            datosSocio.valorCuota = valorCuota;

            string resumen = $"--- RESUMEN DE INSCRIPCIÓN ---\n\n" +
                 $"Nombre: {datosSocio.nombre}\n" +
                 $"Edad: {datosSocio.edad} años ({datosSocio.categoria})\n" +
                 $"Plan: {datosSocio.plan}\n" +
                 $"Horario: {datosSocio.horario}\n" +
                 $"Tiempo: {datosSocio.meses} mes(es)\n" +
                 $"Forma de pago: {datosSocio.formaDePago}\n\n" +
                 $"Importe Total: {datosSocio.total:C2}\n" +
                 $"Valor de Cuota: {datosSocio.valorCuota:C2}";

            MessageBox.Show(resumen,
                "Resumen de Inscripción del Socio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            EstadoInicial();
        }
    }
}
