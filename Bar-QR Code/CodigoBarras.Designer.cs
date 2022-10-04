namespace Bar_QR_Code
{
	partial class CodigoBarras
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
			this.BtnMinimizar = new System.Windows.Forms.Button();
			this.BtnMaximizar = new System.Windows.Forms.Button();
			this.BtnCerrar = new System.Windows.Forms.Button();
			this.PanelContenedor = new System.Windows.Forms.Panel();
			this.PanelFormulario = new System.Windows.Forms.Panel();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.PBCodigoBarras = new System.Windows.Forms.PictureBox();
			this.TBTexto = new System.Windows.Forms.TextBox();
			this.PanelHeader = new System.Windows.Forms.Panel();
			this.Carpeta = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PanelContenedor.SuspendLayout();
			this.PanelFormulario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBCodigoBarras)).BeginInit();
			this.PanelHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnMinimizar
			// 
			this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMinimizar.FlatAppearance.BorderSize = 0;
			this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMinimizar.Image = global::Bar_QR_Code.Properties.Resources.minimize_orange_button_16;
			this.BtnMinimizar.Location = new System.Drawing.Point(709, 6);
			this.BtnMinimizar.Name = "BtnMinimizar";
			this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
			this.BtnMinimizar.TabIndex = 9;
			this.BtnMinimizar.UseVisualStyleBackColor = true;
			this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
			// 
			// BtnMaximizar
			// 
			this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMaximizar.FlatAppearance.BorderSize = 0;
			this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMaximizar.Image = global::Bar_QR_Code.Properties.Resources.window_blue_button_16;
			this.BtnMaximizar.Location = new System.Drawing.Point(735, 6);
			this.BtnMaximizar.Name = "BtnMaximizar";
			this.BtnMaximizar.Size = new System.Drawing.Size(20, 20);
			this.BtnMaximizar.TabIndex = 8;
			this.BtnMaximizar.UseVisualStyleBackColor = true;
			this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
			// 
			// BtnCerrar
			// 
			this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCerrar.FlatAppearance.BorderSize = 0;
			this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCerrar.Image = global::Bar_QR_Code.Properties.Resources.transparent_red_cross_16;
			this.BtnCerrar.Location = new System.Drawing.Point(761, 6);
			this.BtnCerrar.Name = "BtnCerrar";
			this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
			this.BtnCerrar.TabIndex = 7;
			this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnCerrar.UseVisualStyleBackColor = true;
			this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
			// 
			// PanelContenedor
			// 
			this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelContenedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.PanelContenedor.Controls.Add(this.PanelFormulario);
			this.PanelContenedor.Location = new System.Drawing.Point(-1, 27);
			this.PanelContenedor.Name = "PanelContenedor";
			this.PanelContenedor.Size = new System.Drawing.Size(781, 639);
			this.PanelContenedor.TabIndex = 10;
			this.PanelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelContenedor_MouseDown);
			// 
			// PanelFormulario
			// 
			this.PanelFormulario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PanelFormulario.Controls.Add(this.label1);
			this.PanelFormulario.Controls.Add(this.Carpeta);
			this.PanelFormulario.Controls.Add(this.BtnGuardar);
			this.PanelFormulario.Controls.Add(this.PBCodigoBarras);
			this.PanelFormulario.Controls.Add(this.TBTexto);
			this.PanelFormulario.Location = new System.Drawing.Point(137, 18);
			this.PanelFormulario.Name = "PanelFormulario";
			this.PanelFormulario.Size = new System.Drawing.Size(516, 607);
			this.PanelFormulario.TabIndex = 3;
			this.PanelFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelFormulario_MouseDown);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(216, 501);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(83, 32);
			this.BtnGuardar.TabIndex = 3;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
			// 
			// PBCodigoBarras
			// 
			this.PBCodigoBarras.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.PBCodigoBarras.Location = new System.Drawing.Point(17, 15);
			this.PBCodigoBarras.Name = "PBCodigoBarras";
			this.PBCodigoBarras.Size = new System.Drawing.Size(480, 480);
			this.PBCodigoBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PBCodigoBarras.TabIndex = 1;
			this.PBCodigoBarras.TabStop = false;
			this.PBCodigoBarras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBCodigoBarras_MouseDown);
			// 
			// TBTexto
			// 
			this.TBTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TBTexto.Location = new System.Drawing.Point(17, 539);
			this.TBTexto.Name = "TBTexto";
			this.TBTexto.Size = new System.Drawing.Size(480, 26);
			this.TBTexto.TabIndex = 2;
			this.TBTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBTexto_KeyDown);
			// 
			// PanelHeader
			// 
			this.PanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelHeader.BackColor = System.Drawing.SystemColors.Highlight;
			this.PanelHeader.Controls.Add(this.BtnCerrar);
			this.PanelHeader.Controls.Add(this.BtnMaximizar);
			this.PanelHeader.Controls.Add(this.BtnMinimizar);
			this.PanelHeader.Location = new System.Drawing.Point(-1, -5);
			this.PanelHeader.Name = "PanelHeader";
			this.PanelHeader.Size = new System.Drawing.Size(781, 33);
			this.PanelHeader.TabIndex = 4;
			this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
			// 
			// Carpeta
			// 
			this.Carpeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Carpeta.Location = new System.Drawing.Point(179, 571);
			this.Carpeta.Name = "Carpeta";
			this.Carpeta.Size = new System.Drawing.Size(318, 26);
			this.Carpeta.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 574);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Carpeta de guardado";
			// 
			// CodigoBarras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 664);
			this.Controls.Add(this.PanelHeader);
			this.Controls.Add(this.PanelContenedor);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CodigoBarras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CodigoBarras";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodigoBarras_FormClosing);
			this.Load += new System.EventHandler(this.CodigoBarras_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CodigoBarras_MouseDown);
			this.PanelContenedor.ResumeLayout(false);
			this.PanelFormulario.ResumeLayout(false);
			this.PanelFormulario.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBCodigoBarras)).EndInit();
			this.PanelHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnMinimizar;
		private System.Windows.Forms.Button BtnMaximizar;
		private System.Windows.Forms.Button BtnCerrar;
		private System.Windows.Forms.Panel PanelContenedor;
		private System.Windows.Forms.PictureBox PBCodigoBarras;
		private System.Windows.Forms.TextBox TBTexto;
		private System.Windows.Forms.Panel PanelFormulario;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.Panel PanelHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Carpeta;
	}
}