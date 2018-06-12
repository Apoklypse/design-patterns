using System.Collections.Generic;

namespace DesignPatterns.Patterns.Structural.Adapter
{
    public interface IListFormatter
    {
        string Format(List<string> list);
    }
}
