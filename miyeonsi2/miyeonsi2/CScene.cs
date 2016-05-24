using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    public class CScene
    {
        public List<String> theScript;
        public SortedList<String, string> theChoice;
        public CScene()
        {
            theScript = new List<string>();
            theChoice = new SortedList<string, string>();
        }
        public void AddScript( String aScript )
        {
            theScript.Add( aScript );
        }

        public void AddScript( String aScript, String name )
        {
            String temp = aScript.Replace( "{0}", name );
            theScript.Add(temp);
        }
        public void AddScript( String aScript, string aSceneNumber, int goScript)
        {
            theChoice.Add( aScript, aSceneNumber );
        }

        public void AddChoice( String aChoice)
        {
            
        }

        public void AddChoice( String aChoice, string aSceneNumber )
        {
            theChoice.Add( aChoice, aSceneNumber );
        }
    }
}
