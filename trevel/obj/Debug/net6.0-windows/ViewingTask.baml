   M S B A M L   `   `   `  ����A  =trevel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:treveltrevel  5   	       trevel.ViewingTask   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:trevel     5   	     � Title$  ViewingTask��5   
   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5        $��LoginBox��5
      $��10,254,698,132q�6"   �� 5   
   -   5        $��	SearchBtn��5      $��
Найти��6"   $��102,270,616,132q�6K   �� 5   
   -   5        $��	LogOutBtn��5      $��
Назад��5      $	��100��5      $��10,15,0,350q�5      $
��Left=�5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��	TaskDGrid��5         AutoGenerateColumns$ False��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         CanUserAddRows$ False��5      $��193,15,23,15q�5         
IsReadOnly$
 True��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Создатель��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *IdOwnerNavigation.Login+  5      $ Задачи��6%    65   �� *Name+  5      $# Описание задачи��6%    6>   �� *Desck+5      5      5       