using System;
namespace Plugin.BLE.Abstractions.Contracts
{
    /// <summary>
    /// Criteria for filtering result from Bluetooth LE scans. A ScanFilter allows
    /// clients to restrict scan results to only those that are of interest to them.
    ///
    /// Current filtering on the following fields are supported:
    /// - Name of remote Bluetooth LE device.
    /// - Mac address of the remote device.
    /// - Manufacturer specific data which is the data associated with a particular manufacturer.
    /// - Service UUIDs which identify the bluetooth gatt services running on the device.
    /// - Service data which is the data associated with a service.
    /// 
    /// </summary>
    public class ScanFilter
    {

        public string DeviceName { get; set; }
        public string DeviceAddress { get; set; }
        public int? ManufacturerId { get; set; }
        public byte[] ManufacturerData { get; set; }
        public Guid? ServiceUuid { get; set; }
        public Guid? ServiceDataUuid { get; set; }
        public byte[] ServiceData { get; set; }
    }
}
