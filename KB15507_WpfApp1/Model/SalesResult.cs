using KB15507_WpfApp1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB15507_WpfApp1.Model;
internal class SalesResult : ObservableObject
{
    private String _month;

    public String Month
    {
        get { return _month; }
        set { _month = value; OnPropertyChanged(); }
    }

    private double? _actual;

    public double? Actual
    {
        get { return _actual; }
        set { _actual = value; OnPropertyChanged(); }
    }

    private double? _prospect;

    public double? Prospect
    {
        get { return _prospect; }
        set { _prospect = value; OnPropertyChanged(); }
    }

    public SalesResult()
    {
    }
}
