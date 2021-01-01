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

        public void Add(List<Container> containers)
        {
            while (containers.Count != 0)
            {
                Row row = new Row();
                rows.Add(row);
                row.AddRefrigerated(containers);
            }
        }
    }
}
