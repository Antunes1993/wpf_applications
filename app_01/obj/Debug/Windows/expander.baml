   M S B A M L   `   `   `  ����A  =app_01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:app_01.Windowsapp_01.Windows  5   	       app_01.Windows.expander   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:app_01.Windows     5   	     � Title$  expander��5   	   $	��450��6   $	��400��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $
��auto �6   .+�5   
   � $��0��6   .+�5      �� .+�5      �� -   5         ��Name$ tbName��5      $	��Tag��6&   $
��20px(�61   $
��Bold"�6A   9� 5      $��Basic Information��6   .��5      �� .+�5      �� -   5        $ tbName2��5      $
��Name��6/   �� 5      -   5        $ tbLabel��5      $��Label��6/   �� 5      -   5        $ tbDescription��5      $��Description��65   �� 5      -   5        $ tbSystemUID��5      $��
System UID��63   5      5      9� 5      $��Design Data��6   .��5      �� .+�5      �� -   5        $ tbManufacturer��5   "   $��Manufacturer��6:   �� 5      -   5        $ tbTemperature1��5   "   $��Min. Temp(°C)��6:   �� 5      -   5        $ tbTemperature2��5   "   $��Mid. Temp(°C)��6:   �� 5      -	   5        $ tbTemperature3��5   "   $��Max. Temp(°C)��6:   5       5!      �� 5"      -
   5         ��Name$ 
btnDetails��5"      $��100px��6F   $
��30px��6T   $��Morte Details��6b   $
��Left=�6z   $��10q�6�   5#      5$      � 5&   
   $��1��6   
����  �.+�5'      9� -   5         9�Name$ expanderDetails��5'       9� ExpandDirection$
 Left=�60   .��5(      �� $��120px��6   5)      5*      5+      5,      