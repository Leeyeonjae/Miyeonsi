using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C11Classroom : CScene
    {
        public C11Classroom()
        {
            AddScript( "일찐 : 너 친구 없냐? 밥도 왕따랑 먹고ㅋㅋㅋ" );
            AddScript( "오늘 전학 왔는데 당연한 거 아니야?" );
            AddScript( "일찐 : 어이가 없네. 내가 만만한가보다?" );
            AddScript( "네가 먼저 말 걸었잖아..." );
            AddScript( "일찐 : 걸지 않으면 시비를 털 수 없잖아." );
            AddScript( "뭐래는거야...." );
         
            AddChoice( "1. (일찐에게 들리지 않게 혼잣말을 한다.) ", "C13교실" );
        }
    }
}
