namespace Bar_QR_Code
{
	partial class Form1
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
			this.PanelContenedor = new System.Windows.Forms.Panel();
			this.PanelFormulario = new System.Windows.Forms.Panel();
			this.BtnBarcode = new System.Windows.Forms.Button();
			this.BtnQRCode = new System.Windows.Forms.Button();
			this.BtnMinimizar = new System.Windows.Forms.Button();
			this.BtnMaximizar = new System.Windows.Forms.Button();
			this.BtnCerrar = new System.Windows.Forms.Button();
			this.PanelHeader = new System.Windows.Forms.Panel();
			this.PanelContenedor.SuspendLayout();
			this.PanelFormulario.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			this.SuspendLayout();
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
			this.PanelContenedor.Size = new System.Drawing.Size(751, 422);
			this.PanelContenedor.TabIndex = 11;
			this.PanelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelContenedor_MouseDown);
			// 
			// PanelFormulario
			// 
			this.PanelFormulario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PanelFormulario.Controls.Add(this.BtnBarcode);
			this.PanelFormulario.Controls.Add(this.BtnQRCode);
			this.PanelFormulario.Location = new System.Drawing.Point(292, 73);
			this.PanelFormulario.Name = "PanelFormulario";
			this.PanelFormulario.Size = new System.Drawing.Size(200, 186);
			this.PanelFormulario.TabIndex = 2;
			// 
			// BtnBarcode
			// 
			this.BtnBarcode.Location = new System.Drawing.Point(29, 17);
			this.BtnBarcode.Name = "BtnBarcode";
			this.BtnBarcode.Size = new System.Drawing.Size(138, 49);
			this.BtnBarcode.TabIndex = 1;
			this.BtnBarcode.Text = "BARCODE";
			this.BtnBarcode.UseVisualStyleBackColor = true;
			this.BtnBarcode.Click += new System.EventHandler(this.BtnBarcode_Click);
			// 
			// BtnQRCode
			// 
			this.BtnQRCode.Location = new System.Drawing.Point(29, 115);
			this.BtnQRCode.Name = "BtnQRCode";
			this.BtnQRCode.Size = new System.Drawing.Size(138, 49);
			this.BtnQRCode.TabIndex = 0;
			this.BtnQRCode.Text = "QR CODE";
			this.BtnQRCode.UseVisualStyleBackColor = true;
			this.BtnQRCode.Click += new System.EventHandler(this.BtnQRCode_Click);
			// 
			// BtnMinimizar
			// 
			this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMinimizar.FlatAppearance.BorderSize = 0;
			this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMinimizar.Image = global::Bar_QR_Code.Properties.Resources.minimize_orange_button_16;
			this.BtnMinimizar.Location = new System.Drawing.Point(676, 4);
			this.BtnMinimizar.Name = "BtnMinimizar";
			this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
			this.BtnMinimizar.TabIndex = 12;
			this.BtnMinimizar.UseVisualStyleBackColor = true;
			this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
			// 
			// BtnMaximizar
			// 
			this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMaximizar.FlatAppearance.BorderSize = 0;
			this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMaximizar.Image = global::Bar_QR_Code.Properties.Resources.window_blue_button_16;
			this.BtnMaximizar.Location = new System.Drawing.Point(702, 4);
			this.BtnMaximizar.Name = "BtnMaximizar";
			this.BtnMaximizar.Size = new System.Drawing.Size(20, 20);
			this.BtnMaximizar.TabIndex = 11;
			this.BtnMaximizar.UseVisualStyleBackColor = true;
			this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
			// 
			// BtnCerrar
			// 
			this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCerrar.FlatAppearance.BorderSize = 0;
			this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCerrar.Image = global::Bar_QR_Code.Properties.Resources.transparent_red_cross_16;
			this.BtnCerrar.Location = new System.Drawing.Point(728, 4);
			this.BtnCerrar.Name = "BtnCerrar";
			this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
			this.BtnCerrar.TabIndex = 10;
			this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnCerrar.UseVisualStyleBackColor = true;
			this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
			// 
			// PanelHeader
			// 
			this.PanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelHeader.BackColor = System.Drawing.SystemColors.Highlight;
			this.PanelHeader.Controls.Add(this.BtnCerrar);
			this.PanelHeader.Controls.Add(this.BtnMinimizar);
			this.PanelHeader.Controls.Add(this.BtnMaximizar);
			this.PanelHeader.Location = new System.Drawing.Point(-1, -3);
			this.PanelHeader.Name = "PanelHeader";
			this.PanelHeader.Size = new System.Drawing.Size(751, 32);
			this.PanelHeader.TabIndex = 3;
			this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 449);
			this.Controls.Add(this.PanelHeader);
			this.Controls.Add(this.PanelContenedor);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.PanelContenedor.ResumeLayout(false);
			this.PanelFormulario.ResumeLayout(false);
			this.PanelHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelContenedor;
		private System.Windows.Forms.Button BtnMinimizar;
		private System.Windows.Forms.Button BtnMaximizar;
		private System.Windows.Forms.Button BtnCerrar;
		private System.Windows.Forms.Button BtnBarcode;
		private System.Windows.Forms.Button BtnQRCode;
		private System.Windows.Forms.Panel PanelFormulario;
		private System.Windows.Forms.Panel PanelHeader;
	}
}

