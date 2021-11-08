using System;
using Android.OS;
using ScanFilter = Android.Bluetooth.LE.ScanFilter;

namespace Plugin.BLE.Extensions
{
    internal static class ScanFilterExtension
    {
        public static ScanFilter ToNative(this Plugin.BLE.Abstractions.Contracts.ScanFilter filter)
        {
            var builder = new ScanFilter.Builder();
            if(filter.DeviceName != null)
            {
                builder.SetDeviceName(filter.DeviceName);
            }
            if (filter.DeviceAddress != null)
            {
                builder.SetDeviceAddress(filter.DeviceAddress);
            }
            if (filter.ManufacturerId != null && filter.ManufacturerData!=null)
            {
                builder.SetManufacturerData(filter.ManufacturerId.Value, filter.ManufacturerData);
            }
            if (filter.ServiceUuid != null)
            {
                builder.SetServiceUuid(ParcelUuid.FromString(filter.ServiceUuid.ToString()));
            }
            if (filter.ServiceDataUuid != null && filter.ServiceData != null)
            {
                builder.SetServiceData(ParcelUuid.FromString(filter.ServiceDataUuid.ToString()), filter.ServiceData);
            }
            return builder.Build();
        }

    }
}
