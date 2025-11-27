namespace PizzaSipariş
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            checkBoxDomates = new CheckBox();
            checkBoxSalam = new CheckBox();
            checkBoxZeytin = new CheckBox();
            checkBoxBiber = new CheckBox();
            checkBoxMantar = new CheckBox();
            checkBoxMisir = new CheckBox();
            checkBoxSosis = new CheckBox();
            checkBoxSucuk = new CheckBox();
            groupBoxBoyut = new GroupBox();
            radioButtonBuyuk = new RadioButton();
            radioButtonOrta = new RadioButton();
            radioButtonKucuk = new RadioButton();
            listBoxMalzemeler = new ListBox();
            labelSecimler = new Label();
            buttonHesapla = new Button();
            label1 = new Label();
            textBoxFiyat = new TextBox();
            buttonEkle = new Button();
            buttonCikar = new Button();
            labelBaslik = new Label();
            groupBox1.SuspendLayout();
            groupBoxBoyut.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxDomates);
            groupBox1.Controls.Add(checkBoxSalam);
            groupBox1.Controls.Add(checkBoxZeytin);
            groupBox1.Controls.Add(checkBoxBiber);
            groupBox1.Controls.Add(checkBoxMantar);
            groupBox1.Controls.Add(checkBoxMisir);
            groupBox1.Controls.Add(checkBoxSosis);
            groupBox1.Controls.Add(checkBoxSucuk);
            groupBox1.Location = new Point(33, 84);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(291, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Malzeme Seçimi(Malzeme Başına +5 TL):";
            // 
            // checkBoxDomates
            // 
            checkBoxDomates.AutoSize = true;
            checkBoxDomates.Location = new Point(183, 207);
            checkBoxDomates.Margin = new Padding(3, 4, 3, 4);
            checkBoxDomates.Name = "checkBoxDomates";
            checkBoxDomates.Size = new Size(91, 24);
            checkBoxDomates.TabIndex = 8;
            checkBoxDomates.Text = "Domates";
            checkBoxDomates.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalam
            // 
            checkBoxSalam.AutoSize = true;
            checkBoxSalam.Location = new Point(183, 152);
            checkBoxSalam.Margin = new Padding(3, 4, 3, 4);
            checkBoxSalam.Name = "checkBoxSalam";
            checkBoxSalam.Size = new Size(72, 24);
            checkBoxSalam.TabIndex = 7;
            checkBoxSalam.Text = "Salam";
            checkBoxSalam.UseVisualStyleBackColor = true;
            // 
            // checkBoxZeytin
            // 
            checkBoxZeytin.AutoSize = true;
            checkBoxZeytin.Location = new Point(189, 100);
            checkBoxZeytin.Margin = new Padding(3, 4, 3, 4);
            checkBoxZeytin.Name = "checkBoxZeytin";
            checkBoxZeytin.Size = new Size(72, 24);
            checkBoxZeytin.TabIndex = 6;
            checkBoxZeytin.Text = "Zeytin";
            checkBoxZeytin.UseVisualStyleBackColor = true;
            // 
            // checkBoxBiber
            // 
            checkBoxBiber.AutoSize = true;
            checkBoxBiber.Location = new Point(189, 49);
            checkBoxBiber.Margin = new Padding(3, 4, 3, 4);
            checkBoxBiber.Name = "checkBoxBiber";
            checkBoxBiber.Size = new Size(66, 24);
            checkBoxBiber.TabIndex = 5;
            checkBoxBiber.Text = "Biber";
            checkBoxBiber.UseVisualStyleBackColor = true;
            // 
            // checkBoxMantar
            // 
            checkBoxMantar.AutoSize = true;
            checkBoxMantar.Location = new Point(14, 207);
            checkBoxMantar.Margin = new Padding(3, 4, 3, 4);
            checkBoxMantar.Name = "checkBoxMantar";
            checkBoxMantar.Size = new Size(78, 24);
            checkBoxMantar.TabIndex = 4;
            checkBoxMantar.Text = "Mantar";
            checkBoxMantar.UseVisualStyleBackColor = true;
            // 
            // checkBoxMisir
            // 
            checkBoxMisir.AutoSize = true;
            checkBoxMisir.Location = new Point(14, 152);
            checkBoxMisir.Margin = new Padding(3, 4, 3, 4);
            checkBoxMisir.Name = "checkBoxMisir";
            checkBoxMisir.Size = new Size(63, 24);
            checkBoxMisir.TabIndex = 3;
            checkBoxMisir.Text = "Mısır";
            checkBoxMisir.UseVisualStyleBackColor = true;
            // 
            // checkBoxSosis
            // 
            checkBoxSosis.AutoSize = true;
            checkBoxSosis.Location = new Point(14, 100);
            checkBoxSosis.Margin = new Padding(3, 4, 3, 4);
            checkBoxSosis.Name = "checkBoxSosis";
            checkBoxSosis.Size = new Size(64, 24);
            checkBoxSosis.TabIndex = 2;
            checkBoxSosis.Text = "Sosis";
            checkBoxSosis.UseVisualStyleBackColor = true;
            // 
            // checkBoxSucuk
            // 
            checkBoxSucuk.AutoSize = true;
            checkBoxSucuk.Location = new Point(14, 49);
            checkBoxSucuk.Margin = new Padding(3, 4, 3, 4);
            checkBoxSucuk.Name = "checkBoxSucuk";
            checkBoxSucuk.Size = new Size(69, 24);
            checkBoxSucuk.TabIndex = 1;
            checkBoxSucuk.Text = "Sucuk";
            checkBoxSucuk.UseVisualStyleBackColor = true;
            // 
            // groupBoxBoyut
            // 
            groupBoxBoyut.Controls.Add(radioButtonBuyuk);
            groupBoxBoyut.Controls.Add(radioButtonOrta);
            groupBoxBoyut.Controls.Add(radioButtonKucuk);
            groupBoxBoyut.Location = new Point(47, 405);
            groupBoxBoyut.Margin = new Padding(3, 4, 3, 4);
            groupBoxBoyut.Name = "groupBoxBoyut";
            groupBoxBoyut.Padding = new Padding(3, 4, 3, 4);
            groupBoxBoyut.Size = new Size(229, 157);
            groupBoxBoyut.TabIndex = 1;
            groupBoxBoyut.TabStop = false;
            groupBoxBoyut.Text = "Pizza Boyutu:";
            // 
            // radioButtonBuyuk
            // 
            radioButtonBuyuk.AutoSize = true;
            radioButtonBuyuk.Location = new Point(7, 119);
            radioButtonBuyuk.Margin = new Padding(3, 4, 3, 4);
            radioButtonBuyuk.Name = "radioButtonBuyuk";
            radioButtonBuyuk.Size = new Size(122, 24);
            radioButtonBuyuk.TabIndex = 4;
            radioButtonBuyuk.TabStop = true;
            radioButtonBuyuk.Text = "Büyük(200 TL)";
            radioButtonBuyuk.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrta
            // 
            radioButtonOrta.AutoSize = true;
            radioButtonOrta.Location = new Point(7, 76);
            radioButtonOrta.Margin = new Padding(3, 4, 3, 4);
            radioButtonOrta.Name = "radioButtonOrta";
            radioButtonOrta.Size = new Size(112, 24);
            radioButtonOrta.TabIndex = 3;
            radioButtonOrta.TabStop = true;
            radioButtonOrta.Text = "Orta(150 TL)";
            radioButtonOrta.UseVisualStyleBackColor = true;
            // 
            // radioButtonKucuk
            // 
            radioButtonKucuk.AutoSize = true;
            radioButtonKucuk.Location = new Point(7, 29);
            radioButtonKucuk.Margin = new Padding(3, 4, 3, 4);
            radioButtonKucuk.Name = "radioButtonKucuk";
            radioButtonKucuk.Size = new Size(122, 24);
            radioButtonKucuk.TabIndex = 2;
            radioButtonKucuk.TabStop = true;
            radioButtonKucuk.Text = "Küçük(100 TL)";
            radioButtonKucuk.UseVisualStyleBackColor = true;
            // 
            // listBoxMalzemeler
            // 
            listBoxMalzemeler.FormattingEnabled = true;
            listBoxMalzemeler.ItemHeight = 20;
            listBoxMalzemeler.Location = new Point(585, 113);
            listBoxMalzemeler.Margin = new Padding(3, 4, 3, 4);
            listBoxMalzemeler.Name = "listBoxMalzemeler";
            listBoxMalzemeler.Size = new Size(203, 204);
            listBoxMalzemeler.TabIndex = 2;
            // 
            // labelSecimler
            // 
            labelSecimler.AutoSize = true;
            labelSecimler.Location = new Point(585, 89);
            labelSecimler.Name = "labelSecimler";
            labelSecimler.Size = new Size(141, 20);
            labelSecimler.TabIndex = 3;
            labelSecimler.Text = "Seçilen Malzemeler:";
            // 
            // buttonHesapla
            // 
            buttonHesapla.Location = new Point(320, 479);
            buttonHesapla.Margin = new Padding(3, 4, 3, 4);
            buttonHesapla.Name = "buttonHesapla";
            buttonHesapla.Size = new Size(86, 31);
            buttonHesapla.TabIndex = 4;
            buttonHesapla.Text = "HESAPLA>";
            buttonHesapla.UseVisualStyleBackColor = true;
            buttonHesapla.Click += buttonHesapla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 484);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 5;
            label1.Text = "Ödeme Tutarı:";
            // 
            // textBoxFiyat
            // 
            textBoxFiyat.Location = new Point(598, 481);
            textBoxFiyat.Margin = new Padding(3, 4, 3, 4);
            textBoxFiyat.Name = "textBoxFiyat";
            textBoxFiyat.Size = new Size(79, 27);
            textBoxFiyat.TabIndex = 6;
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(353, 148);
            buttonEkle.Margin = new Padding(3, 4, 3, 4);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(86, 31);
            buttonEkle.TabIndex = 7;
            buttonEkle.Text = "EKLE>";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // buttonCikar
            // 
            buttonCikar.Location = new Point(353, 215);
            buttonCikar.Margin = new Padding(3, 4, 3, 4);
            buttonCikar.Name = "buttonCikar";
            buttonCikar.Size = new Size(86, 31);
            buttonCikar.TabIndex = 8;
            buttonCikar.Text = "<ÇIKAR";
            buttonCikar.UseVisualStyleBackColor = true;
            buttonCikar.Click += buttonCikar_Click;
            // 
            // labelBaslik
            // 
            labelBaslik.AutoSize = true;
            labelBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelBaslik.ForeColor = Color.Firebrick;
            labelBaslik.Location = new Point(280, 28);
            labelBaslik.Name = "labelBaslik";
            labelBaslik.Size = new Size(266, 37);
            labelBaslik.TabIndex = 9;
            labelBaslik.Text = "Pizza Sipariş Formu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 667);
            Controls.Add(labelBaslik);
            Controls.Add(buttonCikar);
            Controls.Add(buttonEkle);
            Controls.Add(textBoxFiyat);
            Controls.Add(label1);
            Controls.Add(buttonHesapla);
            Controls.Add(labelSecimler);
            Controls.Add(listBoxMalzemeler);
            Controls.Add(groupBoxBoyut);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxBoyut.ResumeLayout(false);
            groupBoxBoyut.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBoxMantar;
        private CheckBox checkBoxMisir;
        private CheckBox checkBoxSosis;
        private CheckBox checkBoxSucuk;
        private CheckBox checkBoxDomates;
        private CheckBox checkBoxSalam;
        private CheckBox checkBoxZeytin;
        private CheckBox checkBoxBiber;
        private GroupBox groupBoxBoyut;
        private RadioButton radioButtonBuyuk;
        private RadioButton radioButtonOrta;
        private RadioButton radioButtonKucuk;
        private ListBox listBoxMalzemeler;
        private Label labelSecimler;
        private Button buttonHesapla;
        private Label label1;
        private TextBox textBoxFiyat;
        private Button buttonEkle;
        private Button buttonCikar;
        private Label labelBaslik;
    }
}