namespace Practica_de_datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNregistros = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFechaCreado = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btPrimero = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btUltimo = new System.Windows.Forms.Button();
            this.pbLoader = new System.Windows.Forms.PictureBox();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(74, 21);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(312, 22);
            this.tbNombre.TabIndex = 0;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(74, 64);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDireccion.MaxLength = 150;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(312, 22);
            this.tbDireccion.TabIndex = 1;
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(74, 158);
            this.tbNota.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbNota.MaxLength = 150;
            this.tbNota.Multiline = true;
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(312, 75);
            this.tbNota.TabIndex = 3;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(2, 21);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(114, 22);
            this.tbBuscar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota:";
            // 
            // lbNregistros
            // 
            this.lbNregistros.AutoSize = true;
            this.lbNregistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNregistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNregistros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNregistros.Location = new System.Drawing.Point(242, 31);
            this.lbNregistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNregistros.Name = "lbNregistros";
            this.lbNregistros.Size = new System.Drawing.Size(28, 18);
            this.lbNregistros.TabIndex = 10;
            this.lbNregistros.Text = "0/0";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(72, 142);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 16);
            this.lbId.TabIndex = 18;
            this.lbId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Creado:";
            // 
            // lbFechaCreado
            // 
            this.lbFechaCreado.AutoSize = true;
            this.lbFechaCreado.Location = new System.Drawing.Point(72, 251);
            this.lbFechaCreado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaCreado.Name = "lbFechaCreado";
            this.lbFechaCreado.Size = new System.Drawing.Size(0, 16);
            this.lbFechaCreado.TabIndex = 22;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(74, 109);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTelefono.Mask = "(999) 0000-0000";
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(312, 22);
            this.tbTelefono.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBuscar);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Location = new System.Drawing.Point(438, 186);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(120, 94);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbLoader);
            this.groupBox2.Controls.Add(this.btNuevo);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.btBorrar);
            this.groupBox2.Controls.Add(this.btCancelar);
            this.groupBox2.Location = new System.Drawing.Point(436, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(120, 156);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNombre);
            this.groupBox3.Controls.Add(this.tbDireccion);
            this.groupBox3.Controls.Add(this.tbNota);
            this.groupBox3.Controls.Add(this.tbTelefono);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbFechaCreado);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbId);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(17, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 288);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Generales";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btPrimero);
            this.groupBox4.Controls.Add(this.lbNregistros);
            this.groupBox4.Controls.Add(this.btAnterior);
            this.groupBox4.Controls.Add(this.btSiguiente);
            this.groupBox4.Controls.Add(this.btUltimo);
            this.groupBox4.Location = new System.Drawing.Point(17, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(535, 71);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Navegacion";
            // 
            // btPrimero
            // 
            this.btPrimero.Image = global::Practica_de_datos.Properties.Resources.blue_gofirst_firstarrow_azu_12433;
            this.btPrimero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPrimero.Location = new System.Drawing.Point(5, 21);
            this.btPrimero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btPrimero.Name = "btPrimero";
            this.btPrimero.Size = new System.Drawing.Size(100, 36);
            this.btPrimero.TabIndex = 14;
            this.btPrimero.Text = "Primero";
            this.btPrimero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPrimero.UseVisualStyleBackColor = true;
            this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.Enabled = false;
            this.btAnterior.Image = global::Practica_de_datos.Properties.Resources.blue_rewind_arrow_12435;
            this.btAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnterior.Location = new System.Drawing.Point(112, 21);
            this.btAnterior.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(100, 36);
            this.btAnterior.TabIndex = 15;
            this.btAnterior.Text = "Anterior";
            this.btAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Enabled = false;
            this.btSiguiente.Image = global::Practica_de_datos.Properties.Resources.blue_moveforward_moveon_12436;
            this.btSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSiguiente.Location = new System.Drawing.Point(317, 21);
            this.btSiguiente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(100, 36);
            this.btSiguiente.TabIndex = 16;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btUltimo
            // 
            this.btUltimo.Image = global::Practica_de_datos.Properties.Resources.blue_gopast_past_arrow_12434;
            this.btUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUltimo.Location = new System.Drawing.Point(424, 21);
            this.btUltimo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btUltimo.Name = "btUltimo";
            this.btUltimo.Size = new System.Drawing.Size(100, 36);
            this.btUltimo.TabIndex = 17;
            this.btUltimo.Text = "Ultimo";
            this.btUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUltimo.UseVisualStyleBackColor = true;
            this.btUltimo.Click += new System.EventHandler(this.btUltimo_Click);
            // 
            // pbLoader
            // 
            this.pbLoader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoader.Image = global::Practica_de_datos.Properties.Resources.GCNyjJY;
            this.pbLoader.Location = new System.Drawing.Point(0, 15);
            this.pbLoader.Name = "pbLoader";
            this.pbLoader.Size = new System.Drawing.Size(120, 141);
            this.pbLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoader.TabIndex = 27;
            this.pbLoader.TabStop = false;
            this.pbLoader.Visible = false;
            // 
            // btNuevo
            // 
            this.btNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNuevo.Enabled = false;
            this.btNuevo.Image = global::Practica_de_datos.Properties.Resources.blue_insert_append_12420;
            this.btNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNuevo.Location = new System.Drawing.Point(2, 21);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btNuevo.Size = new System.Drawing.Size(114, 38);
            this.btNuevo.TabIndex = 19;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btAdd
            // 
            this.btAdd.Image = global::Practica_de_datos.Properties.Resources.blue_floppy_12557;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.Location = new System.Drawing.Point(2, 65);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(114, 38);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Guardar";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Enabled = false;
            this.btBorrar.Image = global::Practica_de_datos.Properties.Resources.blue_refuse_remove_delete_12601;
            this.btBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBorrar.Location = new System.Drawing.Point(2, 109);
            this.btBorrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(114, 38);
            this.btBorrar.TabIndex = 12;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::Practica_de_datos.Properties.Resources.blue_exit_delete_delete_12417;
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.Location = new System.Drawing.Point(2, 109);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(114, 38);
            this.btCancelar.TabIndex = 20;
            this.btCancelar.Text = "Cancel";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Visible = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::Practica_de_datos.Properties.Resources.Blue_search_find_12583;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.Location = new System.Drawing.Point(2, 49);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(114, 38);
            this.btBuscar.TabIndex = 13;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 383);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro contactos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNregistros;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btPrimero;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btUltimo;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbFechaCreado;
        private System.Windows.Forms.MaskedTextBox tbTelefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbLoader;
    }
}

