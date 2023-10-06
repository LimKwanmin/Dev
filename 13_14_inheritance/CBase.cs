using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_inheritance
{
    internal class CBase
    {
        //이름, 그림, 펜에 대한 정의

        public string strName;

        protected Pen _Pen;

        public CBase() 
        {
            _Pen = new Pen(Color.Aqua,10);
        }
    }
}
