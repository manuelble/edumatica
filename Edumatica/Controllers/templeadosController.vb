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
    Public Class templeadosController
        Inherits System.Web.Mvc.Controller

        Private db As New EDUMATICAEntities

        ' GET: templeados
        Function Index() As ActionResult
            Dim templeados = db.templeados.Include(Function(t) t.tdepartamento)
            Return View(templeados.ToList())
        End Function

        ' GET: templeados/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim templeados As templeados = db.templeados.Find(id)
            If IsNothing(templeados) Then
                Return HttpNotFound()
            End If
            Return View(templeados)
        End Function

        ' GET: templeados/Create
        Function Create() As ActionResult
            ViewBag.departamento_id = New SelectList(db.tdepartamento, "id", "descripcion")
            Return View()
        End Function

        ' POST: templeados/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,nombre,direccion,telefono,departamento_id")> ByVal templeados As templeados) As ActionResult
            If ModelState.IsValid Then
                db.templeados.Add(templeados)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.departamento_id = New SelectList(db.tdepartamento, "id", "descripcion", templeados.departamento_id)
            Return View(templeados)
        End Function

        ' GET: templeados/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim templeados As templeados = db.templeados.Find(id)
            If IsNothing(templeados) Then
                Return HttpNotFound()
            End If
            ViewBag.departamento_id = New SelectList(db.tdepartamento, "id", "descripcion", templeados.departamento_id)
            Return View(templeados)
        End Function

        ' POST: templeados/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,nombre,direccion,telefono,departamento_id")> ByVal templeados As templeados) As ActionResult
            If ModelState.IsValid Then
                db.Entry(templeados).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.departamento_id = New SelectList(db.tdepartamento, "id", "descripcion", templeados.departamento_id)
            Return View(templeados)
        End Function

        ' GET: templeados/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim templeados As templeados = db.templeados.Find(id)
            If IsNothing(templeados) Then
                Return HttpNotFound()
            End If
            Return View(templeados)
        End Function

        ' POST: templeados/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim templeados As templeados = db.templeados.Find(id)
            db.templeados.Remove(templeados)
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
