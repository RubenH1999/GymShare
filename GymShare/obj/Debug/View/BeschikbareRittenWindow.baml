   M S B A M L   `   `   `  ����C  ?GymShare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GymShare.ViewGymShare.View  5   	   +    %GymShare.View.BeschikbareRittenWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GymShare.View     5   	     � Title$  BeschikbareRittenWindow��5	   	   $	��250��6)   $	��350��66    � DataContext 5   	   ��  %  !beschikbareRittenViewModelLocator �� Source# [   �� Path$  BeschikbareRittenViewModel� � 	Resources 5
        buttonStyle �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 ��Name  	labelStle��%s  &	       &	 �    �� 5   
   " ��6$   .�5      ��  � ��$ Right=�64   �� 5       � ��$	 0,5q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $	 3,3,3,3��6!   ���#77dd77���#ccc$��0,0,0,0q�6`   ._�5      �� $
 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  5      5      5      �� 5       � ��$	 120��6&   �� 5       � ��
 �   �6+   5      �� 5   
   " ��6"   .�5      ��  � ��$	 250��6&   �� 5       � ��$	 0,5q�6'   �� 5        � ��$	 120��6&   5"      5#      .��5$      � $��Center=�6   $��Center=�6(    � RowDefinitions 5%   
   �� 5&      $
��Auto �6   �� 5'      $	��150 �6   �� 5(      $
��Auto �6    � ColumnDefinitions 5.   
   �� 5/      $
��Auto �6   �� 50      $
��Auto �6   .+�56   
   �� -   5         ��Name$ label��56      $��Mijn ritten als chauffeur��6   $��0��6C   $��0��6S   �� 57   
   $��0��6X   $��1��6h   ��6   �� *Ritten+ �� SelectedItem 63   �� *SelectedRit+��58      �� 59      .R�5:      �� $��14(�69   $
��Bold"�6H   ��6   �� *
Gym.Naam+6H   5;      5=      � 5>   
   $��1��6   $��2��6    5?      �� 5@      $
��Auto �6    �� 5A      $
��Auto �6    �� 5B      $
��Auto �6     5H      �� 5I      $
��Auto �6#   �� 5J      $
��Auto �6#   .+�5Q      �� $��0��6   $��Zetels:��6!   �� 5R      $��1��6   $��Datum:��6!   �� 5S      $��2��6   $
��Gym:��6!   �� 5T      -   5        $ label1��5T      $��1��6X   $��0��6h   #��[ 6u   ��6$   �� *SelectedRit.Zetels+ �� Mode$ TwoWay=�6u   �� 5U      -   5        $ label2��5U      $��1��6W   $��1��6g   #��[ 6t   ��6$   �� *SelectedRit.Datum+$ TwoWay=�6t   �� 5V      -   5        $ label3��5V      $��1��6Z   $��2��6j   #��[ 6w   ��6$   �� *SelectedRit.Gym.Naam+$ TwoWay=�6w   5X      �� 5Z   
   $��	Meerijden��6   $��2��6%   $��2��65   #��[ 6t   ��6B   �� *DeelnemenCommand+$ TwoWay=�6t   5[      5\      