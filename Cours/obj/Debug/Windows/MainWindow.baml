   M S B A M L   `   `   `  ����@  <Cours, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CoursCours  5   	       Cours.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Cours     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
To-do list��5	   	   $	��400��6   $	��400��6)   $��14(�65   $
��Bold"�6C   
������� � 
ResizeMode$ NoResize=�6h   .��5
      � $��5q�6   .+�5   
   �� .+�5      �� $��To - Do List��6   $��20 5,5,5q�6+   $	��Top=�6=   $
��Left=�6U   
�������$��22(�6�   $��Normal"�6�   �� 5      $.��(----------------------------------------��6   $��22(�6G   $
��Bold"�6U   $��	10,0,10,0q�6g   � 5      $��
10,0,10,10q�6   .+�5      �� $
��Left=�6   $ ��Add new [ To - do list ] :��63   $��Italic$�6X   $��14(�6k   $
��Bold"�6y   �� 5      -   5         ��Name$ addBtm��5      $
��Left=�6>   $��	200,0,0,0q�6Y   $	��100��6l   $	��Add��6x    "  MaterialDesignFlatDarkBgButton#��[  6�   $
��Auto��6�   5      � 5      $��
10,0,10,10q�6   .+�5      �� $
��Left=�6   $ ��Show my [ To - do list ] :��63   $��Italic$�6X   �� 5      -   5        $ showBtm��5      $
��Left=�6@   $��	200,0,0,0q�6[   $	��100��6n   $
��Show��6z   #��[  6�   5      � 5      .+�5      �� $��14(�6   $��10,0,0,5q�6&   $��Italic$�68   $
��Left=�6K   $��Your Plans :��6f   �� 5      -   5         ��Name$ 
countLabel��5   +   $��Italic$�6   $��0��6?   $��Center=�6K   $��	140,0,0,0q�6h   $��16(�6{   5      � 5      .+�5      �� $��14(�6   $��10,0,0,5q�6'   $��Italic$�69   $
��Left=�6L   $��
Red Plan :��6g   
�������
���  ��6�   �� 5      -   5        $ redPlanLabel��5   +   $��Italic$�6   $��0��6A   $��Center=�6M   $��	140,0,0,0q�6j   
�������
���  ��$��16(�6�   5      � 5      .+�5      �� $��14(�6   $��10,0,0,5q�6'   $��Italic$�69   $
��Left=�6L   $��Blue Plan :��6g   
�������
����  �6�   �� 5       -   5        $ 	blueLabel��5    +   $��Italic$�6   $��0��6>   $��Center=�6J   $��	140,0,0,0q�6g   
�������
����  �$��16(�6�   5!      � 5"      .+�5#      �� $��14(�6   $��10,0,0,5q�6'   $��Italic$�69   $
��Left=�6L   $��Blue Plan :��6g   
�������
��� d �6�   �� 5$      -   5        $ 
greanLabel��5$   +   $��Italic$�6   $��0��6?   $��Center=�6K   $��	140,0,0,0q�6h   
�������
��� d �$��16(�6�   5%      �� 5&      $��0,10,0,0q�6   $��Stretch=�6*   .@�5'      �� $��Data: ��6   $
��Bold"�6)   �� 5(      -   5        $ 	dataLabel��5(      $��0 ��6+   $
��Bold"�68   �� 5)      $��Time: ��6   $
��Bold"�6)   �� 5*      -   5        $ 	timeLabel��5*      $��0 ��6+   $
��Bold"�68   5+      5-      5.      5/      