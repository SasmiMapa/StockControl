   M S B A M L   `   `   `  ����G  CStockControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StockControl.ViewStockControl.View  5   	   "    StockControl.View.ViewStocks   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   0viewclr-namespace:StockControl.View     5   	     � Title$  
ViewStocks��5   	   $	��700��6   $	��800��6)    � Icon$H BC:\Users\VCT\RiderProjects\StockControl\StockControl\inventory.ico��5	   	   ��5      �� 5   
    �� ImageSource$J DC:\Users\VCT\RiderProjects\StockControl\StockControl\background2.jpg��6    � DataContext 5      &    StockControl.View.ViewStockModel  5   
    � 	Resources 5         
GridStyle1 �� 
TargetType �� Property �� Value��%}   &	        �� 5   
   " �6#   .�5      ��  � ��$	 Top=�62   �� 5       � ��$ 0,20,0,0q�6'   5      5      .��5      � #���   6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5       $��* �6   	 � RowDefinitions	 5#   
   �� 5$      $
��Auto �6   �� 5%      $��* �6   �� 5&      $
��Auto �6   .+�5)   
   �� $��0��6   $��0��6%   $��2��62   
 �� Orientation$
 Vertical=�6F   $��Center=�5*      .+�5+      �� $H��BC:\Users\VCT\RiderProjects\StockControl\StockControl\inventory.ico��6   $��70��6`   $��70��6k   $��	0,20,0,10q�5,      �� 5-      $��Stock Control��6     	LogoStyle#��[ 6-   5.      &   System.Windows.Controls.DataGrid  50   
   -   5          Name$ dataGrid��50   D   $��0��6   $��1��6#   $��2��60     DataGridStyle1#��[ 51        DataGridRowStyle1   RowStyle# �  52        DataGridCellStyle1   	CellStyle# [ 53        DataGridColumnHeaderStyle1   ColumnHeaderStyle# [ 54         Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ 	StockCode��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	StockCode+  57      $ 	StockName��6%    68   �� *	StockName+  58      $ Quantity��6%    67   �� *
Quantity+5:      �� 5<   
   -   5        $��1��5<      $��0��6!     
HomeButton#���  6.   .��5=      �� $D��>C:\Users\VCT\RiderProjects\StockControl\StockControl\home1.png��6   $��30��6\   $��30��6g   $��0,0,0,0q�5>      5?      5@      5A      