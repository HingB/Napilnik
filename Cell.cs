using System;

namespace Store
{
    public class Cell : IReadOnlyCell
    {
        public Good Good { get; private set; }
        public int Count { get; private set; }

        public Cell(Good good, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();

            Good = good;
            Count = count;
        }

        public void Merge(Cell newCell)
        {
            if (newCell.Good != Good)
                throw new InvalidOperationException();

            Count += newCell.Count;
        }
    }

    public interface IReadOnlyCell
    {
        public Good Good { get; }
        public int Count { get; }
    }
}