   M S B A M L   `   `   `  ����C  ?Debtbook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DebtbookDebtbook  5   	   9!clr-namespace:Debtbook.ViewModelsDebtbook.ViewModels  5   	       Debtbook.DebitorWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Debtbook     5   	   8
viewModels!clr-namespace:Debtbook.ViewModels     5   	   $
��Thin"�5	   	     � Title$  DebitorWindow��5
   	   $	��300��6   $	��560��6,   $	��560��6;   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��400 �6   6-   �� 5      $	��150 �6   6-    � RowDefinitions 5   
   �� 5      6   �� 5      $
��0.2* �6   6,   .+�5   
   �� $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��16(�6   $
��Thin"�6*   $��
Debts of: ��6<   $��
10,10,0,10q�6N   6d   �� 5      $��16(�6   $
��Thin"�6*   $��
0,10,10,10q�6_   ��6<   ��  �� Path$ DebitorsName�6u   5      &   System.Windows.Controls.DataGrid  5      -   5        $��
dgDebitors��5"         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         AutoGenerateColumns .  $��
10,0,10,10q�5          
IsReadOnly . ��5      �� *Debts+   Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Debt name��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6<   �� *	DebtName_+6\     5&      $	 	Debt size��6)   
 6<   �� *SizeOfDebt_+6^     5'      $	 	Debt date��6)   
 6<   �� *DateOfDebt_+6^   5)      5*      �� 5+   
   $��1��6   .+�5,      �� $��
10,38,20,0q�6   Name of new debt:6B   �� 5-      -   5        $��newDebtName��5-      $��
10,0,20,20q�6)   .��6=   .��5.      �� $ NewDebtName�6    �� UpdateSourceTrigger$ PropertyChanged=�6-   6U   5/      �� 50      $��	10,0,20,0q�6   New debt size:6>   �� 51      $��
10,0,20,10q�6   .��6*   .��52      �� $ NewDebtValue�6   $ PropertyChanged=�6.   6V   53      �� 54      $��
10,0,20,10q�6   $��20��6)   $��60��65   ��6@   �� $ AddNewDebtCommand�.��6l   
Add Debt56      57      �� 59   
   -   5        $��2��59      $��1��6%   $��20��62   $��60��6>   ��6I   �� $ CloseWindowCommand�.��6�   Close5;      5>      5@      