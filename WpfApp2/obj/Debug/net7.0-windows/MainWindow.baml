   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��57* �6   �� 5      $
��321* �6   �� 5      $
��346* �6   �� 5      $	��76* �6    � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $��40 �6   �� 5      $
��271* �6   �� 5      $��40 �6   �� 5      $	��64* �6   .+�5   
   �� -   5        $��btnShowStudents��5   "   $��1��6   $��Show students��69   $��1��6Q   6^   &   System.Windows.Controls.DataGrid  5   
   -   5        $��gridStudents��5   #   $��1��6   $��2��67   $��18(�6u   �� 5   
   -   5        $��tbResult��5      $��1��6$   $��3��64   $
��Wrap=�6A   $��	TextBlock��6U   $��20(�6f   $��Center=�6t   $��Center=�6�   �� 5   
   -   5        $��btnInfo��5   !   $��2��6   $��Student Info��60   $��1��6H   ${�False��6j   5      5      