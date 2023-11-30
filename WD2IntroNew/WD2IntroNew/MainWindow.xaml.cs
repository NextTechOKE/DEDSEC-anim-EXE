﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WD2IntroNew
{
    public partial class MainWindow : Window
    {
        private string HostText = "fdfb:4503:4d58::/48";
        private string UserText = "mrcs_pyhooma";
        private string PassText = "*********";
        private int currentPosition = 0;
        private bool inputEnabled = true;

        public MainWindow()
        {
            InitializeComponent();
            Init_Cont();
            DisplayCommand();
            PreviewKeyDown += MainWindow_PreviewKeyDown;
        }

        private async void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // If input is disabled, do nothing
            if (!inputEnabled)
                return;

            // Mark the event as handled to prevent additional processing
            e.Handled = true;

            // Handle the key press event and update the TextBox text
            currentPosition = (currentPosition + 1) % (HostText.Length + UserText.Length + PassText.Length);

            // Display the current portion of the command string
            DisplayCommand();

            // If currentPosition reaches the end of the strings, disable input
            if (currentPosition == HostText.Length + UserText.Length + PassText.Length)
            {
                inputEnabled = false;
                Debug.WriteLine("Disable input");
                YourFunction(); // Call your custom function here
            }
        }

        private void DisplayCommand()
        {
            // Display the current portion of the command string
            if (currentPosition < HostText.Length)
            {
                Host_Text.Text = HostText.Substring(0, currentPosition + 1);
            }
            else if (currentPosition < HostText.Length + UserText.Length)
            {
                User_Text.Text = UserText.Substring(0, currentPosition - HostText.Length + 1);
            }
            else if (currentPosition < HostText.Length + UserText.Length + PassText.Length)
            {
                Pass_Text.Text = new string('*', currentPosition - HostText.Length - UserText.Length + 1); // Mask the password
            }
        }


        private void YourFunction()
        {
            // Implement your custom function logic here
            MessageBox.Show("All strings typed. Calling custom function.");
        }

        public void Init_Cont()
        {
            PoweredBy.IsReadOnly = true;
            Connect_to_BLUME_Servers___.IsReadOnly = true;
        }
    }
}