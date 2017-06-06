using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pix
{
    public class Matrix<T>
    {
        protected T[,] _data;

        public Matrix(int width, int height)
        {
            _data = new T[width, height];
        }

        public T GetElement(int x, int y)
            => _data[x, y];

        public T SetElement(int x, int y, T data)
            => _data[x, y] = data;
    }
}
