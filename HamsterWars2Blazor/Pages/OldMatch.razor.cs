using Entities.Models;
using HamsterWars2Blazor.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace HamsterWars2Blazor.Pages
{
    public partial class OldMatch : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Parameter]
        public Match match { get; set; }
        private Hamster winHamster;
        private Hamster lossHamster;
        private int days;
        private int hours;

        public bool DeleteDialogOpen { get; set; }
        [Inject]
        public IMatchHttpService matchHttpService { get; set; }
        [Inject]
        public IHamsterHttpService hamsterHttpService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            match = await matchHttpService.GetMatchById(Id);
            winHamster = await hamsterHttpService.GetHamsterById(match.WinnerId);
            lossHamster = await hamsterHttpService.GetHamsterById(match.LoserId);
            ClaculateDays();
            StateHasChanged();
        }
        void ClaculateDays()
        {
            var span = DateTime.Now.Subtract(match.TimeStamp);
            days = span.Days;
            hours = span.Hours;
        }
        private void OnDeleteDialogClose(bool accepted)
        {
            DeleteDialogOpen = false;
            if (accepted)
            {
                Delete(match);
            }
            StateHasChanged();
        }
        private void OpenDeleteDialog()
        {
            DeleteDialogOpen = true;
            StateHasChanged();
        }
        public async void Delete(Match match)
        {
            UpdateHamsters();
            await matchHttpService.DeleteMatch(match.Id);
            await JSRuntime.InvokeVoidAsync("history.back");

        }
        async void UpdateHamsters()
        {
            winHamster.Wins--;
            winHamster.Games--;
            await hamsterHttpService.UpdateHamster(winHamster);

            lossHamster.Losses--;
            lossHamster.Games--;
            await hamsterHttpService.UpdateHamster(lossHamster);
        }
    }
}
