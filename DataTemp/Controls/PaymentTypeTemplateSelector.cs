using System;
using Xamarin.Forms;

namespace DataTemp.Controls
{
    public class PaymentTypeTemplateSelector : DataTemplateSelector
    {
        public Xamarin.Forms.DataTemplate PaymentTemplate { get; set; }
        public Xamarin.Forms.DataTemplate DeviceTemplate { get; set; }

        protected override Xamarin.Forms.DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var pay = (Object)item;
            switch (pay.GetType().Name)
            {
                case "Devices":
                    return DeviceTemplate;
                case "DeviceViewCellViewModel":
                    return DeviceTemplate;
                default:
                    return PaymentTemplate;
            }
        }
    }
}
