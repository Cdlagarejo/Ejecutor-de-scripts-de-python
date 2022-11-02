namespace Ejecutor_de_scripts_de_python
{
    partial class FrmEjecutarArchivosPython
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.BtnSeleccionarArchivos = new System.Windows.Forms.Button();
            this.LblRuta = new System.Windows.Forms.Label();
            this.txtRutas = new System.Windows.Forms.TextBox();
            this.LblVersionPython = new System.Windows.Forms.Label();
            this.CbxVersionesPython = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Location = new System.Drawing.Point(317, 64);
            this.BtnEjecutar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(79, 23);
            this.BtnEjecutar.TabIndex = 0;
            this.BtnEjecutar.Text = "Ejecutar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // BtnSeleccionarArchivos
            // 
            this.BtnSeleccionarArchivos.Location = new System.Drawing.Point(317, 22);
            this.BtnSeleccionarArchivos.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSeleccionarArchivos.Name = "BtnSeleccionarArchivos";
            this.BtnSeleccionarArchivos.Size = new System.Drawing.Size(79, 24);
            this.BtnSeleccionarArchivos.TabIndex = 1;
            this.BtnSeleccionarArchivos.Text = "...";
            this.BtnSeleccionarArchivos.UseVisualStyleBackColor = true;
            this.BtnSeleccionarArchivos.Click += new System.EventHandler(this.BtnSeleccionarArchivos_Click);
            // 
            // LblRuta
            // 
            this.LblRuta.AutoSize = true;
            this.LblRuta.Location = new System.Drawing.Point(46, 26);
            this.LblRuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRuta.Name = "LblRuta";
            this.LblRuta.Size = new System.Drawing.Size(41, 15);
            this.LblRuta.TabIndex = 2;
            this.LblRuta.Text = "RUTAS";
            // 
            // txtRutas
            // 
            this.txtRutas.Enabled = false;
            this.txtRutas.Location = new System.Drawing.Point(91, 23);
            this.txtRutas.Margin = new System.Windows.Forms.Padding(2);
            this.txtRutas.Name = "txtRutas";
            this.txtRutas.Size = new System.Drawing.Size(216, 23);
            this.txtRutas.TabIndex = 3;
            // 
            // LblVersionPython
            // 
            this.LblVersionPython.AutoSize = true;
            this.LblVersionPython.Location = new System.Drawing.Point(46, 64);
            this.LblVersionPython.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblVersionPython.Name = "LblVersionPython";
            this.LblVersionPython.Size = new System.Drawing.Size(86, 15);
            this.LblVersionPython.TabIndex = 4;
            this.LblVersionPython.Text = "Version python";
            // 
            // CbxVersionesPython
            // 
            this.CbxVersionesPython.FormattingEnabled = true;
            this.CbxVersionesPython.Location = new System.Drawing.Point(156, 64);
            this.CbxVersionesPython.Margin = new System.Windows.Forms.Padding(2);
            this.CbxVersionesPython.Name = "CbxVersionesPython";
            this.CbxVersionesPython.Size = new System.Drawing.Size(128, 23);
            this.CbxVersionesPython.TabIndex = 5;
            // 
            // FrmEjecutarArchivosPython
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 121);
            this.Controls.Add(this.CbxVersionesPython);
            this.Controls.Add(this.LblVersionPython);
            this.Controls.Add(this.txtRutas);
            this.Controls.Add(this.LblRuta);
            this.Controls.Add(this.BtnSeleccionarArchivos);
            this.Controls.Add(this.BtnEjecutar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEjecutarArchivosPython";
            this.Text = "Ejecutar Archivos Python";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnEjecutar;
        private Button BtnSeleccionarArchivos;
        private Label LblRuta;
        private TextBox txtRutas;
        private Label LblVersionPython;
        private ComboBox CbxVersionesPython;
    }
}