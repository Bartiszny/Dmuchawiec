namespace Gra
{
   public partial class Okno
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno));
            this.PasekStanu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.licznikodlegolosci = new System.Windows.Forms.Label();
            this.licznikpoziomu = new System.Windows.Forms.Label();
            this.odleglosc = new System.Windows.Forms.Label();
            this.poziom = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.pole = new Gra.DoubleBufferedPanel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.nowaGra = new System.Windows.Forms.Button();
            this.zakoncz = new System.Windows.Forms.Button();
            this.zapisWynikow = new System.Windows.Forms.Button();
            this.powrot = new System.Windows.Forms.Button();
            this.menuNapis = new System.Windows.Forms.Label();
            this.PasekStanu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pole.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasekStanu
            // 
            this.PasekStanu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PasekStanu.Controls.Add(this.pictureBox1);
            this.PasekStanu.Controls.Add(this.licznikodlegolosci);
            this.PasekStanu.Controls.Add(this.licznikpoziomu);
            this.PasekStanu.Controls.Add(this.odleglosc);
            this.PasekStanu.Controls.Add(this.poziom);
            this.PasekStanu.Location = new System.Drawing.Point(-3, -3);
            this.PasekStanu.Name = "PasekStanu";
            this.PasekStanu.Size = new System.Drawing.Size(1014, 83);
            this.PasekStanu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(826, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 31);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // licznikodlegolosci
            // 
            this.licznikodlegolosci.AutoSize = true;
            this.licznikodlegolosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.licznikodlegolosci.Location = new System.Drawing.Point(385, 30);
            this.licznikodlegolosci.Name = "licznikodlegolosci";
            this.licznikodlegolosci.Size = new System.Drawing.Size(35, 37);
            this.licznikodlegolosci.TabIndex = 4;
            this.licznikodlegolosci.Text = "0";
            // 
            // licznikpoziomu
            // 
            this.licznikpoziomu.AutoSize = true;
            this.licznikpoziomu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.licznikpoziomu.Location = new System.Drawing.Point(195, 30);
            this.licznikpoziomu.Name = "licznikpoziomu";
            this.licznikpoziomu.Size = new System.Drawing.Size(35, 37);
            this.licznikpoziomu.TabIndex = 3;
            this.licznikpoziomu.Text = "0";
            // 
            // odleglosc
            // 
            this.odleglosc.AutoSize = true;
            this.odleglosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odleglosc.Location = new System.Drawing.Point(236, 30);
            this.odleglosc.Name = "odleglosc";
            this.odleglosc.Size = new System.Drawing.Size(166, 37);
            this.odleglosc.TabIndex = 2;
            this.odleglosc.Text = "PUNKTY: ";
            // 
            // poziom
            // 
            this.poziom.AutoSize = true;
            this.poziom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poziom.Location = new System.Drawing.Point(49, 30);
            this.poziom.Name = "poziom";
            this.poziom.Size = new System.Drawing.Size(160, 37);
            this.poziom.TabIndex = 1;
            this.poziom.Text = "POZIOM: ";
            // 
            // pole
            // 
            this.pole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pole.BackgroundImage")));
            this.pole.Controls.Add(this.menuPanel);
            this.pole.Location = new System.Drawing.Point(-3, 77);
            this.pole.Name = "pole";
            this.pole.Size = new System.Drawing.Size(1014, 665);
            this.pole.TabIndex = 1;
            this.pole.Paint += new System.Windows.Forms.PaintEventHandler(this.Pole_Paint);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuPanel.Controls.Add(this.nowaGra);
            this.menuPanel.Controls.Add(this.zakoncz);
            this.menuPanel.Controls.Add(this.zapisWynikow);
            this.menuPanel.Controls.Add(this.powrot);
            this.menuPanel.Controls.Add(this.menuNapis);
            this.menuPanel.Location = new System.Drawing.Point(243, 172);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(506, 346);
            this.menuPanel.TabIndex = 0;
            // 
            // nowaGra
            // 
            this.nowaGra.BackColor = System.Drawing.Color.Black;
            this.nowaGra.Font = new System.Drawing.Font("SketchFlow Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowaGra.ForeColor = System.Drawing.Color.White;
            this.nowaGra.Location = new System.Drawing.Point(139, 163);
            this.nowaGra.Name = "nowaGra";
            this.nowaGra.Size = new System.Drawing.Size(204, 32);
            this.nowaGra.TabIndex = 4;
            this.nowaGra.Text = "Nowa Gra";
            this.nowaGra.UseVisualStyleBackColor = false;
            this.nowaGra.Click += new System.EventHandler(this.nowaGra_Click);
            // 
            // zakoncz
            // 
            this.zakoncz.BackColor = System.Drawing.Color.Black;
            this.zakoncz.Font = new System.Drawing.Font("SketchFlow Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakoncz.ForeColor = System.Drawing.Color.White;
            this.zakoncz.Location = new System.Drawing.Point(139, 280);
            this.zakoncz.Name = "zakoncz";
            this.zakoncz.Size = new System.Drawing.Size(204, 32);
            this.zakoncz.TabIndex = 3;
            this.zakoncz.Text = "Zakończ";
            this.zakoncz.UseVisualStyleBackColor = false;
            this.zakoncz.Click += new System.EventHandler(this.zakoncz_Click);
            // 
            // zapisWynikow
            // 
            this.zapisWynikow.BackColor = System.Drawing.Color.Black;
            this.zapisWynikow.Font = new System.Drawing.Font("SketchFlow Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapisWynikow.ForeColor = System.Drawing.Color.White;
            this.zapisWynikow.Location = new System.Drawing.Point(139, 221);
            this.zapisWynikow.Name = "zapisWynikow";
            this.zapisWynikow.Size = new System.Drawing.Size(204, 32);
            this.zapisWynikow.TabIndex = 2;
            this.zapisWynikow.Text = "Zapis Wyniku";
            this.zapisWynikow.UseVisualStyleBackColor = false;
            this.zapisWynikow.Click += new System.EventHandler(this.zapisWynikow_Click);
            // 
            // powrot
            // 
            this.powrot.BackColor = System.Drawing.Color.Black;
            this.powrot.Font = new System.Drawing.Font("SketchFlow Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powrot.ForeColor = System.Drawing.Color.White;
            this.powrot.Location = new System.Drawing.Point(139, 106);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(204, 32);
            this.powrot.TabIndex = 1;
            this.powrot.Text = "Start";
            this.powrot.UseVisualStyleBackColor = false;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // menuNapis
            // 
            this.menuNapis.AutoSize = true;
            this.menuNapis.Font = new System.Drawing.Font("SketchFlow Print", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuNapis.ForeColor = System.Drawing.SystemColors.Control;
            this.menuNapis.Location = new System.Drawing.Point(137, 19);
            this.menuNapis.Name = "menuNapis";
            this.menuNapis.Size = new System.Drawing.Size(206, 63);
            this.menuNapis.TabIndex = 0;
            this.menuNapis.Text = "MENU";
            this.menuNapis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 741);
            this.Controls.Add(this.pole);
            this.Controls.Add(this.PasekStanu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Okno";
            this.Text = "Okno";
            this.PasekStanu.ResumeLayout(false);
            this.PasekStanu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pole.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PasekStanu;
        private System.Windows.Forms.Label poziom;
        private System.Windows.Forms.Label odleglosc;
       /// <summary>
       /// Deklaracja obiektu klasy Timer
       /// </summary>
       public System.Windows.Forms.Timer MainTimer;
        private DoubleBufferedPanel pole;
        private System.Windows.Forms.Label licznikodlegolosci;
        private System.Windows.Forms.Label licznikpoziomu;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label menuNapis;
        private System.Windows.Forms.Button zakoncz;
        private System.Windows.Forms.Button zapisWynikow;
        private System.Windows.Forms.Button powrot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nowaGra;
      
    }
}