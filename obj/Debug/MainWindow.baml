   M S B A M L   `   `   `  ����@  <Labb5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Labb5Labb5  5   	       Labb5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Labb5     5   	     � Title$  
MainWindow��5   	   $��378.8��6   $	��637��6+   .��5	      � ���	#FFF4BEBE$��0,0,-6.2,-2.2q�6"    � ColumnDefinitions 5
   
   �� 5      $
��331* �6   �� 5      $
��297* �6   .+�5   
   �� -   5         ��Name$ UserBox��5      $
��Left=�6#   $	��100��6>   $��	10,28,0,0q�6K   $	��Top=�6^   $	��179��6v   ���	#FFF3E1E16�   �� 5   
   -   5        $ AdminBox��5      $
��Left=�6$   $	��100��6?   $��66.6,28,0,0q�6L   $	��Top=�6a   $	��206��6y   ���	#FFF3E1E1$��1��6�   6�   �� 5   
   -   5         ��Name$ MailBox��5      $
��Left=�6#   $��23��6>   $��
10,176,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $��Enter email adress...��6r   $	��Top=�6�   $	��179��6�   $��2��6�   �� 5   
   -   5        $ NameBox��5      $
��Left=�6#   $��23��6>   $��
10,148,0,0q�6J   $
 Wrap=�6^   $��Enter name...��6r   $	��Top=�6�   $	��179��6�   $��1��6�   �� 5   
   -   5         ��Name$ AddUser��5      $��Add user��6"   $
��Left=�65   $��
10,226,0,0q�6P   $	��Top=�6d   $	��100��6|   ���	#FFF3E1E1$��3��6�   �� 5   
   -   5        $ 
ChangeUser��5      $��Change user info��6%   $
��Left=�6@   $��
10,259,0,0q�6[   $	��Top=�6o   $	��100��6�   ���	#FFF3E1E1$��4��6�   �� 5   
   -   5        $ 
RemoveUser��5      $��Remove user��6%   $
��Left=�6;   $��
10,296,0,0q�6V   $	��Top=�6j   $	��100��6�   ���	#FFF3E1E1{�.  $��5��6�   �� 5   
   -   5        $ AddToAdminList��5      $��Move to adminlist >>��6)   $
��Left=�6N   $��
223,54,0,0q�6i   $	��Top=�6}   $	��137��6�   ���	#FFF3E1E1$��2��6�   $��6��6�   {�.  6�   �� 5   
   -	   5        $ AddToUserList��5      $��<< Move to userlist��6(   $
��Left=�6L   $��
223,78,0,0q�6g   $	��Top=�6{   $	��137��6�   ���	#FFF3E1E1$��2��6�   $��7��6�   {�.  6�   �� 5   
   -
   5         ��Name$ UserInfo��5      $�� ��6"   $
��Left=�6-   $��317,201,0,0q�6H   $	��Top=�6]   $	��139��6u   $	��246��6�   $��2��6�   5      5      