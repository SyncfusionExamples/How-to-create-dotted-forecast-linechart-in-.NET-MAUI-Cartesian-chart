# How to create dotted forecast line chart in .NET MAUI.
A forecast chart, also known as a forecasting chart, is a prediction or estimation of future values based on data and statistical models. By analyzing past data, forecasts provide valuable insights for decision-making and planning.
 
To create a forecast chart, you can follow these steps:
 
Step 1:Initialize the chart using this document.
 
Step 2: Add a dotted forecast line in your application by using the StrokeDashArray property. This property is a double array property, that can be set using a resource and then bound to a key.
 
 XAML
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
