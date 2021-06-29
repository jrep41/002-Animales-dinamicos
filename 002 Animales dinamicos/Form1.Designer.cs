namespace _002_Animales_dinamicos
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
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Image_button = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBichos = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imagen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBorrarLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bttCargar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(15, 168);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(294, 29);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear un animal";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Image_button);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de un animal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Localizar imagen";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Image_button
            // 
            this.Image_button.Location = new System.Drawing.Point(108, 128);
            this.Image_button.Name = "Image_button";
            this.Image_button.Size = new System.Drawing.Size(200, 34);
            this.Image_button.TabIndex = 8;
            this.Image_button.Text = "Imagen";
            this.Image_button.UseVisualStyleBackColor = true;
            this.Image_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(62, 64);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(247, 20);
            this.txtColor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // lstBichos
            // 
            this.lstBichos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstBichos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Color,
            this.dia,
            this.imagen});
            this.lstBichos.FullRowSelect = true;
            this.lstBichos.HideSelection = false;
            this.lstBichos.Location = new System.Drawing.Point(424, 12);
            this.lstBichos.MultiSelect = false;
            this.lstBichos.Name = "lstBichos";
            this.lstBichos.Size = new System.Drawing.Size(445, 182);
            this.lstBichos.TabIndex = 2;
            this.lstBichos.UseCompatibleStateImageBehavior = false;
            this.lstBichos.View = System.Windows.Forms.View.Details;
            this.lstBichos.SelectedIndexChanged += new System.EventHandler(this.lstBichos_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 145;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.Width = 97;
            // 
            // dia
            // 
            this.dia.Text = "fecha nacimiento";
            this.dia.Width = 120;
            // 
            // imagen
            // 
            this.imagen.Text = "imagen";
            this.imagen.Width = 78;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(343, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 36);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar Animales";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBorrarLista
            // 
            this.btnBorrarLista.Location = new System.Drawing.Point(343, 68);
            this.btnBorrarLista.Name = "btnBorrarLista";
            this.btnBorrarLista.Size = new System.Drawing.Size(75, 54);
            this.btnBorrarLista.TabIndex = 4;
            this.btnBorrarLista.Text = "Borrar listado";
            this.btnBorrarLista.UseVisualStyleBackColor = true;
            this.btnBorrarLista.Click += new System.EventHandler(this.btnBorrarLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "fecha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hoy es";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(886, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 181);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.jpg";
            this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Imagen de la mascota";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // bttCargar
            // 
            this.bttCargar.Location = new System.Drawing.Point(344, 147);
            this.bttCargar.Name = "bttCargar";
            this.bttCargar.Size = new System.Drawing.Size(75, 23);
            this.bttCargar.TabIndex = 10;
            this.bttCargar.Text = "Cargar";
            this.bttCargar.UseVisualStyleBackColor = true;
            this.bttCargar.Click += new System.EventHandler(this.bttCargar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(344, 184);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 11;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 237);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.bttCargar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBorrarLista);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstBichos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Animales dinámicos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstBichos;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBorrarLista;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader dia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Image_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader imagen;
        private System.Windows.Forms.Button bttCargar;
        private System.Windows.Forms.Button btGuardar;
    }
}

