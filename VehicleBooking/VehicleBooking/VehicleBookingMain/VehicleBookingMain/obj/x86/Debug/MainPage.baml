   M S B A M L   `   `   `  ����M  IVehicleBookingMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:VehicleBookingMain.MasterVehicleBookingMain.Master  5   	   !    VehicleBookingMain.MainPage   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   8master'clr-namespace:VehicleBookingMain.Master    5   	   Fi:http://schemas.microsoft.com/expression/2010/interactivity    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  MainPage��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��600��6@   $
��1200��6M   .��5      � .+�5   
   � $��Center=�6    � RowDefinitions 5	      �� 5
      $
��auto �6    �� 5      $��* �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��10q�62   $��Center=�6>   .+�5      �� -   5         ��Name$ brdGeoMaster��5      $��50��6o   $	��150��6{   
�������$��.5q�6�    �� CornerRadius$ 	10 0 0 10��6�   
����ح�._�5      �� $��
Geo Master��6    
����ح�$��15(�6I   $��Center=�6W   $��Center=�6r   5      �� 5      -   5        $ brdUserMater��5      $��50��6m   $	��150��6y   
�������$��.5q�6�   
����ح�._�5      �� $��User Master��6    
����ح�$��15(�6J   $��Center=�6X   $��Center=�6s   5      �� 5      -   5        $ brdCabMaster��5      $��50��6m   $	��150��6y   
�������$��.5q�6�   
����ح�._�5      �� $��
Cab Master��6    
����ح�$��15(�6I   $��Center=�6W   $��Center=�6r   5      �� 5      -   5        $ brdDriverMater��5      $��50��6o   $	��150��6{   
�������$��.5q�6�   
����ح�._�5      �� $��Driver Master��6    
����ح�$��15(�6L   $��Center=�6Z   $��Center=�6u   5      �� 5      -   5        $ brdBookingMaster��5      $��50��6q   $	��150��6}   
�������$��.5q�6�   
����ح�._�5      �� $��Booking Master��6    
����ح�$��15(�6M   $��Center=�6[   $��Center=�6v   5      �� 5      -   5        $ brdInvoiceMaster��5      $ 	0 10 10 0��6q   $��50��6�   $	��150��6�   
�������$��.5q�6�   
����ح�._�5      �� $��Invoice Master��6    
����ح�$��15(�6M   $��Center=�6[   $��Center=�6v   5       5!      � 5#      $��1��6   $
��Left=�6!   .+�5$      � -   5         �Name$ 	grdMaster��5$      5(      5)      5*      5+      