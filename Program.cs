using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run(
    [
        typeof(Benchmarks<ValueItem>),
        typeof(Benchmarks<BigValueItem>),
        typeof(Benchmarks<ReferenceItem>),
        typeof(Benchmarks<BigReferenceItem>),
    ],
    DefaultConfig.Instance
        .WithOption(ConfigOptions.JoinSummary, true)
        .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.Declared)));

public interface IItem<TSelf> where TSelf : IItem<TSelf>
{
    static abstract TSelf Create(bool isActive);
    bool IsActive { get; }
}

public record ReferenceItem(bool IsActive) : IItem<ReferenceItem>
{
    public static ReferenceItem Create(bool isActive) => new(isActive);
}

public record BigReferenceItem(SomeOtherData OtherData, bool IsActive) : IItem<BigReferenceItem>
{
    public static BigReferenceItem Create(bool isActive) => new(new SomeOtherData(), isActive);
}

public readonly record struct ValueItem(bool IsActive) : IItem<ValueItem>
{
    public static ValueItem Create(bool isActive) => new(isActive);
}

public readonly record struct BigValueItem(SomeOtherData OtherData, bool IsActive) : IItem<BigValueItem>
{
    public static BigValueItem Create(bool isActive) => new(new SomeOtherData(), isActive);
}

[InlineArray(64)]
public struct SomeOtherData
{
    private byte element;
}

[MemoryDiagnoser(false)]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
[HideColumns("Job")]
public class Benchmarks<TItem>
    where TItem : IItem<TItem>
{
    private const int ItemCount = 1000;
    private static readonly TItem[] ItemArray = GenerateItems().ToArray();
    private static readonly List<TItem> ItemList = GenerateItems().ToList();
    private static IEnumerable<TItem> GenerateItems()
    {
        var rng = new Random(0);
        for (var i = 0; i < ItemCount; i++)
        {
            yield return TItem.Create(rng.Next(2) % 2 == 0);
        }
    }

    [Benchmark(Baseline = true)]
    public List<TItem> Array_Linq() =>
        ItemArray.Where(x => x.IsActive).ToList();

    [Benchmark]
    public List<TItem> Array_Loop()
    {
        var result = new List<TItem>();

        foreach (var data in ItemArray)
        {
            if (data.IsActive)
            {
                result.Add(data);
            }
        }

        return result;
    }

    [Benchmark]
    public List<TItem> Generator_Linq() =>
        GenerateItems().Where(x => x.IsActive).ToList();

    [Benchmark]
    public List<TItem> Generator_Loop()
    {
        var result = new List<TItem>();

        foreach (var data in GenerateItems())
        {
            if (data.IsActive)
            {
                result.Add(data);
            }
        }

        return result;
    }

    [Benchmark]
    public List<TItem> List_Linq() =>
        ItemList.Where(x => x.IsActive).ToList();

    [Benchmark]
    public List<TItem> List_Loop()
    {
        var result = new List<TItem>();

        foreach (var data in ItemList)
        {
            if (data.IsActive)
            {
                result.Add(data);
            }
        }

        return result;
    }
}
