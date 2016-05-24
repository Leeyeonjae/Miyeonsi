using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C10Cafe : CScene
    {
        public C10Cafe()
        {
            
            AddScript( "안녕? 같이 먹자!" );
            AddScript( "왕따 : ..." );
            AddChoice( "1. 조용히 밥을 먹는다. ", "C11교실" );
           
        }
    }
}
