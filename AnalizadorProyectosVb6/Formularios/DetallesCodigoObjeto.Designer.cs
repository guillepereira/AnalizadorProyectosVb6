namespace AnalizadorProyectosVb6.Formularios
{
    partial class DetallesCodigoObjeto
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtCodigoFuente = new RichTextBox();
            txtInformacionAdicional = new RichTextBox();
            txtDefinicionControles = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtCodigoFuente, 0, 1);
            tableLayoutPanel1.Controls.Add(txtInformacionAdicional, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDefinicionControles, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(845, 554);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // txtCodigoFuente
            // 
            tableLayoutPanel1.SetColumnSpan(txtCodigoFuente, 2);
            txtCodigoFuente.Dock = DockStyle.Fill;
            txtCodigoFuente.Font = new Font("Courier New", 9F);
            txtCodigoFuente.Location = new Point(3, 153);
            txtCodigoFuente.Name = "txtCodigoFuente";
            txtCodigoFuente.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            txtCodigoFuente.Size = new Size(839, 398);
            txtCodigoFuente.TabIndex = 7;
            txtCodigoFuente.Text = "";
            txtCodigoFuente.WordWrap = false;
            // 
            // txtInformacionAdicional
            // 
            txtInformacionAdicional.Dock = DockStyle.Fill;
            txtInformacionAdicional.Font = new Font("Courier New", 9F);
            txtInformacionAdicional.Location = new Point(425, 3);
            txtInformacionAdicional.Name = "txtInformacionAdicional";
            txtInformacionAdicional.Size = new Size(417, 144);
            txtInformacionAdicional.TabIndex = 6;
            txtInformacionAdicional.Text = "";
            txtInformacionAdicional.WordWrap = false;
            // 
            // txtDefinicionControles
            // 
            txtDefinicionControles.Dock = DockStyle.Fill;
            txtDefinicionControles.Font = new Font("Courier New", 9F);
            txtDefinicionControles.Location = new Point(3, 3);
            txtDefinicionControles.Name = "txtDefinicionControles";
            txtDefinicionControles.Size = new Size(416, 144);
            txtDefinicionControles.TabIndex = 5;
            txtDefinicionControles.Text = "";
            txtDefinicionControles.WordWrap = false;
            // 
            // DetallesCodigoObjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 554);
            Controls.Add(tableLayoutPanel1);
            Name = "DetallesCodigoObjeto";
            Text = "ProyectoX - frmFormaInicial (Form) [50 líneas]";
            Load += DetallesCodigoObjeto_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox txtDefinicionControles;
        private RichTextBox txtInformacionAdicional;
        private RichTextBox txtCodigoFuente;
    }
}