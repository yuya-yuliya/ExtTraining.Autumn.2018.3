﻿using System.Collections.Generic;
using System.Linq;

namespace No3.Solution.Calculators
{
    public class MedianCalculator : IAverageCalculator
    {
        public double Average(IEnumerable<double> values)
        {
            var sortedValues = values.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}
