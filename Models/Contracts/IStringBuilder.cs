using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML.Models.Contracts
{
    public interface IStringBuilder
    {
        IStringBuilder Append(string value);
        IStringBuilder Clear();
        int Length { get; }
        int Capacity { get; }
    }
}
