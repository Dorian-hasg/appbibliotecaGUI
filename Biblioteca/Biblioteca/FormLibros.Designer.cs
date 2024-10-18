namespace Biblioteca
{
    partial class FormLibros
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
            this.txtIdUsuari = new System.Windows.Forms.TextBox();
            this.txtNombr = new System.Windows.Forms.TextBox();
            this.txtApellid = new System.Windows.Forms.TextBox();
            this.txtEmai = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuari = new System.Windows.Forms.Button();
            this.btnEditarUsuari = new System.Windows.Forms.Button();
            this.btnEliminarUsuari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdUsuari
            // 
            this.txtIdUsuari.Location = new System.Drawing.Point(186, 221);
            this.txtIdUsuari.Name = "txtIdUsuari";
            this.txtIdUsuari.Size = new System.Drawing.Size(100, 20);
            this.txtIdUsuari.TabIndex = 0;
            // 
            // txtNombr
            // 
            this.txtNombr.Location = new System.Drawing.Point(186, 264);
            this.txtNombr.Name = "txtNombr";
            this.txtNombr.Size = new System.Drawing.Size(100, 20);
            this.txtNombr.TabIndex = 1;
            // 
            // txtApellid
            // 
            this.txtApellid.Location = new System.Drawing.Point(186, 303);
            this.txtApellid.Name = "txtApellid";
            this.txtApellid.Size = new System.Drawing.Size(100, 20);
            this.txtApellid.TabIndex = 2;
            // 
            // txtEmai
            // 
            this.txtEmai.Location = new System.Drawing.Point(186, 344);
            this.txtEmai.Name = "txtEmai";
            this.txtEmai.Size = new System.Drawing.Size(100, 20);
            this.txtEmai.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(186, 386);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(16, 221);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 23);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 260);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 23);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(16, 303);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(84, 23);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(16, 344);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(72, 23);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(16, 382);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 23);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Telefono";
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(20, 19);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.Size = new System.Drawing.Size(657, 164);
            this.dataGridViewUsuario.TabIndex = 10;
            this.dataGridViewUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAgregarUsuari
            // 
            this.btnAgregarUsuari.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuari.Location = new System.Drawing.Point(489, 295);
            this.btnAgregarUsuari.Name = "btnAgregarUsuari";
            this.btnAgregarUsuari.Size = new System.Drawing.Size(106, 31);
            this.btnAgregarUsuari.TabIndex = 11;
            this.btnAgregarUsuari.Text = "Agregar";
            this.btnAgregarUsuari.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuari
            // 
            this.btnEditarUsuari.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuari.Location = new System.Drawing.Point(489, 218);
            this.btnEditarUsuari.Name = "btnEditarUsuari";
            this.btnEditarUsuari.Size = new System.Drawing.Size(106, 35);
            this.btnEditarUsuari.TabIndex = 12;
            this.btnEditarUsuari.Text = "Editar";
            this.btnEditarUsuari.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuari
            // 
            this.btnEliminarUsuari.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuari.Location = new System.Drawing.Point(489, 373);
            this.btnEliminarUsuari.Name = "btnEliminarUsuari";
            this.btnEliminarUsuari.Size = new System.Drawing.Size(106, 33);
            this.btnEliminarUsuari.TabIndex = 13;
            this.btnEliminarUsuari.Text = "Eliminar";
            this.btnEliminarUsuari.UseVisualStyleBackColor = true;
            // 
            // FormLibros
            // 
            this.ClientSize = new System.Drawing.Size(698, 472);
            this.Controls.Add(this.btnEliminarUsuari);
            this.Controls.Add(this.btnEditarUsuari);
            this.Controls.Add(this.btnAgregarUsuari);
            this.Controls.Add(this.dataGridViewUsuario);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmai);
            this.Controls.Add(this.txtApellid);
            this.Controls.Add(this.txtNombr);
            this.Controls.Add(this.txtIdUsuari);
            this.Name = "FormLibros";
            this.Load += new System.EventHandler(this.FormLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.TextBox txtIdUsuari;
        private System.Windows.Forms.TextBox txtNombr;
        private System.Windows.Forms.TextBox txtApellid;
        private System.Windows.Forms.TextBox txtEmai;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Button btnAgregarUsuari;
        private System.Windows.Forms.Button btnEditarUsuari;
        private System.Windows.Forms.Button btnEliminarUsuari;
    }
}