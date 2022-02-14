using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    class Curve
    {

        List<Point> pointsList = new List<Point>();

        public List<Point> getPointList()
        {
            return pointsList;
        }

        public double Lenght(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.YCoordinate - point1.YCoordinate, 2) + Math.Pow(point2.XCoordinate - point1.XCoordinate, 2));
        }

        public double CalculateCurveLenght()
        {
            double sumOfLenghts = 0; //curve lenght

            for (int i = 0; i < pointsList.Count; i++)
            {
                if(pointsList.Count == 0 | pointsList.Count == 1)
                {
                    sumOfLenghts = 0;
                }

                if(i != pointsList.Count - 1 )
                {
                    sumOfLenghts += Lenght(pointsList[i], pointsList[i + 1]);
                    
                }
                 
            }
            return sumOfLenghts;
            
        }

        public Point LastAddedPoint()
        {
            return pointsList[pointsList.Count - 1];
        }
        public void AddPoint(Point addedPoint)
        {
            pointsList.Add(addedPoint);
        }

        public void RemovePoint(Point removedPoint)
        {
            pointsList.Remove(removedPoint);
        }

        public void RemovePoint(int x, int y)
        {
            for (int i = 0; i < pointsList.Count; i++)
            {
                if (pointsList[i].XCoordinate == x && pointsList[i].YCoordinate == y)
                {
                    pointsList.RemoveAt(i);
                }
            }
        }

        public bool Contains(int x, int y)
        {
            
            for(int i =0; i< pointsList.Count; i++)
            {
                if(pointsList[i].XCoordinate == x && pointsList[i].YCoordinate == y)
                {
                    return true;
                }
            }
            return false;

        }



    }
}
