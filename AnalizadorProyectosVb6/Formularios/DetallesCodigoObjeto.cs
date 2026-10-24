using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorProyectosVb6.Formularios
{
    public partial class DetallesCodigoObjeto : Form
    {
        public DetallesCodigoObjeto()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            /// txtDefinicionControles txtInformacionAdicional txtCodigoFuente
            string definicionControles = string.Empty;
            string informacionAdicional = string.Empty;
            string codigoFuente = string.Empty;

            // por el momento es código de ejemplo, luego se reemplazará con la lógica para obtener los datos reales
            definicionControles = "Nombre : frmIndicadorAvance\r\nTipo   : Form\r\nPropiedades afectadas:\r\n\tTop : 18\r\n\tLeft : 0\r\n\tCaption : Porcentaje de Avance";
            informacionAdicional = "Este objeto tiene las siguientes características\r\nCaracterística 1\r\nCaracterística 2\r\nCaracterística 3";

            codigoFuente = "Option Explicit\r\n";
            codigoFuente += "\r\n";
            codigoFuente += "Public Aceptado As Boolean\r\n";
            codigoFuente += "Public I        As Byte\r\n";
            codigoFuente += "\r\n";
            codigoFuente += "Public Sub MostrarMensaje(Mensaje As String)\r\n";
            codigoFuente += "    Dim strTexto As String\r\n";
            codigoFuente += "    \r\n";
            codigoFuente += "    strTexto = \"Estimad@ Usuari@:\" & vbCrLf & vbCrLf\r\n";
            codigoFuente += "    strTexto = strTexto & \"El presente documento es un documento de grabación irreversible \"\r\n";
            codigoFuente += "    strTexto = strTexto & \"por lo que debe asegurarse que efectivamente sus datos son correctos, \"\r\n";
            codigoFuente += "    strTexto = strTexto & \"porque una vez grabados ya nos los podrá modificar.\" & vbCrLf & vbCrLf\r\n";
            codigoFuente += "    strTexto = strTexto & \"¿Está completamente seguro de grabar sus datos?\" & vbCrLf & vbCrLf\r\n";
            codigoFuente += "    strTexto = strTexto & \"Aviso \" & CStr(I) & \" de 3\"\r\n";
            codigoFuente += "    \r\n";
            codigoFuente += "    txtAviso.Text = strTexto\r\n";
            codigoFuente += "End Sub\r\n";
            codigoFuente += "Private Sub cmdNO_Click()\r\n";
            codigoFuente += "    Aceptado = False\r\n";
            codigoFuente += "    Me.Hide\r\n";
            codigoFuente += "End Sub\r\n";
            codigoFuente += "Private Sub cmdSI_Click()\r\n";
            codigoFuente += "    Aceptado = True\r\n";
            codigoFuente += "    Me.Hide\r\n";
            codigoFuente += "End Sub\r\n";

            txtDefinicionControles.Text = definicionControles;
            txtInformacionAdicional.Text = informacionAdicional;
            txtCodigoFuente.Text = codigoFuente;
        }

        private void DetallesCodigoObjeto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
