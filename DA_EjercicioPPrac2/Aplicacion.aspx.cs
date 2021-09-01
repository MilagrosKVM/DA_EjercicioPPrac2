using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DA_EjercicioPPrac2
{
    public partial class Aplicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Seleccion.Items.Add(new ListItem("Seleccione un electrodoméstico","0"));
                Seleccion.Items.Add(new ListItem("Televisor","1"));
                Seleccion.Items.Add(new ListItem("Lavadora","2"));
                Seleccion.Items.Add(new ListItem("Reproductor Bluray","3"));
                Seleccion.Items.Add(new ListItem("Horno Microondas","4"));
                Seleccion.Items.Add(new ListItem("Licuadora","5"));
                Seleccion.Items.Add(new ListItem("Plancha","6"));
                Seleccion.Items.Add(new ListItem("Batidora","7"));
            }
        }
        protected void Confirmar_ServerClick(Object sender, EventArgs e)
        {
            ListItem elemento = Seleccion.Items[Seleccion.SelectedIndex];
            if (elemento.Value == "1")
            {
                Codigo.InnerText = "Código: 00001";
                Nombre.InnerText = "Nombre: " + elemento.Text;
                Descripcion.InnerText = "Descripción: Pantalla LCD 49 pulgadas";
                Marca.InnerText = "Marca: LG";
                Precio.InnerText = "Precio: 2400.00 soles";
                ImagenI.Src = "televisor.jpg";

            }
            if (elemento.Value == "2")
            {
                Codigo.InnerText = "Código: 00002";
                Nombre.InnerText = "Nombre: " + elemento.Text;
                Descripcion.InnerText = "Descripción: Lavadora de 12  kg.";
                Marca.InnerText = "Marca: Samsung";
                Precio.InnerText = "Precio: 2500.00 soles";
                ImagenI.Src = "lavadora.jpg";

            }
            if (elemento.Value == "3")
            {
                Codigo.InnerText = "Código: 00003";
                Nombre.InnerText = "Nombre: " + elemento.Text;
                Descripcion.InnerText = "Descripción: Bluray";
                Marca.InnerText = "Marca: SONY";
                Precio.InnerText = "Precio: 700.00 soles";
                ImagenI.Src = "reproductor.jpg";

            }
            if (elemento.Value == "4")
            {
                Codigo.InnerText = "Código: 00004";
                Nombre.InnerText = "Nombre: " + elemento.Text;
                Descripcion.InnerText = "Descripción: Hornea, Calienta, etc.";
                Marca.InnerText = "Marca: Panasonic";
                Precio.InnerText = "Precio: 950.00 soles";
                ImagenI.Src = "hornomicroondas.jpg";

            }
            if (elemento.Value == "5")
            {
                Codigo.InnerText = "Código: 00005";
                Nombre.InnerText = "Nombre: " + elemento.Text;
                Descripcion.InnerText = "Descripción: Alta Velocidad de Licuado";
                Marca.InnerText = "Marca: Oster";
                Precio.InnerText = "Precio: 240.00 soles";
                ImagenI.Src = "licuadora.png";

            }
            if (elemento.Value == "6")
            {
                Codigo.InnerText = "Código: 00006";
                Nombre.InnerText = "Nombre: " + elemento.Text;
                Descripcion.InnerText = "Descripción: Planchado para todo tipo de telas.";
                Marca.InnerText = "Marca: Philips";
                Precio.InnerText = "Precio: 500.00 soles";
                ImagenI.Src = "plancha.jpg";

            }
            if (elemento.Value == "7")
            {
                Codigo.InnerText = "Código: 00007";
                Nombre.InnerText = "Nombre: " + elemento.Text;
                Descripcion.InnerText = "Descripción: Alta velocidad en 10 modos.";
                Marca.InnerText = "Marca: Oster";
                Precio.InnerText = "Precio: 130.00 soles";
                ImagenI.Src = "batidora.jpg";

            }
        }
    }
}