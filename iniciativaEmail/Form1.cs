using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Web;
using System.Net;
using System.IO;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;

namespace iniciativaEmail
{
    public partial class Form1 : Form
    {
        MailMessage Msg = new MailMessage();



        public Form1()
        {
            InitializeComponent();
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                MODELmensagem model = new MODELmensagem();
                model.To = TxtEmail.Text;
                model.Subject = TxtAssunto.Text;
                model.Anexos = LblAnexos.Text;
                model.Body = RtbTexto.Text;

                SmtpClient Client = new SmtpClient();
                Client.Host = "smtp-mail.outlook.com";
                Client.Port = 587;
                Client.DeliveryMethod = SmtpDeliveryMethod.Network;
                Client.UseDefaultCredentials = false;
                Client.Credentials = new NetworkCredential("guilherme.santos@confitec.com.br", "Batata123");
                Client.EnableSsl = true;

                Msg.From = new MailAddress("guilherme.santos@confitec.com.br");
                Msg.IsBodyHtml = true;
                Msg.Body = model.Body;
                Msg.Subject = model.Subject;
                Msg.To.Add(model.To.Replace("/", ","));
                Msg.Priority = MailPriority.Normal;

                if (LblAnexos != null && LblAnexos.Text != string.Empty)
                {
                    var anexoS = model.Anexos.Split(';');
                    foreach (var Item in anexoS)
                    {
                        Attachment Anexo = new Attachment(Item);
                        Anexo.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;
                        Msg.Attachments.Add(Anexo);

                        if (Anexo.ContentStream.Length > 36700160)
                        {
                            MessageBox.Show("Não foi possível enviar o email pois seu arquivo ultrapassa 35mb, que é o tamanho máximo permitido por email.");
                            LblAnexos.Clear();
                            Msg.Attachments.Clear();
                            return;
                        }
                    }
                }

                Client.Send(Msg);
                TxtEmail.Clear();
                TxtAssunto.Clear();
                LblAnexos.Clear();
                RtbTexto.Clear();
                Msg.Attachments.Clear();
                Msg.To.Clear();
                Client.Dispose();

                MessageBox.Show("Email enviado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível enviar o email: \n" + ex);
            }

        }




        private void btnAnexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (LblAnexos.Text == string.Empty)
                    {
                        LblAnexos.Text += open.FileName;
                    }
                    else
                    {
                        LblAnexos.Text += ';' + open.FileName;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void RtbTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void RtbTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RtbTexto.AppendText("\n<br>");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
