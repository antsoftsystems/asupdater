﻿'------------------------------------------------------------------------------
' <auto-generated>
'     O código foi gerado por uma ferramenta.
'     Versão de Tempo de Execução:4.0.30319.42000
'
'     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
'     o código for gerado novamente.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    'através de uma ferramenta como ResGen ou Visual Studio.
    'Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    'com a opção /str, ou recrie o projeto do VS.
    '''<summary>
    '''  Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ASUpdater.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Substitui a propriedade CurrentUICulture do thread atual para todas as
        '''  pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ASSUpdater() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ASSUpdater", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ASSUpdaterAbout() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ASSUpdaterAbout", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta uma cadeia de caracteres localizada semelhante a &lt;/div&gt;&lt;script src=&quot;https://code.jquery.com/jquery-3.3.1.slim.min.js&quot; integrity=&quot;sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo&quot; crossorigin=&quot;anonymous&quot;&gt;&lt;/script&gt;
        '''&lt;script src=&quot;https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js&quot; integrity=&quot;sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1&quot; crossorigin=&quot;anonymous&quot;&gt;&lt;/script&gt;
        '''&lt;script src=&quot;https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js&quot; integrity=&quot;sha384-JjSmVgyd0p3pXB [o restante da cadeia de caracteres foi truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property HTMLEnd() As String
            Get
                Return ResourceManager.GetString("HTMLEnd", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta uma cadeia de caracteres localizada semelhante a &lt;!DOCTYPE html&gt;&lt;html lang=&apos;pt-br&apos;&gt;&lt;head&gt; &lt;meta http-equiv=&apos;X-UA-Compatible&apos; content=&apos;IE=edge&apos;&gt;&lt;meta name=&apos;viewport&apos; content=&apos;width=device-width, initial-scale=1&apos;&gt;&lt;title&gt;AntSoft Systems On Demand&lt;/title&gt;
        '''&lt;link rel=&quot;stylesheet&quot; href=&quot;https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css&quot; integrity=&quot;sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T&quot; crossorigin=&quot;anonymous&quot;&gt;
        '''&lt;/head&gt;&lt;body&gt;&lt;div class=&quot;container mt-3&quot;&gt;.
        '''</summary>
        Friend ReadOnly Property HTMLStart() As String
            Get
                Return ResourceManager.GetString("HTMLStart", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
