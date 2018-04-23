Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm.POCO

Namespace DXSample.Common
    Public Class RowViewModel
        Public Overridable Property City() As String
        Public Overridable Property UnitPrice() As Double
        Public Overridable Property Quantity() As Double
        Public Overridable Property Discount() As Double
        Public Overridable Property Freight() As Double
    End Class

    Friend NotInheritable Class DataHelper

        Private Sub New()
        End Sub

        Public Shared Function GetRows() As ObservableCollection(Of RowViewModel)
            Dim Rows = New ObservableCollection(Of RowViewModel)()
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Aachen", .UnitPrice = 10, .Quantity = 20, .Discount = 0, .Freight = 30.54}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Aachen", .UnitPrice = 6.20, .Quantity = 12, .Discount = 0, .Freight = 30.54}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Aachen", .UnitPrice = 14.40, .Quantity = 12, .Discount = 0, .Freight = 30.54}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Aachen", .UnitPrice = 4.80, .Quantity = 18, .Discount = 0, .Freight = 4.45}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Aachen", .UnitPrice = 21, .Quantity = 20, .Discount = 0.03, .Freight = 33.35}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Aachen", .UnitPrice = 6, .Quantity = 7, .Discount = 0, .Freight = 149.74}))

            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Barcelona", .UnitPrice = 16.80, .Quantity = 5, .Discount = 0, .Freight = 10.14}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Barcelona", .UnitPrice = 6.20, .Quantity = 45, .Discount = 0, .Freight = 10.14}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Barcelona", .UnitPrice = 14.40, .Quantity = 5, .Discount = 0.06, .Freight = 18.69}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Barcelona", .UnitPrice = 4.80, .Quantity = 17, .Discount = 0, .Freight = 18.69}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Barcelona", .UnitPrice = 21, .Quantity = 35, .Discount = 0, .Freight = 6.54}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "Barcelona", .UnitPrice = 6, .Quantity = 5, .Discount = 0, .Freight = 1.36}))

            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "London", .UnitPrice = 8, .Quantity = 30, .Discount = 0, .Freight = 22.77}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "London", .UnitPrice = 26.60, .Quantity = 9, .Discount = 0, .Freight = 22.77}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "London", .UnitPrice = 3.60, .Quantity = 25, .Discount = 0.05, .Freight = 18.69}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "London", .UnitPrice = 15.60, .Quantity = 2, .Discount = 0, .Freight = 94.34}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "London", .UnitPrice = 27.20, .Quantity = 56, .Discount = 0, .Freight = 6.54}))
            Rows.Add(ViewModelSource.Create(Function() New RowViewModel() With {.City = "London", .UnitPrice = 28.80, .Quantity = 70, .Discount = 0.15, .Freight = 1.36}))
            Return Rows
        End Function
    End Class
End Namespace
