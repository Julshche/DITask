   M S B A M L   `   `   `  ����A  =DITask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DITask.TaskVewsDITask.TaskVews  5   	       DITask.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:DITask.TaskVews     5   	   W SHelixToolkit.Wpf, Version=2.4.0.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d/HelixToolkithttp://helix-toolkit.org/wpf  5   	      MyStyle#��[  5	   
     � Title$  
MainWindow��5
   	   $	��400��6   $	��600��6)    � 	Resources 5   
    �� DataType$  DITask.TaskVews.TasksViewModel   DITask.TaskVews.TaskView&   DITask.TaskVews.TaskViewModelMax   DITask.TaskVews.Task5��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$' !SystemCommands.CloseWindowCommand��5      5        5   
   -   5        $* $SystemCommands.MaximizeWindowCommand��5      5        5   
   -   5        $* $SystemCommands.MinimizeWindowCommand��5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5       6"   .+�5$   
   � $��0��6   .+�5%      �� 
���   �$��0 0 2 0q�6)   ._�5&      �� ��6   �� *PageViewModels+��5'      �� 5(      .R�5)      �� 
���   �$��0 0 0 2q�69   $��Stretch=�6T   ._�5+   "   ��   ButtonStyle#���  6B   $��60��5,   "   $��30��6-   $	��2,5q�50   !   ��5+   )   �� *Name+��5-   !   �� *DataContext.ChangePageCommand+ �� RelativeSource ��  �� AncestorType" ���5.   !   �� 50   !   51      52      54      55      56      � 5>   
   $��1��6   .+�5@      �� ��6   �� *CurrentPageViewModel+5A      �� 5B      $��Bottom=�5C      $��24��5D      $��Bottom=�6   ��64   Z� .@�5E      �� $��Right=�6    .��5F      ��  J� Opacity$
 0.75Q�6!   5G      5H      5I      5J      5K      