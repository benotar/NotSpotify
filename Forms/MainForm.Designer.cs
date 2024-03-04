namespace NotSpotify.Forms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        components = new System.ComponentModel.Container();
        audioListBox = new ListBox();
        audioNameLabel = new Label();
        previousButton = new Button();
        audioProgressBar = new ProgressBar();
        nextButton = new Button();
        playPauseButton = new Button();
        timer = new System.Windows.Forms.Timer(components);
        startLabel = new Label();
        endLabel = new Label();
        volumeTrackBar = new TrackBar();
        volumeLabel = new Label();
        volumeMaxLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)volumeTrackBar).BeginInit();
        SuspendLayout();
        // 
        // audioListBox
        // 
        audioListBox.BackColor = Color.Gray;
        audioListBox.BorderStyle = BorderStyle.FixedSingle;
        audioListBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
        audioListBox.ForeColor = Color.Black;
        audioListBox.FormattingEnabled = true;
        audioListBox.HorizontalScrollbar = true;
        audioListBox.ItemHeight = 23;
        audioListBox.Location = new Point(12, 157);
        audioListBox.Name = "audioListBox";
        audioListBox.ScrollAlwaysVisible = true;
        audioListBox.Size = new Size(275, 278);
        audioListBox.TabIndex = 0;
        audioListBox.SelectedIndexChanged += AudioListBoxSelectedIndexChanged;
        // 
        // audioNameLabel
        // 
        audioNameLabel.AutoSize = true;
        audioNameLabel.BackColor = Color.FromArgb(20, 19, 18);
        audioNameLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
        audioNameLabel.ForeColor = Color.White;
        audioNameLabel.Location = new Point(12, 19);
        audioNameLabel.Name = "audioNameLabel";
        audioNameLabel.Size = new Size(114, 23);
        audioNameLabel.TabIndex = 1;
        audioNameLabel.Text = "Pick an audio...";
        // 
        // previousButton
        // 
        previousButton.BackColor = Color.GreenYellow;
        previousButton.FlatStyle = FlatStyle.Popup;
        previousButton.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
        previousButton.Location = new Point(12, 60);
        previousButton.Name = "previousButton";
        previousButton.Size = new Size(76, 33);
        previousButton.TabIndex = 3;
        previousButton.Text = "Previous";
        previousButton.UseVisualStyleBackColor = false;
        previousButton.Click += previousButtonClick;
        // 
        // audioProgressBar
        // 
        audioProgressBar.Location = new Point(12, 112);
        audioProgressBar.Name = "audioProgressBar";
        audioProgressBar.Size = new Size(275, 14);
        audioProgressBar.TabIndex = 5;
        audioProgressBar.MouseDown += audioProgressBarMouseDown;
        // 
        // nextButton
        // 
        nextButton.BackColor = Color.GreenYellow;
        nextButton.FlatStyle = FlatStyle.Popup;
        nextButton.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
        nextButton.Location = new Point(211, 60);
        nextButton.Name = "nextButton";
        nextButton.Size = new Size(76, 33);
        nextButton.TabIndex = 6;
        nextButton.Text = "Next";
        nextButton.UseVisualStyleBackColor = false;
        nextButton.Click += nextButtonClick;
        // 
        // playPauseButton
        // 
        playPauseButton.BackColor = Color.GreenYellow;
        playPauseButton.FlatStyle = FlatStyle.Popup;
        playPauseButton.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
        playPauseButton.Location = new Point(94, 60);
        playPauseButton.Name = "playPauseButton";
        playPauseButton.Size = new Size(111, 33);
        playPauseButton.TabIndex = 7;
        playPauseButton.Text = "Play/Pause";
        playPauseButton.UseVisualStyleBackColor = false;
        playPauseButton.Click += PlayButtonClick;
        // 
        // timer
        // 
        timer.Enabled = true;
        timer.Tick += timerTick;
        // 
        // startLabel
        // 
        startLabel.AutoSize = true;
        startLabel.BackColor = Color.FromArgb(20, 19, 18);
        startLabel.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
        startLabel.ForeColor = Color.GreenYellow;
        startLabel.Location = new Point(12, 129);
        startLabel.Name = "startLabel";
        startLabel.Size = new Size(45, 19);
        startLabel.TabIndex = 8;
        startLabel.Text = "00:00";
        // 
        // endLabel
        // 
        endLabel.AutoSize = true;
        endLabel.BackColor = Color.FromArgb(20, 19, 18);
        endLabel.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
        endLabel.ForeColor = Color.GreenYellow;
        endLabel.Location = new Point(242, 129);
        endLabel.Name = "endLabel";
        endLabel.Size = new Size(45, 19);
        endLabel.TabIndex = 9;
        endLabel.Text = "00:00";
        // 
        // volumeTrackBar
        // 
        volumeTrackBar.BackColor = Color.FromArgb(20, 19, 18);
        volumeTrackBar.Location = new Point(300, 179);
        volumeTrackBar.Maximum = 100;
        volumeTrackBar.Name = "volumeTrackBar";
        volumeTrackBar.Orientation = Orientation.Vertical;
        volumeTrackBar.Size = new Size(45, 234);
        volumeTrackBar.TabIndex = 100;
        volumeTrackBar.TickStyle = TickStyle.TopLeft;
        volumeTrackBar.Value = 50;
        volumeTrackBar.Scroll += volumeTrackBarScroll;
        // 
        // volumeLabel
        // 
        volumeLabel.AutoSize = true;
        volumeLabel.BackColor = Color.FromArgb(20, 19, 18);
        volumeLabel.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
        volumeLabel.ForeColor = Color.GreenYellow;
        volumeLabel.Location = new Point(293, 416);
        volumeLabel.Name = "volumeLabel";
        volumeLabel.Size = new Size(52, 19);
        volumeLabel.TabIndex = 11;
        volumeLabel.Text = "Volume";
        // 
        // volumeMaxLabel
        // 
        volumeMaxLabel.AutoSize = true;
        volumeMaxLabel.BackColor = Color.FromArgb(20, 19, 18);
        volumeMaxLabel.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
        volumeMaxLabel.ForeColor = Color.GreenYellow;
        volumeMaxLabel.Location = new Point(300, 157);
        volumeMaxLabel.Name = "volumeMaxLabel";
        volumeMaxLabel.Size = new Size(36, 19);
        volumeMaxLabel.TabIndex = 12;
        volumeMaxLabel.Text = "50%";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(20, 19, 18);
        ClientSize = new Size(355, 458);
        Controls.Add(volumeMaxLabel);
        Controls.Add(volumeLabel);
        Controls.Add(volumeTrackBar);
        Controls.Add(endLabel);
        Controls.Add(startLabel);
        Controls.Add(playPauseButton);
        Controls.Add(nextButton);
        Controls.Add(audioProgressBar);
        Controls.Add(previousButton);
        Controls.Add(audioNameLabel);
        Controls.Add(audioListBox);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Not Spotify";
        Load += MainFormLoad;
        ((System.ComponentModel.ISupportInitialize)volumeTrackBar).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox audioListBox;
    private Label audioNameLabel;
    private Button previousButton;
    private ProgressBar audioProgressBar;
    private Button nextButton;
    private Button playPauseButton;
    private System.Windows.Forms.Timer timer;
    private Label startLabel;
    private Label endLabel;
    private TrackBar volumeTrackBar;
    private Label volumeLabel;
    private Label volumeMaxLabel;
}
