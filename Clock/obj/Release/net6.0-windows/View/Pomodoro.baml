   M S B A M L   `   `   `  ���� @  <Clock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Clock.ViewModelClock.ViewModel  'clr-namespace:Clock.View
Clock.View      Clock.View.Pomodoro   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     c _Microsoft.Expression.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  &vmclr-namespace:Clock.ViewModel  _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  $localclr-namespace:Clock.View  -      
Page_Style#��[  $	��860��$	��740��.��� -   $��	Main_Grid��$
|�True��.+��� -     ��Name$  Cv_Focus��$��20,20,458,278q�y��� *SettingVisibility+.+��� $	��386��$	��442��  RTG_Default#��[ $��Center=���   txbl_Default#��[ $��Get ready to focus!��$��23(� �� Left$	 100��
 �� Top$ 30���� #��[ $
��Wrap=�$��13(�$����We'll turn off notifications and app alerts during each session.For longer sessions, we'll add a short break so you can recharge��$	��345��$ 24��$ 66��$��65�� �� TextAlignment$ Center=�
��������� $	��...��  Icon_Button_Style#��[ $��Center=�$
��Left=�$	 351��$y�Hidden=��� #��[ $
��📌��$��Center=�$
��Left=�$��0q�$	 315��$y�Hidden=��� $	��344��$	��100��$ 24��$	 140��$��Center=�$	��Top=� �� RadiusX$ 50�� �� RadiusY$ 50��  Setting.Background#��[ �� -     UpDown_Button#��[ $	��100��$	��100��$ 24��$	 140��$	��➖�����	#7F433E5B$��27(��� -   #��[ $	��100��$	��100��$	 268��$	 140��$	��➕�����	#7F433E5B$��27(��� -    ��Name$ txblFocusTime��$��55(�
������ 
�������$	 144��$	 144��$��70��$	��102��$
��Left=�$��Center=�$��Center=�$��Center=�$��0q� �� SelectionBrush �	#FFB45CE0 �� 
CaretBrush
 �����	 �� 	MaxLength$	 3��.���� #��[ $��17(�$
��mins��$	 178��$	 216��
��������� -   
 ��Name$
 Start_Button��#��[ $ 86��$	 337��$	��218��
����p��$��Start focus session��
���   �$��0q��� -   $  Cv_Break��$��430,20,30,278q�y��� *SettingVisibility+.+��� $	��399��$	��442��#��[ $��Center=��� -	   $��Cb_Have_Breaks��  CheckBoxTemplate#���  $ 22��$ 70��$
��Left=�$	��Top=�$��Skip breaks��
�������
������  � LayoutTransform ��  �� ScaleX$	 1.5Q� �� ScaleY$	 1.5Q��� $	��344��$	��100��$ 22��$	 104��$ 50��$ 50��#��[ $��Center=�$	��Top=��� -
   $��BreakTime_Down_Button��#��[ $	��100��$	��100��$ 22��$	 104��$	��➖�����	#7F433E5B$��27(�$��Center=�$	��Top=��� -   $��BreakTime_Up_Button��#��[ $	��100��$	��100��$	 266��$	 104��$	��➕�����	#7F433E5B$��27(�$��Center=�$	��Top=��� -    ��Name$ lbBreak_time��$��55(�
������ $	 158��$	 104��$��74��$��70��
�������$��Center=�$��Center=�$��Center=�$	��Top=��� #��[ $��17(�$
��mins��$	 176��$	 180��
��������� #��[ $��Time for a break!��$��25(�$	 100��$ 16���� #��[ $��Number of Pomodoros��$��25(�$ 72��$	 239���� $	��344��$	��100��$ 22��$	 333��$ 50��$ 50��#��[ $��Center=�$	��Top=��� -   $
 Times_Down_Button��#��[ $	��100��$	��100��$ 22��$	 333��$	��➖�����	#7F433E5B$��27(��� -   $
 Times_Up_Button��#��[ $	��100��$	��100��$	 266��$	 333��$	��➕�����	#7F433E5B$��27(��� -   $ txbTimes��$��55(�
������ 
�������$	 142��$	 337��$��70��$	��102��$��Center=�$��Center=�$��0q�$��2���� #��[ $��17(�$��times��$	 176��$	 409��
�������$
��Left=�$��Center=��� -    ��Name$ Cb_Until_Stop��#���  $ 26��$	 295��$��Until I stopping focus��
�������
������ $
��Left=�$	��Top=� �� $	 1.5Q�$	 1.5Q��� -   $  Cv_Tasks��$��20,480,458,18q�.+��� $	��383��$	��242��#��[ $��Center=�$ 2���� -   #��[ $	��➕��$	��Top=�$��Center=�$��0q�$	 348��$ 1���� -   $��Stay_on_track��#��[ $��Stay on track��$��23(�$	 128��$ 66���� -   $��Add_Tasks_and��#��[ $
��Wrap=�$��13(�$F��@Add tasks and assign them to focus sessions throughout your day.��$	��311��$ 41��$	 102��$��65��$ Center=�
��������� $��/Images/blue_tick.png��$��25��$ 11��$ 6�� J� RenderTransformOrigin$ 	0.84,1.08&�$��Center=�$	��Top=��� #��[ $��Tasks��$
��Bold"�$��15(�$ 41��$ 8���� -   $
 Start_Button_Copy��#��[ $	 125��$	 159��$	��152��$��➕ Add a task��$��0q�
�������#��[ �� -    ��Name$ 	Lsv_tasks��$	��204��$	��383��
������ 
������ $
��Left=�$��Center=�$ 40��$y�Hidden=�$��0q�$��Hidden=����� .R��� $ NewTB��-   $	��370��$��35��$��20(�$��0q����#474545$��Center=�
�������$��3 3 3 0q� �� TextWrapping$
 Wrap=� +� FocusedElement ��  �� ElementName$ NewTB���� -   $��Cv_Daily��$��430,480,30,18q�.+��� $	��400��$	��244��#��[ $��Center=�%  Microsoft.Expression.Shapes.Arc  
�������$	��190��$	��190�� �� Stretch$
 None=�   ArcThickness$ 18Q�$	 110��$ 17��   ArcThicknessUnit$ Pixel=�   EndAngle$	 360Q�$
��Left=�$	��Top=�  -   $
��Arc1�����	#FF24B7F3$	��190��$	��190��$
 None=�$ 18Q�$	 110��$ 17��$ Pixel=�$ 0Q�$
��Left=�$��Center=��� $��
Daily goal��#��[ $	 172��$ 73��$��15(��� $	��1.5��#��[ $ Center=�$��33(�$	 184��$ 93���� $��hours��#��[ $��15(�$	 187��$	 137���� $��
Completed:��#��[ $��15(�$	 130��$	 214��$
��Left=�$��Center=��� -   $��Complete��$��	0 minutes��#��[ $��15(�$	 211��$	 214��$��Center=�$
��Left=��� #��[ $��Daily progress��$
��Bold"�$��15(�$ 9��$ 5���� #��[ $��✏️��$��15(�$��0q�$	 364��$
��Left=�$��Center=�$y�Hidden=��� -   $  Cv_Countdown��$��306,73,71,314q�$y�Hidden=�.+��� #��[ $	��793��$	��423��$
��Left=�$
 -281��$	 -35��$��Center=��� $	��408��$��80��$	 -20��$	 247��$��Center=�$	��Top=�$ 40��$ 40��#��[ �� -    ��Name$ txblCountdown��#��[ $��60(�
������ $ 63��$��00:00��$	 108���� -   $��Session��#��[ $��50(�
������ $
��Left=�$	 -30��$
 -260��  
�������$	��235��$	��235��$
 None=�$ 20Q�$	 -15��$ Pixel=�$	 360Q�$��Center=�$	��Top=�$ 65��  -   $
��Arc2�����	#FF24B7F3$	��235��$	��235��$
 None=�$ 18Q�$ 65��$	 -15��$ Pixel=�$ 0Q�$
��Left=�$��Center=��� -   $
 Pause_Button��#��[ $��25(�$	 -20��$	 247��$��80��$��80�����	#7F433E5B$��Center=�$	��Top=����� *BtnPauseContent+�� -    $
 Back_Button��#��[ $	��↩��$��25(�$	 143��$	 247��$��80��$��80�����	#7F433E5B$��Center=�$	��Top=�${�False���� -!   $
 Skip_Button��#��[ $	��⏩��$��25(�$	 309��$	 247��$��80��$��80�����	#7F433E5B$��Center=�$	��Top=�