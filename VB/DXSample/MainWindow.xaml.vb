Imports DevExpress.Xpf.Core
Imports DXSample.Common

Namespace DXSample
    Partial Public Class MainWindow
        Inherits DXWindow

        Public Sub New()
            InitializeComponent()
            DataContext = DataHelper.GetRows()
        End Sub

        Private Sub TableView_CustomRowAppearance(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.CustomRowAppearanceEventArgs)
            e.Result = e.ConditionalValue
            e.Handled = True
        End Sub
    End Class
End Namespace
