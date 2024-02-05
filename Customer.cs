using System;

internal class Customer
{
	public string FullName;
	public byte GentleRate;
	public GentleSmartphone Smartphone;
	public Transformator TransformModule;

	public Customer(string FullName, byte GentleRate)
	{
		this.FullName = FullName;
		this.GentleRate = GentleRate;
	}
}