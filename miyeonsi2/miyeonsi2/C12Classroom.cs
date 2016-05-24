using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C12Classroom : CScene
    {
        public C12Classroom()
        {
            AddScript( "일찐 : (혼잣말로) 왜 신경쓰이게 혼자 먹고 난리야." );
            AddChoice( "1. 주위를 둘러보다 일찐과 마주치는 눈을 피한다. ", "C13교실" );
        }
    }
}
