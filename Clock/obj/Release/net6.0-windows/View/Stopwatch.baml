   M S B A M L   `   `   `  ���� @  <Clock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Clock.ViewModelClock.ViewModel  'clr-namespace:Clock.View
Clock.View      Clock.View.Stopwatch   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,vmclr-namespace:Clock.ViewModel     *localclr-namespace:Clock.View     
������    
Page_Style#��[    � DataContext  !   Clock.ViewModel.StopwatchVM   � 	Resources  �� MergedDictionaries �� Source  Button_IsEnabled �� Color  Button_IsMouseOver �� Opacity  Button_IsPressed �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name J� SnapsToDevicePixels �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  Button.Disabled.Foreground  Time_Display  hr_min_sec_Display  Flags_Display��  �� $ /Styles/ScrollBar.xaml?�%�  &	       &	      &	 4     '�� S     7  7  7  7  &	 �    &	     &	 �    �� $ 	#FF30383E���� $ 	#FF657E90��$	 0.9Q��� $ 	#FF3F4B54��$	 0.8Q��� " ��.���  � ��$ 53����  � ��$ 53����  � ��$ Center=���  � ��
 �������  � ��$ 2q���  � �� �� "	 ��.R��� $
 border��#��z��#��z��#��z��$
 true��$ 50��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8    � ��P�  � ��$
 true��. ��� $ border��8   � ��P�  � {�$ false��. ��� $ border��8   � ���� $ contentPresenter��8   � ���� " ��.���  � ��$ Center=���  � ��$	 Top=���  � ��$ 70(���  � ��
 ������� " ��.���  � ��$ Center=���  � ��$ Bottom=���  � ��$ 20(���  � ��
 �������  � ��$ /Fonts/#Rubik)��� " ��.���  � ��$ Center=���  � ��$	 Top=���  � ��$ 20(���  � ��
 �������  � ��$ /Fonts/#Rubik)�.���  � RowDefinitions �� $	��100 ��� $��55 ��� $��40 ��� .+��� -   $��TimeDisplay��$��0��#��[ ���� *TimeDisplay+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWay=��� -   $��	hrDisplay��$��0��$��hr��$��	0 0 275 0q�#��[ �� -   $��
minDisplay��$��0��$	��min��$��0 0 95 0q�#��[ �� -   $��
secDisplay��$��0��$	��sec��$��	100 0 0 0q�#��[ �� $��1��$��25(�$��1.8 0 0 2.5q�$��	0 0 253 0q�
����������	#FF3F4952���� *BtnStartContent+$ PropertyChanged=����� *StartCommand+�� $
��🏴��$��25(�
�������$��1��$��0,0,0,0q����	#FF3F4952���� *LapsCommand+�� $	��↩��$��25(�
�������$��1�����	#FF3F4952$��	253 0 0 0q����� *ClearCommand+� $��2��$	��692��.+��� -    ��Name$ txblLaps��$
��Laps��$��20(�$��27,0,0,0q�#��[ $
��Left=�y��� *
visibility+$ PropertyChanged=��� -   $ txblTime��$
��Time��#��[ $��	0 0 120 0q�y��� *
visibility+$ PropertyChanged=��� -   $ 	txblTotal��$��Total��$��	488,0,0,0q�#��[ $
��Left=�y��� *
visibility+$ PropertyChanged=�� $��3��$��0,0,0,10q�.+��� $
��Auto=�$	��500��$	��Top=�.��� $	��692��.+��� -   $
��Laps��$
��Left=�$	��128��
�������$��20(�$��0q�
������ $	��Top=�$
��Left=� J� IsHitTestVisible$ False��$��30 0 0 0q�y��� *
visibility+$ PropertyChanged=����� *
LapsList+�� -	    ��Name$ Speed��$��133,0,458,0q�
�������$��20(�$��0q�
������ $	��Top=�$ False��y��� *
visibility+$ PropertyChanged=����� *	SpeedList+�� -
   $
��Time��$��239,0,268,0q�
�������$��20(�$��0q�
������ $	��Top=�$ False��y��� *
visibility+$ PropertyChanged=����� *
TimeList+�� -   $��Total��$��	469,0,0,0q�
�������$��20(�$��0q�
������ $	��Top=�$ False��y��� *
visibility+$ PropertyChanged=����� *	TotalList+