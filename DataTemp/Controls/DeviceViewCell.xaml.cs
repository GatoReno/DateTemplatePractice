using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTemp.ViewModels.ViewCells;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTemp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceViewCell : ViewCell
    {
        public DeviceViewCell()
        {
            InitializeComponent();
            BindingContext = new DeviceViewCellViewModel();
        }
    }
}
