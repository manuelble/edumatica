Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Edumatica

Namespace Controllers
    Public Class tdepartamentoesController
        Inherits System.Web.Mvc.Controller

        Private db As New EDUMATICAEntities

        ' GET: tdepartamentoes
        Function Index() As ActionResult
            Return View(db.tdepartamento.ToList())
        End Function

        ' GET: tdepartamentoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tdepartamento As tdepartamento = db.tdepartamento.Find(id)
            If IsNothing(tdepartamento) Then
                Return HttpNotFound()
            End If
            Return View(tdepartamento)
        End Function

        ' GET: tdepartamentoes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: tdepartamentoes/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,descripcion")> ByVal tdepartamento As tdepartamento) As ActionResult
            If ModelState.IsValid Then
                db.tdepartamento.Add(tdepartamento)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tdepartamento)
        End Function

        ' GET: tdepartamentoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tdepartamento As tdepartamento = db.tdepartamento.Find(id)
            If IsNothing(tdepartamento) Then
                Return HttpNotFound()
            End If
            Return View(tdepartamento)
        End Function

        ' POST: tdepartamentoes/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,descripcion")> ByVal tdepartamento As tdepartamento) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tdepartamento).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tdepartamento)
        End Function

        ' GET: tdepartamentoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tdepartamento As tdepartamento = db.tdepartamento.Find(id)
            If IsNothing(tdepartamento) Then
                Return HttpNotFound()
            End If
            Return View(tdepartamento)
        End Function

        ' POST: tdepartamentoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tdepartamento As tdepartamento = db.tdepartamento.Find(id)
            db.tdepartamento.Remove(tdepartamento)
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
