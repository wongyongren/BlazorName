using Microsoft.AspNetCore.Components;

namespace BlazorName.UIInterfaces
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}