   M S B A M L   `   `   `  ����  StockControl#    StockControl.View.UpdateStock   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	     � Title$  AddStock��5   	   $	��750��6   $	��650��6'    � Icon$H BC:\Users\VCT\RiderProjects\StockControl\StockControl\inventory.ico��5   	   ��5	      �� 5
   
    �� ImageSource$J DC:\Users\VCT\RiderProjects\StockControl\StockControl\background2.jpg��6   .��5      �    	GridStyle#���   6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0��6,   $��0��69   $��3��6I   $��Center=�5      .+�5      �� $H��BC:\Users\VCT\RiderProjects\StockControl\StockControl\inventory.ico��6   $��70��6`   $��70��6k   $��	0,20,0,10q�5      �� 5       $��Stock Control��6     	LogoStyle#��[ 6-   5!      �� 5#   
   -   5         ��Name$ 	CodeLabel��5#   -   $��0��6   $��1��6    $��	StockCode��6@     
LabelStyle#��[ 6T   �� 5$   
   -   5        $ 	NameLabel��5$   -   $��0��6   $��2��6    $��	StockName��6@   #��[ 6T   �� 5%   
   -   5        $ QuantityLabel��5%   -   $��0��6   $��3��6    $��Quantity��6D   #��[ 5&      �� 5(   
   -   5         ��Name$ CodeText��5(   /   $��1��6   $��1��6"     TextBoxStyle#���  5)      �� 5*   
   -   5        $ 	CodeError��5*   -   $��0��6   $��5��6      Message#���  6@   �� 5,   
   -   5        $ NameText��5,   /   $��1��6   $��2��6"   #���  6A   �� 5-   
   -   5        $ 	NameError��5-   -   $��0��6   $��5��6    #���  6@   �� 5/   
   -   5        $ QuantityText��5/   /   $��1��6   $��3��6"   #���  6E   �� 50   
   -	   5        $ QuantityError��50   -   $��0��6   $��5��6    #���  6D   �� 53   
   -
   5         ��Name$ 	AddButton��53   .   $��0��6   $��4��6!   $��Add Item��6A     ButtonStyle#��[ 54      {�. 55   "   �� 56   
   -   5        $ RemoveButton��56   .   $��1��6   $��4��6!   $��Remove Item��6D   #��[ 57      {�. 58   "   �� 59   
   -   5        $ StatusMessage��59   -   $��0��6   $��5��6    #��[ 6D   �� 5;   
   -   5        $��2��5;      $��4��6!     
HomeButton#���  6.   .��5<      �� $D��>C:\Users\VCT\RiderProjects\StockControl\StockControl\home1.png��6   $��30��6\   $��30��6g   $��0,0,0,0q�5=      5>      5?      5@      