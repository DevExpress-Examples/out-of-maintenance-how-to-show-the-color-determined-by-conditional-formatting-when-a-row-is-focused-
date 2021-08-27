<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653125/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T423710)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/DXSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXSample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Show the color determined by conditional formatting when a row is focused


This example demonstrates how to show the color determined by a conditional formatting when a row is focused.


<h3>Description</h3>

<p>This is done by handling the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridTableView_CustomRowAppearancetopic.aspx">CustomRowAppearance</a> event and specifying the required background color in the parameter's <strong>e.Result</strong> property. To accomplish the same task for cell conditional formatting, handle the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridTableView_CustomCellAppearancetopic.aspx">CustomCellAppearance</a> event instead.</p>

<br/>


