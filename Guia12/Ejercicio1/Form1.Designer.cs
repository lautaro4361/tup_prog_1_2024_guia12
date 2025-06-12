namespace guia_12
{
    partial class Form1
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
            btnSolicitar = new Button();
            label1 = new Label();
            lbMostrarValor = new Label();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(244, 63);
            btnSolicitar.Margin = new Padding(4, 4, 4, 4);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(163, 32);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "MostrarValor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 1;
            label1.Text = "Resumen";
            // 
            // lbMostrarValor
            // 
            lbMostrarValor.BackColor = SystemColors.ActiveCaption;
            lbMostrarValor.Location = new Point(244, 149);
            lbMostrarValor.Margin = new Padding(4, 0, 4, 0);
            lbMostrarValor.Name = "lbMostrarValor";
            lbMostrarValor.Size = new Size(150, 21);
            lbMostrarValor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 263);
            Controls.Add(lbMostrarValor);
            Controls.Add(label1);
            Controls.Add(btnSolicitar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Label label1;
        private Label lbMostrarValor;
    }
}
