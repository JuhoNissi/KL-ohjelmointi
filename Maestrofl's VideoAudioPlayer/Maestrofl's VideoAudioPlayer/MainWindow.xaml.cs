using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Maestrofl_s_VideoAudioPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //muuttuja edusatakoon ysinkertaista tilakonetta
        enum MusicPlays;
        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }
        #region METHODS
        private void IniMyStuff()
        {
            //tänne kootaan kaikki käynnityksen yhteydessä tarvittavat alustukset 
            enum MusicPlays
        {
            Stop,
            Play,
            Pause
        }
            MusicPlays musicplays;
            SetButtons();
        }
        private void 
        {
        //asetetaan näytön buttosten näkyvyyttä/käytettävyyttä
        switch ()
        {
            default:
                break;
        }
    }
#endregion
    #region EVENTHANDLERS
    private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            //tämä metodi = tapahtuman käsittelijä suoritetaan joka kerta, kun btnPlay buttonia painetaan
            try
            {
                //tutkitaan onko anneetu tiedosto olemassa
                if (txtFilename.Text.Lenght > 0 && System.IO.File(txtFilename.Text))
                {
                    //nyt rokit soimaan
                    //LoadedBehavior täytyy olla Manual jotta voimme koodissa kotrolloida media Play Pause ja Stop -metodeita
                    if (musicplays == MusicPlays.Stop)
                    mediaElement.Source = new Uri(txtFileName.Text);
                    mediaElement.Play();
                    musicplays.play();
                    SetButtons();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            //näytetään käyttäjälle vakio open-dialogi
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"d:\";
            ofd.Multiselect = false;
            ofd.Filter = "Rock files (*.mp3)|*.mp3|Media files (*.wmv)|*.wmv|All files(*.*)|*.*|";
            Nullable<bool> result = ofd.ShowDialog();
            if (result==true)
            {
                txtFileName.Text = ofd.FileName;
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Stop;
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Pause();
            musicplays = MusicPlays

        }

        private void txtFileName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
