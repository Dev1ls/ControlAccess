namespace ControlAccess
{
    partial class AccessPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessPrincipal));
            this.boxImagen = new System.Windows.Forms.PictureBox();
            this.grupoBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboInvitaciones = new System.Windows.Forms.ComboBox();
            this.comboPatentes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblHoraLlegada = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.lblPorton = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblReporte = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.axMiDocView1 = new AxMODI.AxMiDocView();
            this.btnRunReporte = new System.Windows.Forms.Button();
            this.datasetProductos = new ControlAccess.datasetProductos();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new ControlAccess.datasetProductosTableAdapters.UsuarioTableAdapter();
            this.TimerBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).BeginInit();
            this.grupoBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMiDocView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // boxImagen
            // 
            this.boxImagen.ErrorImage = null;
            this.boxImagen.Image = ((System.Drawing.Image)(resources.GetObject("boxImagen.Image")));
            this.boxImagen.Location = new System.Drawing.Point(6, 19);
            this.boxImagen.Name = "boxImagen";
            this.boxImagen.Size = new System.Drawing.Size(807, 562);
            this.boxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxImagen.TabIndex = 0;
            this.boxImagen.TabStop = false;
            this.boxImagen.Click += new System.EventHandler(this.boxImagen_Click);
            // 
            // grupoBox
            // 
            this.grupoBox.BackColor = System.Drawing.Color.Black;
            this.grupoBox.Controls.Add(this.label9);
            this.grupoBox.Controls.Add(this.label3);
            this.grupoBox.Controls.Add(this.comboInvitaciones);
            this.grupoBox.Controls.Add(this.comboPatentes);
            this.grupoBox.Controls.Add(this.label8);
            this.grupoBox.Controls.Add(this.label7);
            this.grupoBox.Controls.Add(this.label6);
            this.grupoBox.Controls.Add(this.label5);
            this.grupoBox.Controls.Add(this.label4);
            this.grupoBox.Controls.Add(this.lblID);
            this.grupoBox.Controls.Add(this.lblHoraLlegada);
            this.grupoBox.Controls.Add(this.lblHoraSalida);
            this.grupoBox.Controls.Add(this.label2);
            this.grupoBox.Controls.Add(this.label1);
            this.grupoBox.Controls.Add(this.lblApellido);
            this.grupoBox.Controls.Add(this.lblPatente);
            this.grupoBox.Controls.Add(this.lblDomicilio);
            this.grupoBox.Controls.Add(this.lblNombre);
            this.grupoBox.Controls.Add(this.groupBox3);
            this.grupoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoBox.ForeColor = System.Drawing.Color.White;
            this.grupoBox.Location = new System.Drawing.Point(852, 12);
            this.grupoBox.Name = "grupoBox";
            this.grupoBox.Size = new System.Drawing.Size(362, 484);
            this.grupoBox.TabIndex = 1;
            this.grupoBox.TabStop = false;
            this.grupoBox.Text = "INFORMACION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ingreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Invitaciones:";
            // 
            // comboInvitaciones
            // 
            this.comboInvitaciones.BackColor = System.Drawing.Color.Black;
            this.comboInvitaciones.ForeColor = System.Drawing.Color.White;
            this.comboInvitaciones.FormattingEnabled = true;
            this.comboInvitaciones.Location = new System.Drawing.Point(140, 201);
            this.comboInvitaciones.Name = "comboInvitaciones";
            this.comboInvitaciones.Size = new System.Drawing.Size(121, 21);
            this.comboInvitaciones.TabIndex = 21;
            // 
            // comboPatentes
            // 
            this.comboPatentes.BackColor = System.Drawing.Color.Black;
            this.comboPatentes.ForeColor = System.Drawing.Color.White;
            this.comboPatentes.FormattingEnabled = true;
            this.comboPatentes.Location = new System.Drawing.Point(140, 170);
            this.comboPatentes.Name = "comboPatentes";
            this.comboPatentes.Size = new System.Drawing.Size(121, 21);
            this.comboPatentes.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Patentes: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Domicilio: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Apellido: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(124, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 18);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "--";
            // 
            // lblHoraLlegada
            // 
            this.lblHoraLlegada.AutoSize = true;
            this.lblHoraLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraLlegada.ForeColor = System.Drawing.Color.White;
            this.lblHoraLlegada.Location = new System.Drawing.Point(208, 280);
            this.lblHoraLlegada.Name = "lblHoraLlegada";
            this.lblHoraLlegada.Size = new System.Drawing.Size(21, 20);
            this.lblHoraLlegada.TabIndex = 9;
            this.lblHoraLlegada.Text = "--";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.ForeColor = System.Drawing.Color.White;
            this.lblHoraSalida.Location = new System.Drawing.Point(41, 280);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(21, 20);
            this.lblHoraSalida.TabIndex = 8;
            this.lblHoraSalida.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hora Llegada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hora Salida";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(124, 106);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(20, 18);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "--";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.White;
            this.lblPatente.Location = new System.Drawing.Point(124, 19);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(20, 18);
            this.lblPatente.TabIndex = 4;
            this.lblPatente.Text = "--";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(124, 139);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(20, 18);
            this.lblDomicilio.TabIndex = 3;
            this.lblDomicilio.Text = "--";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(124, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(20, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "--";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.Bar);
            this.groupBox3.Controls.Add(this.lblPorton);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 126);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INFORMACION PORTON";
            // 
            // Bar
            // 
            this.Bar.Location = new System.Drawing.Point(39, 97);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(280, 23);
            this.Bar.TabIndex = 24;
            // 
            // lblPorton
            // 
            this.lblPorton.AutoSize = true;
            this.lblPorton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorton.Location = new System.Drawing.Point(117, 56);
            this.lblPorton.Name = "lblPorton";
            this.lblPorton.Size = new System.Drawing.Size(21, 20);
            this.lblPorton.TabIndex = 10;
            this.lblPorton.Text = "--";
            // 
            // btnReporte
            // 
            this.btnReporte.ForeColor = System.Drawing.Color.Black;
            this.btnReporte.Location = new System.Drawing.Point(6, 57);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Guardar";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Location = new System.Drawing.Point(6, 19);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(15, 13);
            this.lblReporte.TabIndex = 12;
            this.lblReporte.Text = "--";
            // 
            // btnAbrir
            // 
            this.btnAbrir.ForeColor = System.Drawing.Color.Black;
            this.btnAbrir.Location = new System.Drawing.Point(6, 55);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 13;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(87, 55);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.btnReporte);
            this.groupBox1.Controls.Add(this.lblReporte);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(852, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 99);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GUARDAR DATOS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.btnAbrir);
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1032, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 97);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PORTON";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.axMiDocView1);
            this.groupBox4.Controls.Add(this.boxImagen);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(25, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(821, 587);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CAMARA PRINCIPAL";
            // 
            // axMiDocView1
            // 
            this.axMiDocView1.Enabled = true;
            this.axMiDocView1.Location = new System.Drawing.Point(443, 593);
            this.axMiDocView1.Name = "axMiDocView1";
            this.axMiDocView1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMiDocView1.OcxState")));
            this.axMiDocView1.Size = new System.Drawing.Size(192, 192);
            this.axMiDocView1.TabIndex = 20;
            // 
            // btnRunReporte
            // 
            this.btnRunReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunReporte.Location = new System.Drawing.Point(25, 605);
            this.btnRunReporte.Name = "btnRunReporte";
            this.btnRunReporte.Size = new System.Drawing.Size(117, 23);
            this.btnRunReporte.TabIndex = 19;
            this.btnRunReporte.Text = "RUN TEST RECON";
            this.btnRunReporte.UseVisualStyleBackColor = true;
            this.btnRunReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // datasetProductos
            // 
            this.datasetProductos.DataSetName = "datasetProductos";
            this.datasetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.datasetProductos;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // TimerBar
            // 
            this.TimerBar.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AccessPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1222, 630);
            this.Controls.Add(this.btnRunReporte);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupoBox);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessPrincipal";
            this.Load += new System.EventHandler(this.AccessPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).EndInit();
            this.grupoBox.ResumeLayout(false);
            this.grupoBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMiDocView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boxImagen;
        private System.Windows.Forms.GroupBox grupoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPorton;
        private System.Windows.Forms.Label lblHoraLlegada;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRunReporte;
        /*private AxMODI.AxMiDocView axMiDocView1;*/
        private System.Windows.Forms.ComboBox comboPatentes;
        private datasetProductos datasetProductos;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private datasetProductosTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboInvitaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar Bar;
        private System.Windows.Forms.Timer TimerBar;
    }
}