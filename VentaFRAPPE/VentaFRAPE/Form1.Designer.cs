namespace VentaFRAPE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.cmbmetodo = new System.Windows.Forms.ComboBox();
            this.lblcaramelo = new System.Windows.Forms.Label();
            this.chkoreo = new System.Windows.Forms.CheckBox();
            this.chkfresa = new System.Windows.Forms.CheckBox();
            this.pictureBoxOreo = new System.Windows.Forms.PictureBox();
            this.pictureBoxFresa = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoka = new System.Windows.Forms.PictureBox();
            this.chkmoka = new System.Windows.Forms.CheckBox();
            this.pictureBoxCafe = new System.Windows.Forms.PictureBox();
            this.chkcafe = new System.Windows.Forms.CheckBox();
            this.pictureBoxCaramelo = new System.Windows.Forms.PictureBox();
            this.chkcaramelo = new System.Windows.Forms.CheckBox();
            this.rbdchispas = new System.Windows.Forms.RadioButton();
            this.rbdchoco = new System.Windows.Forms.RadioButton();
            this.lblmetodo = new System.Windows.Forms.Label();
            this.lblimporte = new System.Windows.Forms.Label();
            this.listeleccion = new System.Windows.Forms.ListBox();
            this.btnpedido = new System.Windows.Forms.Button();
            this.maskfresa = new System.Windows.Forms.MaskedTextBox();
            this.panelcantidad = new System.Windows.Forms.Panel();
            this.maskoreo = new System.Windows.Forms.MaskedTextBox();
            this.maskcafe = new System.Windows.Forms.MaskedTextBox();
            this.maskcaramelo = new System.Windows.Forms.MaskedTextBox();
            this.maskmoka = new System.Windows.Forms.MaskedTextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lblcambio = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.btncomprar = new System.Windows.Forms.Button();
            this.lblsabores = new System.Windows.Forms.Label();
            this.rbdbarquillo = new System.Windows.Forms.RadioButton();
            this.lblpreciocaramelo = new System.Windows.Forms.Label();
            this.btnelegirnuevo = new System.Windows.Forms.Button();
            this.lblpagoen = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaramelo)).BeginInit();
            this.panelcantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Black;
            this.lbltitulo.Location = new System.Drawing.Point(232, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(248, 57);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Oü!-Frappes";
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(589, 432);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(84, 20);
            this.txtimporte.TabIndex = 1;
            // 
            // cmbmetodo
            // 
            this.cmbmetodo.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmetodo.FormattingEnabled = true;
            this.cmbmetodo.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cmbmetodo.Location = new System.Drawing.Point(490, 209);
            this.cmbmetodo.Name = "cmbmetodo";
            this.cmbmetodo.Size = new System.Drawing.Size(121, 27);
            this.cmbmetodo.TabIndex = 3;
            this.cmbmetodo.SelectedIndexChanged += new System.EventHandler(this.cmbtamaño_SelectedIndexChanged);
            // 
            // lblcaramelo
            // 
            this.lblcaramelo.AutoSize = true;
            this.lblcaramelo.BackColor = System.Drawing.Color.Transparent;
            this.lblcaramelo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaramelo.ForeColor = System.Drawing.Color.Indigo;
            this.lblcaramelo.Location = new System.Drawing.Point(487, 63);
            this.lblcaramelo.Name = "lblcaramelo";
            this.lblcaramelo.Size = new System.Drawing.Size(115, 23);
            this.lblcaramelo.TabIndex = 4;
            this.lblcaramelo.Text = "Caramelo Extra";
            // 
            // chkoreo
            // 
            this.chkoreo.AutoSize = true;
            this.chkoreo.BackColor = System.Drawing.Color.Transparent;
            this.chkoreo.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkoreo.Location = new System.Drawing.Point(105, 609);
            this.chkoreo.Name = "chkoreo";
            this.chkoreo.Size = new System.Drawing.Size(187, 30);
            this.chkoreo.TabIndex = 5;
            this.chkoreo.Text = "Frappe de Oreo $35";
            this.chkoreo.UseVisualStyleBackColor = false;
            this.chkoreo.CheckedChanged += new System.EventHandler(this.chkoreo_CheckedChanged);
            // 
            // chkfresa
            // 
            this.chkfresa.AutoSize = true;
            this.chkfresa.BackColor = System.Drawing.Color.Transparent;
            this.chkfresa.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkfresa.ForeColor = System.Drawing.Color.Black;
            this.chkfresa.Location = new System.Drawing.Point(106, 136);
            this.chkfresa.Name = "chkfresa";
            this.chkfresa.Size = new System.Drawing.Size(191, 30);
            this.chkfresa.TabIndex = 6;
            this.chkfresa.Text = "Frappe de Fresa $25";
            this.chkfresa.UseVisualStyleBackColor = false;
            this.chkfresa.CheckedChanged += new System.EventHandler(this.chkfresa_CheckedChanged);
            // 
            // pictureBoxOreo
            // 
            this.pictureBoxOreo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxOreo.BackgroundImage")));
            this.pictureBoxOreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxOreo.Location = new System.Drawing.Point(11, 568);
            this.pictureBoxOreo.Name = "pictureBoxOreo";
            this.pictureBoxOreo.Size = new System.Drawing.Size(88, 107);
            this.pictureBoxOreo.TabIndex = 7;
            this.pictureBoxOreo.TabStop = false;
            // 
            // pictureBoxFresa
            // 
            this.pictureBoxFresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFresa.BackgroundImage")));
            this.pictureBoxFresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFresa.Location = new System.Drawing.Point(12, 111);
            this.pictureBoxFresa.Name = "pictureBoxFresa";
            this.pictureBoxFresa.Size = new System.Drawing.Size(88, 107);
            this.pictureBoxFresa.TabIndex = 8;
            this.pictureBoxFresa.TabStop = false;
            // 
            // pictureBoxMoka
            // 
            this.pictureBoxMoka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMoka.BackgroundImage")));
            this.pictureBoxMoka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMoka.Location = new System.Drawing.Point(12, 227);
            this.pictureBoxMoka.Name = "pictureBoxMoka";
            this.pictureBoxMoka.Size = new System.Drawing.Size(88, 107);
            this.pictureBoxMoka.TabIndex = 9;
            this.pictureBoxMoka.TabStop = false;
            // 
            // chkmoka
            // 
            this.chkmoka.AutoSize = true;
            this.chkmoka.BackColor = System.Drawing.Color.Transparent;
            this.chkmoka.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkmoka.Location = new System.Drawing.Point(105, 263);
            this.chkmoka.Name = "chkmoka";
            this.chkmoka.Size = new System.Drawing.Size(191, 30);
            this.chkmoka.TabIndex = 10;
            this.chkmoka.Text = "Frappe de Moka $30";
            this.chkmoka.UseVisualStyleBackColor = false;
            this.chkmoka.CheckedChanged += new System.EventHandler(this.chkmoka_CheckedChanged);
            // 
            // pictureBoxCafe
            // 
            this.pictureBoxCafe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCafe.BackgroundImage")));
            this.pictureBoxCafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCafe.Location = new System.Drawing.Point(12, 455);
            this.pictureBoxCafe.Name = "pictureBoxCafe";
            this.pictureBoxCafe.Size = new System.Drawing.Size(88, 107);
            this.pictureBoxCafe.TabIndex = 11;
            this.pictureBoxCafe.TabStop = false;
            // 
            // chkcafe
            // 
            this.chkcafe.AutoSize = true;
            this.chkcafe.BackColor = System.Drawing.Color.Transparent;
            this.chkcafe.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcafe.Location = new System.Drawing.Point(105, 497);
            this.chkcafe.Name = "chkcafe";
            this.chkcafe.Size = new System.Drawing.Size(184, 30);
            this.chkcafe.TabIndex = 12;
            this.chkcafe.Text = "Frappe de Cafe $24";
            this.chkcafe.UseVisualStyleBackColor = false;
            this.chkcafe.CheckedChanged += new System.EventHandler(this.chkcafe_CheckedChanged);
            // 
            // pictureBoxCaramelo
            // 
            this.pictureBoxCaramelo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCaramelo.BackgroundImage")));
            this.pictureBoxCaramelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCaramelo.Location = new System.Drawing.Point(12, 340);
            this.pictureBoxCaramelo.Name = "pictureBoxCaramelo";
            this.pictureBoxCaramelo.Size = new System.Drawing.Size(88, 107);
            this.pictureBoxCaramelo.TabIndex = 13;
            this.pictureBoxCaramelo.TabStop = false;
            // 
            // chkcaramelo
            // 
            this.chkcaramelo.AutoSize = true;
            this.chkcaramelo.BackColor = System.Drawing.Color.Transparent;
            this.chkcaramelo.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcaramelo.Location = new System.Drawing.Point(105, 377);
            this.chkcaramelo.Name = "chkcaramelo";
            this.chkcaramelo.Size = new System.Drawing.Size(222, 30);
            this.chkcaramelo.TabIndex = 14;
            this.chkcaramelo.Text = "Frappe de Caramelo $20";
            this.chkcaramelo.UseVisualStyleBackColor = false;
            this.chkcaramelo.CheckedChanged += new System.EventHandler(this.chkcaramelo_CheckedChanged);
            // 
            // rbdchispas
            // 
            this.rbdchispas.AutoSize = true;
            this.rbdchispas.BackColor = System.Drawing.Color.Transparent;
            this.rbdchispas.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdchispas.Location = new System.Drawing.Point(491, 136);
            this.rbdchispas.Name = "rbdchispas";
            this.rbdchispas.Size = new System.Drawing.Size(86, 23);
            this.rbdchispas.TabIndex = 15;
            this.rbdchispas.TabStop = true;
            this.rbdchispas.Text = "Chispas $7";
            this.rbdchispas.UseVisualStyleBackColor = false;
            this.rbdchispas.CheckedChanged += new System.EventHandler(this.rbdchispas_CheckedChanged);
            // 
            // rbdchoco
            // 
            this.rbdchoco.AutoSize = true;
            this.rbdchoco.BackColor = System.Drawing.Color.Transparent;
            this.rbdchoco.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdchoco.Location = new System.Drawing.Point(490, 113);
            this.rbdchoco.Name = "rbdchoco";
            this.rbdchoco.Size = new System.Drawing.Size(156, 23);
            this.rbdchoco.TabIndex = 16;
            this.rbdchoco.TabStop = true;
            this.rbdchoco.Text = "Chocolate Derretido $5";
            this.rbdchoco.UseVisualStyleBackColor = false;
            this.rbdchoco.CheckedChanged += new System.EventHandler(this.rbdchoco_CheckedChanged);
            // 
            // lblmetodo
            // 
            this.lblmetodo.AutoSize = true;
            this.lblmetodo.BackColor = System.Drawing.Color.Transparent;
            this.lblmetodo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmetodo.ForeColor = System.Drawing.Color.Indigo;
            this.lblmetodo.Location = new System.Drawing.Point(487, 183);
            this.lblmetodo.Name = "lblmetodo";
            this.lblmetodo.Size = new System.Drawing.Size(115, 23);
            this.lblmetodo.TabIndex = 17;
            this.lblmetodo.Text = "Metodo de Pago";
            // 
            // lblimporte
            // 
            this.lblimporte.AutoSize = true;
            this.lblimporte.BackColor = System.Drawing.Color.Transparent;
            this.lblimporte.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimporte.ForeColor = System.Drawing.Color.Indigo;
            this.lblimporte.Location = new System.Drawing.Point(598, 406);
            this.lblimporte.Name = "lblimporte";
            this.lblimporte.Size = new System.Drawing.Size(62, 23);
            this.lblimporte.TabIndex = 19;
            this.lblimporte.Text = "Importe";
            // 
            // listeleccion
            // 
            this.listeleccion.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeleccion.FormattingEnabled = true;
            this.listeleccion.ItemHeight = 19;
            this.listeleccion.Location = new System.Drawing.Point(437, 305);
            this.listeleccion.Name = "listeleccion";
            this.listeleccion.Size = new System.Drawing.Size(165, 80);
            this.listeleccion.TabIndex = 20;
            // 
            // btnpedido
            // 
            this.btnpedido.BackColor = System.Drawing.Color.Yellow;
            this.btnpedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpedido.BackgroundImage")));
            this.btnpedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnpedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpedido.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpedido.Location = new System.Drawing.Point(478, 242);
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Size = new System.Drawing.Size(146, 46);
            this.btnpedido.TabIndex = 22;
            this.btnpedido.Text = "Tomar Pedido";
            this.btnpedido.UseVisualStyleBackColor = false;
            this.btnpedido.Click += new System.EventHandler(this.btnpedido_Click);
            // 
            // maskfresa
            // 
            this.maskfresa.Location = new System.Drawing.Point(18, 46);
            this.maskfresa.Mask = "99999";
            this.maskfresa.Name = "maskfresa";
            this.maskfresa.Size = new System.Drawing.Size(48, 20);
            this.maskfresa.TabIndex = 23;
            this.maskfresa.ValidatingType = typeof(int);
            // 
            // panelcantidad
            // 
            this.panelcantidad.BackColor = System.Drawing.Color.Transparent;
            this.panelcantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelcantidad.Controls.Add(this.maskoreo);
            this.panelcantidad.Controls.Add(this.maskcafe);
            this.panelcantidad.Controls.Add(this.maskcaramelo);
            this.panelcantidad.Controls.Add(this.maskmoka);
            this.panelcantidad.Controls.Add(this.lblcantidad);
            this.panelcantidad.Controls.Add(this.maskfresa);
            this.panelcantidad.Location = new System.Drawing.Point(325, 100);
            this.panelcantidad.Name = "panelcantidad";
            this.panelcantidad.Size = new System.Drawing.Size(89, 575);
            this.panelcantidad.TabIndex = 24;
            // 
            // maskoreo
            // 
            this.maskoreo.Location = new System.Drawing.Point(18, 509);
            this.maskoreo.Mask = "99999";
            this.maskoreo.Name = "maskoreo";
            this.maskoreo.Size = new System.Drawing.Size(48, 20);
            this.maskoreo.TabIndex = 28;
            this.maskoreo.ValidatingType = typeof(int);
            // 
            // maskcafe
            // 
            this.maskcafe.Location = new System.Drawing.Point(18, 397);
            this.maskcafe.Mask = "99999";
            this.maskcafe.Name = "maskcafe";
            this.maskcafe.Size = new System.Drawing.Size(48, 20);
            this.maskcafe.TabIndex = 27;
            this.maskcafe.ValidatingType = typeof(int);
            // 
            // maskcaramelo
            // 
            this.maskcaramelo.Location = new System.Drawing.Point(18, 277);
            this.maskcaramelo.Mask = "99999";
            this.maskcaramelo.Name = "maskcaramelo";
            this.maskcaramelo.Size = new System.Drawing.Size(48, 20);
            this.maskcaramelo.TabIndex = 26;
            this.maskcaramelo.ValidatingType = typeof(int);
            // 
            // maskmoka
            // 
            this.maskmoka.Location = new System.Drawing.Point(18, 169);
            this.maskmoka.Mask = "99999";
            this.maskmoka.Name = "maskmoka";
            this.maskmoka.Size = new System.Drawing.Size(48, 20);
            this.maskmoka.TabIndex = 25;
            this.maskmoka.ValidatingType = typeof(int);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblcantidad.Location = new System.Drawing.Point(4, 5);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(81, 26);
            this.lblcantidad.TabIndex = 24;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Indigo;
            this.lbltotal.Location = new System.Drawing.Point(446, 406);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(100, 23);
            this.lbltotal.TabIndex = 25;
            this.lbltotal.Text = "Total a pagar";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(450, 432);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(90, 20);
            this.txttotal.TabIndex = 26;
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.BackColor = System.Drawing.Color.Transparent;
            this.lblcambio.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblcambio.Location = new System.Drawing.Point(533, 520);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(59, 23);
            this.lblcambio.TabIndex = 27;
            this.lblcambio.Text = "Cambio";
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(503, 546);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(121, 20);
            this.txtcambio.TabIndex = 28;
            // 
            // btncomprar
            // 
            this.btncomprar.BackColor = System.Drawing.Color.Yellow;
            this.btncomprar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncomprar.BackgroundImage")));
            this.btncomprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncomprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncomprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomprar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomprar.Location = new System.Drawing.Point(491, 458);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(146, 46);
            this.btncomprar.TabIndex = 29;
            this.btncomprar.Text = "Comprar";
            this.btncomprar.UseVisualStyleBackColor = false;
            this.btncomprar.Click += new System.EventHandler(this.btncomprar_Click);
            // 
            // lblsabores
            // 
            this.lblsabores.AutoSize = true;
            this.lblsabores.BackColor = System.Drawing.Color.Transparent;
            this.lblsabores.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsabores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblsabores.Location = new System.Drawing.Point(92, 76);
            this.lblsabores.Name = "lblsabores";
            this.lblsabores.Size = new System.Drawing.Size(176, 23);
            this.lblsabores.TabIndex = 30;
            this.lblsabores.Text = "Eliga el Frappe que desee";
            // 
            // rbdbarquillo
            // 
            this.rbdbarquillo.AutoSize = true;
            this.rbdbarquillo.BackColor = System.Drawing.Color.Transparent;
            this.rbdbarquillo.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdbarquillo.Location = new System.Drawing.Point(490, 159);
            this.rbdbarquillo.Name = "rbdbarquillo";
            this.rbdbarquillo.Size = new System.Drawing.Size(93, 23);
            this.rbdbarquillo.TabIndex = 31;
            this.rbdbarquillo.TabStop = true;
            this.rbdbarquillo.Text = "Barquillo $8";
            this.rbdbarquillo.UseVisualStyleBackColor = false;
            this.rbdbarquillo.CheckedChanged += new System.EventHandler(this.rbdbarquillo_CheckedChanged);
            // 
            // lblpreciocaramelo
            // 
            this.lblpreciocaramelo.AutoSize = true;
            this.lblpreciocaramelo.BackColor = System.Drawing.Color.Transparent;
            this.lblpreciocaramelo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreciocaramelo.ForeColor = System.Drawing.Color.Blue;
            this.lblpreciocaramelo.Location = new System.Drawing.Point(463, 86);
            this.lblpreciocaramelo.Name = "lblpreciocaramelo";
            this.lblpreciocaramelo.Size = new System.Drawing.Size(176, 23);
            this.lblpreciocaramelo.TabIndex = 32;
            this.lblpreciocaramelo.Text = "(Precio por cada Frappe)";
            // 
            // btnelegirnuevo
            // 
            this.btnelegirnuevo.BackColor = System.Drawing.Color.Yellow;
            this.btnelegirnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnelegirnuevo.BackgroundImage")));
            this.btnelegirnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnelegirnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnelegirnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnelegirnuevo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnelegirnuevo.Location = new System.Drawing.Point(503, 601);
            this.btnelegirnuevo.Name = "btnelegirnuevo";
            this.btnelegirnuevo.Size = new System.Drawing.Size(124, 66);
            this.btnelegirnuevo.TabIndex = 33;
            this.btnelegirnuevo.Text = "Elegir Nuevamente";
            this.btnelegirnuevo.UseVisualStyleBackColor = false;
            this.btnelegirnuevo.Click += new System.EventHandler(this.btnelegirnuevo_Click);
            // 
            // lblpagoen
            // 
            this.lblpagoen.AutoSize = true;
            this.lblpagoen.BackColor = System.Drawing.Color.Transparent;
            this.lblpagoen.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagoen.ForeColor = System.Drawing.Color.Blue;
            this.lblpagoen.Location = new System.Drawing.Point(622, 301);
            this.lblpagoen.Name = "lblpagoen";
            this.lblpagoen.Size = new System.Drawing.Size(66, 23);
            this.lblpagoen.TabIndex = 35;
            this.lblpagoen.Text = "Pago en:";
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(608, 327);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(90, 20);
            this.txtpago.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 679);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.lblpagoen);
            this.Controls.Add(this.btnelegirnuevo);
            this.Controls.Add(this.lblpreciocaramelo);
            this.Controls.Add(this.rbdbarquillo);
            this.Controls.Add(this.lblsabores);
            this.Controls.Add(this.btncomprar);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.lblcambio);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.panelcantidad);
            this.Controls.Add(this.btnpedido);
            this.Controls.Add(this.listeleccion);
            this.Controls.Add(this.lblimporte);
            this.Controls.Add(this.lblmetodo);
            this.Controls.Add(this.rbdchoco);
            this.Controls.Add(this.rbdchispas);
            this.Controls.Add(this.chkcaramelo);
            this.Controls.Add(this.pictureBoxCaramelo);
            this.Controls.Add(this.chkcafe);
            this.Controls.Add(this.pictureBoxCafe);
            this.Controls.Add(this.chkmoka);
            this.Controls.Add(this.pictureBoxMoka);
            this.Controls.Add(this.pictureBoxFresa);
            this.Controls.Add(this.pictureBoxOreo);
            this.Controls.Add(this.chkfresa);
            this.Controls.Add(this.chkoreo);
            this.Controls.Add(this.lblcaramelo);
            this.Controls.Add(this.cmbmetodo);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.lbltitulo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Venta de Frappes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaramelo)).EndInit();
            this.panelcantidad.ResumeLayout(false);
            this.panelcantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.ComboBox cmbmetodo;
        private System.Windows.Forms.Label lblcaramelo;
        private System.Windows.Forms.CheckBox chkoreo;
        private System.Windows.Forms.CheckBox chkfresa;
        private System.Windows.Forms.PictureBox pictureBoxOreo;
        private System.Windows.Forms.PictureBox pictureBoxFresa;
        private System.Windows.Forms.PictureBox pictureBoxMoka;
        private System.Windows.Forms.CheckBox chkmoka;
        private System.Windows.Forms.PictureBox pictureBoxCafe;
        private System.Windows.Forms.CheckBox chkcafe;
        private System.Windows.Forms.PictureBox pictureBoxCaramelo;
        private System.Windows.Forms.CheckBox chkcaramelo;
        private System.Windows.Forms.RadioButton rbdchispas;
        private System.Windows.Forms.RadioButton rbdchoco;
        private System.Windows.Forms.Label lblmetodo;
        private System.Windows.Forms.Label lblimporte;
        private System.Windows.Forms.ListBox listeleccion;
        private System.Windows.Forms.Button btnpedido;
        private System.Windows.Forms.MaskedTextBox maskfresa;
        private System.Windows.Forms.Panel panelcantidad;
        private System.Windows.Forms.MaskedTextBox maskoreo;
        private System.Windows.Forms.MaskedTextBox maskcafe;
        private System.Windows.Forms.MaskedTextBox maskcaramelo;
        private System.Windows.Forms.MaskedTextBox maskmoka;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Button btncomprar;
        private System.Windows.Forms.Label lblsabores;
        private System.Windows.Forms.RadioButton rbdbarquillo;
        private System.Windows.Forms.Label lblpreciocaramelo;
        private System.Windows.Forms.Button btnelegirnuevo;
        private System.Windows.Forms.Label lblpagoen;
        private System.Windows.Forms.TextBox txtpago;
    }
}

