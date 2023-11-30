using System;
using System.Windows;
using System.Windows.Input;

namespace WD2IntroNew
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init_Cont();
            String Command = ("fdfb:4503:4d58::/48");

            // Subscribe to the PreviewKeyDown event
            PreviewKeyDown += MainWindow_PreviewKeyDown;
        }

        private void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Handle the key press event and update the TextBox text
            string currentText = PoweredBy.Text;
            char pressedKey = (char)KeyInterop.VirtualKeyFromKey(e.Key);

            // Add the pressed key to the existing text
            Host_Text.Text = currentText + pressedKey;

            // Mark the event as handled to prevent additional processing
            e.Handled = true;
        }

        public void Init_Cont()
        {
            PoweredBy.IsReadOnly = true;
            Connect_to_BLUME_Servers___.IsReadOnly = true;
        }
    }
}
