
namespace Interfaces
{
    partial class frmCombos
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
            this.btnVisualizarCombos = new System.Windows.Forms.Button();
            this.btnRegistrarCosto = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnCrearCombo = new System.Windows.Forms.Button();
            this.grbSeleccionProductos = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.grbCombo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombreCombo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbSeleccionProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grbCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizarCombos
            // 
            this.btnVisualizarCombos.Enabled = false;
            this.btnVisualizarCombos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarCombos.Location = new System.Drawing.Point(224, 571);
            this.btnVisualizarCombos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizarCombos.Name = "btnVisualizarCombos";
            this.btnVisualizarCombos.Size = new System.Drawing.Size(227, 54);
            this.btnVisualizarCombos.TabIndex = 16;
            this.btnVisualizarCombos.Text = "Visualizar Combos";
            this.btnVisualizarCombos.UseVisualStyleBackColor = true;
            this.btnVisualizarCombos.Click += new System.EventHandler(this.btnVisualizarCombos_Click);
            // 
            // btnRegistrarCosto
            // 
            this.btnRegistrarCosto.Enabled = false;
            this.btnRegistrarCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCosto.Location = new System.Drawing.Point(517, 486);
            this.btnRegistrarCosto.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarCosto.Name = "btnRegistrarCosto";
            this.btnRegistrarCosto.Size = new System.Drawing.Size(121, 39);
            this.btnRegistrarCosto.TabIndex = 15;
            this.btnRegistrarCosto.Text = "Registrar";
            this.btnRegistrarCosto.UseVisualStyleBackColor = true;
            this.btnRegistrarCosto.Click += new System.EventHandler(this.btnRegistrarCosto_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(53, 494);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(216, 20);
            this.lblCosto.TabIndex = 14;
            this.lblCosto.Text = "Ingrese el costo del combo: $";
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(360, 490);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(133, 26);
            this.txtCosto.TabIndex = 13;
            // 
            // btnCrearCombo
            // 
            this.btnCrearCombo.Enabled = false;
            this.btnCrearCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCombo.Location = new System.Drawing.Point(261, 384);
            this.btnCrearCombo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCombo.Name = "btnCrearCombo";
            this.btnCrearCombo.Size = new System.Drawing.Size(149, 50);
            this.btnCrearCombo.TabIndex = 12;
            this.btnCrearCombo.Text = "Crear Combo";
            this.btnCrearCombo.UseVisualStyleBackColor = true;
            this.btnCrearCombo.Click += new System.EventHandler(this.btnCrearCombo_Click);
            // 
            // grbSeleccionProductos
            // 
            this.grbSeleccionProductos.Controls.Add(this.nudCantidad);
            this.grbSeleccionProductos.Controls.Add(this.lblCantidad);
            this.grbSeleccionProductos.Controls.Add(this.btnAgregar);
            this.grbSeleccionProductos.Controls.Add(this.cmbProductos);
            this.grbSeleccionProductos.Enabled = false;
            this.grbSeleccionProductos.Location = new System.Drawing.Point(17, 155);
            this.grbSeleccionProductos.Margin = new System.Windows.Forms.Padding(4);
            this.grbSeleccionProductos.Name = "grbSeleccionProductos";
            this.grbSeleccionProductos.Padding = new System.Windows.Forms.Padding(4);
            this.grbSeleccionProductos.Size = new System.Drawing.Size(660, 203);
            this.grbSeleccionProductos.TabIndex = 11;
            this.grbSeleccionProductos.TabStop = false;
            this.grbSeleccionProductos.Text = "Seleccione productos";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(192, 123);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(147, 26);
            this.nudCantidad.TabIndex = 3;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(72, 126);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(483, 89);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 39);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Items.AddRange(new object[] {
            "Palomitas Ch",
            "Palomitas Md",
            "Palomitas Gd",
            "Ice",
            "Refresco Md",
            "Refresco Gd",
            "Nachos",
            "Hot Dog",
            "M&M´s",
            "Corneto",
            "Papas",
            "Helado Micha \"Holanda\" ",
            "Magnum",
            "Crepa",
            "",
            "",
            ""});
            this.cmbProductos.Location = new System.Drawing.Point(77, 52);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(300, 28);
            this.cmbProductos.TabIndex = 0;
            // 
            // grbCombo
            // 
            this.grbCombo.Controls.Add(this.label1);
            this.grbCombo.Controls.Add(this.btnRegistrar);
            this.grbCombo.Controls.Add(this.txtNombreCombo);
            this.grbCombo.Location = new System.Drawing.Point(17, 25);
            this.grbCombo.Margin = new System.Windows.Forms.Padding(4);
            this.grbCombo.Name = "grbCombo";
            this.grbCombo.Padding = new System.Windows.Forms.Padding(4);
            this.grbCombo.Size = new System.Drawing.Size(660, 122);
            this.grbCombo.TabIndex = 10;
            this.grbCombo.TabStop = false;
            this.grbCombo.Text = "Combo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del combo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(483, 44);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(139, 46);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombreCombo
            // 
            this.txtNombreCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCombo.Location = new System.Drawing.Point(227, 50);
            this.txtNombreCombo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCombo.Name = "txtNombreCombo";
            this.txtNombreCombo.Size = new System.Drawing.Size(225, 26);
            this.txtNombreCombo.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 676);
            this.Controls.Add(this.btnVisualizarCombos);
            this.Controls.Add(this.btnRegistrarCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.btnCrearCombo);
            this.Controls.Add(this.grbSeleccionProductos);
            this.Controls.Add(this.grbCombo);
            this.Name = "frmCombos";
            this.Text = "Combos Cine";
            this.grbSeleccionProductos.ResumeLayout(false);
            this.grbSeleccionProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grbCombo.ResumeLayout(false);
            this.grbCombo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizarCombos;
        private System.Windows.Forms.Button btnRegistrarCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCrearCombo;
        private System.Windows.Forms.GroupBox grbSeleccionProductos;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.GroupBox grbCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombreCombo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}