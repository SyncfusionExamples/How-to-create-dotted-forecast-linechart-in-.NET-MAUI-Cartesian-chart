# How to create dotted forecast line in .NET MAUI (SfCartesianChart)
The [.NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) allows add a dotted forecast line by using the StrokeDashArray property. This property is a double array property that can be set using a resource and then bind to a key.

Initialize a Cartesian chart with the help of this [guideline](https://help.syncfusion.com/maui/cartesian-charts/getting-started).

**[XAML]**
```
<chart:SfCartesianChart>
       <chart:SfCartesianChart.Resources>
           <DoubleCollection x:Key="dashArray">
                <x:Double>3</x:Double>
                <x:Double>2</x:Double>
            </DoubleCollection>
       </chart:SfCartesianChart.Resources> 

      <chart:SplineSeries ItemsSource="{Binding Data}"
                          XBindingPath="Year" 
                          YBindingPath="Sales">
         </chart:SplineSeries>

          <chart:SplineSeries  ItemsSource="{Binding Data}"
                               XBindingPath="Year" 
                               YBindingPath="ForeCast"
                               StrokeDashArray="{StaticResource dashArray}">
        </chart:SplineSeries>

</chart:SfCartesianChart>

```

**[C#]**
```
SfCartesianChart chart = new SfCartesianChart();

DoubleCollection doubleCollection = new DoubleCollection();
doubleCollection.Add(3);
doubleCollection.Add(2);

SplineSeries series = new SplineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Year",
    YBindingPath = "Sales"

};

SplineSeries series2 = new SplineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Year",
    YBindingPath = "ForeCast",
    StrokeDashArray = doubleCollection
};

chart.Series.Add(series);
chart.Series.Add(series2);

this.Content = chart;
```

**Output:** 
![DottedLine](https://user-images.githubusercontent.com/102796134/232827103-37afd8b6-50ea-4497-8e3e-0420998b7584.png)


