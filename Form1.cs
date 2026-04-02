namespace LoginScreen
{
    public partial class LoginScreen : Form
    {
        string myID = "jaehuni";
        string myPW = "jaehuni";
        public LoginScreen()
        {
            InitializeComponent();
            lblErrorMsg.Visible = false;
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }
        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;

            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인 되었습니다.", "로그인", MessageBoxButtons.OK);
                lblErrorMsg.Visible = false;
            }
            else
            {
                //MessageBox.Show("아이디/패스워드를 다시 입력해주세요.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMsg.Visible = true;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본 비프음 방지
                txtPW.Focus(); // 패스워드 입력창이 포커스를 갖게끔
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본 비프음 방지
                btnLogin.PerformClick(); // 버튼이 눌린 것처럼 만들기
            }
        }

        private void btnPWshowhide_Click_1(object sender, EventArgs e)
        {
            // Placeholder(안내문구)일 때는 동작하지 않음
            if (txtPW.Text == "패스워드") return;

            // UseSystemPasswordChar 값이 true(숨김)라면 false(표시)로, false면 true로 전환합니다.
            txtPW.UseSystemPasswordChar = !txtPW.UseSystemPasswordChar;

            // 포커스가 버튼으로 이동하는 것을 막고 입력창에 유지
            txtPW.Focus();
        }

        private void btnTXTClear_Click(object sender, EventArgs e)
        {
            // 1. 텍스트 박스 초기화 (안의 글자 모두 지우기)
            txtID.Text = "";
            txtPW.Text = "";

            // 2. 입력란이 비었을 때 "아이디", "패스워드" 안내문구(Placeholder)를 다시 띄워주는 기존 기능 재활용
            txtID_Leave(null, EventArgs.Empty);
            txtPW_Leave(null, EventArgs.Empty);

            // 3. 에러 메시지도 혹시 켜져있다면 숨기기 (선택사항)
            lblErrorMsg.Visible = false;

            // 4. 다시 아이디 입력란으로 커서(포커스) 옮기기
            txtID.Focus();
        }
    }
}
