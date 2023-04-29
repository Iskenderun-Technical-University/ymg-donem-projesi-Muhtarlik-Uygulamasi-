namespace muhtarlik_otomasyon
{
    partial class Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ikametgahİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vatandaşAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vatandaşRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ikametgahRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(236, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kayıt Ol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(358, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Ekranı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 232);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 474);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı İşlemleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(167, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sifre =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(100, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Adı =";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(127, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(105, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Kullanıcıyı Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreİşlemleriToolStripMenuItem,
            this.üyeleriGörüntüleToolStripMenuItem,
            this.işlemlerToolStripMenuItem1,
            this.ikametgahİşlemleriToolStripMenuItem,
            this.vatandaşAramaToolStripMenuItem,
            this.vatandaşRaporuToolStripMenuItem,
            this.ikametgahRaporToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            this.şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            this.şifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            this.şifreİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.şifreİşlemleriToolStripMenuItem_Click);
            // 
            // üyeleriGörüntüleToolStripMenuItem
            // 
            this.üyeleriGörüntüleToolStripMenuItem.Name = "üyeleriGörüntüleToolStripMenuItem";
            this.üyeleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.üyeleriGörüntüleToolStripMenuItem.Text = "Üyeleri Görüntüle";
            this.üyeleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.üyeleriGörüntüleToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem1
            // 
            this.işlemlerToolStripMenuItem1.Name = "işlemlerToolStripMenuItem1";
            this.işlemlerToolStripMenuItem1.Size = new System.Drawing.Size(222, 26);
            this.işlemlerToolStripMenuItem1.Text = "Vatandaş İşlemleri";
            this.işlemlerToolStripMenuItem1.Click += new System.EventHandler(this.işlemlerToolStripMenuItem1_Click);
            // 
            // ikametgahİşlemleriToolStripMenuItem
            // 
            this.ikametgahİşlemleriToolStripMenuItem.Name = "ikametgahİşlemleriToolStripMenuItem";
            this.ikametgahİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ikametgahİşlemleriToolStripMenuItem.Text = "İkametgah İşlemleri";
            this.ikametgahİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ikametgahİşlemleriToolStripMenuItem_Click);
            // 
            // vatandaşAramaToolStripMenuItem
            // 
            this.vatandaşAramaToolStripMenuItem.Name = "vatandaşAramaToolStripMenuItem";
            this.vatandaşAramaToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.vatandaşAramaToolStripMenuItem.Text = "Vatandaş Arama ";
            this.vatandaşAramaToolStripMenuItem.Click += new System.EventHandler(this.vatandaşAramaToolStripMenuItem_Click);
            // 
            // vatandaşRaporuToolStripMenuItem
            // 
            this.vatandaşRaporuToolStripMenuItem.Name = "vatandaşRaporuToolStripMenuItem";
            this.vatandaşRaporuToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.vatandaşRaporuToolStripMenuItem.Text = "Vatandaş Raporu";
            this.vatandaşRaporuToolStripMenuItem.Click += new System.EventHandler(this.vatandaşRaporuToolStripMenuItem_Click);
            // 
            // ikametgahRaporToolStripMenuItem
            // 
            this.ikametgahRaporToolStripMenuItem.Name = "ikametgahRaporToolStripMenuItem";
            this.ikametgahRaporToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ikametgahRaporToolStripMenuItem.Text = "İkametgah Rapor";
            this.ikametgahRaporToolStripMenuItem.Click += new System.EventHandler(this.ikametgahRaporToolStripMenuItem_Click);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(614, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kayit";
            this.Text = "Kayit";
            this.Load += new System.EventHandler(this.Kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ikametgahİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vatandaşAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vatandaşRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ikametgahRaporToolStripMenuItem;
    }
}