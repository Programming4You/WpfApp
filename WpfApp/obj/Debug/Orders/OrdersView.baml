   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp.OrdersWpfApp.Orders  5          WpfApp.Orders.OrdersView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp.Orders     5      .��5	      � $��10q�6     � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  $��0��6      AutoGenerateColumns .     HeadersVisibility$ Column=�6�      
IsReadOnly . ��6#   �� *Orders+ �� SelectedItem 6B   �� *SelectedOrder+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	OrderDate��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	OrderDate+	 �� StringFormat$	 d��6f     5      $ TotalDue��6%   $ * 6T    67   �� *
TotalDue+6T   5      � 5   
   $��1��6   
 � DataContext
 6   �� *SelectedOrder+ � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6      5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5       �� $��0��6   $��0��6!   .��61   	OrderDate6<   �� 5!      $��0��6   $��1��6#    �� 
IsReadOnly . ��63   �� *	OrderDate+$	 d��6^   �� 5"      $��1��6   $��0��6!   .��61   
SubTotal6;   �� 5#      $��1��6   $��1��6#    . ��63   �� *
SubTotal+6M   �� 5$      $��2��6   $��0��6!   .��61   	TaxAmount6<   �� 5%      $��2��6   $��1��6#    . ��63   �� *TaxAmt+6K   �� 5&      $��3��6   $��0��6!   .��61   	Freight6:   �� 5'      $��3��6   $��1��6#    . ��63   �� *	Freight+6L   �� 5(      $��4��6   $��0��6!   .��61   
TotalDue6;   �� 5)      $��4��6   $��1��6#    . ��63   �� *
TotalDue+6M   5*      5+      5,      