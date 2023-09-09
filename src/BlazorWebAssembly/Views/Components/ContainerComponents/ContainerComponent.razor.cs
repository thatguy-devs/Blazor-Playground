using BlazorWebAssembly.Models.ContainerComponent;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssembly.Views.Components.ContainerComponents
{
	public partial class ContainerComponent : ComponentBase
	{
		[Parameter]
		public ComponentState State { get; set; }

		[Parameter]
		public RenderFragment Content { get; set; }

		[Parameter]
		public string Error { get; set; }
	}
}
