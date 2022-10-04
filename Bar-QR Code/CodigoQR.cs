using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace Bar_QR_Code
{
	public partial class CodigoQR : Form
	{
		public CodigoQR()
		{
			InitializeComponent();
		}

		private void CodigoQR_Load(object sender, EventArgs e)
		{

		}

		private void CodigoQR_FormClosing(object sender, FormClosingEventArgs e)
		{

		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void CodigoQR_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void BtnCerrar_Click(object sender, EventArgs e)
		{
			//Application.Exit();
			this.Close();
		}

		private void BtnMaximizar_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			else
			{
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void BtnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void TBTexto_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter)
			{
				QRCodeGenerator qrGen = null;
				QRCodeData qrData = null;
				try
				{
					qrGen = new QRCodeGenerator();
					qrData = qrGen.CreateQrCode(TBTexto.Text, QRCodeGenerator.ECCLevel.H);
				}
				catch(Exception Ex1)
				{
					MessageBox.Show(Ex1.ToString(), Ex1.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
				if (CBTipo.SelectedIndex == 0)
				{
					//Texto
					try
					{
						qrData = qrGen.CreateQrCode(TBTexto.Text, QRCodeGenerator.ECCLevel.H);
					}
					catch (Exception Ex1)
					{
						MessageBox.Show(Ex1.ToString(), Ex1.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (CBTipo.SelectedIndex == 1)
				{
					//Url
					try
					{
						Url url = new Url("");
						qrData = qrGen.CreateQrCode(url, QRCodeGenerator.ECCLevel.H);
					}
					catch (Exception Ex1)
					{
						MessageBox.Show(Ex1.ToString(), Ex1.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (CBTipo.SelectedIndex == 2)
				{
					//Número telefónico
					try
					{
						PhoneNumber telefono = new PhoneNumber("");
						qrData = qrGen.CreateQrCode(telefono, QRCodeGenerator.ECCLevel.H);
					}
					catch (Exception Ex1)
					{
						MessageBox.Show(Ex1.ToString(), Ex1.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (CBTipo.SelectedIndex == 3)
				{
					//SMS
					try
					{
						SMS sms = new SMS("+52753123", "Hola");
						qrData = qrGen.CreateQrCode(sms, QRCodeGenerator.ECCLevel.H);
					}
					catch (Exception Ex1)
					{
						MessageBox.Show(Ex1.ToString(), Ex1.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (CBTipo.SelectedIndex == 4)
				{
					//Mensaje de WhatsApp
					try
					{
						WhatsAppMessage ws = new WhatsAppMessage("+52753123", "Hola");
						qrData = qrGen.CreateQrCode(ws, QRCodeGenerator.ECCLevel.H);
					}
					catch (Exception Ex1)
					{
						MessageBox.Show(Ex1.ToString(), Ex1.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (CBTipo.SelectedIndex == 5)
				{
					//Red Wifi sin contraseña
				}
				if (CBTipo.SelectedIndex == 6)
				{
					//Red Wifi WEP
				}
				if (CBTipo.SelectedIndex == 7)
				{
					//Red Wifi WPA
				}
				
				
				try
				{
					QRCode qrCod = new QRCode(qrData);
					Bitmap qrImg = qrCod.GetGraphic(5, Color.Black, Color.White, true);
					PBCodigoQR.Image = qrImg;
				}
				catch (Exception Ex1)
				{
					MessageBox.Show(Ex1.ToString(), Ex1.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void CBTipo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void PanelFormulario_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void PBCodigoQR_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void BtnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				Image imgFinal = (Image)PBCodigoQR.Image;

				SaveFileDialog CajaDeDiaologoGuardar = new SaveFileDialog();
				CajaDeDiaologoGuardar.AddExtension = true;
				CajaDeDiaologoGuardar.Filter = "Image PNG (*.png)|*.png";
				CajaDeDiaologoGuardar.ShowDialog();
				if (!string.IsNullOrEmpty(CajaDeDiaologoGuardar.FileName))
				{
					try
					{
						imgFinal.Save(CajaDeDiaologoGuardar.FileName, ImageFormat.Png);
					}
					catch (Exception Ex2)
					{
						MessageBox.Show(Ex2.ToString(), Ex2.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				try
				{
					imgFinal.Dispose();
				}
				catch (Exception Ex2)
				{
					MessageBox.Show(Ex2.ToString(), Ex2.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception Ex1)
			{
				//
			}
		}

		private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
