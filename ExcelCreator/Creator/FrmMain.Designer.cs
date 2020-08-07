namespace ExcelCreator.Creator
{
    partial class FrmMain
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
            this.BtnGenerarDocumento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenerarDocumento
            // 
            this.BtnGenerarDocumento.Location = new System.Drawing.Point(109, 115);
            this.BtnGenerarDocumento.Name = "BtnGenerarDocumento";
            this.BtnGenerarDocumento.Size = new System.Drawing.Size(102, 39);
            this.BtnGenerarDocumento.TabIndex = 0;
            this.BtnGenerarDocumento.Text = "Generar Documento";
            this.BtnGenerarDocumento.UseVisualStyleBackColor = true;
            this.BtnGenerarDocumento.Click += new System.EventHandler(this.BtnGenerarDocumento_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 179);
            this.Controls.Add(this.BtnGenerarDocumento);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerarDocumento;
    }
}