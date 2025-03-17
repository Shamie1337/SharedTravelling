using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace SharedTravelling.Components
{
	public class MainMenuComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return await Task.FromResult<IViewComponentResult>(View());
		}
	}
}
