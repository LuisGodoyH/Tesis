namespace Presentacion
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.camImagen = new Emgu.CV.UI.ImageBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcamara = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbescala = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbminimo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdetectmin = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbExtraerRostro = new Emgu.CV.UI.ImageBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.group = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.camImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtraerRostro)).BeginInit();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // camImagen
            // 
            this.camImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camImagen.Location = new System.Drawing.Point(12, 12);
            this.camImagen.Name = "camImagen";
            this.camImagen.Size = new System.Drawing.Size(513, 378);
            this.camImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.camImagen.TabIndex = 2;
            this.camImagen.TabStop = false;
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(450, 396);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(75, 23);
            this.btniniciar.TabIndex = 3;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccionar Camara:";
            // 
            // cmbcamara
            // 
            this.cmbcamara.FormattingEnabled = true;
            this.cmbcamara.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbcamara.Location = new System.Drawing.Point(306, 396);
            this.cmbcamara.Name = "cmbcamara";
            this.cmbcamara.Size = new System.Drawing.Size(121, 21);
            this.cmbcamara.TabIndex = 5;
            this.cmbcamara.SelectedIndexChanged += new System.EventHandler(this.cmbcamara_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parametros de Deteccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aumento de Escala";
            // 
            // cmbescala
            // 
            this.cmbescala.FormattingEnabled = true;
            this.cmbescala.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "1.3",
            "1.4"});
            this.cmbescala.Location = new System.Drawing.Point(178, 34);
            this.cmbescala.Name = "cmbescala";
            this.cmbescala.Size = new System.Drawing.Size(121, 21);
            this.cmbescala.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Min a Reconocer";
            // 
            // cmbminimo
            // 
            this.cmbminimo.FormattingEnabled = true;
            this.cmbminimo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbminimo.Location = new System.Drawing.Point(178, 61);
            this.cmbminimo.Name = "cmbminimo";
            this.cmbminimo.Size = new System.Drawing.Size(121, 21);
            this.cmbminimo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minino Escala de Deteccion";
            // 
            // txtdetectmin
            // 
            this.txtdetectmin.Location = new System.Drawing.Point(178, 88);
            this.txtdetectmin.Name = "txtdetectmin";
            this.txtdetectmin.Size = new System.Drawing.Size(121, 20);
            this.txtdetectmin.TabIndex = 12;
            this.txtdetectmin.Text = "3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(89, 368);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 30);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbExtraerRostro);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtdetectmin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbminimo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbescala);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(530, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 405);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obtener Rostro";
            // 
            // pbExtraerRostro
            // 
            this.pbExtraerRostro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExtraerRostro.Location = new System.Drawing.Point(59, 117);
            this.pbExtraerRostro.Name = "pbExtraerRostro";
            this.pbExtraerRostro.Size = new System.Drawing.Size(193, 200);
            this.pbExtraerRostro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExtraerRostro.TabIndex = 21;
            this.pbExtraerRostro.TabStop = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(95, 326);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 18;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // group
            // 
            this.group.Controls.Add(this.imageBox1);
            this.group.Controls.Add(this.button1);
            this.group.Location = new System.Drawing.Point(853, 15);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(317, 405);
            this.group.TabIndex = 19;
            this.group.TabStop = false;
            this.group.Text = "Obtener Rostro";
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(53, 41);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(221, 251);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 20;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Identificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 436);
            this.Controls.Add(this.group);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbcamara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.camImagen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtraerRostro)).EndInit();
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox camImagen;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcamara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbescala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbminimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdetectmin;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TextBox txtnombre;
        private Emgu.CV.UI.ImageBox pbExtraerRostro;
    }
}

