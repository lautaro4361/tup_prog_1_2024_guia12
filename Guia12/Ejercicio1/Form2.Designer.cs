namespace guia_12
{
    partial class Form2
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
            btnAceptar = new Button();
            tbValor = new MaskedTextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(273, 141);
            btnAceptar.Margin = new Padding(4, 4, 4, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 32);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button3_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(188, 80);
            tbValor.Margin = new Padding(4, 4, 4, 4);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(127, 29);
            tbValor.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(147, 141);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 246);
            Controls.Add(btnAceptar);
            Controls.Add(tbValor);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        public MaskedTextBox tbValor;
    }
}