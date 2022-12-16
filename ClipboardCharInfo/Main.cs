namespace ClipboardCharInfo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            { 
                string text = Clipboard.GetText();
                if (text.Length < 1)
                    return;

                lbl_info.Text = "";

                foreach (var i in text)
                { 
                    char chr = i;
                    int char_int = Convert.ToInt32(chr);
                    lbl_info.Text += $"{char_int:X} ";
                }
            }
        }
    }
}