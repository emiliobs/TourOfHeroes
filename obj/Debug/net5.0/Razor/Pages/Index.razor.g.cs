#pragma checksum "C:\Projects4\TourOfHeroes\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a82ba21c165e5af443a269ff3a0a2f4e04571a7"
// <auto-generated/>
#pragma warning disable 1591
namespace TourOfHeroes.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects4\TourOfHeroes\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects4\TourOfHeroes\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects4\TourOfHeroes\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects4\TourOfHeroes\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects4\TourOfHeroes\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects4\TourOfHeroes\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects4\TourOfHeroes\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects4\TourOfHeroes\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects4\TourOfHeroes\_Imports.razor"
using TourOfHeroes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects4\TourOfHeroes\_Imports.razor"
using TourOfHeroes.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects4\TourOfHeroes\_Imports.razor"
using TourOfHeroes.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Projects4\TourOfHeroes\_Imports.razor"
using TourOfHeroes.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 3 "C:\Projects4\TourOfHeroes\Pages\Index.razor"
     title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<TourOfHeroes.Components.Heroes>(3);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Projects4\TourOfHeroes\Pages\Index.razor"
      
	string title = "Tour of heroes";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
