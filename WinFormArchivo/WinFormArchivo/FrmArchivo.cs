using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using WinFormArchivo;
using Spire.Pdf;
using Spire.Pdf.Annotations;
using Spire.Pdf.Annotations.Appearance;
using Spire.Pdf.Graphics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Spire.Pdf.Grid;

namespace WinFormArchivo
{
    public partial class FrmArchivo : Form
    {
        public FrmArchivo()
        {
            InitializeComponent();
        }

        private async void btnDescargarArchivo_Click(object sender, EventArgs e)
        {
            string nombreArchivo = txtNombreArchivo.Text;
            int tipoRespuesta = 2;
            string mensajeRespuesta = "";
            if (!string.IsNullOrWhiteSpace(nombreArchivo))
            {
                
                try
                {
                    using (HttpClient cliente = new HttpClient())
                    {
                        string url = "https://localhost:44316/api/Archivo/?nombreArchivo=" + nombreArchivo;
                        using (HttpResponseMessage respuestaConsulta = await cliente.GetAsync(url))
                        {
                            if (respuestaConsulta.IsSuccessStatusCode)
                            {
                                byte[] arrContenido = await respuestaConsulta.Content.ReadAsAsync<byte[]>();
                                string nombreCompletoArchivo = nombreArchivo + 1;
                                File.WriteAllBytes(nombreCompletoArchivo, arrContenido);
                                tipoRespuesta = 1;
                                mensajeRespuesta = "Se descargó correctamente el archivo " + nombreArchivo;
                            }
                            else
                            {
                                mensajeRespuesta = await respuestaConsulta.Content.ReadAsStringAsync();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    tipoRespuesta = 3;
                    mensajeRespuesta = ex.Message;
                }

            }

            MessageBoxIcon iconoMensaje;
            if (tipoRespuesta == 1)
                iconoMensaje = MessageBoxIcon.Information;
            else if (tipoRespuesta == 2)
                iconoMensaje = MessageBoxIcon.Warning;
            else
                iconoMensaje = MessageBoxIcon.Error;
            MessageBox.Show(mensajeRespuesta, "Descarga de archivos", MessageBoxButtons.OK, iconoMensaje);
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtRuta.Text = this.openFileDialog1.FileName;
                    txtNombreArchivo.Text = this.openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            pdfReader pdf = new pdfReader();
            pdf.axAcroPDF1.src = txtRuta.Text;
            pdf.Show();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pcbFirma.ImageLocation = openFileDialog2.FileName;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            txtGuardar.Text = saveFileDialog1.FileName;
            using (Stream inputPdfStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream inputImageStream = new FileStream(openFileDialog2.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream outputPdfStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var reader = new PdfReader(inputPdfStream);
                var stamper = new PdfStamper(reader, outputPdfStream);
                var pdfContentByte = stamper.GetOverContent(1);

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(inputImageStream);
                image.SetAbsolutePosition(100, 100);
                pdfContentByte.AddImage(image);
                stamper.Close();
            }
        }
    }
}
