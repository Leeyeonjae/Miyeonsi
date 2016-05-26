using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C01SchoolGate : CScene
    {
        public C01SchoolGate()
        {
            AddScript( "여기가 내가 다닐 학교인가? >< " );
            AddScript( "음..근데 교실이 어디지..? T^T" );
            AddScript( "전학생이야? 내가 데려다줄까?" );
            AddChoice( "1. 우와 착한 사람이다. 잘생겼으니 따라간다." ,"C02복도");
            AddChoice( "2. 아뇨; 저 길 잘찾아요. 거부한다.", "C03복도" );
            AddChoice("3. 이상한 사람인 것 같다. 도망가자.", "C03복도");


        }
    }
}
