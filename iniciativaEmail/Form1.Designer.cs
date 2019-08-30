namespace iniciativaEmail
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAssunto = new System.Windows.Forms.TextBox();
            this.LblAnexos = new System.Windows.Forms.TextBox();
            this.RtbTexto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(83, 56);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(438, 20);
            this.TxtEmail.TabIndex = 0;
            // 
            // TxtAssunto
            // 
            this.TxtAssunto.Location = new System.Drawing.Point(83, 99);
            this.TxtAssunto.Name = "TxtAssunto";
            this.TxtAssunto.Size = new System.Drawing.Size(438, 20);
            this.TxtAssunto.TabIndex = 1;
            // 
            // LblAnexos
            // 
            this.LblAnexos.Location = new System.Drawing.Point(83, 204);
            this.LblAnexos.Name = "LblAnexos";
            this.LblAnexos.Size = new System.Drawing.Size(438, 20);
            this.LblAnexos.TabIndex = 2;
            // 
            // RtbTexto
            // 
            this.RtbTexto.Location = new System.Drawing.Point(61, 297);
            this.RtbTexto.Name = "RtbTexto";
            this.RtbTexto.Size = new System.Drawing.Size(460, 165);
            this.RtbTexto.TabIndex = 3;
            this.RtbTexto.Text = "";
            this.RtbTexto.TextChanged += new System.EventHandler(this.RtbTexto_TextChanged);
            this.RtbTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RtbTexto_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Destinatário(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assunto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Anexos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mensagem";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(446, 480);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAnexar
            // 
            this.btnAnexar.Location = new System.Drawing.Point(446, 175);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(75, 23);
            this.btnAnexar.TabIndex = 9;
            this.btnAnexar.Text = "Anexar";
            this.btnAnexar.UseVisualStyleBackColor = true;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 541);
            this.Controls.Add(this.btnAnexar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RtbTexto);
            this.Controls.Add(this.LblAnexos);
            this.Controls.Add(this.TxtAssunto);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Enviar email";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAssunto;
        private System.Windows.Forms.TextBox LblAnexos;
        private System.Windows.Forms.RichTextBox RtbTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAnexar;
    }
}

