using System;
using System.Windows.Forms;
using GameWer.SDK;

namespace GameWer.UI.UniversalDevblog
{
    public partial class Form1 : Form, IGameWerForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Show();
            this.Activate();
        }

        public Boolean HasClosed => false;///throw new NotImplementedException();

        public void OnApplicationState(String state)
        {
            throw new NotImplementedException();
        }

        public void OnException(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void OnIncomingBanned(String reason, DateTime finish_at)
        {
            throw new NotImplementedException();
        }

        public void OnIncomingCode(String code)
        {
            throw new NotImplementedException();
        }

        public void OnIncomingSteamID(UInt64 steamid)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkAuthSuccess()
        {
            throw new NotImplementedException();
        }

        public void OnNetworkConnected()
        {
            throw new NotImplementedException();
        }

        public void OnNetworkDisconnected(String reason)
        {
            throw new NotImplementedException();
        }

        public void OnUpdate()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(Object sender, EventArgs e)
        {

        }
    }
}
