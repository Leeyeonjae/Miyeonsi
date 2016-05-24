using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C06Classroom : CScene
    {
        public C06Classroom()
        {
            AddScript( "아, 어떤 놈이. 퍽! " );
            AddScript( "END" );
        
            AddChoice( "1.처음으로", "교문" );
            AddChoice( "2.종료하기", "C06교실" );
        }
    }
}
