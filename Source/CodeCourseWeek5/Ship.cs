using System;
using System.Collections.Generic;

namespace CodeCourseWeek5
{
    class Ship
    {
        public List<Container> containers;
        public int id;

        public Ship(int id)
        {
            this.id = id;
            containers = new List<Container>();
        }

        public void AddContainer(Container container)
        {
            containers.Add(container);
        }
    }
}
