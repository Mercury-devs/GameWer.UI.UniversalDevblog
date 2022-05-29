using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameWer.SDK;
using Microsoft.Win32;

namespace GameWer.UI.UniversalDevblog
{
    public partial class Form1 : Form, IGameWerForm
    {
        public Form1()
        {
            InitializeComponent();            
            this.Show();
            this.Activate();

            this.SetStatus("Starting...");
            OpacityController();

            notifyIcon1.Icon = this.Icon;
            Notify("Добро пожаловать!", "Мы подключаем вас к системе, ожидайте!");

            if (String.IsNullOrWhiteSpace(structures.DiscordChannelServer))
                DiscordChannelServer_StripMenuItem.Visible = false;
            if (String.IsNullOrWhiteSpace(structures.VKGroupServer))
                VKGroupServer_StripMenuItem.Visible = false;

            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
            notifyIcon1.Visible = true;
            //Task.Delay(5000).ContinueWith(_ =>
            //{
            //    notifyIcon1.Visible = true;
            //});
        }

        #region Vars    
        Structures structures = new Structures();
        private Point MouseHook;
        private bool _hasFinishState = false;
        private bool _hasClosed = false;
        #endregion

        #region Hooks
        public Boolean HasClosed => _hasClosed;
        public void OnApplicationState(String state)
        {
            string[] stateArgs = state.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            if (stateArgs.Length > 0)
            {
                switch (stateArgs[0])
                {
                    case "badVersion":
                        this.SetStatus("Version is outdated");
                        this._hasFinishState = true;
                        Notify("Устаревшая версия", "Вы используете старую версию :(\nЗапустите Updater.exe", ToolTipIcon.Warning);
                        break;
                    case "appVersion":
                        this.version_value.Text = "v" + ((stateArgs.Length > 1 ? stateArgs[1] : "unknown") + " [DEVBLOG]");
                        break;
                    default:
                        this.SetStatus(state);
                        break;
                }
            }
        }

        public void OnException(Exception ex)
        {
            File.AppendAllText("./ui.log", $"\n[{DateTime.Now}]: " + ex);
            MessageBox.Show(ex.ToString());
        }

        public void OnIncomingBanned(String reason, DateTime finish_at)
        {
            SetStatus("You are banned up " + finish_at);
            Notify("Отказ в подключении", "Вы забанены, мы не можем вас подключить!", ToolTipIcon.Error);
        }

        public void OnIncomingCode(String code)
        {
            SetStatus("You auth code: " + code);
        }

        public void OnIncomingSteamID(UInt64 steamid)
        {
            steamid_value.Text = steamid.ToString();
        }

        public void OnNetworkAuthSuccess()
        {
            SetStatus("Online");
            Notify("Вы - Online!", "Мы смогли подключить вас к системе, вы Online!\nПриятной игры!");
        }

        public void OnNetworkConnected()
        {
            SetStatus("Connected, auth...");
        }

        public void OnNetworkDisconnected(String reason)
        {
            SetStatus("Disconnected, reconnecting...");
        }

        public void OnUpdate()
        {
        }
        #endregion

        #region Metods

        /// <summary>
        /// Изменение статуса в GameWer [Текстовое поле]
        /// </summary>
        /// <param name="newStatus"></param>
        private void SetStatus(String newStatus)
        {
            if (_hasFinishState)
                return;
            status_value.Text = newStatus;
        }

        /// <summary>
        /// Метод отправки ошибки [Всплывающее окно]
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Description"></param>
        private void SendError(String Title, String Description)
        {
            MessageBox.Show(this, Description,
                           Title, MessageBoxButtons.OK,
                           MessageBoxIcon.Error,
                           MessageBoxDefaultButton.Button3, 0,
                           "https://discord.gg/ZuxcNXxbJG",
                           "https://discord.gg/ZuxcNXxbJG");
        }
        public void OpenRust()
        {
            DirectoryInfo WorkingDirectory = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent;

            if (!IsRustGame(WorkingDirectory))
            {
                //MessageBox.Show("Файл не найден, идем в реестр");
                #region Check Regedit

                RegistryKey registryRust = Registry.CurrentUser.OpenSubKey("GameWerAntiCheat");

                if (registryRust == null)
                {
                    // MessageBox.Show("Реестр не найден, просим указать путь");
                    String FilePath = GetRust();

                    WorkingDirectory = RegeditSaveAndGetDirectory(FilePath);
                    if (WorkingDirectory == null || WorkingDirectory.FullName == null || String.IsNullOrWhiteSpace(WorkingDirectory.FullName))
                    {
                        SendError("Неверный файл", $"Вы не указали путь к файлу {structures.FileRust}, мы не можем запустить игру!");
                        Application.Exit();
                        return;
                    }
                }
                else
                {
                    //MessageBox.Show("Реестр найден, проверяем файл!");
                    String FilePath = (String)registryRust.GetValue("pathRustGame");

                    FilePath = FilePath.Replace(@"\" + structures.FileRust, String.Empty);
                    //MessageBox.Show(FilePath);
                    if (FilePath == null || String.IsNullOrWhiteSpace(FilePath) || !IsRustGame(new DirectoryInfo(FilePath)))
                    {
                        //MessageBox.Show("Файл в реестре неверный, просим указать вручную!");

                        String NewFilePath = GetRust();
                        // MessageBox.Show($"Указали путь - {NewFilePath}");
                        WorkingDirectory = RegeditSaveAndGetDirectory(NewFilePath);
                        if (WorkingDirectory == null || WorkingDirectory.FullName == null || String.IsNullOrWhiteSpace(WorkingDirectory.FullName))
                        {
                            SendError("Неверный файл", $"Вы не указали путь к файлу {structures.FileRust}, мы не можем запустить игру!");
                            Application.Exit();
                            return;
                        }
                    }
                    else WorkingDirectory = RegeditSaveAndGetDirectory(FilePath);
                }

                #endregion
            }

            #region Start Game
            //  MessageBox.Show("Полученная директория, запуск файла игры в " + WorkingDirectory.FullName);
          //  try
            //{
                if (Process.GetProcessesByName("RustClient").Any()) return;  //// Доделать

                if (!String.IsNullOrWhiteSpace(structures.FileSupportRust))
                {
                    ProcessStartInfo startInfoHandler = new ProcessStartInfo();
                    startInfoHandler.WorkingDirectory = WorkingDirectory.FullName + "/";
                    startInfoHandler.FileName = $"{WorkingDirectory.FullName}\\{structures.FileSupportRust}";
                    Process.Start(startInfoHandler);
                }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.Arguments = "-show-screen-selector";
            startInfo.WorkingDirectory = WorkingDirectory.FullName + "/";
            startInfo.FileName = $"{WorkingDirectory.FullName}\\{structures.FileRust}";
            startInfo.UseShellExecute = false;
            Process.Start(startInfo).WaitForExit();


            //  }
            //  catch (Exception ex)
            //  {
            //      SendError($"Не удалось запустить {structures.FileRust}", $"В папке с {structures.FileRust} возможно отсутствует файл {(!String.IsNullOrWhiteSpace(structures.FileSupportRust) ? $"{structures.FileSupportRust} или" : "")} {structures.FileRust}, перенесите файл {structures.FileRust} в корневую папку с клиентом или свяжитесь с поддержкой");
            //     return;
            //  }

            #endregion
        }

        public Boolean IsRustGame(DirectoryInfo Folder)
        {
            FileInfo[] files = Folder.GetFiles(structures.FileRust, SearchOption.TopDirectoryOnly).ToArray();

            return files.Length > 0;
        }
        private DirectoryInfo RegeditSaveAndGetDirectory(String FilePath)
        {
            if (FilePath == null || String.IsNullOrWhiteSpace(FilePath)) return null;
            RegistryKey key = Registry.CurrentUser.CreateSubKey("GameWerAntiCheat");
            key.SetValue("pathRustGame", FilePath);
            key.Close();
            DirectoryInfo WorkingDirectory = new DirectoryInfo(FilePath);

            if (!IsRustGame(WorkingDirectory))
                if (!IsRustGame(WorkingDirectory.Parent))
                {
                    if (!IsRustGame(WorkingDirectory.Parent.Parent))
                    {
                        SendError("Неверный файл", $"Вы не указали путь к файлу {structures.FileRust}, мы не можем запустить игру!");
                        Application.Exit();
                        return null;
                    }
                    else WorkingDirectory = WorkingDirectory.Parent.Parent;
                }
                else WorkingDirectory = WorkingDirectory.Parent;

            return WorkingDirectory;
        }
        private String GetRust()
        {
            SendError($"Не найден {structures.FileRust}", $"Укажите путь к файлу {structures.FileRust}\nПерейдите в каталог с вашей игрой и выберите {structures.FileRust}");

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = $"{structures.FileRust}|{structures.FileRust}";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            return filePath.Replace(@"\" + structures.FileRust, String.Empty);
        }


        #region Tree
        /// <summary>
        /// Метод отправки Push-уведомления
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Description"></param>
        /// <param name="toolTipIcon"></param>
        /// <param name="Time"></param>
        private void Notify(String Title, String Description, ToolTipIcon toolTipIcon = ToolTipIcon.Info, Int32 Time = 10000)
        {
            notifyIcon1.ShowBalloonTip(
              Time,
              Title,
              Description,
              toolTipIcon
            );
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            // notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;


        }

        #endregion

        #region Opacity Controller
        private void OpacityController()
        {
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.2d) == 1)
                {
                    timer.Stop();
                    OpenRust();
                }

            });
            timer.Interval = 80;
            timer.Start();
        }
        #endregion

        #endregion

        #region Events
        private void Form1_Load(Object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _hasClosed = true;
        }
        private void pictureBox1_Click(Object sender, EventArgs e)
        {
            Process.Start(structures.DiscordSupportGameWer);
        }

        private void label1_Click(Object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_MouseMove(Object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                this.MouseHook = e.Location;
            else
                this.Location = new Point((Size)this.Location - (Size)this.MouseHook + (Size)e.Location);
        }

        #region StripsEvents
        private void CloseGameWer_StripMenuItem_Click(Object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Support_Get_StripMenuItem_Click(Object sender, EventArgs e)
        {
            Process.Start(structures.DiscordSupportGameWer);
            Notify("Поддержка GameWer", "Поддержка осуществляется в нашем Discrod-канале, мы направляем вас по ссылке, пожалуйста создайте тикет");
        }

        private void VKGroup_Get_StripMenuItem_Click(Object sender, EventArgs e)
        {
            Process.Start(structures.VKGroupGameWer);
        }

        private void DiscrodChannel_Get_StripMenuItem_Click(Object sender, EventArgs e)
        {
            Process.Start(structures.DiscordSupportGameWer);
        }

        private void DiscordChannelServer_StripMenuItem_Click(Object sender, EventArgs e)
        {
            Process.Start(structures.DiscordChannelServer);
        }

        private void VKGroupServer_StripMenuItem_Click(Object sender, EventArgs e)
        {
            Process.Start(structures.VKGroupServer);
        }
        #endregion

        #endregion
    }
}
