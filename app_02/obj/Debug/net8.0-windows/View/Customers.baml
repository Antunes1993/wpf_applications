   M S B A M L   `   `   `  ����A  =app_02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:app_02.Viewapp_02.View  5      3clr-namespace:app_02.ViewModelapp_02.ViewModel  5          app_02.View.Customers   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:app_02.View     5      -vmclr-namespace:app_02.ViewModel     5         
Page_Style#��[  5	   7     � DataContext  5
      !  app_02.ViewModel.CustomerVM  5   
   .��5      � .+�5   
   ��  �� CornerRadius$ 	0,20,20,0��6   ��5      �� 5       �� ImageSource$ /Images/customer_page.png��6    j� Stretch$
 None=�6E   5      �� 5   
   $��Customer ID :��6   ���#DBDBDB$��12(�5      $
��Left=�5      $	��Top=�5      $��/Fonts/#Rubik Medium)�5      $��80, 154,0,0q�5      �� 5   
   ���#CED565$��12(�5      $
��Left=�5      $	��Top=�5       $��/Fonts/#Rubik Medium)�5!      $��175,154,0,0q�5"      ��5      �� *
CustomerID+5"      5#      5$      