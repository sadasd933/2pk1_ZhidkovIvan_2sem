   M S B A M L   `   `   `  ����@  <PZ_77, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PZ_77PZ_77  5   	       PZ_77.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PZ_77     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ]� .+�5
   
   �� $	��Top=�6   
�������.+�5      o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5         m�Name$ openFileMenuItem��5      $
��Open��69   6h   m� 5      -   5        $ newFileMenuItem��5      $	��New��68   6e   m� 5      -   5        $ saveFile��5      $
��Save��61   6Y   m� 5      -   5        $ 
deleteFile��5      $��Delete��63   6_   �� 5      m� 5      $
��Exit��6   60   5      m� 5      $��Sample��6   .@�5      m� -   5        $ Create_sample��5   /   $��Create��6   6d   m� 5      -   5        $ Load_sample��5   -   $
��Load��6   6^   5      m� 5      $��About��6   .@�5      m� -   5        $��About programAm��5      6Q   m� 5      -   5        $��About Authors��5      6Q   5      5      � 5      $��20��6   .+�5      �� -	   5         ��Name$ Bold_button��5   0   $��20��6   $��20��6%   .��5      �� $��/Icons/png.png��6   5       �� 5!      -
   5        $ Kursiv_button��5!   0   $��20��6   $��20��6%   .��5"      �� $B��</Icons/italic_em_emphasis_format_editor_tool_icon_145968.png��6   5#      �� 5$      -   5        $ Polosa_pod_textom_button��5$   0   $��20��6   $��20��6%   .��5%      �� $9��3/Icons/underline_format_editor_tool_icon_145920.png��6   5&      5'      5(      �� 5)   
   $��Bottom=�6   $��20��6,   $��1��68   ��5*      �� 5+      .R�5,      �  � ColumnDefinitions 5-      �� 5.      $��* �6/   6;   �� 5/      $
��auto �6/   6>   51      52      .@�54      �� -   5         ��Name$ cursorPosition��54   &   $��10(�6   6@   �� 55      $��1��6   .��56      �� -   5        $ 	informait��56   *   $��10(�6   6?   57      58      �� 59   
   -   5         ��Name$ FileList��59      $
��Left=�6$   
������� �� SelectionMode$ Extended=�6M   .@�5:      �� .��6   Files:6"   5;      �� 5<   
   -   5         ��Name$ MainText��5<      $��20(�6$    �� TextWrapping$
 Wrap=�62   	 �� AcceptsReturn	 . 
 �� 
AcceptsTab
 .  �� 	IsEnabled .  � Language$ ru-ru�6�   6�   5=      5>      