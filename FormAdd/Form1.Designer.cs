namespace FormAdd;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // ประกาศตัวแปร reference สำหรับคอนโทรลในระดับคลาส
    private Button buttonAdd;
    private Label label_A;
    private Label label_B;
    private Label label_C;
    private TextBox textBox_A;
    private TextBox textBox_B;
    private TextBox textBox_C;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        buttonAdd = new Button();
        label_A = new Label();
        label_B= new Label();
        label_C= new Label();
        textBox_A = new TextBox();
        textBox_B = new TextBox();
        textBox_C = new TextBox();
        SuspendLayout();

        label_A.AutoSize = true;
        label_A.Location = new Point(25, 24);
        label_A.Name = "label_A";
        label_A.Size = new Size(15, 15);
        label_A.Text = "A";
        Controls.Add(label_A);

        label_B.AutoSize = true;
        label_B.Location = new Point(26, 53);
        label_B.Name = "label_B";
        label_B.Size = new Size(14, 15);
        label_B.Text = "B";
        Controls.Add(label_B);

        label_C.AutoSize = true;
        label_C.Location = new Point(26, 112);
        label_C.Name = "label_C";
        label_C.Size = new Size(15, 15);
        label_C.Text = "C";
        Controls.Add(label_C);

        textBox_A.Location = new Point(46, 20);
        textBox_A.Name = "textBox_A";
        textBox_A.Size = new Size(100, 23);
        Controls.Add(textBox_A);

        textBox_B.Location = new Point(46, 49);
        textBox_B.Name = "textBox_B";
        textBox_B.Size = new Size(100, 23);
        Controls.Add(textBox_B);

        textBox_C.Location = new Point(46, 108);
        textBox_C.Name = "textBox_C";
        textBox_C.Size = new Size(100, 23);
        Controls.Add(textBox_C);

        buttonAdd.Location = new Point(59, 79);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(75, 23);
        buttonAdd.Text = "Add";
        Controls.Add(buttonAdd);

        buttonAdd.Click += buttonAdd_Click;


        ResumeLayout(false);
        PerformLayout();

       
    }
   
    #endregion
}
