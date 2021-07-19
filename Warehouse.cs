using System;
using System.Collections.Generic;
using System.Linq;

namespace Store
{
    public class Warehouse
    {
        public event Action<Good, int> GoodDelived;

        public void Delive(Good good, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();

            GoodDelived?.Invoke(good, count);
        }
    }
}
