using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class Pathfinding
    {
        char[,] _grid;

        public char[,] Grid => _grid;
        public Pathfinding(string map)
        {
            
            string[] _map = map.Split('\n');
            char[,] _newgrid = new char[_map.Length, _map[0].Length];
            for (int i = 0; i < _map.Length; i++)
            {
                for(int j = 0; j < _map[i].Length; j++)
                {
                    _newgrid[i,j] = _map[i][j];
                }
            }
            _grid = _newgrid;
        }

        public bool IsOutOfBound(Vector2 vector2)
        {
           if(vector2.X<0|| vector2.Y < 0 || vector2.X > _grid.GetLength(0)-1 || vector2.Y > _grid.GetLength(1)-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Vector2> GetNeighboors(Vector2 vector2)
        {
            List<Vector2> retour=new List<Vector2>();
            for(int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if(!IsOutOfBound( new Vector2(vector2.X + i, vector2.Y + j))&&_grid[vector2.X + i, vector2.Y + j]=='_'&&!(i==0&&j==0))
                    {
                        retour.Add(new Vector2(vector2.X + i, vector2.Y + j));
                    }

                }
            }
            return retour;
        }

        public List<Vector2> GetNeighboors(Vector2 vector2, List<Vector2> exclude)
        {
            List<Vector2> retour = new List<Vector2>();
            exclude.Add(vector2);
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (!IsOutOfBound(new Vector2(vector2.X + i, vector2.Y + j)) && _grid[vector2.X + i, vector2.Y + j] == '_' && !(i == 0 && j == 0)&&!exclude.Contains(new Vector2(vector2.X + i, vector2.Y + j)))
                    {
                        retour.Add(new Vector2(vector2.X + i, vector2.Y + j));
                    }

                }
            }
            return retour;
        }

        public Path BreadthFirstSearch(Vector2 start, Vector2 destination)
        {
            Path path = new Path(start);
            List<Vector2> neighbours = new List<Vector2>();
            List<Vector2> exclude = new List<Vector2>();
            while (!path.IsComplete(start,destination))
            {
                neighbours = GetNeighboors(path.LastElement,exclude);
                foreach(Vector2 element in neighbours)
                {
                    if (!exclude.Contains(element))
                    {
                        path =new Path(path, element);
                    }
                    if (path.IsComplete(start, destination))
                    {
                        break;
                    }            
                }
                if (neighbours.Count == 0)
                {
                    break;
                }
            }
            return path;
        }

        public char GetCoord(Vector2 el)
        {
            return _grid[el.X, el.Y];
        }
    }

}
