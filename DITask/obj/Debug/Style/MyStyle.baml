   M S B A M L   `   `   `  ����A  =DITask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DITask.StyleDITask.Style  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ButtonStyle  �� 
TargetType �� Property  ToggleButton �� Value �� Triggers P� Property P� Value  MyStyle'   !System.Windows.Shell.WindowChrome    CaptionHeight    CornerRadius    GlassFrameThickness	    NonClientFrameEdges
    ResizeBorderThickness    UseAeroCaptionButtons �� 
TargetType � ColumnDefinitions � Title �� Orientation ��Name    IsHitTestVisibleInChrome �� ElementName �� Stretch �� EdgeMode �� RelativeSource �� AncestorType �� Path#  System.Windows.SystemCommands   MaximizeWindowCommand �� Source F�Name   CloseWindowCommand�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      $localclr-namespace:DITask.Style  5      %�	  &	        7  &	 �    �� 5      "  ��6    .�5   
   ��  �@�FocusVisualStyle8   6-   �� 5   
    � �� 6(   Z� 6;   �� 5   
    � ��$ 14(�6%   62   �� 5   
    � ��$
 Bold"�6'   66   �� 5	   
    � �� 6(   Z�  5
   
   P� 5       � �� . . �5      ��  � ��
 � � �60   �� 5       � �� 60   Z� �� 5       � ��$ Light"�6/   5      5      �� 5      "  �6   .�5   
   ��  �@  WindowChrome 5         5      $ 30Q�6   $ 4��5       $ 0,0,0,1q�5!      $
	 None=�5"      $
 5q�5#       .  5$      5(      �� 5*   
    � ��
 ��·�6(   �� 5+   
    � ��
 �����6'   �� 5-   
    � �� 5.      �� 5/      " �6"   .R�51      � .+�52      �� #��z��6!   #��z��53   !   $��0,30,0,0q�54   !   ._�56      �� .u�57   "   �� 58      5:      � 5<      $��30��6   $	��Top=�5=       5?      �� 5@   "   $
��Auto �63   �� 5A   "   $��* �63   �� 5B   "   $
��Auto �63   .+�5H      �� $��5,0,0,0q�6(   $��Center=�5I   (   $��16(�5J   (   
�������#��z 5L   (   $��1��5M   (   �� 5Q      $ 
Horizontal=�6)   $��2��5R   )   .+�5S   "   �� $ MinimizeButton��6)   $��15��5T   %   $��5q�5U   %   $��Bottom=�5V   %   $*��$SystemCommands.MinimizeWindowCommand��5Y   %    . ��5W   %   Z� ��5X   %   Z� ��5Z   %   �� $ 
MAINWINDOW��.��5\   &   F� $��1��5^   5   $
 None=�5_   5   $ Aliased=�5`   5   +����     z р��  z �    ��j р�� ��j 	��5]   5   ��  �� $ ButtonL�$ 
Foreground�5a   5   5c   #   �� 5f   "   $ MaximizeButton��6)   $��15��5g   %   $��5q�5h   %    . ��5i   %   �� # Z ��5j   %   �� $ 
MAINWINDOW����5k   %   Z� ��5l   %   Z� .��5o   &   F� $ PART_MaxButton_Path��5p   5   $��1��5r   5   $
 None=�5s   5   $ Aliased=�5t   5   X����        ��ا     ��ا @T� �@B @T� �@B     �    @B ��ا @B �    �� р�� �� 	��5q   5   ��  �� $ ButtonL�$ 
Foreground�5u   5   5x   #   �� 5y   "   $ CloseButton��6)   $��15��5z   %   $��5q�5{   %    . $��Oblique$�5�   R   ��5}   %   Z� ��5~   %   Z� ��5   %   �� # Z ��5�   %   �� $ 
MAINWINDOW��.��5�   &   F� $	��1.5��5�   5   $
 None=�5�   5   +����        � z  z �     z � z     	��5�   5   ��  �� $ ButtonL�$ 
Foreground�5�   5   5�   #   5�      5�      5�      5�      5�      5�      5�      