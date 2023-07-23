using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public partial class Testing : Form
    {
        bool flag = false;
        bool process = false;
        bool animate = false;
        bool init = true;
        public Testing()
        {
            InitializeComponent();
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                //process = true;
                flag = false;
                buttonPlay.Enabled = false;
                await Process();
                buttonPlay.Enabled = true;
                //process = false;
            }

            if (animate)
            {
                animate = false;
                buttonRun.Enabled = false;

                
                await GameUtils.AnimateWithMovement(() =>
                {
                    label1.Top -= 1;
                }, 800, 10);
                
                /*
                await GameUtils.Animate(new EventHandler((object s, EventArgs args) =>
                {
                    label1.Top--;
                }), 200, 10);
                */
                buttonRun.Enabled = true;

            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                flag = true;
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (!animate)
            {
                animate = true;
            }
        }

        private async Task Process()
        {
            await GameUtils.SetDuration(() =>
            {
                listBoxDisplay.Items.Add("HAI");
            }, 2000);
        }

        
    }
}
