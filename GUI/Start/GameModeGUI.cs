using GUI.MessageBoxes;
using GUI.Ultils;
using GUI.Ultils.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI.Start
{
    public partial class GameModeGUI : Form
    {
        public GameModeGUI()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;
                return createParams;
            }
        }

        private void loadImages()
        {
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\background.jpg");
            Pbx_SinglePlayer.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\wood.png");
            Pbx_MultiPlayer.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\wood.png");
            Pbx_BackHome.Image = Ultilities.ControlUltils.getImageFromFile(@"Shared\back.png");
            Pbx_Mode.Image = Ultilities.ControlUltils.getImageFromFile(@"Result\back.png");
        }

        private void Btn_SinglePlayer_Click(object sender, EventArgs e)
        {
            Btn_SinglePlayer.Enabled = false;
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.CHARACTER_CHOICE, new CharacterChoiceGUI());
        }

        private void Btn_MultiPlayer_Click(object sender, EventArgs e)
        {
            Btn_MultiPlayer.Enabled = false;
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.START, new PlayerSelection());
        }

        private void Btn_Home_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Home.Enabled = false;
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.START, new StartGUI());
        }

        private void Btn_Home_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Ultilities.ControlUltils.changeCursorDown();
        }

        private void Btn_Home_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Ultilities.ControlUltils.changeCursorUp();
        }

        private void Btn_Home_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.DarkCyan;
        }

        private void Btn_Home_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[Ultils.Enum.SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.Cyan;
        }

        private void GameMode_GUI_Load(object sender, EventArgs e)
        {
            loadImages();

            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Program.Dic_Sounds[SoundKind.OPENING_MUSIC].windowsMediaPlayer.controls.pause();
            Program.Dic_Sounds[SoundKind.MAIN_MUSIC].windowsMediaPlayer.controls.play();
            Program.Dic_Sounds[SoundKind.MAIN_MUSIC].windowsMediaPlayer.settings.setMode("loop", true);
            Btn_SinglePlayer.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_MultiPlayer.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Home.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);

            Ultilities.ControlUltils.changeParent(Lbl_Mode, Pbx_Mode, new Point(Lbl_Mode.Location.X, Lbl_Mode.Location.Y));
            Ultilities.ControlUltils.changeParent(Btn_Home, Pbx_BackHome, new Point(20, 22));
            Ultilities.ControlUltils.changeParent(Btn_SinglePlayer, Pbx_SinglePlayer,
                new Point((Pbx_SinglePlayer.Width - Btn_SinglePlayer.Width) / 2, (Pbx_SinglePlayer.Height - Btn_SinglePlayer.Height) / 4));
            Ultilities.ControlUltils.changeParent(Btn_MultiPlayer, Pbx_MultiPlayer,
                new Point((Pbx_MultiPlayer.Width - Btn_MultiPlayer.Width) / 2, (Pbx_MultiPlayer.Height - Btn_MultiPlayer.Height) / 4));
            Program.runAnimation(AnimationState.SINK, this);
        }

        private void GameMode_GUI_FormClosing(object sender, FormClosingEventArgs e)
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
