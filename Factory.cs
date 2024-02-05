using System;

internal class Factory
{
	public List<GentleSmartphone> Smartphones;
	public List<Customer> Customers;

	public Factory(List<Customer> Customers)
	{
		this.Customers = Customers;
		this.Smartphones = new List<GentleSmartphone>();
	}

	public void SaleSmartphone()
	{
		foreach(Customer cust in this.Customers)
		{
			byte custSen = cust.GentleRate;

			bool needT = false;
			TransformatorType neededTT = TransformatorType.Multiplier;
			if (cust.Smartphone != null) return;
			if (this.Smartphones.Count() <= 0) return;
			foreach (GentleSmartphone smar in this.Smartphones.ToList())
			{
				byte smarSen = smar.Sensor.Sensitivity;
				if (custSen >= smarSen / 1.5 && custSen <= 2 * smarSen)
				{
					cust.Smartphone = smar;
					this.Smartphones.Remove(smar);
					break;
				}
				else if (custSen >= smarSen / (1.5 * 2) && custSen <= 2 * smarSen && !needT)
				{
					needT = true;
					neededTT = TransformatorType.Multiplier;
				}
				else if (custSen >= smarSen / 1.5 && custSen <= 2 * 2 * smarSen && !needT)
				{
					needT = true;
					neededTT = TransformatorType.Divider;
				}
			}
			if (cust.Smartphone == null && needT)
			{
				Transformator trans = new Transformator(new Random().Next(0, 1000), neededTT);
				if (trans.TransformType == TransformatorType.Multiplier) custSen *= 2;
				else if (trans.TransformType == TransformatorType.Divider) custSen /= 2;

                if (this.Smartphones.Count() > 0)
                {
                    foreach (GentleSmartphone smar in this.Smartphones.ToList())
                    {
                        byte smarSen = smar.Sensor.Sensitivity;
                        if (custSen >= smarSen / 1.5 && custSen <= 2 * smarSen)
                        {
                            cust.Smartphone = smar;
                            this.Smartphones.Remove(smar);
                            break;
                        }
                    }
                }
            }
		}
		this.Smartphones.Clear();
	}
}