   M S B A M L   `   `   `  ����A  =app_01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:app_01.Windowsapp_01.Windows  5   	   .    (app_01.Windows.custom_application_window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:app_01.Windows     5   	   -   5          � WindowStyle$
  None=�5       � Title$ custom_application_window��5   	   $	��450��6+   $	��400��68   '  !System.Windows.Shell.WindowChrome   WindowChrome 5	        5
   
      GlassFrameThickness$ 0q�6      CornerRadius$ 0��6/      CaptionHeight$ 0Q�6@   .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Right=�6.   .+�5      �� -   5         ��Name$ btnMinimize��5      $��-��6*   $��40��6P   $��40��6[   
������ 
������ 5   #   �� 5      -   5        $ btnMaximize��5      $
��🗖��6*   $��40��6Q   $��40��6\   
������ 
������ 5   #   �� 5      -   5        $ btnClose��5      $��X��6'   $��40��6J   $��40��6U   
������ 
������ 5   /   5      5      5      