namespace Arentheym.EnergieVergelijker.Domain;

public class Range<T>
    where T : IComparable<T>
{
    private T? Min { get; }

    private T? Max { get; }

    public Range(T? min, T? max)
    {
        if (min != null && max != null && min.CompareTo(max) > 0)
        {
            throw new ArgumentException("Min value cannot be greater than max value");
        }

        Min = min;
        Max = max;
    }

    public bool Contains(T value)
    {
        return Min != null && Max != null && value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
    }
}
