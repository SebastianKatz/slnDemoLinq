
namespace WindowsEFLinq
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
            this.txtTraerProductos = new System.Windows.Forms.Button();
            this.btnTraerPorCategoria = new System.Windows.Forms.Button();
            this.btnTraerPorNombre = new System.Windows.Forms.Button();
            this.btnTraerId = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTraerProductos
            // 
            this.txtTraerProductos.Location = new System.Drawing.Point(12, 12);
            this.txtTraerProductos.Name = "txtTraerProductos";
            this.txtTraerProductos.Size = new System.Drawing.Size(119, 41);
            this.txtTraerProductos.TabIndex = 0;
            this.txtTraerProductos.Text = "Traer todos los productos";
            this.txtTraerProductos.UseVisualStyleBackColor = true;
            this.txtTraerProductos.Click += new System.EventHandler(this.txtTraerProductos_Click);
            // 
            // btnTraerPorCategoria
            // 
            this.btnTraerPorCategoria.Location = new System.Drawing.Point(152, 12);
            this.btnTraerPorCategoria.Name = "btnTraerPorCategoria";
            this.btnTraerPorCategoria.Size = new System.Drawing.Size(134, 41);
            this.btnTraerPorCategoria.TabIndex = 1;
            this.btnTraerPorCategoria.Text = "Traer todos los productos por categoria";
            this.btnTraerPorCategoria.UseVisualStyleBackColor = true;
            this.btnTraerPorCategoria.Click += new System.EventHandler(this.btnTraerPorCategoria_Click);
            // 
            // btnTraerPorNombre
            // 
            this.btnTraerPorNombre.Location = new System.Drawing.Point(304, 12);
            this.btnTraerPorNombre.Name = "btnTraerPorNombre";
            this.btnTraerPorNombre.Size = new System.Drawing.Size(134, 41);
            this.btnTraerPorNombre.TabIndex = 2;
            this.btnTraerPorNombre.Text = "Traer por nombre de producto";
            this.btnTraerPorNombre.UseVisualStyleBackColor = true;
            this.btnTraerPorNombre.Click += new System.EventHandler(this.btnTraerPorNombre_Click);
            // 
            // btnTraerId
            // 
            this.btnTraerId.Location = new System.Drawing.Point(453, 12);
            this.btnTraerId.Name = "btnTraerId";
            this.btnTraerId.Size = new System.Drawing.Size(107, 41);
            this.btnTraerId.TabIndex = 3;
            this.btnTraerId.Text = "Traer por ID";
            this.btnTraerId.UseVisualStyleBackColor = true;
            this.btnTraerId.Click += new System.EventHandler(this.btnTraerId_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(13, 59);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(775, 379);
            this.gridProductos.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnTraerId);
            this.Controls.Add(this.btnTraerPorNombre);
            this.Controls.Add(this.btnTraerPorCategoria);
            this.Controls.Add(this.txtTraerProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtTraerProductos;
        private System.Windows.Forms.Button btnTraerPorCategoria;
        private System.Windows.Forms.Button btnTraerPorNombre;
        private System.Windows.Forms.Button btnTraerId;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Button button1;
    }
}

