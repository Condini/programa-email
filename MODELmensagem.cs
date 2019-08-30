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

public class MODELmensagem
{
    public string From { get; set; }
    public bool isBodyHtml { get; set; }
    public string Body { get; set; }
    public string Subject { get; set; }
    public string To { get; set; }
    public bool Priority { get; set; }
}
