   M S B A M L   `   `   `  ����B  >CRN_AT3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CRN_AT3CRN_AT3  5   	       CRN_AT3.EmployeeMain   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CRN_AT3     5   	     � Title$  EmployeeMain��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��24 �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��24 �6    � RowDefinitions 5   
   �� 5      $��16 �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��16 �6   .+�5   
   �� -   5         ��Name$ SearchEmployeeLabel��5      $��Search by Family Name��6-   $��1��6M   $��1��6]   $��8,8,5.6,7.2q�6j   $��18(�6   �� 5   
   -   5         ��Name$ SearchEmployeeTextbox��5      $��2��61   $��1��6A   $��32��6N   $��10.4,8,7.6,7.2q�6]    �� TextWrapping$
 wrap=�6u   $�� ��6�   $��14(�6�   �� 5    
   -   5         ��Name$ 
FillButton��5       $��	Fill list��6%   $��14(�6R   
�������
���   �$��1��6�   $��2��6�   $��
10,10,10,5q�6�   $��30��6�   $	��Top=�6�   �� 5!   
   -   5        $ Searchrecord��5!      $��Search��6'   $��14(�6S   
�������
���   �$��1��6�   $��3��6�   $��
10,10,10,5q�6�   $��30��6�   $	��Top=�6�   �� 5"   
   -   5        $ AdvancedSearchrecord��5"      $��Advanced Search��6/   $��14(�6l   
�������
���   �$��1��6�   $��4��6�   $��
10,10,10,5q�6�   $��30��6�   $	��Top=�6�   �� 5#   
   -   5        $ Insertrecord��5#      $��Insert��6'   $��14(�6S   
�������
���   �$��1��6�   $��5��6�   $��
10,10,10,5q�6�   $��30��6�   $	��Top=�6�   �� 5$   
   -   5        $ Deleterecord��5$      $��Delete��6'   $��14(�6S   
�������
���   �$��1��6�   $��6��6�   $��
10,10,10,5q�6�   $��30��6�   $	��Top=�6�   �� 5%   
   -   5        $ 
Editrecord��5%      $
��Edit��6%   $��14(�6M   
�������
���   �$��1��6�   $��7��6�   $��
10,10,10,5q�6�   $��30��6�   $	��Top=�6�   �� 5&   
   -	   5        $ JoinOperation��5&      $��Join Operation��6(   $��14(�6c   
�������
���   �$��1��6�   $��8��6�   $��
10,10,10,5q�6�   $��30��6�   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5(   
   -
   5          Name$ EmployeeDataGrid��5(      $��2��6-   $��2��6>   $��6��6K   
�������$��10.2,9,7.6,9.6q�6s      AutoGenerateColumns$ False��6�   	   Columns	 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+  5+      $
 
Given Name��6%    69   �� *	GivenName+  5,      $
 Family Name��6%    6:   �� *
FamilyName+  5-      $	
 DoB��6%    62   �� *DateOfBirth+ �� StringFormat$ 
yyyy-MM-dd��  5.      $
 Gender Identity��6%    6>   �� *GenderIdentity+  5/      $
 Gross Salary��6%    6;   �� *GrossSalary+  50      $
 Supervisor ID��6%    6<   �� *SupervisorID+  51      $
 	Branch ID��6%    68   �� *
BranchID+53      �� 56   
   -   5        $ CloseWindow��56      $��Back to main window��6&   $��14(�6d   
�������
���   �$��2��6�   $��8��6�   $��
10,10,10,5q�6�   $��30��6�   $	��Top=�6�   58      59      