   M S B A M L   `   `   `  ����@  <Cours, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Cours.WindowsCours.Windows  5   	       Cours.Windows.AddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Cours.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  	AddWindow��5	   	   $	��750��6   $	��700��6(   .��5
      � ���	#ffdadada$��5,5,5,5q�6"   .+�5   
   �� $	��Top=�6   $
��Left=�6(   $��To - Do List��6C   $��30(�6Z   $��90,5,5,5q�6h   $
��Bold"�6z   $��Italic$�6�   �� 5   
   $��	0,50,20,0q�6   
�������$��Center=�67    �� Padding$ 40q�6R   $	��300��6_   $	��650��6o   $	��640��6    �� CornerRadius$	 100��6�   $	��650��6�   ._�5      �� .+�5      � $��	0,10,0,10q�6   .+�5      �� $��Enter name To-Do: ��6   $��22(�69   $
��Bold"�6G   $
��Left=�6Y   $��Italic$�6t   �� 5      -   5         ��Name$ nameTextBox��5      $
��Left=�63   ���	#ffdadada$��	210,0,0,0q�6e   $	��280��6x   5      � 5      $��0q�6   .+�5      �� $��20,0,0,0q�6   $
��With��6.   $��22(�6=   $
��Bold"�6K   $
��Left=�6]   $��Italic$�6x   �� 5      $��0,0,20,0q�6   $��To��6.   $��22(�6;   $
��Bold"�6I   $��Right=�6[   $��Italic$�6w   5      � 5      .+�5      &   System.Windows.Controls.Calendar  -   5        $��calendarWith��5         SelectionMode$ MultipleRange=�6D   $
��Left=�6b   ��63   Z� 6b     5      -   5        $��
calendarTo��5      $ MultipleRange=�6B   $��Right=�6`   ��61   Z� 6`   5      � 5      $��5q�6   .+�5      �� .+�5      �� $��Priority��6#   $��22(�65   $
��Bold"�6C   $��3q�6U   .��5      �� .+�5   "   	� -   5         	�Name$ greenRadioBtm��5   .   $��Green��6E   $��18(�6U   
��� d �6c   	� 5    "   -   5        $ blueRadioBtm��5    .   $��Green��6D   $��18(�6T   
����  �6b   	� 5!   "   -   5        $ redRadioBtm��5!   .   $��Green��6C   $��18(�6S   
���  ��6a   5"      5#      5$      �� 5%      $��Comment��6   $��20,130,0,-100q�6.   $��18(�6E   $
��Bold"�6S   $��Italic$�6e   �� 5&      -   5        $ commentTexbox��5&      $��22(�65   ���	#ffdadada$��
0,160,0,87q�6Z    �� 	MaxLength$ 45��6n   � 5'      .+�5(      �� -   5         ��Name$ 	canselBtm��5(   9   $��
20,220,0,0q�6M   $
��Left=�6a   $	��100��6|   $��Cansel��6�   �� 5)      -	   5        $ addBtm��5)   6   $��
20,220,0,0q�6F   $��Right=�6Z   $	��100��6v   $	��Add��6�   5+      5,      5-      5.      5/      50      