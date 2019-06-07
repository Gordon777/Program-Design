using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Gomoku
{
    class board
    {
        private static readonly Point nomatchnode = new Point(-1, -1);
        private static readonly int offset = 75;///距離邊邊距離
        private static readonly int noderadius = 10;///距離多近
        private static readonly int nodedisttance = 75;///點雨點距離
        public bool Canbeplace(int x, int y)
        {
            Point nodeId = findtheclosetnode(x, y); ///todo;找出最近的節點(Node)
            Point nodeld = findtheclosetnode(x, y);
            ///todo:如果沒有的話，回傳false
            if (nodeld == nomatchnode)
                return false;
            ///todo:如果有的化，檢查棋子是否存在

            return true;
        }
        private Point findtheclosetnode(int x,int y)
        {
            int nodeIdx = findtheclosetnode(x);
            if (nodeIdx == -1)
                return nomatchnode;
            int nodeIdy = findtheclosetnode(y);
            if (nodeIdy == -1)
                return nomatchnode;
            return new Point(nodeIdx, nodeIdy);
        }
        private int findtheclosetnode(int pos)
        {
            if (pos < offset - noderadius)
                return -1;
            pos -= offset;
            int quotient = pos / nodedisttance;///商數
            int remainder = pos % nodedisttance;///餘數

            if (remainder <= noderadius)

                return quotient;

            else if (remainder >= nodedisttance - noderadius)
                return quotient + 1;
            else
                return -1;

        }
    }
}
