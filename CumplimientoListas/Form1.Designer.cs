namespace CumplimientoListas
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtHoja = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDialogo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.cmbListas = new System.Windows.Forms.ComboBox();
            this.btnSubirLista = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(845, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(155, 24);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.ReadOnly = true;
            this.txtLibro.Size = new System.Drawing.Size(467, 20);
            this.txtLibro.TabIndex = 3;
            // 
            // txtHoja
            // 
            this.txtHoja.Location = new System.Drawing.Point(157, 62);
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(185, 20);
            this.txtHoja.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(753, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(365, 60);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(133, 23);
            this.btnCargarDatos.TabIndex = 6;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Libro de Excel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del Hoja :";
            // 
            // btnDialogo
            // 
            this.btnDialogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDialogo.Location = new System.Drawing.Point(628, 21);
            this.btnDialogo.Name = "btnDialogo";
            this.btnDialogo.Size = new System.Drawing.Size(38, 23);
            this.btnDialogo.TabIndex = 9;
            this.btnDialogo.Text = "...";
            this.btnDialogo.UseVisualStyleBackColor = true;
            this.btnDialogo.Click += new System.EventHandler(this.btnDialogo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad de Registros :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 157);
            this.dataGridView1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(753, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(856, 109);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(75, 23);
            this.btnConexion.TabIndex = 14;
            this.btnConexion.Text = "Conexion";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(160, 334);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblTotalRegistros.TabIndex = 10;
            this.lblTotalRegistros.Text = "0";
            // 
            // cmbListas
            // 
            this.cmbListas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListas.FormattingEnabled = true;
            this.cmbListas.Items.AddRange(new object[] {
            "-- Seleccione el Tipo de Lista --",
            "Listas OFAC",
            "Lista de Requerimientos",
            "Listas PEPS"});
            this.cmbListas.Location = new System.Drawing.Point(564, 134);
            this.cmbListas.Name = "cmbListas";
            this.cmbListas.Size = new System.Drawing.Size(190, 21);
            this.cmbListas.TabIndex = 15;
            this.cmbListas.SelectedIndexChanged += new System.EventHandler(this.cmbListas_SelectedIndexChanged);
            // 
            // btnSubirLista
            // 
            this.btnSubirLista.Location = new System.Drawing.Point(546, 189);
            this.btnSubirLista.Name = "btnSubirLista";
            this.btnSubirLista.Size = new System.Drawing.Size(75, 23);
            this.btnSubirLista.TabIndex = 16;
            this.btnSubirLista.Text = "Subir Lista";
            this.btnSubirLista.UseVisualStyleBackColor = true;
            this.btnSubirLista.Click += new System.EventHandler(this.btnSubirLista_Click);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Location = new System.Drawing.Point(520, 405);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarRegistro.TabIndex = 17;
            this.btnAgregarRegistro.Text = "Agregar Registros";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 534);
            this.Controls.Add(this.btnAgregarRegistro);
            this.Controls.Add(this.btnSubirLista);
            this.Controls.Add(this.cmbListas);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDialogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtHoja);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtHoja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDialogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.ComboBox cmbListas;
        private System.Windows.Forms.Button btnSubirLista;
        private System.Windows.Forms.Button btnAgregarRegistro;
    }
}

