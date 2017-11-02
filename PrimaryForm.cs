using System;
using System.Windows.Forms;
using Encryption;
using System.Drawing;
using System.Collections.Generic;
using System.Numerics;
using System.IO;
using System.Linq;

namespace RSound_A
{

    public partial class PrimaryForm : Form
    {

        private String SoundPath = String.Empty;   
        RSA PreparedRSA = new RSA();
        RSA myRSA = new RSA();
        Bitmap mainPic, cryptedPic;
        List<List<BigInteger>> mesPixels = new List<List<BigInteger>>();

        public PrimaryForm()
        {
            InitializeComponent();            
            txtBoxSoundPath.Text = Directory.GetCurrentDirectory() + @"\Samples\";
            statusLbl.Visible = true;
            flatButton5.BaseColor = Color.Red;

        }


        void Import()
        {

            OpenFileDialog openSound = new OpenFileDialog() {
                Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg",
                Title = "Please, select an image",
                FileName = Directory.GetCurrentDirectory() + @"\Samples\",
                
            };

            if (openSound.ShowDialog() == DialogResult.OK) {
                SoundPath = openSound.FileName;
                txtBoxSoundPath.Text = SoundPath;
                ChangeStatus("Image opened with success!", FlatUI.FlatAlertBox._Kind.Success);
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

        public void ExportKeys()
        {
            String keys = String.Empty;
            String path = String.Empty;

            if (isExportKeyWanted.Checked) {

                SaveFileDialog saveKeys = new SaveFileDialog() {
                    Filter = "Key File (*.keys)|*.keys",
                    Title = "Please, select a place to save keys",
                    FileName = Directory.GetCurrentDirectory(),
                    DefaultExt = ".keys"
                };
                if (saveKeys.ShowDialog() == DialogResult.OK) 
                    path = saveKeys.FileName;


                using (var sw = new StreamWriter(path)) {
                    for (int i = 0; i < mesPixels.Count; i++) {
                        for (int j = 0; j < mesPixels[i].Count; j++) {
                            sw.Write(mesPixels[i][j].ToString() + (j == mesPixels[i].Count -1 ? "" : ","));
                        }
                        sw.Write("\n");
                    }
                     //Ajout des clées privées et publique
                    sw.Write("|");
                    sw.Write(PreparedRSA.GetPrivateKey().ToString() + "|" + PreparedRSA.GetPublickey()[0].ToString()  + "|" + PreparedRSA.GetPublickey()[1].ToString());


                    sw.Flush();
                    sw.Close();
                }
 
                File.AppendAllText(path, keys);
            }
        }


     
        private void BtnCrypt_Click_1(object sender, EventArgs e)
        {
            cryptedPic = mainPic;

            try {
                List<BigInteger> oneLineOfPixel = new List<BigInteger>();

                for (int X = 0; X < cryptedPic.Width; X++) {
                      for (int Y = 0; Y < cryptedPic.Height; Y++)  {

                        Color pixelColor = cryptedPic.GetPixel(X, Y);                             
                        BigInteger.TryParse(pixelColor.ToArgb().ToString(), out BigInteger pixelToArgb);
                        Color cryptedPixel = Color.FromArgb((int)(PreparedRSA.Crypt(pixelToArgb) % int.MaxValue));

                        oneLineOfPixel.Add(PreparedRSA.Crypt(pixelToArgb));
                        cryptedPic.SetPixel(X, Y, cryptedPixel);

                     }

                    mesPixels.Add(oneLineOfPixel);
                    oneLineOfPixel = new List<BigInteger>();
                }

                pictureBox1.Image = cryptedPic;
                ExportKeys();
                ExportCryptedPicture();
            }

            catch (DivideByZeroException error) {
                MessageBox.Show(error.Data + "\n" + error.Message + "\n" + error.Source, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeStatus("An error happened !", FlatUI.FlatAlertBox._Kind.Error);
                Application.Exit();
            }
            ChangeStatus("Done with success!", FlatUI.FlatAlertBox._Kind.Success);
         
        }

        private void ExportCryptedPicture()
        {
            String path = String.Empty;

            if (exportPic.Checked) {

                SaveFileDialog saveImage = new SaveFileDialog() {
                    Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg",
                    Title = "Please, select an image",
                    FileName = Directory.GetCurrentDirectory() + @"\Samples\"
                };

                if (saveImage.ShowDialog() == DialogResult.OK)
                    path = saveImage.FileName;

                cryptedPic.Save(path);
            }
        }

        private void FlatButton4_Click_1(object sender, EventArgs e)
        {
            cryptedPic = mainPic;
             try {
                for (int X = 0; X < cryptedPic.Width; X++) {
                    for (int Y = 0; Y < cryptedPic.Height ; Y++) {

 
                      Color decryptedPixel = Color.FromArgb((int)PreparedRSA.Decrypt(mesPixels[X][Y]));
                      cryptedPic.SetPixel(X, Y, decryptedPixel);

 
                    }
                }
                pictureBox1.Image = cryptedPic;
                mesPixels = new List<List<BigInteger>>();
            }
           
            catch (DivideByZeroException error) {
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

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "If you want to decrypt an image that you crypted few days ago for example, you'll have to import the keys, since" +
                " the application won't know (after restarting) the keys."
                );
        }

        private void FlatButton5_Click(object sender, EventArgs e)
        {
            String path = String.Empty;
            OpenFileDialog openSound = new OpenFileDialog() {
                Filter = "Keys Files (*.keys)|*.keys",
                Title = "Please, select a key file",
                FileName = Directory.GetCurrentDirectory() + @"\Samples\",

            };

            if (openSound.ShowDialog() == DialogResult.OK) {
               ChangeStatus("Keys decoded with success!", FlatUI.FlatAlertBox._Kind.Success);
                path = openSound.FileName;
            }


           string[] readedKeys = File.ReadAllLines(path);
           string publicAndPrivateKey = readedKeys[readedKeys.Length-1];

            Array.Resize(ref readedKeys, readedKeys.Length - 1);
            mesPixels = readedKeys.Select(x => x.Split(',').Select(y => BigInteger.Parse(y)).ToList()).ToList();
      

            BigInteger.TryParse(File.ReadAllText(path).Split('|')[1], out BigInteger privateKey);
            BigInteger.TryParse(File.ReadAllText(path).Split('|')[2], out BigInteger publicKey_N);
            BigInteger.TryParse(File.ReadAllText(path).Split('|')[3], out BigInteger publicKey_E);


            PreparedRSA.SetPrivateKey(privateKey);
            PreparedRSA.SetPublicKey(new List<BigInteger> { publicKey_N, publicKey_E });
 
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
 
 