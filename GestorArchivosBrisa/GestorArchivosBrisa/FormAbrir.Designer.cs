namespace GestorArchivosBrisa
{
    partial class FormAbrir
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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            crearArchivoToolStripMenuItem = new ToolStripMenuItem();
            crearCarpetaToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 450);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { crearArchivoToolStripMenuItem, crearCarpetaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // crearArchivoToolStripMenuItem
            // 
            crearArchivoToolStripMenuItem.Name = "crearArchivoToolStripMenuItem";
            crearArchivoToolStripMenuItem.Size = new Size(180, 22);
            crearArchivoToolStripMenuItem.Text = "Crear Archivo";
            // 
            // crearCarpetaToolStripMenuItem
            // 
            crearCarpetaToolStripMenuItem.Name = "crearCarpetaToolStripMenuItem";
            crearCarpetaToolStripMenuItem.Size = new Size(180, 22);
            crearCarpetaToolStripMenuItem.Text = "Crear Carpeta";
            crearCarpetaToolStripMenuItem.Click += crearCarpetaToolStripMenuItem_Click;
            // 
            // FormAbrir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "FormAbrir";
            Text = "FormAbrir";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem crearArchivoToolStripMenuItem;
        private ToolStripMenuItem crearCarpetaToolStripMenuItem;
    }
}