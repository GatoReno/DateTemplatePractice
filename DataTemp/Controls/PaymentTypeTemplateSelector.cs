using System;
using DataTemp.Models;
using Xamarin.Forms;

namespace DataTemp.Controls
{
    public class PaymentTypeTemplateSelector : DataTemplateSelector
    {
        public Xamarin.Forms.DataTemplate PaymentTemplate { get; set; }
        public Xamarin.Forms.DataTemplate DeviceTemplate { get; set; }

        protected override Xamarin.Forms.DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            if (item is Devices)
            {
                return DeviceTemplate;
            }
            else
            {
                return PaymentTemplate;
            }
        }
    }
}
