using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CanExecuteApp
{
    public class MainWindowViewModel : ObservableObject
    {
        public ICommand ValidateCommand
        {
            get
            {
                return new RelayCommand(o => Validate());
            }
        }

        public ICommand UploadCommand
        {
            get
            {
                return new RelayCommand(o => Upload(), o => CanUploadExecute());
            }
        }

        private ObservableCollection<Order> orders;
        public ObservableCollection<Order> Orders
        {
            get
            {
                return orders ?? (orders = new ObservableCollection<Order>());
            }
            set
            {
                SetProperty(ref orders, value);
            }
        }

        private bool isValidated;
        public bool IsValidated
        {
            get
            {
                return isValidated;
            }
            set
            {
                SetProperty(ref isValidated, value);
            }
        }

        public MainWindowViewModel()
        {

        }

        private void Validate()
        {
            IsValidated = !IsValidated;
        }

        private void Upload()
        {
            MessageBox.Show("Upload");
        }

        private bool CanUploadExecute()
        {
            return IsValidated;
        }
    }
}
