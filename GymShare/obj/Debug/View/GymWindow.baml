   M S B A M L   `   `   `  ����C  ?GymShare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GymShare.ViewGymShare.View  5   	       GymShare.View.GymWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GymShare.View     5   	     � Title$  	GymWindow��5	   	   $	��450��6   $	��800��6(    � DataContext 5   	   ��    gymViewModelLocator �� Source# [   �� Path$ GymViewModel�.��5
      �  � ColumnDefinitions 5   
   �� 5      $	��350 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��20q�6   $	��280��6a   ��6   �� *Gyms+ �� SelectedItem 6<   �� *SelectedGym+��5      �� 5      .R�5      �� $��14(�65   $
��Bold"�6D   ��6   �� *Naam+6D   5      5      � 5   
   $��1��6   $��0,100,10,10q�6    � RowDefinitions 5      �� 5      $��30 �6    6/   �� 5      $
��auto �6    60   �� 5      $��30 �6    6.   �� 5      $
��auto �6    60    5      �� 5      $	��150 �6#   61   �� 5       $��* �6#   6/   .+�5"      �� $��0��6   $��Naam:��6%   $
��Bold"�62   �� 5#      $��1��6   $��Sport:��6%   $
��Bold"�63   �� 5&      $��0��6   $��1��6%   ��65   �� *SelectedGym.Naam+�� 5'      $��1��6   $��1��6%   $��WrapWithOverflow=�6Z   $��	0,0,10,10q�6z   ��65   �� *SelectedGym.Sport+6z   �� 5*      $��3��6   .+�5+      �� $��Wijzig��6   $
��Bold"�6O   
�������
���   �$��0,10,0,0q�6�   ��6+   �� *WijzigenCommand+6�   �� 5,      $��Voeg toe��6   $
��Bold"�6R   
�������
���   �$��0,10,0,0q�6�   ��6-   �� *ToevoegenCommand+6�   5-      5.      5/      50      