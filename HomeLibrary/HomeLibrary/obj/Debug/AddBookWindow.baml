   M S B A M L   `   `   `  ����F  BHomeLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HomeLibraryHomeLibrary  5   	       HomeLibrary.AddBookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HomeLibrary     5   	     � Title$  AddBook��5   	   $	��380��6   $	��300��6&    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   �� -   5         ��Name$ TitleTextBox��5      $
��Left=�6(   $��23��6C   $��
152,20,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $ AuthorTextBox��5      $
��Left=�6)   $��23��6D   $��
152,62,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ YeraTextBox��5      $
��Left=�6'   $��23��6B   $��152,104,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $ PagesTextBox��5      $
��Left=�6(   $��23��6C   $��152,147,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5         ��Name$ 
TitleLabel��5      $��Title:��6$   $
��Left=�65   $��	10,20,0,0q�6P   $	��Top=�6c   $��91��6{   $��23��6�   �� 5   
   -   5        $ AuthorLabel��5      $��Author:��6%   $
��Left=�67   $��	10,62,0,0q�6R   $	��Top=�6e   $��91��6}   $��30��6�   �� 5   
   -   5        $ 	YearLabel��5      $��Year:��6#   $
��Left=�63   $��
10,104,0,0q�6N   $	��Top=�6b   $��91��6z   $��30��6�   �� 5   
   -   5        $ 
PagesLabel��5      $��Pages:��6$   $
��Left=�65   $��
10,147,0,0q�6P   $	��Top=�6d   $��91��6|   $��30��6�   �� 5   
   -	   5        $ ReadedLabel��5      $��Readed:��6%   $
��Left=�67   $��
10,190,0,0q�6R   $	��Top=�5      $��91��6(   $��30��63    J� RenderTransformOrigin$ 
0.54,2.164&�6?   �� 5   
   -
   5         ��Name$ OkButton��5      $��Ok��6#   $
��Left=�60   $��106,312,0,0q�6K   $	��Top=�5      $��75��6)   $ 0.889,0.765&�64   6X   �� 5   
   -   5         ��Name$ ReadedComboBox��5      $
��Left=�6+   $��152,190,0,0q�6F   $	��Top=�5      $	��120��6+   6i   �� 5   
   -   5        $ PriorityLabel��5      $��	Priority:��6'   $
��Left=�6;   $��
10,235,0,0q�6V   $	��Top=�5      $��91��6(   $��30��63   $ 
0.54,2.164&�6?   �� 5   
   -   5        $ 	MarkLabel��5      $��Mark:��6#   $
��Left=�63   $��201,235,0,0q�6N   $	��Top=�5      $��91��6(   $��30��63   $ 
0.54,2.164&�6?   �� 5   
   -   5        $ PriorityComboBox��5      $
��Left=�6-   $��
10,270,0,0q�6H   $	��Top=�6\   $��62��6t   6   �� 5   
   -   5        $ MarkComboBox��5      $
��Left=�6)   $��201,270,0,0q�6D   $	��Top=�6Y   $��62��6q   6|   5      5       