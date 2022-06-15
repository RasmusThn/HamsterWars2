using Entities.Models;
using HamsterWars2Blazor.Service;
using Microsoft.AspNetCore.Components;

namespace HamsterWars2Blazor.Components
{
    public partial class EditFormComponent : ComponentBase
    {
        [Parameter]
        public bool IsCreateMode { get; set; }
        private string? Num { get; set; }
        private string? CompleteSrc { get; set; }
        private readonly string href = "/images/hamsters/hamster-";
        private bool IsSuccess { get; set; }
        [Parameter]
        public Hamster? hamster { get; set; } = new Hamster();
        public string? FormSubmitMessage { get; set; }
        [Inject]
        public IHamsterHttpService HttpService { get; set; }

        public void HandleValidSubmit()
        {
            if (IsCreateMode)
            {
                hamster.ImgName = CompleteSrc;
                HttpService.CreateHamster(hamster);
                hamster = new Hamster();
            }
            else
            {
                HttpService.EditHamster(hamster);
            }
            FormSubmitMessage = "Success!";
            IsSuccess = true;
            StateHasChanged();
        }
        public void HandleInvalidSubmit()
        {
            FormSubmitMessage = "Invalid Data";
            IsSuccess = false;
        }
        private void ShowImg(ChangeEventArgs e)
        {
            Num = e.Value as string;
            CompleteSrc = GetJpgSrc();
        }
        private string GetJpgSrc()
        {
            string src = href + Num + ".jpg";
            return src;
        }
    }
}
