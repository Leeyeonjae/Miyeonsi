using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miyeonsi2
{
    public class CSceneManager
    {
        public SortedList<string, CScene> theScenes;
        public SortedList<string, int> theSelectedIndex;
        public CSceneManager()
        {      
            theScenes = new SortedList<string, CScene>();
            theSelectedIndex = new SortedList<string, int>();
        }
        public void AddScene( string aName, CScene aScene )
        {
            theScenes.Add( aName, aScene );
        }

        public CScene GetCurrentScene()
        {
            return (theScenes[ theCurrentIndex ]);
        }

        public String GetCurrentSceneKey()
        {
            return (theScenes[theCurrentIndex]).ToString();
        }
        public void SelectChoice( string aIndex, int aSelectedIndex )
        {
            theSelectedIndex.Add( theCurrentIndex, aSelectedIndex );
            theCurrentIndex = aIndex;
        }


        public string theCurrentIndex;
        public string theRootIndex;

    }
}
