   M S B A M L   `   `   `  ����B  >CRN_AT3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CRN_AT3CRN_AT3  5   	   #    CRN_AT3.EmployeeJoinOperation   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CRN_AT3     5   	     � Title$  EmployeeJoinOperation��5   	   $	��450��6'   $	��800��64   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��24 �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��24 �6    � RowDefinitions 5   
   �� 5      $��16 �6   �� 5      $��1* �6   �� 5      $��16 �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��16 �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��16 �6   .+�5!   
   �� -   5         ��Name$ SearchEmployeeLabel��5!      $��Search by Family Name��6-   $��1��6M   $��1��6]   $��8,8,5.6,7.2q�6j   $��18(�6   �� 5"   
   -   5         ��Name$" EmployeeJoinOperationTextbox��5"      $��2��68   $��1��6H   $��32��6U   $��10.4,8,7.6,7.2q�6d    �� TextWrapping$
 wrap=�6|   $�� ��6�   $��14(�6�   �� 5#   
   -   5         ��Name$ ResultButton��5#      $��Result��6'   $��14(�6S   
�������
���   �$��3��6�   $��1��6�   $��
10,10,10,5q�6�   $��30��6�   $	��Top=�6�   �� 5&   
   -   5        $ TotalSalesLabel��5&      $��Total Sales��6)   $��2��6?   $��3��6O   $��8,8,5.6,7.2q�6\   $��18(�6q   �� 5'   
   -   5        $ TotalSalesTextbox��5'      $��2��6-   $��4��6=   $��2��6J   $��32��6^   $��10.4,8,7.6,7.2q�6m   $
 wrap=�6�   $�� ��6�   $��14(�6�   �� 5)   
   -   5        $ SalesByClientLabel��5)      $��Sales By Client��6,   $��2��6F   $��6��6V   $��8,8,5.6,7.2q�6c   $��18(�6x   &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ JoinOperationDataGrid��5*      $��2��62   $��7��6C   $��3��6P   $��2��6a   
�������$��10.2,9,7.6,9.6q�6�   5,      5-      5.      