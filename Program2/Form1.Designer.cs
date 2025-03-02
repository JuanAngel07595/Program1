namespace Program2
{
    partial class backform
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
            this.baridentity = new System.Windows.Forms.TextBox();
            this.Barname = new System.Windows.Forms.TextBox();
            this.boxinfopersonal = new System.Windows.Forms.GroupBox();
            this.TextID = new System.Windows.Forms.Label();
            this.TextApellido = new System.Windows.Forms.Label();
            this.TextNombre = new System.Windows.Forms.Label();
            this.BarLastname = new System.Windows.Forms.TextBox();
            this.baremail = new System.Windows.Forms.TextBox();
            this.bartel = new System.Windows.Forms.TextBox();
            this.boxcontacto = new System.Windows.Forms.GroupBox();
            this.TextTelefono = new System.Windows.Forms.Label();
            this.TextCorreo = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.boxinfopersonal.SuspendLayout();
            this.boxcontacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // baridentity
            // 
            this.baridentity.Location = new System.Drawing.Point(87, 31);
            this.baridentity.Name = "baridentity";
            this.baridentity.Size = new System.Drawing.Size(273, 22);
            this.baridentity.TabIndex = 10;
            this.baridentity.TextChanged += new System.EventHandler(this.BarraID_TextChanged);
            this.baridentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baridentity_KeyPress);
            // 
            // Barname
            // 
            this.Barname.Location = new System.Drawing.Point(87, 71);
            this.Barname.Name = "Barname";
            this.Barname.Size = new System.Drawing.Size(273, 22);
            this.Barname.TabIndex = 2;
            this.Barname.TextChanged += new System.EventHandler(this.Barname_TextChanged);
            this.Barname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Barname_KeyPress);
            // 
            // boxinfopersonal
            // 
            this.boxinfopersonal.BackColor = System.Drawing.Color.Transparent;
            this.boxinfopersonal.Controls.Add(this.TextID);
            this.boxinfopersonal.Controls.Add(this.baridentity);
            this.boxinfopersonal.Controls.Add(this.TextApellido);
            this.boxinfopersonal.Controls.Add(this.TextNombre);
            this.boxinfopersonal.Controls.Add(this.BarLastname);
            this.boxinfopersonal.Controls.Add(this.Barname);
            this.boxinfopersonal.ForeColor = System.Drawing.SystemColors.Control;
            this.boxinfopersonal.Location = new System.Drawing.Point(176, 44);
            this.boxinfopersonal.Name = "boxinfopersonal";
            this.boxinfopersonal.Size = new System.Drawing.Size(375, 202);
            this.boxinfopersonal.TabIndex = 7;
            this.boxinfopersonal.TabStop = false;
            this.boxinfopersonal.Text = "Información Personal";
            this.boxinfopersonal.Enter += new System.EventHandler(this.boxinfopersonal_Enter);
            // 
            // TextID
            // 
            this.TextID.AutoSize = true;
            this.TextID.ForeColor = System.Drawing.SystemColors.Control;
            this.TextID.Location = new System.Drawing.Point(34, 34);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(20, 16);
            this.TextID.TabIndex = 11;
            this.TextID.Text = "ID";
            // 
            // TextApellido
            // 
            this.TextApellido.AutoSize = true;
            this.TextApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.TextApellido.Location = new System.Drawing.Point(15, 115);
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(57, 16);
            this.TextApellido.TabIndex = 9;
            this.TextApellido.Text = "Apellido";
            // 
            // TextNombre
            // 
            this.TextNombre.AutoSize = true;
            this.TextNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.TextNombre.Location = new System.Drawing.Point(15, 71);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(56, 16);
            this.TextNombre.TabIndex = 8;
            this.TextNombre.Text = "Nombre";
            this.TextNombre.Click += new System.EventHandler(this.TextNombre_Click);
            // 
            // BarLastname
            // 
            this.BarLastname.Location = new System.Drawing.Point(87, 109);
            this.BarLastname.Name = "BarLastname";
            this.BarLastname.Size = new System.Drawing.Size(273, 22);
            this.BarLastname.TabIndex = 3;
            this.BarLastname.TextChanged += new System.EventHandler(this.BarLastname_TextChanged);
            this.BarLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarLastname_KeyPress);
            // 
            // baremail
            // 
            this.baremail.Location = new System.Drawing.Point(101, 108);
            this.baremail.Name = "baremail";
            this.baremail.Size = new System.Drawing.Size(227, 22);
            this.baremail.TabIndex = 5;
            this.baremail.TextChanged += new System.EventHandler(this.baremail_TextChanged);
            this.baremail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baremail_KeyPress);
            // 
            // bartel
            // 
            this.bartel.Location = new System.Drawing.Point(101, 47);
            this.bartel.Name = "bartel";
            this.bartel.Size = new System.Drawing.Size(227, 22);
            this.bartel.TabIndex = 4;
            this.bartel.TextChanged += new System.EventHandler(this.bartel_TextChanged);
            this.bartel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bartel_KeyPress);
            // 
            // boxcontacto
            // 
            this.boxcontacto.BackColor = System.Drawing.Color.Transparent;
            this.boxcontacto.Controls.Add(this.TextTelefono);
            this.boxcontacto.Controls.Add(this.TextCorreo);
            this.boxcontacto.Controls.Add(this.baremail);
            this.boxcontacto.Controls.Add(this.bartel);
            this.boxcontacto.ForeColor = System.Drawing.SystemColors.Control;
            this.boxcontacto.Location = new System.Drawing.Point(176, 263);
            this.boxcontacto.Name = "boxcontacto";
            this.boxcontacto.Size = new System.Drawing.Size(367, 202);
            this.boxcontacto.TabIndex = 8;
            this.boxcontacto.TabStop = false;
            this.boxcontacto.Text = "Contacto";
            this.boxcontacto.Enter += new System.EventHandler(this.boxcontacto_Enter);
            // 
            // TextTelefono
            // 
            this.TextTelefono.AutoSize = true;
            this.TextTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.TextTelefono.Location = new System.Drawing.Point(21, 53);
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(61, 16);
            this.TextTelefono.TabIndex = 10;
            this.TextTelefono.Text = "Teléfono";
            // 
            // TextCorreo
            // 
            this.TextCorreo.AutoSize = true;
            this.TextCorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.TextCorreo.Location = new System.Drawing.Point(21, 112);
            this.TextCorreo.Name = "TextCorreo";
            this.TextCorreo.Size = new System.Drawing.Size(48, 16);
            this.TextCorreo.TabIndex = 11;
            this.TextCorreo.Text = "Correo";
            this.TextCorreo.Click += new System.EventHandler(this.TextCorreo_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(176, 484);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(111, 39);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(406, 484);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(111, 39);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // backform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Program2.Properties.Resources.Tablero_de_ajedrez;
            this.ClientSize = new System.Drawing.Size(684, 551);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.boxcontacto);
            this.Controls.Add(this.boxinfopersonal);
            this.Name = "backform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.backform_Load);
            this.boxinfopersonal.ResumeLayout(false);
            this.boxinfopersonal.PerformLayout();
            this.boxcontacto.ResumeLayout(false);
            this.boxcontacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox baridentity;
        private System.Windows.Forms.TextBox Barname;
        private System.Windows.Forms.GroupBox boxinfopersonal;
        private System.Windows.Forms.Label TextID;
        private System.Windows.Forms.Label TextApellido;
        private System.Windows.Forms.Label TextNombre;
        private System.Windows.Forms.TextBox BarLastname;
        private System.Windows.Forms.TextBox baremail;
        private System.Windows.Forms.TextBox bartel;
        private System.Windows.Forms.GroupBox boxcontacto;
        private System.Windows.Forms.Label TextTelefono;
        private System.Windows.Forms.Label TextCorreo;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

