
namespace Gretas_Cake
{
    partial class ConsultarRegistroMateriaPrima
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFechaHoraEntrada = new System.Windows.Forms.TextBox();
            this.btnConsultarRegistro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Nombre y Fecha Hora de Entrada Para consultar el registro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha-Hora de Entrada: ";
            // 
            // tbxFechaHoraEntrada
            // 
            this.tbxFechaHoraEntrada.Location = new System.Drawing.Point(257, 128);
            this.tbxFechaHoraEntrada.Name = "tbxFechaHoraEntrada";
            this.tbxFechaHoraEntrada.Size = new System.Drawing.Size(253, 20);
            this.tbxFechaHoraEntrada.TabIndex = 4;
            // 
            // btnConsultarRegistro
            // 
            this.btnConsultarRegistro.Enabled = false;
            this.btnConsultarRegistro.Location = new System.Drawing.Point(101, 248);
            this.btnConsultarRegistro.Name = "btnConsultarRegistro";
            this.btnConsultarRegistro.Size = new System.Drawing.Size(241, 48);
            this.btnConsultarRegistro.TabIndex = 5;
            this.btnConsultarRegistro.Text = "Consultar Registro Materia Prima";
            this.btnConsultarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(422, 248);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 48);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ConsultarRegistroMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultarRegistro);
            this.Controls.Add(this.tbxFechaHoraEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarRegistroMateriaPrima";
            this.Text = "Consultar Registro Materia Prima";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFechaHoraEntrada;
        private System.Windows.Forms.Button btnConsultarRegistro;
        private System.Windows.Forms.Button btnCancelar;
    }
}