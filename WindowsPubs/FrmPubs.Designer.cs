
namespace WindowsPubs
{
    partial class FrmPubs
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
            this.btnTraerAutores = new System.Windows.Forms.Button();
            this.btnTraerPublicadores = new System.Windows.Forms.Button();
            this.btnAutoresCiudad = new System.Windows.Forms.Button();
            this.btnAutorId = new System.Windows.Forms.Button();
            this.btnPublicadorNombre = new System.Windows.Forms.Button();
            this.btnLista1 = new System.Windows.Forms.Button();
            this.btnLista2 = new System.Windows.Forms.Button();
            this.btnLista3 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerAutores
            // 
            this.btnTraerAutores.Location = new System.Drawing.Point(34, 12);
            this.btnTraerAutores.Name = "btnTraerAutores";
            this.btnTraerAutores.Size = new System.Drawing.Size(83, 48);
            this.btnTraerAutores.TabIndex = 0;
            this.btnTraerAutores.Text = "Traer todos los autores";
            this.btnTraerAutores.UseVisualStyleBackColor = true;
            this.btnTraerAutores.Click += new System.EventHandler(this.btnTraerAutores_Click);
            // 
            // btnTraerPublicadores
            // 
            this.btnTraerPublicadores.Location = new System.Drawing.Point(137, 12);
            this.btnTraerPublicadores.Name = "btnTraerPublicadores";
            this.btnTraerPublicadores.Size = new System.Drawing.Size(83, 48);
            this.btnTraerPublicadores.TabIndex = 1;
            this.btnTraerPublicadores.Text = "Traer todos los publicadores";
            this.btnTraerPublicadores.UseVisualStyleBackColor = true;
            this.btnTraerPublicadores.Click += new System.EventHandler(this.btnTraerPublicadores_Click);
            // 
            // btnAutoresCiudad
            // 
            this.btnAutoresCiudad.Location = new System.Drawing.Point(237, 12);
            this.btnAutoresCiudad.Name = "btnAutoresCiudad";
            this.btnAutoresCiudad.Size = new System.Drawing.Size(86, 74);
            this.btnAutoresCiudad.TabIndex = 2;
            this.btnAutoresCiudad.Text = "Traer todos los autores que viven en la misma ciudad";
            this.btnAutoresCiudad.UseVisualStyleBackColor = true;
            this.btnAutoresCiudad.Click += new System.EventHandler(this.btnAutoresCiudad_Click);
            // 
            // btnAutorId
            // 
            this.btnAutorId.Location = new System.Drawing.Point(340, 13);
            this.btnAutorId.Name = "btnAutorId";
            this.btnAutorId.Size = new System.Drawing.Size(82, 47);
            this.btnAutorId.TabIndex = 3;
            this.btnAutorId.Text = "Traer autores por ID";
            this.btnAutorId.UseVisualStyleBackColor = true;
            this.btnAutorId.Click += new System.EventHandler(this.btnAutorId_Click);
            // 
            // btnPublicadorNombre
            // 
            this.btnPublicadorNombre.Location = new System.Drawing.Point(439, 13);
            this.btnPublicadorNombre.Name = "btnPublicadorNombre";
            this.btnPublicadorNombre.Size = new System.Drawing.Size(82, 47);
            this.btnPublicadorNombre.TabIndex = 4;
            this.btnPublicadorNombre.Text = "Traer publicadores por su nombre";
            this.btnPublicadorNombre.UseVisualStyleBackColor = true;
            this.btnPublicadorNombre.Click += new System.EventHandler(this.btnPublicadorNombre_Click);
            // 
            // btnLista1
            // 
            this.btnLista1.Location = new System.Drawing.Point(527, 13);
            this.btnLista1.Name = "btnLista1";
            this.btnLista1.Size = new System.Drawing.Size(82, 47);
            this.btnLista1.TabIndex = 5;
            this.btnLista1.Text = "Lista 1";
            this.btnLista1.UseVisualStyleBackColor = true;
            this.btnLista1.Click += new System.EventHandler(this.btnLista1_Click);
            // 
            // btnLista2
            // 
            this.btnLista2.Location = new System.Drawing.Point(615, 12);
            this.btnLista2.Name = "btnLista2";
            this.btnLista2.Size = new System.Drawing.Size(82, 47);
            this.btnLista2.TabIndex = 6;
            this.btnLista2.Text = "Lista 2";
            this.btnLista2.UseVisualStyleBackColor = true;
            this.btnLista2.Click += new System.EventHandler(this.btnLista2_Click);
            // 
            // btnLista3
            // 
            this.btnLista3.Location = new System.Drawing.Point(706, 12);
            this.btnLista3.Name = "btnLista3";
            this.btnLista3.Size = new System.Drawing.Size(82, 47);
            this.btnLista3.TabIndex = 7;
            this.btnLista3.Text = "Lista 3";
            this.btnLista3.UseVisualStyleBackColor = true;
            this.btnLista3.Click += new System.EventHandler(this.btnLista3_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(13, 115);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(775, 323);
            this.grid.TabIndex = 8;
            // 
            // FrmPubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnLista3);
            this.Controls.Add(this.btnLista2);
            this.Controls.Add(this.btnLista1);
            this.Controls.Add(this.btnPublicadorNombre);
            this.Controls.Add(this.btnAutorId);
            this.Controls.Add(this.btnAutoresCiudad);
            this.Controls.Add(this.btnTraerPublicadores);
            this.Controls.Add(this.btnTraerAutores);
            this.Name = "FrmPubs";
            this.Text = "FrmPubs";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerAutores;
        private System.Windows.Forms.Button btnTraerPublicadores;
        private System.Windows.Forms.Button btnAutoresCiudad;
        private System.Windows.Forms.Button btnAutorId;
        private System.Windows.Forms.Button btnPublicadorNombre;
        private System.Windows.Forms.Button btnLista1;
        private System.Windows.Forms.Button btnLista2;
        private System.Windows.Forms.Button btnLista3;
        private System.Windows.Forms.DataGridView grid;
    }
}