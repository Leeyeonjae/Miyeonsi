using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C02Hallway : CScene
    {
        public C02Hallway()
        {
            AddScript( "자, 여기가 2학년 6반이야.^^" );
            AddScript( "감사합니다~! (뭐야 설레잖아 뭐야 잘생겼어 뭐야뭐야)" );
            AddScript( "친구들 다 착했으면좋겠다~ 두근두근!><" );
            AddChoice( "(조심스레 교실 문을 연다.)", "C04교실" );

           
        }
    }
}
