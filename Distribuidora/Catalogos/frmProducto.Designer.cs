
namespace Distribuidora
{
    partial class fmrProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrProducto));
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCantidadTotal = new System.Windows.Forms.TextBox();
            this.txtCantidadMaxima = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtCantidadMinima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.picAgregarCategoria = new System.Windows.Forms.PictureBox();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtNomProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureNombre = new System.Windows.Forms.PictureBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureCodigo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(836, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(35, 35);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Producto";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 521);
            this.panel1.TabIndex = 1;
            this.panel1.UseWaitCursor = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.txtCantidadTotal);
            this.panel3.Controls.Add(this.txtCantidadMaxima);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.txtCantidadMinima);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(9, 418);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 100);
            this.panel3.TabIndex = 9;
            this.panel3.UseWaitCursor = true;
            // 
            // txtCantidadTotal
            // 
            this.txtCantidadTotal.BackColor = System.Drawing.Color.White;
            this.txtCantidadTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadTotal.Location = new System.Drawing.Point(51, 46);
            this.txtCantidadTotal.MaxLength = 18;
            this.txtCantidadTotal.Name = "txtCantidadTotal";
            this.txtCantidadTotal.Size = new System.Drawing.Size(173, 19);
            this.txtCantidadTotal.TabIndex = 62;
            this.txtCantidadTotal.UseWaitCursor = true;
            // 
            // txtCantidadMaxima
            // 
            this.txtCantidadMaxima.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadMaxima.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadMaxima.Location = new System.Drawing.Point(517, 46);
            this.txtCantidadMaxima.Name = "txtCantidadMaxima";
            this.txtCantidadMaxima.Size = new System.Drawing.Size(227, 19);
            this.txtCantidadMaxima.TabIndex = 61;
            this.txtCantidadMaxima.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Cantidad Maxima:";
            this.label6.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(508, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.UseWaitCursor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(6, 35);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(229, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 53;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.UseWaitCursor = true;
            // 
            // txtCantidadMinima
            // 
            this.txtCantidadMinima.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadMinima.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadMinima.Location = new System.Drawing.Point(255, 46);
            this.txtCantidadMinima.Name = "txtCantidadMinima";
            this.txtCantidadMinima.Size = new System.Drawing.Size(227, 19);
            this.txtCantidadMinima.TabIndex = 58;
            this.txtCantidadMinima.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Cantidad:";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Cantidad Minima:";
            this.label5.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(246, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnAgregarCliente);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.picAgregarCategoria);
            this.panel2.Controls.Add(this.cbxCategorias);
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Controls.Add(this.txtPrecioProducto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.txtNomProducto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureNombre);
            this.panel2.Controls.Add(this.txtCodigoProducto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureCodigo);
            this.panel2.Location = new System.Drawing.Point(9, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 345);
            this.panel2.TabIndex = 8;
            this.panel2.UseWaitCursor = true;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.White;
            this.btnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarCliente.Image = global::Distribuidora.Properties.Resources.save_;
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.Location = new System.Drawing.Point(636, 17);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(130, 57);
            this.btnAgregarCliente.TabIndex = 61;
            this.btnAgregarCliente.Text = "GUARDAR";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCliente.UseCompatibleTextRendering = true;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.UseWaitCursor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(312, 41);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 29);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 60;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.UseWaitCursor = true;
            // 
            // picAgregarCategoria
            // 
            this.picAgregarCategoria.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.picAgregarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("picAgregarCategoria.Image")));
            this.picAgregarCategoria.Location = new System.Drawing.Point(684, 299);
            this.picAgregarCategoria.Name = "picAgregarCategoria";
            this.picAgregarCategoria.Size = new System.Drawing.Size(32, 29);
            this.picAgregarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAgregarCategoria.TabIndex = 56;
            this.picAgregarCategoria.TabStop = false;
            this.picAgregarCategoria.UseWaitCursor = true;
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.BackColor = System.Drawing.Color.White;
            this.cbxCategorias.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(284, 303);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(385, 21);
            this.cbxCategorias.TabIndex = 55;
            this.cbxCategorias.UseWaitCursor = true;
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(20, 192);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(217, 19);
            this.txtMarca.TabIndex = 59;
            this.txtMarca.UseWaitCursor = true;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.Location = new System.Drawing.Point(349, 45);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(106, 19);
            this.txtPrecioProducto.TabIndex = 59;
            this.txtPrecioProducto.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "Marca";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Categorias:";
            this.label7.UseWaitCursor = true;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(305, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 58;
            this.label10.Text = "Precio:";
            this.label10.UseWaitCursor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(4, 181);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(254, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 57;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.UseWaitCursor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox4.Location = new System.Drawing.Point(273, 294);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(464, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.UseWaitCursor = true;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Location = new System.Drawing.Point(307, 34);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(254, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 57;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.UseWaitCursor = true;
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProducto.Location = new System.Drawing.Point(17, 116);
            this.txtNomProducto.MaxLength = 100;
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(712, 19);
            this.txtNomProducto.TabIndex = 35;
            this.txtNomProducto.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Descripcion:";
            this.label3.UseWaitCursor = true;
            // 
            // pictureNombre
            // 
            this.pictureNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureNombre.Location = new System.Drawing.Point(4, 105);
            this.pictureNombre.Name = "pictureNombre";
            this.pictureNombre.Size = new System.Drawing.Size(740, 40);
            this.pictureNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNombre.TabIndex = 33;
            this.pictureNombre.TabStop = false;
            this.pictureNombre.UseWaitCursor = true;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(16, 44);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(236, 19);
            this.txtCodigoProducto.TabIndex = 32;
            this.txtCodigoProducto.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Codigo:";
            this.label2.UseWaitCursor = true;
            // 
            // pictureCodigo
            // 
            this.pictureCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureCodigo.Location = new System.Drawing.Point(6, 34);
            this.pictureCodigo.Name = "pictureCodigo";
            this.pictureCodigo.Size = new System.Drawing.Size(255, 40);
            this.pictureCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCodigo.TabIndex = 30;
            this.pictureCodigo.TabStop = false;
            this.pictureCodigo.UseWaitCursor = true;
            this.pictureCodigo.Click += new System.EventHandler(this.pictureCodigo_Click);
            // 
            // fmrProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(914, 587);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrProducto";
            this.Text = "fmrProducto";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.fmrProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCodigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCantidadTotal;
        private System.Windows.Forms.TextBox txtCantidadMaxima;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtCantidadMinima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox picAgregarCategoria;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtNomProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureNombre;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureCodigo;
    }
}

