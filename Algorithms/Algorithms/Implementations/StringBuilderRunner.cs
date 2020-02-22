using Algorithms.Implementations.MyOwnStringBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Implementations
{
    public class StringBuilderRunner
    {
        public StringBuilderRunner()
        {

        }

        public string ExecuteStringBuilder()
        {
            var stringBuilder = new VicDStringBuilder();

            for (int i = 0; i < 100; i++)
            {
                stringBuilder.Append($"Text{i}-");
            }

            return stringBuilder.ToString();
        }
    }
}
