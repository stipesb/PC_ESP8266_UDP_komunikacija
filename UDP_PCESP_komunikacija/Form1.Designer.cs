namespace UDP_PCESP_komunikacija
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IPracunala = new System.Windows.Forms.TextBox();
            this.IPodredista = new System.Windows.Forms.TextBox();
            this.PORT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Zapocni = new System.Windows.Forms.Button();
            this.slider = new System.Windows.Forms.TrackBar();
            this.tipka1 = new System.Windows.Forms.Button();
            this.tipka2 = new System.Windows.Forms.Button();
            this.tipka3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // IPracunala
            // 
            this.IPracunala.Enabled = false;
            this.IPracunala.Location = new System.Drawing.Point(150, 26);
            this.IPracunala.Name = "IPracunala";
            this.IPracunala.Size = new System.Drawing.Size(144, 20);
            this.IPracunala.TabIndex = 0;
            this.IPracunala.TextChanged += new System.EventHandler(this.IPracunala_TextChanged);
            // 
            // IPodredista
            // 
            this.IPodredista.Location = new System.Drawing.Point(150, 69);
            this.IPodredista.Name = "IPodredista";
            this.IPodredista.Size = new System.Drawing.Size(144, 20);
            this.IPodredista.TabIndex = 1;
            this.IPodredista.TextChanged += new System.EventHandler(this.IPodredista_TextChanged);
            // 
            // PORT
            // 
            this.PORT.Location = new System.Drawing.Point(171, 109);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(110, 20);
            this.PORT.TabIndex = 2;
            this.PORT.TextChanged += new System.EventHandler(this.PORT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP adresa racunala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP adresa odredista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PORT";
            // 
            // Zapocni
            // 
            this.Zapocni.Location = new System.Drawing.Point(190, 155);
            this.Zapocni.Name = "Zapocni";
            this.Zapocni.Size = new System.Drawing.Size(75, 23);
            this.Zapocni.TabIndex = 6;
            this.Zapocni.Text = "Zapocni";
            this.Zapocni.UseVisualStyleBackColor = true;
            this.Zapocni.Click += new System.EventHandler(this.Zapocni_Click);
            // 
            // slider
            // 
            this.slider.Location = new System.Drawing.Point(97, 207);
            this.slider.Maximum = 100;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(266, 45);
            this.slider.TabIndex = 8;
            this.slider.Value = 50;
            this.slider.Scroll += new System.EventHandler(this.slider_Scroll);
            // 
            // tipka1
            // 
            this.tipka1.Location = new System.Drawing.Point(190, 271);
            this.tipka1.Name = "tipka1";
            this.tipka1.Size = new System.Drawing.Size(75, 23);
            this.tipka1.TabIndex = 9;
            this.tipka1.Text = "Sklopka  1";
            this.tipka1.UseVisualStyleBackColor = true;
            this.tipka1.Click += new System.EventHandler(this.tipka1_Click);
            // 
            // tipka2
            // 
            this.tipka2.Location = new System.Drawing.Point(190, 315);
            this.tipka2.Name = "tipka2";
            this.tipka2.Size = new System.Drawing.Size(75, 23);
            this.tipka2.TabIndex = 10;
            this.tipka2.Text = "Sklopka  2";
            this.tipka2.UseVisualStyleBackColor = true;
            this.tipka2.Click += new System.EventHandler(this.tipka2_Click);
            // 
            // tipka3
            // 
            this.tipka3.Location = new System.Drawing.Point(190, 357);
            this.tipka3.Name = "tipka3";
            this.tipka3.Size = new System.Drawing.Size(75, 23);
            this.tipka3.TabIndex = 11;
            this.tipka3.Text = "Sklopka  3";
            this.tipka3.UseVisualStyleBackColor = true;
            this.tipka3.Click += new System.EventHandler(this.tipka3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.tipka3);
            this.Controls.Add(this.tipka2);
            this.Controls.Add(this.tipka1);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.Zapocni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.IPodredista);
            this.Controls.Add(this.IPracunala);
            this.Name = "Form1";
            this.Text = "Kontrola rasvjete";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPracunala;
        private System.Windows.Forms.TextBox IPodredista;
        private System.Windows.Forms.TextBox PORT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Zapocni;
        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.Button tipka1;
        private System.Windows.Forms.Button tipka2;
        private System.Windows.Forms.Button tipka3;
        private System.Windows.Forms.Timer timer1;
    }
}

