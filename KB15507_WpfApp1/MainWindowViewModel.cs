using KB15507_WpfApp1.Infrastructure;
using KB15507_WpfApp1.Model;
using System.Collections.ObjectModel;

namespace KB15507_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
    public ObservableCollection<SalesResult> SalesResults { get; set; }

    public MainWindowViewModel()
    {
        SalesResults = new()
        {
            new () { Month = "1月", Actual = 100, Prospect = null },
            new () { Month = "2月", Actual = 121.782, Prospect = null },
            new () { Month = "3月", Actual = 148.206, Prospect = 148.206 },
            new () { Month = "4月", Actual = null, Prospect = 148.911 },
            new () { Month = "5月", Actual = null, Prospect = 165.696 },
            new () { Month = "6月", Actual = null, Prospect = 189.118 },
            new () { Month = "7月", Actual = null, Prospect = 191.297 },
            new () { Month = "8月", Actual = null, Prospect = 197.730 },
            new () { Month = "9月", Actual = null, Prospect = 220.739 },
            new () { Month = "10月", Actual = null, Prospect = 235.363 },
            new () { Month = "11月", Actual = null, Prospect = 236.091 },
            new () { Month = "12月", Actual = null, Prospect = 256.984 },
        };
    }
}