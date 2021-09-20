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
                                string nombreCompletoArchivo = @"C:\Users\rober\source\repos\ApiForms\WinFormArchivo\WinFormArchivo\pruebadocs\" + nombreArchivo;
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

        private void FrmArchivo_Load(object sender, EventArgs e)
        {

        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtRuta.Text = this.openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
             
        }
    }
}
