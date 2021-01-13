using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerVervoer
{
    public class Ship
    {

        private readonly List<Row> rows;
        public List<Row> GetRows()
        {
            return rows;
        }

        public Ship()
        {
            rows = new List<Row>();
        }



        public void AddRow(List<Container> containers)
        {
            int i = 0;
            while (i != 1)
            {
                Row row = new Row();
                rows.Add(row);
                row.AvailableSpace();
                i++;
            }
        }
    }
}
