using System;
using System.Windows.Input;
using DataTemp.Abstractions;
using Xamarin.Forms;

namespace DataTemp.ViewModels.ViewCells
{
    public class DeviceViewCellViewModel : BaseViewModel, IDevice
    {
        public string Number
        {  
            get
            {
                return _numberDevice;
            }
            set
            {
                _numberDevice = value;
                OnPropertyChanged("Number");
             }
        }
        public string Name
        {
            get
            {
                return _nameDevice;
            }
            set
            {
                _nameDevice = value;
                OnPropertyChanged("Number");
            }
        }

        public ICommand DeviceCommand { get; set; }
        private string _nameDevice;
        private string _numberDevice;
         

        public DeviceViewCellViewModel()
        {
            DeviceCommand = new Command(OnDeviceCommnad);
        }

        private void OnDeviceCommnad()
        {
            
        }
    }
}
