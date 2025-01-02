using System;

// Step 1: Define the Target Interface
// This is what the client expects.
public interface IUsbCCharger
{
    void ChargeWithUsbC();
}

// Step 2: Create the Adaptee
// This is the existing, incompatible class that needs to be adapted.
public class MicroUsbCharger
{
    public void ChargeWithMicroUsb()
    {
        Console.WriteLine("Charging with Micro-USB.");
    }
}

// Step 3: Create the Adapter
// The adapter makes the Micro-USB charger compatible with the USB-C charger interface.
public class MicroUsbToUsbCAdapter : IUsbCCharger
{
    private readonly MicroUsbCharger _microUsbCharger;

    // The adapter wraps a MicroUsbCharger instance.
    public MicroUsbToUsbCAdapter(MicroUsbCharger microUsbCharger)
    {
        _microUsbCharger = microUsbCharger;
    }

    // This method adapts the Micro-USB charging to USB-C.
    public void ChargeWithUsbC()
    {
        Console.WriteLine("Adapter converts USB-C to Micro-USB.");
        _microUsbCharger.ChargeWithMicroUsb();
    }
}
