namespace CumplimientoListas
{
    partial class ProcesarListas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargarGridHoja = new System.Windows.Forms.Button();
            this.txtHoja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLibro = new System.Windows.Forms.Button();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCargarGridHoja);
            this.panel1.Controls.Add(this.txtHoja);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLibro);
            this.panel1.Controls.Add(this.txtLibro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnCargarGridHoja
            // 
            this.btnCargarGridHoja.Location = new System.Drawing.Point(292, 66);
            this.btnCargarGridHoja.Name = "btnCargarGridHoja";
            this.btnCargarGridHoja.Size = new System.Drawing.Size(100, 23);
            this.btnCargarGridHoja.TabIndex = 5;
            this.btnCargarGridHoja.Text = "Cargar Datos";
            this.btnCargarGridHoja.UseVisualStyleBackColor = true;
            this.btnCargarGridHoja.Click += new System.EventHandler(this.btnCargarGridHoja_Click);
            // 
            // txtHoja
            // 
            this.txtHoja.Location = new System.Drawing.Point(150, 66);
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(121, 20);
            this.txtHoja.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese  la Hoja del Libro :";
            // 
            // btnLibro
            // 
            this.btnLibro.Location = new System.Drawing.Point(557, 28);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(95, 26);
            this.btnLibro.TabIndex = 2;
            this.btnLibro.Text = "Seleccionar...";
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(7, 30);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(533, 20);
            this.txtLibro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Libro de Excel :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalRegistros.Location = new System.Drawing.Point(206, 132);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(84, 16);
            this.lblTotalRegistros.TabIndex = 7;
            this.lblTotalRegistros.Text = "0";
            this.lblTotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registros Disponibles para Procesar :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(140, 307);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(439, 36);
            this.btnProcesar.TabIndex = 9;
            this.btnProcesar.Text = "Procesar Registros";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 385);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(680, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(17, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Registros Para Subir :";
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(140, 553);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(439, 31);
            this.btnSubir.TabIndex = 12;
            this.btnSubir.Text = "Subir Registros";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
           /// this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProcesarListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 609);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ProcesarListas";
            this.Text = "Listas de Cumplimiento";
            this.Load += new System.EventHandler(this.ProcesarListas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Button btnCargarGridHoja;
        private System.Windows.Forms.TextBox txtHoja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button button1;
    }
}