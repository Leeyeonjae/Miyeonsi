using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miyeonsi2
{
    public partial class Form1 : Form
    {
        CSceneManager theSM;

        public Form1()
        {
            InitializeComponent();
            theSM = new CSceneManager();

            CScene tmpS1 = new C01SchoolGate();
            theSM.AddScene( "교문", tmpS1 );

            CScene tmpS2 = new C02Hallway();
            theSM.AddScene( "C02복도", tmpS2 );

            CScene tmpS3 = new C03Classroom();
            theSM.AddScene( "C03복도", tmpS3 );

            CScene tmpS4 = new C04Classroom();
            theSM.AddScene( "C04교실", tmpS4 );

            CScene tmpS5 = new C05Classroom();
            theSM.AddScene( "C05교실", tmpS5 );

            CScene tmpS6 = new C06Classroom();
            theSM.AddScene( "C06교실", tmpS6 );

            CScene tmpS7 = new C07Classroom();
            theSM.AddScene( "C07교실", tmpS7 );

            CScene tmpS8 = new C08Classroom();
            theSM.AddScene( "C08교실", tmpS8 );

            CScene tmpS9 = new C09Cafe();
            theSM.AddScene( "C09급식", tmpS9 );

            CScene tmpS10 = new C10Cafe();
            theSM.AddScene( "C10급식", tmpS10 );

            CScene tmpS11 = new C11Classroom();
            theSM.AddScene( "C11교실", tmpS11 );

            CScene tmpS12 = new C12Classroom();
            theSM.AddScene( "C12교실", tmpS12 );

            CScene tmpS13 = new C13Classroom();
            theSM.AddScene( "C13교실", tmpS13 );


            theSM.theRootIndex = "교문";
            theSM.theCurrentIndex = "교문";

            bChoice1.Visible = false;
            bChoice2.Visible = false;
            bChoice3.Visible = false;

        }

        private void ViewScene()
        {
            scriptCount = 0;
            CScene tmpScene = theSM.GetCurrentScene();
            lSubscript.Text = tmpScene.theScript[ 0 ];
            Button[] tmpBtn = { bChoice1, bChoice2, bChoice3 };
            int i = 0;
            foreach( KeyValuePair<string, string> iter in tmpScene.theChoice )
            {
                tmpBtn[ i ].Text = iter.Key;
                i++;

                if(i >= tmpBtn.Length )
                {
                    break;
                }
            }

            bChoice1.Visible = false;
            bChoice2.Visible = false;
            bChoice3.Visible = false;
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            ViewScene();
            
        }

        private void bChoice1_Click( object sender, EventArgs e )
        {
            Button[] tmpBtn = { bChoice1, bChoice2, bChoice3 };
            CScene tmpScene = theSM.GetCurrentScene();
            string tmpIndex = tmpScene.theChoice[ tmpBtn[ 0 ].Text ];
            theSM.SelectChoice( tmpIndex, 0 );

            ViewScene();
        }

        private void bChoice2_Click( object sender, EventArgs e )
        {
            Button[] tmpBtn = { bChoice1, bChoice2, bChoice3 };
            CScene tmpScene = theSM.GetCurrentScene();
            string tmpIndex = tmpScene.theChoice[ tmpBtn[ 1 ].Text ];
            theSM.SelectChoice( tmpIndex, 1 );
            ViewScene();
        }

        private void bChoice3_Click( object sender, EventArgs e )
        {
            Button[] tmpBtn = { bChoice1, bChoice2, bChoice3 };
            CScene tmpScene = theSM.GetCurrentScene();
            string tmpIndex = tmpScene.theChoice[ tmpBtn[ 2 ].Text ];
            theSM.SelectChoice( tmpIndex, 2 );
            ViewScene();
        }

        int scriptCount = 0;

        private int RunScript()
        {
            Button[] tmpBtn = { bChoice1, bChoice2, bChoice3 };

            scriptCount++;
            CScene tmpScene = theSM.GetCurrentScene();
            if( scriptCount >= tmpScene.theScript.Count )
            {
                lSubscript.Text = tmpScene.theScript[ tmpScene.theScript.Count - 1 ];

                int i;
                for( i = 0; i < 3; i++ )
                {
                    if( i < tmpScene.theChoice.Count ) tmpBtn[ i ].Visible = true;
                    else tmpBtn[ i ].Visible = false;
                }
            }
            else
            {
                lSubscript.Text = tmpScene.theScript[ scriptCount ];

                bChoice1.Visible = false;
                bChoice2.Visible = false;
                bChoice3.Visible = false;
            }

            return (1);
        }

        private void lSubscript_Click( object sender, EventArgs e )
        {
            RunScript();
        }

        private void Form1_MouseDown( object sender, MouseEventArgs e )
        {
            RunScript();
        }

        private void Form1_KeyDown( object sender, KeyEventArgs e )
        {
            if( e.KeyCode == Keys.T )
            {

            }
        }


    }
}
