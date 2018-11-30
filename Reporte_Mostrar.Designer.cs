namespace Ejercicio_TimeSpan
{
    partial class Reporte_Mostrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxReporte = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte de Salidas y Entradas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxReporte
            // 
            this.listBoxReporte.BackColor = System.Drawing.Color.Silver;
            this.listBoxReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxReporte.FormattingEnabled = true;
            this.listBoxReporte.ItemHeight = 16;
            this.listBoxReporte.Location = new System.Drawing.Point(54, 100);
            this.listBoxReporte.Name = "listBoxReporte";
            this.listBoxReporte.Size = new System.Drawing.Size(682, 244);
            this.listBoxReporte.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(322, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mostrar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Persona + Numero:";
            // 
            // btnEntradas
            // 
            this.btnEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.Location = new System.Drawing.Point(132, 385);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(85, 32);
            this.btnEntradas.TabIndex = 10;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnSalidas
            // 
            this.btnSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidas.Location = new System.Drawing.Point(586, 385);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Size = new System.Drawing.Size(75, 29);
            this.btnSalidas.TabIndex = 11;
            this.btnSalidas.Text = "Salidas";
            this.btnSalidas.UseVisualStyleBackColor = true;
            this.btnSalidas.Click += new System.EventHandler(this.btnSalidas_Click);
            // 
            // txtPersona
            // 
            this.txtPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersona.Location = new System.Drawing.Point(213, 68);
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(154, 24);
            this.txtPersona.TabIndex = 12;
            // 
            // Reporte_Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPersona);
            this.Controls.Add(this.btnSalidas);
            this.Controls.Add(this.btnEntradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxReporte);
            this.Controls.Add(this.label1);
            this.Name = "Reporte_Mostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Mostrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnSalidas;
        private System.Windows.Forms.TextBox txtPersona;
    }
}