   M S B A M L   `   `   `  ����A  =trevel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:treveltrevel  5   	       trevel.cabinet   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:trevel     5   	     � Title$  Private��5   	   $	��550��6   $
��1000��6&   .��5	      � .+�5
   
   �� $��Задания��6   $
��Left=�6"   $��
553,26,0,0q�6=   $	��Top=�6Q   $��25(�6i   �� 5   
   $!��Личный кабинет��6   $
��Left=�6)   $��	223,6,0,0q�6D   $	��Top=�6W   $��25(�6o   &   System.Windows.Controls.DataGrid  5   
   -   5        $��UserAndTask��5         AutoGenerateColumns$ False��6&      CanUserAddRows$ False��6B      
IsReadOnly$
 True��6Y   $��311,74,24,25q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 25 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Id+  5      $' !Название предмета��6%   $	 180 6@    6L   �� *Name+  5      $# Описание задачи��6%   $	 200 6>    6J   �� *Desck+  5      $ Статус задачи��6%   $	 100 6<    6H   �� *IdStatusTaskNavigation.Name+  5      $# Дата публикации��6%   $ 90 6>    6I   �� *
PublicDate+5      �� 5   
   $
��Left=�6   $��	31,74,0,0q�6-   $	��150��5       �� TextWrapping$
 Wrap=�6   $	��Top=�62   $��15(�6J   $��40��6X   $��Center=�5      	 � Cursor$	 Arrow��64   ��5   @   �� *	FirstName+5   4   �� 5   
   $��Имя:��6   $
��Left=�6   $��33,50,0,355q�6:   $	��Top=�6O   $��15(�6g   �� 5   
   $
��Left=�6   $��
31,143,0,0q�6-   $	��150��5      $
 Wrap=�6   $	��Top=�62   $��15(�6J   $��30��6X   $��Center=�5      ��5   A   �� *
SecondName+5      �� 5   
   $��Фамилия:��6   $
��Left=�6#   $��
33,114,0,0q�6>   $	��Top=�6R   $��15(�6j   �� 5    
   $
��Left=�6   $��
33,217,0,0q�6-   $	��150��5!      $
 Wrap=�6   $	��Top=�62   $��15(�6J   $��30��6X   $��Center=�5"      ��5    A   �� *
LastName+5"      �� 5#   
   $��Отчество:��6   $
��Left=�6$   $��
33,188,0,0q�6?   $	��Top=�6S   $��15(�6k   �� 5%   
   $
��Left=�6   $��
33,284,0,0q�6-   $	��150��5&      $
 Wrap=�6   $	��Top=�62   $��15(�6J   $��30��6X   $��Center=�5'      ��5%   A   �� *Phone+5'      �� 5(   
   $��Телефон:��6   $
��Left=�6#   $��
33,255,0,0q�6>   $	��Top=�6R   $��15(�6j   �� 5)   
   -   5        $��История��5)      $
��Left=�6#   $��
821,10,0,0q�6>   $	��Top=�6R   $��95��6j   $��42��6u   6�   �� 5*   
   .+�5+      �� -   5        $��	ChechTask��5+   F   $��31,333,731,119q�6   $!��Просмотр задач��6-   $��16(�6o   $
	 Hand��6}   �� 5,      -   5        $��	ChechUser��5,   R   $/��)Просмотр пользователя��6   $��31, -110, 731, 120q�65   $
	 Hand��6{   �� 5-      -   5        $��CreateReportBtn��5-   -   $��Создать отчет��6   $
��Left=�6b   $��31,-110,731,119q�6}   $��42��6�   $	��174��6�   5/      51      52      