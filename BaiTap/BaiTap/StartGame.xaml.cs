using Microsoft.Win32;
using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO.Packaging;

namespace BaiTap
{
    /// <summary>
    /// Interaction logic for StartGame.xaml
    /// </summary>
    public partial class StartGame : Page
    {
        public string Path = "E:\\Code\\Visual Repo";
        public int gameType { get; set; }
        public StartGame()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/backgroundStart.jpg"));
            this.Background = myBrush;
           
        }
        DispatcherTimer timer = new DispatcherTimer();
        // Nhạc game
        private void startTime(bool what)
        {
            if (what == true)
            {
                mediaPlayer.Open(new Uri(Path + "\\BINGO_WPF\\music\\gunny.mp3"));
                mediaPlayer.Play();
                timer.Interval = new TimeSpan(0, 2, 0);
                timer.Tick += (sender, args) =>
                {   
                    mediaPlayer.Stop();
                    mediaPlayer.Open(new Uri(Path + "\\BINGO_WPF\\music\\gunny.mp3"));
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

        public List<string> content = new List<string>
        {
           "CHƠI",
            "LUẬT CHƠI",
            "THOÁT"
        };

        public List<string> game = new List<string>
        {
            "3X3",
            "4X4",
            "5X5"
        };
        public List<string> gameMode = new List<string>
        {
            "DỄ",
            "TRUNG BÌNH",
            "KHÓ"
        };

        public List<int> index = new List<int>
        {
            150,
            220,
            290
        };

        public List<int> index1 = new List<int>
        {
            150,
            220,
            290
        };

        public bool checkMusic = true;

        public MediaPlayer mediaPlayer = new MediaPlayer();

        public string MyString = "Trong mỗi chế độ 3x3, 4x4, 5x5 sẽ có số lượng giới hạn số nhất định, bạn cần tìm những con số đó trùng với số trong phiếu của bạn. Sau khi hết số hệ thống sẽ kiểm tra và cho biết bạn có thắng hay không, nếu bạn chơi 3x3 hoặc 5x5 thì bạn cần tối thiểu 1 hàng ngang, 1 hàng dọc hoặc 1 đường chéo còn 4x4 thì chỉ cần tối thiểu 1 hàng hàng hoặc 1 hàng dọc.";
        // Tab Hướng dẫn
        public void Help()
        {
            Canvas canvas = new Canvas();
            canvas.Height = 465;
            TextBlock text = new TextBlock();
            text.Width = 600;
            text.Height = 500;
            text.TextWrapping = TextWrapping.Wrap;
            text.Text = MyString;
            text.FontSize = 18;
            text.FontFamily = new FontFamily("Arial");
            Canvas.SetTop(text, 100);
            Canvas.SetLeft(text, 130);
            canvas.Children.Add(text);
            ImageBrush myBrush1 = new ImageBrush();
            myBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/backgroundHelp.jpg"));
            canvas.Background = myBrush1;
            MediaPlayer mediaPlayer1 = new MediaPlayer();
            mediaPlayer1.Open(new Uri(Path+"\\BINGO_WPF\\music\\button.mp3"));
            //
            Button button = new Button();
            TextBlock textblock = new TextBlock();
            ImageBrush myBrushButton = new ImageBrush();
            myBrushButton.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/buttonStart.png"));
            // Create a new style for the button
            Style myButtonStyle = new Style(typeof(Button));
            Style myButtonStyle1 = new Style(typeof(Button));

            // Set the template for the button to a new control template
            ControlTemplate myButtonTemplate = new ControlTemplate(typeof(Button));
            ControlTemplate myButtonTemplate1 = new ControlTemplate(typeof(Button));

            // Create a new Border element and add it to the template
            FrameworkElementFactory borderFactory = new FrameworkElementFactory(typeof(Border));
            FrameworkElementFactory borderFactory1 = new FrameworkElementFactory(typeof(Border));
            borderFactory.SetValue(Border.BorderThicknessProperty, new Thickness(0));
            borderFactory.SetValue(Border.BackgroundProperty, myBrushButton);
            borderFactory.SetValue(Border.PaddingProperty, new Thickness(0));
            borderFactory.SetValue(Border.MarginProperty, new Thickness(0));
            borderFactory.SetValue(Border.SnapsToDevicePixelsProperty, true);
            myButtonTemplate.VisualTree = borderFactory;
            myButtonTemplate1.VisualTree = borderFactory1;
            myButtonStyle.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate));
            myButtonStyle1.Setters.Remove(new Setter(Button.TemplateProperty, myButtonTemplate));
            button.MouseMove += (sender, args) =>
            {
                button.Style = myButtonStyle;
            };
            button.MouseLeave += (sender, args) =>
            {
                button.Style = myButtonStyle1;
            };
            button.Click += (sender, args) =>
            {
                gridStart.Children.Remove(canvas);
                MediaPlayer mediaPlayer1 = new MediaPlayer();
                mediaPlayer1.Open(new Uri(Path + "\\BINGO_WPF\\music\\button.mp3"));
                mediaPlayer1.Play();
            };
            button.Background = myBrushButton;
            button.Width = 200;
            button.Height = 50;
            button.Cursor = Cursors.Hand;
            MainWindow main = new MainWindow();
            var margin = button.Margin;
            margin.Top = 110;
            margin.Left = main.Width / 2 - button.Width / 2;
            //
            textblock.Text = "LUẬT CHƠI";
            textblock.FontFamily = new FontFamily("Arial");
            textblock.Foreground = Brushes.White;
            textblock.FontSize = 20;
            textblock.Width = main.Width;
            textblock.FontWeight = FontWeights.Bold;
            Canvas.SetTop(textblock, 35);
            textblock.TextAlignment = TextAlignment.Center;
            canvas.Children.Add(textblock);
            //
            button.Content = "TRỞ VỀ";
            button.FontWeight = FontWeights.Bold;
            button.FontFamily = new FontFamily("Arial");
            button.Foreground = Brushes.White;
            button.FontSize = 18;
            button.BorderBrush = null;
            button.Name = "buttonBack";
            Canvas.SetBottom(button, 30);
            button.Margin = margin;
            canvas.Children.Add(button);
            //
            gridStart.Children.Add(canvas);
        }

        // Tab Chế độ game
        public void tabGameMode()
        {
            Canvas canvas = new Canvas();
            canvas.Height = 500;
            canvas.Width = 850;
            ImageBrush myBrush1 = new ImageBrush();
            myBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/backgroundMenu.png"));
            canvas.Background = myBrush1;

            MediaPlayer mediaPlayer1 = new MediaPlayer();
            mediaPlayer1.Open(new Uri(Path + "\\BINGO_WPF\\music\\button.mp3"));
            //
            for (var i = 0; i < 3; i++)
            {
                Button button = new Button();
                Button buttonC = new Button();
                ImageBrush myBrushButton = new ImageBrush();
                myBrushButton.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/buttonStart.png"));
                ImageBrush myBrushButtonC = new ImageBrush();
                myBrushButtonC.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/buttonClose.png"));
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
                    gridStart.Children.Remove(canvas);
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
                button.Content = gameMode[i];
                button.FontFamily = new FontFamily("Arial");
                button.Foreground = Brushes.White;
                button.FontSize = 18;
                button.BorderBrush = null;
                button.Name = "button" + i + 1;
                var margin = button.Margin;
                margin.Top = 110;
                if (i == 0)
                {
                    Canvas.SetTop(button, index[i] - 100);
                }
                else if (i == 1)
                {
                    Canvas.SetTop(button, index[i] - 100);
                }
                else if (i == 2)
                {
                    Canvas.SetTop(button, index[i] - 100);
                }
                margin.Left = main.Width / 2 - button.Width / 2;
                button.Margin = margin;
                canvas.Children.Add(button);
                canvas.Children.Add(buttonC);

                switch (button.Content)
                {
                    case "DỄ":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            if(gameType == 1)
                            {
                                this.NavigationService.Navigate(new Bingo3x3("DỄ"));
                            }else if(gameType == 2)
                            {
                                this.NavigationService.Navigate(new Bingo4x4("DỄ"));
                            }else if(gameType == 3)
                            {
                                this.NavigationService.Navigate(new Bingo5x5("DỄ"));
                            }
                            startTime(false);
                        };
                        break;
                    case "TRUNG BÌNH":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            if (gameType == 1)
                            {
                                this.NavigationService.Navigate(new Bingo3x3("TRUNG BÌNH"));
                            }
                            else if (gameType == 2)
                            {
                                this.NavigationService.Navigate(new Bingo4x4("TRUNG BÌNH"));
                            }
                            else if (gameType == 3)
                            {
                                this.NavigationService.Navigate(new Bingo5x5("TRUNG BÌNH"));
                            }
                            startTime(false);

                        };
                        break;
                    case "KHÓ":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            if (gameType == 1)
                            {
                                this.NavigationService.Navigate(new Bingo3x3("KHÓ"));
                            }
                            else if (gameType == 2)
                            {
                                this.NavigationService.Navigate(new Bingo4x4("KHÓ"));
                            }
                            else if (gameType == 3)
                            {
                                this.NavigationService.Navigate(new Bingo5x5("KHÓ"));
                            }
                            startTime(false);
                        };
                        break;
                }
            }
            gridStart.Children.Add(canvas);
        }
        // Chọn loại game
        public void Controler()
        { 
            Canvas canvas = new Canvas();
            canvas.Height = 500;
            canvas.Width = 850;
            ImageBrush myBrush1 = new ImageBrush();
            myBrush1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/backgroundMenu.png"));
            canvas.Background = myBrush1;
            
            MediaPlayer mediaPlayer1 = new MediaPlayer();
            mediaPlayer1.Open(new Uri("pack://application:,,,/music/button.mp3"));
            //
            for (var i = 0; i < 3; i++)
            {
                Button button = new Button();
                Button buttonC = new Button();
                ImageBrush myBrushButton = new ImageBrush();
                myBrushButton.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/buttonStart.png"));
                ImageBrush myBrushButtonC = new ImageBrush();
                myBrushButtonC.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/buttonClose.png"));
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
                    gridStart.Children.Remove(canvas);
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
                    Canvas.SetTop(button, index[i] - 100);
                }
                else if (i == 1)
                {
                    Canvas.SetTop(button, index[i] - 100);
                }
                else if (i == 2)
                {
                    Canvas.SetTop(button, index[i] - 100);
                }
                margin.Left = main.Width / 2 - button.Width / 2;
                button.Margin = margin;
                canvas.Children.Add(button);
                canvas.Children.Add(buttonC);
            
                switch (button.Content)
                {
                    case "3X3":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            gameType = 1;
                            tabGameMode();
                        };
                        break;
                    case "4X4":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            gameType = 2;
                            tabGameMode();
                        };
                        break;
                    case "5X5":
                        button.Click += (sender, args) =>
                        {
                            mediaPlayer1.Play();
                            gameType = 3;
                            tabGameMode();
                        };
                        break;
                }
            }
            //
            gridStart.Children.Add(canvas);
        }
        // Load Form
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            startTime(true);

            //
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/logoStart.png"));
            img.Height = 230;
            Canvas.SetTop(img, 30);
            Canvas.SetLeft(img, 60);
            canvasM.Children.Add(img);
            for (var i = 0; i < 3; i++)
            {
                Button button = new Button();
                ImageBrush myBrushButton = new ImageBrush();
                myBrushButton.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/StartGame/buttonStart.png"));
                button.Background = myBrushButton;
                button.Width = 210;
                button.Height = 60;
                button.Content = content[i];
                button.FontWeight = FontWeights.Bold;
                button.FontFamily = new FontFamily("Arial");
                button.Foreground = Brushes.White;
                button.FontSize = 18;
                button.BorderBrush = null;
                button.Name = "button"+i+1;
                var margin = button.Margin;
                MainWindow main = new MainWindow();
                Canvas.SetTop(button, index[i]);
                margin.Left = main.Width - main.Width / 3.5 - 50;
                margin.Top = 50;
                button.Margin = margin;
                button.Cursor = Cursors.Hand;
                canvasM.Children.Add(button);
                // Create a new style for the button
                Style myButtonStyle = new Style(typeof(Button));
                Style myButtonStyle1 = new Style(typeof(Button));

                // Set the template for the button to a new control template
                ControlTemplate myButtonTemplate = new ControlTemplate(typeof(Button));

                // Create a new Border element and add it to the template
                FrameworkElementFactory borderFactory = new FrameworkElementFactory(typeof(Border));
                borderFactory.SetValue(Border.BorderThicknessProperty, new Thickness(0));
                borderFactory.SetValue(Border.BackgroundProperty, myBrushButton);
                borderFactory.SetValue(Border.PaddingProperty, new Thickness(0));
                borderFactory.SetValue(Border.MarginProperty, new Thickness(0));
                borderFactory.SetValue(Border.SnapsToDevicePixelsProperty, true);
                myButtonTemplate.VisualTree = borderFactory;
                myButtonStyle.Setters.Add(new Setter(Button.TemplateProperty, myButtonTemplate));
                myButtonStyle1.Setters.Remove(new Setter(Button.TemplateProperty, myButtonTemplate));
                button.MouseMove += (sender, args) =>
                {
                    button.Style = myButtonStyle;
                }; 
                button.MouseLeave += (sender, args) =>
                {
                    button.Style = myButtonStyle1;
                };
                switch (button.Content)
                {
                    case "CHƠI":
                        button.Click += (sender, args) =>
                        {
                            Controler();
                            MediaPlayer mediaPlayer1 = new MediaPlayer();
                            mediaPlayer1.Open(new Uri(Path + "\\BINGO_WPF\\music\\button.mp3"));
                            mediaPlayer1.Play();
                            
                        };
                    break;
                    case "LUẬT CHƠI":
                        button.Click += (sender, args) =>
                        {
                            Help();
                            MediaPlayer mediaPlayer1 = new MediaPlayer();
                            mediaPlayer1.Open(new Uri(Path + "\\BINGO_WPF\\music\\button.mp3"));
                            mediaPlayer1.Play();
                        };
                       
                        break;
                    case "THOÁT":
                        button.Click += (sender, args) =>
                        {
                            MediaPlayer mediaPlayer1 = new MediaPlayer();
                            mediaPlayer1.Open(new Uri(Path + "\\BINGO_WPF\\music\\button.mp3"));
                            mediaPlayer1.Play();
                            var temp = MessageBox.Show("Do you want to exit the game","QUIT",MessageBoxButton.YesNo);
                            if(temp == MessageBoxResult.Yes)
                            {
                                Environment.Exit(0);
                            }
                        };
                        break;
                }
            }
           
        }
    }
}