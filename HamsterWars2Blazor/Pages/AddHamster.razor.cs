
using Entities.Models;
using HamsterWars2Blazor.Service;
using Microsoft.AspNetCore.Components;

namespace WarHamsters.Pages
{
    public partial class AddHamster : ComponentBase
    {
        private Hamster Hamster { get; set; } = new Hamster();
        private readonly string href = "/images/hamsters/hamster-";
        private string? Num { get; set; }
        private string? CompleteSrc { get; set; }
        private bool IsSuccess { get; set; }
        public string? FormSubmitMessage { get; set; }
        [Inject]
        public IHamsterHttpService httpService { get; set; }
        private string GetJpgSrc()
        {
            string src = href + Num + ".jpg";
            return src;
        }
        private void ShowImg(ChangeEventArgs e)
        {
            Num = e.Value as string;
            CompleteSrc = GetJpgSrc();
        }
        public void HandleValidSubmit()
        {
            Hamster.ImgName = CompleteSrc;
            httpService.CreateHamster(Hamster);
            FormSubmitMessage = "Hamster Added !";
            Hamster = new Hamster();
            IsSuccess = true;
        }
        public void HandleInvalidSubmit()
        {
            FormSubmitMessage = "Invalid Data";
            IsSuccess = false;
        }
    }
}
