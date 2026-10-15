namespace LoginLol
{
    partial class FrmPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonas));
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtID = new TextBox();
            dgvPersonas = new DataGridView();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources.nuevo;
            btnNuevo.ImageAlign = ContentAlignment.TopCenter;
            btnNuevo.Location = new Point(87, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(93, 87);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(208, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 87);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(326, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 87);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.TopCenter;
            btnEditar.Location = new Point(470, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(93, 87);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.TopCenter;
            btnEliminar.Location = new Point(584, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 87);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button1_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSalir.Location = new Point(695, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 87);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(139, 124);
            txtID.Name = "txtID";
            txtID.Size = new Size(144, 27);
            txtID.TabIndex = 12;
            // 
            // dgvPersonas
            // 
            dgvPersonas.BackgroundColor = SystemColors.ControlDarkDark;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(12, 167);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.Size = new Size(829, 268);
            dgvPersonas.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(382, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(144, 27);
            txtNombre.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(631, 124);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(144, 27);
            txtTelefono.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 127);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 16;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(558, 127);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 17;
            label3.Text = "Telefono";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 127);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 18;
            label4.Text = "ID";
            // 
            // FrmPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(853, 447);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(dgvPersonas);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Name = "FrmPersonas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Personas";
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
        private Label label1;
        private TextBox txtID;
        private DataGridView dgvPersonas;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}