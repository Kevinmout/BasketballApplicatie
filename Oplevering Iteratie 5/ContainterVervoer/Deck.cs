using System;
using System.Collections.Generic;
using System.Text;

namespace ContainterVervoer
{
    public class Deck
    {
        private readonly List<Row> rows;
        public List<Row> GetStacks()
        {
            return rows;
        }

        public Deck()
        {
            rows = new List<Row>();
        }

        public void Add()
        {
            Row row = new Row();
            rows.Add(row);
        }

        public void SortStacks()
        {

        }
    }
}
