   M S B A M L   `   `   `  ����C  ?GymShare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GymShare.ViewGymShare.View  5   	   #    GymShare.View.RitDetailWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GymShare.View     5   	     � Title$  RitDetailWindow��5	   	   $	��450��6!   $	��800��6.    � DataContext 5   	   ��    ritViewModelLocator �� Source# [   �� Path$ RitDetailViewModel�.��5      � $��1��6   $��20q�6    � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      $��30 �6   6+   �� 5      $
��auto �6   6,   �� 5      $��30 �6   6*   �� 5      $
��auto �6   6,    � ColumnDefinitions 5   
   �� 5      $	��150 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��1��6   $��Zetels:��6!   $
��Bold"�60   �� 5   
   $��2��6   $
��Uur:��6!   $
��Bold"�6-   �� 5   
   $��3��6   $
��Gym:��6!   $
��Bold"�6-   �� 5   
   -   5        $��textBoxZetels��5      $��1��6'   $��1��64   $��0,0,0,10q�6u   ��6D   �� *SelectedRit.Zetels+ �� Mode$ TwoWay=�6u   �� 5   
   $��2��6   $��1��6   $��0,0,0,10q�6\    �� AcceptsReturn .  �� TextWrapping$ WrapWithOverflow=�6�   ��6/   �� *SelectedRit.Uur+$ TwoWay=�6�   �� 5   
   $��1��6   $��3��6#   $��0,0,0,10q�61   $	 �� IsSynchronizedWithCurrentItem$
	 TrueY�6�   
 �� SelectedIndex$
 0��6�   ��6C   �� *Gyms+ �� SelectedItem 6a   �� *SelectedGym+6�   �� 5"   
   $��4��6   .+�5#      �� $��Bewaren��6   $
��Bold"�6I   
�������
���   �$��0,10,0,0q�6�   ��6'   �� *UpdateCommand+6�   �� 5$      $��Verwijderen��6   $
��Bold"�6M   
�������
���   �$��0,10,0,0q�6�   ��6+   �� *DeleteCommand+6�   5%      5&      5'      