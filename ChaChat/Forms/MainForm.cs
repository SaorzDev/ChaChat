using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using UtilityTCP;

namespace ChaChat
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            UtilityTCP.Server server1 = new Server(IPAddress.Any, 21212);
            var chatRoom =  new ChaChat.Forms.ChatRoomForServerForm(server1);
            chatRoom.ShowDialog();
        }

        private void btnJoinRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
