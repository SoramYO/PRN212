   M S B A M L   `   `   `  ����O  KProductManagermentUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ProductManagermentUIProductManagermentUI  5   	   %    ProductManagermentUI.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ProductManagermentUI     5   	   -   5          � Title$  
MainWindow��5      $	��880��6   $
��1720��6&    � WindowStartupLocation$ CenterScreen=�63   .��5	      � .+�5
   
   �� -   5         ��Name$ ProductNameTextBox��5
       $��20(�6   $��738,343,122,470q�6<   �� 5   
   -   5        $ ProductDescriptionTextBox��5       $��20(�6   $��738,429,122,385q�6C   �� 5   
   -   5        $ ProductPriceTextBox��5       $��20(�6   $��738,515,122,299q�6=   �� 5   
   -   5        $��22(�5      $��Create product��6   $��738,666,136,125q�68   6Q   �� 5   
   -   5         ��Name$ CategoryCombo��5   "   $��20(�6   $
��Left=�69   $��738,600,0,0q�6T   $	��Top=�6i   $	��828��6�   $��45��6�   �� 5   
   -   5         ��Name$ QrCodeImage��5      $
��Left=�6T   $	��392��6o   $��
74,374,0,0q�6|   $	��Top=�6�   $	��410��6�   �� 5   
   -   5        $ BarCodeImage��5      $
��Left=�6&   $��90��6A   $��
46,168,0,0q�6M   $	��Top=�6a   $	��718��6y   �� 5   
   $��20(�6   $
��Name��6   $
��Left=�6-   $��623,354,0,0q�6H   $	��Top=�6]   $��40��6u   $��78��6�   �� 5   
   $��20(�6   $��Description��6   $
��Left=�64   $��589,440,0,0q�6O   $	��Top=�6d   $��39��6|   $	��112��6�   �� 5   
   $��20(�6   $��Price��6   $
��Left=�6.   $��623,525,0,0q�6I   $	��Top=�6^   $��40��6v   $��54��6�    J� RenderTransformOrigin$ 0.843,0.364&�6�   �� 5   
   $��20(�6   $��Category��6   $
��Left=�61   $��599,606,0,0q�6L   $	��Top=�6a   $��39��6y   $	��102��6�   $ -1.784,7.193&�6�   �� 5   
   $��80(�6   $��Add Product��6   $
��Left=�64   $��934,110,0,0q�6O   $	��Top=�6d   �� 5   
   -	   5         ��Name$ ScanQRCodeButton��5      $��20(�6+   $��Scan QRCode��69   $
��Left=�6O   $��1504,70,0,0q�6j   $	��Top=�6   $��60��6�   $	��164��6�   6�   5      5      