<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aplicacion.aspx.cs" Inherits="DA_EjercicioPPrac2.Aplicacion" %>

<!DOCTYPE html>
<script languaje="C#" runat="server">
    void CambiarTamano(Object sender, EventArgs argumentos){
        ImagenI.Style["width"] = Tamano.Value;
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Electrodomésticos</title>
    <style >
        body{
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            text-align:center;
            background-image: url('fondo.jpg');
        }
        p{
            font-size:30px;
            font-family:'Comic Sans MS';
            font-weight:bold;
        }
        #Contener {
            border:double;
            border-color:#994939;
            
        }
        #ImagenI{
            width:500px;
            border:dashed;
            border-spacing:20px 30px 20px 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <p>Electrodomésticos</p>
                <h3>Seleccione: </h3>
                <select id="Seleccion" runat="server"></select>
                <br />
                <p></p>
                <input type="submit" id="Confirmar" runat="server" value="Aceptar" onserverclick="Confirmar_ServerClick"/>
                <br />
                <p></p>
                <div id="Contener" runat="server">
                    <div id="Codigo" runat="server" style="height:30px" ></div>
                    <div id="Nombre" runat="server" style="height:30px"></div>
                    <div id="Descripcion" runat="server" style="height:30px"></div>
                    <div id="Marca" runat="server" style="height:30px"></div>
                    <div id="Precio" runat="server" style="height:30px"></div>
                </div>
                <br />

                <img id="ImagenI" runat="server" />
                <p></p>
                <select id="Tamano" runat="server">
                    <option value="500px">Predeterminado</option>
                    <option value="100px">100 px</option>
                    <option value="200px">200 px</option>
                    <option value="300px">300 px</option>
                    <option value="400px">400 px</option>
                    <option value="1000px">1000 px</option>
                </select>
                
                <p></p>
                <input type="button" runat="server" value="Cambiar Tamaño de Imagen" onserverclick="CambiarTamano" />
                     
            </div>
        </div>
    </form>
</body>
</html>
