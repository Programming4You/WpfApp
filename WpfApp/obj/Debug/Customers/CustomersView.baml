   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfApp.CustomersWpfApp.Customers  5      $    WpfApp.Customers.CustomersView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WpfApp.Customers     5      .��5	      � $��10q�6     � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  $��0��6      AutoGenerateColumns .     HeadersVisibility$ Column=�6�      
IsReadOnly . ��6#   �� *	Customers+ �� SelectedItem 6E   �� *SelectedCustomer+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	FirstName��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6V      SortDirection$ 	AscendingX�6a   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 68   �� *	FirstName+6a     5      $ LastName��6%   $ 3* 6T   $ 	AscendingX�6_   	 67   �� *
LastName+6_   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 2* 6)   
   CellTemplate
 5      �� 5      .R�5      �� $��Delete��6%   ��66   ��  �� Path$ DataContext.DeleteCommand� �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=���6�   �� 5      5      5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5!      � $��0��6   $��5q�6E    � DataContext 6    �� *CustomerEdit+ 5"      �� 5#      $
��Auto �6$   �� 5$      $
��Auto �6$     5&      �� 5'      $
��Auto �6'   �� 5(      $��* �6'   .+�5*      �� $��0��6   $��0��6%   .��65   	FirstName6@   �� 5+      $��0��6   $��1��6'   ��67   �� *	FirstName+�� 5,      $��1��6   $��0��6%   .��65   
LastName6?   �� 5-      $��1��6   $��1��6'   ��67   �� *
LastName+5.      �� 5/      $��1��6   $��Center=�6&    �� Orientation$ 
Horizontal=�6C   $��Center=�6\   $��5q�6w   .+�50      �� $
��Save��6   $��3q�6H   $��3q�6S   ��6(   �� *SaveCommand+6S   �� 51      $��Cancel��6   $��3q�6L   $��3q�6W   ��6*   �� *CancelCommand+6W   52      � 53      $��2��6     54      �� 55      $��* �6'   �� 56      $��2* �6'   .+�58        $��0��6    .  $ Column=�6�    . $��10q�6�   ��6+   �� *Orders+ 6J   �� *SelectedOrder+ 59        5:      $ 	OrderDate��6-   $ * 6n   	 6@   �� *	OrderDate+ �� StringFormat$ d��6n     5;      $ TotalDue��6-   $
 Auto 6\   	 6?   �� *
TotalDue+6\   5=      � 5>      $��1��6   $��10q�6M    6'   �� *SelectedOrder+ 5?      �� 5@      $
��Auto �6(   �� 5A      $
��Auto �6(   �� 5B      $
��Auto �6(   �� 5C      $
��Auto �6(   �� 5D      $
��Auto �6(     5F      �� 5G      $
��Auto �6+   �� 5H      $��* �6+   .+�5J      �� $��0��6   $��0��6)   .��69   	OrderDate6D   (  "System.Windows.Controls.DatePicker  5K      $��0��6!   $��1��6.      SelectedDate 6>   �� *	OrderDate+�� 5L      $��1��6   $��0��6)   .��69   
SubTotal6C   �� 5M      $��1��6   $��1��6+    �� 
IsReadOnly . ��6;   �� *
SubTotal+6U   �� 5N      $��2��6   $��0��6)   .��69   	TaxAmount6D   �� 5O      $��2��6   $��1��6+    . ��6;   �� *TaxAmt+6S   �� 5P      $��3��6   $��0��6)   .��69   	Freight6B   �� 5Q      $��3��6   $��1��6+    . ��6;   �� *	Freight+6T   �� 5R      $��4��6   $��0��6)   .��69   
TotalDue6C   �� 5S      $��4��6   $��1��6+    . ��6;   �� *
TotalDue+6U   5T      5U      5V      5X      5Y      