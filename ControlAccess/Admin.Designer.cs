namespace ControlAccess
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetProductos = new ControlAccess.datasetProductos();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.gifError = new System.Windows.Forms.PictureBox();
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UsuarioTableAdapter = new ControlAccess.datasetProductosTableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifError)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioBindingSource
            // 
            this.UsuarioBindingSource.DataMember = "Usuario";
            this.UsuarioBindingSource.DataSource = this.datasetProductos;
            // 
            // datasetProductos
            // 
            this.datasetProductos.DataSetName = "datasetProductos";
            this.datasetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(512, 42);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 0;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(521, 26);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(82, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "PASSWORD!";
            // 
            // gifError
            // 
            this.gifError.Image = ((System.Drawing.Image)(resources.GetObject("gifError.Image")));
            this.gifError.Location = new System.Drawing.Point(338, 59);
            this.gifError.Name = "gifError";
            this.gifError.Size = new System.Drawing.Size(454, 442);
            this.gifError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gifError.TabIndex = 2;
            this.gifError.TabStop = false;
            // 
            // report
            // 
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UsuarioBindingSource;
            this.report.LocalReport.DataSources.Add(reportDataSource1);
            this.report.LocalReport.ReportEmbeddedResource = "ControlAccess.reporteUsuario.rdlc";
            this.report.Location = new System.Drawing.Point(0, 0);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(1105, 535);
            this.report.TabIndex = 5;
            // 
            // UsuarioTableAdapter
            // 
            this.UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 535);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.gifError);
            this.Controls.Add(this.report);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox gifError;
        private Microsoft.Reporting.WinForms.ReportViewer report;
        private System.Windows.Forms.BindingSource UsuarioBindingSource;
        private datasetProductos datasetProductos;
        private datasetProductosTableAdapters.UsuarioTableAdapter UsuarioTableAdapter;
    }
}