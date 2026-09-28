namespace Juego_Basic;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;

    private StatusStrip statusStrip1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripStatusLabel toolStripStatusLabel2;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        statusStrip1 = new StatusStrip();
        toolStripStatusLabel1 = new ToolStripStatusLabel();
        toolStripStatusLabel2 = new ToolStripStatusLabel();

        statusStrip1.SuspendLayout();
        SuspendLayout();

        statusStrip1.Items.AddRange(new ToolStripItem[]
        {
            toolStripStatusLabel1,
            toolStripStatusLabel2
        });

        statusStrip1.Dock = DockStyle.Bottom;
        statusStrip1.Name = "statusStrip1";

        toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        toolStripStatusLabel1.Text = "Mi Rival";

        toolStripStatusLabel2.Name = "toolStripStatusLabel2";
        toolStripStatusLabel2.Text = "Mi Avion";

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 600);
        Controls.Add(statusStrip1);
        Name = "Form1";
        Text = "JUEGO DE AVIONES BASICO";

        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}