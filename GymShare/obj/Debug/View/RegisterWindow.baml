   M S B A M L   `   `   `  ����C  ?GymShare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GymShare.ViewGymShare.View  5   	   "    GymShare.View.RegisterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GymShare.View     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ RegisterWindow��5   	   $	��400��6    $	��375��6-    � DataContext 5   	   ��    registerViewModelLocator �� Source# [   �� Path$ RegisterViewModel� � 	Resources 5        buttonStyle �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� CornerRadius ��Name  textBoxStyle��%P  &	       &	 �    �� 5   
   " ��6$   .�5      ��  � ��$	 0,5q�6'   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� $
 3,3,3,3��6!   ���#77dd77���#ccc$��0,0,0,0q�6`   ._�5      �� $ contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  5      5      5      �� 5       � ��$	 120��6&   �� 5       � ��
 �   �6+   5      �� 5   
   " ��6%   .�5      ��  � ��$ 0,0,0,2q�60   �� 5       � ��$	 250��6&   �� 5       � ��$	 0,5q�6'   5"      5#      .��5$      � .+�5%   
   ��  �� Orientation$ Vertical=�6   .+�5&      �� $��Register��6   
���   �$��25(�6:   $��Center=�6H   �� 5'      $��	Firstname��6   
���   �$��14(�6;   $��Center=�6I   �� 5(      -   5         ��Name$ textBox��5(      #��[ 6(    �� TextWrapping$
 Wrap=�6O   $	��Top=�6�   ��6c   �� *User.Firstname+ �� Mode$ TwoWay=�6�   �� 5)      $��Lastname��6   
���   �$��14(�6:   $��Center=�6H   �� 5*      -   5        $ textBox_Copy��5*      #��[ 6,   $	��Top=�6�   ��6T   �� *User.Lastname+$ TwoWay=�6�   �� 5+      $��Email��6   
���   �$��14(�67   $��Center=�6E   �� 5-      -   5        $ textBox_Copy1��5-      #��[ 6-   $	��Top=�6~   ��6T   �� *
User.Email+$ TwoWay=�6~   �� 5.      $��Phone��6   
���   �$��14(�67   $��Center=�6E   �� 5/      -   5        $ textBox_Copy2��5/      #��[ 6-   $	��Top=�6~   ��6T   �� *
User.Phone+$ TwoWay=�6~   �� 50      $��Password��6   
���   �$��14(�6:   $��Center=�6H   �� 51      -   5        $ textBox_Copy3��51      #��[ 6-   $	��Top=�6�   ��6T   �� *User.Password+$ TwoWay=�6�   �� 52      -   5         ��Name$ button��52      #��[ 6%   $��Register��6J   ��6^   �� *RegisterCommand+53      56      57      