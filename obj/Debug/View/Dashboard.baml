   M S B A M L   `   `   `  ����  StockControl!    StockControl.View.Dashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	     � Title$
  Home��5   	   $	��500��6   $	��600��6#    � Icon$H BC:\Users\VCT\RiderProjects\StockControl\StockControl\inventory.ico��5   	   ��5	      �� 5
   
    �� ImageSource$J DC:\Users\VCT\RiderProjects\StockControl\StockControl\background2.jpg��6    � 	Resources 5         ButtonStyle1 �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value��%�  &	        �� 5   
   " ��6%   .�5      ��  � �� �#088F8F6+   �� 5       � ��
 �����6+   �� 5       � ��$	 100��6'   �� 5       � ��$	 150��6&   �� 5       � ��$ Cascadia Code)�6+   �� 5       � ��$ 20(�6)   �� 5       � ��$ 	0,50,25,0q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 20��6!   #��z��5   !   #��z��5   !   #��z��5   !   ._�5      �� #��z��6/   #��z��5   /   5      	 5       P� 5!      
 �@J�IsMouseOver . . �5"   "   ��  � �� �#00A9FA6?   5#      5%      5'      5(      5*      .��5,      �   	GridStyle#���  6    � ColumnDefinitions 5-   
   �� 5.      $
��Auto �6   �� 5/      $
��Auto �6   �� 50      $
��Auto �6    � RowDefinitions 52   
   �� 53      $
��Auto �6   �� 54      $
��Auto �6   .+�57   
   ��  �� Orientation$ Vertical=�6   $��0��6,   $��0��69   $��3��6I   $��Center=�58      .+�59      �� $H��BC:\Users\VCT\RiderProjects\StockControl\StockControl\inventory.ico��6   $��70��6`   $��70��6k   $��	0,20,0,10q�5:      �� 5;      $��Stock Control��6     	LogoStyle#��[ 6-   5<      �� 5>   
   -   5        $��0��5>      $��1��6!   #���   6.   .��5?      �� $ Vertical=�6   .+�5@      �� $G��AC:\Users\VCT\RiderProjects\StockControl\StockControl\addStock.png��6   $��50��6c   $��50��5A      $��0,0,5,0q�6$   �� 5B      $��Update Stock��6   5C      5D      �� 5F   
   -   5        $��1��5F      $��1��6!   #���   6.   .��5G      �� $ Vertical=�6   .+�5H      �� $D��>C:\Users\VCT\RiderProjects\StockControl\StockControl\table.png��6   $��50��6`   $��50��6k   $��0,0,5,0q�5I      �� 5J      $��View Stocks��6   5K      5L      �� 5N   
   -   5        $��2��5N      $��1��6!   #���   6.   .��5O      �� $ Vertical=�6   .+�5P      �� $K��EC:\Users\VCT\RiderProjects\StockControl\StockControl\transactions.png��6   $��50��6g   $��50��5Q      $��5,0,5,0q�5R      �� 5S      $��View Log��6   5T      5U      5W      5X      