   M S B A M L   `   `   `  ����F  BHomeLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HomeLibraryHomeLibrary  5   	       HomeLibrary.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HomeLibrary     5   	     � Title$  HomeLibrary��5   	   $	��400��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   �� -   5         ��Name$ listView��5      $	��245��6%   $	��740��62   $��
20,32,20,0q�6>   $	��Top=�6R   ���	#FFCBD7DE��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5       �� Binding 6&   �� *MyMark+ �� Value 6A   Z� .a�5      ��  �� Property � �� �� Value �	#FF75B99A6;   5      �� 5       6&   �� *PriorityToRead+ 6I   Z� .a�5      ��  � �� �	#FF70B1B86;   5      5      	 �� View	 5      �� 5      .P�5      �� $��Title��6%   
 �� Width$	
 200��6[    �� DisplayMemberBinding 64   �� *Title+6[   �� 5      $��Author��6%   $	
 200��6]    65   �� *Author+6]   �� 5      $
��Year��6%   $
 70��6Y    63   �� *Year+6Y   �� 5      $��Pages��6%   $
 70��6c    64   �� *NumberOfPages+6c   �� 5      $
��Mark��6%   $	
 100��6[    63   �� *MyMark+6[   �� 5      $��Priority��6%   $	
 100��6g    67   �� *PriorityToRead+6g   5       5"      �� 5#   
   -   5         ��Name$ AddBookButton��5#      $��Add Book��6(   $
��Left=�6;   $��28��6V   $��
20,301,0,0q�6b   $	��Top=�5$      $	��120��6)   65   �� 5%   
   -   5        $ RemoveButton��5%      $��Remove Book��6'   $
��Left=�6=   $��28��6X   $��646,301,0,0q�6d   $	��Top=�5&      $	��120��6)    � UseLayoutRounding .  6O   5'      5(      