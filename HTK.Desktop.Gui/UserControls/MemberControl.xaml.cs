using HTK.Desktop.Gui.ViewModels;
using HTK.Logging;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HTK.Desktop.Gui.UserControls
{
    /// <summary>
    /// Interaction logic for MemberControl.xaml
    /// </summary>
    public partial class MemberControl : UserControl
    {
        #region Fields
        private readonly MemberViewModel viewModel;
        private bool isLoaded; 
        #endregion

        #region Constructor
        public MemberControl()
        {
            InitializeComponent();

            // Initialize the viewModel
            viewModel = DataContext as MemberViewModel;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Initialize the viewModel when the view has been loaded, and prevents reinitialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Check if this has already been loaded
                if(!isLoaded)
                {
                    // Change isLoaded value
                    isLoaded = !isLoaded;

                    // Initialize the viewModel
                    await viewModel.InitializeAsync();
                }
            }
            catch(Exception ex)
            {
                // Output error message
                MessageBox.Show(ex.Message, "Der opstod en fejl.", MessageBoxButton.OK, MessageBoxImage.Error);

                // Log Exception
                await Logger.LogAsync(ex);
            }
        } 
        #endregion
    }
}