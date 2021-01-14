using System;
using System.Collections.Generic;
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
        
        
        public void AddCc()
        {
            for (int i = 0; i < ((height - 1) * width) ; i++)
            {
                Container container1 = new Container()
                {
                    Weight = 14,
                    IsRefrigerated = true
                };
                cc.Add(container1);
            }

        }

        public void AddCv()
        {
            for (int i = 0; i < 2*width; i++)
            {
                Container container1 = new Container()
                {
                    Weight = 17,
                    IsValuable = true
                };
                cv.Add(container1);
            }
        }


        public void AddCn()
        {
            Container container1 = new Container()
            {
                Weight = 16
            };
            //Container container2 = new Container()
            //{
            //    Weight = 16
            //};
            cn.Add(container1);
            cn.Add(container1);
            cn.Add(container1);
            cn.Add(container1);

            cn.Add(container1);
            cn.Add(container1);
            cn.Add(container1);
            cn.Add(container1);

            cn.Add(container1);
            cn.Add(container1);
            cn.Add(container1);
            cn.Add(container1);

            cn.Add(container1);
            cn.Add(container1);
            cn.Add(container1);
            cn.Add(container1);
            //cn.Add(container1);
            //cn.Add(container1);
            //cn.Add(container1);

            //cn.Add(container2);
            //cn.Add(container2);
            //cn.Add(container2);
            //cn.Add(container2);

        }
    }
}
