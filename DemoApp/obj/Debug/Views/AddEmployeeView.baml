   M S B A M L   `   `   `  ����  DemoApp#    DemoApp.Views.AddEmployeeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      A =Stylet, Version=1.3.4.0, Culture=neutral, PublicKeyToken=null)s!https://github.com/canton7/Stylet  5      
�������.��5
      �   � ColumnDefinitions  5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5    
   �� $��1��6W   $��1��6d   $��Add Employee��6t   $	��100��6�   $��5,5,5,5q�6�   {�6   �� *IsFamilyVis+ �� Click 63   !  Stylet.Xaml.ActionExtension  *ChangeVisibility+6�   �� 5!   
   $��2��6Y   $��1��6f   $��
Add Family��6v   $	��100��6�   $��5,5,5,5q�6�   {�6   �� *IsEmployeeVis+ 65     *ChangeVisibility+6�   �� 5#   
   -   5         ��Name$ EmployeeVisibility��5#      $��1��61   $��1��6>   $��4��6N   $��5��6b    �� Orientation$ Vertical=�5$      $��Center=�6,   y�6I   �� *EmployeeVisibility+.+�5%      �� $ 
Horizontal=�6   .+�5&      �� $��24(�6   .��6&   Name [First Last]:6:   �� 5'      $	��200��6   $��3,0,0,0q�6&   $��24(�6M   ��67   �� *Name+6M   5(      �� 5)      $ 
Horizontal=�6   .+�5*      �� $��24(�6   .��6&   Employee ID :65   �� 5+      $	��200��6   $��40,0,0,0q�6&   $��24(�6L   ��68   �� *ID+6L   5,      �� 5-      $ 
Horizontal=�6   .+�5.      �� $��24(�6   .��6&   	Position:61   �� 5/      $	��200��6   $��96,0,0,0q�6&   $��24(�6R   ��68   �� *
Position+6R   50      �� 51      $ 
Horizontal=�6   .+�52      �� $��24(�6   .��6&   
Address:60   �� 53      $	��200��6   $��95,0,0,0q�6&   $��24(�6Q   ��68   �� *	Address+6Q   54      �� 55      $ 
Horizontal=�6   .+�56      �� $��24(�6   .��6&   Family Members:67   �� 57      $	��200��6   $��6,0,0,0q�6&   $��24(�6V   ��67   �� *FamilyMembers+6V   58      59      �� 5;   
   -   5        $ FamilyVisibility��5;      $��1��6/   $��1��6<   $��4��6L   $��5��5<      $ Vertical=�6&   $��Center=�6=   y�6Z   �� *FamilyVisibility+.+�5=      �� $ 
Horizontal=�6   .+�5>      �� $��24(�6   .��6&   Name [First Last]:6:   �� 5?      $	��200��6   $��3,0,0,0q�6&   $��24(�6M   ��67   �� *Name+6M   5@      �� 5A      $ 
Horizontal=�6   .+�5B      �� $��24(�6   .��6&   Employee ID :65   �� 5C      $	��200��6   $��40,0,0,0q�6&   $��24(�6R   ��68   �� *
FamilyOf+6R   5D      �� 5E      $ 
Horizontal=�6   .+�5F      �� $��24(�6   .��6&   
Family ID:62   �� 5G      $	��200��6   $��83,0,0,0q�6&   $��24(�6L   ��68   �� *ID+6L   5H      �� 5I      $ 
Horizontal=�6   .+�5J      �� $��24(�6   .��6&   Relationship:65   �� 5K      $	��200��6   $��50,0,0,0q�6&   $��24(�6R   ��68   �� *
Standing+6R   5L      5M      �� 5O   
   $��2��62   $��2��6B   $��6��6V   $	��200��6c   $��50��6o   $��24(�6{    6     *AddToDatabase+.��6�   Add To Database5Q      �� 5S   
   $��2��61   $��2��6A   $��7��6U   $	��300��6b   $��50��6n   $��24(�6z   $��0,20,0,0q�6�    6     *LoadMainMenu+.��6�   BACK5U      5V      5W      