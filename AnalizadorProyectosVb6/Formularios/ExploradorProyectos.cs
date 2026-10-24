namespace AnalizadorProyectosVb6
{
    public partial class ExploradorProyectos : Form
    {
        private TreeNode rootNode;

        public ExploradorProyectos()
        {
            InitializeComponent();
        }

        private void CargarDatosAlTreeView()
        {
            // Agrega unos nodos y sub nodos de ejemplo al TreeView
            rootNode = new TreeNode("Conjunto de Proyectos (1 proyecto de 1)") { ImageIndex = 0, SelectedImageIndex = 0 };
            trvEstructura.Nodes.Add(rootNode);

            TreeNode projectNode = new TreeNode("NombreProyecto (Nombre Físico.vbp)") { ImageIndex = 0, SelectedImageIndex = 0 };

            TreeNode node1 = new TreeNode("Forms") { ImageIndex = 1, SelectedImageIndex = 1 };
            TreeNode node2 = new TreeNode("Modules") { ImageIndex = 1, SelectedImageIndex = 1 };
            TreeNode node3 = new TreeNode("Class Modules") { ImageIndex = 1, SelectedImageIndex = 1 };
            TreeNode node4 = new TreeNode("User Controls") { ImageIndex = 1, SelectedImageIndex = 1 };
            TreeNode node5 = new TreeNode("References") { ImageIndex = 1, SelectedImageIndex = 1 };
            TreeNode node6 = new TreeNode("Objetos") { ImageIndex = 1, SelectedImageIndex = 1 };
            TreeNode node7 = new TreeNode("Additional Information") { ImageIndex = 1, SelectedImageIndex = 1 };

            projectNode.Nodes.Add(node1);
            projectNode.Nodes.Add(node2);
            projectNode.Nodes.Add(node3);
            projectNode.Nodes.Add(node4);
            projectNode.Nodes.Add(node5);
            projectNode.Nodes.Add(node6);
            projectNode.Nodes.Add(node7);
            rootNode.Nodes.Add(projectNode);

            // Agrega sub nodos de ejemplo a los nodos principales
            node1.Nodes.Add(new TreeNode("frmForm1 (Form1.frm)") { ImageIndex = 3, SelectedImageIndex = 3 });
            node1.Nodes.Add(new TreeNode("frmForm2 (Form2.frm)") { ImageIndex = 3, SelectedImageIndex = 3 });
            node2.Nodes.Add(new TreeNode("mdlModule1 (Module1.bas)") { ImageIndex = 4, SelectedImageIndex = 4 });
            node2.Nodes.Add(new TreeNode("mdlModule2 (Module2.bas)") { ImageIndex = 4, SelectedImageIndex = 4 });
            node3.Nodes.Add(new TreeNode("clsClass1 (Class1.cls)") { ImageIndex = 5, SelectedImageIndex = 5 });
            node3.Nodes.Add(new TreeNode("clsClass2 (Class2.cls)") { ImageIndex = 5, SelectedImageIndex = 5 });
            node4.Nodes.Add(new TreeNode("ctlUserControl1 (UserControl1.vb)") { ImageIndex = 6, SelectedImageIndex = 6 });
            node4.Nodes.Add(new TreeNode("ctlUserControl2 (UserControl2.vb)") { ImageIndex = 6, SelectedImageIndex = 6 });
            node5.Nodes.Add(new TreeNode("Descripción Reference1") { ImageIndex = 7, SelectedImageIndex = 7 });
            node5.Nodes.Add(new TreeNode("Descripción Reference2") { ImageIndex = 7, SelectedImageIndex = 7 });
            node6.Nodes.Add(new TreeNode("Descripción Object1") { ImageIndex = 8, SelectedImageIndex = 8 });
            node6.Nodes.Add(new TreeNode("Descripción Object2") { ImageIndex = 8, SelectedImageIndex = 8 });
            node7.Nodes.Add(new TreeNode("AdditionalInfo1.txt") { ImageIndex = 9, SelectedImageIndex = 9 });
            node7.Nodes.Add(new TreeNode("AdditionalInfo2.txt") { ImageIndex = 9, SelectedImageIndex = 9 });

            // Expande todos los nodos del TreeView para mostrar la estructura completa
            trvEstructura.ExpandAll();
        }

        private void FormularioInicial_Load(object sender, EventArgs e)
        {
            CargarDatosAlTreeView();
        }

        private void trvEstructura_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // Ignorar si es el nodo raíz
            if (e.Node != rootNode)
            {
                e.Node.ImageIndex = 2; // FolderAbierto.png
                e.Node.SelectedImageIndex = 2;
            }
        }

        private void trvEstructura_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node != rootNode)
            {
                e.Node.ImageIndex = 1; // FolderCerrado.png
                e.Node.SelectedImageIndex = 1;
            }
        }

        private void tsbExpander_Click(object sender, EventArgs e)
        {
            trvEstructura.ExpandAll();
        }

        private void tsbContraer_Click(object sender, EventArgs e)
        {
            trvEstructura.CollapseAll();
        }
    }
}
