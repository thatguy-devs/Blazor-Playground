using BlazorWebAssembly.Models.ContainerComponent;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssembly.Views.Components.ContainerComponents
{
	public partial class ContainerStatesComponent
	{
		[Parameter]
		public ComponentState State { get; set; }

		[Parameter]
		public RenderFragment LoadingFragment { get; set; }

		[Parameter]
		public RenderFragment ContentFragment { get; set; }

		[Parameter]
		public RenderFragment ErrorFragment { get; set; }

		private RenderFragment GetComponentStateFragment()
		{
			return State switch
			{
				ComponentState.Loading => LoadingFragment,
				ComponentState.Content => ContentFragment,
				ComponentState.Error => ErrorFragment,
				_ => ErrorFragment
			};
		}
	}
}
