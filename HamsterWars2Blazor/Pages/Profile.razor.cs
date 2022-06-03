using Entities.Models;
using HamsterWars2Blazor.Service;
using Microsoft.AspNetCore.Components;

namespace HamsterWars2Blazor.Pages
{
    public partial class Profile : ComponentBase
    {


        [Parameter]
        public int Id { get; set; }
        [Parameter]
        public string Oldpage { get; set; }
        [Parameter]
        public Hamster hamster { get; set; }
        private bool _showMatches = false;
        private string _ShowHide = "Show";
        private bool Isprofile { get; set; } = true;
        public bool DeleteDialogOpen { get; set; }
        [Inject]
        public IHamsterHttpService httpService { get; set; }
        protected override async void OnInitialized()
        {
           
           hamster = await httpService.GetHamsterById(Id);

        }
        public void Delete(Hamster hamster)
        {

            httpService.DeleteHamster(hamster.Id);
            navigation.NavigateTo("/gallery");

        }
        public void Edit()
        {
            navigation.NavigateTo("/Edit");
        }
        public void GoBack()
        {

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
                _showMatches = true;
                _ShowHide = "Hide";
            }
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
