namespace Bar_QR_Code
{
	partial class CodigoQR
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
			this.PBCodigoQR = new System.Windows.Forms.PictureBox();
			this.CBTipo = new System.Windows.Forms.ComboBox();
			this.TBTexto = new System.Windows.Forms.TextBox();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.PanelHeader = new System.Windows.Forms.Panel();
			this.PanelContenedor.SuspendLayout();
			this.PanelFormulario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBCodigoQR)).BeginInit();
			this.PanelHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnMinimizar
			// 
			this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMinimizar.FlatAppearance.BorderSize = 0;
			this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMinimizar.Image = global::Bar_QR_Code.Properties.Resources.minimize_orange_button_16;
			this.BtnMinimizar.Location = new System.Drawing.Point(618, 0);
			this.BtnMinimizar.Name = "BtnMinimizar";
			this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
			this.BtnMinimizar.TabIndex = 6;
			this.BtnMinimizar.UseVisualStyleBackColor = true;
			this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
			// 
			// BtnMaximizar
			// 
			this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMaximizar.FlatAppearance.BorderSize = 0;
			this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMaximizar.Image = global::Bar_QR_Code.Properties.Resources.window_blue_button_16;
			this.BtnMaximizar.Location = new System.Drawing.Point(644, 0);
			this.BtnMaximizar.Name = "BtnMaximizar";
			this.BtnMaximizar.Size = new System.Drawing.Size(20, 20);
			this.BtnMaximizar.TabIndex = 5;
			this.BtnMaximizar.UseVisualStyleBackColor = true;
			this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
			// 
			// BtnCerrar
			// 
			this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCerrar.FlatAppearance.BorderSize = 0;
			this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCerrar.Image = global::Bar_QR_Code.Properties.Resources.transparent_red_cross_16;
			this.BtnCerrar.Location = new System.Drawing.Point(670, 0);
			this.BtnCerrar.Name = "BtnCerrar";
			this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
			this.BtnCerrar.TabIndex = 4;
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
			this.PanelContenedor.Location = new System.Drawing.Point(-1, 26);
			this.PanelContenedor.Name = "PanelContenedor";
			this.PanelContenedor.Size = new System.Drawing.Size(690, 666);
			this.PanelContenedor.TabIndex = 7;
			this.PanelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelContenedor_MouseDown);
			// 
			// PanelFormulario
			// 
			this.PanelFormulario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PanelFormulario.Controls.Add(this.BtnGuardar);
			this.PanelFormulario.Controls.Add(this.PBCodigoQR);
			this.PanelFormulario.Controls.Add(this.CBTipo);
			this.PanelFormulario.Controls.Add(this.TBTexto);
			this.PanelFormulario.Location = new System.Drawing.Point(82, 9);
			this.PanelFormulario.Name = "PanelFormulario";
			this.PanelFormulario.Size = new System.Drawing.Size(516, 631);
			this.PanelFormulario.TabIndex = 3;
			this.PanelFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelFormulario_MouseDown);
			// 
			// PBCodigoQR
			// 
			this.PBCodigoQR.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.PBCodigoQR.Location = new System.Drawing.Point(18, 13);
			this.PBCodigoQR.Name = "PBCodigoQR";
			this.PBCodigoQR.Size = new System.Drawing.Size(480, 480);
			this.PBCodigoQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PBCodigoQR.TabIndex = 0;
			this.PBCodigoQR.TabStop = false;
			this.PBCodigoQR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBCodigoQR_MouseDown);
			// 
			// CBTipo
			// 
			this.CBTipo.FormattingEnabled = true;
			this.CBTipo.Items.AddRange(new object[] {
            "Texto",
            "Url",
            "Número telefónico",
            "SMS",
            "Mensaje de WhatsApp",
            "Red Wifi sin contraseña",
            "Red Wifi WEP",
            "Red Wifi WPA"});
			this.CBTipo.Location = new System.Drawing.Point(18, 537);
			this.CBTipo.Name = "CBTipo";
			this.CBTipo.Size = new System.Drawing.Size(480, 28);
			this.CBTipo.TabIndex = 2;
			this.CBTipo.SelectedIndexChanged += new System.EventHandler(this.CBTipo_SelectedIndexChanged);
			// 
			// TBTexto
			// 
			this.TBTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TBTexto.Location = new System.Drawing.Point(18, 580);
			this.TBTexto.Name = "TBTexto";
			this.TBTexto.Size = new System.Drawing.Size(480, 26);
			this.TBTexto.TabIndex = 1;
			this.TBTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBTexto_KeyDown);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(215, 499);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(83, 32);
			this.BtnGuardar.TabIndex = 4;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
			// 
			// PanelHeader
			// 
			this.PanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelHeader.BackColor = System.Drawing.SystemColors.Highlight;
			this.PanelHeader.Controls.Add(this.BtnCerrar);
			this.PanelHeader.Controls.Add(this.BtnMaximizar);
			this.PanelHeader.Controls.Add(this.BtnMinimizar);
			this.PanelHeader.Location = new System.Drawing.Point(-1, 0);
			this.PanelHeader.Name = "PanelHeader";
			this.PanelHeader.Size = new System.Drawing.Size(690, 29);
			this.PanelHeader.TabIndex = 4;
			this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
			// 
			// CodigoQR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 692);
			this.Controls.Add(this.PanelHeader);
			this.Controls.Add(this.PanelContenedor);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CodigoQR";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CodigoQR";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodigoQR_FormClosing);
			this.Load += new System.EventHandler(this.CodigoQR_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CodigoQR_MouseDown);
			this.PanelContenedor.ResumeLayout(false);
			this.PanelFormulario.ResumeLayout(false);
			this.PanelFormulario.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBCodigoQR)).EndInit();
			this.PanelHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnMinimizar;
		private System.Windows.Forms.Button BtnMaximizar;
		private System.Windows.Forms.Button BtnCerrar;
		private System.Windows.Forms.Panel PanelContenedor;
		private System.Windows.Forms.TextBox TBTexto;
		private System.Windows.Forms.PictureBox PBCodigoQR;
		private System.Windows.Forms.ComboBox CBTipo;
		private System.Windows.Forms.Panel PanelFormulario;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.Panel PanelHeader;
	}
}