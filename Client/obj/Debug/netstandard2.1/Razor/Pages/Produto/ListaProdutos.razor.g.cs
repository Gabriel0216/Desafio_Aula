#pragma checksum "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82ec2d100dba22ba205875a637175df95dc4a498"
// <auto-generated/>
#pragma warning disable 1591
namespace Desafio_Aula.Client.Pages.Produto
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\wamp64\www\projeto\Desafio_Aula\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\wamp64\www\projeto\Desafio_Aula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\wamp64\www\projeto\Desafio_Aula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\wamp64\www\projeto\Desafio_Aula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\wamp64\www\projeto\Desafio_Aula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\wamp64\www\projeto\Desafio_Aula\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\wamp64\www\projeto\Desafio_Aula\Client\_Imports.razor"
using Desafio_Aula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\wamp64\www\projeto\Desafio_Aula\Client\_Imports.razor"
using Desafio_Aula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor"
using Desafio_Aula.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Produto/ListaProdutos")]
    public partial class ListaProdutos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Produtos</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-body");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th scope=\"col\">Nome</th>\r\n                <th scope=\"col\">Descricao</th>\r\n                <th scope=\"col\">Preço</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 19 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor"
             foreach(var item in listaProduto){

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 21 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor"
                         item.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 22 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor"
                         item.Descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 23 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor"
                         item.Preco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-success");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor"
                                                                    () => EditarProduto(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-danger");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor"
                                                                   () => DeletarProduto(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Excluir");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 29 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\ListaProdutos.razor"
      
    private List<Produto> listaProduto = new List<Produto>();

    protected override async Task OnInitializedAsync(){
        var produtos = await Http.GetFromJsonAsync<List<Produto>>("api/Produto/List");
        foreach(var item in produtos){
            listaProduto.Add(item);
        }
    }

    private void EditarProduto(int id){
        NavigationManager.NavigateTo($"Produto/EditaProdutos/{id}");
    }

    private async Task DeletarProduto(int id){
        var del = await Http.DeleteAsync($"api/Produto/Delete/{id}");
        NavigationManager.NavigateTo("Produto/ListaProdutos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
