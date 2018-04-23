Imports DevExpress.Xpf.PdfViewer
Imports System.Windows

Namespace AddPDFViewer

    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            ' Create a PDF viewer control and add it to the window. 
            Dim viewer As New PdfViewerControl()
            Me.Content = viewer
        End Sub
    End Class
End Namespace

