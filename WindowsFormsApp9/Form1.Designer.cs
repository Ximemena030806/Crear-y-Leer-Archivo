namespace WindowsFormsApp9
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
            this.btnFichero = new System.Windows.Forms.Button();
            this.btnCrearFichero2 = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFichero
            // 
            this.btnFichero.Location = new System.Drawing.Point(43, 41);
            this.btnFichero.Name = "btnFichero";
            this.btnFichero.Size = new System.Drawing.Size(103, 37);
            this.btnFichero.TabIndex = 0;
            this.btnFichero.Text = "Crear Fichero";
            this.btnFichero.UseVisualStyleBackColor = true;
            this.btnFichero.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrearFichero2
            // 
            this.btnCrearFichero2.Location = new System.Drawing.Point(183, 41);
            this.btnCrearFichero2.Name = "btnCrearFichero2";
            this.btnCrearFichero2.Size = new System.Drawing.Size(126, 37);
            this.btnCrearFichero2.TabIndex = 1;
            this.btnCrearFichero2.Text = "Formar 2 de Crear";
            this.btnCrearFichero2.UseVisualStyleBackColor = true;
            this.btnCrearFichero2.Click += new System.EventHandler(this.btnCrearFichero2_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(349, 41);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(105, 37);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Leer Archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(498, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Leer Archivo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Leer Archivo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(346, 116);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 38);
            this.button6.TabIndex = 5;
            this.button6.Text = "Modificar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(200, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 38);
            this.button7.TabIndex = 6;
            this.button7.Text = "Leer Archivo";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnCrearFichero2);
            this.Controls.Add(this.btnFichero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFichero;
        private System.Windows.Forms.Button btnCrearFichero2;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

