namespace CambioDivisaBrisa
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
            lblImporte = new Label();
            lblDe = new Label();
            lblA = new Label();
            tBoxImporte = new TextBox();
            comboDe = new ComboBox();
            comboA = new ComboBox();
            btnFlecha = new Button();
            btnCambiar = new Button();
            lblHistorico = new Label();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(67, 38);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(49, 15);
            lblImporte.TabIndex = 0;
            lblImporte.Text = "Importe";
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Location = new Point(213, 38);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(24, 15);
            lblDe.TabIndex = 1;
            lblDe.Text = "De:";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(530, 38);
            lblA.Name = "lblA";
            lblA.Size = new Size(16, 15);
            lblA.TabIndex = 2;
            lblA.Text = "a:";
            // 
            // tBoxImporte
            // 
            tBoxImporte.Location = new Point(40, 79);
            tBoxImporte.Name = "tBoxImporte";
            tBoxImporte.Size = new Size(100, 23);
            tBoxImporte.TabIndex = 3;
            // 
            // comboDe
            // 
            comboDe.FormattingEnabled = true;
            comboDe.Location = new Point(213, 79);
            comboDe.Name = "comboDe";
            comboDe.Size = new Size(121, 23);
            comboDe.TabIndex = 4;
            // 
            // comboA
            // 
            comboA.FormattingEnabled = true;
            comboA.Location = new Point(530, 79);
            comboA.Name = "comboA";
            comboA.Size = new Size(121, 23);
            comboA.TabIndex = 5;
            // 
            // btnFlecha
            // 
            btnFlecha.Image = Properties.Resources.Flecha;
            btnFlecha.Location = new Point(391, 70);
            btnFlecha.Name = "btnFlecha";
            btnFlecha.Size = new Size(82, 38);
            btnFlecha.TabIndex = 6;
            btnFlecha.UseVisualStyleBackColor = true;
            // 
            // btnCambiar
            // 
            btnCambiar.Location = new Point(549, 160);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(102, 49);
            btnCambiar.TabIndex = 7;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            // 
            // lblHistorico
            // 
            lblHistorico.AutoSize = true;
            lblHistorico.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorico.Location = new Point(67, 210);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(160, 33);
            lblHistorico.TabIndex = 8;
            lblHistorico.Text = "Histórico";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(67, 261);
            listBox.Name = "listBox";
            listBox.Size = new Size(328, 124);
            listBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox);
            Controls.Add(lblHistorico);
            Controls.Add(btnCambiar);
            Controls.Add(btnFlecha);
            Controls.Add(comboA);
            Controls.Add(comboDe);
            Controls.Add(tBoxImporte);
            Controls.Add(lblA);
            Controls.Add(lblDe);
            Controls.Add(lblImporte);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImporte;
        private Label lblDe;
        private Label lblA;
        private TextBox tBoxImporte;
        private ComboBox comboDe;
        private ComboBox comboA;
        private Button btnFlecha;
        private Button btnCambiar;
        private Label lblHistorico;
        private ListBox listBox;
    }
}