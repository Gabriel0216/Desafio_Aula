#pragma checksum "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\EditaProdutos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5173f54eb36de32b4e60ec868bede22ed45b1b5d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\EditaProdutos.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\EditaProdutos.razor"
using Desafio_Aula.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Produto/EditaProduto")]
    public partial class EditaProdutos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\wamp64\www\projeto\Desafio_Aula\Client\Pages\Produto\EditaProdutos.razor"
      
    private Produto produto = new Produto();

    protected override async Task OnInitializedAsync(){
        //var id = 
        var produtos = await Http.GetFromJsonAsync<List<Produto>>("api/Produto/List/");
    }

    private async Task HandleValidSubmit(){
        var teste = await Http.PostAsJsonAsync("/api/Produto/Create", produto);
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