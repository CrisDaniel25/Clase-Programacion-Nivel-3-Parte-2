#pragma checksum "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_6.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b912f71ce6d2d3aff5c8c5688d9a28ca474badf"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Tarea_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Tarea_2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio-6")]
    public partial class Ejercicio_6 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Ejercicio #6</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"row\">\r\n        <p>Realiza un programa que acepte una URL, determine la cantidad de párrafos e imágenes que contienen estas.</p>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\r\n         ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_6.razor"
                                                           URL

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => URL = __value, URL));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n         ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-dark");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_6.razor"
                                                   Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Verificar URL");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "<br>\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col justify-content-center");
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "ul");
            __builder.AddAttribute(32, "class", "list-group");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "li");
            __builder.AddAttribute(35, "class", "list-group-item");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "p");
            __builder.AddMarkupContent(38, "<strong>Imagenes</strong> = ");
            __builder.AddContent(39, 
#nullable restore
#line 23 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_6.razor"
                                                img

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "li");
            __builder.AddAttribute(43, "class", "list-group-item");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "p");
            __builder.AddMarkupContent(46, "<strong>Parrafos</strong> = ");
            __builder.AddContent(47, 
#nullable restore
#line 26 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_6.razor"
                                                p

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_6.razor"
       
   public string URL;
   public int img;
   public int p;

   public void Search()
   {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_6.razor"
          
   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591