using BarcodeLib;
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

namespace Bar_QR_Code
{
	public partial class CodigoBarras : Form
	{
		public CodigoBarras()
		{
			InitializeComponent();
		}

		private void CodigoBarras_Load(object sender, EventArgs e)
		{
			Carpeta.Text = "C:\\Barcodes";
		}

		private void CodigoBarras_FormClosing(object sender, FormClosingEventArgs e)
		{

		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void CodigoBarras_MouseDown(object sender, MouseEventArgs e)
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

		private void BtnEntrar_Click(object sender, EventArgs e)
		{
			//
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
				Barcode bar = new Barcode();
				bar.IncludeLabel = true;
				try
				{
					PBCodigoBarras.Image = bar.Encode(TYPE.CODE128, TBTexto.Text);

					Image imgFinal = (Image)PBCodigoBarras.Image;

					imgFinal.Save(Carpeta.Text + "\\" + TBTexto.Text + ".png", ImageFormat.Png);
				}
				catch(Exception Ex1)
				{
					MessageBox.Show(Ex1.ToString(), Ex1.Message, MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}

		private void PanelFormulario_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void PBCodigoBarras_MouseDown(object sender, MouseEventArgs e)
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
				Image imgFinal = (Image)PBCodigoBarras.Image;

				SaveFileDialog CajaDeDiaologoGuardar = new SaveFileDialog();
				CajaDeDiaologoGuardar.AddExtension = true;
				CajaDeDiaologoGuardar.Filter = "Image PNG (*.png)|*.png";
				CajaDeDiaologoGuardar.ShowDialog();
				if (!string.IsNullOrEmpty(CajaDeDiaologoGuardar.FileName))
				{
					try
					{
						//MessageBox.Show(CajaDeDiaologoGuardar.FileName); //C:\
						imgFinal.Save(CajaDeDiaologoGuardar.FileName, ImageFormat.Png);
					}catch(Exception Ex2)
					{
						MessageBox.Show(Ex2.ToString(), Ex2.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				try
				{
					imgFinal.Dispose();
				}catch(Exception Ex2)
				{
					MessageBox.Show(Ex2.ToString(), Ex2.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}catch(Exception Ex1)
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
