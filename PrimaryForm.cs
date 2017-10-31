using System;
 using System.Windows.Forms;
using Encryption;
using System.Drawing;
using System.Collections.Generic;
using System.Numerics;

namespace RSound_A
{

    public partial class PrimaryForm : Form
    {

        private String SoundPath = String.Empty;   
        RSA PreparedRSA = new RSA();
        RSA myRSA = new RSA();
        Bitmap mainPic;
        Bitmap cryptedPic;
        List<List<BigInteger>> mesPixels = new List<List<BigInteger>>();

        public PrimaryForm()
        {
            InitializeComponent();            
            statusLbl.Visible = true;
            txtBoxSoundPath.Text = System.IO.Directory.GetCurrentDirectory();

        }

  
        void Import()
        {


            OpenFileDialog openSound = new OpenFileDialog() {
                Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg",
            Title = "Please, select a .wav file"
            };

            if (openSound.ShowDialog() == DialogResult.OK) {
                SoundPath = openSound.FileName;
                txtBoxSoundPath.Text = SoundPath;
                ChangeStatus("Sound opened with success!", FlatUI.FlatAlertBox._Kind.Success);

            }
            mainPic = new Bitmap(SoundPath);
            pictureBox1.Image = mainPic;
        }
        private void ImportBtn_Click_1(object sender, EventArgs e)
        {
            Import();

        }         
        private void ChangeStatus(string Message, FlatUI.FlatAlertBox._Kind kind)
        {
            statusLbl.Text = Message;
            statusLbl.kind = kind;
        }

        
     
        private void BtnCrypt_Click_1(object sender, EventArgs e)
        {
            cryptedPic = mainPic;

            try {
                List<BigInteger> oneLineOfPixel = new List<BigInteger>();

                for (int ii = 0; ii < cryptedPic.Width; ii++) {
                      for (int jj = 0; jj < cryptedPic.Height; jj++)  {

                       Color pixelColor = cryptedPic.GetPixel(ii, jj);

                        BigInteger.TryParse(pixelColor.ToArgb().ToString(), out BigInteger pixelToArgb);
                        BigInteger.TryParse(pixelColor.R.ToString(), out BigInteger R);
                        BigInteger.TryParse(pixelColor.G.ToString(), out BigInteger G);
                        BigInteger.TryParse(pixelColor.B.ToString(), out BigInteger B);

                        oneLineOfPixel.Add(PreparedRSA.Crypt(pixelToArgb));

                        int futureArgb = (int)(PreparedRSA.Crypt(B + R + G) % 2147483647);
                        Color cryptedPixel = Color.FromArgb(futureArgb);

                        cryptedPic.SetPixel(ii, jj, cryptedPixel);

                     }
                    mesPixels.Add(oneLineOfPixel);
                    oneLineOfPixel = new List<BigInteger>();
                }

                pictureBox1.Image = cryptedPic;

            }

            catch (DivideByZeroException error) {
                MessageBox.Show(error.Data + "\n" + error.Message + "\n" + error.Source, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeStatus("An error happened !", FlatUI.FlatAlertBox._Kind.Error);
                Application.Exit();
            }
            ChangeStatus("Done with success!", FlatUI.FlatAlertBox._Kind.Success);
         
        }

        private void FlatButton4_Click_1(object sender, EventArgs e)
        {

             try {

                for (int ii = 0; ii < cryptedPic.Width; ii++) {
                    for (int jj = 0; jj < cryptedPic.Height ; jj++) {                         

                      Color decryptedPixel = Color.FromArgb((int)PreparedRSA.Decrypt(mesPixels[ii][jj]));
                      cryptedPic.SetPixel(ii, jj, decryptedPixel);

 
                    }
                }
                pictureBox1.Image = cryptedPic;
                mesPixels = new List<List<BigInteger>>();
            }
           
            catch (Exception error) {
                MessageBox.Show(error.Data + "\n" + error.Message + "\n" + error.Source, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeStatus("An error happened !", FlatUI.FlatAlertBox._Kind.Error);
                Application.Exit();
            }
            ChangeStatus("Done with success!", FlatUI.FlatAlertBox._Kind.Success);


        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {

            privateKeyLabel.Text = PreparedRSA.GetPrivateKey().ToString();
            flatLabel9.Text = PreparedRSA.GetPublickey()[0] + " & " + myRSA.GetPublickey()[1];
            flatLabel6.Text = PreparedRSA.Crypt(Convert.ToInt32(flatNumeric2.Value)).ToString();

            BigInteger.TryParse(flatLabel6.Text, out BigInteger toDecrypt);

            lblD.Text = PreparedRSA.Decrypt(toDecrypt).ToString();
        }
        private void FlatButton2_Click(object sender, EventArgs e)
        {
            Import();
        }
        private void FlatButton3_Click(object sender, EventArgs e)
        {

            BigInteger.TryParse(nbrToDecrypt.Value.ToString(), out BigInteger toDecrypt);
            BigInteger.TryParse(txtN.Text, out BigInteger N);
            BigInteger.TryParse(txtD.Text, out BigInteger D);
            lblD.Text = PreparedRSA.Decrypt(toDecrypt, D, N).ToString();
        }
     
    }
}