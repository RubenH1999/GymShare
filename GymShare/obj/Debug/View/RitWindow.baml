   M S B A M L   `   `   `  ����C  ?GymShare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GymShare.ViewGymShare.View  5   	       GymShare.View.RitWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GymShare.View     5   	     � Title$  	RitWindow��5	   	   $	��450��6   $	��800��6(    � DataContext 5   	   ��    ritViewModelLocator �� Source# [   �� Path$ RitViewModel�.��5
      �  � ColumnDefinitions 5   
   �� 5      $	��350 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��20q�6   $	��280��6c   ��6   �� *Ritten+ �� SelectedItem 6>   �� *SelectedRit+��5      �� 5      .R�5      �� $��14(�69   $
��Bold"�6H   ��6   �� *
Gym.Naam+6H   5      5      � 5   
   $��1��6   $��0,100,10,10q�6    � RowDefinitions 5      �� 5      $��30 �6    6/   �� 5      $
��auto �6    60   �� 5      $��30 �6    6.   �� 5      $
��auto �6    60    5      �� 5      $	��150 �6#   61   �� 5       $��* �6#   6/   .+�5"      �� $��0��6   $��Zetels:��6%   $
��Bold"�64   �� 5#      $��1��6   $
��Uur:��6%   $
��Bold"�61   �� 5$      $��2��6   $
��Gym:��6%   $
��Bold"�61   �� 5&      $��0��6   $��1��6%   ��65   �� *SelectedRit.Zetels+�� 5'      $��1��6   $��1��6%   $��WrapWithOverflow=�6X   $��	0,0,10,10q�6x   ��65   �� *SelectedRit.Uur+6x   �� 5(      $��2��6   $��1��6%   ��65   �� *SelectedRit.Gym.Naam+�� 5*      $��3��6   .+�5+      �� $��Wijzig��6   $
��Bold"�6O   
�������
���   �$��0,10,0,0q�6�   ��6+   �� *WijzigenCommand+6�   �� 5,      $��Voeg toe��6   $
��Bold"�6R   
�������
���   �$��0,10,0,0q�6�   ��6-   �� *ToevoegenCommand+6�   5-      5.      5/      50      