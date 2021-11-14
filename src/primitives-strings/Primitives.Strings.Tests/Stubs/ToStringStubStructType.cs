namespace PrimeFuncPack.Primitives.Tests;

internal readonly struct ToStringStubStructType
{
    private readonly string? toStringValue;

    public ToStringStubStructType(string? toStringValue)
        => this.toStringValue = toStringValue;

    public override string? ToString()
        => toStringValue;
}
