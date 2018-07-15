namespace LibrosBiblicos.UI.Consulta
{
    partial class cLibros
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
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsultasdataGridView = new System.Windows.Forms.DataGridView();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(345, 80);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.HastadateTimePicker.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hasta";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(128, 81);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.DesdedateTimePicker.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Desde";
            // 
            // ConsultasdataGridView
            // 
            this.ConsultasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasdataGridView.Location = new System.Drawing.Point(94, 130);
            this.ConsultasdataGridView.Name = "ConsultasdataGridView";
            this.ConsultasdataGridView.Size = new System.Drawing.Size(351, 272);
            this.ConsultasdataGridView.TabIndex = 16;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(345, 27);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(100, 20);
            this.CriteriotextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Criterio";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "LibroId",
            "Fecha",
            "Descripcion",
            "Siglas",
            "Tipo",
            "Todo"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(128, 28);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtro";
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Image = global::LibrosBiblicos.Properties.Resources.icons8_Print_32;
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimirbutton.Location = new System.Drawing.Point(12, 356);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(66, 46);
            this.Imprimirbutton.TabIndex = 17;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::LibrosBiblicos.Properties.Resources.icons8_Search_Property_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(473, 26);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 51);
            this.Buscarbutton.TabIndex = 12;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.ConsultasdataGridView);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(571, 489);
            this.MinimumSize = new System.Drawing.Size(571, 489);
            this.Name = "cLibros";
            this.Text = "Consulta de Libros";
            this.Load += new System.EventHandler(this.cLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.DataGridView ConsultasdataGridView;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}