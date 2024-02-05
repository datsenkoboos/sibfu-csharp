using System;

internal class Transformator
{
	public int SerialNumber;
	public TransformatorType TransformType;
	public Transformator(int SerialNumber, TransformatorType TransformType)
	{
		this.SerialNumber = SerialNumber;
		this.TransformType = TransformType;
	}
}

enum TransformatorType
{
	Multiplier,
	Divider
}