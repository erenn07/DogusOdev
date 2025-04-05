namespace WinFormsApp1
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
            lblOdemeTipi = new Label();
            lblTutar = new Label();
            btnOdeme = new Button();
            cmbOdemeTipi = new ComboBox();
            lblSonuc = new Label();
            txtTutar = new TextBox();
            SuspendLayout();
            // 
            // lblOdemeTipi
            // 
            lblOdemeTipi.AutoSize = true;
            lblOdemeTipi.Location = new Point(302, 103);
            lblOdemeTipi.Name = "lblOdemeTipi";
            lblOdemeTipi.Size = new Size(87, 20);
            lblOdemeTipi.TabIndex = 0;
            lblOdemeTipi.Text = "Ödeme Tipi";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(318, 226);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(43, 20);
            lblTutar.TabIndex = 1;
            lblTutar.Text = "Tutar";
            // 
            // btnOdeme
            // 
            btnOdeme.Location = new Point(528, 288);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new Size(133, 40);
            btnOdeme.TabIndex = 2;
            btnOdeme.Text = "Ödeme Yap";
            btnOdeme.UseVisualStyleBackColor = true;
            btnOdeme.Click += btnOdeme_Click;
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Items.AddRange(new object[] { "Bitcoin", "GooglePlay", "KrediKarti", "Paypal", "ApplePay" });
            cmbOdemeTipi.Location = new Point(491, 103);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(151, 28);
            cmbOdemeTipi.TabIndex = 3;
            cmbOdemeTipi.SelectedIndexChanged += cmbOdemeTipi_SelectedIndexChanged;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(318, 347);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(49, 20);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "Sonuç";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(491, 223);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(189, 27);
            txtTutar.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTutar);
            Controls.Add(lblSonuc);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(btnOdeme);
            Controls.Add(lblTutar);
            Controls.Add(lblOdemeTipi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOdemeTipi;
        private Label lblTutar;
        private Button btnOdeme;
        private ComboBox cmbOdemeTipi;
        private Label lblSonuc;
        private TextBox txtTutar;
    }
}
