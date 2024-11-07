
namespace Presentacion
{
    partial class FormReporte
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgRetiros = new System.Windows.Forms.DataGridView();
            this.btnBuscarRetirosAFPHabitat = new System.Windows.Forms.Button();
            this.btnBuscarRetirosEmpleadosMayoresA30 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRetiros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(49, 286);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(176, 26);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgRetiros
            // 
            this.dgRetiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRetiros.Location = new System.Drawing.Point(287, 12);
            this.dgRetiros.Name = "dgRetiros";
            this.dgRetiros.RowTemplate.Height = 24;
            this.dgRetiros.Size = new System.Drawing.Size(501, 301);
            this.dgRetiros.TabIndex = 14;
            // 
            // btnBuscarRetirosAFPHabitat
            // 
            this.btnBuscarRetirosAFPHabitat.Location = new System.Drawing.Point(49, 12);
            this.btnBuscarRetirosAFPHabitat.Name = "btnBuscarRetirosAFPHabitat";
            this.btnBuscarRetirosAFPHabitat.Size = new System.Drawing.Size(176, 59);
            this.btnBuscarRetirosAFPHabitat.TabIndex = 16;
            this.btnBuscarRetirosAFPHabitat.Text = "Buscar Retiros gestionados por AFP Habitat";
            this.btnBuscarRetirosAFPHabitat.UseVisualStyleBackColor = true;
            this.btnBuscarRetirosAFPHabitat.Click += new System.EventHandler(this.btnBuscarRetirosAFPHabitat_Click);
            // 
            // btnBuscarRetirosEmpleadosMayoresA30
            // 
            this.btnBuscarRetirosEmpleadosMayoresA30.Location = new System.Drawing.Point(49, 77);
            this.btnBuscarRetirosEmpleadosMayoresA30.Name = "btnBuscarRetirosEmpleadosMayoresA30";
            this.btnBuscarRetirosEmpleadosMayoresA30.Size = new System.Drawing.Size(176, 59);
            this.btnBuscarRetirosEmpleadosMayoresA30.TabIndex = 18;
            this.btnBuscarRetirosEmpleadosMayoresA30.Text = "Buscar Retiros de Empleados mayores de 30 años";
            this.btnBuscarRetirosEmpleadosMayoresA30.UseVisualStyleBackColor = true;
            this.btnBuscarRetirosEmpleadosMayoresA30.Click += new System.EventHandler(this.btnBuscarRetirosEmpleadosMayoresA30_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.btnBuscarRetirosEmpleadosMayoresA30);
            this.Controls.Add(this.btnBuscarRetirosAFPHabitat);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgRetiros);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgRetiros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgRetiros;
        private System.Windows.Forms.Button btnBuscarRetirosAFPHabitat;
        private System.Windows.Forms.Button btnBuscarRetirosEmpleadosMayoresA30;
    }
}