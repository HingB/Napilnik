using System;
using System.Collections.Generic;
using System.Linq;

namespace Store
{
    public class Cart
    {
        private Order _order;
        private Shop _shop;
        private List<Cell> _cells = new List<Cell>();

        public Cart(Shop shop)
        {
            _shop = shop;
        }

        public Order Order()
        {
            int linkLength = 20;

            PayLinkGenerator generator = new PayLinkGenerator();
            _order = new Order(generator.GenerateString(linkLength));

            return _order;
        }

        public void Add(Good newGood, int count)
        {
            Cell newCell = new Cell(newGood, count);
            var good = _shop.Cells.FirstOrDefault(good => good.Good == newGood);

            if (count > good.Count)
            {
                throw new ArgumentOutOfRangeException();
            }


            int cellIndex = _cells.FindIndex(good => good.Good == newGood);

            if (cellIndex == -1)
                _cells.Add(newCell);
            else
                _cells[cellIndex].Merge(newCell);
        }
    }
}
