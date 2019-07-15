<%@ Import Namespace ="System.Data" %>
<%@ Import Namespace ="System.Data.Sqlclient" %>
<script runat="server">

    Dim cn As SqlClient.SqlConnection
    Dim reader As SqlClient.SqlDataReader
    Dim com As SqlClient.SqlCommand
    Dim ds As New Data.DataSet
    Dim adap As SqlClient.SqlDataAdapter

    Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            cn = New SqlClient.SqlConnection("Server=LTELMXJCORREA1; Database=Book; User=sa; Password=telepro;")
            cn.Open()
            com = New SqlClient.SqlCommand("Select * From Book", cn)
            reader = com.ExecuteReader()


            cn = New SqlClient.SqlConnection("Server=LTELMXJCORREA1; Database=Book; User=sa; Password=telepro;")
            cn.Open()
            adap = New SqlClient.SqlDataAdapter("Select Distinct Catid, CatName From Category", cn)
            adap.Fill(ds, "Category")
            mylist.DataTextField = "CatName"
            mylist.DataValueField = "Catid"
            mylist.DataSource = ds
            mylist.DataBind()

            cn.Close()
        End If
    End Sub

    Sub list1_change(ByVal s As Object, ByVal e As EventArgs)
        Dim val As String
        val = mylist.SelectedValue

        cn = New SqlClient.SqlConnection("Server=LTELMXJCORREA1; Database=Book; User=sa; Password=telepro;")
        cn.Open()
        com = New SqlClient.SqlCommand("Select Title From Book Where Catid='" & val & "'", cn)
        reader = com.ExecuteReader

        grid1.DataSource = reader
        grid1.DataBind()


    End Sub

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
<title>IT Books Collection</title>
</head>
<body>
<form id="form1" runat="server">
<center><p>
Select category:
<asp:DropDownList ID="mylist" runat ="server" AutoPostBack ="true" OnSelectedIndexChanged ="list1_change" />
</p>
<p>
<asp:GridView ID="grid1" runat ="server"
HeaderStyle-BackColor="AliceBlue" />
</p>
</center> 
</form>
</body>
</html>