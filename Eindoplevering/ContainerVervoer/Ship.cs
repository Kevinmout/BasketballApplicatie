using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerVervoer
{
    public class Ship
    {
        private bool bValuable;
        public int Weight { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        private int unevenRowWidth;
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



        public void CheckWidthEvenOrUneven() //done
        {
            if (Width % 2 == 0) // uneven or even
            {
                unevenRowWidth = 0;
            }
            else
            {
                unevenRowWidth = 1;
            }
        }



        public List<Container> CheckDivisibleByWidth(List<Container> containers)
        {
            if(containers.Count % Width == 0)
            {
                containers = containers.OrderByDescending(w => w.Weight).ToList();
            }
            else
            {
                FillWithDummyContainers(containers);
                containers = containers.OrderByDescending(w => w.Weight).ToList();
            }
            return containers;
        }

        public void FillWithDummyContainers(List<Container> containers)
        {
            while (containers.Count % Width != 0)
            {
                containers.Add(new Container
                {
                    Weight = 0
                });
            }
        }


        public List<Container> ListForFirstRow(List<Container> cc, List<Container> cv)
        {
            List<Container> containersForFirstRow = new List<Container>();
            cv = cv.GetRange(0, Width).ToList();
            containersForFirstRow.AddRange(cc);
            containersForFirstRow.AddRange(cv);
            return containersForFirstRow;
        }



        public List<Container> ListForLastRow(List<Container> cn, List<Container> cv)
        {
            // make list of containers to fill the last row
            List<Container> containersForLastRow = new List<Container>();
            List<Container> cnFirst = new List<Container>();
            List<Container> cnEnd = new List<Container>();
            cnFirst = cn.GetRange(0, Width ).ToList();
            cv = cv.GetRange(0, Width).ToList();
            if (cn.Count > Width)
            {
                cnEnd = cn.GetRange(Width, cn.Count - Width).ToList();
            }
            containersForLastRow.AddRange(cnFirst);
            containersForLastRow.AddRange(cv);
            containersForLastRow.AddRange(cnEnd);
            return containersForLastRow;
        }

        public void AddFirstLastRow(List<Container> listForLastRow)
        {
            bValuable = true;
            Row row = new Row(listForLastRow,unevenRowWidth,Width,Height, bValuable);
            rows.Add(row);
            SortRow(row, listForLastRow);
            row.AvailableSpace();
            row.EvenOrUnevenHeight();
            row.AddStacks();
            row.FillStacks();
        }

        public void AddRow(List<Container> containers)
        {
            bValuable = false;
            containers = containers.OrderByDescending(w => w.Weight).ToList();
            while (containers.Count != 0)
            {
                Row row = new Row(containers, unevenRowWidth, Width, Height, bValuable);
                rows.Add(row);
                SortRow(row, containers);
                row.AvailableSpace();
                row.EvenOrUnevenHeight();
                row.AddStacks();
                if(row.FillStacks() == false)
                {
                    foreach (Row item in rows.ToList())
                    {
                        rows.Remove(item);
                    }
                    break;
                }
            }
        }



        public void SortRow(Row row, List<Container> containers)
        {
            //row.AvailableSpace();
            //row.EvenOrUnevenHeight(); // chooses between IndexLevellerEven and IndexLevellerUneven
            ////row.AddStack(); //Add stack
            //var stackBuild = row.BuildStack(); // call method BuildStack to build stack. FillTempLists to create leftContainers and rightContainers than we call method Sort to sort the containers
            //if (stackBuild != null)
            //{
            //    //remember stack and add to new row
            //    FillStackNewRow(stackBuild, containers);

            //}
            //if (row.CheckContainersLeft() == true)
            //{
            //    SortRow(row, containers);
            //}
        }






        //public void PlaceContainersOnShip(Row row, List<Container> containersLeft)
        //{
        //    if (row.NextRow == true)
        //    {
        //        // make new row
        //        // add stack
        //        //CheckContainersLeft(containers);

        //    }
        //    else
        //    {
        //        // Go further with existing stack and row
        //    }
        //}


    }
}
