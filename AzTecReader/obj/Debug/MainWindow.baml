   M S B A M L   `   `   `  ����F  BAzTecReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AzTecReaderAzTecReader  5   	   _ [WebEye.Controls.Wpf.WebCameraControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullgOclr-namespace:WebEye.Controls.Wpf;assembly=WebEye.Controls.Wpf.WebCameraControlWebEye.Controls.Wpf 5   	       AzTecReader.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AzTecReader     5   	   dcontrolsOclr-namespace:WebEye.Controls.Wpf;assembly=WebEye.Controls.Wpf.WebCameraControl     5   	   -   5          �Name$
  this��5	   	    � Title$ 
MainWindow��5
   	   $	��620��6   $	��600��6)    � 
ResizeMode$ NoResize=�65   
����  �$��1q�6^    � WindowStartupLocation$ CenterScreen=�6r   .��5      � $	��569��6   $��Bottom=�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $	��360 �6   6+   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   ��    
mainHeader#��[  6   $��0��68   Aztec Barcode Reader6[   �� 5   
   $��Settings��6   $��60��6$   $��Right=�6/   $��2q�6K   ��6V   �� *SettingsCommand+6|   *  $WebEye.Controls.Wpf.WebCameraControl  5   
   -   5          Name$ _videoWindow��5   >   $	��400��6$   $��1��61   6W   �� 5   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��Center=�6;   .+�5      �� $��64��6d   $��Start��6o   $��2q�6   ��6   �� *StartCommand+��66   ��  �� ElementName$
 this��6�   �� 5      $
��Stop��6d   $��64��6s   $��2q�6~   ��6   �� *StopCommand+��65   �� $
 this��6�   �� 5      $��Refresh��6g   $��64��6y   $��2q�6�   ��6   �� *RefreshCommand+��68   �� $
 this��6�   �� 5      $
��Scan��6d   $��64��6s   $��2q�6~   ��6   �� *ScanCommand+��65   �� $
 this��6�   5      �� 5    
   $��3��6   .+�5!      �� $ 
Horizontal=�6   .+�5"      ��   headers#��[ 6   
UserId:-6H   �� 5#      $��	10,0,10,0q�6B   ��6   �� *UserId+ �� Mode$ OneTime=�6W   5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� #��[ 6   $��Scanned Code :- ��6=   �� 5'      $
��Auto��69   ��6   �� *ScannedCode+��5(      �� 5)      	 �� BasedOn#	 [ 6    
 �� 
TargetType"
 ��6C   .�5*      ��  �� Property � �� �� Value
 �   �6L    �� Triggers 5+      �� 5,   "    �� Binding 6.   �� *ScannedCode+ �� Value	 error6N   .a�5-   &   ��  � ��
 �  ��6Q   5.   #   50      52      53      55      �� 56   
   $ 
Horizontal=�6   $��4��6.   .+�57      �� $	��250��6   .+�58      �� #��[ 6   $��Request��6=   6O   �� 59      $	��100��6    �� TextWrapping$
 Wrap=�6@   ��6'   �� *	Request+6V   5:      �� 5;      $	��250��6   .+�5<      �� #��[ 6   $��Response��6=   6P   �� 5=      $	��100��6   $
 Wrap=�6A   ��6'   �� *
Response+6W   5>      �� 5?      $
��Send��6   $��64��6$   $��64��6/   $��10q�6;   ��6G   �� *SendCommand+5@      5A      5B      