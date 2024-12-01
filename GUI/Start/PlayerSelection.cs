using GUI.Ultils.Enum;
using GUI.Ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
//using GUI.CharacterChoice;

namespace GUI.Start
{
    public partial class PlayerSelection : Form
    {
       
        public PlayerSelection()
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
            Pbx_Player1.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\wood.png");
            Pbx_Player2.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\wood.png");
            Pbx_Start.Image = Ultilities.ControlUltils.getImageFromFile(@"Shared\back.png");
            Pbx_Home.Image = Ultilities.ControlUltils.getImageFromFile(@"Result\back.png");
        }

        private void PlayerSelection_Load(object sender, EventArgs e)
        {
            loadImages();
            Cbo_ChoosePlayer2.Location = new Point(660, 390);
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Program.Dic_Sounds[SoundKind.OPENING_MUSIC].windowsMediaPlayer.controls.pause();
            Program.Dic_Sounds[SoundKind.MAIN_MUSIC].windowsMediaPlayer.controls.play();
            Program.Dic_Sounds[SoundKind.MAIN_MUSIC].windowsMediaPlayer.settings.setMode("loop", true);
            Btn_Start.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Home.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);

            Ultilities.ControlUltils.changeParent(Btn_Home, Pbx_Home, new Point(Btn_Home.Location.X, Btn_Home.Location.Y));
            Ultilities.ControlUltils.changeParent(Btn_Start, Pbx_Start, new Point(20, 22));
            Ultilities.ControlUltils.changeParent(Lbl_Player1, Pbx_Player1,
                new Point((Pbx_Player1.Width - Lbl_Player1.Width) / 2, (Pbx_Player1.Height - Lbl_Player1.Height) / 3));
            Ultilities.ControlUltils.changeParent(Lbl_Player2, Pbx_Player2,
                new Point((Pbx_Player2.Width - Lbl_Player2.Width) / 2, (Pbx_Player2.Height - Lbl_Player2.Height) / 3));

            CharacterDTO characterDTO = (CharacterDTO)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterDTO_Key];
            //CharacterDTO characterDTO2 = (CharacterDTO)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterDTO_Key2];

            Lbl_Player1.Text = characterDTO.username;
            //Lbl_Player2.Text = characterDTO2.username;


            // Lấy thông tin người chơi hiện tại (Player 1)
            CharacterDTO currentPlayer = (CharacterDTO)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterDTO_Key];
            Lbl_Player1.Text = currentPlayer.username;

            // Lấy danh sách tất cả các CharacterDTO (trừ người chơi hiện tại)
            List<CharacterDTO> characterDTOs = ((CharacterBLL)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterBLL_Key]).getCharacterDTOs();

            // Xóa tất cả các mục hiện tại trong ComboBox
            Cbo_ChoosePlayer2.Items.Clear();

            // Lọc danh sách để loại trừ người chơi hiện tại
            var otherPlayers = characterDTOs.Where(c => c.username != currentPlayer.username).ToList();

            // Thêm các tài khoản còn lại vào ComboBox
            foreach (var player in otherPlayers)
            {
                Cbo_ChoosePlayer2.Items.Add(player.username);  // Hoặc có thể thêm thêm các thông tin khác
            }

            // Nếu có ít nhất một tài khoản trong ComboBox, chọn tài khoản đầu tiên làm mặc định
            if (Cbo_ChoosePlayer2.Items.Count > 0)
            {
                Cbo_ChoosePlayer2.SelectedIndex = 0;
                //Lbl_Player2.Text = Cbo_ChoosePlayer2.SelectedItem.ToString();
            }

            Program.runAnimation(AnimationState.SINK, this);


           
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Btn_Home.Enabled = false;
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.START, new GameModeGUI());
        }

        private void Cbo_ChoosePlayer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_ChoosePlayer2.SelectedItem != null)
            {
                Lbl_Player2.Text = Cbo_ChoosePlayer2.SelectedItem.ToString();

                CharacterDTO player2 = ((CharacterBLL)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterBLL_Key2]).getCharacterDTO(Lbl_Player2.Text);
                // Lưu thông tin người chơi thứ 2 vào đối tượng lưu trữ (ví dụ: Dic_Bundles hoặc một biến tạm)
                Program.Dic_Bundles[StringManagement.KeyDatas.CharacterDTO_Key2] = player2;

                Cbo_ChoosePlayer2.SelectedIndex = -1;
                Cbo_ChoosePlayer2.Width = 18;
                Cbo_ChoosePlayer2.Location = new Point(660, 380);
            }
        }

        private void Cbo_ChoosePlayer2_DropDown(object sender, EventArgs e)
        {
            // Tính toán chiều rộng tối đa của các mục trong ComboBox
            int maxWidth = 0;
            foreach (var item in Cbo_ChoosePlayer2.Items)
            {
                // Tính chiều rộng của mỗi mục
                int width = TextRenderer.MeasureText(item.ToString(), Cbo_ChoosePlayer2.Font).Width;
                if (width > maxWidth)
                {
                    maxWidth = width;
                }
            }

            // Đặt chiều rộng ComboBox sao cho đủ để hiển thị toàn bộ nội dung
            Cbo_ChoosePlayer2.Width = maxWidth + 30; // Thêm một chút không gian (padding)
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            // Lưu thông tin người chơi thứ 2 vào Dic_Bundles
            Program.Dic_Bundles[StringManagement.KeyDatas.CharacterDTO_Key2] =
                ((CharacterBLL)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterBLL_Key]).getCharacterDTO(Lbl_Player2.Text);

            Btn_Start.Enabled = false;
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.CHARACTER_CHOICE, new CharacterChoice2Player());
        }
    }
}
