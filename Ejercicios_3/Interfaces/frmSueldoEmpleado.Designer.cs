
namespace Interfaces
{
    partial class frmSueldoEmpleado
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
            this.lblDiasTrabajados = new System.Windows.Forms.Label();
            this.nudDiasTrabajados = new System.Windows.Forms.NumericUpDown();
            this.lblSueldoDiario = new System.Windows.Forms.Label();
            this.txtSueldoDiario = new System.Windows.Forms.TextBox();
            this.btnCalcularSueldo = new System.Windows.Forms.Button();
            this.lblResultadoSueldo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasTrabajados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiasTrabajados
            // 
            this.lblDiasTrabajados.AutoSize = true;
            this.lblDiasTrabajados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasTrabajados.Location = new System.Drawing.Point(41, 33);
            this.lblDiasTrabajados.Name = "lblDiasTrabajados";
            this.lblDiasTrabajados.Size = new System.Drawing.Size(124, 20);
            this.lblDiasTrabajados.TabIndex = 0;
            this.lblDiasTrabajados.Text = "Días trabajados:";
            // 
            // nudDiasTrabajados
            // 
            this.nudDiasTrabajados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiasTrabajados.Location = new System.Drawing.Point(171, 31);
            this.nudDiasTrabajados.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudDiasTrabajados.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiasTrabajados.Name = "nudDiasTrabajados";
            this.nudDiasTrabajados.Size = new System.Drawing.Size(84, 26);
            this.nudDiasTrabajados.TabIndex = 1;
            this.nudDiasTrabajados.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSueldoDiario
            // 
            this.lblSueldoDiario.AutoSize = true;
            this.lblSueldoDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoDiario.Location = new System.Drawing.Point(41, 73);
            this.lblSueldoDiario.Name = "lblSueldoDiario";
            this.lblSueldoDiario.Size = new System.Drawing.Size(105, 20);
            this.lblSueldoDiario.TabIndex = 2;
            this.lblSueldoDiario.Text = "Sueldo diario:";
            // 
            // txtSueldoDiario
            // 
            this.txtSueldoDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoDiario.Location = new System.Drawing.Point(171, 70);
            this.txtSueldoDiario.Name = "txtSueldoDiario";
            this.txtSueldoDiario.Size = new System.Drawing.Size(100, 26);
            this.txtSueldoDiario.TabIndex = 3;
            // 
            // btnCalcularSueldo
            // 
            this.btnCalcularSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSueldo.Location = new System.Drawing.Point(61, 122);
            this.btnCalcularSueldo.Name = "btnCalcularSueldo";
            this.btnCalcularSueldo.Size = new System.Drawing.Size(181, 31);
            this.btnCalcularSueldo.TabIndex = 4;
            this.btnCalcularSueldo.Text = "Calcular sueldo";
            this.btnCalcularSueldo.UseVisualStyleBackColor = true;
            this.btnCalcularSueldo.Click += new System.EventHandler(this.btnCalcularSueldo_Click);
            // 
            // lblResultadoSueldo
            // 
            this.lblResultadoSueldo.AutoSize = true;
            this.lblResultadoSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSueldo.Location = new System.Drawing.Point(27, 197);
            this.lblResultadoSueldo.Name = "lblResultadoSueldo";
            this.lblResultadoSueldo.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoSueldo.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSueldoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 279);
            this.Controls.Add(this.lblResultadoSueldo);
            this.Controls.Add(this.btnCalcularSueldo);
            this.Controls.Add(this.txtSueldoDiario);
            this.Controls.Add(this.lblSueldoDiario);
            this.Controls.Add(this.nudDiasTrabajados);
            this.Controls.Add(this.lblDiasTrabajados);
            this.Name = "frmSueldoEmpleado";
            this.Text = "Calcular sueldo del empleado";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasTrabajados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiasTrabajados;
        private System.Windows.Forms.NumericUpDown nudDiasTrabajados;
        private System.Windows.Forms.Label lblSueldoDiario;
        private System.Windows.Forms.TextBox txtSueldoDiario;
        private System.Windows.Forms.Button btnCalcularSueldo;
        private System.Windows.Forms.Label lblResultadoSueldo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}