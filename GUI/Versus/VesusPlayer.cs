using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GUI.Ultils;
using GUI.MessageBoxes;
using GUI.MainGaime;
using DTO;

namespace GUI.Versus
{
    public partial class VesusPlayer : Form
    {
        private List<Image> List_BotImages;
        public VesusPlayer()
        {
            InitializeComponent();
            List_BotImages = new List<Image>();
        }
        //user for smooth screen
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;
                return createParams;
            }
        }
        private void VersusPlayer_Load(object sender, EventArgs e)
        {

            loadImages();
            DoubleBuffered = true;
            Lbl_Player.Text = string.Empty;
            Lbl_Player.Text = StringManagement.Vesus();
            Lbl_Player2.Text = string.Empty;
            Lbl_Player2.Text = StringManagement.Vesus2();

            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Ultilities.ControlUltils.changeParent(Pbx_Player, Pnl_Player, new Point(0, -Pnl_Player.Height));
            Ultilities.ControlUltils.changeParent(Pbx_Player2, Pnl_Player2, new Point(0, Pnl_Player2.Height));
            Ultilities.ControlUltils.changeParent(Lbl_Player, Pbx_PlayerBg,
                new Point((Pbx_PlayerBg.Width - Lbl_Player.Width) / 2, (Pbx_PlayerBg.Height - Lbl_Player.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_Player2, Pbx_Player2Bg,
                new Point((Pbx_Player2Bg.Width - Lbl_Player2.Width) / 2, (Pbx_Player2Bg.Height - Lbl_Player2.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_Loading, Pnl_Loading, Point.Empty);

            if (Program.Dic_Bundles.ContainsKey(StringManagement.KeyDatas.PlayerAvatar_Key))
            {
                Pbx_Player.Image = (Image)Program.Dic_Bundles[StringManagement.KeyDatas.PlayerAvatar_Key];
            }

            // Kiểm tra nếu avatar của Player 2 đã được lưu
            if (Program.Dic_Bundles.ContainsKey(StringManagement.KeyDatas.PlayerAvatar_Key2))
            {
                Pbx_Player2.Image = (Image)Program.Dic_Bundles[StringManagement.KeyDatas.PlayerAvatar_Key2];
            }

            Program.runAnimation(AnimationState.ZOOM_IN, this);
        }
        private void loadImages()
        {
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Versus\background.jpg");
            DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath + @"\images\Characters");
            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                List_BotImages.Add(Image.FromFile(fileInfo.FullName));
            Pbx_PlayerBg.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\rank.png");
            Pbx_Player2Bg.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\rank.png");

        }
        private int delay = 150;
        private void Timer_Avt_Tick(object sender, EventArgs e)
        {
            if (--delay > 0)
                return;
            Pbx_Player.Location = new Point(Pbx_Player.Location.X, Pbx_Player.Location.Y + 15);
            Pbx_Player2.Location = new Point(Pbx_Player2.Location.X, Pbx_Player2.Location.Y - 15);
            if (Pbx_Player.Location.Y >= Pbx_Player2.Location.Y)
            {
                Pbx_Player.Location = Pbx_Player2.Location = Point.Empty;
                Timer_Avt.Stop();
                Timer_Avt.Enabled = false;
                Timer_Loading.Enabled = true;
            }
        }

        private void Timer_Loading_Tick(object sender, EventArgs e)
        {
            Timer_Loading.Interval = new Random().Next(100, 1500);
            Lbl_Loading.BackColor = Color.Cyan;
            Lbl_Loading.Width += new Random().Next(1, 100);
            Lbl_ResultLoading.Text =
                (Math.Round(Lbl_Loading.Width * 1.0 / Pnl_Loading.Width, 2) * 100).ToString() + "%";
            if (Lbl_Loading.Width >= Pnl_Loading.Width)
            {
                Lbl_ResultLoading.Text = "100%";
                Lbl_Loading.Width = Pnl_Loading.Width;
                Timer_Loading.Stop();
                Timer_Loading.Enabled = false;
                Program.runAnimation(AnimationState.DISAPPEAR, this);
                Program.changeForm(FormKind.MAIN_GAME, new PlayWithPlayer());
                Program.Dic_Sounds[Ultils.Enum.SoundKind.MAIN_MUSIC].windowsMediaPlayer.controls.stop();
            }
        }

        private void VersusPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.List_HiddenForms.Count <= 0)
            {
                Program.changeForm(FormKind.YES_NO_MESSAGE_BOX, new YesNoMessageBox(),
                StringManagement.MessTitle, StringManagement.Leave_Mess);
                if (((YesNoMessageBox)Program.Dic_Forms[FormKind.YES_NO_MESSAGE_BOX]).Flag)
                    Application.ExitThread();
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
