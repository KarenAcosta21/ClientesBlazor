#pragma checksum "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80810360957f79ef9e6b2d891f41a98429180bf6"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecti_Cafeteria.ClientesBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Proyecti_Cafeteria.ClientesBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Proyecti_Cafeteria.ClientesBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(4);
                __builder2.AddAttribute(5, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                          1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Class", "Brown");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(8);
                    __builder3.AddAttribute(9, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 7 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(14);
                    __builder3.AddAttribute(15, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 8 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "Class", "ml-3");
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(18, "☕🍩Cafeteria🥨🍴");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(20);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(22);
                    __builder3.AddAttribute(23, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                              Icons.Material.Filled.MoreVert

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                                                                     Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 10 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                                                                                          Edge.End

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(27);
                __builder2.AddAttribute(28, "Class", "pa-4 Brown Darken1 shades-text text-blak");
                __builder2.AddAttribute(29, "ClipMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DrawerClipMode>(
#nullable restore
#line 12 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                                                                                                   DrawerClipMode.Always

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                                                                                                                                     2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
                                                                            _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Proyecti_Cafeteria.ClientesBlazor.Shared.NavMenu>(34);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(36);
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(38);
                    __builder3.AddAttribute(39, "Class", "pa-6");
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(41, 
#nullable restore
#line 17 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\MainLayout.razor"
       
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
