   M S B A M L   `   `   `  ����C  ?GymShare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GymShare.ViewGymShare.View  5   	   )    #GymShare.View.PassagierRittenWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GymShare.View     5   	     � Title$  PassagierRittenWindow��5	   	   $	��275��6'   $	��320��64    � DataContext 5   	   ��  #  passagierRittenViewModelLocator �� Source# [   �� Path$ PassagierRittenViewModel� � 	Resources 5        buttonStyleDelete �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 ��Name  	labelStle��%s  &	       &	 �    �� 5   
   " ��6*   .�5      ��  � ��$ Right=�64   �� 5       � ��$	 0,5q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $	 3,3,3,3��6!   ���#ff6961���#ccc$��0,0,0,0q�6`   ._�5      �� $
 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  5      5      5      �� 5       � ��$	 120��6&   �� 5       � ��
 �   �6+   5      �� 5   
   " ��6"   .�5      ��  � ��$	 250��6&   �� 5        � ��$	 0,5q�6'   �� 5!       � ��$	 120��6&   5#      5$      .��5&      � $��Center=�6   $��Center=�6(    � RowDefinitions 5'   
   �� 5(      $
��Auto �6   �� 5)      $	��150 �6   �� 5*      $
��Auto �6    � ColumnDefinitions 5/   
   �� 50      $
��Auto �6   �� 51      $
��Auto �6   .+�57   
   �� -   5         ��Name$ label��57      $��0��6   $��0��6/   $��Ritten als passagier��6<   �� 58   
   $��1��6   $��0��6    ��60   �� *PassagierRitten+ �� SelectedItem 6X   �� *SelectedRit+��59      �� 5:      .R�5;      �� $��14(�6=   $
��Bold"�6L   ��6   �� *Rit.Gym.Naam+6L   5=      5?      � 5@   
   $��1��6   $��2��6    5A      �� 5B      $
��Auto �6    �� 5C      $
��Auto �6    �� 5D      $
��Auto �6    �� 5E      $
��Auto �6     5K      �� 5L      $
��Auto �6#   �� 5M      $
��Auto �6#   .+�5T      �� -   5        $ label1��5T      $��0��6$   $��0��64   $	��Gym��6A   �� 5U      -   5        $ label1_Copy��5U      $��	Chauffeur��6)   $��1��6=   $��0��6J   �� 5V      -   5        $ label1_Copy2��5V      $��Datum��6*   $��2��6:   $��0��6G   �� 5W      -   5        $ label2��5W      #��[ 6Q   $��0��6t   $��1��6�   ��6$   �� *SelectedRit.Rit.Gym.Naam+6�   �� 5X      -   5        $ label2_Copy��5X      #��[ 6Q   $��1��6t   $��1��6�   ��6)   �� *Chauffeur.Firstname+6�   �� 5Y      -   5        $ label2_Copy2��5Y      #��[ 6T   $��1��6w   $��2��6�   ��6*   �� *SelectedRit.Rit.Datum+6�   �� 5Z      -   5         ��Name$ button1��5Z      $��Uitschrijven��6&   $��3��6=   $��1��6J   #��[ 6[   ��6�   �� *UitschrijvenCommand+ �� Mode$ TwoWay=�5[      5^      5a      