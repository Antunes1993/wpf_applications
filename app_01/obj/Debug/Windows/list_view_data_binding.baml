   M S B A M L   `   `   `  ����A  =app_01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:app_01.Windowsapp_01.Windows  5   	   +    %app_01.Windows.list_view_data_binding   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:app_01.Windows     5   	     � Title$  list_view_data_binding��5   	   $	��450��6(   $	��800��65   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5        $��tbEntry��5      $��35��6!   $��16(�6-   $��5,0,0,0q�6;   �� 5   
   -   5        $��btnAdd��5   !   $��1��6   $��30��6/   $	��Add��6;   $��10,10,275,10q�6^   �� 5   
   -   5        $��btnDel��5   !   $��1��6   $��30��6/   $��Delete��6;   $��130,10,162,10q�6a   �� 5   
   -   5        $��btnClr��5   !   $��1��6   $��30��6/   $��Clear��6;   $��243,10,36,10q�6`   �� 5   
   -   5        $��	lvEntries��5      $��1��6$   $��2��61    �� SelectionMode$ Multiple=�6E   ��6^   �� *	Entries+5      5      