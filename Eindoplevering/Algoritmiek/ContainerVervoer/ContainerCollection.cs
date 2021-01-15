using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerVervoer
{
    public class ContainerCollection
    {
        private int width;
        private int height;
        private List<Container> cn;
        public List<Container> GetCn()
        {
            return cn;
        }

        private List<Container> cc;
        public List<Container> GetCc()
        {
            return cc;
        }

        private List<Container> cv;
        public List<Container> GetCv()
        {
            return cv;
        }

        public ContainerCollection(int width, int height)
        {
            cn = new List<Container>();
            cv = new List<Container>();
            cc = new List<Container>();
            this.width = width;
            this.height = height;
        }








        public void AddCc(Container container)
        {
            if (container.Weight >= 4 && container.Weight <= 30)
            {
                cc.Add(container);
            }


        }

        public void AddCv(Container container)
        {
            if (container.Weight >= 4 && container.Weight <= 30)
            {
                cv.Add(container);
            }
        }


        public void AddCn(Container container)
        {
            if (container.Weight >= 4 && container.Weight <= 30)
            {
                cn.Add(container);
            }
        }


        public void ErrorHandler()
        {

        }
    }

}
