using System;
using System.Windows;
using System.Windows.Forms;

namespace WPF_HOST_winformsEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            htmlEditor.DocumentLoadComplete += HtmlEditor_DocumentLoadComplete;

            htmlEditor.DocumentHTML = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In elementum sagittis arcu, vehicula laoreet purus</p><p>Nullam vel est et est consectetur luctus eget eget erat. Nulla efficitur neque massa, quis aliquet odio laoreet eu. Suspendisse hendrerit, diam eu luctus tincidunt, lectus urna eleifend mi, id suscipit augue augue eget dolor.</p><p>Maecenas id maximus augue. Etiam auctor auctor dui quis sollicitudin</p>";
            htmlEditor.CSSText = "body {font-family: arial}";
            htmlEditor.FontSizesList = "10pt;12pt;14pt;18pt;22pt";
        }

        private void HtmlEditor_DocumentLoadComplete(object sender, EventArgs e)
        {
            htmlEditor.MoveCursorToElement(this.htmlEditor.Document.Body, Zoople.HTMLEditControl.ELEM_ADJ.ELEM_ADJ_AfterBegin);
            htmlEditor.SetFocus();
        }
    }
}
