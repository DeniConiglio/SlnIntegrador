namespace WindowsPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridListaMedPac = new System.Windows.Forms.DataGridView();
            this.lstMedicosClinicos = new System.Windows.Forms.ListBox();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.btnMostrarMedicos = new System.Windows.Forms.Button();
            this.btnMostrarPacientes = new System.Windows.Forms.Button();
            this.btnMostrarHabitaciones = new System.Windows.Forms.Button();
            this.btnClinicos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaMedPac)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListaMedPac
            // 
            this.gridListaMedPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListaMedPac.Location = new System.Drawing.Point(33, 12);
            this.gridListaMedPac.Name = "gridListaMedPac";
            this.gridListaMedPac.RowHeadersWidth = 51;
            this.gridListaMedPac.RowTemplate.Height = 24;
            this.gridListaMedPac.Size = new System.Drawing.Size(664, 209);
            this.gridListaMedPac.TabIndex = 0;
            // 
            // lstMedicosClinicos
            // 
            this.lstMedicosClinicos.FormattingEnabled = true;
            this.lstMedicosClinicos.ItemHeight = 16;
            this.lstMedicosClinicos.Location = new System.Drawing.Point(33, 229);
            this.lstMedicosClinicos.Name = "lstMedicosClinicos";
            this.lstMedicosClinicos.Size = new System.Drawing.Size(251, 180);
            this.lstMedicosClinicos.TabIndex = 1;
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.ItemHeight = 16;
            this.lstHabitaciones.Location = new System.Drawing.Point(446, 229);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(251, 180);
            this.lstHabitaciones.TabIndex = 2;
            // 
            // btnMostrarMedicos
            // 
            this.btnMostrarMedicos.Location = new System.Drawing.Point(297, 227);
            this.btnMostrarMedicos.Name = "btnMostrarMedicos";
            this.btnMostrarMedicos.Size = new System.Drawing.Size(143, 38);
            this.btnMostrarMedicos.TabIndex = 3;
            this.btnMostrarMedicos.Text = "Mostrar Medicos";
            this.btnMostrarMedicos.UseVisualStyleBackColor = true;
            this.btnMostrarMedicos.Click += new System.EventHandler(this.btnMostrarMedicos_Click);
            // 
            // btnMostrarPacientes
            // 
            this.btnMostrarPacientes.Location = new System.Drawing.Point(297, 271);
            this.btnMostrarPacientes.Name = "btnMostrarPacientes";
            this.btnMostrarPacientes.Size = new System.Drawing.Size(143, 38);
            this.btnMostrarPacientes.TabIndex = 4;
            this.btnMostrarPacientes.Text = "Mostrar Pacientes";
            this.btnMostrarPacientes.UseVisualStyleBackColor = true;
            this.btnMostrarPacientes.Click += new System.EventHandler(this.btnMostrarPacientes_Click);
            // 
            // btnMostrarHabitaciones
            // 
            this.btnMostrarHabitaciones.Location = new System.Drawing.Point(297, 356);
            this.btnMostrarHabitaciones.Name = "btnMostrarHabitaciones";
            this.btnMostrarHabitaciones.Size = new System.Drawing.Size(143, 53);
            this.btnMostrarHabitaciones.TabIndex = 5;
            this.btnMostrarHabitaciones.Text = "Numero y Estado de Habitaciones";
            this.btnMostrarHabitaciones.UseVisualStyleBackColor = true;
            this.btnMostrarHabitaciones.Click += new System.EventHandler(this.btnMostrarHabitaciones_Click);
            // 
            // btnClinicos
            // 
            this.btnClinicos.Location = new System.Drawing.Point(297, 315);
            this.btnClinicos.Name = "btnClinicos";
            this.btnClinicos.Size = new System.Drawing.Size(143, 35);
            this.btnClinicos.TabIndex = 6;
            this.btnClinicos.Text = "Medicos Clinicos";
            this.btnClinicos.UseVisualStyleBackColor = true;
            this.btnClinicos.Click += new System.EventHandler(this.btnClinicos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.btnClinicos);
            this.Controls.Add(this.btnMostrarHabitaciones);
            this.Controls.Add(this.btnMostrarPacientes);
            this.Controls.Add(this.btnMostrarMedicos);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.lstMedicosClinicos);
            this.Controls.Add(this.gridListaMedPac);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridListaMedPac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridListaMedPac;
        private System.Windows.Forms.ListBox lstMedicosClinicos;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.Button btnMostrarMedicos;
        private System.Windows.Forms.Button btnMostrarPacientes;
        private System.Windows.Forms.Button btnMostrarHabitaciones;
        private System.Windows.Forms.Button btnClinicos;
    }
}

