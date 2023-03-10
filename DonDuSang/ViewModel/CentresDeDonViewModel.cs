using DonDuSang.Services;

namespace DonDuSang.ViewModel;

public partial class CentresDeDonViewModel : BaseViewModel
{
    CentreDeDonService service;
    public ObservableCollection<CentreDeDon> Centres { get; } = new();
    public CentresDeDonViewModel(CentreDeDonService service)
    {
        Titre = "Don du sang";
        this.service = service;
    }

    [RelayCommand]
    async Task GetCentresDeDon()
    {
        if (EstOccupé)
            return;

        EstOccupé = true;
        var entres = await service.GetCentresDeDon();
        if (Centres.Count != 0)
            Centres.Clear();
        foreach (var centre in entres)
        {
            Centres.Add(centre);
        }
        EstOccupé=false;
    }
    [RelayCommand]

    async Task GoToDetails(CentreDeDon centreDeDon)
    {
       await Shell.Current.GoToAsync("DetailsPage", true, 
        new Dictionary<string, object> 
            { 
                { "CentreDeDon", centreDeDon } 
        });
    }
}
