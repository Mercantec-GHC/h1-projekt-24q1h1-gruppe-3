using DomainModels;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Service
{
    public class AuthenticationService
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly DatabaseService _databaseService;

        public AuthenticationService(IJSRuntime jsRuntime, DatabaseService databaseService)
        {
            _jsRuntime = jsRuntime;
            _databaseService = databaseService;
            LoadFromLocalStorage();
            ClearLocalStorageOnPageExit();
        }

        public bool IsAuthenticated { get; private set; }
        public User CurrentUser { get; private set; }
        public string CurrentUserID { get; private set; }

        public async Task Login(User user)
        {
            IsAuthenticated = true;
            CurrentUser = user;
            CurrentUserID = user.userID.ToString(); // Sørger for at sætte CurrentUserID korrekt
            _databaseService.SetCurrentUserID(CurrentUserID); 
            await SaveToLocalStorage();
        }

        public async Task Logout()
        {
            IsAuthenticated = false;
            CurrentUser = null;
            CurrentUserID = null; // Sørg for at rydde CurrentUserID
            await ClearLocalStorage();
            
        }

        private async Task SaveToLocalStorage()
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "IsAuthenticated", IsAuthenticated.ToString());
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "CurrentUser", CurrentUser != null ? CurrentUser.name : "");
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "CurrentUserId", CurrentUserID); // Gem CurrentUserID korrekt
        }

        public async Task LoadFromLocalStorage()
        {
            string isAuthenticatedString = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "IsAuthenticated");
            if (!string.IsNullOrEmpty(isAuthenticatedString))
            {
                IsAuthenticated = bool.Parse(isAuthenticatedString);
            }

            string userName = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "CurrentUser");
            if (!string.IsNullOrEmpty(userName))
            {
                CurrentUser = new User
                { name = userName };
            }
            CurrentUserID = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "CurrentUserId");
        }

        private async Task ClearLocalStorage()
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "IsAuthenticated");
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "CurrentUser");
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "CurrentUserId");
        }

        private async Task ClearLocalStorageOnPageExit()
        {
                await _jsRuntime.InvokeVoidAsync("eval", @"
            window.addEventListener('beforeunload', function() {
                localStorage.clear();
                });
                ");
        }
    }
}
