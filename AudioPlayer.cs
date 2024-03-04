using NAudio.Wave;

namespace NotSpotify;

public class AudioPlayer
{
    private Mp3FileReader _reader;

    private WaveOutEvent _player;

    private string? _currentAudio;

    public bool IsPlaying { get; private set; }

    public AudioPlayer()
    {
        IsPlaying = false;

        _player = new WaveOutEvent();
    }

    public void Play(string audio)
    {
        IsPlaying = true;

        if (_currentAudio == audio)
        {
            if (_player.PlaybackState != PlaybackState.Playing)
                _player.Play();
        }
        else
        {
            _currentAudio = audio;

            _reader = new Mp3FileReader(audio);

            _player.Stop();

            _player.Init(_reader);

            _player.Play();
        }
    }

    public void Pause()
    {
        if (_player.PlaybackState == PlaybackState.Playing)
        {
            _player.Pause();

            IsPlaying = false;
        }
    }

    public int GetCurrentSeconds()
        => _reader is not null ? (int)_reader.CurrentTime.TotalSeconds : 0;

    public void SetCurrentSeconds(int seconds)
    {
        if (_reader is null)
        {
            throw new Exception("Error");
        }

        _reader.CurrentTime = TimeSpan.FromSeconds(seconds);
    }

    public string GetCurrentDurationString()
    {
        if (_reader is not null)
        {
            int totalSeconds = (int)_reader.CurrentTime.TotalSeconds;

            int minutes = totalSeconds / 60;

            int remainingSeconds = totalSeconds % 60;

            return string.Format($"{minutes}:{remainingSeconds:00}");
        }

        return "00:00";
    }

    public int GetTotalSeconds()
        => _reader is not null ? (int)_reader.TotalTime.TotalSeconds : 0;

    public string GetTotalDurationString()
    {
        if (_reader is not null)
        {
            int totalSeconds = (int)_reader.TotalTime.TotalSeconds;

            int minutes = totalSeconds / 60;

            int remainingSeconds = totalSeconds % 60;

            return string.Format($"{minutes}:{remainingSeconds:00}");
        }

        return "00:00";
    }

    public float GetCurrentVolume()
        => _player.Volume;
    public void SetVolume(float volume)
    {
        _player.Volume = volume / 100f;
    }
}