using DomainModels;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Service
{
	public class AuthenticationService
	{


		private readonly IJSRuntime _jsRuntime;

		public AuthenticationService(IJSRuntime jsRuntime)
		{
			_jsRuntime = jsRuntime;
			LoadFromLocalStorage();
		}

		public bool IsAuthenticated { get; private set; }
		public User CurrentUser { get; private set; }

		public async Task Login(User user)
		{
			IsAuthenticated = true;
			CurrentUser = user;
			await SaveToLocalStorage();
		}

		public async Task Logout()
		{
			IsAuthenticated = false;
			CurrentUser = null;
			await ClearLocalStorage();
		}

		private async Task SaveToLocalStorage()
		{
			await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "IsAuthenticated", IsAuthenticated.ToString());
			await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "CurrentUser", CurrentUser != null ? CurrentUser.name : "");
		}


		private async Task LoadFromLocalStorage()
		{
			string isAuthenticatedString = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "IsAuthenticated");
			if (!string.IsNullOrEmpty(isAuthenticatedString))
			{
				IsAuthenticated = bool.Parse(isAuthenticatedString);
			}

			string userName = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "CurrentUser");
			if (!string.IsNullOrEmpty(userName))
			{
				CurrentUser = new User { name = userName };
			}
		}


		private async Task ClearLocalStorage()
		{
			await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "IsAuthenticated");
			await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "CurrentUser");
		}
	}
}
