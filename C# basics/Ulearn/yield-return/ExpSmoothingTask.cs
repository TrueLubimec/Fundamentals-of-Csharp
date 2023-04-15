using System.Collections.Generic;
using System.Linq;

namespace yield
{
	public static class ExpSmoothingTask
	{
		public static IEnumerable<DataPoint> SmoothExponentialy(this IEnumerable<DataPoint> data, double alpha)
		{
			
			while(true)
			{

				var expSmoothedY = (alpha * point.OriginalY) + ((1 - alpha) * previousPoint.ExpSmoothedY);

                yield return data;
			}
			yield return data;
		}
	}
}