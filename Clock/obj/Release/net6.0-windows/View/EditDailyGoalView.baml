   M S B A M L   `   `   `  ���� @  <Clock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Clock.View
Clock.View  "    Clock.View.EditDailyGoalView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:Clock.View       � 	Resources   �� MergedDictionaries �� Source��  �� $ /Styles/ComboBox.xaml?��� $ /Styles/ScrollBar.xaml?�%    .����  �� CornerRadius$ 10��$	��330��$	��390�����#242423._�� .+��� $��15 20 15 20q�.+��� $��Edit your daily goal��$
��Bold"�$��23(�   txbl_Default#��[  $	��Top=�$
��Left=� �� Left$ 0��
 �� Top$ 0���� $��
Daily goal��$��Regular"�$��15(�#��[  $ 0��$ 50���� -    ��Name$ pickTimeCbox��$ 0��$ 80��.@��� $��
30 minutes���� $��1 hour���� $��1 hour, 30 minutes���� $��2 hours���� $��2 hours, 30 minutes���� $��3 hours���� $��3 hours, 30 minutes���� $��4 hours���� $��5 hours���� $��6 hours���� $��7 hours���� $��8 hours���� $.��(Clear daily progress and completed tasks��$��Regular"�$��15(�#��[  $ 0��$	 140���� $	 170�� �� Orientation$ 
Horizontal=�.+��� -   $ pickHour��$��45 0 0 0q�$��70���� -   $ 
pickMinute��$��5 0 0 0q�$��70���� -   $ pickAMPM��$��5 0 0 0q�$��70���� $
��Hour��$��Regular"�$��15(�#��[  $ 60��$	 200���� $��Minute��$��Regular"�$��15(�#��[  $	 130��$	 200���� $��AM or PM��$��Regular"�$��15(�#��[  $	 195��$	 200���� $ 10��$	 250�� � LayoutTransform �� 	 �� ScaleX$		 1.5Q�
 �� ScaleY$	
 1.5Q��� $!��Include weekends in streaks��$��Regular"�$��15(�#��[  $ 40��$	 250���� $	 295��$ 
Horizontal=�$��20 0 0 0q�.+��� $	��120��$��40��$��	💾 Save��$��0q�$��20(�
���   �$��Center=�$��Center=����#51a9db$��0q�����  �� 
TargetType" ��.���  �� Property �@�FocusVisualStyle  FocusVisual �� Value# [ ��  � �� ��  �� 
TargetType" ��.R���  ��Name$ border��#��z��#��z��#��z�� J� SnapsToDevicePixels$
 true��$ 10��._���  ��Name$ contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 true��. ���  �� 
TargetName$ border�� � �� �#6a92a8P�  � ��$
 true��. ��� $ border�� � �� �#637f8f��   Icon_Button_Style#��[ $	��120��$��40��$��20 0 0 0q�$��✖️ Cancel��$��0q����#3c3d3d
�������