
namespace Gretas_Cake
{
    partial class ConsultarRegistroProductoTerminado
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultarRegistro = new System.Windows.Forms.Button();
            this.tbxFechaHoraSalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(415, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 48);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultarRegistro
            // 
            this.btnConsultarRegistro.Enabled = false;
            this.btnConsultarRegistro.Location = new System.Drawing.Point(94, 263);
            this.btnConsultarRegistro.Name = "btnConsultarRegistro";
            this.btnConsultarRegistro.Size = new System.Drawing.Size(241, 48);
            this.btnConsultarRegistro.TabIndex = 12;
            this.btnConsultarRegistro.Text = "Consultar Registro Producto Terminado";
            this.btnConsultarRegistro.UseVisualStyleBackColor = true;
            this.btnConsultarRegistro.Click += new System.EventHandler(this.btnConsultarRegistro_Click);
            // 
            // tbxFechaHoraSalida
            // 
            this.tbxFechaHoraSalida.Location = new System.Drawing.Point(250, 143);
            this.tbxFechaHoraSalida.Name = "tbxFechaHoraSalida";
            this.tbxFechaHoraSalida.Size = new System.Drawing.Size(253, 20);
            this.tbxFechaHoraSalida.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha-Hora de Salida:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese Nombre y Fecha Hora de Entrada Para consultar el registro";
            // 
            // ConsultarRegistroProductoTerminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultarRegistro);
            this.Controls.Add(this.tbxFechaHoraSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarRegistroProductoTerminado";
            this.Text = "Consultar Registro Producto Terminado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultarRegistro;
        private System.Windows.Forms.TextBox tbxFechaHoraSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}