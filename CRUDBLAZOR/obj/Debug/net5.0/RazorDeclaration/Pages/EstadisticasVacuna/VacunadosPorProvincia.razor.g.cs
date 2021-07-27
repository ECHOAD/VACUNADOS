// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CRUDBLAZOR.Pages.EstadisticasVacuna
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacunasprovincia")]
    public partial class VacunadosPorProvincia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Adrian Estevez\Desktop\Full Project\VacunadosKeuri\Vacunados2021\CRUDBLAZOR\Pages\EstadisticasVacuna\VacunadosPorProvincia.razor"
       
    private static ProvinciaModel OProvincia = new();

    private List<ComboBoxProvinciaModel> _cboProvincia;
    List<dynamic> VacunadosProv;


    private async Task VacunadosProvincias(int Id)
    {

        string query = "SP_LIST_VACUNADOS_PROVINCIA @Id";

        VacunadosProv = await _data.LoadData<dynamic, dynamic>(query, new { Id = Id }, _config.GetConnectionString("default"));
    }
    protected override async Task OnInitializedAsync()
    {

        string query = "SELECT Id, Nombre FROM PROVINCIA";

        _cboProvincia = await _data.LoadData<ComboBoxProvinciaModel, dynamic>(query, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
