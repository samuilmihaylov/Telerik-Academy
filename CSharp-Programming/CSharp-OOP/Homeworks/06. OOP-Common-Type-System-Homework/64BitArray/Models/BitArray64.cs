namespace _64BitArray.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BitArray64 : IEnumerable<int>
    {
        private const int Length = 64;
        private int[] bits = new int[Length];
        private ulong number;

        public BitArray64(ulong number)
        {
            string binary = ConvertDecimalToBinary(number);
            this.bits = BitsIntoArray(binary);
            this.Number = number;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }
            set
            {
                if (value < 0 || value > ulong.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Number must be in the allowed ulong range");
                }
                else
                {
                    this.number = value;
                }
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > Length - 1)
                {
                    throw new ArgumentOutOfRangeException("Index is in range [0 - 63]");
                }

                return this.bits[index];
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray)
        {
            return (firstArray.Equals(secondArray));
        }

        public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
        {
            return !(firstArray.Equals(secondArray));
        }

        public override bool Equals(object obj)
        {
            var otherArray = obj as BitArray64;

            for (int i = 0; i < Length; i++)
            {
                if (!otherArray[i].Equals(this[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.bits.GetHashCode();
        }

        public override string ToString()
        {
            return string.Join(string.Empty, this.bits);
        }

        private string ConvertDecimalToBinary(ulong number)
        {
            ulong systemBase = 2;
            string binary = string.Empty;

            while (number > 0)
            {
                ulong remainder = number % systemBase;
                number /= systemBase;
                binary = remainder.ToString() + binary;
            }

            return binary.ToString().PadLeft(64, '0');
        }

        private int[] BitsIntoArray(string binary)
        {
            int[] bitArray = new int[64];

            for (int i = 0; i < binary.Length; i++)
            {
                bitArray[i] = int.Parse(binary[i].ToString());
            }

            return bitArray;
        }
    }
}
