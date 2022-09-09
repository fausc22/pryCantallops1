
namespace pryCantallops1
{
    partial class FrmProductos
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
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.LstTipos = new System.Windows.Forms.ComboBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(93, 117);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(110, 26);
            this.LblProducto.TabIndex = 0;
            this.LblProducto.Text = "Productos";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(93, 189);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(53, 26);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo";
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(268, 123);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(146, 20);
            this.txtProductos.TabIndex = 2;
            // 
            // LstTipos
            // 
            this.LstTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LstTipos.FormattingEnabled = true;
            this.LstTipos.Items.AddRange(new object[] {
            "ALIMENTOS",
            "BEBIDAS",
            "GOLOSINAS"});
            this.LstTipos.Location = new System.Drawing.Point(268, 193);
            this.LstTipos.Name = "LstTipos";
            this.LstTipos.Size = new System.Drawing.Size(121, 21);
            this.LstTipos.TabIndex = 3;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(201, 300);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(117, 44);
            this.BtnRegistrar.TabIndex = 4;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(92, 20);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(324, 31);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "Seleccione sus productos";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 361);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.LstTipos);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblProducto);
            this.Name = "FrmProductos";
            this.Text = "Seleccione sus productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.ComboBox LstTipos;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label LblTitulo;
    }
}