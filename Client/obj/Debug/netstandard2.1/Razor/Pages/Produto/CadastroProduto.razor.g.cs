#pragma checksum "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c73d4c2a85f081c1fcdbd1c471bcc69890fe2d43"
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
#line 2 "C:\wamp64\www\Desafio_Aula\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\wamp64\www\Desafio_Aula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\wamp64\www\Desafio_Aula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\wamp64\www\Desafio_Aula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\wamp64\www\Desafio_Aula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\wamp64\www\Desafio_Aula\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\wamp64\www\Desafio_Aula\Client\_Imports.razor"
using Desafio_Aula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\wamp64\www\Desafio_Aula\Client\_Imports.razor"
using Desafio_Aula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
using Desafio_Aula.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Produto/CadastroProduto")]
    public partial class CadastroProduto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Cadastrar novo Produto</h4>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
                          produto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-row");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group col");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.AddMarkupContent(20, "<label>Nome</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
                                                                 produto.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Nome = __value, produto.Nome))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => produto.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __Blazor.Desafio_Aula.Client.Pages.Produto.CadastroProduto.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 16 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
                                              () => produto.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-row");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group col");
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.AddMarkupContent(38, "<label>Descricao</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(39);
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
                                                                     produto.Descricao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Descricao = __value, produto.Descricao))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => produto.Descricao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __Blazor.Desafio_Aula.Client.Pages.Produto.CadastroProduto.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 23 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
                                              () => produto.Descricao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-row");
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group col");
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.AddMarkupContent(56, "<label>Preço</label>\r\n                    ");
                __Blazor.Desafio_Aula.Client.Pages.Produto.CadastroProduto.TypeInference.CreateInputNumber_2(__builder2, 57, 58, "form-control", 59, 
#nullable restore
#line 29 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
                                                                   produto.Preco

#line default
#line hidden
#nullable disable
                , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Preco = __value, produto.Preco)), 61, () => produto.Preco);
                __builder2.AddMarkupContent(62, "\r\n                    ");
                __Blazor.Desafio_Aula.Client.Pages.Produto.CadastroProduto.TypeInference.CreateValidationMessage_3(__builder2, 63, 64, 
#nullable restore
#line 30 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
                                              () => produto.Preco

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.AddMarkupContent(68, "<div class=\"text-center\">\r\n                <button class=\"btn btn-primary\" type=\"submit\">Salvar</button>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\wamp64\www\Desafio_Aula\Client\Pages\Produto\CadastroProduto.razor"
      
    private Produto produto = new Produto();

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
namespace __Blazor.Desafio_Aula.Client.Pages.Produto.CadastroProduto
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
