namespace RSound_A
{
    partial class PrimaryForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryForm));
            this.RSImage = new FlatUI.FormSkin();
            this.flatGroupBox4 = new FlatUI.FlatGroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblD = new FlatUI.FlatLabel();
            this.txtD = new FlatUI.FlatTextBox();
            this.flatLabel16 = new FlatUI.FlatLabel();
            this.txtN = new FlatUI.FlatTextBox();
            this.flatLabel15 = new FlatUI.FlatLabel();
            this.flatLabel14 = new FlatUI.FlatLabel();
            this.nbrToDecrypt = new FlatUI.FlatNumeric();
            this.flatLabel13 = new FlatUI.FlatLabel();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatGroupBox2 = new FlatUI.FlatGroupBox();
            this.flatGroupBox3 = new FlatUI.FlatGroupBox();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.flatLabel7 = new FlatUI.FlatLabel();
            this.privateKeyLabel = new FlatUI.FlatLabel();
            this.flatLabel9 = new FlatUI.FlatLabel();
            this.flatLabel10 = new FlatUI.FlatLabel();
            this.flatLabel11 = new FlatUI.FlatLabel();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatLabel12 = new FlatUI.FlatLabel();
            this.flatNumeric2 = new FlatUI.FlatNumeric();
            this.lblEncryptedMsg = new FlatUI.FlatLabel();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.lblPrivateKey = new FlatUI.FlatLabel();
            this.lblPublicKeys = new FlatUI.FlatLabel();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatNumeric1 = new FlatUI.FlatNumeric();
            this.flatGroupBox5 = new FlatUI.FlatGroupBox();
            this.exportPic = new FlatUI.FlatToggle();
            this.flatLabel8 = new FlatUI.FlatLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.flatButton5 = new FlatUI.FlatButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.isExportKeyWanted = new FlatUI.FlatToggle();
            this.flatButton4 = new FlatUI.FlatButton();
            this.statusLbl = new FlatUI.FlatAlertBox();
            this.flatButton6 = new FlatUI.FlatButton();
            this.flatButton7 = new FlatUI.FlatButton();
            this.txtBoxSoundPath = new FlatUI.FlatTextBox();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.importBtn = new FlatUI.FlatButton();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            this.RSImage.SuspendLayout();
            this.flatGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flatGroupBox2.SuspendLayout();
            this.flatGroupBox3.SuspendLayout();
            this.flatGroupBox5.SuspendLayout();
            this.flatGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RSImage
            // 
            this.RSImage.BackColor = System.Drawing.Color.White;
            this.RSImage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.RSImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.RSImage.Controls.Add(this.flatGroupBox4);
            this.RSImage.Controls.Add(this.lblD);
            this.RSImage.Controls.Add(this.txtD);
            this.RSImage.Controls.Add(this.flatLabel16);
            this.RSImage.Controls.Add(this.txtN);
            this.RSImage.Controls.Add(this.flatLabel15);
            this.RSImage.Controls.Add(this.flatLabel14);
            this.RSImage.Controls.Add(this.nbrToDecrypt);
            this.RSImage.Controls.Add(this.flatLabel13);
            this.RSImage.Controls.Add(this.flatButton3);
            this.RSImage.Controls.Add(this.flatGroupBox2);
            this.RSImage.Controls.Add(this.flatGroupBox5);
            this.RSImage.Controls.Add(this.flatGroupBox1);
            this.RSImage.Controls.Add(this.flatMini1);
            this.RSImage.Controls.Add(this.flatClose1);
            this.RSImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RSImage.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.RSImage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RSImage.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.RSImage.HeaderMaximize = false;
            this.RSImage.Location = new System.Drawing.Point(0, 0);
            this.RSImage.Name = "RSImage";
            this.RSImage.Size = new System.Drawing.Size(1112, 512);
            this.RSImage.TabIndex = 0;
            this.RSImage.Text = "RSImage";
            // 
            // flatGroupBox4
            // 
            this.flatGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox4.Controls.Add(this.pictureBox1);
            this.flatGroupBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox4.Location = new System.Drawing.Point(603, 51);
            this.flatGroupBox4.Name = "flatGroupBox4";
            this.flatGroupBox4.ShowText = true;
            this.flatGroupBox4.Size = new System.Drawing.Size(483, 455);
            this.flatGroupBox4.TabIndex = 37;
            this.flatGroupBox4.Text = "Preview";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RSound_A.Properties.Resources.Android_O_Preview_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.Transparent;
            this.lblD.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblD.Location = new System.Drawing.Point(448, 420);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(36, 20);
            this.lblD.TabIndex = 31;
            this.lblD.Text = "N/A";
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.Transparent;
            this.txtD.FocusOnHover = false;
            this.txtD.Location = new System.Drawing.Point(413, 383);
            this.txtD.MaxLength = 32767;
            this.txtD.Multiline = false;
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = false;
            this.txtD.Size = new System.Drawing.Size(173, 29);
            this.txtD.TabIndex = 35;
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtD.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtD.UseSystemPasswordChar = false;
            // 
            // flatLabel16
            // 
            this.flatLabel16.AutoSize = true;
            this.flatLabel16.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel16.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel16.ForeColor = System.Drawing.Color.White;
            this.flatLabel16.Location = new System.Drawing.Point(295, 420);
            this.flatLabel16.Name = "flatLabel16";
            this.flatLabel16.Size = new System.Drawing.Size(140, 20);
            this.flatLabel16.TabIndex = 34;
            this.flatLabel16.Text = "Decrypted message";
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.Color.Transparent;
            this.txtN.FocusOnHover = false;
            this.txtN.Location = new System.Drawing.Point(401, 347);
            this.txtN.MaxLength = 32767;
            this.txtN.Multiline = false;
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = false;
            this.txtN.Size = new System.Drawing.Size(185, 29);
            this.txtN.TabIndex = 22;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtN.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtN.UseSystemPasswordChar = false;
            // 
            // flatLabel15
            // 
            this.flatLabel15.AutoSize = true;
            this.flatLabel15.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel15.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel15.ForeColor = System.Drawing.Color.White;
            this.flatLabel15.Location = new System.Drawing.Point(293, 388);
            this.flatLabel15.Name = "flatLabel15";
            this.flatLabel15.Size = new System.Drawing.Size(114, 20);
            this.flatLabel15.TabIndex = 33;
            this.flatLabel15.Text = "Private key (d)  :";
            // 
            // flatLabel14
            // 
            this.flatLabel14.AutoSize = true;
            this.flatLabel14.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel14.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel14.ForeColor = System.Drawing.Color.White;
            this.flatLabel14.Location = new System.Drawing.Point(293, 349);
            this.flatLabel14.Name = "flatLabel14";
            this.flatLabel14.Size = new System.Drawing.Size(104, 20);
            this.flatLabel14.TabIndex = 32;
            this.flatLabel14.Text = "Public key (n) :";
            // 
            // nbrToDecrypt
            // 
            this.nbrToDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.nbrToDecrypt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.nbrToDecrypt.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.nbrToDecrypt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nbrToDecrypt.ForeColor = System.Drawing.Color.White;
            this.nbrToDecrypt.Location = new System.Drawing.Point(436, 309);
            this.nbrToDecrypt.Maximum = ((long)(999999999999999999));
            this.nbrToDecrypt.Minimum = ((long)(-999999999999999999));
            this.nbrToDecrypt.Name = "nbrToDecrypt";
            this.nbrToDecrypt.Size = new System.Drawing.Size(150, 30);
            this.nbrToDecrypt.TabIndex = 31;
            this.nbrToDecrypt.Value = ((long)(0));
            // 
            // flatLabel13
            // 
            this.flatLabel13.AutoSize = true;
            this.flatLabel13.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel13.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel13.ForeColor = System.Drawing.Color.White;
            this.flatLabel13.Location = new System.Drawing.Point(293, 310);
            this.flatLabel13.Name = "flatLabel13";
            this.flatLabel13.Size = new System.Drawing.Size(146, 20);
            this.flatLabel13.TabIndex = 31;
            this.flatLabel13.Text = "Number to decrypt : ";
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton3.Location = new System.Drawing.Point(297, 459);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(289, 32);
            this.flatButton3.TabIndex = 31;
            this.flatButton3.Text = "Build decrypted message";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.FlatButton3_Click);
            // 
            // flatGroupBox2
            // 
            this.flatGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox2.Controls.Add(this.flatGroupBox3);
            this.flatGroupBox2.Controls.Add(this.lblEncryptedMsg);
            this.flatGroupBox2.Controls.Add(this.flatLabel5);
            this.flatGroupBox2.Controls.Add(this.lblPrivateKey);
            this.flatGroupBox2.Controls.Add(this.lblPublicKeys);
            this.flatGroupBox2.Controls.Add(this.flatLabel4);
            this.flatGroupBox2.Controls.Add(this.flatLabel3);
            this.flatGroupBox2.Controls.Add(this.flatButton1);
            this.flatGroupBox2.Controls.Add(this.flatLabel2);
            this.flatGroupBox2.Controls.Add(this.flatNumeric1);
            this.flatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox2.Location = new System.Drawing.Point(12, 288);
            this.flatGroupBox2.Name = "flatGroupBox2";
            this.flatGroupBox2.ShowText = true;
            this.flatGroupBox2.Size = new System.Drawing.Size(277, 230);
            this.flatGroupBox2.TabIndex = 22;
            this.flatGroupBox2.Text = "Testing RSA";
            // 
            // flatGroupBox3
            // 
            this.flatGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox3.Controls.Add(this.flatLabel6);
            this.flatGroupBox3.Controls.Add(this.flatLabel7);
            this.flatGroupBox3.Controls.Add(this.privateKeyLabel);
            this.flatGroupBox3.Controls.Add(this.flatLabel9);
            this.flatGroupBox3.Controls.Add(this.flatLabel10);
            this.flatGroupBox3.Controls.Add(this.flatLabel11);
            this.flatGroupBox3.Controls.Add(this.flatButton2);
            this.flatGroupBox3.Controls.Add(this.flatLabel12);
            this.flatGroupBox3.Controls.Add(this.flatNumeric2);
            this.flatGroupBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox3.Location = new System.Drawing.Point(-9, -12);
            this.flatGroupBox3.Name = "flatGroupBox3";
            this.flatGroupBox3.ShowText = true;
            this.flatGroupBox3.Size = new System.Drawing.Size(589, 230);
            this.flatGroupBox3.TabIndex = 31;
            this.flatGroupBox3.Text = "Testing RSA";
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatLabel6.Location = new System.Drawing.Point(156, 146);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(36, 20);
            this.flatLabel6.TabIndex = 30;
            this.flatLabel6.Text = "N/A";
            // 
            // flatLabel7
            // 
            this.flatLabel7.AutoSize = true;
            this.flatLabel7.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel7.ForeColor = System.Drawing.Color.White;
            this.flatLabel7.Location = new System.Drawing.Point(13, 146);
            this.flatLabel7.Name = "flatLabel7";
            this.flatLabel7.Size = new System.Drawing.Size(137, 20);
            this.flatLabel7.TabIndex = 29;
            this.flatLabel7.Text = "Encrypted message";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.privateKeyLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.privateKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.privateKeyLabel.Location = new System.Drawing.Point(123, 109);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(36, 20);
            this.privateKeyLabel.TabIndex = 28;
            this.privateKeyLabel.Text = "N/A";
            // 
            // flatLabel9
            // 
            this.flatLabel9.AutoSize = true;
            this.flatLabel9.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatLabel9.Location = new System.Drawing.Point(141, 76);
            this.flatLabel9.Name = "flatLabel9";
            this.flatLabel9.Size = new System.Drawing.Size(29, 15);
            this.flatLabel9.TabIndex = 27;
            this.flatLabel9.Text = "N/A";
            // 
            // flatLabel10
            // 
            this.flatLabel10.AutoSize = true;
            this.flatLabel10.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel10.ForeColor = System.Drawing.Color.White;
            this.flatLabel10.Location = new System.Drawing.Point(13, 109);
            this.flatLabel10.Name = "flatLabel10";
            this.flatLabel10.Size = new System.Drawing.Size(106, 20);
            this.flatLabel10.TabIndex = 26;
            this.flatLabel10.Text = "Private key (d):";
            // 
            // flatLabel11
            // 
            this.flatLabel11.AutoSize = true;
            this.flatLabel11.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel11.ForeColor = System.Drawing.Color.White;
            this.flatLabel11.Location = new System.Drawing.Point(13, 72);
            this.flatLabel11.Name = "flatLabel11";
            this.flatLabel11.Size = new System.Drawing.Size(127, 20);
            this.flatLabel11.TabIndex = 25;
            this.flatLabel11.Text = "Publics keys (n, e):";
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton2.Location = new System.Drawing.Point(17, 185);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(266, 32);
            this.flatButton2.TabIndex = 24;
            this.flatButton2.Text = "Build encrypted message";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.FlatButton1_Click);
            // 
            // flatLabel12
            // 
            this.flatLabel12.AutoSize = true;
            this.flatLabel12.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel12.ForeColor = System.Drawing.Color.White;
            this.flatLabel12.Location = new System.Drawing.Point(13, 38);
            this.flatLabel12.Name = "flatLabel12";
            this.flatLabel12.Size = new System.Drawing.Size(129, 20);
            this.flatLabel12.TabIndex = 23;
            this.flatLabel12.Text = "Number to crypt : ";
            // 
            // flatNumeric2
            // 
            this.flatNumeric2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatNumeric2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatNumeric2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatNumeric2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatNumeric2.ForeColor = System.Drawing.Color.White;
            this.flatNumeric2.Location = new System.Drawing.Point(145, 32);
            this.flatNumeric2.Maximum = ((long)(999999999999999999));
            this.flatNumeric2.Minimum = ((long)(-999999999999999999));
            this.flatNumeric2.Name = "flatNumeric2";
            this.flatNumeric2.Size = new System.Drawing.Size(138, 30);
            this.flatNumeric2.TabIndex = 0;
            this.flatNumeric2.Text = "flatNumeric2";
            this.flatNumeric2.Value = ((long)(0));
            // 
            // lblEncryptedMsg
            // 
            this.lblEncryptedMsg.AutoSize = true;
            this.lblEncryptedMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblEncryptedMsg.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEncryptedMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEncryptedMsg.Location = new System.Drawing.Point(157, 134);
            this.lblEncryptedMsg.Name = "lblEncryptedMsg";
            this.lblEncryptedMsg.Size = new System.Drawing.Size(36, 20);
            this.lblEncryptedMsg.TabIndex = 30;
            this.lblEncryptedMsg.Text = "N/A";
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(13, 134);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(137, 20);
            this.flatLabel5.TabIndex = 29;
            this.flatLabel5.Text = "Encrypted message";
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.BackColor = System.Drawing.Color.Transparent;
            this.lblPrivateKey.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPrivateKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPrivateKey.Location = new System.Drawing.Point(129, 105);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(36, 20);
            this.lblPrivateKey.TabIndex = 28;
            this.lblPrivateKey.Text = "N/A";
            // 
            // lblPublicKeys
            // 
            this.lblPublicKeys.AutoSize = true;
            this.lblPublicKeys.BackColor = System.Drawing.Color.Transparent;
            this.lblPublicKeys.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPublicKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPublicKeys.Location = new System.Drawing.Point(129, 75);
            this.lblPublicKeys.Name = "lblPublicKeys";
            this.lblPublicKeys.Size = new System.Drawing.Size(36, 20);
            this.lblPublicKeys.TabIndex = 27;
            this.lblPublicKeys.Text = "N/A";
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(13, 105);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(87, 20);
            this.flatLabel4.TabIndex = 26;
            this.flatLabel4.Text = "Private key :";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(13, 75);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(94, 20);
            this.flatLabel3.TabIndex = 25;
            this.flatLabel3.Text = "Publics keys :";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton1.Location = new System.Drawing.Point(15, 168);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(218, 32);
            this.flatButton1.TabIndex = 24;
            this.flatButton1.Text = "Build encrypted message";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.FlatButton1_Click);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(13, 38);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(129, 20);
            this.flatLabel2.TabIndex = 23;
            this.flatLabel2.Text = "Number to crypt : ";
            // 
            // flatNumeric1
            // 
            this.flatNumeric1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatNumeric1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatNumeric1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatNumeric1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatNumeric1.ForeColor = System.Drawing.Color.White;
            this.flatNumeric1.Location = new System.Drawing.Point(160, 36);
            this.flatNumeric1.Maximum = ((long)(9999999));
            this.flatNumeric1.Minimum = ((long)(0));
            this.flatNumeric1.Name = "flatNumeric1";
            this.flatNumeric1.Size = new System.Drawing.Size(107, 30);
            this.flatNumeric1.TabIndex = 0;
            this.flatNumeric1.Text = "flatNumeric1";
            this.flatNumeric1.Value = ((long)(0));
            // 
            // flatGroupBox5
            // 
            this.flatGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox5.Controls.Add(this.exportPic);
            this.flatGroupBox5.Controls.Add(this.flatLabel8);
            this.flatGroupBox5.Controls.Add(this.linkLabel1);
            this.flatGroupBox5.Controls.Add(this.flatButton5);
            this.flatGroupBox5.Controls.Add(this.flatLabel1);
            this.flatGroupBox5.Controls.Add(this.isExportKeyWanted);
            this.flatGroupBox5.Controls.Add(this.flatButton4);
            this.flatGroupBox5.Controls.Add(this.statusLbl);
            this.flatGroupBox5.Controls.Add(this.flatButton6);
            this.flatGroupBox5.Controls.Add(this.flatButton7);
            this.flatGroupBox5.Controls.Add(this.txtBoxSoundPath);
            this.flatGroupBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox5.Location = new System.Drawing.Point(3, 49);
            this.flatGroupBox5.Name = "flatGroupBox5";
            this.flatGroupBox5.ShowText = true;
            this.flatGroupBox5.Size = new System.Drawing.Size(596, 236);
            this.flatGroupBox5.TabIndex = 17;
            this.flatGroupBox5.Text = "                                             Import your image";
            // 
            // exportPic
            // 
            this.exportPic.BackColor = System.Drawing.Color.Transparent;
            this.exportPic.Checked = true;
            this.exportPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportPic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exportPic.Location = new System.Drawing.Point(461, 179);
            this.exportPic.Name = "exportPic";
            this.exportPic.Options = FlatUI.FlatToggle._Options.Style1;
            this.exportPic.Size = new System.Drawing.Size(76, 33);
            this.exportPic.TabIndex = 42;
            this.exportPic.Text = "flatToggle1";
            // 
            // flatLabel8
            // 
            this.flatLabel8.AutoSize = true;
            this.flatLabel8.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel8.ForeColor = System.Drawing.Color.White;
            this.flatLabel8.Location = new System.Drawing.Point(250, 184);
            this.flatLabel8.Name = "flatLabel8";
            this.flatLabel8.Size = new System.Drawing.Size(216, 21);
            this.flatLabel8.TabIndex = 41;
            this.flatLabel8.Text = "Export the encrypted picture : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.linkLabel1.Location = new System.Drawing.Point(132, 189);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(15, 19);
            this.linkLabel1.TabIndex = 40;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.Gray;
            this.flatButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton5.Location = new System.Drawing.Point(405, 76);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Rounded = false;
            this.flatButton5.Size = new System.Drawing.Size(132, 42);
            this.flatButton5.TabIndex = 39;
            this.flatButton5.Text = "Import keys";
            this.flatButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton5.Click += new System.EventHandler(this.FlatButton5_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(13, 186);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(122, 21);
            this.flatLabel1.TabIndex = 38;
            this.flatLabel1.Text = "Export the keys :";
            // 
            // isExportKeyWanted
            // 
            this.isExportKeyWanted.BackColor = System.Drawing.Color.Transparent;
            this.isExportKeyWanted.Checked = true;
            this.isExportKeyWanted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isExportKeyWanted.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.isExportKeyWanted.Location = new System.Drawing.Point(155, 179);
            this.isExportKeyWanted.Name = "isExportKeyWanted";
            this.isExportKeyWanted.Options = FlatUI.FlatToggle._Options.Style1;
            this.isExportKeyWanted.Size = new System.Drawing.Size(76, 33);
            this.isExportKeyWanted.TabIndex = 37;
            this.isExportKeyWanted.Text = "flatToggle1";
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton4.Location = new System.Drawing.Point(185, 129);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(171, 40);
            this.flatButton4.TabIndex = 36;
            this.flatButton4.Text = "Decrypt the picture";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.Click += new System.EventHandler(this.FlatButton4_Click_1);
            // 
            // statusLbl
            // 
            this.statusLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.statusLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusLbl.kind = FlatUI.FlatAlertBox._Kind.Info;
            this.statusLbl.Location = new System.Drawing.Point(17, 76);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(382, 42);
            this.statusLbl.TabIndex = 19;
            this.statusLbl.Text = "You need to import a sound";
            this.statusLbl.Visible = false;
            // 
            // flatButton6
            // 
            this.flatButton6.BackColor = System.Drawing.Color.Transparent;
            this.flatButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton6.Location = new System.Drawing.Point(383, 129);
            this.flatButton6.Name = "flatButton6";
            this.flatButton6.Rounded = false;
            this.flatButton6.Size = new System.Drawing.Size(154, 39);
            this.flatButton6.TabIndex = 15;
            this.flatButton6.Text = "Browse image";
            this.flatButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton6.Click += new System.EventHandler(this.ImportBtn_Click_1);
            // 
            // flatButton7
            // 
            this.flatButton7.BackColor = System.Drawing.Color.Transparent;
            this.flatButton7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton7.Location = new System.Drawing.Point(17, 129);
            this.flatButton7.Name = "flatButton7";
            this.flatButton7.Rounded = false;
            this.flatButton7.Size = new System.Drawing.Size(141, 40);
            this.flatButton7.TabIndex = 16;
            this.flatButton7.Text = "Crypt the picture";
            this.flatButton7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton7.Click += new System.EventHandler(this.BtnCrypt_Click_1);
            // 
            // txtBoxSoundPath
            // 
            this.txtBoxSoundPath.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxSoundPath.FocusOnHover = false;
            this.txtBoxSoundPath.Location = new System.Drawing.Point(17, 41);
            this.txtBoxSoundPath.MaxLength = 32767;
            this.txtBoxSoundPath.Multiline = false;
            this.txtBoxSoundPath.Name = "txtBoxSoundPath";
            this.txtBoxSoundPath.ReadOnly = false;
            this.txtBoxSoundPath.Size = new System.Drawing.Size(523, 29);
            this.txtBoxSoundPath.TabIndex = 14;
            this.txtBoxSoundPath.Text = "C:\\";
            this.txtBoxSoundPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxSoundPath.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBoxSoundPath.UseSystemPasswordChar = false;
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox1.Controls.Add(this.importBtn);
            this.flatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox1.Location = new System.Drawing.Point(15, 55);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = true;
            this.flatGroupBox1.Size = new System.Drawing.Size(358, 245);
            this.flatGroupBox1.TabIndex = 17;
            this.flatGroupBox1.Text = "                              Import your image";
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.Transparent;
            this.importBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.importBtn.Location = new System.Drawing.Point(114, 132);
            this.importBtn.Name = "importBtn";
            this.importBtn.Rounded = false;
            this.importBtn.Size = new System.Drawing.Size(130, 32);
            this.importBtn.TabIndex = 15;
            this.importBtn.Text = "Browse .png file";
            this.importBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.importBtn.Click += new System.EventHandler(this.ImportBtn_Click_1);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(1068, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 11;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(1092, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 10;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 512);
            this.Controls.Add(this.RSImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrimaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSound-A";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.RSImage.ResumeLayout(false);
            this.RSImage.PerformLayout();
            this.flatGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flatGroupBox2.ResumeLayout(false);
            this.flatGroupBox2.PerformLayout();
            this.flatGroupBox3.ResumeLayout(false);
            this.flatGroupBox3.PerformLayout();
            this.flatGroupBox5.ResumeLayout(false);
            this.flatGroupBox5.PerformLayout();
            this.flatGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin RSImage;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private FlatUI.FlatButton importBtn;
        private FlatUI.FlatGroupBox flatGroupBox2;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatNumeric flatNumeric1;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatLabel lblPrivateKey;
        private FlatUI.FlatLabel lblPublicKeys;
        private FlatUI.FlatLabel lblEncryptedMsg;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatGroupBox flatGroupBox3;
        private FlatUI.FlatLabel flatLabel6;
        private FlatUI.FlatLabel flatLabel7;
        private FlatUI.FlatLabel privateKeyLabel;
        private FlatUI.FlatLabel flatLabel9;
        private FlatUI.FlatLabel flatLabel10;
        private FlatUI.FlatLabel flatLabel11;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatLabel flatLabel12;
        private FlatUI.FlatNumeric flatNumeric2;
        private FlatUI.FlatNumeric nbrToDecrypt;
        private FlatUI.FlatLabel flatLabel13;
        private FlatUI.FlatTextBox txtD;
        private FlatUI.FlatLabel flatLabel16;
        private FlatUI.FlatLabel flatLabel15;
        private FlatUI.FlatLabel flatLabel14;
        private FlatUI.FlatTextBox txtN;
        private FlatUI.FlatLabel lblD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatGroupBox flatGroupBox4;
        private FlatUI.FlatGroupBox flatGroupBox5;
        private FlatUI.FlatButton flatButton6;
        private FlatUI.FlatButton flatButton7;
        private FlatUI.FlatButton flatButton4;
        private FlatUI.FlatAlertBox statusLbl;
        private FlatUI.FlatTextBox txtBoxSoundPath;
        private FlatUI.FlatButton flatButton5;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatToggle isExportKeyWanted;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FlatUI.FlatToggle exportPic;
        private FlatUI.FlatLabel flatLabel8;
    }
}
