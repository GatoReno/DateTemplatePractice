using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using DataTemp.Models;
using DataTemp.ViewModels.ViewCells;
using Xamarin.Forms;

namespace DataTemp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand LoadChargesAndPaymentsCommand { get; set; }
        public ObservableCollection<Object> PaymentsAndDevices { get; set; }
        public ICommand OnRefreshCommand { get; set; }
        public ICommand OnCallUserDialogsCommand { get; set; }
        public ICommand DeviceCommand { get; set; }

        public MainViewModel()
        {
            OnRefreshCommand = new Command(async () => await RefreshCommand());
            PaymentsAndDevices = new ObservableCollection<Object>();
            LoadChargesAndPaymentsCommand = new Command(async () => await RefreshCommand());
            LoadChargesAndPaymentsCommand.Execute(null);
            DeviceCommand = new Command<object>(OnDeviceCommnad);
            OnCallUserDialogsCommand = new Command(async () => await CallUserDialogsCommand());
        }

        private async Task CallUserDialogsCommand()
        {
            UserDialogs.Instance.ShowLoading("Loading ... ");
            await Task.Delay(3000);
            UserDialogs.Instance.HideLoading();
        }

        private void OnDeviceCommnad(object obj)
        {
            Console.WriteLine($"U w U {obj.GetType()}");
        }
        private async Task RefreshCommand()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(.5));
            PaymentsAndDevices.Clear();
            Random rdn = new Random();
            for (int i = 0; i < 2; i++)
            {

                PaymentsAndDevices.Add(new Payments()
                {

                    Name = "I'm a payment"
                });
            }
            for (int i = 0; i < 2; i++)
            {

                PaymentsAndDevices.Add(new Devices()
                {
                    Number = rdn.Next().ToString(),
                    Name = "I'm a device",
                    DeviceCommand = DeviceCommand
                });

            }
            IsRefreshing = false;
        }

    }
}
