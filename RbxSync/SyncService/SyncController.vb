Imports System.Net
Imports Catnap.Server

<RoutePrefix("")>
Public Class SyncController
	Inherits Controller

	<HttpGet>
	<Route>
	Public Function [Get]() As HttpResponse
		Return New HttpResponse(HttpStatusCode.OK, "Testing")
	End Function
End Class