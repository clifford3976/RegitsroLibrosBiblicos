namespace LibrosBiblicos.UI.Registro
{
    partial class rLibros
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SiglastextBox = new System.Windows.Forms.TextBox();
            this.DescripcionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.LibroIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TipotextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibroIdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SiglastextBox
            // 
            this.SiglastextBox.Location = new System.Drawing.Point(213, 247);
            this.SiglastextBox.Name = "SiglastextBox";
            this.SiglastextBox.Size = new System.Drawing.Size(213, 20);
            this.SiglastextBox.TabIndex = 20;
            // 
            // DescripcionrichTextBox
            // 
            this.DescripcionrichTextBox.Location = new System.Drawing.Point(213, 73);
            this.DescripcionrichTextBox.Name = "DescripcionrichTextBox";
            this.DescripcionrichTextBox.Size = new System.Drawing.Size(213, 65);
            this.DescripcionrichTextBox.TabIndex = 19;
            this.DescripcionrichTextBox.Text = "";
            // 
            // LibroIdnumericUpDown
            // 
            this.LibroIdnumericUpDown.Location = new System.Drawing.Point(213, 43);
            this.LibroIdnumericUpDown.Name = "LibroIdnumericUpDown";
            this.LibroIdnumericUpDown.Size = new System.Drawing.Size(213, 20);
            this.LibroIdnumericUpDown.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Siglas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "LibroId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(213, 187);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(213, 20);
            this.FechadateTimePicker.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tipo";
            // 
            // TipotextBox
            // 
            this.TipotextBox.Location = new System.Drawing.Point(213, 301);
            this.TipotextBox.Name = "TipotextBox";
            this.TipotextBox.Size = new System.Drawing.Size(213, 20);
            this.TipotextBox.TabIndex = 28;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::LibrosBiblicos.Properties.Resources.icons8_Delete_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(527, 385);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 57);
            this.Eliminarbutton.TabIndex = 24;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::LibrosBiblicos.Properties.Resources.icons8_Save_as_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(403, 385);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 57);
            this.Guardarbutton.TabIndex = 23;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::LibrosBiblicos.Properties.Resources.icons8_Add_File_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(270, 385);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 57);
            this.Nuevobutton.TabIndex = 22;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::LibrosBiblicos.Properties.Resources.icons8_Search_Property_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(527, 31);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 50);
            this.Buscarbutton.TabIndex = 21;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // rLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(610, 444);
            this.Controls.Add(this.TipotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.SiglastextBox);
            this.Controls.Add(this.DescripcionrichTextBox);
            this.Controls.Add(this.LibroIdnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(626, 483);
            this.MinimumSize = new System.Drawing.Size(626, 483);
            this.Name = "rLibros";
            this.Text = "Registro de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibroIdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TipotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox SiglastextBox;
        private System.Windows.Forms.RichTextBox DescripcionrichTextBox;
        private System.Windows.Forms.NumericUpDown LibroIdnumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}