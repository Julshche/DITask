   M S B A M L   `   `   `  ����A  =DITask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DITask.TaskVewsDITask.TaskVews  5          DITask.TaskVews.Task5   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:DITask.TaskVews     5      W SHelixToolkit.Wpf, Version=2.4.0.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d/HelixToolkithttp://helix-toolkit.org/wpf  5      -   5        $��TASK5��5      .��5   
   �   � RowDefinitions  5      �� 5      6"   �� 5      $
��auto �6    60   .+�5      � $��0��6   .+�5      �� 
���   �$��0 0 0 2q�6-   ._�5      &   HelixToolkit.Wpf.HelixViewport3D  -   5          Name$ 
helix_view��5   /      Children. 5      $  HelixToolkit.Wpf.DefaultLights  g� 5       g� Content 6$   �� *	MyModel+5      5      5      � 5      $��2��6   $
��Left=�6    .+�5      ]� .+�5      �� 
�������$��2q�6+   $
��Bold"�6?   $��60��6R   $��30��6]   $��7q�6i   $
��LOAD��5      ��6&   ��  �� Path$
 Load�6G   �� 5       
�������$��2q�6+   $
��Bold"�6?   $��60��6R   $��30��6]   $��7q�6i   $��CLEAR��5!      ��6&   �� $ Clear�6G   � 5"      $	��150��6   $��5q�6$   .+�5#      �� $��MIN Z ��6   6,   �� 5$       � Minimum$	 -25Q�60    � Maximum$ -5Q�6>   $	��110��6L   $��0 0 0 2q�6X    � Value 6   �� *MinZ+6k   �� 5%      $��MAX Z��6   6+   �� 5&      $ 5Q�60   $ 25Q�6<   $	��110��6I    6   �� *MaxZ+6W   5'      �� 5(      
�������$��2q�6+   $
��Bold"�6?   $��60��6R   $��30��6]   $��7q�6i   $��START��5)      ��6&   �� $ Start�6H   �� 5*      
�������$��2q�6+   $
��Bold"�6?   $��60��6R   $��30��6]   $��7q�6i   $
��STOP��5+      ��6%   �� $
 Stop�6F   5-      50      52      53      