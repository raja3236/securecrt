# $language = "VBScript"  
# $interface = "1.0"  
' Note: Single quoted lines are commments  
' Note: This script can be used only by using SecureCRT application (like Putty tool for logging into unix boxes  with additional scripting interface )   
  
' Connect to a telnet server and automate the initial login sequence.  
' Note that synchronous mode is enabled to prevent server output from  
' potentially being missed.   
  
Sub Main  
  
  Dim env   'declare a var to know the unix environment in which you want to login   
  
  env = crt.Dialog.Prompt("Enter the unix environment environment:","Environment Detail","")  
    
  If env = "give your environment here in caps " Or env = "give your environment here in small letter"  Then  
    
  crt.Screen.Synchronous = True   'synchronous mode is enabled to prevent server output from  potentially being missed.   
  
  ' connect to host on port 23 (the default telnet port)  
  '  
  crt.Session.Connect "/TELNET give your ip address here"  
    
  crt.window.caption = "give the title of the window here" 'Returns or sets the title or caption of SecureCRT's application window  
  
  crt.Screen.WaitForString "login:"   'Wait for the string to appear in the terminal(screen)   
  
  crt.Screen.Send "give your userid here" & vbCr  'Sends a string of characters in the terminal(screen)   
  
  crt.Screen.WaitForString "password:"  
  
  crt.Screen.Send "give your password here" & vbCr  
   
   End If  
  
End Sub  
