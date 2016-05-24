using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    class C03Classroom : CScene
    {
        public C03Classroom()
        {
            AddScript( "센세 : 첫날부터 늦고 잘하는 짓이다!" );
            AddScript( "죄송합니다..(아까 그냥 말 들을걸..)" );
            AddChoice( "(선생님과 함께 교실에 들어간다.", "C04교실" );

        }
    }
}

