namespace DonDuSang.ViewModel;

[QueryProperty("CentreDeDon", "CentreDeDon")]
public partial class CentreDeDonDetailsViewModel : BaseViewModel
{
    [ObservableProperty]
    CentreDeDon centreDeDon;

    IMap map;
    public CentreDeDonDetailsViewModel(IMap map)
    {
        this.map = map;
    }
}




