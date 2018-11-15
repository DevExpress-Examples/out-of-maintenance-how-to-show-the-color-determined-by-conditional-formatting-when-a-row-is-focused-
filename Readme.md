<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/DXSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))
<!-- default file list end -->
# How to: Show the color determined by conditional formatting when a row is focused


This example demonstrates how to show the color determined by a conditional formatting when a row is focused.


<h3>Description</h3>

<p>This is done by handling the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridTableView_CustomRowAppearancetopic.aspx">CustomRowAppearance</a> event and specifying the required background color in the parameter's <strong>e.Result</strong> property. To accomplish the same task for cell conditional formatting, handle the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridTableView_CustomCellAppearancetopic.aspx">CustomCellAppearance</a> event instead.</p>

<br/>


