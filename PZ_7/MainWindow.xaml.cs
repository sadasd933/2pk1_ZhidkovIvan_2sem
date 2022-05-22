using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace PZ_77
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string path = @"Data\";
        bool isBold;
        bool isItalic;
        bool isUnderline;
        public bool isShowListFiles = false;
        public bool isText = true;
        public string sample;
        public MainWindow()
        {
            InitializeComponent();
            if (isShowListFiles == false)
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                if (!dir.Exists)
                {
                    dir.Create();
                }
                else
                {
                    FileInfo[] files = dir.GetFiles("*.txt");
                    foreach (FileInfo fi in files)
                    {
                        FileList.Items.Add(fi.ToString());
                    }
                    isShowListFiles = true;
                    isShowListFiles = false;
                }
            }
        }

        private void openFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            int row = MainText.GetLineIndexFromCharacterIndex(MainText.CaretIndex);
            int col = MainText.CaretIndex - MainText.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Saved";
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Текстик (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                StreamReader reader = new StreamReader(fileInfo.Open(FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251));

                MainText.Text = reader.ReadToEnd();

                reader.Close();
                return;
            }
        }

        private void newFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
                if (createFileWindow.ShowDialog() == true)
                {
                    File.Create(path + $"{createFileWindow.FileName}" + ".txt");
                    FileList.Items.Add($"{createFileWindow.FileName}" + ".txt");
                }
            createFileWindow.Close();
        }

        private void saveFile_Click(object sender, RoutedEventArgs e)
        {
            int row = MainText.GetLineIndexFromCharacterIndex(MainText.CaretIndex);
            int col = MainText.CaretIndex - MainText.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Saved";
            string r = $"{FileList.SelectedItem}";
            StreamWriter streamWriter = new StreamWriter(path + r);
            streamWriter.WriteLine(MainText.Text);
            streamWriter.Close();
        }

        private void FileList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string r = $"{FileList.SelectedItem}";
            if (File.Exists(path + r))
            {
                MainText.Clear();
                FileStream open = new FileStream(path + $"{r}", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader file = new StreamReader(open);
                MainText.AppendText(file.ReadToEnd());
                file.Close();
            }
            //FileInfo file1 = new FileInfo(path + $"{FileList.SelectedItem}");
            //informait.Text = $"{file1.CreationTime}   {file1.Length / 1024} Кб";
            int row = MainText.GetLineIndexFromCharacterIndex(MainText.CaretIndex);
            int col = MainText.CaretIndex - MainText.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Saved";
        }

        private void Bold_button_Click(object sender, RoutedEventArgs e)
        {

                if (!isBold)
                    MainText.FontWeight = FontWeights.Bold;
                else
                    MainText.FontWeight = FontWeights.Normal;
                isBold = !isBold;

        }

        private void Kursiv_button_Click(object sender, RoutedEventArgs e)
        {
            if (!isItalic)
                MainText.FontStyle = FontStyles.Italic;
            else
                MainText.FontStyle = FontStyles.Normal;
            isItalic = !isItalic;
        }

        private void Polosa_pod_textom_button_Click(object sender, RoutedEventArgs e)
        {
            if (this.isUnderline)
            {
                this.MainText.TextDecorations.Add(TextDecorations.Underline);
            }
            else
            {
                foreach (var item in TextDecorations.Underline)
                {
                    this.MainText.TextDecorations.Remove(item);
                }
            }
            isUnderline = !isUnderline;
        }

        private void MainText_TextChanged(object sender, TextChangedEventArgs e)
        {
            int row = MainText.GetLineIndexFromCharacterIndex(MainText.CaretIndex);
            int col = MainText.CaretIndex - MainText.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Не сохранено";
        }

        private void Create_sample_Click(object sender, RoutedEventArgs e)
        {
            FileStream open = new FileStream(@"Sample\Sample.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(open);
            writer.WriteLine(MainText.Text);
            writer.Close();
        }

        private void Load_sample_Click(object sender, RoutedEventArgs e)
        {
            MainText.Clear();
            FileStream open = new FileStream(@"Sample\Sample.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(open);
            MainText.AppendText(reader.ReadToEnd());
            reader.Close();
        }

        private void deleteFile_Click(object sender, RoutedEventArgs e)
        {
            informait.Text = "0 Кб";
            string r = $"{FileList.SelectedItem}";
            if (File.Exists(path + r))
            {
                File.Delete(path + r);
            }
            FileList.Items.RemoveAt(FileList.SelectedIndex);
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AboutProgram program = new AboutProgram();
            program.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AboutAuthor autors = new AboutAuthor();
            autors.Show();
        }
    }
    
}
