Imports System.Web.Mvc

Namespace Controllers
    Public Class mainController
        Inherits Controller

        ' GET: main
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace