
namespace Gretas_Cake
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGestionarPMateriaPrima = new System.Windows.Forms.Button();
            this.btnGestionarPTerminados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Inventario  Sistema Gretta´s Cake";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(591, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione uno de los dos botones para ejecutar una acción";
            // 
            // btnGestionarPMateriaPrima
            // 
            this.btnGestionarPMateriaPrima.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPMateriaPrima.Location = new System.Drawing.Point(12, 193);
            this.btnGestionarPMateriaPrima.Name = "btnGestionarPMateriaPrima";
            this.btnGestionarPMateriaPrima.Size = new System.Drawing.Size(379, 89);
            this.btnGestionarPMateriaPrima.TabIndex = 2;
            this.btnGestionarPMateriaPrima.Text = "Gestionar Productos Materia Prima";
            this.btnGestionarPMateriaPrima.UseVisualStyleBackColor = true;
            this.btnGestionarPMateriaPrima.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGestionarPTerminados
            // 
            this.btnGestionarPTerminados.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPTerminados.Location = new System.Drawing.Point(416, 193);
            this.btnGestionarPTerminados.Name = "btnGestionarPTerminados";
            this.btnGestionarPTerminados.Size = new System.Drawing.Size(353, 89);
            this.btnGestionarPTerminados.TabIndex = 3;
            this.btnGestionarPTerminados.Text = "Gestionar Productos Terminados";
            this.btnGestionarPTerminados.UseVisualStyleBackColor = true;
            this.btnGestionarPTerminados.Click += new System.EventHandler(this.btnGestionarPTerminados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestionarPTerminados);
            this.Controls.Add(this.btnGestionarPMateriaPrima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGestionarPMateriaPrima;
        private System.Windows.Forms.Button btnGestionarPTerminados;
    }
}

