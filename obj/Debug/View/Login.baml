   M S B A M L   `   `   `  ����  StockControl    StockControl.View.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	     � Title$  Login��5   	   $	��600��6   $	��550��6$    � Icon$H BC:\Users\VCT\RiderProjects\StockControl\StockControl\inventory.ico��5   	   ��5	      �� 5
   
    �� ImageSource$J DC:\Users\VCT\RiderProjects\StockControl\StockControl\background2.jpg��6   .��5      �    	GridStyle#���   6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0��6,   $��0��69   $��2��6I   $��Center=�5      .+�5      �� $H��BC:\Users\VCT\RiderProjects\StockControl\StockControl\inventory.ico��6   $��70��6`   $��70��6k   $��	0,20,0,10q�5      �� 5      $��Stock Control��6     	LogoStyle#��[ 6-   5      �� 5!   
   $��0��6   $��1��6    $��Username��6-     
LabelStyle#��[ 6@   �� 5"   
   $��0��6   $��2��6    $��Password��6-   #��[ 6@   �� 5$   
   -   5         ��Name$ userName��5$   /   $��1��6   $��1��6"     TextBoxStyle#���  6A   �� 5%   
   -   5        $ passWord��5%   /   $��1��6   $��2��6"   #���  6A   �� 5'   
   -   5         ��Name$ ErrorMessage��5'   -   $��0��6   $��4��6      Message#���  6C   �� 5)   
   -   5         ��Name$ LogInButton��5)   B   $��0��6   $��3��6!   $��2��6.   $��Log In��6W     ButtonStyle#��[ 5*      {�.  5+   #   5,      5-      