Imports DevExpress.Xpf.Core
Imports DXSample.Common

Namespace DXSample

    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
            DataContext = GetRows()
        End Sub

        Private Sub TableView_CustomRowAppearance(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.CustomRowAppearanceEventArgs)
            e.Result = e.ConditionalValue
            e.Handled = True
        End Sub
    End Class
End Namespace
