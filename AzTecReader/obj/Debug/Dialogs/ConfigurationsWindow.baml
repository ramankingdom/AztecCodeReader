   M S B A M L   `   `   `  ����F  BAzTecReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AzTecReader.DialogsAzTecReader.Dialogs  5   	   .    (AzTecReader.Dialogs.ConfigurationsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:AzTecReader.Dialogs     5   	     � Topmost  .  � 
ResizeMode$ NoResize=�5       � ShowInTaskbar .  
����  �$��1q�6Y    � WindowStyle$
 None=�6m    � WindowStartupLocation$ CenterScreen=�6�    � Title$ ConfigurationsWindow��5      $	��100��6%   $	��550��62   .��5	      � $��Center=�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5      6!   .+�5   
   �� $��0��6   $��0��6!   $��2��61      
mainHeader#��[  6E   $��2q�6i   URL Settings :6�   �� 5   
   $��1��6   $��0��6!     headers#��[ 61   $��2q�6R   	API URL :6h   �� 5   
     
borderless#��[ 6   $��1��66   $��1��6C   ��6S   �� *ApiUrl+6m   �� 5   
   $��2��6   $��0��6#   $��2��63    �� Orientation$ 
Horizontal=�6G   $��Right=�6`   .+�5      �� $��54��6   $
��Save��6"   $��5q�61   ��6<   �� *SaveCommand+6^   �� 5      -   5        $��54��5      $��Close��6"   $��5q�62   6T   5      5      5      