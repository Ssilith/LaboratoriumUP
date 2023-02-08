
namespace Latwiutko
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.skanujButton = new System.Windows.Forms.Button();
            this.listaSkanerow = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PojemnikNaObraz = new System.Windows.Forms.PictureBox();
            this.resLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.PNG = new System.Windows.Forms.CheckBox();
            this.JPG = new System.Windows.Forms.CheckBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PojemnikNaObraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.skanujButton);
            this.panel1.Controls.Add(this.listaSkanerow);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 270);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista urządzeń";
            // 
            // skanujButton
            // 
            this.skanujButton.Location = new System.Drawing.Point(7, 195);
            this.skanujButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skanujButton.Name = "skanujButton";
            this.skanujButton.Size = new System.Drawing.Size(130, 40);
            this.skanujButton.TabIndex = 2;
            this.skanujButton.Text = "Skanuj!";
            this.skanujButton.UseVisualStyleBackColor = true;
            this.skanujButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaSkanerow
            // 
            this.listaSkanerow.BackColor = System.Drawing.Color.Gray;
            this.listaSkanerow.FormattingEnabled = true;
            this.listaSkanerow.ItemHeight = 20;
            this.listaSkanerow.Location = new System.Drawing.Point(7, 42);
            this.listaSkanerow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaSkanerow.Name = "listaSkanerow";
            this.listaSkanerow.Size = new System.Drawing.Size(271, 144);
            this.listaSkanerow.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PojemnikNaObraz);
            this.panel2.Location = new System.Drawing.Point(460, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 588);
            this.panel2.TabIndex = 1;
            // 
            // PojemnikNaObraz
            // 
            this.PojemnikNaObraz.Location = new System.Drawing.Point(3, 4);
            this.PojemnikNaObraz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PojemnikNaObraz.Name = "PojemnikNaObraz";
            this.PojemnikNaObraz.Size = new System.Drawing.Size(489, 575);
            this.PojemnikNaObraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PojemnikNaObraz.TabIndex = 0;
            this.PojemnikNaObraz.TabStop = false;
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(30, 59);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(40, 20);
            this.resLabel.TabIndex = 13;
            this.resLabel.Text = " 300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "rozdzielczość:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(109, 10);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(235, 69);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 300;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(241, 96);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(93, 24);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "1-bitowy";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(153, 96);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 24);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "RGB";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 96);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Skala szarości";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.checkBox6);
            this.panel3.Controls.Add(this.checkBox5);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.PNG);
            this.panel3.Controls.Add(this.JPG);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.resLabel);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Location = new System.Drawing.Point(15, 301);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 300);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Rozmiar:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(292, 262);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(67, 24);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "25%";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(153, 262);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(67, 24);
            this.checkBox5.TabIndex = 17;
            this.checkBox5.Text = "50%";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(23, 262);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(76, 24);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "100%";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // PNG
            // 
            this.PNG.AutoSize = true;
            this.PNG.Location = new System.Drawing.Point(81, 176);
            this.PNG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PNG.Name = "PNG";
            this.PNG.Size = new System.Drawing.Size(69, 24);
            this.PNG.TabIndex = 15;
            this.PNG.Text = "PNG";
            this.PNG.UseVisualStyleBackColor = true;
            this.PNG.CheckedChanged += new System.EventHandler(this.PNG_CheckedChanged);
            // 
            // JPG
            // 
            this.JPG.AutoSize = true;
            this.JPG.Checked = true;
            this.JPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.JPG.Location = new System.Drawing.Point(10, 176);
            this.JPG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.JPG.Name = "JPG";
            this.JPG.Size = new System.Drawing.Size(66, 24);
            this.JPG.TabIndex = 14;
            this.JPG.Text = "JPG";
            this.JPG.UseVisualStyleBackColor = true;
            this.JPG.CheckedChanged += new System.EventHandler(this.JPG_CheckedChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(314, 111);
            this.trackBar2.Maximum = 2500;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(124, 69);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(314, 225);
            this.trackBar3.Maximum = 3500;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(124, 69);
            this.trackBar3.TabIndex = 4;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zmienna x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Zmienna y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "0";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(966, 609);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PojemnikNaObraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listaSkanerow;
        private System.Windows.Forms.Button skanujButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PojemnikNaObraz;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox PNG;
        private System.Windows.Forms.CheckBox JPG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

