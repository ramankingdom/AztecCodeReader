   M S B A M L   `   `   `  ����F  BAzTecReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AzTecReader.DialogsAzTecReader.Dialogs  5   	   %    AzTecReader.Dialogs.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:AzTecReader.Dialogs     5   	     � WindowStyle$
  None=�5       � 
ResizeMode$ NoResize=�6/    � Title$ Login Window��6E   
����  �$��1q�5       � WindowStartupLocation$ CenterScreen=�60    � Topmost . $	��300��5	   	   $	��330��6   .��5
   
   �  � RowDefinitions 5   
   �� 5      6   �� 5      $
��Auto �6   6-   �� 5      $
��Auto �6   6,   �� 5      6    � ColumnDefinitions 5   
   �� 5      $��54 �6   6,   �� 5      6!   .+�5   
   �� $��0��6   $��0��6   $��38��6-   $��38��68   $��/Images/logo.png��6D   6`   �� 5   
      
mainHeader#��[  6   $��0��68   $��1��6E   Aztec Barcode Reader6k   �� 5   
   $��1��6   $��1��6   $��2��6/   $��5,0,5,5q�6C     
borderless#��[ 6�   ��6T   �� *UserId+ �� UpdateSourceTrigger$ PropertyChanged=�6�   G� 5   
   $��2��6   $��1��6#   $��2��63   $��5,0,5,5q�6G     password#��[ 6X   6}   �� 5   
   $��/Images/user.png��6   $��1��6*   $��0��67   $��42��6G   $
��0,15q�6S   6c   �� 5   
   $��/Images/key.png��6   $��2��6)   $��0��66   $��42��6F   $
��0,15q�6R   6b   �� 5   
   $��3��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��0,0,5,0q�6g   .+�5      �� $��Login��6   $	��100��6F   $��32��6R   ��6%   �� *LoginCommand+6`   �� 5      -   5        $��Cancel��5      $	��100��6'   $��32��63   $��5,0,0,0q�6?   6g   5      5       5!      