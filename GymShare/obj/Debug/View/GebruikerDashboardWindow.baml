   M S B A M L   `   `   `  ����C  ?GymShare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GymShare.ViewGymShare.View  5   	   ,    &GymShare.View.GebruikerDashboardWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GymShare.View     5   	     � Title$  	Dashboard��5	   	   $	��250��6   $	��400��6(    � DataContext 5   	   ��  &  "gebruikerDashboardViewModelLocator �� Source# [   �� Path$! GebruikerDashboardViewModel� � 	Resources 5
        buttonSytle �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value��%�  &	       �� 5   
   " ��6$   .�5      ��  � ��$ 10q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $	 3,3,3,3��6!   ���#77dd77���#ccc$��0,0,0,0q�6`   ._�5      �� $
 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  5      5      5      �� 5       � ��$ 12(�6)   �� 5       � ��$
 Left=�64   �� 5       � ��$ Center=�62   �� 5       � ��$	 131��6&   �� 5       � ��$ 40��6'    5      P� 5       �@J�IsMouseOver . . �5      ��  �@J�Opacity$ 50Q�60   5      5!      5"      .��5#      � $��Center=�6   $��Center=�6(    � RowDefinitions 5%   
   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6    � ColumnDefinitions 5+   
   �� 5,      $
��Auto �6   �� 5-      $
��Auto �6   .+�50      �� -   5         ��Name$ button��50      #��[ 6%   $��0��6J   $��0��6W   $��Beschikbare ritten��6g   ��6�   �� *BeschikbareRittenCommand+�� 51      -   5        $ button1��51      #��[ 6&   $��0��6K   $��1��6X   $��Maak nieuwe rit aan��6h   ��6�   �� *NieuweRitCommand+�� 53   
   -   5        $ button3��53      #��[ 6"   $��1��6G   $��1��6T   $��Mijn ritten��6d   ��6{   �� *MijnRittenCommand+�� 54      -   5        $ button4��54      #��[ 6&   $��1��6K   $��0��6X   $��Passagiers ritten��6i   ��6�   �� *PassagierRittenCommand+59      5:      