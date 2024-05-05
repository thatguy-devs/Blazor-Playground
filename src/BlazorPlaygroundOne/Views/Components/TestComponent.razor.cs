using BlazorPlaygroundOne.Models.ContainerComponent;
using Microsoft.AspNetCore.Components;

namespace BlazorPlaygroundOne.Views.Components
{
	public partial class TestComponent : ComponentBase
	{
		public ComponentState State { get; set; }
		public string ErrorMessage { get; set; }

		protected async override Task OnInitializedAsync()
		{
			try
			{
                this.State = ComponentState.Loading;
            }
			catch (Exception exception)
			{
				this.ErrorMessage = exception.Message;
				this.State = ComponentState.Error;
			}
		}

        protected async override Task OnParametersSetAsync()
        {
			// simulate loading data here.
            await Task.Delay(TimeSpan.FromSeconds(5));

            this.State = ComponentState.Content;
        }
    }
}
