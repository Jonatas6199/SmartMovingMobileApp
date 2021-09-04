using System.Collections.Generic;
using Microcharts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp;

namespace SmartMovingMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartsPage : ContentPage
    {
        List<ChartEntry> timeEntries = new List<ChartEntry>
        {
            new ChartEntry((float)(47.23/60))
            {
                Color = SKColor.Parse("#FF1493"),
                Label =  "24H",
                ValueLabel = "47.23 min"

            },
            new ChartEntry((float)1.5)
            {
                Color = SKColor.Parse("#0a1a91"),
                Label =  "7D",
                ValueLabel = "1.5h"

            },
            new ChartEntry((float)1.2)
            {
                Color = SKColor.Parse("#00CED1"),
                Label =  "15D",
                ValueLabel = "1.2h",
            },
            new ChartEntry((float)1.3)
            {
                Color = SKColor.Parse("#54096b"),
                Label =  "30D",
                ValueLabel = "1.3h",
            },
            new ChartEntry((float)(58.0/60))
            {
                Color = SKColor.Parse("#18ba54"),
                Label =  "6M",
                ValueLabel = "58min",
            },
        };

        List<ChartEntry> tagsEntries = new List<ChartEntry>
        {
            new ChartEntry(220)
            {
                Color = SKColor.Parse("#FF1493"),
                Label =  "1H",
                ValueLabel = "220"

            },
            new ChartEntry(353)
            {
                Color = SKColor.Parse("#0a1a91"),
                Label =  "2H",
                ValueLabel = "353"

            },
            new ChartEntry(345)
            {
                Color = SKColor.Parse("#00CED1"),
                Label =  "3H",
                ValueLabel = "345",
            },
            new ChartEntry(290)
            {
                Color = SKColor.Parse("#54096b"),
                Label =  "24H",
                ValueLabel = "290",
            },
            new ChartEntry(215)
            {
                Color = SKColor.Parse("#18ba54"),
                Label =  "30D",
                ValueLabel = "215",
            },
        };


        public ChartsPage()
        {
            InitializeComponent();
            ChartTime.Chart = new BarChart { Entries = timeEntries, ValueLabelOrientation = Orientation.Horizontal, LabelOrientation = Orientation.Horizontal, LabelTextSize = 35 };
            ChartTags.Chart = new BarChart { Entries = tagsEntries, ValueLabelOrientation = Orientation.Horizontal, LabelOrientation = Orientation.Horizontal,  LabelTextSize = 35 };
        }
    }
}