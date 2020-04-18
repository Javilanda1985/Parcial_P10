namespace Funciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textEntrada = new System.Windows.Forms.TextBox();
            this.textSalida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonSerie = new System.Windows.Forms.Button();
            this.button2Fibo = new System.Windows.Forms.Button();
            this.buttonFact = new System.Windows.Forms.Button();
            this.buttonAC = new System.Windows.Forms.Button();
            this.buttonEND = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEntrada
            // 
            this.textEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEntrada.Location = new System.Drawing.Point(161, 68);
            this.textEntrada.Name = "textEntrada";
            this.textEntrada.Size = new System.Drawing.Size(64, 22);
            this.textEntrada.TabIndex = 0;
            // 
            // textSalida
            // 
            this.textSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalida.Location = new System.Drawing.Point(125, 304);
            this.textSalida.Name = "textSalida";
            this.textSalida.Size = new System.Drawing.Size(123, 22);
            this.textSalida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESO NUMERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "FUNCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "SALIDA";
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(69, 147);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(75, 57);
            this.buttonMult.TabIndex = 5;
            this.buttonMult.Text = "Multiplos";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(150, 147);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 57);
            this.buttonDiv.TabIndex = 6;
            this.buttonDiv.Text = "Divisores";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonSerie
            // 
            this.buttonSerie.Location = new System.Drawing.Point(231, 147);
            this.buttonSerie.Name = "buttonSerie";
            this.buttonSerie.Size = new System.Drawing.Size(75, 57);
            this.buttonSerie.TabIndex = 7;
            this.buttonSerie.Text = "y = x²";
            this.buttonSerie.UseVisualStyleBackColor = true;
            this.buttonSerie.Click += new System.EventHandler(this.buttonSerie_Click);
            // 
            // button2Fibo
            // 
            this.button2Fibo.Location = new System.Drawing.Point(150, 210);
            this.button2Fibo.Name = "button2Fibo";
            this.button2Fibo.Size = new System.Drawing.Size(75, 57);
            this.button2Fibo.TabIndex = 9;
            this.button2Fibo.Text = "Fibonacci";
            this.button2Fibo.UseVisualStyleBackColor = true;
            this.button2Fibo.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFact
            // 
            this.buttonFact.Location = new System.Drawing.Point(69, 210);
            this.buttonFact.Name = "buttonFact";
            this.buttonFact.Size = new System.Drawing.Size(75, 57);
            this.buttonFact.TabIndex = 10;
            this.buttonFact.Text = "Factorial";
            this.buttonFact.UseVisualStyleBackColor = true;
            this.buttonFact.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAC
            // 
            this.buttonAC.Location = new System.Drawing.Point(92, 346);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(75, 57);
            this.buttonAC.TabIndex = 11;
            this.buttonAC.Text = "BORRAR";
            this.buttonAC.UseVisualStyleBackColor = true;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // buttonEND
            // 
            this.buttonEND.Location = new System.Drawing.Point(198, 346);
            this.buttonEND.Name = "buttonEND";
            this.buttonEND.Size = new System.Drawing.Size(75, 57);
            this.buttonEND.TabIndex = 12;
            this.buttonEND.Text = "SALIR";
            this.buttonEND.UseVisualStyleBackColor = true;
            this.buttonEND.Click += new System.EventHandler(this.buttonEND_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(351, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 420);
            this.Controls.Add(this.buttonEND);
            this.Controls.Add(this.buttonAC);
            this.Controls.Add(this.buttonFact);
            this.Controls.Add(this.button2Fibo);
            this.Controls.Add(this.buttonSerie);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSalida);
            this.Controls.Add(this.textEntrada);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "FUNCIONES";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEntrada;
        private System.Windows.Forms.TextBox textSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonSerie;
        private System.Windows.Forms.Button button2Fibo;
        private System.Windows.Forms.Button buttonFact;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Button buttonEND;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

