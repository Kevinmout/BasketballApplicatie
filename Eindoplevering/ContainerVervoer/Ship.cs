using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerVervoer
{
    public class Ship
    {
        public int Weight { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int UnevenRowWidth { get; set; }
        //private int unevenRowWidth;
        private readonly List<Row> rows;
        public List<Row> GetRows()
        {
            return rows;
        }

        public Ship()
        {
            rows = new List<Row>();
            Width = 4;
            Height = 4;
        }



        public void CheckWidthEvenOrUneven(List<Container> containers) //done
        {
            if (Width % 2 == 0) // uneven or even
            {
                UnevenRowWidth = 0;
            }
            else
            {
                UnevenRowWidth = 1;
            }
            CheckDivisibleByWidth(containers);
        }



        public void CheckDivisibleByWidth(List<Container> containers)
        {
            if(containers.Count % Width == 0)
            {
                containers = containers.OrderByDescending(w => w.Weight).ToList();
                AddRow(containers);
            }
            else
            {
                FillWithDummyContainers(containers);
                containers = containers.OrderByDescending(w => w.Weight).ToList();
                AddRow(containers);
            }
        }

        public void FillWithDummyContainers(List<Container> containers)
        {
            while(containers.Count % Width != 0)
            {
                containers.Add(new Container
                {
                    Weight = 0
                });
            }
        }







        public void AddRow(List<Container> containers)
        {
            Row row = new Row(containers, UnevenRowWidth);
            rows.Add(row);
            row.AvailableSpace();
            //row.EvenOrUnevenHeight();
            //PlaceContainersOnShip(row,containers);
        }



        public void PlaceContainersOnShip(Row row, List<Container> containersLeft)
        {
            if (row.NextRow == true)
            {
                // make new row
                // add stack
                //CheckContainersLeft(containers);

            }
            else
            {
                // Go further with existing stack and row
            }
        }


    }
}
