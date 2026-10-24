namespace AnalizadorProyectosVb6
{
    partial class ExploradorProyectos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExploradorProyectos));
            trvEstructura = new TreeView();
            imgIconos = new ImageList(components);
            tstBotones = new ToolStrip();
            tsbExpander = new ToolStripButton();
            tsbContraer = new ToolStripButton();
            imgBotones = new ImageList(components);
            tstBotones.SuspendLayout();
            SuspendLayout();
            // 
            // trvEstructura
            // 
            trvEstructura.ImageIndex = 0;
            trvEstructura.ImageList = imgIconos;
            trvEstructura.Location = new Point(0, 28);
            trvEstructura.Name = "trvEstructura";
            trvEstructura.SelectedImageIndex = 0;
            trvEstructura.Size = new Size(399, 791);
            trvEstructura.TabIndex = 0;
            trvEstructura.BeforeCollapse += trvEstructura_BeforeCollapse;
            trvEstructura.BeforeExpand += trvEstructura_BeforeExpand;
            // 
            // imgIconos
            // 
            imgIconos.ColorDepth = ColorDepth.Depth32Bit;
            imgIconos.ImageStream = (ImageListStreamer)resources.GetObject("imgIconos.ImageStream");
            imgIconos.TransparentColor = Color.Transparent;
            imgIconos.Images.SetKeyName(0, "Proyecto.png");
            imgIconos.Images.SetKeyName(1, "FolderCerrado.png");
            imgIconos.Images.SetKeyName(2, "FolderAbierto.png");
            imgIconos.Images.SetKeyName(3, "Formularios.png");
            imgIconos.Images.SetKeyName(4, "Modules.png");
            imgIconos.Images.SetKeyName(5, "ClassModule.png");
            imgIconos.Images.SetKeyName(6, "UserControl.png");
            imgIconos.Images.SetKeyName(7, "References.png");
            imgIconos.Images.SetKeyName(8, "Objects.png");
            imgIconos.Images.SetKeyName(9, "AdditionalInfo.png");
            // 
            // tstBotones
            // 
            tstBotones.Items.AddRange(new ToolStripItem[] { tsbExpander, tsbContraer });
            tstBotones.Location = new Point(0, 0);
            tstBotones.Name = "tstBotones";
            tstBotones.Size = new Size(399, 25);
            tstBotones.TabIndex = 1;
            tstBotones.Text = "toolStrip1";
            // 
            // tsbExpander
            // 
            tsbExpander.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbExpander.Image = (Image)resources.GetObject("tsbExpander.Image");
            tsbExpander.ImageTransparentColor = Color.Magenta;
            tsbExpander.Name = "tsbExpander";
            tsbExpander.Size = new Size(23, 22);
            tsbExpander.Text = "toolStripButton1";
            tsbExpander.Click += tsbExpander_Click;
            // 
            // tsbContraer
            // 
            tsbContraer.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbContraer.Image = (Image)resources.GetObject("tsbContraer.Image");
            tsbContraer.ImageTransparentColor = Color.Magenta;
            tsbContraer.Name = "tsbContraer";
            tsbContraer.Size = new Size(23, 22);
            tsbContraer.Text = "toolStripButton2";
            tsbContraer.Click += tsbContraer_Click;
            // 
            // imgBotones
            // 
            imgBotones.ColorDepth = ColorDepth.Depth32Bit;
            imgBotones.ImageStream = (ImageListStreamer)resources.GetObject("imgBotones.ImageStream");
            imgBotones.TransparentColor = Color.Transparent;
            imgBotones.Images.SetKeyName(0, "Expander.png");
            imgBotones.Images.SetKeyName(1, "Contraer.png");
            // 
            // FormularioInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 819);
            Controls.Add(tstBotones);
            Controls.Add(trvEstructura);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioInicial";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Explorador de Proyectos";
            Load += FormularioInicial_Load;
            tstBotones.ResumeLayout(false);
            tstBotones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView trvEstructura;
        private ImageList imgIconos;
        private ToolStrip tstBotones;
        private ToolStripButton tsbExpander;
        private ToolStripButton tsbContraer;
        private ImageList imgBotones;
    }
}
