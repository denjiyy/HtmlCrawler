using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTML.Models.Contracts;

namespace HTML.Models.CustomStringBuilder
{
    public class CustomStringBuilder : IStringBuilder
    {
        public const int DefaultCapacity = 32;

        private char[] internalBuffer;

        public int Length { get; private set; }
        public int Capacity { get; private set; }

        public CustomStringBuilder(int capacity)
        {
            Capacity = capacity;
            internalBuffer = new char[capacity];
            Length = 0;
        }

        public CustomStringBuilder() : this(DefaultCapacity) { }

        public IStringBuilder Append(string value)
        {
            char[] data = value.ToCharArray();

            InternalEnsureCapacity(data.Length);

            foreach (char t in data)
            {
                internalBuffer[Length] = t;
                Length++;
            }

            return this;
        }

        public IStringBuilder Clear()
        {
            internalBuffer = new char[Capacity];
            Length = 0;
            return this;
        }

        public override string ToString()
        {
            var tmp = new char[Length];
            for (int i = 0; i < Length; i++)
            {
                tmp[i] = internalBuffer[i];
            }
            return new string(tmp);
        }

        private void InternalExpandBuffer()
        {
            Capacity *= 2;

            var tmpBuffer = new char[Capacity];
            for (int i = 0; i < internalBuffer.Length; i++)
            {
                char c = internalBuffer[i];
                tmpBuffer[i] = c;
            }
            internalBuffer = tmpBuffer;
        }

        private void InternalEnsureCapacity(int additionalLengthRequired)
        {
            while (Length + additionalLengthRequired > Capacity)
            {
                InternalExpandBuffer();
            }
        }
    }
}
