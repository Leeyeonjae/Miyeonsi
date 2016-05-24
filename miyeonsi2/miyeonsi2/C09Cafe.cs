using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C09Cafe : CScene
    {
        public C09Cafe()
        {
            
            AddScript( "드디어 점심시간이구나! 누구랑 먹지?" );
         
            AddChoice( "1. 앞에 혼자 먹는 친구와 먹는다. ", "C10급식실" );
            AddChoice( "2. 혼자 먹어도 되지만 앞에 친구가 혼자 먹기에 같이 먹는다. ", "C10급식실" );
            AddChoice( "3. 나 혼자 먹는다. ", "C12교실" );
        }
    }
}
