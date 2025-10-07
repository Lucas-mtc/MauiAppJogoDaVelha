namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        public MainPage()
        {
            InitializeComponent();
            Zerar(this, null);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            if ((btn10.Text == btn11.Text && btn11.Text == btn12.Text && btn10.Text != "") ||
                (btn20.Text == btn21.Text && btn21.Text == btn22.Text && btn20.Text != "") ||
                (btn30.Text == btn31.Text && btn31.Text == btn32.Text && btn30.Text != "") ||
                (btn10.Text == btn20.Text && btn20.Text == btn30.Text && btn10.Text != "") ||
                (btn11.Text == btn21.Text && btn21.Text == btn31.Text && btn11.Text != "") ||
                (btn12.Text == btn22.Text && btn22.Text == btn32.Text && btn12.Text != "") ||
                (btn10.Text == btn21.Text && btn21.Text == btn32.Text && btn10.Text != "") ||
                (btn12.Text == btn21.Text && btn21.Text == btn30.Text && btn12.Text != ""))
            {
                DisplayAlert("Fim de Jogo", $"O jogador {btn.Text} venceu!", "OK");
                Zerar(sender, e);
            }
            else if (btn10.IsEnabled == false && btn11.IsEnabled == false && btn12.IsEnabled == false &&
                     btn20.IsEnabled == false && btn21.IsEnabled == false && btn22.IsEnabled == false &&
                     btn30.IsEnabled == false && btn31.IsEnabled == false && btn32.IsEnabled == false)
            {
                DisplayAlert("Fim de Jogo", "Empate!", "OK");
                Zerar(sender, e);
            }
        }

        private void Zerar(object sender, EventArgs e)
        {
            btn10.Text = "";
            btn10.IsEnabled = true;
            btn11.Text = "";
            btn11.IsEnabled = true;
            btn12.Text = "";
            btn12.IsEnabled = true;
            btn20.Text = "";
            btn20.IsEnabled = true;
            btn21.Text = "";
            btn21.IsEnabled = true;
            btn22.Text = "";
            btn22.IsEnabled = true;
            btn30.Text = "";
            btn30.IsEnabled = true;
            btn31.Text = "";
            btn31.IsEnabled = true;
            btn32.Text = "";
            btn32.IsEnabled = true;
        }
    }
}
