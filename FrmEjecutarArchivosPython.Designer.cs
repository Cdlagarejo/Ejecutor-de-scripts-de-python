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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjecutarArchivosPython));
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
            resources.ApplyResources(this.BtnEjecutar, "BtnEjecutar");
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // BtnSeleccionarArchivos
            // 
            resources.ApplyResources(this.BtnSeleccionarArchivos, "BtnSeleccionarArchivos");
            this.BtnSeleccionarArchivos.Name = "BtnSeleccionarArchivos";
            this.BtnSeleccionarArchivos.UseVisualStyleBackColor = true;
            this.BtnSeleccionarArchivos.Click += new System.EventHandler(this.BtnSeleccionarArchivos_Click);
            // 
            // LblRuta
            // 
            resources.ApplyResources(this.LblRuta, "LblRuta");
            this.LblRuta.Name = "LblRuta";
            // 
            // txtRutas
            // 
            resources.ApplyResources(this.txtRutas, "txtRutas");
            this.txtRutas.Name = "txtRutas";
            // 
            // LblVersionPython
            // 
            resources.ApplyResources(this.LblVersionPython, "LblVersionPython");
            this.LblVersionPython.Name = "LblVersionPython";
            // 
            // CbxVersionesPython
            // 
            this.CbxVersionesPython.FormattingEnabled = true;
            resources.ApplyResources(this.CbxVersionesPython, "CbxVersionesPython");
            this.CbxVersionesPython.Name = "CbxVersionesPython";
            // 
            // FrmEjecutarArchivosPython
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbxVersionesPython);
            this.Controls.Add(this.LblVersionPython);
            this.Controls.Add(this.txtRutas);
            this.Controls.Add(this.LblRuta);
            this.Controls.Add(this.BtnSeleccionarArchivos);
            this.Controls.Add(this.BtnEjecutar);
            this.Name = "FrmEjecutarArchivosPython";
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