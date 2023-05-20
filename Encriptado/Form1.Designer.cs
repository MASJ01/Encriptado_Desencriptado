namespace Encriptado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_ENTRAR = new System.Windows.Forms.Button();
            this.NUD_LLAVE = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RDB_DESENCRIPTAR = new System.Windows.Forms.RadioButton();
            this.RDB_ENCRIPTAR = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_ACCION = new System.Windows.Forms.Button();
            this.RTF_MODIFICADO = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RTF_ORIGINAL = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_NUEVO = new System.Windows.Forms.Button();
            this.BTN_ABRIR1 = new System.Windows.Forms.Button();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.cuadro_guardar = new System.Windows.Forms.SaveFileDialog();
            this.cuadro_abrir = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LLAVE)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.BTN_ENTRAR);
            this.groupBox1.Controls.Add(this.NUD_LLAVE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RDB_DESENCRIPTAR);
            this.groupBox1.Controls.Add(this.RDB_ENCRIPTAR);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(544, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECCIONA LA OPCION";
            // 
            // BTN_ENTRAR
            // 
            this.BTN_ENTRAR.Location = new System.Drawing.Point(158, 164);
            this.BTN_ENTRAR.Name = "BTN_ENTRAR";
            this.BTN_ENTRAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ENTRAR.TabIndex = 4;
            this.BTN_ENTRAR.Text = "ENTRAR";
            this.BTN_ENTRAR.UseVisualStyleBackColor = true;
            this.BTN_ENTRAR.Click += new System.EventHandler(this.BTN_ENTRAR_Click);
            // 
            // NUD_LLAVE
            // 
            this.NUD_LLAVE.Location = new System.Drawing.Point(169, 98);
            this.NUD_LLAVE.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUD_LLAVE.Name = "NUD_LLAVE";
            this.NUD_LLAVE.Size = new System.Drawing.Size(87, 22);
            this.NUD_LLAVE.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "LLAVE";
            // 
            // RDB_DESENCRIPTAR
            // 
            this.RDB_DESENCRIPTAR.AutoSize = true;
            this.RDB_DESENCRIPTAR.Location = new System.Drawing.Point(227, 44);
            this.RDB_DESENCRIPTAR.Name = "RDB_DESENCRIPTAR";
            this.RDB_DESENCRIPTAR.Size = new System.Drawing.Size(132, 20);
            this.RDB_DESENCRIPTAR.TabIndex = 2;
            this.RDB_DESENCRIPTAR.TabStop = true;
            this.RDB_DESENCRIPTAR.Text = "DESENCRIPTAR";
            this.RDB_DESENCRIPTAR.UseVisualStyleBackColor = true;
            this.RDB_DESENCRIPTAR.CheckedChanged += new System.EventHandler(this.RDB_DESENCRIPTAR_CheckedChanged);
            // 
            // RDB_ENCRIPTAR
            // 
            this.RDB_ENCRIPTAR.AutoSize = true;
            this.RDB_ENCRIPTAR.Location = new System.Drawing.Point(9, 44);
            this.RDB_ENCRIPTAR.Name = "RDB_ENCRIPTAR";
            this.RDB_ENCRIPTAR.Size = new System.Drawing.Size(104, 20);
            this.RDB_ENCRIPTAR.TabIndex = 1;
            this.RDB_ENCRIPTAR.TabStop = true;
            this.RDB_ENCRIPTAR.Text = "ENCRIPTAR";
            this.RDB_ENCRIPTAR.UseVisualStyleBackColor = true;
            this.RDB_ENCRIPTAR.CheckedChanged += new System.EventHandler(this.RDB_ENCRIPTAR_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Red;
            this.groupBox2.Controls.Add(this.BTN_ACCION);
            this.groupBox2.Controls.Add(this.RTF_MODIFICADO);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RTF_ORIGINAL);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 429);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TEXTO";
            this.groupBox2.Visible = false;
            // 
            // BTN_ACCION
            // 
            this.BTN_ACCION.BackColor = System.Drawing.Color.Yellow;
            this.BTN_ACCION.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACCION.Location = new System.Drawing.Point(156, 197);
            this.BTN_ACCION.Name = "BTN_ACCION";
            this.BTN_ACCION.Size = new System.Drawing.Size(99, 24);
            this.BTN_ACCION.TabIndex = 4;
            this.BTN_ACCION.Text = "button1";
            this.BTN_ACCION.UseVisualStyleBackColor = false;
            this.BTN_ACCION.Click += new System.EventHandler(this.BTN_ACCION_Click);
            // 
            // RTF_MODIFICADO
            // 
            this.RTF_MODIFICADO.Location = new System.Drawing.Point(18, 273);
            this.RTF_MODIFICADO.Name = "RTF_MODIFICADO";
            this.RTF_MODIFICADO.Size = new System.Drawing.Size(390, 113);
            this.RTF_MODIFICADO.TabIndex = 3;
            this.RTF_MODIFICADO.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Texto Modificado";
            // 
            // RTF_ORIGINAL
            // 
            this.RTF_ORIGINAL.Location = new System.Drawing.Point(18, 44);
            this.RTF_ORIGINAL.Name = "RTF_ORIGINAL";
            this.RTF_ORIGINAL.Size = new System.Drawing.Size(390, 114);
            this.RTF_ORIGINAL.TabIndex = 1;
            this.RTF_ORIGINAL.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Texto Original";
            // 
            // BTN_NUEVO
            // 
            this.BTN_NUEVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_NUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NUEVO.Location = new System.Drawing.Point(600, 87);
            this.BTN_NUEVO.Name = "BTN_NUEVO";
            this.BTN_NUEVO.Size = new System.Drawing.Size(75, 23);
            this.BTN_NUEVO.TabIndex = 2;
            this.BTN_NUEVO.Text = "NUEVO";
            this.BTN_NUEVO.UseVisualStyleBackColor = false;
            this.BTN_NUEVO.Visible = false;
            this.BTN_NUEVO.Click += new System.EventHandler(this.BTN_NUEVO_Click);
            // 
            // BTN_ABRIR1
            // 
            this.BTN_ABRIR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_ABRIR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ABRIR1.Location = new System.Drawing.Point(725, 166);
            this.BTN_ABRIR1.Name = "BTN_ABRIR1";
            this.BTN_ABRIR1.Size = new System.Drawing.Size(75, 23);
            this.BTN_ABRIR1.TabIndex = 3;
            this.BTN_ABRIR1.Text = "ABRIR";
            this.BTN_ABRIR1.UseVisualStyleBackColor = false;
            this.BTN_ABRIR1.Visible = false;
            this.BTN_ABRIR1.Click += new System.EventHandler(this.BTN_ABRIR1_Click);
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_GUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GUARDAR.Location = new System.Drawing.Point(855, 87);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_GUARDAR.TabIndex = 4;
            this.BTN_GUARDAR.Text = "GUARDAR";
            this.BTN_GUARDAR.UseVisualStyleBackColor = false;
            this.BTN_GUARDAR.Visible = false;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // cuadro_abrir
            // 
            this.cuadro_abrir.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Encriptado.Properties.Resources.Encrip1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 467);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.BTN_ABRIR1);
            this.Controls.Add(this.BTN_NUEVO);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LLAVE)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_ENTRAR;
        private System.Windows.Forms.NumericUpDown NUD_LLAVE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RDB_DESENCRIPTAR;
        private System.Windows.Forms.RadioButton RDB_ENCRIPTAR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_ACCION;
        private System.Windows.Forms.RichTextBox RTF_MODIFICADO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RTF_ORIGINAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_NUEVO;
        private System.Windows.Forms.Button BTN_ABRIR1;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.SaveFileDialog cuadro_guardar;
        private System.Windows.Forms.OpenFileDialog cuadro_abrir;
    }
}

