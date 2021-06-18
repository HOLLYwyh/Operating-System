using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManangement
{
    class BitMap  //位图
    {
        private char[] map = new char[Constant.BlocksNumber];        //数组

        public BitMap()
        {
            for (int i=0; i<Constant.BlocksNumber;i++)
            {
                map[i] = '0';
            }
        }

        public bool assignBlock(int type)
        {
            int number = (type == Constant.File) ? 2 : 1;
            for(int i =0;i<Constant.BlocksNumber;i++)
            {
                if(map[i] == '0')
                {
                    number--;
                    map[i] = '1';
                }
                if(number == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void deleteBlock(int type)
        {
            int number = (type == Constant.File) ? 2 : 1;
            for (int i = 0; i < Constant.BlocksNumber; i++)
            {
                if (map[i] == '1')
                {
                    number--;
                    map[i] = '0';
                }
                if (number == 0)
                {
                    return;
                }
            }
        }

        public int getBlockNumber()
        {
            int number = 0;
            for(int i = 0;i< Constant.BlocksNumber;i++)
            {
                if(map[i] == '1')
                {
                    number++;
                }
            }
            return number;
        }
    }
}
