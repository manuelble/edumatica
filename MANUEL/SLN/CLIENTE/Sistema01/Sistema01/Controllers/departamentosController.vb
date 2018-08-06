Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Sistema01

Namespace Controllers
    Public Class departamentosController
        Inherits System.Web.Mvc.Controller

        Private db As New BLEIXEntities1

        ' GET: departamentos
        Function Index() As ActionResult
            Return View(db.departamentos.ToList())
        End Function

        ' GET: departamentos/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim departamentos As departamentos = db.departamentos.Find(id)
            If IsNothing(departamentos) Then
                Return HttpNotFound()
            End If
            Return View(departamentos)
        End Function

        ' GET: departamentos/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: departamentos/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="iddepartamento,Descripcion")> ByVal departamentos As departamentos) As ActionResult
            If ModelState.IsValid Then
                db.departamentos.Add(departamentos)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(departamentos)
        End Function

        ' GET: departamentos/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim departamentos As departamentos = db.departamentos.Find(id)
            If IsNothing(departamentos) Then
                Return HttpNotFound()
            End If
            Return View(departamentos)
        End Function

        ' POST: departamentos/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="iddepartamento,Descripcion")> ByVal departamentos As departamentos) As ActionResult
            If ModelState.IsValid Then
                db.Entry(departamentos).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(departamentos)
        End Function

        ' GET: departamentos/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim departamentos As departamentos = db.departamentos.Find(id)
            If IsNothing(departamentos) Then
                Return HttpNotFound()
            End If
            Return View(departamentos)
        End Function

        ' POST: departamentos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim departamentos As departamentos = db.departamentos.Find(id)
            db.departamentos.Remove(departamentos)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
