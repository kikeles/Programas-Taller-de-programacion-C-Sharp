namespace Tarea_6_metodos
{
    partial class Principal
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
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnHeadSort = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuickSort = new System.Windows.Forms.Label();
            this.txtBubbleSort = new System.Windows.Forms.Label();
            this.txtMergeSort = new System.Windows.Forms.Label();
            this.txtHeadSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.BackColor = System.Drawing.Color.Red;
            this.btnQuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickSort.Location = new System.Drawing.Point(33, 88);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(121, 39);
            this.btnQuickSort.TabIndex = 0;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = false;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.BackColor = System.Drawing.Color.Red;
            this.btnBubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubbleSort.Location = new System.Drawing.Point(33, 164);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(121, 39);
            this.btnBubbleSort.TabIndex = 1;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = false;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.BackColor = System.Drawing.Color.Red;
            this.btnMergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergeSort.Location = new System.Drawing.Point(33, 245);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(121, 39);
            this.btnMergeSort.TabIndex = 2;
            this.btnMergeSort.Text = "Merge Sort";
            this.btnMergeSort.UseVisualStyleBackColor = false;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnHeadSort
            // 
            this.btnHeadSort.BackColor = System.Drawing.Color.Red;
            this.btnHeadSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeadSort.Location = new System.Drawing.Point(33, 326);
            this.btnHeadSort.Name = "btnHeadSort";
            this.btnHeadSort.Size = new System.Drawing.Size(121, 39);
            this.btnHeadSort.TabIndex = 3;
            this.btnHeadSort.Text = "Head Sort";
            this.btnHeadSort.UseVisualStyleBackColor = false;
            this.btnHeadSort.Click += new System.EventHandler(this.btnHeadSort_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(163, 42);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(429, 21);
            this.txtSerie.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Métodos de Ordenamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Serie Numérica";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "separar por comas";
            // 
            // txtQuickSort
            // 
            this.txtQuickSort.AutoSize = true;
            this.txtQuickSort.BackColor = System.Drawing.Color.Snow;
            this.txtQuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuickSort.Location = new System.Drawing.Point(160, 98);
            this.txtQuickSort.Name = "txtQuickSort";
            this.txtQuickSort.Size = new System.Drawing.Size(0, 18);
            this.txtQuickSort.TabIndex = 8;
            // 
            // txtBubbleSort
            // 
            this.txtBubbleSort.AutoSize = true;
            this.txtBubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBubbleSort.Location = new System.Drawing.Point(160, 174);
            this.txtBubbleSort.Name = "txtBubbleSort";
            this.txtBubbleSort.Size = new System.Drawing.Size(0, 18);
            this.txtBubbleSort.TabIndex = 9;
            // 
            // txtMergeSort
            // 
            this.txtMergeSort.AutoSize = true;
            this.txtMergeSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMergeSort.Location = new System.Drawing.Point(160, 255);
            this.txtMergeSort.Name = "txtMergeSort";
            this.txtMergeSort.Size = new System.Drawing.Size(0, 18);
            this.txtMergeSort.TabIndex = 10;
            // 
            // txtHeadSort
            // 
            this.txtHeadSort.AutoSize = true;
            this.txtHeadSort.BackColor = System.Drawing.Color.Snow;
            this.txtHeadSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadSort.Location = new System.Drawing.Point(160, 336);
            this.txtHeadSort.Name = "txtHeadSort";
            this.txtHeadSort.Size = new System.Drawing.Size(0, 18);
            this.txtHeadSort.TabIndex = 11;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(604, 425);
            this.Controls.Add(this.txtHeadSort);
            this.Controls.Add(this.txtMergeSort);
            this.Controls.Add(this.txtBubbleSort);
            this.Controls.Add(this.txtQuickSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.btnHeadSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnQuickSort);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnHeadSort;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtQuickSort;
        private System.Windows.Forms.Label txtBubbleSort;
        private System.Windows.Forms.Label txtMergeSort;
        private System.Windows.Forms.Label txtHeadSort;
    }
}

