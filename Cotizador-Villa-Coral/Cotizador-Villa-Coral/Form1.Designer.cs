namespace Cotizador_Villa_Coral
{
    partial class Form1
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
            lblHuesped = new Label();
            lblTarifa = new Label();
            lblNoches = new Label();
            cbTemporada = new CheckBox();
            nudNoches = new NumericUpDown();
            txtbTarifa = new TextBox();
            txtbHuesped = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gbCotizacion = new GroupBox();
            lblTOTALn = new Label();
            lblServicioN = new Label();
            lblITBISn = new Label();
            lblDescuentoN = new Label();
            lblSubtotalN = new Label();
            lblTOTAL = new Label();
            lblSubTotal = new Label();
            lblDescuento = new Label();
            lblITBIS = new Label();
            lblServicio = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(42, 48);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(68, 20);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(42, 167);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(165, 20);
            lblTarifa.TabIndex = 1;
            lblTarifa.Text = "Tarifa por noches (USD)";
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(42, 106);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(58, 20);
            lblNoches.TabIndex = 2;
            lblNoches.Text = "Noches";
            lblNoches.Click += label3_Click;
            // 
            // cbTemporada
            // 
            cbTemporada.AutoSize = true;
            cbTemporada.Location = new Point(42, 220);
            cbTemporada.Name = "cbTemporada";
            cbTemporada.Size = new Size(190, 24);
            cbTemporada.TabIndex = 3;
            cbTemporada.Text = "Temporada Alta (+25%)";
            cbTemporada.UseVisualStyleBackColor = true;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(299, 106);
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(150, 27);
            nudNoches.TabIndex = 4;
            // 
            // txtbTarifa
            // 
            txtbTarifa.Location = new Point(299, 164);
            txtbTarifa.Name = "txtbTarifa";
            txtbTarifa.Size = new Size(125, 27);
            txtbTarifa.TabIndex = 5;
            // 
            // txtbHuesped
            // 
            txtbHuesped.Location = new Point(299, 48);
            txtbHuesped.Name = "txtbHuesped";
            txtbHuesped.Size = new Size(125, 27);
            txtbHuesped.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(42, 274);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(190, 274);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gbCotizacion
            // 
            gbCotizacion.Controls.Add(lblTOTALn);
            gbCotizacion.Controls.Add(lblServicioN);
            gbCotizacion.Controls.Add(lblITBISn);
            gbCotizacion.Controls.Add(lblDescuentoN);
            gbCotizacion.Controls.Add(lblSubtotalN);
            gbCotizacion.Controls.Add(lblTOTAL);
            gbCotizacion.Controls.Add(lblSubTotal);
            gbCotizacion.Controls.Add(lblDescuento);
            gbCotizacion.Controls.Add(lblITBIS);
            gbCotizacion.Controls.Add(lblServicio);
            gbCotizacion.Location = new Point(42, 326);
            gbCotizacion.Name = "gbCotizacion";
            gbCotizacion.Size = new Size(461, 226);
            gbCotizacion.TabIndex = 9;
            gbCotizacion.TabStop = false;
            gbCotizacion.Text = "Cotizacion";
            gbCotizacion.Enter += groupBox1_Enter;
            // 
            // lblTOTALn
            // 
            lblTOTALn.AutoSize = true;
            lblTOTALn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTOTALn.Location = new Point(332, 185);
            lblTOTALn.Name = "lblTOTALn";
            lblTOTALn.Size = new Size(47, 25);
            lblTOTALn.TabIndex = 19;
            lblTOTALn.Text = "0.00";
            // 
            // lblServicioN
            // 
            lblServicioN.AutoSize = true;
            lblServicioN.Location = new Point(332, 147);
            lblServicioN.Name = "lblServicioN";
            lblServicioN.Size = new Size(36, 20);
            lblServicioN.TabIndex = 18;
            lblServicioN.Text = "0.00";
            // 
            // lblITBISn
            // 
            lblITBISn.AutoSize = true;
            lblITBISn.Location = new Point(332, 113);
            lblITBISn.Name = "lblITBISn";
            lblITBISn.Size = new Size(36, 20);
            lblITBISn.TabIndex = 17;
            lblITBISn.Text = "0.00";
            // 
            // lblDescuentoN
            // 
            lblDescuentoN.AutoSize = true;
            lblDescuentoN.Location = new Point(332, 75);
            lblDescuentoN.Name = "lblDescuentoN";
            lblDescuentoN.Size = new Size(36, 20);
            lblDescuentoN.TabIndex = 16;
            lblDescuentoN.Text = "0.00";
            // 
            // lblSubtotalN
            // 
            lblSubtotalN.AutoSize = true;
            lblSubtotalN.Location = new Point(332, 41);
            lblSubtotalN.Name = "lblSubtotalN";
            lblSubtotalN.Size = new Size(36, 20);
            lblSubtotalN.TabIndex = 15;
            lblSubtotalN.Text = "0.00";
            // 
            // lblTOTAL
            // 
            lblTOTAL.AutoSize = true;
            lblTOTAL.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTOTAL.Location = new Point(15, 185);
            lblTOTAL.Name = "lblTOTAL";
            lblTOTAL.Size = new Size(67, 25);
            lblTOTAL.TabIndex = 14;
            lblTOTAL.Text = "TOTAL";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(15, 41);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(67, 20);
            lblSubTotal.TabIndex = 10;
            lblSubTotal.Text = "SubTotal";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(15, 75);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 11;
            lblDescuento.Text = "Descuento";
            // 
            // lblITBIS
            // 
            lblITBIS.AutoSize = true;
            lblITBIS.Location = new Point(15, 113);
            lblITBIS.Name = "lblITBIS";
            lblITBIS.Size = new Size(74, 20);
            lblITBIS.TabIndex = 12;
            lblITBIS.Text = "ITBIS 18%";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(15, 147);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(93, 20);
            lblServicio.TabIndex = 13;
            lblServicio.Text = "Servicio 10%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 554);
            Controls.Add(gbCotizacion);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtbHuesped);
            Controls.Add(txtbTarifa);
            Controls.Add(nudNoches);
            Controls.Add(cbTemporada);
            Controls.Add(lblNoches);
            Controls.Add(lblTarifa);
            Controls.Add(lblHuesped);
            Name = "Form1";
            Text = "Cotizador Villa coral - Eudy Acosta 2026-0581";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbCotizacion.ResumeLayout(false);
            gbCotizacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHuesped;
        private Label lblTarifa;
        private Label lblNoches;
        private CheckBox cbTemporada;
        private NumericUpDown nudNoches;
        private TextBox txtbTarifa;
        private TextBox txtbHuesped;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox gbCotizacion;
        private Label lblSubtotalN;
        private Label lblTOTAL;
        private Label lblSubTotal;
        private Label lblDescuento;
        private Label lblITBIS;
        private Label lblServicio;
        private Label lblTOTALn;
        private Label lblServicioN;
        private Label lblITBISn;
        private Label lblDescuentoN;
    }
}
