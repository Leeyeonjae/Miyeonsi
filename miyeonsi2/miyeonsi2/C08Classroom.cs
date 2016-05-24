using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C08Classroom : CScene
    {
        public C08Classroom()
        {
            AddScript( "띠리리리 띠리리리 띠리리리리리리" );
            AddScript( "선생님 : 오늘은 여기까지" );
            AddScript( "시계 : (점심시간)" );
            AddScript( "아, 배고프다." );
         
            AddChoice( "1. (급식실로 향한다.) ", "C09급식실" );
        }
    }
}
