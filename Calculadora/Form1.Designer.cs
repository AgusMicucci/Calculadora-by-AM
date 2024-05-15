namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtResultado = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnMasMenos = new Button();
            btnC = new Button();
            btnCE = new Button();
            btnRaiz = new Button();
            btnDelete = new Button();
            btnIgual = new Button();
            btnDivide = new Button();
            btnMultiplicar = new Button();
            btnMenos = new Button();
            btnMas = new Button();
            btnPorcentaje = new Button();
            btnFraccion = new Button();
            btnPotencia = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(12, 12);
            txtResultado.MaxLength = 16;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(309, 62);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 269);
            btn1.Name = "btn1";
            btn1.Size = new Size(57, 57);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += agregarNumero;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(75, 269);
            btn2.Name = "btn2";
            btn2.Size = new Size(57, 57);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += agregarNumero;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(138, 269);
            btn3.Name = "btn3";
            btn3.Size = new Size(57, 57);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += agregarNumero;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(138, 206);
            btn6.Name = "btn6";
            btn6.Size = new Size(57, 57);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += agregarNumero;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(75, 206);
            btn5.Name = "btn5";
            btn5.Size = new Size(57, 57);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += agregarNumero;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 206);
            btn4.Name = "btn4";
            btn4.Size = new Size(57, 57);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += agregarNumero;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(138, 143);
            btn9.Name = "btn9";
            btn9.Size = new Size(57, 57);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += agregarNumero;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(75, 143);
            btn8.Name = "btn8";
            btn8.Size = new Size(57, 57);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += agregarNumero;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(12, 143);
            btn7.Name = "btn7";
            btn7.Size = new Size(57, 57);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += agregarNumero;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(75, 332);
            btn0.Name = "btn0";
            btn0.Size = new Size(57, 57);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += agregarNumero;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDecimal.Location = new Point(138, 332);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(57, 57);
            btnDecimal.TabIndex = 11;
            btnDecimal.Tag = ",";
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnMasMenos
            // 
            btnMasMenos.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMasMenos.Location = new Point(12, 332);
            btnMasMenos.Name = "btnMasMenos";
            btnMasMenos.Size = new Size(57, 57);
            btnMasMenos.TabIndex = 12;
            btnMasMenos.Text = "±";
            btnMasMenos.UseVisualStyleBackColor = true;
            btnMasMenos.Click += btnMasMenos_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC.Location = new Point(201, 80);
            btnC.Name = "btnC";
            btnC.Size = new Size(57, 57);
            btnC.TabIndex = 15;
            btnC.Tag = "C";
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCE.Location = new Point(138, 80);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(57, 57);
            btnCE.TabIndex = 14;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRaiz.Location = new Point(201, 145);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(57, 57);
            btnRaiz.TabIndex = 13;
            btnRaiz.Tag = "√";
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += clickOperador;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(264, 80);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(57, 57);
            btnDelete.TabIndex = 20;
            btnDelete.Tag = "˿";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(201, 332);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(120, 57);
            btnIgual.TabIndex = 19;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Image = (Image)resources.GetObject("btnDivide.Image");
            btnDivide.Location = new Point(264, 206);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(57, 57);
            btnDivide.TabIndex = 18;
            btnDivide.Tag = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += clickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(201, 206);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(57, 57);
            btnMultiplicar.TabIndex = 17;
            btnMultiplicar.Tag = "x";
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnMenos
            // 
            btnMenos.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenos.Location = new Point(264, 269);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(57, 57);
            btnMenos.TabIndex = 16;
            btnMenos.Tag = "-";
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += clickOperador;
            // 
            // btnMas
            // 
            btnMas.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMas.Location = new Point(201, 269);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(57, 57);
            btnMas.TabIndex = 24;
            btnMas.Tag = "+";
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += clickOperador;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPorcentaje.Location = new Point(12, 80);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(57, 57);
            btnPorcentaje.TabIndex = 23;
            btnPorcentaje.Text = "%";
            btnPorcentaje.UseVisualStyleBackColor = true;
            // 
            // btnFraccion
            // 
            btnFraccion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFraccion.Location = new Point(75, 80);
            btnFraccion.Name = "btnFraccion";
            btnFraccion.Size = new Size(57, 57);
            btnFraccion.TabIndex = 22;
            btnFraccion.Text = "¹̸  ˣ";
            btnFraccion.UseVisualStyleBackColor = true;
            // 
            // btnPotencia
            // 
            btnPotencia.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPotencia.Location = new Point(264, 143);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(57, 57);
            btnPotencia.TabIndex = 21;
            btnPotencia.Tag = "²";
            btnPotencia.Text = "x²";
            btnPotencia.UseVisualStyleBackColor = true;
            btnPotencia.Click += clickOperador;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 402);
            Controls.Add(btnMas);
            Controls.Add(btnPorcentaje);
            Controls.Add(btnFraccion);
            Controls.Add(btnPotencia);
            Controls.Add(btnDelete);
            Controls.Add(btnIgual);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnMenos);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnRaiz);
            Controls.Add(btnMasMenos);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtResultado);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora by AM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn0;
        private Button btnDecimal;
        private Button btnMasMenos;
        private Button btnC;
        private Button btnCE;
        private Button btnRaiz;
        private Button btnDelete;
        private Button btnIgual;
        private Button btnDivide;
        private Button btnMultiplicar;
        private Button btnMenos;
        private Button btnMas;
        private Button btnPorcentaje;
        private Button btnFraccion;
        private Button btnPotencia;
    }
}
