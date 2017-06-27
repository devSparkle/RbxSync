Imports Windows.Networking.Sockets

Public Class SocketManager
	Dim SocketListener As StreamSocketListener

	Public Sub New()
		Debug.WriteLine("New SocketManager requested")

		SocketListener = New StreamSocketListener

		LoadEventConnection()
	End Sub

	Private Async Sub LoadEventConnection()
		AddHandler SocketListener.ConnectionReceived, AddressOf ConnectionReceived

		Await SocketListener.BindServiceNameAsync("21496")
	End Sub

	Private Async Sub ConnectionReceived(Sender As StreamSocketListener, Args As StreamSocketListenerConnectionReceivedEventArgs)
		Debug.WriteLine("Connection Received")

		Dim InputStream As Stream = Args.Socket.InputStream.AsStreamForRead()
		Dim Reader As New StreamReader(InputStream)
		Dim Request As String = Await Reader.ReadLineAsync()

		Debug.WriteLine(Request)
	End Sub
End Class
