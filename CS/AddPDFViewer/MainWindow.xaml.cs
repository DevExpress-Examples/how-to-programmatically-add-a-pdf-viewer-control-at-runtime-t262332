using DevExpress.Xpf.PdfViewer;
using System.Windows;

namespace AddPDFViewer {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            // Create a PDF viewer control and add it to the window. 
            PdfViewerControl viewer = new PdfViewerControl();
            this.Content = viewer;          
        }
    }
}

