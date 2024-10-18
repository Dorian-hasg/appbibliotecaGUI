namespace TuNombreDeEspacio
{
    partial class FormConsultas
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
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnConsultarLibros = new System.Windows.Forms.Button();
            this.btnLibrosMasReservados = new System.Windows.Forms.Button();
            this.btnUsuariosMasActivos = new System.Windows.Forms.Button();
            this.dataGridLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(370, 247);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 0;
            // 
            // btnConsultarLibros
            // 
            this.btnConsultarLibros.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLibros.Location = new System.Drawing.Point(79, 306);
            this.btnConsultarLibros.Name = "btnConsultarLibros";
            this.btnConsultarLibros.Size = new System.Drawing.Size(137, 63);
            this.btnConsultarLibros.TabIndex = 1;
            this.btnConsultarLibros.Text = "Consulta";
            this.btnConsultarLibros.UseVisualStyleBackColor = true;
            this.btnConsultarLibros.Click += new System.EventHandler(this.btnConsultarLibros_Click_1);
            // 
            // btnLibrosMasReservados
            // 
            this.btnLibrosMasReservados.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrosMasReservados.Location = new System.Drawing.Point(79, 390);
            this.btnLibrosMasReservados.Name = "btnLibrosMasReservados";
            this.btnLibrosMasReservados.Size = new System.Drawing.Size(137, 63);
            this.btnLibrosMasReservados.TabIndex = 2;
            this.btnLibrosMasReservados.Text = "Reservado";
            this.btnLibrosMasReservados.UseVisualStyleBackColor = true;
            // 
            // btnUsuariosMasActivos
            // 
            this.btnUsuariosMasActivos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosMasActivos.Location = new System.Drawing.Point(79, 225);
            this.btnUsuariosMasActivos.Name = "btnUsuariosMasActivos";
            this.btnUsuariosMasActivos.Size = new System.Drawing.Size(137, 63);
            this.btnUsuariosMasActivos.TabIndex = 3;
            this.btnUsuariosMasActivos.Text = "Usuario";
            this.btnUsuariosMasActivos.UseVisualStyleBackColor = true;
            // 
            // dataGridLibros
            // 
            this.dataGridLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLibros.Location = new System.Drawing.Point(42, 21);
            this.dataGridLibros.Name = "dataGridLibros";
            this.dataGridLibros.Size = new System.Drawing.Size(493, 174);
            this.dataGridLibros.TabIndex = 4;
            this.dataGridLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormConsultas
            // 
            this.ClientSize = new System.Drawing.Size(573, 488);
            this.Controls.Add(this.dataGridLibros);
            this.Controls.Add(this.btnUsuariosMasActivos);
            this.Controls.Add(this.btnLibrosMasReservados);
            this.Controls.Add(this.btnConsultarLibros);
            this.Controls.Add(this.cmbGenero);
            this.Name = "FormConsultas";
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btnConsultarLibros;
        private System.Windows.Forms.Button btnLibrosMasReservados;
        private System.Windows.Forms.Button btnUsuariosMasActivos;
        private System.Windows.Forms.DataGridView dataGridLibros;
    }
}