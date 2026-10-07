namespace pryBenavidezGimnasio
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
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            chkEstudiante = new CheckBox();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            txtMeses = new TextBox();
            chkCasillero = new CheckBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            cboCuotas = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            boxPago = new GroupBox();
            lblNombre = new Label();
            lblEdad = new Label();
            lblPlan = new Label();
            lblTurno = new Label();
            lblMeses = new Label();
            lblCuotas = new Label();
            lblPago = new Label();
            boxPago.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(87, 28);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(87, 57);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 1;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(87, 89);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(87, 114);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 3;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(87, 143);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 4;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(87, 172);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(100, 23);
            txtMeses.TabIndex = 5;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(87, 201);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 6;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(6, 13);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(6, 38);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(87, 292);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 23);
            cboCuotas.TabIndex = 8;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(48, 338);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(194, 338);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // boxPago
            // 
            boxPago.Controls.Add(rbtEfectivo);
            boxPago.Controls.Add(rbtTarjeta);
            boxPago.Location = new Point(87, 226);
            boxPago.Name = "boxPago";
            boxPago.Size = new Size(121, 60);
            boxPago.TabIndex = 7;
            boxPago.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(48, 60);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 14;
            lblEdad.Text = "Edad:";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(43, 117);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(33, 15);
            lblPlan.TabIndex = 15;
            lblPlan.Text = "Plan:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(43, 146);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(42, 15);
            lblTurno.TabIndex = 16;
            lblTurno.Text = "Turno:";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(43, 175);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(43, 15);
            lblMeses.TabIndex = 17;
            lblMeses.Text = "Meses:";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(34, 295);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(47, 15);
            lblCuotas.TabIndex = 18;
            lblCuotas.Text = "Cuotas:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(44, 239);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(37, 15);
            lblPago.TabIndex = 19;
            lblPago.Text = "Pago:";
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 394);
            Controls.Add(lblPago);
            Controls.Add(lblCuotas);
            Controls.Add(lblMeses);
            Controls.Add(lblTurno);
            Controls.Add(lblPlan);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(boxPago);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(cboCuotas);
            Controls.Add(chkCasillero);
            Controls.Add(txtMeses);
            Controls.Add(cboTurno);
            Controls.Add(cboPlan);
            Controls.Add(chkEstudiante);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            Load += frmInscripcion_Load;
            boxPago.ResumeLayout(false);
            boxPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEdad;
        private CheckBox chkEstudiante;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private TextBox txtMeses;
        private CheckBox chkCasillero;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private ComboBox cboCuotas;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox boxPago;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblPlan;
        private Label lblTurno;
        private Label lblMeses;
        private Label lblCuotas;
        private Label lblPago;
    }
}
