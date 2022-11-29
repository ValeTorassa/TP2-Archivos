namespace ArchivocCSharp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Alumno = new System.Windows.Forms.GroupBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtClase = new System.Windows.Forms.ComboBox();
            this.txtRaza = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdAlta = new System.Windows.Forms.Button();
            this.nmID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nmNivel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(544, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "s";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Alumno
            // 
            this.Alumno.Controls.Add(this.nmNivel);
            this.Alumno.Controls.Add(this.txtNombre);
            this.Alumno.Controls.Add(this.label7);
            this.Alumno.Controls.Add(this.label6);
            this.Alumno.Controls.Add(this.lblFoto);
            this.Alumno.Controls.Add(this.txtClase);
            this.Alumno.Controls.Add(this.txtRaza);
            this.Alumno.Controls.Add(this.label4);
            this.Alumno.Controls.Add(this.cmdAlta);
            this.Alumno.Controls.Add(this.nmID);
            this.Alumno.Controls.Add(this.label3);
            this.Alumno.Controls.Add(this.label2);
            this.Alumno.Controls.Add(this.label1);
            this.Alumno.Location = new System.Drawing.Point(11, 11);
            this.Alumno.Margin = new System.Windows.Forms.Padding(2);
            this.Alumno.Name = "Alumno";
            this.Alumno.Padding = new System.Windows.Forms.Padding(2);
            this.Alumno.Size = new System.Drawing.Size(278, 337);
            this.Alumno.TabIndex = 1;
            this.Alumno.TabStop = false;
            this.Alumno.Text = "Personaje";
            // 
            // lblFoto
            // 
            this.lblFoto.AllowDrop = true;
            this.lblFoto.AutoEllipsis = true;
            this.lblFoto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFoto.ImageList = this.imageList1;
            this.lblFoto.Location = new System.Drawing.Point(107, 183);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(83, 121);
            this.lblFoto.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "871328-plebeyo-orco.jpg");
            this.imageList1.Images.SetKeyName(1, "Lor\'themar_Tides_of_Vengeance.png");
            this.imageList1.Images.SetKeyName(2, "UAPQ0O3WTN381603122326262.png");
            this.imageList1.Images.SetKeyName(3, "enano9.jpg");
            this.imageList1.Images.SetKeyName(4, "260px-No-Muerto_WoW.jpg");
            // 
            // txtClase
            // 
            this.txtClase.FormattingEnabled = true;
            this.txtClase.Items.AddRange(new object[] {
            "Guerrero",
            "Cazador",
            "Chaman",
            "Mago",
            "Invocador"});
            this.txtClase.Location = new System.Drawing.Point(62, 122);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(187, 21);
            this.txtClase.TabIndex = 8;
            // 
            // txtRaza
            // 
            this.txtRaza.FormattingEnabled = true;
            this.txtRaza.Items.AddRange(new object[] {
            "Enano",
            "No Muerto",
            "Orco",
            "Elfo",
            "Humano"});
            this.txtRaza.Location = new System.Drawing.Point(62, 159);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(187, 21);
            this.txtRaza.TabIndex = 3;
            this.txtRaza.SelectedIndexChanged += new System.EventHandler(this.txtApellido_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raza";
            // 
            // cmdAlta
            // 
            this.cmdAlta.Location = new System.Drawing.Point(110, 306);
            this.cmdAlta.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAlta.Name = "cmdAlta";
            this.cmdAlta.Size = new System.Drawing.Size(80, 27);
            this.cmdAlta.TabIndex = 6;
            this.cmdAlta.Text = "Crear Cuenta";
            this.cmdAlta.UseVisualStyleBackColor = true;
            this.cmdAlta.Click += new System.EventHandler(this.cmdAlta_Click);
            // 
            // nmID
            // 
            this.nmID.Location = new System.Drawing.Point(62, 24);
            this.nmID.Margin = new System.Windows.Forms.Padding(2);
            this.nmID.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nmID.Name = "nmID";
            this.nmID.Size = new System.Drawing.Size(187, 20);
            this.nmID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Borrar Cuenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(324, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Creador de personajes de WOW";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(316, 297);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 35);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nivel";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // nmNivel
            // 
            this.nmNivel.Location = new System.Drawing.Point(62, 87);
            this.nmNivel.Margin = new System.Windows.Forms.Padding(2);
            this.nmNivel.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nmNivel.Name = "nmNivel";
            this.nmNivel.Size = new System.Drawing.Size(187, 20);
            this.nmNivel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 359);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Creador de Personajes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Alumno.ResumeLayout(false);
            this.Alumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Alumno;
        private System.Windows.Forms.Button cmdAlta;
        private System.Windows.Forms.NumericUpDown nmID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtRaza;
        private System.Windows.Forms.ComboBox txtClase;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.NumericUpDown nmNivel;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

