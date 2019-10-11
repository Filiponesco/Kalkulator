namespace Kalkulator
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
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnRownaSie = new System.Windows.Forms.Button();
            this.btnPrzecinek = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnRazy = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnDziel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.txtBoxEkranGlowny = new System.Windows.Forms.TextBox();
            this.txtBoxEkranMaly = new System.Windows.Forms.TextBox();
            this.btnPierwiastek = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnKwadrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Location = new System.Drawing.Point(4, 276);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(56, 42);
            this.btnPlusMinus.TabIndex = 0;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(65, 276);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 42);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btnRownaSie
            // 
            this.btnRownaSie.Location = new System.Drawing.Point(188, 228);
            this.btnRownaSie.Name = "btnRownaSie";
            this.btnRownaSie.Size = new System.Drawing.Size(56, 90);
            this.btnRownaSie.TabIndex = 3;
            this.btnRownaSie.Text = "=";
            this.btnRownaSie.UseVisualStyleBackColor = true;
            this.btnRownaSie.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnPrzecinek
            // 
            this.btnPrzecinek.Location = new System.Drawing.Point(127, 276);
            this.btnPrzecinek.Name = "btnPrzecinek";
            this.btnPrzecinek.Size = new System.Drawing.Size(56, 42);
            this.btnPrzecinek.TabIndex = 2;
            this.btnPrzecinek.Text = ",";
            this.btnPrzecinek.UseVisualStyleBackColor = true;
            this.btnPrzecinek.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(250, 228);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(56, 90);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(127, 228);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 42);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(65, 228);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 42);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(4, 228);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 42);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btnRazy
            // 
            this.btnRazy.Location = new System.Drawing.Point(188, 132);
            this.btnRazy.Name = "btnRazy";
            this.btnRazy.Size = new System.Drawing.Size(56, 42);
            this.btnRazy.TabIndex = 15;
            this.btnRazy.Text = "x";
            this.btnRazy.UseVisualStyleBackColor = true;
            this.btnRazy.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(127, 132);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 42);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(65, 132);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 42);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(4, 132);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 42);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(188, 180);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(56, 42);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(127, 180);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 42);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(65, 180);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 42);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(4, 180);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 42);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btnDziel
            // 
            this.btnDziel.Location = new System.Drawing.Point(188, 84);
            this.btnDziel.Name = "btnDziel";
            this.btnDziel.Size = new System.Drawing.Size(56, 42);
            this.btnDziel.TabIndex = 19;
            this.btnDziel.Text = "/";
            this.btnDziel.UseVisualStyleBackColor = true;
            this.btnDziel.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(127, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 42);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DEL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(65, 84);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(56, 42);
            this.btnC.TabIndex = 17;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(4, 84);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(56, 42);
            this.btnCE.TabIndex = 16;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // txtBoxEkranGlowny
            // 
            this.txtBoxEkranGlowny.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxEkranGlowny.Location = new System.Drawing.Point(4, 40);
            this.txtBoxEkranGlowny.Name = "txtBoxEkranGlowny";
            this.txtBoxEkranGlowny.ReadOnly = true;
            this.txtBoxEkranGlowny.Size = new System.Drawing.Size(305, 38);
            this.txtBoxEkranGlowny.TabIndex = 20;
            this.txtBoxEkranGlowny.TabStop = false;
            this.txtBoxEkranGlowny.Text = "0";
            this.txtBoxEkranGlowny.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxEkranGlowny.WordWrap = false;
            // 
            // txtBoxEkranMaly
            // 
            this.txtBoxEkranMaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxEkranMaly.Location = new System.Drawing.Point(4, 10);
            this.txtBoxEkranMaly.Name = "txtBoxEkranMaly";
            this.txtBoxEkranMaly.ReadOnly = true;
            this.txtBoxEkranMaly.Size = new System.Drawing.Size(305, 24);
            this.txtBoxEkranMaly.TabIndex = 21;
            this.txtBoxEkranMaly.TabStop = false;
            this.txtBoxEkranMaly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPierwiastek
            // 
            this.btnPierwiastek.Location = new System.Drawing.Point(250, 84);
            this.btnPierwiastek.Name = "btnPierwiastek";
            this.btnPierwiastek.Size = new System.Drawing.Size(56, 42);
            this.btnPierwiastek.TabIndex = 22;
            this.btnPierwiastek.Text = "Sqrt";
            this.btnPierwiastek.UseVisualStyleBackColor = true;
            this.btnPierwiastek.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // btnModulo
            // 
            this.btnModulo.Location = new System.Drawing.Point(250, 132);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(56, 42);
            this.btnModulo.TabIndex = 23;
            this.btnModulo.Text = "Mod";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnKwadrat
            // 
            this.btnKwadrat.Location = new System.Drawing.Point(250, 180);
            this.btnKwadrat.Name = "btnKwadrat";
            this.btnKwadrat.Size = new System.Drawing.Size(56, 42);
            this.btnKwadrat.TabIndex = 24;
            this.btnKwadrat.Text = "x^2";
            this.btnKwadrat.UseVisualStyleBackColor = true;
            this.btnKwadrat.Click += new System.EventHandler(this.AllBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(321, 323);
            this.Controls.Add(this.btnKwadrat);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnPierwiastek);
            this.Controls.Add(this.txtBoxEkranMaly);
            this.Controls.Add(this.txtBoxEkranGlowny);
            this.Controls.Add(this.btnDziel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnRazy);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnRownaSie);
            this.Controls.Add(this.btnPrzecinek);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlusMinus);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnRownaSie;
        private System.Windows.Forms.Button btnPrzecinek;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnRazy;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnDziel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.TextBox txtBoxEkranGlowny;
        private System.Windows.Forms.TextBox txtBoxEkranMaly;
        private System.Windows.Forms.Button btnPierwiastek;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnKwadrat;
    }
}

