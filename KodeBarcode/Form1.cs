using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnBarcode.Barcode;
using System.Drawing.Imaging;

namespace KodeBarcode
{
    public partial class Form1 : Form
    {
        private Bitmap code;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //proses generate barcode
        private void button1_Click(object sender, EventArgs e)
        {
            var qr = new QRCode();

            qr.Data = textBox1.Text;

            qr.X = 4;

            qr.ImageFormat = ImageFormat.Png;

            code = qr.drawBarcode();

            pictureBox1.Image = code;
        }

        //proses simpan barcode
        private void button2_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();

            sfd.Filter = "*.png | *.png";

            sfd.ShowDialog();



            if (sfd.FileName != null)

            {

                code.Save(sfd.FileName);

            }
        }
    }
}
