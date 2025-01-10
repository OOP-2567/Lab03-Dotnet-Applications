namespace HelloForm1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private TextBox textBox_A; 
    private TextBox textBox_B; 
    private TextBox textBox_C; 

    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBox_A = new TextBox();
        textBox_A.Location = new Point(46, 20);
        textBox_A.Name = "textBox_A";
        textBox_A.Size = new Size(100, 23);
        Controls.Add(textBox_A);

        textBox_B = new TextBox();
        textBox_B.Location = new Point(46, 49);
        textBox_B.Name = "textBox_B";
        textBox_B.Size = new Size(100, 23);
        Controls.Add(textBox_B);

        textBox_C = new TextBox();
        textBox_C.Location = new Point(46, 111);
        textBox_C.Name = "textBox_C";
        textBox_C.Size = new Size(100, 23);
        Controls.Add(textBox_C);
        Button button1 = new Button();
        button1.Text = "button 1";
        button1.Location = new Point(54, 80);
        button1.Click += button1_Click; // ผูก Event Handler
        Controls.Add(button1);

       
    }
     private void button1_Click(object sender, EventArgs e)
        {

            double a, b, c;
            double.TryParse(textBox_A.Text, out a);
            double.TryParse(textBox_B.Text, out b);
            c = a + b;
            textBox_C.Text = c.ToString();
         }

    #endregion
}
