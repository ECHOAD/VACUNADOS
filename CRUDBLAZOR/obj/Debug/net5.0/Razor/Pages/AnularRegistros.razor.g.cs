#pragma checksum "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41a5051ea2d99a9aa19454b4523e414798d4895e"
// <auto-generated/>
#pragma warning disable 1591
namespace CRUDBLAZOR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Models.ComboBoxModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/anularegistros")]
    public partial class AnularRegistros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudContainer>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(4);
                    __builder3.AddAttribute(5, "MaxWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 14 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                MaxWidth.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
                        __builder4.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                             CedulaFiltro

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(9, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                     ()=>LoadObjects(CedulaFiltro)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder5) => {
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(12, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCard>(13);
                            __builder5.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudCardHeader>(15);
                                __builder6.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudCardHeader>(17);
                                    __builder7.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudText>(19);
                                        __builder8.AddAttribute(20, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 20 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                           Typo.h5

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(22, "Anular Registro");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(23, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudCardContent>(24);
                                __builder6.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudGrid>(26);
                                    __builder7.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudItem>(28);
                                        __builder8.AddAttribute(29, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                         12

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __Blazor.CRUDBLAZOR.Pages.AnularRegistros.TypeInference.CreateMudTextField_0(__builder9, 31, 32, "Cedula", 33, 
#nullable restore
#line 26 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                                                 Variant.Text

#line default
#line hidden
#nullable disable
                                            , 34, 
#nullable restore
#line 26 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                                                                         true

#line default
#line hidden
#nullable disable
                                            , 35, "El campo cedula es requerido!", 36, 
#nullable restore
#line 26 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                           CedulaFiltro

#line default
#line hidden
#nullable disable
                                            , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CedulaFiltro = __value, CedulaFiltro)));
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(38, "\r\n                            ");
                                        __builder8.OpenComponent<MudBlazor.MudItem>(39);
                                        __builder8.AddAttribute(40, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                         12

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.OpenComponent<MudBlazor.MudButton>(42);
                                            __builder9.AddAttribute(43, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 29 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                       ButtonType.Submit

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(44, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 29 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                                   Variant.Filled

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(45, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 29 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                                                          Color.Info

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(46, "FullWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                                                                                 true

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(48, "Buscar Vacunaciones Por Cedula");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudDivider>(50);
                        __builder4.AddAttribute(51, "DividerType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DividerType>(
#nullable restore
#line 35 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                     DividerType.Middle

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(52, "Class", "my-6");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(54);
                __builder2.AddAttribute(55, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                         12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 40 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
         if (personavacunas != null)
        {

#line default
#line hidden
#nullable disable
                    __Blazor.CRUDBLAZOR.Pages.AnularRegistros.TypeInference.CreateMudTable_1(__builder3, 58, 59, 
#nullable restore
#line 42 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                              personavacunas

#line default
#line hidden
#nullable disable
                    , 60, 
#nullable restore
#line 42 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                     true

#line default
#line hidden
#nullable disable
                    , 61, 
#nullable restore
#line 42 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                        false

#line default
#line hidden
#nullable disable
                    , 62, 
#nullable restore
#line 42 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                    , 63, 
#nullable restore
#line 42 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                                                               5

#line default
#line hidden
#nullable disable
                    , 64, (__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudSpacer>(65);
                        __builder4.CloseComponent();
                    }
                    , 66, (__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTh>(67);
                        __builder4.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(69, "Cedula");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(70, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(71);
                        __builder4.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(73, "Nombres");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(74, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(75);
                        __builder4.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(77, "Telefono");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(78, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(79);
                        __builder4.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(81, "Vacuna Aplicada");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(82, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(83);
                        __builder4.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(85, "Provincia");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(86, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(87);
                        __builder4.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(89, "Fecha");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(90, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(91);
                        __builder4.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(93, "Accion");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    , 94, (context) => (__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTd>(95);
                        __builder4.AddAttribute(96, "DataLabel", "Cedula");
                        __builder4.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(98, 
#nullable restore
#line 59 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                               context.Cedula

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(99, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(100);
                        __builder4.AddAttribute(101, "DataLabel", "Nombres");
                        __builder4.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(103, 
#nullable restore
#line 60 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                context.Nombres

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(104, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(105);
                        __builder4.AddAttribute(106, "DataLabel", "Telefono");
                        __builder4.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(108, 
#nullable restore
#line 61 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                 context.Telefono

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(109, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(110);
                        __builder4.AddAttribute(111, "DataLabel", "Vacuna Aplicada");
                        __builder4.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(113, 
#nullable restore
#line 62 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                        context.VacunaAplicada

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(114, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(115);
                        __builder4.AddAttribute(116, "DataLabel", "Fecha");
                        __builder4.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(118, 
#nullable restore
#line 63 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                              context.Provincia

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(119, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(120);
                        __builder4.AddAttribute(121, "DataLabel", "Fecha");
                        __builder4.AddAttribute(122, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(123, 
#nullable restore
#line 64 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                              context.Fecha

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(124, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(125);
                        __builder4.AddAttribute(126, "DataLabel", "Acciones");
                        __builder4.AddAttribute(127, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(128);
                            __builder5.AddAttribute(129, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                ()=> DeleteData(context)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(130, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                                 Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(131, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 66 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                                                                     Size.Small

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(132, "Class", "ma-2");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    , 133, (__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTablePager>(134);
                        __builder4.CloseComponent();
                    }
                    );
#nullable restore
#line 75 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
       
    string CedulaFiltro = "";
    private static bool ExistPersona = false;
    static List<dynamic> personavacunas;

    int AnswerServer;

    private async Task LoadObjects(string Cedula)
    {

        string query = $"SELECT dbo.ufcExistePersona (@Cedula)";

        int AnswerServer = await _data.LoadObject<int, dynamic>(query, new { Cedula = Cedula }, _config.GetConnectionString("default"));

        ExistPersona = true;

        if (AnswerServer == 1)
        {
            query = "SELECT * FROM uvwPersonaVacuna WHERE Cedula = @Cedula ";

            personavacunas = await _data.LoadData<dynamic, dynamic>(query, new { Cedula = Cedula }, _config.GetConnectionString("default"));

        }
        else
        {
            //persona = new();
            //OPersonaVacuna = new();

            //OPersonaVacuna.Persona.Cedula = Cedula;
            //ExistPersona = false;
        }
    }

    private async Task DeleteData(dynamic Persona)
    {
        string query = "DELETE PERSONA_VACUNA WHERE Id= @Id";
        AnswerServer = await _data.SaveData(query, new { Id = Persona.Id }, _config.GetConnectionString("default"));
        personavacunas = null;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
namespace __Blazor.CRUDBLAZOR.Pages.AnularRegistros
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Required", __arg2);
        __builder.AddAttribute(__seq3, "RequiredError", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTable_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Int32 __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "FixedFooter", __arg2);
        __builder.AddAttribute(__seq3, "FixedHeader", __arg3);
        __builder.AddAttribute(__seq4, "RowsPerPage", __arg4);
        __builder.AddAttribute(__seq5, "ToolBarContent", __arg5);
        __builder.AddAttribute(__seq6, "HeaderContent", __arg6);
        __builder.AddAttribute(__seq7, "RowTemplate", __arg7);
        __builder.AddAttribute(__seq8, "PagerContent", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
