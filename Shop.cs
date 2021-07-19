using System;
using System.Collections.Generic;
using System.Linq;

namespace Store
{
    public class Shop
    {
        private readonly List<Cell> _cells = new List<Cell>();
        private Cart _cart;
        private Warehouse _warehouse;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;

            _warehouse.GoodDelived += OnGoodDelived;
        }

        public IReadOnlyList<IReadOnlyCell> Cells => _cells;

        public Cart Cart()
        {
            _cart = new Cart(this);

            return _cart;
        }

        private void OnGoodDelived(Good goodn, int count)
        {
            var newCell = new Cell(goodn, count);

            int cellIndex = _cells.FindIndex(cell => cell.Good == goodn);

            if (cellIndex == -1)
                _cells.Add(newCell);
            else
                _cells[cellIndex].Merge(newCell);
        }
    }
}
