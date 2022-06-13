
using Entities.Models;
using HamsterWars2Blazor.Service;
using Microsoft.AspNetCore.Components;
using Shared.DataTransferObjects;

namespace HamsterWars2Blazor.Pages;

public partial class Battle : ComponentBase
{
    private Hamster oldHamster1;
    private Hamster oldHamster2;
    [Parameter]
    public Hamster hamster1 { get; set; }
    [Parameter]
    public Hamster hamster2 { get; set; }
    private double hamster1Procent;
    private double hamster2Procent;
    //public MatchForCreationDto matchForCreation { get; set; }
    public HamsterForUpdateDto hamsterForUpdate { get; set; }
    [Inject]
    public IHamsterHttpService hamsterHttpService { get; set; }
    [Inject]
    public IMatchHttpService matchHttpService { get; set; }
    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public async Task Update(Hamster hamsterWin, Hamster hamsterLoss)
    {

        AddWin(hamsterWin);
        AddLoss(hamsterLoss);
        await hamsterHttpService.UpdateHamster(hamsterWin);
        await hamsterHttpService.UpdateHamster(hamsterLoss);

        MatchForCreationDto matchForCreation = new MatchForCreationDto();
        matchForCreation.WinnerId = hamsterWin.Id;
        matchForCreation.LoserId = hamsterLoss.Id;


        await matchHttpService.CreateMatch(matchForCreation);



        RunAgain(hamsterWin, hamsterLoss);

    }
    public void AddWin(Hamster hamsterWin)
    {
        hamsterWin.Wins++;
        hamsterWin.Games++;
    }
    public void AddLoss(Hamster hamsterLoss)
    {
        hamsterLoss.Losses++;
        hamsterLoss.Games++;
    }

    public async Task RunAgain(Hamster hamsterWin, Hamster hamsterLoss)
    {
        oldHamster1 = hamsterWin;
        oldHamster2 = hamsterLoss;
        hamster1Procent = CalculateProcent(hamsterWin);
        hamster2Procent = CalculateProcent(hamsterLoss);
        await GetTwoRandomHamsters();
        StateHasChanged(); //Här laddas det om
    }
    public async Task GetTwoRandomHamsters()
    {

        hamster1 = await hamsterHttpService.GetRandomHamster();
        do
        {
             hamster2 = await hamsterHttpService.GetRandomHamster();//TODO: koll is active

        } while (hamster1.Id == hamster2.Id);//TODO får fram 2 ändå ibland

    }
    private static double CalculateProcent(Hamster hamster)
    {
        double sum = ((double)hamster.Wins / (double)hamster.Games) * 100d;
        return sum;
    }
    protected override async void OnInitialized()
    {
        await GetTwoRandomHamsters();
        StateHasChanged();
    }
}
