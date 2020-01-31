using System;
using System.Linq;
using System.Windows.Forms;

namespace SoundCard
{
    public partial class FormMain : Form
    {

        private bool _soundPaused;
        private bool _isRecording;
        private SoundCard _soundCard = new SoundCard();

        private String Filename
        {
            get
            {
                return _soundCard.Filename;
            }

            set
            {
                _soundCard.Filename = value;
                labelFilename.Text = StripFilename(value);
            }
        }

        private bool ButtonsEnabled
        {
            get
            {
                return comboBoxPlayingMethod.Enabled && buttonStart.Enabled && buttonPauseResume.Enabled && buttonStop.Enabled;
            }

            set
            {
                comboBoxPlayingMethod.Enabled = value;
                buttonStart.Enabled = value;
                buttonPauseResume.Enabled = value && SoundCard.IsPausable(comboBoxPlayingMethod.SelectedItem.ToString());
                buttonStop.Enabled = value;
            }
        }

        private bool SoundPaused
        {
            get
            {
                return _soundPaused;
            }

            set
            {
                if (value)
                    buttonPauseResume.Text = "Resume";
                else
                    buttonPauseResume.Text = "Pause";

                _soundPaused = value;
            }
        }

        private bool IsRecording
        {
            get
            {
                return _isRecording;
            }

            set
            {
                _isRecording = value;
                labelRecording.Visible = value;
                if (value)
                    buttonRecord.Text = "Save";
                else
                    buttonRecord.Text = "Record";
            }
        }

        public FormMain()
        {
            InitializeComponent();
            InitializeComboBoxPlayingMethod();
            InitializeComboBoxRecordingMethod();
            ButtonsEnabled = false;
            IsRecording = false;
            _soundCard.Parent = Handle;
        }

        private void InitializeComboBoxPlayingMethod()
        {
            comboBoxPlayingMethod.Items.AddRange(new String[] { "PlaySound", "Windows Media Player", "MCI", "DirectSound" });
            comboBoxPlayingMethod.SelectedIndex = 0;
        }

        private void InitializeComboBoxRecordingMethod()
        {
            comboBoxRecordingMethod.Items.AddRange(new String[] { "MCI" });
            comboBoxRecordingMethod.SelectedIndex = 0;
        }

        private void GetFilename()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Browse Sound Files",
                Filter = "Audio files (*.wav)|*.wav"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Filename = openFileDialog.FileName;
                ButtonsEnabled = true;
            }
        }

        private String GetFileDestination()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Audio files (*.wav)|*.wav",
                Title = "Save an audio file"
            };

            saveFileDialog.ShowDialog();

            return saveFileDialog.FileName;
        }

        private String StripFilename(String filename)
        {
            return filename.Split('\\').Last();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            GetFilename();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            _soundCard.Play();
            SoundPaused = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _soundCard.Stop();
            SoundPaused = false;
        }

        private void buttonPauseResume_Click(object sender, EventArgs e)
        {
            if (_soundPaused)
                _soundCard.Resume();
            else
                _soundCard.Pause();

            SoundPaused = !SoundPaused;
        }

        private void comboBoxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            _soundCard.PlayingMethod = comboBoxPlayingMethod.SelectedItem.ToString();
            buttonPauseResume.Enabled = SoundCard.IsPausable(comboBoxPlayingMethod.SelectedItem.ToString());
        }

        private void comboBoxRecordingMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            _soundCard.RecordingMethod = comboBoxRecordingMethod.SelectedItem.ToString();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            if (IsRecording)
                _soundCard.SaveRecordedFile(GetFileDestination());
            else
                _soundCard.Record();

            IsRecording = !IsRecording;
        }

        private void labelRecording_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
