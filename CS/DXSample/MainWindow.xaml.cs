using DevExpress.Xpf.Core;
using DXSample.Common;

namespace DXSample {
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            InitializeComponent();
            DataContext = DataHelper.GetRows();
        }

        private void TableView_CustomRowAppearance(object sender, DevExpress.Xpf.Grid.CustomRowAppearanceEventArgs e) {
            e.Result = e.ConditionalValue;
            e.Handled = true;
        }
    }
}
