using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C13Classroom : CScene
    {
        public C13Classroom()
        {
            AddScript( "..." );
            AddScript( "머리가 너무 아프다.." );
            AddScript( "양호실에 좀 가야겠어." );           
            AddChoice( "1.(교실 밖으로 나간다.) ", "C14교실" );
        }
    }
}
