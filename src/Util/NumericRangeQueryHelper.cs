using System;
using Lucene.Net.Search;

namespace Lucene.Net.Spatial.Util
{
    internal static class NumericRangeQueryHelper
    {
        internal static NumericRangeQuery NewDoubleRange(string field, int precisionStep, ValueType min, ValueType max, bool minInclusive, bool maxInclusive)
        {
            // There is a NewDoubleRange helper, but it only accepts decimals, not value type, so we create a helper to call the NewLongRange
            // which internally, does exactly the same as NewDoubleRange anyway, but allows passing of ValueType
            return NumericRangeQuery.NewLongRange(field, precisionStep, min, max, minInclusive, maxInclusive);
        }
    }
}
