using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_0._1
{
    class Collider
    {
        int XA1;
        int XA2;
        int YA1;
        int YA2;

        int XB1;
        int XB2;
        int YB1;
        int YB2;

        bool CollisionX;
        bool CollisionY;

        public Collider()
        {

        }

        private bool Collision(int xa1, int xa2, int ya1, int ya2, int xb1, int xb2, int yb1, int yb2)
        {
            //Kantenwerte des Quadrates A
            XA1 = xa1;//Links
            XA2 = xa2;//Rechts
            YA1 = ya1;//Oben
            YA2 = ya2;//Unten
            //Kantenwerte Quadrates B
            XB1 = xb1;//Links
            XB2 = xb2;//Rechts
            YB1 = yb1;//Oben
            YB2 = yb2;//Unten

            if (XA1 < XB1 && XB1 < XA2)
                CollisionX = true;
            if (XA1 < XB2 && XB2 < XA2)
                CollisionX = true;
            if (XB1 < XA1 && XA2 < XB2)
                CollisionX = true;
            if (XA1 < XB1 && XB2 < XA2)
                CollisionX = true;
            else
                CollisionX = false;

            if (YA1 < YB1 && YB1 < YA2)
                CollisionX = true;
            if (YA1 < YB2 && YB2 < YA2)
                CollisionX = true;
            if (YB1 < YA1 && YA2 < YB2)
                CollisionX = true;
            if (YA1 < YB1 && YB2 < YA2)
                CollisionX = true;
            else
                CollisionX = false;

            if (CollisionX == true && CollisionY == true)
                return true ;
            else
                return false ;
        }
    }
}
