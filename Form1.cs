using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDown1.Items.Add("叩頭蟲");
            domainUpDown1.Items.Add("吉丁蟲");
            domainUpDown1.Items.Add("鍬形蟲");
            domainUpDown1.Items.Add("獨角仙");
            domainUpDown1.Items.Add("寬尾鳳蝶");
            domainUpDown1.SelectedIndex = 0;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            string[] msg = new string[] {"胸腹間有彈器可以瞬間彈跳，以利翻身或避敵。",
                                        "吉丁蟲被稱為「飛舞的寶石」。",
                                        "頭上具有一對鹿角狀大顎，是牠們禦敵的武器。",
                                        "因頭部有大角故稱為獨角仙，是台灣第二大甲蟲。",
                                        "有「國蝶」之稱，被列為瀕臨絕種的一級保護物種。"};
            pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\insect\images\" + domainUpDown1.SelectedItem.ToString() + ".jpg");
            label1.Text = msg[domainUpDown1.SelectedIndex];
        }
    }
}
