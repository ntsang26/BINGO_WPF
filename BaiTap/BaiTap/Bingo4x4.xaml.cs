﻿using System;
using System.Collections;
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
using System.Windows.Threading;
using System.IO.Packaging;
using System.Windows.Media.Animation;


namespace BaiTap
{
    /// <summary>
    /// Interaction logic for Bingo4x4.xaml
    /// </summary>
    public partial class Bingo4x4 : Page
    {
        public string Key { get; set; }
        public int number;
        StartGame start = new StartGame();
        public Bingo4x4(string mess)
        {
            InitializeComponent();
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/backgroundMain4x4.jpg"));
            this.Background = imageBrush;
            Key = mess;
        }
        public string[,] StringArray = new string[4, 4];
        public List<string> list = new List<string>
        {
            "1", "2", "3", "4", "5",
            "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15",
            "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25",
            "26", "27", "28", "29", "30",
            "31", "32", "33", "34", "35",
            "36", "37", "38", "39", "40",
            "41", "42", "43", "44", "45",
            "46", "47", "48", "49", "50",
            "51", "52", "53", "54", "55",
            "56", "57", "58", "59", "60",
            "61", "62", "63", "64", "65",
            "66", "67", "68", "69", "70",
            "71", "72", "73", "74", "75",
        };

        public List<string> list2 = new List<string>
        {
             "1", "2", "3", "4", "5",
            "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15",
            "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25",
            "26", "27", "28", "29", "30",
            "31", "32", "33", "34", "35",
            "36", "37", "38", "39", "40",
            "41", "42", "43", "44", "45",
            "46", "47", "48", "49", "50",
            "51", "52", "53", "54", "55",
            "56", "57", "58", "59", "60",
            "61", "62", "63", "64", "65",
            "66", "67", "68", "69", "70",
            "71", "72", "73", "74", "75",
        };

        public List<string> listE = new List<string>
        {
             "1", "2", "3", "4", "5",
            "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15",
            "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25",
            "26", "27", "28", "29", "30",
            "31", "32", "33", "34", "35",
        };

        public List<string> listE2 = new List<string>
        {
             "1", "2", "3", "4", "5",
            "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15",
            "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25",
            "26", "27", "28", "29", "30",
            "31", "32", "33", "34", "35",
        };

        public List<string> listN = new List<string>
        {
             "1", "2", "3", "4", "5",
            "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15",
            "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25",
            "26", "27", "28", "29", "30",
            "31", "32", "33", "34", "35",
            "36", "37", "38", "39", "40",
            "41", "42", "43", "44", "45",
            "46", "47", "48", "49", "50",
        };

        public List<string> listN2 = new List<string>
        {
             "1", "2", "3", "4", "5",
            "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15",
            "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25",
            "26", "27", "28", "29", "30",
            "31", "32", "33", "34", "35",
            "36", "37", "38", "39", "40",
            "41", "42", "43", "44", "45",
            "46", "47", "48", "49", "50",
        };
        public List<string> listRs = new List<string>
        {
             "1", "2", "3", "4", "5",
            "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15",
            "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25",
            "26", "27", "28", "29", "30",
            "31", "32", "33", "34", "35",
            "36", "37", "38", "39", "40",
            "41", "42", "43", "44", "45",
            "46", "47", "48", "49", "50",
            "51", "52", "53", "54", "55",
            "56", "57", "58", "59", "60",
            "61", "62", "63", "64", "65",
            "66", "67", "68", "69", "70",
            "71", "72", "73", "74", "75",
        };
        public List<string> list3 = new List<string>
        {
             "1", "2", "3", "4", "5",
            "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15",
            "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25",
            "26", "27", "28", "29", "30",
            "31", "32", "33", "34", "35",
            "36", "37", "38", "39", "40",
            "41", "42", "43", "44", "45",
            "46", "47", "48", "49", "50",
            "51", "52", "53", "54", "55",
            "56", "57", "58", "59", "60",
            "61", "62", "63", "64", "65",
            "66", "67", "68", "69", "70",
            "71", "72", "73", "74", "75",
        };
        public List<string> listLabel = new List<string>
        {

        };
        public List<string> listCorect = new List<string>
        {

        };
        public List<string> listButton = new List<string>
        {

        };

        public List<string> game = new List<string>
        {
            "CHƠI LẠI",
            "TRỢ GIÚP",
            "QUAY VỀ"
        };

        public List<string> game1 = new List<string>
        {
            "CHƠI LẠI",
            "QUAY VỀ"
        };

        public List<int> index1 = new List<int>
        {
            150,
            220,
            290
        };

        MediaPlayer mediaPlayer1 = new MediaPlayer();
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public MediaPlayer mediaPlayer = new MediaPlayer();

        public string arr = "";
        Random rd = new Random();
        public int index = 1;
        public string temp = "";
        public int checkRoll = 1;
        public int checkBall;
        public bool checkWin = false;
        public string MyString = "     Chế độ 4x4 dễ gồm số từ 1 đến 35 và chỉ có 28 số trong 35 số được chọn, bạn cần tìm các số trong thẻ Bingo trùng với 1 trong 28 số đó.";
        public string MyString1 = "     Chế độ 4x4 thường gồm số từ 1 đến 50 và chỉ có 44 số trong 50 số được chọn, bạn cần tìm các số trong thẻ Bingo trùng với 1 trong 44 số đó.";
        public string MyString2 = "     Chế độ 4x4 khó gồm số từ 1 đến 75 và chỉ có 50 số trong 75 số được chọn, bạn cần tìm các số trong thẻ Bingo trùng với 1 trong 50 số đó.";

        // Create thẻ Bingo và CheckWin
        public void cardGame()
        {
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    switch (Key)
                    {
                        case "Easy":
                            arr = listE[rd.Next(listE.Count)];
                            listE.Remove(arr);
                            break;
                        case "Normal":
                            arr = listN[rd.Next(listN.Count)];
                            listN.Remove(arr);
                            break;
                        case "Hard":
                            arr = list[rd.Next(list.Count)];
                            list.Remove(arr);
                            break;
                    }; 
                    Button button = new Button();
                    Button button1 = new Button();
                    button.Name = "btn" + index;
                    button.BorderBrush = null;
                    button.FontSize = 20;
                    button.FontWeight = FontWeights.Bold;
                    button.Content = arr;
                    listButton.Add("label" + button.Content);
                    button.Background = null;
                    Grid.SetColumn(button, i);
                    Grid.SetRow(button, j);
                    var margin = button.Margin;
                    margin.Top = 9;
                    margin.Left = 9;
                    margin.Right = 9;
                    margin.Bottom = 9;
                    button.Margin = margin;
                    grid_button.Children.Add(button);

                    canvasControl.Children.Add(button1);
                    for (var r = 0; r < 4; r++)
                    {
                        StringArray[i, j] = "label" + button.Content;
                    }

                    button.Click += (sender, args) =>
                    {
                        mediaPlayer1.Open(new Uri(start.Path + "\\BINGO_WPF\\music\\buttonGame.mp3"));
                        mediaPlayer1.Play();
                        ImageBrush myBrush1 = new ImageBrush();
                        foreach (var value in listCorect)
                        {
                            if (value == "label" + button.Content)
                            {
                                myBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/star.png"));
                                button.Background = myBrush1;
                                for (var m = 0; m < 4; m++)
                                {
                                    for (var n = 0; n < 4; n++)
                                    {
                                        if (StringArray[m, n] == "label" + button.Content)
                                        {
                                            StringArray[m, n] = "*";
                                        }
                                    }
                                }
                            }
                            else
                            {

                            }



                            int count1 = 0;
                            int count2 = 0;
                            int count3 = 0;
                            int count4 = 0;
                            int count5 = 0;
                            int count6 = 0;
                            int count7 = 0;
                            int count8 = 0;
                            int count9 = 0;
                            int count10 = 0;
                            for (var i = 0; i < 4; ++i)
                            {
                                for (var j = 0; j < 4; ++j)
                                {
                                    if (StringArray[i, j] == "*" && i == 0)
                                    {
                                        count1++;
                                    }
                                    if (StringArray[i, j] == "*" && i == 1)
                                    {
                                        count2++;
                                    }
                                    if (StringArray[i, j] == "*" && i == 2)
                                    {
                                        count3++;
                                    }
                                    if (StringArray[i, j] == "*" && i == 3)
                                    {
                                        count8++;
                                    }
                                    if (StringArray[i, j] == "*" && j == 0)
                                    {
                                        count4++;
                                    }
                                    if (StringArray[i, j] == "*" && j == 1)
                                    {
                                        count5++;
                                    }
                                    if (StringArray[i, j] == "*" && j == 2)
                                    {
                                        count6++;
                                    }
                                    if (StringArray[i, j] == "*" && j == 3)
                                    {
                                        count7++;
                                    }
                                    if (StringArray[i, j] == "*" && i == j)
                                    {
                                        count9++;
                                    }
                                    if ((StringArray[i, j] == "*" && (i == 1 && j == 2))
                                    || (StringArray[i, j] == "*" && (i == 2 && j == 1))
                                    || (StringArray[i, j] == "*" && (i == 0 && j == 3))
                                    || (StringArray[i, j] == "*" && (i == 3 && j == 0)))
                                    {
                                        count10++;
                                    }

                                }
                            }
                            if (count1 == 4 || count2 == 4 || count3 == 4
                                    || count4 == 4 || count5 == 4 || count6 == 4
                                        || count7 == 4 || count8 == 4 || count9 == 4
                                            || count10 == 4)
                            {
                                checkWin = true;
                            }

                        };
                        index++;

                    };

                    list.Remove(arr);

                }
            }

        }

        // Kiểm tra số rand và Tính số còn lại + bảng số
        public void checkNum(bool temp)
        {
            for (int i = 1; i <= list3.Count; ++i)
            {
                if (temp == true)
                {
                    TextBlock tbCount = new TextBlock();
                    if (checkBall < 0)
                    {
                        if (checkBall < 0)
                        {
                            tbCount.Text = "Còn lại " + 0 + " số";
                        }
                        else
                        {
                            tbCount.Text = "Còn lại " + checkBall.ToString() + " số";
                        }
                        tbCount.Text = "Còn lại " + 0 + " số";
                    }
                    else
                    {
                        tbCount.Text = "Còn lại " + checkBall.ToString() + " số";
                    }
                    tbCount.Width = 110;
                    tbCount.FontSize = 16;
                    tbCount.FontFamily = new FontFamily("Arial");
                    Canvas.SetBottom(tbCount, 13);
                    Canvas.SetLeft(tbCount, 35);
                    tbCount.TextAlignment = TextAlignment.Center;
                    canvasCountDown.Children.Add(tbCount);
                }
                
                Label label = new Label();
                label.FontFamily = new FontFamily("Roboto");
                label.Name = "label" + i;
                label.Content = i;
                label.FontSize = 10;
                label.BorderBrush = new SolidColorBrush(Colors.Black);
                var padding = label.Padding;
                padding.Top = 5;
                if (i >= 1 && i <= 9)
                {
                    padding.Left = 9;
                    padding.Right = 9;
                }
                else
                {
                    padding.Left = 6;
                    padding.Right = 6;
                }
                padding.Bottom = 5;
                label.Padding = padding;
                label.HorizontalContentAlignment = HorizontalAlignment.Center;
                if (i >= 1 && i <= 15)
                {
                    wrap1.Children.Add(label);
                    if (i == 1)
                    {
                        label.BorderThickness = new Thickness(1, 3, 0, 1);
                    }
                    else
                    {
                        label.BorderThickness = new Thickness(1, 0, 0, 1);
                    }
                }
                if (i >= 16 && i <= 30)
                {
                    wrap2.Children.Add(label);
                    if (i == 16)
                    {
                        label.BorderThickness = new Thickness(1, 3, 0, 1);
                    }
                    else
                    {
                        label.BorderThickness = new Thickness(1, 0, 0, 1);
                    }

                }
                if (i >= 31 && i <= 45)
                {
                    wrap3.Children.Add(label);
                    if (i == 31)
                    {
                        label.BorderThickness = new Thickness(1, 3, 0, 1);
                    }
                    else
                    {
                        label.BorderThickness = new Thickness(1, 0, 0, 1);
                    }
                }
                if (i >= 46 && i <= 60)
                {
                    wrap4.Children.Add(label);
                    if (i == 46)
                    {
                        label.BorderThickness = new Thickness(1, 3, 0, 1);
                    }
                    else
                    {
                        label.BorderThickness = new Thickness(1, 0, 0, 1);
                    }
                }
                if (i >= 61 && i <= 75)
                {

                    wrap5.Children.Add(label);
                    if (i == 61)
                    {
                        label.BorderThickness = new Thickness(1, 3, 1, 1);
                    }
                    else
                    {
                        label.BorderThickness = new Thickness(1, 0, 1, 1);
                    }
                }

                label.FontWeight = FontWeights.Bold;
                for (int j = 0; j < listLabel.Count; ++j)
                {
                    if ("label" + i == listLabel[j])
                    {
                        if (i >= 1 && i <= 15)
                        {
                            label.Background = Brushes.DarkRed;
                            label.Foreground = Brushes.White;

                        }
                        else if (i >= 16 && i <= 30)
                        {
                            label.Background = Brushes.DarkOrange;
                            label.Foreground = Brushes.White;

                        }
                        else if (i >= 31 && i <= 45)
                        {
                            label.Background = Brushes.DarkBlue;
                            label.Foreground = Brushes.White;

                        }
                        else if (i >= 46 && i <= 60)
                        {
                            label.Background = Brushes.DarkGreen;
                            label.Foreground = Brushes.White;

                        }
                        else if (i >= 61 && i <= 75)
                        {
                            label.Background = Brushes.Purple;
                            label.Foreground = Brushes.White;

                        }

                        listCorect.Add(label.Name);


                    }
                }
            }


        }

        // Rand số và kiểm tra 
        public void startGame()
        {
            switch (Key)
            {
                case "Easy":
                    temp = listE2[rd.Next(listE2.Count)];
                    listLabel.Add("label" + temp);
                    tbShow.Text = temp;
                    listE2.Remove(temp);
                    listE2 = new List<string>(listE2);
                    break;
                case "Normal":
                    temp = listN2[rd.Next(listN2.Count)];
                    listLabel.Add("label" + temp);
                    tbShow.Text = temp;
                    listN2.Remove(temp);
                    listN2 = new List<string>(listN2);
                    break;
                case "Hard":
                    temp = list2[rd.Next(list2.Count)];
                    listLabel.Add("label" + temp);
                    tbShow.Text = temp;
                    list2.Remove(temp);
                    list2 = new List<string>(list2);
                    break;
            };
        }

        // Nhạc game
        private void startTime(bool what)
        {
            if (what == true)
            {
                mediaPlayer.Open(new Uri(start.Path + "\\BINGO_WPF\\music\\musicMap44.mp3"));
                mediaPlayer.Play();
                timer.Interval = new TimeSpan(0, 3, 0);
                timer.Tick += (sender, args) =>
                {
                    mediaPlayer.Stop();
                    mediaPlayer.Open(new Uri(start.Path + "\\BINGO_WPF\\music\\musicMap44.mp3"));
                    mediaPlayer.Play();
                };
                timer.Start();
            }

            if (what == false)
            {
                mediaPlayer.Stop();
                timer.Stop();
            }
        }

        // Tab Menu
        public void tabMenu()
        {
            Canvas canvas = new Canvas();
            canvas.Height = 500;
            canvas.Width = 850;
            ImageBrush myBrush1 = new ImageBrush();
            myBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/backgroundMenu.png"));
            canvas.Background = myBrush1;

            MediaPlayer mediaPlayer1 = new MediaPlayer();
            mediaPlayer1.Open(new Uri(start.Path + "\\BINGO_WPF\\music\\button.mp3"));
            //
            for (var i = 0; i < 3; i++)
            {
                Button button = new Button();
                Button buttonC = new Button();
                ImageBrush myBrushButton = new ImageBrush();
                myBrushButton.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/buttonStart.png"));
                ImageBrush myBrushButtonC = new ImageBrush();
                myBrushButtonC.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/buttonClose.png"));
                // Create a new style for the button
                Style myButtonStyle = new Style(typeof(Button));
                Style myButtonStyle1 = new Style(typeof(Button));
                Style myButtonStyleC = new Style(typeof(Button));

                // Set the template for the button to a new control template
                ControlTemplate myButtonTemplate = new ControlTemplate(typeof(Button));
                ControlTemplate myButtonTemplate1 = new ControlTemplate(typeof(Button));

                // Create a new Border element and add it to the template
                FrameworkElementFactory borderFactory = new FrameworkElementFactory(typeof(Border));
                FrameworkElementFactory borderFactory1 = new FrameworkElementFactory(typeof(Border));
                borderFactory.SetValue(Border.BorderThicknessProperty, new Thickness(0));
                borderFactory.SetValue(Border.BackgroundProperty, myBrushButton);
                borderFactory1.SetValue(Border.BackgroundProperty, myBrushButtonC);
                borderFactory.SetValue(Border.PaddingProperty, new Thickness(0));
                borderFactory.SetValue(Border.MarginProperty, new Thickness(0));
                borderFactory.SetValue(Border.SnapsToDevicePixelsProperty, true);
                myButtonTemplate.VisualTree = borderFactory;
                myButtonTemplate1.VisualTree = borderFactory1;
                myButtonStyle.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate));
                myButtonStyleC.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate1));
                myButtonStyle1.Setters.Remove(new Setter(Button.TemplateProperty, myButtonTemplate));
                button.MouseMove += (sender, args) =>
                {
                    button.Style = myButtonStyle;
                };
                button.MouseLeave += (sender, args) =>
                {
                    button.Style = myButtonStyle1;
                };
                buttonC.Style = myButtonStyleC;
                button.FontWeight = FontWeights.Bold;
                buttonC.FontWeight = FontWeights.Bold;
                button.Background = myBrushButton;
                button.Width = 200;
                button.Height = 50;
                buttonC.BorderBrush = null;
                buttonC.Background = myBrushButtonC;
                button.Cursor = Cursors.Hand;
                buttonC.Cursor = Cursors.Hand;
                buttonC.Click += (sender, args) =>
                {
                    mediaPlayer1.Play();
                    grid4x4.Children.Remove(canvas);
                };
                buttonC.Width = 60;
                MainWindow main = new MainWindow();
                buttonC.Height = 60;
                var margin1 = buttonC.Margin;
                margin1.Top = 40;
                margin1.Left = main.Width / 2 + buttonC.Width * 2 + 13;
                buttonC.Margin = margin1;
                Canvas.SetTop(buttonC, 30);
                //
                button.Content = game[i];
                button.FontFamily = new FontFamily("Arial");
                button.Foreground = Brushes.White;
                button.FontSize = 18;
                button.BorderBrush = null;
                button.Name = "button" + i + 1;
                var margin = button.Margin;
                margin.Top = 110;
                if (i == 0)
                {
                    Canvas.SetTop(button, index1[i] - 100);
                }
                else if (i == 1)
                {
                    Canvas.SetTop(button, index1[i] - 100);
                }
                else if (i == 2)
                {
                    Canvas.SetTop(button, index1[i] - 100);
                }
                margin.Left = main.Width / 2 - button.Width / 2;
                button.Margin = margin;
                canvas.Children.Add(button);
                canvas.Children.Add(buttonC);
                var marginCanvas = canvas.Margin;
                margin.Left = -145;
                margin.Top = -38;
                canvas.Margin = margin;

                switch (button.Content)
                {
                    case "CHƠI LẠI":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            this.NavigationService.Navigate(new Bingo4x4(Key));
                            startTime(false);
                        };
                        break;
                    case "TRỢ GIÚP":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            tabInfo(false);

                        };
                        break;
                    case "QUAY VỀ":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            this.NavigationService.Navigate(new StartGame());
                            startTime(false);
                        };
                        break;
                }
            }
            //
            Grid.SetColumn(canvas, 1);
            grid4x4.Children.Add(canvas);
        }

        // Tab kết quả game
        public void tabResult()
        {
            Canvas canvas = new Canvas();
            canvas.Height = 500;
            canvas.Width = 850;
            ImageBrush myBrush1 = new ImageBrush();
            myBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/backgroundMenu.png"));
            canvas.Background = myBrush1;

            MediaPlayer mediaPlayer1 = new MediaPlayer();
            mediaPlayer1.Open(new Uri(start.Path + "\\BINGO_WPF\\music\\button.mp3"));
            //
            for (var i = 0; i < 2; i++)
            {
                Button button = new Button();
                Button buttonC = new Button();
                ImageBrush myBrushButton = new ImageBrush();
                myBrushButton.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/buttonStart.png"));
                ImageBrush myBrushButtonC = new ImageBrush();
                myBrushButtonC.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/buttonClose.png"));
                // Create a new style for the button
                Style myButtonStyle = new Style(typeof(Button));
                Style myButtonStyle1 = new Style(typeof(Button));
                Style myButtonStyleC = new Style(typeof(Button));

                // Set the template for the button to a new control template
                ControlTemplate myButtonTemplate = new ControlTemplate(typeof(Button));
                ControlTemplate myButtonTemplate1 = new ControlTemplate(typeof(Button));

                // Create a new Border element and add it to the template
                FrameworkElementFactory borderFactory = new FrameworkElementFactory(typeof(Border));
                FrameworkElementFactory borderFactory1 = new FrameworkElementFactory(typeof(Border));
                borderFactory.SetValue(Border.BorderThicknessProperty, new Thickness(0));
                borderFactory.SetValue(Border.BackgroundProperty, myBrushButton);
                borderFactory1.SetValue(Border.BackgroundProperty, myBrushButtonC);
                borderFactory.SetValue(Border.PaddingProperty, new Thickness(0));
                borderFactory.SetValue(Border.MarginProperty, new Thickness(0));
                borderFactory.SetValue(Border.SnapsToDevicePixelsProperty, true);
                myButtonTemplate.VisualTree = borderFactory;
                myButtonTemplate1.VisualTree = borderFactory1;
                myButtonStyle.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate));
                myButtonStyleC.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate1));
                myButtonStyle1.Setters.Remove(new Setter(Button.TemplateProperty, myButtonTemplate));
                button.MouseMove += (sender, args) =>
                {
                    button.Style = myButtonStyle;
                };
                button.MouseLeave += (sender, args) =>
                {
                    button.Style = myButtonStyle1;
                };
                buttonC.Style = myButtonStyleC;
                button.FontWeight = FontWeights.Bold;
                buttonC.FontWeight = FontWeights.Bold;
                button.Background = myBrushButton;
                button.Width = 200;
                button.Height = 50;
                buttonC.BorderBrush = null;
                buttonC.Background = myBrushButtonC;
                button.Cursor = Cursors.Hand;
                buttonC.Cursor = Cursors.Hand;
                buttonC.Click += (sender, args) =>
                {
                    mediaPlayer1.Play();
                    grid4x4.Children.Remove(canvas);
                };
                buttonC.Width = 60;
                MainWindow main = new MainWindow();
                buttonC.Height = 60;
                var margin1 = buttonC.Margin;
                margin1.Top = 40;
                margin1.Left = main.Width / 2 + buttonC.Width * 2 + 13;
                buttonC.Margin = margin1;
                Canvas.SetTop(buttonC, 30);
                //
                button.Content = game1[i];
                button.FontFamily = new FontFamily("Arial");
                button.Foreground = Brushes.White;
                button.FontSize = 18;
                button.BorderBrush = null;
                button.Name = "button" + i + 1;
                var margin = button.Margin;
                margin.Top = 110;
                TextBlock textblock = new TextBlock();
                if (checkWin == false)
                {
                    textblock.Text = "YOU DIDN'T WIN !";
                }
                else
                {
                    textblock.Text = "YOU WIN !";
                }
                textblock.FontFamily = new FontFamily("Arial");
                textblock.Foreground = Brushes.Black;
                textblock.FontSize = 20;
                textblock.Width = main.Width;
                textblock.FontWeight = FontWeights.Bold;
                textblock.TextAlignment = TextAlignment.Center;
                Canvas.SetTop(textblock, 150);
                Canvas.SetLeft(textblock, main.Width / 2 - textblock.Width / 2);
                canvas.Children.Add(textblock);
                if (i == 0)
                {
                    Canvas.SetTop(button, index1[i + 1] - 100);
                }
                else if (i == 1)
                {
                    Canvas.SetTop(button, index1[i + 1] - 100);
                }
                else if (i == 2)
                {
                    Canvas.SetTop(button, index1[i] - 100);
                }
                margin.Left = main.Width / 2 - button.Width / 2;
                button.Margin = margin;
                canvas.Children.Add(button);
                var marginCanvas = canvas.Margin;
                margin.Left = -145;
                margin.Top = -38;
                canvas.Margin = margin;

                switch (button.Content)
                {
                    case "CHƠI LẠI":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            this.NavigationService.Navigate(new Bingo4x4(Key));
                            startTime(false);
                        };
                        break;
                    case "QUAY VỀ":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            this.NavigationService.Navigate(new StartGame());
                            startTime(false);
                        };
                        break;
                }
            }
            //
            Grid.SetColumn(canvas, 1);
            grid4x4.Children.Add(canvas);
        }

        public void tabInfo(bool check)
        {
            Canvas canvas = new Canvas();
            canvas.Height = 500;
            canvas.Width = 850;
            //
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/back_nv.png"));
            image.Height = 300;
            TextBlock text = new TextBlock();
            text.Width = 350;
            text.Height = 500;
            text.TextWrapping = TextWrapping.Wrap;
            switch (Key)
            {
                case "Easy":
                    text.Text = MyString;
                    break;
                case "Normal":
                    text.Text = MyString1;
                    break;
                case "Hard":
                    text.Text = MyString2;
                    break;
            }
            text.FontSize = 18;
            text.FontFamily = new FontFamily("Arial");
            Canvas.SetTop(text, 155);
            Canvas.SetLeft(text, 245);
            canvas.Children.Add(text);
            //
            ImageBrush myBrush1 = new ImageBrush();
            myBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/back_tabInfo.png"));
            canvas.Background = myBrush1;

            MediaPlayer mediaPlayer1 = new MediaPlayer();
            mediaPlayer1.Open(new Uri(start.Path + "\\BINGO_WPF\\music\\button.mp3"));
            //
            Button buttonC = new Button();
            ImageBrush myBrushButtonC = new ImageBrush();
            if (check == true)
            {
                myBrushButtonC.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo3x3/buttonPlay.png"));
            }
            else
            {
                myBrushButtonC.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo3x3/buttonContinue.png"));
            }
            // Create a new style for the button
            Style myButtonStyleC = new Style(typeof(Button));

            // Set the template for the button to a new control template
            ControlTemplate myButtonTemplate = new ControlTemplate(typeof(Button));
            ControlTemplate myButtonTemplate1 = new ControlTemplate(typeof(Button));

            // Create a new Border element and add it to the template
            FrameworkElementFactory borderFactory1 = new FrameworkElementFactory(typeof(Border));
            borderFactory1.SetValue(Border.BackgroundProperty, myBrushButtonC);
            myButtonTemplate1.VisualTree = borderFactory1;
            myButtonStyleC.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate1));
            buttonC.Style = myButtonStyleC;
            buttonC.BorderBrush = null;
            buttonC.Background = myBrushButtonC;
            buttonC.Cursor = Cursors.Hand;
            buttonC.Click += (sender, args) =>
            {
                mediaPlayer1.Play();
                if (check == true)
                {
                    autoNum(true);
                    checkNum(true);
                }
                grid4x4.Children.Remove(canvas);        
            };
            buttonC.Width = 120;
            MainWindow main = new MainWindow();
            buttonC.Height = 60;
            var margin = canvas.Margin;
            var margin1 = buttonC.Margin;
            margin1.Top = main.Height / 2 - 40;
            margin1.Left = main.Width / 2 - buttonC.Width / 2;
            buttonC.Margin = margin1;
            Canvas.SetTop(buttonC, 70);
            Canvas.SetTop(image, 20);
            Canvas.SetLeft(image, 0);
            canvas.Children.Add(buttonC);
            canvas.Children.Add(image);
            var marginCanvas = canvas.Margin;
            margin.Left = -145;
            margin.Top = -38;
            canvas.Margin = margin;
            //
            Grid.SetColumn(canvas, 1);
            grid4x4.Children.Add(canvas);
        }

        // On/Off Music
        public void buttonControler()
        {

            MediaPlayer mediaPlayer1 = new MediaPlayer();
            mediaPlayer1.Open(new Uri(start.Path + "\\BINGO_WPF\\music\\button.mp3"));
            ImageBrush myBrushButtonT = new ImageBrush();
            ImageBrush myBrushButtonF = new ImageBrush();
            ImageBrush myBrushButtonMenu = new ImageBrush();
            myBrushButtonT.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/music1.png"));
            myBrushButtonF.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/music2.png"));
            myBrushButtonMenu.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/menu.png"));
            Style myButtonStyleT = new Style(typeof(Button));
            Style myButtonStyleF = new Style(typeof(Button));
            Style myButtonStyleMenu = new Style(typeof(Button));
            ControlTemplate myButtonTemplate2 = new ControlTemplate(typeof(Button));
            ControlTemplate myButtonTemplate3 = new ControlTemplate(typeof(Button));
            ControlTemplate myButtonTemplate4 = new ControlTemplate(typeof(Button));
            FrameworkElementFactory borderFactory2 = new FrameworkElementFactory(typeof(Border));
            borderFactory2.SetValue(Border.BackgroundProperty, myBrushButtonT);
            FrameworkElementFactory borderFactory3 = new FrameworkElementFactory(typeof(Border));
            FrameworkElementFactory borderFactory4 = new FrameworkElementFactory(typeof(Border));
            myButtonTemplate2.VisualTree = borderFactory2;
            myButtonTemplate3.VisualTree = borderFactory3;
            myButtonTemplate4.VisualTree = borderFactory4;
            borderFactory3.SetValue(Border.BackgroundProperty, myBrushButtonF);
            borderFactory4.SetValue(Border.BackgroundProperty, myBrushButtonMenu);
            myButtonStyleT.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate2));
            myButtonStyleF.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate3));
            myButtonStyleMenu.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate4));
            Button buttonMusicT = new Button();
            Button buttonMusicF = new Button();
            Button buttonMusicMenu = new Button();
            buttonMusicT.Height = 40;
            buttonMusicT.Width = 42;
            buttonMusicF.Height = 40;
            buttonMusicF.Width = 42;
            buttonMusicMenu.Width = 40;
            buttonMusicMenu.Width = 42;
            var margin = buttonMusicF.Margin;
            margin.Left = 17;
            buttonMusicF.Margin = margin;
            buttonMusicT.Margin = margin;
            buttonMusicMenu.Margin = margin;
            buttonMusicT.Cursor = Cursors.Hand;
            buttonMusicF.Cursor = Cursors.Hand;
            buttonMusicMenu.Cursor = Cursors.Hand;
            buttonMusicF.Style = myButtonStyleF;
            buttonMusicT.Style = myButtonStyleT;
            buttonMusicMenu.Style = myButtonStyleMenu;
            wpControl.Children.Add(buttonMusicT);
            wpControl.Children.Add(buttonMusicMenu);
            buttonMusicT.Click += (sender, args) =>
            {
                mediaPlayer1.Play();
                wpControl.Children.Remove(buttonMusicT);
                wpControl.Children.Remove(buttonMusicMenu);
                wpControl.Children.Add(buttonMusicF);
                wpControl.Children.Add(buttonMusicMenu);
                startTime(false);
            };
            buttonMusicF.Click += (sender, args) =>
            {
                mediaPlayer1.Play();
                wpControl.Children.Remove(buttonMusicMenu);
                wpControl.Children.Remove(buttonMusicF);
                wpControl.Children.Add(buttonMusicT);
                wpControl.Children.Add(buttonMusicMenu);
                startTime(true);
            };
            buttonMusicMenu.Click += (sender, args) =>
            {
                mediaPlayer1.Play();
                tabMenu();
            };

        }

        // Set Style Button Bingo
        public void Controler()
        {
            MediaPlayer mediaPlayer1 = new MediaPlayer();
            mediaPlayer1.Open(new Uri(start.Path + "\\BINGO_WPF\\music\\button.mp3"));
            ImageBrush myBrushButtonC = new ImageBrush();
            myBrushButtonC.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/Bingo4x4/button_callBingo.png"));
            Style myButtonStyleC = new Style(typeof(Button));
            ControlTemplate myButtonTemplate1 = new ControlTemplate(typeof(Button));
            FrameworkElementFactory borderFactory1 = new FrameworkElementFactory(typeof(Border));
            borderFactory1.SetValue(Border.BackgroundProperty, myBrushButtonC);
            myButtonTemplate1.VisualTree = borderFactory1;
            myButtonStyleC.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate1));
            Button buttonCall = new Button();
            buttonCall.Height = 40;
            buttonCall.Width = 120;
            Canvas.SetBottom(buttonCall, -25);
            Canvas.SetLeft(buttonCall, 80);
            buttonCall.Style = myButtonStyleC;
            canvasGame.Children.Add(buttonCall);
            buttonCall.Cursor = Cursors.Hand;
            buttonCall.Click += (sender, args) =>
            {
                mediaPlayer1.Play();
                tabResult();
                autoNum(false);
            };

        }

        // Auto tạo số và kiểm tra
        public void autoNum(bool checkTime)
        {
            switch (Key)
            {
                case "Easy":
                    number = 28;
                    checkBall = 27;
                    break;
                case "Normal":
                    number = 34;
                    checkBall = 33;
                    break;
                case "Hard":
                    number = 40;
                    checkBall = 39;
                    break;
            };
            if (checkTime == true)
            {
                dispatcherTimer.Tick += (sender, args) =>
                {
                    checkBall--;
                    wrap1.Children.RemoveRange(0, wrap1.Children.Count);
                    wrap2.Children.RemoveRange(0, wrap2.Children.Count);
                    wrap3.Children.RemoveRange(0, wrap3.Children.Count);
                    wrap4.Children.RemoveRange(0, wrap4.Children.Count);
                    wrap5.Children.RemoveRange(0, wrap5.Children.Count);
                    canvasCountDown.Children.RemoveRange(0, canvasCountDown.Children.Count);
                    if (checkBall < 0)
                    {

                    }
                    else
                    {
                        startGame();
                    }

                    checkNum(true);
                    checkRoll++;

                    if (checkRoll >= number + 1 || checkTime == false)
                    {
                        dispatcherTimer.Stop();
                        tabResult();
                    }
                };
                dispatcherTimer.Interval = TimeSpan.FromMilliseconds(5000);
                dispatcherTimer.Start();
            }
            else
            {
                dispatcherTimer.Stop();
            }

        }

        // Load Form
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tbMode.Text = Key;
            tabInfo(true);
            startGame();
            checkNum(false);
            Controler();
            buttonControler();
            startTime(true);
            cardGame();
        }

    }
}

