using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C07Classroom : CScene
    {
        public C07Classroom()
        {
            AddScript( "선생님: 수업을 시작합니다." );
            AddChoice( "(수업을 진행한다.)", "C08교실" );
           
        }
    }
}
