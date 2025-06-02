namespace CapaPresentacion
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
            dgvLibros = new DataGridView();
            cmbTipoLibro = new ComboBox();
            lblTipo = new Label();
            lblTitulo = new Label();
            lblAutor = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            lblEditorial = new Label();
            txtEditorial = new TextBox();
            txtPeso = new TextBox();
            lblPeso = new Label();
            lblFormato = new Label();
            txtFormato = new TextBox();
            lblTamanoMB = new Label();
            txtTamanoMB = new TextBox();
            btnLimpiarCampos = new PictureBox();
            btnsalir = new PictureBox();
            btnAgregar = new PictureBox();
            btnEliminar = new PictureBox();
            btnListar = new PictureBox();
            btnActualizar = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLimpiarCampos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnListar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnActualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(12, 119);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(922, 292);
            dgvLibros.TabIndex = 1;
            // 
            // cmbTipoLibro
            // 
            cmbTipoLibro.FormattingEnabled = true;
            cmbTipoLibro.Location = new Point(783, 84);
            cmbTipoLibro.Name = "cmbTipoLibro";
            cmbTipoLibro.Size = new Size(151, 28);
            cmbTipoLibro.TabIndex = 2;
            cmbTipoLibro.SelectedIndexChanged += cmbTipoLibro_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Firebrick;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Image = (Image)resources.GetObject("lblTipo.Image");
            lblTipo.Location = new Point(644, 80);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(133, 28);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo de libro";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Image = (Image)resources.GetObject("lblTitulo.Image");
            lblTitulo.Location = new Point(12, 434);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(68, 28);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAutor.Image = (Image)resources.GetObject("lblAutor.Image");
            lblAutor.Location = new Point(12, 474);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(66, 28);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "\tAutor";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(251, 431);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(207, 27);
            txtTitulo.TabIndex = 6;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(251, 475);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(207, 27);
            txtAutor.TabIndex = 7;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.BackColor = Color.Linen;
            lblEditorial.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditorial.Image = (Image)resources.GetObject("lblEditorial.Image");
            lblEditorial.Location = new Point(12, 512);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(233, 28);
            lblEditorial.TabIndex = 8;
            lblEditorial.Text = "Editorial (solo impreso)";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(251, 516);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(207, 27);
            txtEditorial.TabIndex = 9;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(251, 552);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(207, 27);
            txtPeso.TabIndex = 10;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.BackColor = Color.Linen;
            lblPeso.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPeso.Location = new Point(12, 548);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(239, 28);
            lblPeso.TabIndex = 11;
            lblPeso.Text = "Peso (kg) (solo impreso)";
            // 
            // lblFormato
            // 
            lblFormato.AutoSize = true;
            lblFormato.BackColor = Color.Linen;
            lblFormato.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFormato.Location = new Point(464, 434);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(217, 28);
            lblFormato.TabIndex = 12;
            lblFormato.Text = "Formato (solo digital)";
            // 
            // txtFormato
            // 
            txtFormato.Location = new Point(728, 431);
            txtFormato.Name = "txtFormato";
            txtFormato.Size = new Size(192, 27);
            txtFormato.TabIndex = 13;
            // 
            // lblTamanoMB
            // 
            lblTamanoMB.AutoSize = true;
            lblTamanoMB.BackColor = Color.Linen;
            lblTamanoMB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTamanoMB.Location = new Point(464, 470);
            lblTamanoMB.Name = "lblTamanoMB";
            lblTamanoMB.Size = new Size(264, 28);
            lblTamanoMB.TabIndex = 14;
            lblTamanoMB.Text = "Tamaño (MB) (solo digital)";
            // 
            // txtTamanoMB
            // 
            txtTamanoMB.Location = new Point(728, 469);
            txtTamanoMB.Name = "txtTamanoMB";
            txtTamanoMB.Size = new Size(192, 27);
            txtTamanoMB.TabIndex = 15;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackgroundImage = (Image)resources.GetObject("btnLimpiarCampos.BackgroundImage");
            btnLimpiarCampos.Image = (Image)resources.GetObject("btnLimpiarCampos.Image");
            btnLimpiarCampos.Location = new Point(821, 3);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(51, 49);
            btnLimpiarCampos.SizeMode = PictureBoxSizeMode.Zoom;
            btnLimpiarCampos.TabIndex = 20;
            btnLimpiarCampos.TabStop = false;
            btnLimpiarCampos.Click += pictureBox1_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackgroundImage = (Image)resources.GetObject("btnsalir.BackgroundImage");
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(878, 3);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(56, 49);
            btnsalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnsalir.TabIndex = 21;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Linen;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(561, 525);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(61, 62);
            btnAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            btnAgregar.TabIndex = 22;
            btnAgregar.TabStop = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Linen;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(793, 525);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(55, 61);
            btnEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminar.TabIndex = 23;
            btnEliminar.TabStop = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.Linen;
            btnListar.Image = (Image)resources.GetObject("btnListar.Image");
            btnListar.Location = new Point(716, 525);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(61, 62);
            btnListar.SizeMode = PictureBoxSizeMode.Zoom;
            btnListar.TabIndex = 24;
            btnListar.TabStop = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Linen;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.Location = new Point(644, 524);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(55, 61);
            btnActualizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnActualizar.TabIndex = 25;
            btnActualizar.TabStop = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-22, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(159, 40);
            label1.Name = "label1";
            label1.Size = new Size(479, 56);
            label1.TabIndex = 27;
            label1.Text = "Gestion de libros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(949, 601);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnActualizar);
            Controls.Add(btnListar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnsalir);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(txtTamanoMB);
            Controls.Add(lblTamanoMB);
            Controls.Add(txtFormato);
            Controls.Add(lblFormato);
            Controls.Add(lblPeso);
            Controls.Add(txtPeso);
            Controls.Add(txtEditorial);
            Controls.Add(lblEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipoLibro);
            Controls.Add(dgvLibros);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLimpiarCampos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnListar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnActualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvLibros;
        private ComboBox cmbTipoLibro;
        private Label lblTipo;
        private Label lblTitulo;
        private Label lblAutor;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private Label lblEditorial;
        private TextBox txtEditorial;
        private TextBox txtPeso;
        private Label lblPeso;
        private Label lblFormato;
        private TextBox txtFormato;
        private Label lblTamanoMB;
        private TextBox txtTamanoMB;
        private PictureBox btnLimpiarCampos;
        private PictureBox btnsalir;
        private PictureBox btnAgregar;
        private PictureBox btnEliminar;
        private PictureBox btnListar;
        private PictureBox btnActualizar;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
