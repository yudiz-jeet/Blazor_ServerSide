// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCURD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\_Imports.razor"
using BlazorCURD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\_Imports.razor"
using BlazorCURD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\Pages\EditEmployee.razor"
using BlazorCURD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditEmployee/{Id}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\YUDIZ\Traning\B\BlazorCURD\BlazorCURD\Pages\EditEmployee.razor"
       
    [Parameter]
    public string Id { get; set; }
    Employee obj = new Employee();
    protected override async Task OnInitializedAsync()
    {
        obj = await Task.Run(() => employeeService.GetEmployeeAsync(Convert.ToInt32(Id)));
    }
    protected async void UpdateEmployee()
    {
        await employeeService.UpdateEmployeeAsync(obj);
        NavigationManager.NavigateTo("Employees");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Employees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591
