using System;

namespace DesignPatterns.Patterns.Structural.Adapter
{
    public class ArrayFormatter
    {
        public string Format(string[] array)
        {
            var result = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    result += $"{array[i]}, ";
                }
                else
                {
                    result += array[i];
                }
            }

            return result;
        }
    }
}
