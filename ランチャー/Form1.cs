using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ランチャー
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panels.Add(panelEx1);
            panels.Add(panelEx2);
            panels.Add(panelEx3);
            panels.Add(panelEx4);
            panels.Add(panelEx5);
            panels.Add(panelEx6);
            panels.Add(panelEx7);
            panels.Add(panelEx8);
            panels.Add(panelEx9);
            panels.Add(panelEx10);
            panels.Add(panelEx11);
            panels.Add(panelEx12);
            panels.Add(panelEx13);
            panels.Add(panelEx14);
            panels.Add(panelEx15);
        }
        List<PanelEx> panels = new List<PanelEx>();


        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            label1.BackColor = Color.Black;
            bLoadPath();
        }
     
     
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelEx1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> vs = new List<string>();
            foreach (var panel in panels)
                vs.Add(panel.GetPath());

            var xml = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));
                var sw = new System.IO.StreamWriter("C:\\Users\\" + Environment.UserName + "\\ドキュメント\\ショートカット");
                xml.Serialize(sw, vs);
                sw.Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bLoadPath();


        }
        public void bLoadPath()
        {

            var xml = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));
            var sr = new System.IO.StreamReader("C:\\Users\\" + Environment.UserName + "\\ドキュメント\\ショートカット");
            if (sr != null)
            {
                var paths = (List<string>)xml.Deserialize(sr);
                sr.Close();

                int i = 0;
                foreach (var panel in panels)
                {
                    panel.SetPath(paths[i]);
                    i++;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //delete押されたとき


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox1.Checked;
        }
    }
}
