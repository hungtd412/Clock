   M S B A M L   `   `   `  ���� @  <Clock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClockClock  1clr-namespace:Clock.ViewModelClock.ViewModel  1clr-namespace:Clock.UtilitiesClock.Utilities      Clock.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Clock     ,vmclr-namespace:Clock.ViewModel     .Menuclr-namespace:Clock.Utilities     -     � Icon$  Images/app_icon.png�� � Title$ Clock��$	��780��$
��1150��$	��450��$	��700�� � WindowStyle$
 None=� � 
ResizeMode$ 	CanResize=� � WindowStartupLocation$ CenterScreen=� � WindowState$ Normal=����#427ef5$	��0.7q�
������  � DataContext "  Clock.ViewModel.NavigationVM  '  !System.Windows.Shell.WindowChrome   WindowChrome      GlassFrameThickness$ 0q�	   CornerRadius$	 0��
   CaptionHeight$
 0Q�.��� .+��� ���#272B2F�  � ColumnDefinitions �� $
��Auto ��� $��* �.+�� -    �Name$ MainControl��.+��� ���	#B2191919�� $	��400��$	��Top=�.+�� -   $	��Top=�$
��Left=�$��38��$	��275��
������ .+���    
Text_Style#��[  $��Clock��$
��Left=�$��79,3,0,0q�$��Center=��� $��27,0,0,0q�$��Images/app_icon.png��  Image_Style#��[    Clock.Utilities.Btn    BtnStyle#��[  d� 	IsChecked$
 TrueY����� *PomodoroCommand+.��� .+��� $��Pomodoro��#��[  �� $��Images/pomodoro_icon.png��#��[   #��[ ���� *StopwatchCommand+.��� .+��� $��Images/stopwatch_icon.png��#��[ �� $��	Stopwatch��#��[  � $��1�� � RowDefinitions �� $��40 ��� $��* �.+�� .+��� -   $	��Top=�$��41��$
��Auto��
������ .+�d� -    d�Name$ Tg_Btn��$��Center=�  iToggleButtonStyle#���  $
��Left=�$��0q�
������ $��	10,5,0,15q�$��30��$��30�� � Triggers :�  :� RoutedEvent$ ToggleButton.Unchecked��.[��� .���� -    ��Name$ HideStackPanel��.��W�  �� 
TargetName$ MainControl�� �� TargetProperty$ Width� g� 	BeginTime	 0:0:0 W� From 75	 W� To 275 g� Duration$ 0:0:0.2D�:� $ ToggleButton.Checked��.[��� .���� -   $ ShowStackPanel��.��W� $ MainControl��$ Width�	 0:0:0 275 75$ 0:0:0.2D��� -    ��Name$ 	btn_Close��  Close_Button_Style#��[  �� Right$ 0��$��Right=�$��38��$��48��$��✖️��$��0q�$��13(��� -	   $ btn_Maximize��  Icon_Button_Style#��[ $��38��$ 48��$��1��$��Webdings)�$��15(�$��0q�$��48��
 �� Top$ 1���� -
   $��btn_Minimize��#��[ $��38��$ 96��$
��🗕��$��5q�$��15(�$��48��$ 1��� $��1��y��� *Pomodoro_Visibility+ �� UpdateSourceTrigger$ PropertyChanged=�.+��� -    ��Name$ Pages������ *
Pomodoro+� $��1��y��� *StopWatch_Visibility+$ PropertyChanged=�.+��� ���� *	StopWatch+