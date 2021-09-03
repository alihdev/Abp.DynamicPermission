﻿using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.DynamicPermission.Blazor.WebAssembly
{
    [DependsOn(
        typeof(AbpDynamicPermissionBlazorModule),
        typeof(DynamicPermissionHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class AbpDynamicPermissionBlazorWebAssemblyModule : AbpModule
    {
        
    }
}