namespace InteropTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtNota = new System.Windows.Forms.TextBox();
            this.PbW = new System.Windows.Forms.PictureBox();
            this.PbX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbX)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNota
            // 
            this.TxtNota.BackColor = System.Drawing.SystemColors.Info;
            this.TxtNota.Location = new System.Drawing.Point(12, 112);
            this.TxtNota.Multiline = true;
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(309, 336);
            this.TxtNota.TabIndex = 1;
            this.TxtNota.Text = "Hola Mundo!";
            // 
            // PbW
            // 
            this.PbW.Image = global::InteropTest.Properties.Resources.icons8_ms_word_80;
            this.PbW.Location = new System.Drawing.Point(195, 37);
            this.PbW.Name = "PbW";
            this.PbW.Size = new System.Drawing.Size(52, 52);
            this.PbW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbW.TabIndex = 2;
            this.PbW.TabStop = false;
            this.PbW.Click += new System.EventHandler(this.PbW_Click);
            // 
            // PbX
            // 
            this.PbX.Image = global::InteropTest.Properties.Resources.excel;
            this.PbX.Location = new System.Drawing.Point(271, 37);
            this.PbX.Name = "PbX";
            this.PbX.Size = new System.Drawing.Size(52, 52);
            this.PbX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbX.TabIndex = 0;
            this.PbX.TabStop = false;
            this.PbX.Click += new System.EventHandler(this.PbX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 463);
            this.Controls.Add(this.PbW);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.PbX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbX;
        private System.Windows.Forms.TextBox TxtNota;
        private System.Windows.Forms.PictureBox PbW;
    }
}

