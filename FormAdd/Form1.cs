namespace FromAdd;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void buttonAdd_Click(object sender, EventArgs e)
{
    double a, b, c;
    double.TryParse(textBox_A.Text, out a);
    double.TryParse(textBox_B.Text, out b);
    c = a + b;
    textBox_C.Text = c.ToString();
}
}