namespace WordSorter.ExternalMerge;

internal readonly struct Row
{
    public string Value { get; init; }
    public int StreamReader { get; init; }
}