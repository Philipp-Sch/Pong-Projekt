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

        public bool Collision(int xa1, int xa2, int ya1, int ya2, int xb1, int xb2, int yb1, int yb2)
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
            else if (XA1 < XB2 && XB2 < XA2)
                CollisionX = true;
            else if (XB1 < XA1 && XA2 < XB2)
                CollisionX = true;
            else if (XA1 < XB1 && XB2 < XA2)
                CollisionX = true;
            else
                CollisionX = false;

            if (YA1 < YB1 && YB1 < YA2)
                CollisionY = true;
            else if (YA1 < YB2 && YB2 < YA2)
                CollisionY = true;
            else if (YB1 < YA1 && YA2 < YB2)
                CollisionY = true;
            else if (YA1 < YB1 && YB2 < YA2)
                CollisionY = true;
            else
                CollisionY = false;

            if (CollisionX == true && CollisionY == true)
                return true ;
            else
                return false ;
        }

        public bool PunktStrichHorCollision(int xa,int ya,int xb1,int xb2,int yb)
        {
            //Punktkoordinaten
            XA1 = xa;
            YA1 = ya;
            //Strichkoordinaten
            XB1 = xb1;
            XB2 = xb2;
            YB1 = yb;

            if(XB1 <= XA1 && XB2 >= XA1)
                CollisionX = true;
            else
                CollisionY = false;

            if (YA1 == YB1)
                CollisionY = true;
            else
                CollisionY = false;

            if (CollisionX == true && CollisionY == true)
                return true;
            else
                return false;
        }//Horizontal

        public bool PunktStrichVerCollision(int xa, int ya, int xb, int yb1, int yb2)
        {
            //Punktkoordinaten
            XA1 = xa;
            YA1 = ya;
            //Strichkoordinaten
            XB1 = xb;
            YB1 = yb1;
            YB2 = yb2;

            if (XB1 == XA1)
                CollisionX = true;
            else
                CollisionY = false;

            if (YB1 <= YA1 && YB2 >= YA1)
                CollisionY = true;
            else
                CollisionY = false;

            if (CollisionX == true && CollisionY == true)
                return true;
            else
                return false;
        }//Vertiakal

        public bool PunktQuadratCollision(int xa,int ya,int xb1, int xb2, int yb1,int yb2)
        {
            //Punkt-Koordinaten
            XA1 = xa;
            YA1 = ya;
            //Kantenwerte Quadrates 
            XB1 = xb1;//Links
            XB2 = xb2;//Rechts
            YB1 = yb1;//Oben
            YB2 = yb2;//Unten

            if (PunktStrichHorCollision(XA1, YA1, XB1, XB2, YB1) == true)
                CollisionX = true;
            else
                CollisionX = false;

            if (PunktStrichVerCollision(XA1, YA1, XB1, YB1, YB2) == true)
                CollisionY = true;
            else
                CollisionY = false;

            if (CollisionX == true && CollisionY == true)
                return true;
            else
                return false;
        }
    }
}
