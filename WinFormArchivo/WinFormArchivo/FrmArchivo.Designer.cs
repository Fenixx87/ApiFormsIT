
namespace WinFormArchivo
{
    partial class FrmArchivo
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
            this.btnDescargarArchivo = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblFirma = new System.Windows.Forms.Label();
            this.btnImg = new System.Windows.Forms.Button();
            this.pcbFirma = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.txtGuardar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDescargarArchivo
            // 
            this.btnDescargarArchivo.Location = new System.Drawing.Point(28, 163);
            this.btnDescargarArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescargarArchivo.Name = "btnDescargarArchivo";
            this.btnDescargarArchivo.Size = new System.Drawing.Size(200, 49);
            this.btnDescargarArchivo.TabIndex = 0;
            this.btnDescargarArchivo.Text = "Descargar archivo";
            this.btnDescargarArchivo.UseVisualStyleBackColor = true;
            this.btnDescargarArchivo.Click += new System.EventHandler(this.btnDescargarArchivo_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(173, 27);
            this.txtNombreArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(261, 22);
            this.txtNombreArchivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de archivo : ";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(440, 70);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(38, 24);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(173, 70);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(261, 22);
            this.txtRuta.TabIndex = 5;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(25, 73);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(92, 17);
            this.lblRuta.TabIndex = 6;
            this.lblRuta.Text = "Ruta archivo:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(235, 163);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(179, 49);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Mostrar PDF";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirma.Location = new System.Drawing.Point(546, 27);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(101, 17);
            this.lblFirma.TabIndex = 8;
            this.lblFirma.Text = "Imagen Firma: ";
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(653, 163);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(201, 49);
            this.btnImg.TabIndex = 10;
            this.btnImg.Text = "Seleccionar Imagen...";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // pcbFirma
            // 
            this.pcbFirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFirma.Location = new System.Drawing.Point(653, 27);
            this.pcbFirma.Name = "pcbFirma";
            this.pcbFirma.Size = new System.Drawing.Size(201, 130);
            this.pcbFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFirma.TabIndex = 11;
            this.pcbFirma.TabStop = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Location = new System.Drawing.Point(25, 116);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(130, 17);
            this.lblGuardar.TabIndex = 13;
            this.lblGuardar.Text = "Ruta de Guardado:";
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(173, 110);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(261, 22);
            this.txtGuardar.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(420, 163);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 49);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar PDF";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 242);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.pcbFirma);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnDescargarArchivo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumiendo web api de archivos";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDescargarArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.PictureBox pcbFirma;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.TextBox txtGuardar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

