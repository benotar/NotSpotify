using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

namespace NotSpotify.Forms;

public partial class MainForm : Form
{
    private string _folderPath = "Audio/";
    
    private string? _selectedAudioName = null;


    private AudioPlayer _audioPlayer;
    public MainForm()
    {
        _audioPlayer = new AudioPlayer();

        InitializeComponent();
    }

    private void MainFormLoad(object sender, EventArgs e)
    {
        FillAudioListBox();
    }

    private void FillAudioListBox()
    {
        if (string.IsNullOrEmpty(_folderPath) || !Directory.Exists(_folderPath))
        {
            return;
        }

        audioListBox.Items.Clear();

        var audioFileNames = Directory
        .GetFiles(_folderPath);

        foreach (var audioFile in audioFileNames)
        {
            int lastSlashIndex = audioFile.LastIndexOf('/');

            string shortFileName = audioFile.Substring(lastSlashIndex + 1, audioFile.Length - lastSlashIndex - 1);

            audioListBox.Items.Add(shortFileName);
        }
    }

    private void previousButtonClick(object sender, EventArgs e)
    {
        if (audioListBox.SelectedIndex < 1)
        {
            audioListBox.SelectedIndex = audioListBox.Items.Count - 1;
        }
        else
        {
            audioListBox.SelectedIndex--;
        }
    }

    private void nextButtonClick(object sender, EventArgs e)
    {
        if (audioListBox.SelectedIndex >= audioListBox.Items.Count - 1)
        {
            audioListBox.SelectedIndex = 0;
        }
        else
        {
            audioListBox.SelectedIndex++;
        }
    }

    private void AudioListBoxSelectedIndexChanged(object sender, EventArgs e)
    {
        if (audioListBox.SelectedItem is null) return;

        _selectedAudioName = audioListBox.SelectedItem.ToString();

        audioNameLabel.Text = _selectedAudioName;

        _audioPlayer.Play(_folderPath + _selectedAudioName);
    }

    private void PlayButtonClick(object sender, EventArgs e)
    {
        if (_selectedAudioName is null) return;

        if (_audioPlayer.IsPlaying is true)
        {
            _audioPlayer.Pause();
        }
        else
        {
            _audioPlayer.Play(_folderPath + _selectedAudioName);
        }
    }

    private void timerTick(object sender, EventArgs e)
    {
        if (_audioPlayer.IsPlaying)
        {
            audioProgressBar.Maximum = _audioPlayer.GetTotalSeconds();

            audioProgressBar.Value = _audioPlayer.GetCurrentSeconds();

            if (audioProgressBar.Value == audioProgressBar.Maximum)
            {
                if (audioListBox.SelectedIndex >= audioListBox.Items.Count - 1)
                {
                    audioListBox.SelectedIndex = 0;
                }
                else
                {
                    audioListBox.SelectedIndex++;
                }
            }
        }

        startLabel.Text = _audioPlayer.GetCurrentDurationString();

        endLabel.Text = _audioPlayer.GetTotalDurationString();
    }

    private void volumeTrackBarScroll(object sender, EventArgs e)
    {
        _audioPlayer.SetVolume((float)volumeTrackBar.Value);

        volumeMaxLabel.Text = volumeTrackBar.Value.ToString() + '%';
    }

    private void audioProgressBarMouseDown(object sender, MouseEventArgs e)
    {
        _audioPlayer.SetCurrentSeconds(_audioPlayer.GetTotalSeconds() * e.X / audioProgressBar.Width);
    }

    private void openButtonClick(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

        openFileDialog.Filter = "wav, mp3|* .wav;*.mp3";

        openFileDialog.Multiselect = true;

        DialogResult dialogResult = openFileDialog.ShowDialog();

        audioListBox.Items.Clear();

        if (dialogResult == DialogResult.OK)
        {
            _folderPath = Path.GetDirectoryName(openFileDialog.FileName) + '/';

            foreach (var f in openFileDialog.FileNames)
            {
                int lastSlashIndex = Path.GetFileName(f).LastIndexOf('/');

                string shortFileName = Path.GetFileName(f).Substring(lastSlashIndex + 1, Path.GetFileName(f).Length - lastSlashIndex - 1);

                audioListBox.Items.Add(shortFileName);
            }
        }
    }
}
