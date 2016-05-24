using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C04Classroom : CScene
    {
        public C04Classroom()
        {
            AddScript( "전학생이 왔다. 오늘부터 너희랑 1년을 함께 할 {0}라고 한다. 잘해줘.", "제갈연재" );
            AddScript( "제갈연재 너는 맨 뒤 자고있는애 옆에 앉으렴." );
            AddScript( "유아인 : (...)자는중" );
            AddScript( "깨워아햐나..?" );
            AddChoice( "1. 저기..수업 시작했어 일어나렴!^^","C05교실" );
            AddChoice( "2. 감히 전학생이 왔는데 잠을 자고있어?!!!(시원하게 뒷통수를 갈긴다", "C06교실" );
            AddChoice( "3. 그냥 두자.. 무서운 애 같은데", "C07교실" );
        }
    }
}
