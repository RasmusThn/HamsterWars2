using Entities.Models;
using HamsterWars2Blazor.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace HamsterWars2Blazor.Components
{
    public partial class ProfileComponent : ComponentBase
    {


        [Parameter]
        public int Id { get; set; }
        [Parameter]
        public Hamster hamster { get; set; }
        private bool _showMatches = false;
        private bool _showEdit = false;
        private string _ShowHide = "Show";
        private string _showOrHideEdit = "Show";
        private bool Isprofile { get; set; } = true;
        public bool DeleteDialogOpen { get; set; }
        [Inject]
        public IHamsterHttpService httpService { get; set; }

        [Inject]
        NavigationManager navigation { get; set; }
        
        public async void Delete(Hamster hamster)
        {

           await httpService.DeleteHamster(hamster.Id);
           await JSRuntime.InvokeVoidAsync("history.back");

        }
        public void Edit()
        {
            if (_showEdit)
            {
                
                _showEdit = false;
                _showOrHideEdit = "Show";
            }
            else
            {
                if (_showMatches)
                {
                    _showMatches = false;
                    _ShowHide = "Show";
                }
                _showEdit = true;
                _showOrHideEdit = "Hide";
            }
        }
       
        public void ShowMatches()
        {
            if (_showMatches)
            {
                
                _showMatches = false;
                _ShowHide = "Show";
            }
            else
            {
                if (_showEdit)
                {
                    _showEdit = false;
                    _showOrHideEdit = "Show";
                }
                _showMatches = true;
                _ShowHide = "Hide";
            }
        }
        private async void GoBack()
        {
            await JSRuntime.InvokeVoidAsync("history.back");
        }
        private void OnDeleteDialogClose(bool accepted)
        {
            DeleteDialogOpen = false;
            if (accepted)
            {
                Delete(hamster);
            }
            StateHasChanged();
        }
        private void OpenDeleteDialog()
        {
            DeleteDialogOpen = true;
            StateHasChanged();
        }
    }
}
