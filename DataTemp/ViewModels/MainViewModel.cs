using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
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
        public MainViewModel()
        {
            OnRefreshCommand = new Command(async () => await RefreshCommand());
            PaymentsAndDevices = new ObservableCollection<Object>();
            LoadChargesAndPaymentsCommand = new Command(async () => await RefreshCommand());
            LoadChargesAndPaymentsCommand.Execute(null);
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
                    Name = "I'm a device"
                });


                //PaymentsAndDevices.Add(new DeviceViewCellViewModel()
                //{
                //    Number = rdn.Next().ToString(),
                //    Name = "I'm a device"
                //});
            }
            IsRefreshing = false;
        }

    }
}
