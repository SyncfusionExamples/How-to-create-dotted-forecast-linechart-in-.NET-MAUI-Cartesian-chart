using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DottedForecastChart
{
    public class ViewModel
    {
        public ObservableCollection<ChartData> Data { get; set; }
        public ObservableCollection<Brush> CustomColor { get; set; }

        public ViewModel()
        {

            Data = new ObservableCollection<ChartData>()
            {
            new ChartData(){Year="2010",Sales = 3200},
            new ChartData(){ Year="2011",Sales = 2000},
            new ChartData(){ Year="2012",Sales = 4500},
            new ChartData(){ Year="2013",Sales = 6000},
            new ChartData(){ Year="2014",Sales = 5500},
            new ChartData(){ Year="2015",Sales = 4600,ForeCast = 4600},
            new ChartData(){ Year="2016",ForeCast = 4500},
            new ChartData(){ Year="2017",ForeCast = 5500},
            new ChartData(){ Year="2018",ForeCast = 6000},
            new ChartData(){ Year="2019",ForeCast = 4800},
            new ChartData(){ Year="2020",ForeCast = 5000},
            new ChartData(){ Year="2021",ForeCast = 6500},
            };

            CustomColor = new ObservableCollection<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#ff944d")),
                new SolidColorBrush(Color.FromArgb("#33bbff"))
            };

        }
    }

    public class ChartData
    {
        public string Year { get; set; }
        public double? Sales { get; set; }
        public double? ForeCast { get; set; }

    }

}

