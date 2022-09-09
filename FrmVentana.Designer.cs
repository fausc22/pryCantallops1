
namespace pryCantallops1
{
    partial class FrmVentana
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
            this.BtnMegusta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LblPregunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMegusta
            // 
            this.BtnMegusta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMegusta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnMegusta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMegusta.Location = new System.Drawing.Point(26, 97);
            this.BtnMegusta.Name = "BtnMegusta";
            this.BtnMegusta.Size = new System.Drawing.Size(303, 236);
            this.BtnMegusta.TabIndex = 0;
            this.BtnMegusta.Text = "Me gusta";
            this.BtnMegusta.UseVisualStyleBackColor = false;
            this.BtnMegusta.Click += new System.EventHandler(this.BtnMegusta_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(431, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 236);
            this.button2.TabIndex = 1;
            this.button2.Text = "No me gusta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblPregunta
            // 
            this.LblPregunta.AutoSize = true;
            this.LblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPregunta.Location = new System.Drawing.Point(170, 42);
            this.LblPregunta.Name = "LblPregunta";
            this.LblPregunta.Size = new System.Drawing.Size(424, 31);
            this.LblPregunta.TabIndex = 2;
            this.LblPregunta.Text = "¿Que le parece nuestro producto?";
            // 
            // FrmVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblPregunta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnMegusta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentana";
            this.Text = "Quiero saber tu opinion...";
            this.Load += new System.EventHandler(this.FrmVentana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMegusta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblPregunta;
    }
}

