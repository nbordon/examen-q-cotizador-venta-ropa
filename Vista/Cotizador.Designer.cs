namespace Vista
{
    partial class Cotizador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblHistorialCotizaciones = new System.Windows.Forms.LinkLabel();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.grpPrecioCantidad = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCalidad = new System.Windows.Forms.GroupBox();
            this.radPremium = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPrenda = new System.Windows.Forms.GroupBox();
            this.chkChupin = new System.Windows.Forms.CheckBox();
            this.chkCuelloMao = new System.Windows.Forms.CheckBox();
            this.chkMarngaCorta = new System.Windows.Forms.CheckBox();
            this.radPantalon = new System.Windows.Forms.RadioButton();
            this.radCamisa = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpPrecioCantidad.SuspendLayout();
            this.grpCalidad.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpPrenda.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.grpPrecioCantidad);
            this.panel1.Controls.Add(this.grpCalidad);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.grpPrenda);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 524);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtCotizacion);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.btnCotizar);
            this.panel6.Location = new System.Drawing.Point(-1, 412);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(510, 111);
            this.panel6.TabIndex = 12;
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacion.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtCotizacion.Location = new System.Drawing.Point(264, 42);
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.ReadOnly = true;
            this.txtCotizacion.Size = new System.Drawing.Size(170, 29);
            this.txtCotizacion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "$";
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.Color.White;
            this.btnCotizar.Location = new System.Drawing.Point(74, 28);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(141, 51);
            this.btnCotizar.TabIndex = 9;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblHistorialCotizaciones);
            this.panel5.Controls.Add(this.lblNombreVendedor);
            this.panel5.Location = new System.Drawing.Point(-1, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(510, 52);
            this.panel5.TabIndex = 11;
            // 
            // lblHistorialCotizaciones
            // 
            this.lblHistorialCotizaciones.AutoSize = true;
            this.lblHistorialCotizaciones.Location = new System.Drawing.Point(372, 19);
            this.lblHistorialCotizaciones.Name = "lblHistorialCotizaciones";
            this.lblHistorialCotizaciones.Size = new System.Drawing.Size(107, 13);
            this.lblHistorialCotizaciones.TabIndex = 4;
            this.lblHistorialCotizaciones.TabStop = true;
            this.lblHistorialCotizaciones.Text = "Historial Cotizaciones";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNombreVendedor.Location = new System.Drawing.Point(11, 19);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(134, 13);
            this.lblNombreVendedor.TabIndex = 3;
            this.lblNombreVendedor.Text = "Nombre Vendedor | Codigo";
            this.lblNombreVendedor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblDireccionTienda);
            this.panel4.Controls.Add(this.lblNombreTienda);
            this.panel4.Location = new System.Drawing.Point(-1, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(510, 49);
            this.panel4.TabIndex = 10;
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionTienda.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblDireccionTienda.Location = new System.Drawing.Point(365, 17);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(126, 16);
            this.lblDireccionTienda.TabIndex = 2;
            this.lblDireccionTienda.Text = "Direccion Tienda";
            this.lblDireccionTienda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTienda.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblNombreTienda.Location = new System.Drawing.Point(13, 17);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(115, 16);
            this.lblNombreTienda.TabIndex = 1;
            this.lblNombreTienda.Text = "Nombre Tienda";
            // 
            // grpPrecioCantidad
            // 
            this.grpPrecioCantidad.Controls.Add(this.txtCantidad);
            this.grpPrecioCantidad.Controls.Add(this.label4);
            this.grpPrecioCantidad.Controls.Add(this.txtPrecioUnitario);
            this.grpPrecioCantidad.Controls.Add(this.label3);
            this.grpPrecioCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrecioCantidad.Location = new System.Drawing.Point(259, 339);
            this.grpPrecioCantidad.Name = "grpPrecioCantidad";
            this.grpPrecioCantidad.Size = new System.Drawing.Size(232, 58);
            this.grpPrecioCantidad.TabIndex = 8;
            this.grpPrecioCantidad.TabStop = false;
            this.grpPrecioCantidad.Text = "Precio Unitario y Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(163, 20);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(63, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(26, 20);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(63, 22);
            this.txtPrecioUnitario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "$";
            // 
            // grpCalidad
            // 
            this.grpCalidad.Controls.Add(this.radPremium);
            this.grpCalidad.Controls.Add(this.radStandard);
            this.grpCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCalidad.Location = new System.Drawing.Point(41, 339);
            this.grpCalidad.Name = "grpCalidad";
            this.grpCalidad.Size = new System.Drawing.Size(212, 58);
            this.grpCalidad.TabIndex = 7;
            this.grpCalidad.TabStop = false;
            this.grpCalidad.Text = "Calidad de Prenda";
            // 
            // radPremium
            // 
            this.radPremium.AutoSize = true;
            this.radPremium.Location = new System.Drawing.Point(109, 21);
            this.radPremium.Name = "radPremium";
            this.radPremium.Size = new System.Drawing.Size(78, 20);
            this.radPremium.TabIndex = 6;
            this.radPremium.TabStop = true;
            this.radPremium.Text = "Premium";
            this.radPremium.UseVisualStyleBackColor = true;
            this.radPremium.CheckedChanged += new System.EventHandler(this.radPremium_CheckedChanged);
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(16, 21);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(80, 20);
            this.radStandard.TabIndex = 5;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.CheckedChanged += new System.EventHandler(this.radStandard_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtStock);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(41, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 35);
            this.panel3.TabIndex = 6;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(167, 7);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unidades Disponibles";
            // 
            // grpPrenda
            // 
            this.grpPrenda.Controls.Add(this.chkChupin);
            this.grpPrenda.Controls.Add(this.chkCuelloMao);
            this.grpPrenda.Controls.Add(this.chkMarngaCorta);
            this.grpPrenda.Controls.Add(this.radPantalon);
            this.grpPrenda.Controls.Add(this.radCamisa);
            this.grpPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrenda.Location = new System.Drawing.Point(41, 181);
            this.grpPrenda.Name = "grpPrenda";
            this.grpPrenda.Size = new System.Drawing.Size(450, 116);
            this.grpPrenda.TabIndex = 5;
            this.grpPrenda.TabStop = false;
            this.grpPrenda.Text = "Prenda";
            // 
            // chkChupin
            // 
            this.chkChupin.AutoSize = true;
            this.chkChupin.Location = new System.Drawing.Point(190, 70);
            this.chkChupin.Name = "chkChupin";
            this.chkChupin.Size = new System.Drawing.Size(67, 20);
            this.chkChupin.TabIndex = 4;
            this.chkChupin.Text = "Chupín";
            this.chkChupin.UseVisualStyleBackColor = true;
            this.chkChupin.CheckedChanged += new System.EventHandler(this.chkChupin_CheckedChanged);
            // 
            // chkCuelloMao
            // 
            this.chkCuelloMao.AutoSize = true;
            this.chkCuelloMao.Location = new System.Drawing.Point(316, 34);
            this.chkCuelloMao.Name = "chkCuelloMao";
            this.chkCuelloMao.Size = new System.Drawing.Size(94, 20);
            this.chkCuelloMao.TabIndex = 3;
            this.chkCuelloMao.Text = "Cuello Mao";
            this.chkCuelloMao.UseVisualStyleBackColor = true;
            this.chkCuelloMao.CheckedChanged += new System.EventHandler(this.chkCuelloMao_CheckedChanged);
            // 
            // chkMarngaCorta
            // 
            this.chkMarngaCorta.AutoSize = true;
            this.chkMarngaCorta.Location = new System.Drawing.Point(190, 34);
            this.chkMarngaCorta.Name = "chkMarngaCorta";
            this.chkMarngaCorta.Size = new System.Drawing.Size(103, 20);
            this.chkMarngaCorta.TabIndex = 2;
            this.chkMarngaCorta.Text = "Manga Corta";
            this.chkMarngaCorta.UseVisualStyleBackColor = true;
            this.chkMarngaCorta.CheckedChanged += new System.EventHandler(this.chkMarngaCorta_CheckedChanged);
            // 
            // radPantalon
            // 
            this.radPantalon.AutoSize = true;
            this.radPantalon.Location = new System.Drawing.Point(30, 70);
            this.radPantalon.Name = "radPantalon";
            this.radPantalon.Size = new System.Drawing.Size(78, 20);
            this.radPantalon.TabIndex = 1;
            this.radPantalon.TabStop = true;
            this.radPantalon.Text = "Pantalon";
            this.radPantalon.UseVisualStyleBackColor = true;
            this.radPantalon.CheckedChanged += new System.EventHandler(this.radPantalon_CheckedChanged);
            // 
            // radCamisa
            // 
            this.radCamisa.AutoSize = true;
            this.radCamisa.Location = new System.Drawing.Point(30, 28);
            this.radCamisa.Name = "radCamisa";
            this.radCamisa.Size = new System.Drawing.Size(71, 20);
            this.radCamisa.TabIndex = 0;
            this.radCamisa.TabStop = true;
            this.radCamisa.Text = "Camisa";
            this.radCamisa.UseVisualStyleBackColor = true;
            this.radCamisa.CheckedChanged += new System.EventHandler(this.radCamisa_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 79);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizador Express";
            // 
            // Cotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 548);
            this.Controls.Add(this.panel1);
            this.Name = "Cotizador";
            this.Text = "Quarktizador";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grpPrecioCantidad.ResumeLayout(false);
            this.grpPrecioCantidad.PerformLayout();
            this.grpCalidad.ResumeLayout(false);
            this.grpCalidad.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpPrenda.ResumeLayout(false);
            this.grpPrenda.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.GroupBox grpPrenda;
        private System.Windows.Forms.RadioButton radPantalon;
        private System.Windows.Forms.RadioButton radCamisa;
        private System.Windows.Forms.LinkLabel lblHistorialCotizaciones;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.CheckBox chkCuelloMao;
        private System.Windows.Forms.CheckBox chkMarngaCorta;
        private System.Windows.Forms.GroupBox grpCalidad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkChupin;
        private System.Windows.Forms.GroupBox grpPrecioCantidad;
        private System.Windows.Forms.RadioButton radPremium;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCotizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}

