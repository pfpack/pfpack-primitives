#nullable enable

namespace PrimeFuncPack.Primitives.Tests
{
    internal sealed class ToStringStubRefType
    {
        private readonly string? toStringValue;

        public ToStringStubRefType(string? toStringValue)
            => this.toStringValue = toStringValue;

        public override string? ToString()
            => toStringValue;
    }
}
