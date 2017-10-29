using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace Audio_Player
{
    public partial class frmMain : Form
    {
        AxWindowsMediaPlayer wmp = new AxWindowsMediaPlayer();//обьект класса WMP из библиотеки WMPLib
        
        bool WindowMax = false; //окно не на весь экран 
        bool playPause = false;//состояние трека(на паузе или возпроизводится). play - true; pause - false.
        bool mute = false;//включен звук или нет (true - звука нет; false - звук есть)
        bool isRepeat = false; //включена ли функция повтора трека
        bool audiobookMode = false; //режим аудиокниги
        int indexCurTrack = 0; //индекс текущего трека
        string nameCurrentTrack = "";//название текущего трека
        string[] paths; //пути к выбранным файлам
        
        public frmMain()
        {
            InitializeComponent();
            wmp = axWindowsMediaPlayer;
            //фильтры для окна выбора плейлиста
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "MP3 Files|*.mp3|WAV Files|*.wav|All Supported|*.aac,*.mp4,*.m4v,*.mp4v,*.wma,*.amr";
            //автовоспроизведение следующего трека
            wmp.settings.autoStart = true;
            paths = new string[0];
        }

        //закрыть программу
        private void bnfImgBtnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        //развернуть окно на весь экран
        private void bnfImgBtnMaxWindow_Click(object sender, EventArgs e)
        {
            if (WindowMax)
            {
                WindowState = FormWindowState.Normal;//размер окна по дефолту 
                WindowMax = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;//окно на весь экран
                WindowMax = true;
            }
        }
        
        //свернуть 
        private void bnfImgBtnMinWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;//свернуить окно
        }

        //обработка выбора плейлиста
        private void bnfImgBtnPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                //Если выбран диалог открытия файла, выполняем условие
                if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName != "." && openFileDialog.FileName != string.Empty)
                {
                    //помещаем выделенные файлы в плейлист проигрывателя
                    //если в листбоксе уже есть файлы, то просто добавляем к плейлисту новые
                    listBoxPlaylist.Items.AddRange(openFileDialog.SafeFileNames);
                    indexCurTrack = 0;//индекс текущего трека = 0
                    nameCurrentTrack = listBoxPlaylist.Items[indexCurTrack].ToString();//название текущего трека

                    //сохраняем пути к файлам
                    //создаем новый массив, если текущий плейлист уже содержит файлы 
                    if (listBoxPlaylist.Items.Count != 0)
                    {
                        var size = openFileDialog.FileNames.Length;
                        var size2 = paths.Length;

                        string[] newPaths = new string[size + size2];

                        //помещаем данные в новый массив
                        int i = 0;
                        //помещаем старые данные
                        for (i = 0; i < paths.Length; i++)
                        {
                            newPaths[i] = paths[i];
                        }
                        //добавляем новые данные
                        for (int j = 0; j < size; j++, i++)
                        {
                            newPaths[i] = openFileDialog.FileNames[j];
                        }
                        //присваиваем новый массив 
                        paths = newPaths;
                    }
                    else
                    {
                        paths = openFileDialog.FileNames;
                    }
                }
                

                //настройка громкости
                wmp.settings.volume = bunifuSliderVolume.Value;
                ChangeImageVolume();

                //начинаем воспроизводить с первого трека
                //выбираем файл для проигрывания 
                wmp.URL = paths[indexCurTrack];
                SettingPlayTrack();

                //запускаем таймер
                timer.Enabled = true;
                timer.Interval = 1000;
            }
            catch (Exception)
            {
                //обработка исключения, если не выбран файл
                //MessageBox.Show("Файл не выбран!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //настройка воспроизведение трека: запуск файла, запуск таймера
        private void SettingPlayTrack()
        {
            //запускаем или ставим на паузу файл
            PlayOrPause();

            //выводим название трека!!!!! УБРАТЬ ВЫВОД .ФОРМАТ
            bnfCstmLblPlayingTrack.Text = listBoxPlaylist.Items[indexCurTrack].ToString();
        }

        //кнопка воспроизведения трека
        private void bnfImgBtnPlay_Click(object sender, EventArgs e)
        {
            //запускаем или ставим на паузу файл
            PlayOrPause();
        }

        //таймер, отвечает за показ продолжительности трека
        private void timer_Tick(object sender, EventArgs e)
        {
            //связываем продолжительность трека с ProgressBar
            bunifuProgressBar.MaximumValue = Convert.ToInt32(wmp.currentMedia.duration);
            try
            {
                bunifuProgressBar.Value = Convert.ToInt32(wmp.Ctlcontrols.currentPosition);
            }
            catch (DivideByZeroException)
            {
                //деление на ноль, ловим исключение
            }

            if (wmp != null)
            {
                //вычисляем продолжительность трека 
                int seconds = (int)wmp.currentMedia.duration;
                int hours = seconds / 3600;
                int minutes = (seconds - (hours * 3600)) / 60;
                seconds = seconds - (hours * 3600 + minutes * 60);
                if(hours == 0)
                {
                    bnfCstmLblTrackDuration.Text = hours + ":" + minutes + ":" + seconds;
                }
                else
                {
                    bnfCstmLblTrackDuration.Text = minutes + ":" + seconds;
                }

                //вычисляем время проигрывания трека
                calcCurrentTime();
            }
            else
            {
                bnfCstmLblTrackDuration.Text = "0:0:00";
                bnfCstmLblTrackCurPosition.Text = "0:0:00";
            }
        }

        //вычисляем время проигрывания трека
        private void calcCurrentTime()
        {
            //вычисляем время проигрывания трека
            int seconds = (int)wmp.Ctlcontrols.currentPosition;
            int hours = seconds / 3600;
            int minutes = (seconds - (hours * 3600)) / 60;
            seconds = seconds - (hours * 3600 + minutes * 60);
            if (hours == 0)
            {
                bnfCstmLblTrackCurPosition.Text = hours + ":" + minutes + ":" + seconds;
            }
            else
            {
                bnfCstmLblTrackCurPosition.Text = minutes + ":" + seconds;
            }
        }

        //кнопка паузы
        private void bnfImgBtnPause_Click(object sender, EventArgs e)
        {
            //запускаем или ставим на паузу файл
            PlayOrPause();
        }

        //функция отвечает за запуск или паузу файла
        private void PlayOrPause()
        {
            try
            {
                //если на паузе - запускаем
                if (playPause == false)
                {
                    wmp.Ctlcontrols.play();
                    playPause = true;
                }
                //иначе - ставим на паузу
                else
                {
                    wmp.Ctlcontrols.pause();
                    playPause = false;

                    //проверка на режим аудиокниги
                    //если режим включен, то отматываем воспроизведение на 5 секунд назад
                    if (audiobookMode)
                    {
                        wmp.Ctlcontrols.currentPosition -= 5;
                        //вычисляем время проигрывания трека
                        calcCurrentTime();
                    }

                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Не нужно нажимать все подряд!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //обработка кнопки "Стоп"
        private void bnfImgBtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                //останавливаем воспроизведение 
                wmp.Ctlcontrols.stop();
                //ставим текущий индекс 0
                indexCurTrack = 0;
                //и текущий трек - первый в плейлисте
                nameCurrentTrack = listBoxPlaylist.Items[indexCurTrack].ToString();
            }
            catch (Exception)
            {
                //MessageBox.Show("Не нужно нажимать все подряд!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //если пользователь нажал на кнопку звук, то меняем состояние звука
        private void bnfImgBtnVolume_Click(object sender, EventArgs e)
        {
            //если звука нет
            if (mute)
            {
                wmp.settings.mute = false;//включаем звук
                mute = false;
                ChangeImageVolume();//меняем иконку
            }
            else
            {
                wmp.settings.mute = true;//убираем звук
                mute = true;
                bnfImgBtnVolume.Image = Properties.Resources.Mute_96px;
            }
            
        }

        //меняем иконку звука при различной громкости
        private void ChangeImageVolume()
        {
            //в соответсвие с указаной громкостью меняем иконку звука
            if (wmp.settings.volume < 33)
            {
                bnfImgBtnVolume.Image = Properties.Resources.Low_Volume_96px;
            }
            else if (wmp.settings.volume >= 33 && wmp.settings.volume < 66)
            {
                bnfImgBtnVolume.Image = Properties.Resources.Medium_Volume_96px;
            }
            else if (wmp.settings.volume >= 66)
            {
                bnfImgBtnVolume.Image = Properties.Resources.High_Volume_96px;
            }
        }

        //при выборе песни прямо в плейлисте (двойной клик мышкой по треку)
        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //меняем текущий трек
            try
            {
                indexCurTrack = listBoxPlaylist.SelectedIndex;

                wmp.URL = paths[indexCurTrack];

                //запускаем трек
                SettingPlayTrack();
            }
            catch (IndexOutOfRangeException)
            {
                //выход за границы листобокса
            }
        }

        //воспроизвести следующий трек
        private void bnfImgBtnNextTrack_Click(object sender, EventArgs e)
        {
            PlayNextPrevious(1);
        }

        //настройки для следующего трека  (-1 - предыдущий; 0 - повтор текущего, 1 - следуюий в плейлисте)
        private void PlayNextPrevious(short nextTrack)
        {
            try
            {
                //проверяем включена ли функция повтора трека
                if (isRepeat)
                {
                    nextTrack = 0;
                }

                //меняем текущий трек
                //если есть следущуий трек воспроизводим его
                if ((nextTrack == 1) && (indexCurTrack + 1 < listBoxPlaylist.Items.Count))
                {
                    indexCurTrack++;
                }
                //если нет следующего - переходим к первому
                else if ((nextTrack == 1) && (indexCurTrack + 1 >= listBoxPlaylist.Items.Count))
                {
                    indexCurTrack = 0;
                }
                //если есть предыдущий - выбираем его
                else if ((nextTrack == -1) && (indexCurTrack - 1 >= 0))
                {
                    indexCurTrack--;
                }
                //если предыдущего нет, то выбираем последний трек
                else if ((nextTrack == -1) && (indexCurTrack - 1 < 0))
                {
                    indexCurTrack = listBoxPlaylist.Items.Count - 1;
                }

                //иначе - будет воспроизведен текущий трек(повтор)
                Console.WriteLine("Индекс:" + indexCurTrack);
                wmp.URL = paths[indexCurTrack];
                //запускаем трек
                SettingPlayTrack();
            }
            catch (Exception)
            {
               // MessageBox.Show("Не нужно нажимать все подряд!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //воспроизвести предыдущий трек
        private void bnfImgBtnPreviousTrack_Click(object sender, EventArgs e)
        {
            PlayNextPrevious(-1);
        }

        //регулировка громкости
        private void bunifuSliderVolume_ValueChanged(object sender, EventArgs e)
        {
            //так как максимальное значения TrackBar = 100, то при прокрутке громкость меняется на соответсующее значение
            wmp.settings.volume = bunifuSliderVolume.Value;

            //меняем иконку
            ChangeImageVolume();
        }

        //переход к следующему треку после окончания текущего
        private void bunifuProgressBar_progressChanged(object sender, EventArgs e)
        {
            //переходим к следующему треку
            if (bunifuProgressBar.Value == bunifuProgressBar.MaximumValue)
            {
                PlayNextPrevious(1);
            }
        }

        //кнопка включения повтора трека
        private void bnfImgBtnRepeat_Click(object sender, EventArgs e)
        {
            //если функция повтора была включена - отключаем
            if (isRepeat)
            {
                //меняем иконку)
                bnfImgBtnRepeat.Image = Properties.Resources.Repeat_white__96px;
                //повтор трека выключен
                isRepeat = false;
            }
            //иначе - включаем повтор трека
            else
            {
                //посдвечиваем(меняем иконку) 
                bnfImgBtnRepeat.Image = Properties.Resources.Repeat_96px;
                //повтор трека включен
                isRepeat = true;
            }
        }

        //вкл-выкл режим аудиокниги
        private void bnfImgBtnAudiobookMode_Click(object sender, EventArgs e)
        {
            //если режим аудиокниги включен - выключаем 
            if (audiobookMode)
            {
                audiobookMode = false;
                bnfImgBtnAudiobookMode.Image = Properties.Resources.Book_96px;
            }
            //иначе - включаем
            else
            {
                audiobookMode = true;
                bnfImgBtnAudiobookMode.Image = Properties.Resources.Book_on__96px;
            }
        }

    }
}
