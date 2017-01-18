using System;

namespace OOP.Tasks {
	public class Television {
		public bool IsOn { get; set; }
		public bool HasSignal { get; set; }
		public int Channel { get; set; }
		public float Volume { get; set; }

		public string PrintStatus(Television x)
		{
			return string.Format("Television is on: {0}, Has signal: {1}, Channel: {2}, Volume: {3:0.00}",
				x.IsOn, x.HasSignal, x.Channel, x.Volume);
		}
	}
}
