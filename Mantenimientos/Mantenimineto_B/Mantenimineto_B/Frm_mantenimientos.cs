using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Navegador;
using Capa_Controlador_Navegador;

namespace Mantenimineto_B
{
    public partial class Frm_mantenimientos : Form
    {
        public Frm_mantenimientos()
        {
            InitializeComponent();

            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config =
                new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
                {
                    Ancho = 1100,
                    Alto = 200,
                    PosX = 10,
                    PosY = 300,
                    ColorFondo = Color.AliceBlue,
                    TipoScrollBars = ScrollBars.Both,
                    Nombre = " productos en bodegas"
                };

            string[] columnas = {
                "productos",
                "codigo_producto",
                "nombre_producto",
                "codigo_linea",
                "codigo_marca",
               "exitencia_producto",
               "estatus_producto"
            };

            string[] sEtiquetas = {
               "codigo producto",
               "nombre",
               "linea",
               "marca",
               "existencias",
               "estatus"

            };

            int id_aplicacion = 9000;
            int id_Modulo = 44;

            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }
    }
}
