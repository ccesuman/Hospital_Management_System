   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      H DHealthcareWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HealthcareWpfHealthcareWpf 5	         HealthcareWpf.InsertPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      6sys&clr-namespace:System;assembly=mscorlib     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:HealthcareWpf     5	        N� Title$  
InsertPage��5      .��5      �  J� OpacityMask# � ��6   ���	#FF8CC673$��
0,-13,0,13q�6t   .+�5   
   �� -   5         ��Name$ HoapitalNameTX��5      $
��Left=�6*   $��
160,34,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��177��6�   $��34��6�   �� 5   
   -   5        $ PrimaryAddressTX��5      $
��Left=�6,   $��
160,86,0,0q�6G   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��177��6�    J� RenderTransformOrigin$ 
1.82,1.002&�6�   $��36��6�   �� 5   
   -   5        $ SecondaryAddressTX��5      $
��Left=�6.   $��160,139,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��177��6�   $��31��6�   �� 5   
   -   5        $ 	PinCodeTX��5      $
��Left=�6%   $��160,185,0,0q�6@   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��177��6�   $��40��6�   �� 5   
   -   5        $ DepartmentTX��5      $
��Left=�6(   $��160,241,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��177��6�   $��32��6�   �� 5   
   -   5        $ TotalRoomTX��5      $
��Left=�6'   $��160,284,0,0q�6B   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��177��6�   $��39��6�   �� 5   
   -   5        $ FunctionalRoomTX��5      $
��Left=�6,   $��
501,34,0,0q�6G   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��165��6�   $��34��6�   �� 5   
   -   5        $ TotalDoctorsTX��5      $
��Left=�6*   $��
501,86,0,0q�6E   $
 Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��165��6�   $��36��6�   �� 5   
   -	   5        $��Submit��5      $
��Left=�6"   $��600,380,0,0q�6=   $	��Top=�6R   $	��115��6j   $��42��6v   $
��Bold"�6�   $��16(�6�   $ 0.216,1.965&�6�   6�   �� 5   
   $��FunctionalRoom��6   $
��Left=�6)   $��
357,38,0,0q�6D   $	��Top=�6X   $ 0.542,-0.177&�6p   $	��139��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   $��TotalDoctors��6   $
��Left=�6'   $��
357,86,0,0q�6B   $	��Top=�6V   $ 0.542,-0.177&�6n   $	��120��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   $��	City Code��6   $
��Left=�6$   $��357,144,0,0q�6?   $	��Top=�6T   $ 0.542,-0.177&�6l   $	��120��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   $��
State Code��6   $
��Left=�6%   $��357,192,0,0q�6@   $	��Top=�6U   $ 0.542,-0.177&�6m   $	��120��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   $��Country Code��6   $
��Left=�6'   $��357,241,0,0q�6B   $	��Top=�6W   $ 0.542,-0.177&�6o   $	��120��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   $��Hospital Name��6   $
��Left=�6(   $��	22,38,0,0q�6C   $	��Top=�6V   $ 0.542,-0.177&�6n   $	��133��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   $��Primary Address��6   $
��Left=�6*   $��	22,91,0,0q�6E   $	��Top=�6X   $ 0.542,-0.177&�6p   $	��133��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   $��Sec. Address��6   $
��Left=�6'   $��
22,139,0,0q�6B   $	��Top=�6V   $ 0.542,-0.177&�6n   $	��106��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   $��Pin Code��6   $
��Left=�6#   $��
22,187,0,0q�6>   $	��Top=�6R   $ 0.542,-0.177&�6j   $	��106��6�   $��16(�6�   $
��Bold"�6�   �� 5    
   $��No of Depart.��6   $
��Left=�6(   $��
22,244,0,0q�6C   $	��Top=�6W   $ 0.542,-0.177&�6o   $	��133��6�   $
��Bold"�6�   $��16(�6�   �� 5!   
   $��
Total Room��6   $
��Left=�6%   $��
22,297,0,0q�6@   $	��Top=�6T   $ 0.542,-0.177&�6l   $	��106��6�   $��16(�6�   $
��Bold"�6�   �� 5"   
   -
   5         ��Name$ CitycodeBOX��5"      $
��Left=�6(   $��501,150,0,0q�6C   $	��Top=�6X   $	��165��6p   $��25��6|   �� 5#   
   -   5        $ StateCodeBOX��5#      $
��Left=�6)   $��501,198,0,0q�6D   $	��Top=�6Y   $	��165��6q   $��27��6}   �� 5$   
   -   5        $ CountryCodeBOX��5$      $
��Left=�6+   $��501,249,0,0q�6F   $	��Top=�6[   $	��165��6s   $��26��6   5'      5(      