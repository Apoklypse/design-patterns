using System.Collections.Generic;

namespace DesignPatterns.Patterns.Structural.Adapter
{
    public class ListFormatter : IListFormatter
    {
        ArrayFormatter formatter;

        public ListFormatter()
        {
            this.formatter = new ArrayFormatter();
        }

        public string Format(List<string> list)
        {
            var array = list.ToArray();

            return formatter.Format(array);
        }
    }
}
