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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblHistorialCotizaciones = new System.Windows.Forms.LinkLabel();
            this.grpPrenda = new System.Windows.Forms.GroupBox();
            this.radCamisa = new System.Windows.Forms.RadioButton();
            this.radPantalon = new System.Windows.Forms.RadioButton();
            this.chkMarngaCorta = new System.Windows.Forms.CheckBox();
            this.chkCuelloMao = new System.Windows.Forms.CheckBox();
            this.chkChupin = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.grpCalidad = new System.Windows.Forms.GroupBox();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grpPrecioCantidad = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpPrenda.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpCalidad.SuspendLayout();
            this.grpPrecioCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCotizar);
            this.panel1.Controls.Add(this.grpPrecioCantidad);
            this.panel1.Controls.Add(this.grpCalidad);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.grpPrenda);
            this.panel1.Controls.Add(this.lblHistorialCotizaciones);
            this.panel1.Controls.Add(this.lblNombreVendedor);
            this.panel1.Controls.Add(this.lblDireccionTienda);
            this.panel1.Controls.Add(this.lblNombreTienda);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 524);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(100, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizador Express";
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTienda.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblNombreTienda.Location = new System.Drawing.Point(13, 95);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(115, 16);
            this.lblNombreTienda.TabIndex = 1;
            this.lblNombreTienda.Text = "Nombre Tienda";
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionTienda.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblDireccionTienda.Location = new System.Drawing.Point(365, 95);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(126, 16);
            this.lblDireccionTienda.TabIndex = 2;
            this.lblDireccionTienda.Text = "Direccion Tienda";
            this.lblDireccionTienda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNombreVendedor.Location = new System.Drawing.Point(13, 130);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(134, 13);
            this.lblNombreVendedor.TabIndex = 3;
            this.lblNombreVendedor.Text = "Nombre Vendedor | Codigo";
            this.lblNombreVendedor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHistorialCotizaciones
            // 
            this.lblHistorialCotizaciones.AutoSize = true;
            this.lblHistorialCotizaciones.Location = new System.Drawing.Point(374, 130);
            this.lblHistorialCotizaciones.Name = "lblHistorialCotizaciones";
            this.lblHistorialCotizaciones.Size = new System.Drawing.Size(107, 13);
            this.lblHistorialCotizaciones.TabIndex = 4;
            this.lblHistorialCotizaciones.TabStop = true;
            this.lblHistorialCotizaciones.Text = "Historial Cotizaciones";
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
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtStock);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(41, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 24);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unidades Disponibles";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(167, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 1;
            // 
            // grpCalidad
            // 
            this.grpCalidad.Controls.Add(this.radioButton2);
            this.grpCalidad.Controls.Add(this.radStandard);
            this.grpCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCalidad.Location = new System.Drawing.Point(41, 339);
            this.grpCalidad.Name = "grpCalidad";
            this.grpCalidad.Size = new System.Drawing.Size(212, 58);
            this.grpCalidad.TabIndex = 7;
            this.grpCalidad.TabStop = false;
            this.grpCalidad.Text = "Calidad de Prenda";
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
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(109, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 20);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Camisa";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // grpPrecioCantidad
            // 
            this.grpPrecioCantidad.Controls.Add(this.textBox1);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "$";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(26, 20);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(63, 22);
            this.txtPrecioUnitario.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 22);
            this.textBox1.TabIndex = 3;
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.Color.White;
            this.btnCotizar.Location = new System.Drawing.Point(41, 428);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(141, 51);
            this.btnCotizar.TabIndex = 9;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.BlueViolet;
            this.textBox2.Location = new System.Drawing.Point(231, 442);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(170, 29);
            this.textBox2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "$";
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
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpPrenda.ResumeLayout(false);
            this.grpPrenda.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpCalidad.ResumeLayout(false);
            this.grpCalidad.PerformLayout();
            this.grpPrecioCantidad.ResumeLayout(false);
            this.grpPrecioCantidad.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCotizar;
    }
}

