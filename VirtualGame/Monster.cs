using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Workflow.ComponentModel.Design;

namespace VirtualGame
{
    public class Monster
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int hp;

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

       // public Image iamge;

        private int xOriginalLocation, yOriginalLocation;


        public int XOriginalLocation
        {
            get { return xOriginalLocation; }
            set { xOriginalLocation = value; }
        }

        public int YOriginalLocation
        {
            get { return yOriginalLocation; }
            set { yOriginalLocation = value; }
        }

        private int xCurrentLocation, yCurrentLocation;

        public int XCurrentLocation
        {
            get { return xCurrentLocation; }
            set { xCurrentLocation = value; }
        }

        public int YCurrentLocation
        {
            get { return yCurrentLocation; }
            set { yCurrentLocation = value; }
        }
        public Monster()
        {
        }
        public Monster(string name, int hp, string image, int xOriginalLocation, int yOriginalLocation, int xCurrentLocation, int yCurrentLocation)
        {
            this.name = name;
            this.hp = hp;
            this.image = image;
            this.xOriginalLocation = xOriginalLocation;
            this.yOriginalLocation = yOriginalLocation;
            this.xCurrentLocation = xCurrentLocation;
            this.yCurrentLocation = yCurrentLocation;
        }
        public void Attack()
        {

        }
    }
}
