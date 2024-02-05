using System;

internal class GentleSmartphone
{
	public int SerialNumber;
	public TactileSensor Sensor;
	public GentleSmartphone(int SerialNumber, byte Sensitivity)
	{
		this.SerialNumber = SerialNumber;
		this.Sensor = new TactileSensor(Sensitivity);
	}
}