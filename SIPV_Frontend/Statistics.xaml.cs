using OxyPlot;
using System.Collections.ObjectModel;
using OxyPlot.Axes;
using OxyPlot.Series;
using Microsoft.Maui.Controls;
using Microcharts;
using SkiaSharp;

namespace SIPV_Frontend;

public partial class Statistics : ContentPage
{
    ChartEntry[] dnevi = new[]
    {
        new ChartEntry(10){
        Label = "Pon",
        ValueLabel = "10",
        Color = SKColor.Parse("#4682B4")
         },

        new ChartEntry(15){
        Label = "Tor",
        ValueLabel = "15",
        Color = SKColor.Parse("#4682B4")
         },

        new ChartEntry(15){
        Label = "Sre",
        ValueLabel = "2",
        Color = SKColor.Parse("#4682B4")
         },

        new ChartEntry(15){
        Label = "Cet",
        ValueLabel = "8",
        Color = SKColor.Parse("#4682B4")
         },

        new ChartEntry(15){
        Label = "Pet",
        ValueLabel = "17",
        Color = SKColor.Parse("#4682B4")
         },

        new ChartEntry(22){
        Label = "Sob",
        ValueLabel = "22",
        Color = SKColor.Parse("#4682B4")
         },

        new ChartEntry(9){
        Label = "Ned",
        ValueLabel = "9",
        Color = SKColor.Parse("#4682B4")
         }
    };

    ChartEntry[] obiskano = new[]
    {
        new ChartEntry(10){
        Label = "Pon",
        ValueLabel = "10",
        Color = SKColor.Parse("#4682B4")
         },

        new ChartEntry(15){
        Label = "Tor",
        ValueLabel = "15",
        Color = SKColor.Parse("#ADD8E6")
         },

        
    };


    public Statistics()
    {
        InitializeComponent();

        myChartView.Chart = new BarChart
        {
            Entries = dnevi
        };
        myChartView2.Chart = new DonutChart
        {
            Entries = obiskano,
            
        };
        myChartView3.Chart = new LineChart
        {
           Entries = dnevi
        };
    }



   


}






